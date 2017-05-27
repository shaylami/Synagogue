using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Synagogue_App
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Version();
            LicenseEndDate();
        }

        public void Version()
        {
            rtbVer.Text = "גרסא : 1.0.0.0";
            rtbHFVer.Text = "עדכון : 1.0.0.10";
            rtbAbout.Text = "כל הזכויות שמורות ל Info-sb.com, "
                + "אין להעתיק או להעביר ללא הסכמת החברה העבריין צפוי לשאת את העונשים הקבועים בחוק,"
                + " www.info-sb.com "
                + "טלפון:" + "8359554" + "-" + "052";
        }
        public void LicenseEndDate()
        {
            
            XmlDocument xmlDoc = new XmlDocument();
            CreateLicense cl = new CreateLicense();
            if (!File.Exists("License.xml"))
            {
                cl.BuildEncryptLicenseDate();
            }
            else
            {
                xmlDoc.Load("License.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/License/License");
                string license_id = "", license_Date = "";
                foreach (XmlNode node in nodeList)
                {
                    license_id = node.SelectSingleNode("License_id").InnerText;
                    license_Date = node.SelectSingleNode("License_Date").InnerText;
                }
                DecryptText(license_Date.ToString().Trim());
                string endDate = s1.ToString();
                lblEndLicDate.Text = "פקיעת תוקף רישיון :" + endDate;
            }
        }
        string s, s1;
        public void DecryptText(string strText)
        {
            s1 = Decrypt(strText, "!@#$%^&*()<>?/:;{}[]~`");
        }
        private string Decrypt(string strText, string sDecrKey)
        {
            byte[] byKey = null;
            byte[] IV = { 0X12, 0X34, 0X56, 0X78, 0X90, 0XAB, 0XCD, 0XEF };
            byte[] inputByteArray = new byte[strText.Length + 1];

            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(sDecrKey.Substring(0, 8));
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                inputByteArray = Convert.FromBase64String(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(byKey, IV), CryptoStreamMode.Write);

                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                System.Text.Encoding encoding = System.Text.Encoding.UTF8;


                s = encoding.GetString(ms.ToArray());
                return s;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
