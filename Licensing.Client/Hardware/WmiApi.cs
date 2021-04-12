using System.Collections.Generic;
using System.Management;
using System.Text;

namespace Licensing.Client.Hardware
{
    public class WmiApi
    {
        internal static List<WmiResponse> QueryWin32Class(string path)
        {
            var mc = new ManagementClass(path);
            return WmiResponse.FromCollection(mc.GetInstances());
        }

        internal static List<WmiResponse> SearchClass(string query)
        {
            var result = new ManagementObjectSearcher(query);
            return WmiResponse.FromCollection(result.Get());
        }

        internal static List<WmiResponse> QueryClass(string scope, string query)
        {
            var result = new ManagementObjectSearcher(scope, query);
            return WmiResponse.FromCollection(result.Get());
        }

        // Code by Simon Mourier, https://stackoverflow.com/a/65857067/14181760
        internal static string EscapeWql(string text)
        {
            if (text == null)
                return null;

            var sb = new StringBuilder(text.Length);
            foreach (var c in text)
            {
                if (c == '\\' || c == '\'' || c == '"')
                    sb.Append('\\');

                sb.Append(c);
            }
            return sb.ToString();
        }
    }
}
