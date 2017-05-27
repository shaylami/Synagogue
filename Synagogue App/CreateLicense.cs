using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Synagogue_App
{
    class CreateLicense
    {
        string d, d1;
        public void EncryptText(string strText)
        {
            d1 = Encrypt(strText, "!@#$%^&*()<>?/:;{}[]~`");
        }
        public string Encrypt(string strText, string strEncrKey)
        {
            byte[] byKey = null;
            byte[] IV = { 0X12, 0X34, 0X56, 0X78, 0X90, 0XAB, 0XCD, 0XEF };

            try
            {
                byKey = System.Text.Encoding.UTF8.GetBytes(strEncrKey.Substring(0, 8));

                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] inputByteArray = Encoding.UTF8.GetBytes(strText);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(byKey, IV), CryptoStreamMode.Write);
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();

                Convert.ToBase64String(ms.ToArray());
                d = Convert.ToBase64String(ms.ToArray());
                return d;
            }
            catch (Exception ex)
            {
                return ex.Message;
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


        /// <summary>
        /// create XML Node elment list
        /// </summary>
        /// <param name="LicID"></param>
        /// <param name="LicDate"></param>
        /// <param name="writer"></param>
        private void createNode(string LicID, string LicDate, XmlTextWriter writer)
        {
            writer.WriteStartElement("License");
            writer.WriteStartElement("License_id");
            writer.WriteString(LicID);
            writer.WriteEndElement();
            writer.WriteStartElement("License_Date");
            writer.WriteString(LicDate);
            writer.WriteEndElement();
        }
        public void BuildLicenseFile()
        {
            XmlTextWriter writer = new XmlTextWriter("License.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("License");
            createNode("1", "4JzSah7sWAtTTZrP5ef1GQ==", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        public void BuildEncryptLicenseDate()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("License.xml"))
            {
                BuildLicenseFile();
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
                string myDate = license_Date;
            }          
        }

    }

}
