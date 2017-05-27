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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
            checkUser();
        }
        /// <summary>
        /// create XML Node Tree
        /// </summary>
        /// <param name="pID">set User_id</param>
        /// <param name="pTime">set User_name</param>
        /// <param name="writer">wirte parmter into xml file</param>
        private void createNode(string pID, string pName, XmlTextWriter writer)
        {
            writer.WriteStartElement("Mange");
            writer.WriteStartElement("User_id");
            writer.WriteString(pID);
            writer.WriteEndElement();
            writer.WriteStartElement("User_name");
            writer.WriteString(pName);
            writer.WriteEndElement();
        }
        /// <summary>
        /// set parmters in PrayTimes1.xml
        /// </summary>
        public void AdminSet1()
        {
            XmlTextWriter writer = new XmlTextWriter("AL.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1","Admin", writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

        }
        private void checkUser()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("AL.xml"))
            {
                AdminSet1();
                //AdminLogin al = new AdminLogin();
                checkUser();
            }
            else
            {
                xmlDoc.Load("AL.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Mange");
                string Admin_id = "", Admin_name = "";
                foreach (XmlNode node in nodeList)
                {
                    Admin_id = node.SelectSingleNode("User_id").InnerText;
                    Admin_name = node.SelectSingleNode("User_name").InnerText;
                }
                 tbAdminUser.Text = Admin_name;
            }
        }
        private void CheckUserPass()
        {
            string Password = "l@mi";
            if (tbPassword.Text != Password)
            {
                MessageBox.Show("!!!!! מצטערים אנא בדוק שם משתמש או סיסמא");
                this.Hide();
            }
            else
            {
                HiloiNames hn = new HiloiNames();
                hn.Show();
                this.Hide();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CheckUserPass();
        }

    }
}
