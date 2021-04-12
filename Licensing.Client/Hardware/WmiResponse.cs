using System;
using System.Collections.Generic;
using System.Management;

namespace Licensing.Client.Hardware
{
    public class WmiResponse
    {
        readonly ManagementBaseObject ObjectCollection;

        public static List<WmiResponse> FromCollection(ManagementObjectCollection collection)
        {
            var list = new List<WmiResponse>();

            foreach (var managementObject in collection)
                list.Add(new WmiResponse(managementObject));

            return list;
        }

        public WmiResponse(ManagementBaseObject objectCollection)
        {
            ObjectCollection = objectCollection;
        }

        public T GetProperty<T>(string key)
        {
            try
            {
                return (T)Convert.ChangeType(ObjectCollection.GetPropertyValue(key) ?? default(T), typeof(T));
            }
            catch (System.Management.ManagementException)
            {
                return default(T);
            }
        }

        public Guid GetGuid(string key)
        {
            return new Guid(GetProperty<string>(key) ?? "00000000-0000-0000-0000-000000000000");
        }

        public DateTime GetDateTime(string key)
        {
            return ManagementDateTimeConverter.ToDateTime(GetProperty<string>(key) ?? "00010108141835.999999-420");
        }

        public object GetObject(string key)
        {
            return ObjectCollection.GetPropertyValue(key);
        }
    }
}
