using MetroFramework;
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
    public partial class PrayTimes : Form
    {
        public PrayTimes()
        {
            InitializeComponent();
            PrayTimesRead();

        }
/***************************************************************************************************************/
        /// <summary>
        /// create XML Node Tree
        /// </summary>
        /// <param name="pID">set Pray ID</param>
        /// <param name="pTime">set pray Time</param>
        /// <param name="writer">wirte parmter into xml file</param>
        private void createNode(string pID, string pName ,string pTime, XmlTextWriter writer)
        {
            writer.WriteStartElement("Pray");
            writer.WriteStartElement("Pray_id");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("PrayName");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteStartElement("PrayTime");
            writer.WriteString(pTime);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }
/**********************************************************************************************/
        /// <summary>
        /// set parmters in PrayTimes1.xml
        /// </summary>
        public void PraySet()
        {
            XmlTextWriter writer = new XmlTextWriter("PrayTimes.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1",tbPrayHead1.Text, tbPtime1.Text, writer);
            createNode("2", tbPrayHead2.Text, tbPtime2.Text, writer);
            createNode("3", tbPrayHead3.Text, tbPtime3.Text, writer);
            createNode("4", tbPrayHead4.Text, tbPtime4.Text, writer);
            createNode("5", tbPrayHead5.Text, tbPtime5.Text, writer);
            createNode("6", tbPrayHead6.Text, tbPtime6.Text, writer);
            createNode("7", tbPrayHead7.Text, tbPtime7.Text, writer);
            createNode("8", tbPrayHead8.Text, tbPtime8.Text, writer);
            createNode("9", tbPrayHead9.Text, tbPtime9.Text, writer);
            createNode("10", tbPrayHead10.Text, tbPtime10.Text, writer);
            createNode("11", tbPrayHead11.Text, tbPtime11.Text, writer);
            createNode("12", tbPrayHead12.Text, tbPtime12.Text, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            
        }
/***************************************************************************************************************/
        /// <summary>
        /// read PrayTime1.xml file and show the data it the label 
        /// </summary>
        private void PrayTimesRead()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("PrayTimes.xml"))
            {
                PraySet();
            }
            else
            {
                xmlDoc.Load("PrayTimes.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Pray");
                string PrayID = "", PrayName = "", PrayTime="";
                foreach (XmlNode node in nodeList)
                {
                    PrayID = node.SelectSingleNode("Pray_id").InnerText;
                    PrayName = node.SelectSingleNode("PrayName").InnerText;
                    PrayTime = node.SelectSingleNode("PrayTime").InnerText;
                    if (PrayID == "1")
                    {
                        tbPrayHead1.Text = PrayName;
                        tbPtime1.Text = PrayTime;
                    }
                    if (PrayID == "2")
                    {
                        tbPrayHead2.Text = PrayName;
                        tbPtime2.Text = PrayTime;
                    }
                    if (PrayID == "3")
                    {
                        tbPrayHead3.Text = PrayName;
                        tbPtime3.Text = PrayTime; ;
                    }
                    if (PrayID == "4")
                    {
                        tbPrayHead4.Text = PrayName;
                        tbPtime4.Text = PrayTime;
                    }
                    if (PrayID == "5")
                    {
                        tbPrayHead5.Text = PrayName;
                        tbPtime5.Text = PrayTime;
                    }
                    if (PrayID == "6")
                    {
                        tbPrayHead6.Text = PrayName;
                        tbPtime6.Text = PrayTime;
                    }
                    if (PrayID == "7")
                    {
                        tbPrayHead7.Text = PrayName;
                        tbPtime7.Text = PrayTime; ;
                    }
                    if (PrayID == "8")
                    {
                        tbPrayHead8.Text = PrayName;
                        tbPtime8.Text = PrayTime;
                    }
                    if (PrayID == "9")
                    {
                        tbPrayHead9.Text = PrayName;
                        tbPtime9.Text = PrayTime;
                    }
                    if (PrayID == "10")
                    {
                        tbPrayHead10.Text = PrayName;
                        tbPtime10.Text = PrayTime;
                    }
                    if (PrayID == "11")
                    {
                        tbPrayHead11.Text = PrayName;
                        tbPtime11.Text = PrayTime; ;
                    }
                    if (PrayID == "12")
                    {
                        tbPrayHead12.Text = PrayName;
                        tbPtime12.Text = PrayTime;
                    }
                }

            }

        }
/***************************************************************************************************************/
        private void btnUpdateAll_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("!!! שים לב שורות ללא שם ימחקו", "האם אתה בטוח", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                PraySet();              
                tbPrayHead1.Clear();
                tbPrayHead2.Clear();
                tbPrayHead3.Clear();
                tbPrayHead4.Clear();
                tbPrayHead5.Clear();
                tbPrayHead6.Clear();
                tbPrayHead7.Clear();
                tbPrayHead8.Clear();
                tbPrayHead9.Clear();
                tbPrayHead10.Clear();
                tbPrayHead11.Clear();
                tbPrayHead12.Clear();
                tbPtime1.Clear();
                tbPtime2.Clear();
                tbPtime3.Clear();
                tbPtime4.Clear();
                tbPtime5.Clear();
                tbPtime6.Clear();
                tbPtime7.Clear();
                tbPtime8.Clear();
                tbPtime9.Clear();
                tbPtime10.Clear();
                tbPtime11.Clear();
                tbPtime12.Clear();
                PrayTimesRead();
                MessageBox.Show("כל הזמנים עודכנו בהצלחה");
            }
            else if (dialogResult == DialogResult.No)
            {
                tbPrayHead1.Clear();
                tbPrayHead2.Clear();
                tbPrayHead3.Clear();
                tbPrayHead4.Clear();
                tbPrayHead5.Clear();
                tbPrayHead6.Clear();
                tbPrayHead7.Clear();
                tbPrayHead8.Clear();
                tbPrayHead9.Clear();
                tbPrayHead10.Clear();
                tbPrayHead11.Clear();
                tbPrayHead12.Clear();
                tbPtime1.Clear();
                tbPtime2.Clear();
                tbPtime3.Clear();
                tbPtime4.Clear();
                tbPtime5.Clear();
                tbPtime6.Clear();
                tbPtime7.Clear();
                tbPtime8.Clear();
                tbPtime9.Clear();
                tbPtime10.Clear();
                tbPtime11.Clear();
                tbPtime12.Clear();
                MessageBox.Show("כל הזמנים לא עודכנו ");
            }
        }
/***************************************************************************************************************/
    }
}
