using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Synagogue_App
{
    
    public partial class HiloiNames : Form
    {
        string Id = "0";
        string Name = "";

        public HiloiNames()
        {
            InitializeComponent();
            HiloiNamesRead();
        }

        private void btnUpdateHiloiNames_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("!!! שים לב שורות ללא שם ימחקו", "האם אתה בטוח", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                HiloiSet();

                tbHiloi1.Clear();
                tbHiloi2.Clear();
                tbHiloi3.Clear();
                tbHiloi4.Clear();
                tbHiloi5.Clear();
                tbHiloi6.Clear();
                tbHiloi7.Clear();
                tbHiloi8.Clear();
                tbHiloi9.Clear();
                tbHiloi10.Clear();
                tbHiloi11.Clear();
                tbHiloi12.Clear();
                tbHiloi13.Clear();
                tbHiloi14.Clear();
                tbHiloi15.Clear();
                tbHiloi16.Clear();
                tbHiloi17.Clear();
                tbHiloi18.Clear();
                tbHiloi19.Clear();
                tbHiloi20.Clear();
                tbHiloi21.Clear();
                tbHiloi22.Clear();
                tbHiloi23.Clear();
                tbHiloi24.Clear();
                tbHiloi25.Clear();
                tbHiloi26.Clear();
                tbHiloi27.Clear();
                tbHiloi28.Clear();
                tbHiloi29.Clear();
                tbHiloi30.Clear();
                tbHiloi31.Clear();
                tbHiloi32.Clear();
                tbHiloi33.Clear();
                tbHiloi34.Clear();
                MessageBox.Show("שמות הנפטרים עודכנו בהצלחה");
            }
            else if (dialogResult == DialogResult.No)
            {
                tbHiloi1.Clear();
                tbHiloi2.Clear();
                tbHiloi3.Clear();
                tbHiloi4.Clear();
                tbHiloi5.Clear();
                tbHiloi6.Clear();
                tbHiloi7.Clear();
                tbHiloi8.Clear();
                tbHiloi9.Clear();
                tbHiloi10.Clear();
                tbHiloi11.Clear();
                tbHiloi12.Clear();
                tbHiloi13.Clear();
                tbHiloi14.Clear();
                tbHiloi15.Clear();
                tbHiloi16.Clear();
                tbHiloi17.Clear();
                tbHiloi18.Clear();
                tbHiloi19.Clear();
                tbHiloi20.Clear();
                tbHiloi21.Clear();
                tbHiloi22.Clear();
                tbHiloi23.Clear();
                tbHiloi24.Clear();
                tbHiloi25.Clear();
                tbHiloi26.Clear();
                tbHiloi27.Clear();
                tbHiloi28.Clear();
                tbHiloi29.Clear();
                tbHiloi30.Clear();
                tbHiloi31.Clear();
                tbHiloi32.Clear();
                tbHiloi33.Clear();
                tbHiloi34.Clear();
                MessageBox.Show("שמות הנפטרים לא עודכנו ");
            }
        }
        /************************************************************************************/
        public void HiloiSet()
        {
            XmlTextWriter writer = new XmlTextWriter("HiloiNamesData.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1", tbHiloi1.Text, writer);
            createNode("2", tbHiloi2.Text, writer);
            createNode("3", tbHiloi3.Text, writer);
            createNode("4", tbHiloi4.Text, writer);
            createNode("5", tbHiloi5.Text, writer);
            createNode("6", tbHiloi6.Text, writer);
            createNode("7", tbHiloi7.Text, writer);
            createNode("8", tbHiloi8.Text, writer);
            createNode("9", tbHiloi9.Text, writer);
            createNode("10", tbHiloi10.Text, writer);
            createNode("11", tbHiloi11.Text, writer);
            createNode("12", tbHiloi12.Text, writer);
            createNode("13", tbHiloi13.Text, writer);
            createNode("14", tbHiloi14.Text, writer);
            createNode("15", tbHiloi15.Text, writer);
            createNode("16", tbHiloi16.Text, writer);
            createNode("17", tbHiloi17.Text, writer);
            createNode("18", tbHiloi18.Text, writer);
            createNode("19", tbHiloi19.Text, writer);
            createNode("20", tbHiloi20.Text, writer);
            createNode("21", tbHiloi12.Text, writer);
            createNode("22", tbHiloi22.Text, writer);
            createNode("23", tbHiloi23.Text, writer);
            createNode("24", tbHiloi24.Text, writer);
            createNode("25", tbHiloi25.Text, writer);
            createNode("26", tbHiloi26.Text, writer);
            createNode("27", tbHiloi27.Text, writer);
            createNode("28", tbHiloi28.Text, writer);
            createNode("29", tbHiloi29.Text, writer);
            createNode("30", tbHiloi30.Text, writer);
            createNode("31", tbHiloi31.Text, writer);
            createNode("32", tbHiloi32.Text, writer);
            createNode("33", tbHiloi33.Text, writer);
            createNode("34", tbHiloi34.Text, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
        /****************************************************************************************************/
        /// <summary>
        /// read HiloiNameData.xml file and show the data it the label 
        /// </summary>
        /// 
        private void HiloiNamesRead()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("HiloiNamesData.xml"))
            {
                HiloiSet();
            }
            else
            {
                xmlDoc.Load("HiloiNamesdata.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Hiloi");
                string HiloiID1 = "", HiloiName1 = "";
                foreach (XmlNode node in nodeList)
                {
                    HiloiID1 = node.SelectSingleNode("Hiloi_id").InnerText;
                    HiloiName1 = node.SelectSingleNode("Hiloi_name").InnerText;
                    if (HiloiID1 == "1")
                    {
                        tbHiloi1.Text = HiloiName1;
                    }
                    if (HiloiID1 == "2")
                    {
                        tbHiloi2.Text = HiloiName1;
                    }
                    if (HiloiID1 == "3")
                    {
                        tbHiloi3.Text = HiloiName1;
                    }
                    if (HiloiID1 == "4")
                    {
                        tbHiloi4.Text = HiloiName1;
                    }
                    if (HiloiID1 == "5")
                    {
                        tbHiloi5.Text = HiloiName1;
                    }
                    if (HiloiID1 == "6")
                    {
                        tbHiloi6.Text = HiloiName1;
                    }
                    if (HiloiID1 == "7")
                    {
                        tbHiloi7.Text = HiloiName1;
                    }
                    if (HiloiID1 == "8")
                    {
                        tbHiloi8.Text = HiloiName1;
                    }
                    if (HiloiID1 == "9")
                    {
                        tbHiloi9.Text = HiloiName1;
                    }
                    if (HiloiID1 == "10")
                    {
                        tbHiloi10.Text = HiloiName1;
                    }
                    if (HiloiID1 == "11")
                    {
                        tbHiloi11.Text = HiloiName1;
                    }
                    if (HiloiID1 == "12")
                    {
                        tbHiloi12.Text = HiloiName1;
                    }
                    if (HiloiID1 == "13")
                    {
                        tbHiloi13.Text = HiloiName1;
                    }
                    if (HiloiID1 == "14")
                    {
                        tbHiloi14.Text = HiloiName1;
                    }
                    if (HiloiID1 == "15")
                    {
                        tbHiloi15.Text = HiloiName1;
                    }
                    if (HiloiID1 == "16")
                    {
                        tbHiloi16.Text = HiloiName1;
                    }
                    if (HiloiID1 == "17")
                    {
                        tbHiloi17.Text = HiloiName1;
                    }
                    if (HiloiID1 == "18")
                    {
                        tbHiloi18.Text = HiloiName1;
                    }
                    if (HiloiID1 == "19")
                    {
                        tbHiloi19.Text = HiloiName1;
                    }
                    if (HiloiID1 == "20")
                    {
                        tbHiloi20.Text = HiloiName1;
                    }
                    if (HiloiID1 == "21")
                    {
                        tbHiloi21.Text = HiloiName1;
                    }
                    if (HiloiID1 == "22")
                    {
                        tbHiloi22.Text = HiloiName1;
                    }
                    if (HiloiID1 == "23")
                    {
                        tbHiloi23.Text = HiloiName1;
                    }
                    if (HiloiID1 == "24")
                    {
                        tbHiloi24.Text = HiloiName1;
                    }
                    if (HiloiID1 == "25")
                    {
                        tbHiloi25.Text = HiloiName1;
                    }
                    if (HiloiID1 == "26")
                    {
                        tbHiloi26.Text = HiloiName1;
                    }
                    if (HiloiID1 == "27")
                    {
                        tbHiloi27.Text = HiloiName1;
                    }
                    if (HiloiID1 == "28")
                    {
                        tbHiloi28.Text = HiloiName1;
                    }
                    if (HiloiID1 == "29")
                    {
                        tbHiloi29.Text = HiloiName1;
                    }
                    if (HiloiID1 == "30")
                    {
                        tbHiloi30.Text = HiloiName1;
                    }
                    if (HiloiID1 == "31")
                    {
                        tbHiloi31.Text = HiloiName1;
                    }
                    if (HiloiID1 == "32")
                    {
                        tbHiloi32.Text = HiloiName1;
                    }
                    if (HiloiID1 == "33")
                    {
                        tbHiloi33.Text = HiloiName1;
                    }
                    if (HiloiID1 == "34")
                    {
                        tbHiloi34.Text = HiloiName1;
                    }
                }
            }

        }

/*******************************************************************************************/
        /// <summary>
        /// bulding xml file 
        /// </summary>
        /// <param name="pID">Person ID</param>
        /// <param name="pName">Person Name</param>
        /// <param name="writer">write into file</param>
        private void createNode(string pID, string pName, XmlTextWriter writer)
        {
            writer.WriteStartElement("Hiloi");
            writer.WriteStartElement("Hiloi_id");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("Hiloi_name");
            writer.WriteString(pName);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

    }
}
