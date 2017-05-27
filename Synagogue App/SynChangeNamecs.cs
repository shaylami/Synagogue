using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Synagogue_App
{
    public partial class SynChangeNamecs : Form
    {

        public SynChangeNamecs()
        {
            InitializeComponent();
            showSynName();
        }

        public void SetAppSynName()
        {
            XmlTextWriter writer = new XmlTextWriter("SynName.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1", textBoxSynNewName.Text, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
        private void createNode(string pID, string SynName, XmlTextWriter writer)
        {
            writer.WriteStartElement("SynAppName");
            writer.WriteStartElement("SynApp_id");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("SynName");
            writer.WriteString(SynName);
            writer.WriteEndElement();
        }

        private void btnSetSynName_Click(object sender, EventArgs e)
        {
            SetAppSynName();
            textBoxSynNewName.Clear();
            showSynName();
            MessageBox.Show("שם בית הכנסת עודכן");
        }

        private void showSynName()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("SynName.xml"))
            {
                SetAppSynName();
            }
            else
            {
                xmlDoc.Load("SynName.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/SynAppName");
                string SynID1 = "", SynName1 = "";
                foreach (XmlNode node in nodeList)
                {
                    SynID1 = node.SelectSingleNode("SynApp_id").InnerText;
                    SynName1 = node.SelectSingleNode("SynName").InnerText;
                }
                textBoxSynNewName.Text = SynName1;
            }
        }
    }
}
