using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Synagogue_App
{
    public partial class Parnas : Form
    {
        public Parnas()
        {
            InitializeComponent();
            ShowParnas();
        }
/***************************************************************************************************************/
        private void ShowParnas()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("parnas.xml"))
            {
                parnas();
            }
            else
            {
                xmlDoc.Load("parnas.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Parnas");
                string Parnas_id1 = "", Parnas_name1 = "";
                foreach (XmlNode node in nodeList)
                {
                    Parnas_id1 = node.SelectSingleNode("Parnas_id").InnerText;
                    Parnas_name1 = node.SelectSingleNode("Parnas_name").InnerText;
                    if(Parnas_id1 == "1")
                    {
                        tbParans1.Text = Parnas_name1;
                    }
                    if(Parnas_id1 == "2")
                    {
                        tbParans2.Text = Parnas_name1;
                    }
                    if(Parnas_id1 == "3")
                    {
                        tbParans3.Text = Parnas_name1;
                    }
                    if(Parnas_id1 == "4")
                    {
                        tbParans4.Text = Parnas_name1;
                    }
                }
                

            }
        }

/***************************************************************************************************************/
        private void btnSaveParnas_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("!!! שים לב שורות ללא שם ימחקו", "האם אתה בטוח", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                parnas();
                tbParans1.Clear();
                tbParans2.Clear();
                tbParans3.Clear();
                tbParans4.Clear();
                ShowParnas();
                MessageBox.Show("שמות הפרנס נשמרו בהצלחה");
            }
            else if (dialogResult == DialogResult.No)
            {
                tbParans1.Clear();
                tbParans2.Clear();
                tbParans3.Clear();
                tbParans4.Clear();
                MessageBox.Show("שמות הפרנס לא נשמרו ");
            }
        }
/***************************************************************************************************************/
        public void parnas()
        {
            XmlTextWriter writer = new XmlTextWriter("parnas.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1",tbParans1.Text, writer);
            createNode("2",tbParans2.Text, writer);
            createNode("3",tbParans3.Text, writer);
            createNode("4",tbParans4.Text, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            
        }
/***************************************************************************************************************/
        private void createNode(string pID, string pName, XmlTextWriter writer)
        {
            writer.WriteStartElement("Parnas");
            writer.WriteStartElement("Parnas_id");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Parnas_name");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
