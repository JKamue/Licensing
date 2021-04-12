using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Licensing.Client.Hardware;

namespace Licensing.Client
{
    public partial class Form1 : Form
    {
        private const string PublicKey = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<RSAParameters xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Exponent>AQAB</Exponent>\r\n  <Modulus>3271CiMyYH+l+obrsPEkJYkQc3LCjEGzOP1rdFKrwZp1NvwKMwgPLttPVlyX2zLOTLGu13a2E3Ua+fNulIHLeSG+0wxF0291Tb5a8cNA7nvTFpLQO9H3AWhjTFhkD+W9qTZUWX9KHYpnAVsKXjcVD2WOWUhm7HHSZUHPyTykewzDSgfapxpbJ1EbFH4g9Lq2ntM7cKq7bklaZ1PTYWvGsbYiIBHsfMSlNVlw20KtIAFWfEEgLmvjfvp/kV44NzJ52AhASpN7Olr847LpxXDoH19OyXyn4Ic4TqfXUgMygm0qHnWMnft6BhLpwIp6uGXKcm10KwR0WrRjjIKJ7fqYMpl73iLbXtxH8bEQZGA13FPkq6MsX5dAXk2EA6XSeOtiiC/oOykzvLg5bKfrGKlJr8gkqJs7a7hbVsVHsIJiJ0wsooC+k3HXkMmsRUhuwbZNfOO4OSabb32edBCiMoTIRlGL5N0PfNyBzpXzfIxaF/rREl0PAT6Ib0Ui2jKtypHTQGJzi8nOmunO54/kOMjrNgxxZoDa7oTINavFfaLzUHWy+vI9HSIvK0QkX7zIveW7aLGme/6PSIuCLdJl5/c1+mfaDufMNveeNJQy2DZzjd1uZWSu9QqC6deWlU3lAeKg1vYynwLp2mKKhVCWCWxXyZqNNIxmc+AW62hpibknEkk=</Modulus>\r\n</RSAParameters>";

        public Form1()
        {
            InitializeComponent();
            var id = HardwareId.GenerateHardwareId(trvHardware);
            lblHardwareOutput.Text = id;
        }

        private byte[] GetBytes(string str)
        {
            return Encoding.ASCII.GetBytes(str);
        }

        private void btnVerifyLicense_Click(object sender, EventArgs e)
        {
            try
            {
                var sr = new StringReader(PublicKey);
                var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
                var publicKey = (RSAParameters) xs.Deserialize(sr);

                RSACryptoServiceProvider RSAalg = new RSACryptoServiceProvider(4096);
                RSAalg.ImportParameters(publicKey);
                var test = RSAalg.VerifyData(GetBytes(lblHardwareOutput.Text), SHA256.Create(),
                    Convert.FromBase64String(tbxLicense.Text));


                if (test)
                {
                    lblLicenseOutput.Text = "OK";
                }
                else
                {
                    lblLicenseOutput.Text = "nope";
                }
            }
            catch (Exception ex)
            {
                lblLicenseOutput.Text = ex.Message;
            }
        }
    }
}
