using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Synagogue_App
{
    class LicenseParmter
    {

        private void createNode(string pID, string pDate, XmlTextWriter writer)
        {
            writer.WriteStartElement("Parmter");
            writer.WriteStartElement("Parmter_id");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Parmter_Date");
            writer.WriteString(pDate);
            writer.WriteEndElement();
        }
        public void parmater()
        {
            string datestrformat = ("dd/MM/yyyy");
            string UpDate = DateTime.Now.ToString(datestrformat);
            XmlTextWriter writer = new XmlTextWriter("Parmter.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1",UpDate, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
        /*
        public void ReadParmter()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("Parmter.xml"))
            {
                parmater();
            }
            else
            {
                xmlDoc.Load("Parmter.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Parmter");
                string pID = "", pDate = "";
                foreach (XmlNode node in nodeList)
                {
                    pID = node.SelectSingleNode("Parmter_id").InnerText;
                    pDate = node.SelectSingleNode("Parmter_Date").InnerText;
                }
                 string parmterDate = pDate;
            }
        }
         */

    }
}
