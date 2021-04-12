using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Licensing.Licenser
{
    public partial class Form1 : Form
    {
        private const string PrivateKey = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<RSAParameters xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <Exponent>AQAB</Exponent>\r\n  <Modulus>3271CiMyYH+l+obrsPEkJYkQc3LCjEGzOP1rdFKrwZp1NvwKMwgPLttPVlyX2zLOTLGu13a2E3Ua+fNulIHLeSG+0wxF0291Tb5a8cNA7nvTFpLQO9H3AWhjTFhkD+W9qTZUWX9KHYpnAVsKXjcVD2WOWUhm7HHSZUHPyTykewzDSgfapxpbJ1EbFH4g9Lq2ntM7cKq7bklaZ1PTYWvGsbYiIBHsfMSlNVlw20KtIAFWfEEgLmvjfvp/kV44NzJ52AhASpN7Olr847LpxXDoH19OyXyn4Ic4TqfXUgMygm0qHnWMnft6BhLpwIp6uGXKcm10KwR0WrRjjIKJ7fqYMpl73iLbXtxH8bEQZGA13FPkq6MsX5dAXk2EA6XSeOtiiC/oOykzvLg5bKfrGKlJr8gkqJs7a7hbVsVHsIJiJ0wsooC+k3HXkMmsRUhuwbZNfOO4OSabb32edBCiMoTIRlGL5N0PfNyBzpXzfIxaF/rREl0PAT6Ib0Ui2jKtypHTQGJzi8nOmunO54/kOMjrNgxxZoDa7oTINavFfaLzUHWy+vI9HSIvK0QkX7zIveW7aLGme/6PSIuCLdJl5/c1+mfaDufMNveeNJQy2DZzjd1uZWSu9QqC6deWlU3lAeKg1vYynwLp2mKKhVCWCWxXyZqNNIxmc+AW62hpibknEkk=</Modulus>\r\n  <P>9D75v8gcMko54ZDhGKbP0mnqzVW7Q5PlAn2ofVGnKg45aiMKMsUr3ErbQ3bZ8RUMvQFGcsEyt5r2p1nO79qEHZw9TI20GQ7VnJLCs/8w5hzwKMv515U7GrQFG9DoC2NinpIfNUqIoe+6OP4YrT+IzAa1o8qDwxq7WwAyzLhQYXMSwRFDsWIm86qcq75tmHRWbwkGN+8K17XZOwkCMH4rQsVEvYgJ+mzxBlU/8q7gmPhCazXqvlmyB0g9B84OVYSYV/jVJLvc/dGsXREg4c9sDImmvhUKlXVe5dAssTS6dd7Z5uHCbLEIHBG5HwqVsusJCY5zVOFmM8sZpZB1HDz1tw==</P>\r\n  <Q>6i+T/GmEIUgmt/tTpOhF5XzEI5ZBRQGZT2DvTZD5NisgWsZBMh5PeRCxcbTNRout4xZ1288UbnQHlGziB5vwLSgHyQiQWflsMpvKlw38++fw6vbbAY43JJggyS68VZSoJB5rLhK7JOjtZLDVjCPP0SZDf9SCSKiQ940u+fAjqeEspULcGAI6LaXftRZialzJtfdAv+zJv0Yope2Qb1Oo+kX7dUCtmri7xfTd184jUmDQ+jeW7xjKbpVAO9LonWDBy5Ew4d6BbYDmrJ7JX9brHIwglqYdYdhJa2XXObHBV8ofVWJ9DRKReSr+suaevdpJshhm3o5pTOtVlocxXXw3/w==</Q>\r\n  <DP>u6C5KPuntXZR2pb6ZH6YvbJB/vUyAyrUzUIMsiCMwwDkWEWMqw3OsM8Me1oM+GdMPtGA9dy2gldXzZ1vG9CIl1qTuIBO7sT3ke0oBzAtt0hZsW1og5UPL2dFWWX1K/JwKxJjSQP1zDilnOyNtmFNTDaHSMjkyXd6n+CaJawdi47jxE7n6pdVBvB0pHaIKIqOb4PGNCe885Ktyu0Tsn7p6sQyF0svJyKTUWMh2eM/hCOKmmNz7kBnQ7LZt2oylr1iboon6q0qig2NVH04/l7iSQthfToaxE/C09ZEzuiLqMrGJ9gcDHU+npl61X7DGwv1CFNXA8iXQ4htLkO3wzaNJw==</DP>\r\n  <DQ>wHBEbSDQAQFnP7x5KYPtG/2At7WbAPelYcNIIjdFcqvRtIZBwMuDhvqetc9a9+OECp3ET9JE+dbC+8bVnmcX4COK8jnlVOpPbO70dVh7UQ1xvcMIiKiyy5FvL6MGBFVaLgQJEx01R8lYemuNr9ElzrpgsUSRot9R8PrFZYFd7RUqOMtOTTRXVnd98zLnwHtrDeqV/KC50EH42RD0pWbb7n1feyShBAlV0/+55MJx6BnC4DqZ/vQiNOjUldRkbh66YWt3/cN4G+HWrHb3B5h2L0k+5kyuzF6NRoGzcKePN3LSeLmsBPgDLsyT67LzMxOTh5PhxHTGNv0TodSKTkXrRQ==</DQ>\r\n  <InverseQ>qxTrxqbMUGMRVuCNVYSkPxYkFMChdxDEKzXr464FHi/vAWVbpL9gu4DwXNEfTQ+iz5oRlUbUar/qSDvgiKvZefwG1AvIoaMIGZ7n6svRUwn2RyhajEsvdL1K60Gvy45SbZU8XhEtspbFZZpE8z+gOgd7QLetY9ZOG9fhw87/9yD9R9V96T82VSaTOLuqTc7rhDFl72qsUE4/Jx5dKCVohbaFB4zsoT9hrQQGiXfNFdfedwBD3DWSTPPfefMK78ktdx9Q6xmb9EwxJpHPaq2QvMXeGMUbn4C9/pPiQRBhohMIuN/IZkQzE9yqy3tVKvbFinne4vfTHJKGOelC5NWhPg==</InverseQ>\r\n  <D>r+h+mW2eguTcu0IwG42upLKltg765kvvm4XBbMKNoQ5HDHQgX48PzRcy/k5F7HiyfSVC/zXiIa2IAJPMUrVhicusniJCczWESCH/HepYm6n3RgVuVjp3Wq9hxkCs/uskiC1S+WdC5cEKWcHghs6dERMmoFplVfBC8h9/RPMumAYzVnyahAc3DtxHEro+ng7GKoMpgAmbKTgtKb6QZFnjBBTeBxu1cYGshDUXqjhzbwg+m/L2MDYW1OjJOJzSa3qc/R156Hz2froV8frxG9ZJmjGCKRWwYhBzn1F7L4F+6bqid3qaq+LKbi/DwygDeFwDqFVOKXQHW0Y8PeqkRy2NVohd8hfxuiWNtV6rXomS/jjgHWwFTzfEBjXsRd8ICBd/46Cvd/u6J9B72I4YdWtD10eh7QRrlY5s9yPC4O3xpWwNS8dK4+6vLoH+KrYddbKjO7DdhQuM1V+UkyC9iWTe05UkU7YOP+0y0JCUAO2GgKFrycQzyrRtCpesYDPDfBzFrvPQlUo6V6XnCeHyIs4cyXP+1xIXrcVPiNM6V0KOwWsletyy+iSw/dXEizkEr7ZWZsts7H6hynebwrmUiiCYjaVa0bLieJf0D4mqjUe3rUMNpdvvWVyvCBiQvMYQl2W4w+NXrfWfnVNF1uzHPzuVU2soNqdl/4FryDdofR56GYU=</D>\r\n</RSAParameters>";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            var sr = new StringReader(PrivateKey);
            var xs = new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            var privateKey = (RSAParameters) xs.Deserialize(sr);

            var csp = new RSACryptoServiceProvider(4096);
            csp.ImportParameters(privateKey);
            var id = tbxHardwareId.Text;
            var bytesPlainTextData = Encoding.ASCII.GetBytes(id);
            var bytesCypherText = csp.SignData(bytesPlainTextData, SHA256.Create());
            var cypherText = Convert.ToBase64String(bytesCypherText);
            lblOutput.Text = cypherText;
        }
    }
}
