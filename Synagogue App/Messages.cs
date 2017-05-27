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
    public partial class Messages : Form
    {
        public Messages()
        {
            InitializeComponent();
            ShowMsg();
        }
        /**********************************************************************************/
        private void createNode(string MsgID, string MsgTxt, XmlTextWriter writer)
        {
            writer.WriteStartElement("Messages");
            writer.WriteStartElement("Msg_id");
            writer.WriteString(MsgID);
            writer.WriteEndElement();
            writer.WriteStartElement("Msg_Text");
            writer.WriteString(MsgTxt);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
        /**********************************************************************************/
        public void Msg()
        {
            XmlTextWriter writer = new XmlTextWriter("Msg.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1",tbMsg1.Text, writer);
            createNode("2", tbMsg2.Text, writer);
            createNode("3", tbMsg3.Text, writer);
            createNode("4", tbMsg4.Text, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
        /**********************************************************************************/
        private void ShowMsg()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("Msg.xml"))
            {
                Msg();
            }
            else
            {
                xmlDoc.Load("Msg.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Messages");
                string Msg_id1 = "", MsgTxt1 = "";
                foreach (XmlNode node in nodeList)
                {
                    Msg_id1 = node.SelectSingleNode("Msg_id").InnerText;
                    MsgTxt1 = node.SelectSingleNode("Msg_Text").InnerText;
                    if(Msg_id1 == "1")
                    {
                        tbMsg1.Text = MsgTxt1;
                    }
                    if(Msg_id1 == "2")
                    {
                        tbMsg2.Text = MsgTxt1;
                    }
                    if(Msg_id1 == "3")
                    {
                        tbMsg3.Text = MsgTxt1;
                    }
                    if(Msg_id1 == "4")
                    {
                        tbMsg4.Text = MsgTxt1;
                    }
                }
                
            }
        }
        /**********************************************************************************/

        private void btnUpdateMsg1_Click_1(object sender, EventArgs e)
        {
            Msg();
            tbMsg1.Clear();
            tbMsg2.Clear();
            tbMsg3.Clear();
            tbMsg4.Clear();
            ShowMsg();
            MessageBox.Show("ההודעה עודכנה בהצלחה");
        }
    }
}
