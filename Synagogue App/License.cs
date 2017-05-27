using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Synagogue_App
{
    public partial class License : Form
    {
        public License()
        {
            InitializeComponent();
        }
        /// <summary>
        /// create license node for xml
        /// </summary>
        /// <param name="LicID"></param>
        /// <param name="LicDate"></param>
        /// <param name="writer"></param>
        private void createLicenseNode(string LicID, string LicDate, XmlTextWriter writer)
        {
            writer.WriteStartElement("License");
            writer.WriteStartElement("License_id");
            writer.WriteString(LicID);
            writer.WriteEndElement();
            writer.WriteStartElement("License_Date");
            writer.WriteString(LicDate);
            writer.WriteEndElement();
        }
        /// <summary>
        /// build xml file with data from text box
        /// </summary>
        public void updateLicense()
        {
            XmlTextWriter writer = new XmlTextWriter("License.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("License");
            createLicenseNode("1",tbLicKey.Text, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
            
        }
        /*******************************************************************************************/
        private void btnUpdateKey_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace (tbLicKey.Text) )
            {
                MessageBox.Show("הזן קוד רישוי");
            }
            else
            {
                updateLicense();
                tbLicKey.Clear();
                MessageBox.Show("הרישיון עודכן בהצלחה");
                Application.Restart();
            }

        }
    }
}
