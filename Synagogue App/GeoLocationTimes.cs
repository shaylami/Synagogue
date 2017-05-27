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
using Zmanim;
using Zmanim.TimeZone;
using Zmanim.TzDatebase;

namespace Synagogue_App
{
    public partial class GeoLocationTimes : Form
    {
        public GeoLocationTimes()
        {
            InitializeComponent();
            ShowCurrentGeoLocation();
        }


        private void createNode(string GeoID, string GeoLocationName, string latitude, string longitude, string elevation, XmlTextWriter writer)
        {
            writer.WriteStartElement("Geo");
            writer.WriteStartElement("Geo_Id");
            writer.WriteString(GeoID);
            writer.WriteEndElement();
            writer.WriteStartElement("Geo_Location_Name");
            writer.WriteString(GeoLocationName);
            writer.WriteEndElement();
            writer.WriteStartElement("Latitude");
            writer.WriteString(latitude);
            writer.WriteEndElement();
            writer.WriteStartElement("Longitude");
            writer.WriteString(longitude);
            writer.WriteEndElement();
            writer.WriteStartElement("Elevation");
            writer.WriteString(elevation);
            writer.WriteEndElement();
        }

        public void CreateFirstGeoLocationXML()
        {
            XmlTextWriter writer = new XmlTextWriter("GeoLocation.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            createNode("1", "Location", "50", "50", "50", writer);
            //createNode("1", tbLocation.Text, tbLatitude.Text, tbLongitude.Text, tbElevation.Text, writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        public void SetGeoLocation()
        {
            XmlTextWriter writer = new XmlTextWriter("GeoLocation.xml", System.Text.Encoding.UTF8);
            writer.WriteStartDocument(true);
            writer.Formatting = Formatting.Indented;
            writer.Indentation = 2;
            writer.WriteStartElement("Table");
            //createNode("1", "Location", "Latitude", "Longitude", "Elevation", writer);
            createNode("1",tbLocation.Text,tbLatitude.Text,tbLongitude.Text,tbElevation.Text,writer);
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }

        public void ShowCurrentGeoLocation()
            
        {

            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("GeoLocation.xml"))
            {
                SetGeoLocation();
            }
            else
            {
                xmlDoc.Load("GeoLocation.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Geo");
                string GeoID = "", GeoLocationName = "", latitude = "", longitude = "", elevation = "";
                foreach (XmlNode node in nodeList)
                {
                    GeoID = node.SelectSingleNode("Geo_Id").InnerText;
                    GeoLocationName = node.SelectSingleNode("Geo_Location_Name").InnerText;
                    latitude = node.SelectSingleNode("Latitude").InnerText;
                    longitude = node.SelectSingleNode("Longitude").InnerText;
                    elevation = node.SelectSingleNode("Elevation").InnerText;
                }
                tbLocation.Text = GeoLocationName;
                tbLatitude.Text = latitude;
                tbLongitude.Text = longitude;
                tbElevation.Text = elevation;
                //lblLocation.Text = GeoLocationName;
                //lblLatitude.Text = latitude;
                //lblLongitude.Text = longitude;
                //lblElevation.Text = elevation;
            }
             
        }

      
        private void btnUpdateGeolocation_Click(object sender, EventArgs e)
        {
            SetGeoLocation();
            tbLocation.Clear();
            tbLatitude.Clear();
            tbLongitude.Clear();
            tbElevation.Clear();
            ShowCurrentGeoLocation();
            MessageBox.Show("עדכון מיקום גאוגראפי עודכן בהצלחה");
        }
    }
}
