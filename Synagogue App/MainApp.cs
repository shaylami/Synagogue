using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Zmanim.TimeZone;
using Zmanim.TzDatebase;
using Zmanim.Utilities;
using Zmanim;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Threading;
using NUnit.Framework;
using Synagogue_App;
using System.Security.Cryptography;
using System.Timers;
using System.Diagnostics;
using System.Reflection;
using Synagogue_App.Properties;
using System.Resources;

namespace Synagogue_App
{
    public partial class FormMain : Form
    {
        static System.Windows.Forms.Timer theTimer = new System.Windows.Forms.Timer();
        public int alarmCounter = 0;

        public FormMain()
        {
            InitializeComponent();
            Load_Other();
        }
        /****************************************************************************************/
        private void Load_Other()
        {
            synName();
            showDate();
            ShowHebDate();
            ShowDay();
            LocationTimes();
            HiloiNamesRead();
            PrayTimesRead();
            readParansXML();
            ShowMsg();
            TradeMark();
            //CheckLicenseParamter();
            showLayoutEmpty();
            licenseParmter();
            isfriday();
            ChangeDisplaySize();
            ScrrenTimer();
            CheckRoshHodesh();
            Pharsha();
            Daf();
            Hagim();
            FullScreenMode();
        }
        private void HiloiNamesRead()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("HiloiNamesData.xml"))
            {
                HiloiNames hn = new HiloiNames();
                hn.HiloiSet();
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
                        lblHiloi1.Text = HiloiName1;
                    }
                    if (HiloiID1 == "2")
                    {
                        lblHiloi2.Text = HiloiName1;
                    }
                    if (HiloiID1 == "3")
                    {
                        lblHiloi3.Text = HiloiName1;
                    }
                    if (HiloiID1 == "4")
                    {
                        lblHiloi4.Text = HiloiName1;
                    }
                    if (HiloiID1 == "5")
                    {
                        lblHiloi5.Text = HiloiName1;
                    }
                    if (HiloiID1 == "6")
                    {
                        lblHiloi6.Text = HiloiName1;
                    }
                    if (HiloiID1 == "7")
                    {
                        lblHiloi7.Text = HiloiName1;
                    }
                    if (HiloiID1 == "8")
                    {
                        lblHiloi8.Text = HiloiName1;
                    }
                    if (HiloiID1 == "9")
                    {
                        lblHiloi9.Text = HiloiName1;
                    }
                    if (HiloiID1 == "10")
                    {
                        lblHiloi10.Text = HiloiName1;
                    }
                    if (HiloiID1 == "11")
                    {
                        lblHiloi11.Text = HiloiName1;
                    }
                    if (HiloiID1 == "12")
                    {
                        lblHiloi12.Text = HiloiName1;
                    }
                    if (HiloiID1 == "13")
                    {
                        lblHiloi13.Text = HiloiName1;
                    }
                    if (HiloiID1 == "14")
                    {
                        lblHiloi14.Text = HiloiName1;
                    }
                    if (HiloiID1 == "15")
                    {
                        lblHiloi15.Text = HiloiName1;
                    }
                    if (HiloiID1 == "16")
                    {
                        lblHiloi16.Text = HiloiName1;
                    }
                    if (HiloiID1 == "17")
                    {
                        lblHiloi17.Text = HiloiName1;
                    }
                    if (HiloiID1 == "18")
                    {
                        lblHiloi18.Text = HiloiName1;
                    }
                    if (HiloiID1 == "19")
                    {
                        lblHiloi19.Text = HiloiName1;
                    }
                    if (HiloiID1 == "20")
                    {
                        lblHiloi20.Text = HiloiName1;
                    }
                    if (HiloiID1 == "21")
                    {
                        lblHiloi21.Text = HiloiName1;
                    }
                    if (HiloiID1 == "22")
                    {
                        lblHiloi22.Text = HiloiName1;
                    }
                    if (HiloiID1 == "23")
                    {
                        lblHiloi23.Text = HiloiName1;
                    }
                    if (HiloiID1 == "24")
                    {
                        lblHiloi24.Text = HiloiName1;
                    }
                    if (HiloiID1 == "25")
                    {
                        lblHiloi25.Text = HiloiName1;
                    }
                    if (HiloiID1 == "26")
                    {
                        lblHiloi26.Text = HiloiName1;
                    }
                    if (HiloiID1 == "27")
                    {
                        lblHiloi27.Text = HiloiName1;
                    }
                    if (HiloiID1 == "28")
                    {
                        lblHiloi28.Text = HiloiName1;
                    }
                    if (HiloiID1 == "29")
                    {
                        lblHiloi29.Text = HiloiName1;
                    }
                    if (HiloiID1 == "30")
                    {
                        lblHiloi30.Text = HiloiName1;
                    }
                    if (HiloiID1 == "31")
                    {
                        lblHiloi31.Text = HiloiName1;
                    }
                    if (HiloiID1 == "32")
                    {
                        lblHiloi32.Text = HiloiName1;
                    }
                    if (HiloiID1 == "33")
                    {
                        lblHiloi33.Text = HiloiName1;
                    }
                    if (HiloiID1 == "34")
                    {
                        lblHiloi34.Text = HiloiName1;
                    }
                }
            }

        }
        
        /********************************************************************************************/
        /// <summary>
        /// read PrayTime1.xml file and show the data it the label 
        /// </summary>
        private void PrayTimesRead()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("PrayTimes.xml"))
            {
                PrayTimes pt = new PrayTimes();
                pt.PraySet();
            }
            else
            {
                xmlDoc.Load("PrayTimes.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Pray");
                string PrayID = "", PrayName = "", PrayTime = "";
                foreach (XmlNode node in nodeList)
                {
                    PrayID = node.SelectSingleNode("Pray_id").InnerText;
                    PrayName = node.SelectSingleNode("PrayName").InnerText;
                    PrayTime = node.SelectSingleNode("PrayTime").InnerText;
                    if (PrayID == "1")
                    {
                        lblPrayTimes1.Text = PrayName;
                        lblPrayTimes1_1.Text = PrayTime;
                    }
                    if (PrayID == "2")
                    {
                        lblPrayTimes2.Text = PrayName;
                        lblPrayTimes2_2.Text = PrayTime;
                    }
                    if (PrayID == "3")
                    {
                        lblPrayTimes3.Text = PrayName;
                        lblPrayTimes3_3.Text = PrayTime; ;
                    }
                    if (PrayID == "4")
                    {
                        lblPrayTimes4.Text = PrayName;
                        lblPrayTimes4_4.Text = PrayTime;
                    }
                    if (PrayID == "5")
                    {
                        lblPrayTimes5.Text = PrayName;
                        lblPrayTimes5_5.Text = PrayTime;
                    }
                    if (PrayID == "6")
                    {
                        lblPrayTimes6.Text = PrayName;
                        lblPrayTimes6_6.Text = PrayTime;
                    }
                    if (PrayID == "7")
                    {
                        lblPrayTimes7.Text = PrayName;
                        lblPrayTimes7_7.Text = PrayTime; ;
                    }
                    if (PrayID == "8")
                    {
                        lblPrayTimes8.Text = PrayName;
                        lblPrayTimes8_8.Text = PrayTime;
                    }
                    if (PrayID == "9")
                    {
                        lblPrayTimes9.Text = PrayName;
                        lblPrayTimes9_9.Text = PrayTime;
                    }
                    if (PrayID == "10")
                    {
                        lblPrayTimes10.Text = PrayName;
                        lblPrayTimes10_10.Text = PrayTime;
                    }
                    if (PrayID == "11")
                    {
                        lblPrayTimes11.Text = PrayName;
                        lblPrayTimes11_11.Text = PrayTime; ;
                    }
                    if (PrayID == "12")
                    {
                        lblPrayTimes12.Text = PrayName;
                        lblPrayTimes12_12.Text = PrayTime;
                    }
                }
            }

        }

        /********************************************************************************************/
        /// <summary>
        /// show real time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTime_Tick(object sender, EventArgs e)
        {
            string Tformat = "HH:mm:ss";
            string n = "00:00:01";
            lblTime.Text = DateTime.Now.ToString(Tformat);
            if (lblTime.Text == n)
            {
                Application.Restart();
                ChangeDisplaySize();
            }
        }
        /// <summary>
        /// show layout every 15 seconds.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void timerSeconds_Tick(object sender, EventArgs e)
        //{
        //    string Tformat = "ss";
        //    lblSec.Text = DateTime.Now.ToString(Tformat);
        //    string tt = "00", pt = "12", msg = "24", pp = "36",h = "48";
        //    if (tt == lblSec.Text)
        //    {
        //        showLayoutTT();
        //    }
        //    else if (pt == lblSec.Text)
        //    {
        //        showLayoutPT();
        //    }
        //    else if (msg == lblSec.Text)
        //    {
        //        showLayoutMSG();
        //    }
        //    else if (pp == lblSec.Text)
        //    {
        //        showLayoutParns();
        //    }
        //    else if(h == lblSec.Text)
        //    {
        //        showLayoutHilio();
        //    }
        //}      
        /// <summary>
        /// check the parameter XML file
        /// </summary>
        private void licenseParmter()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("Parmter.xml"))
            {
                LicenseParmter lc = new LicenseParmter();
                lc.parmater();
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
                //string parmterDate = pDate;
            }
        }
        /// <summary>
        /// update parameter file with the current date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerUpdateParmter_Tick(object sender, EventArgs e)
        {
            if (lblTime.Text == "00:00:10")
            {
                XmlDocument xmlDoc = new XmlDocument();
                if (!File.Exists("Parmter.xml"))
                {
                    LicenseParmter lc = new LicenseParmter();
                    lc.parmater();
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
                    //string parmterDate = pDate;
                }

            }
        }
        /// <summary>
        /// show Times Based of Geo location
        /// </summary>
        public void LocationTimes()
        {
            string locationName;
            double latitude;
            double longitude;
            double elevation;
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("GeoLocation.xml"))
            {
                GeoLocationTimes glt = new GeoLocationTimes();
                glt.CreateFirstGeoLocationXML();
                //glt.SetGeoLocation();
            }
            else
            {
                xmlDoc.Load("GeoLocation.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Geo");
                string GeoID = "", GeoLocationName = "", Geolatitude = "", Geolongitude = "", Geoelevation = "";
                foreach (XmlNode node in nodeList)
                {

                    GeoID = node.SelectSingleNode("Geo_Id").InnerText;
                    GeoLocationName = node.SelectSingleNode("Geo_Location_Name").InnerText;
                    Geolatitude = node.SelectSingleNode("Latitude").InnerText;
                    Geolongitude = node.SelectSingleNode("Longitude").InnerText;
                    Geoelevation = node.SelectSingleNode("Elevation").InnerText;

                }
                locationName = GeoLocationName;
                latitude = Convert.ToDouble(Geolatitude);
                longitude = Convert.ToDouble(Geolongitude);
                elevation = Convert.ToDouble(Geoelevation);
                
                //ITimeZone timeZone = new OlsonTimeZone(PublicDomain.TzTimeZone.CurrentTimeZone);
                ITimeZone timeZone = new OlsonTimeZone("Asia/Jerusalem");
                GeoLocation location = new GeoLocation(locationName, latitude, longitude, elevation, timeZone);
                ComplexZmanimCalendar zc = new ComplexZmanimCalendar(DateTime.Now, location);
                string TimeFormat = "HH:mm:ss";
                DateTime d1,d2,d3,d4,d5,d6,d7,d8,d9;
                {

                    lblTi1.Text = (locationName);
                    d1 = (zc.GetAlosHashachar().Value);
                    d2 = (zc.GetBeginNauticalTwilight().Value);
                    d3 = (zc.GetSunrise().Value);
                    d4 = (zc.GetSofZmanShmaMGA().Value);
                    d5 = (zc.GetSofZmanShmaGRA().Value);
                    d6 = (zc.GetMinchaGedola72Minutes().Value);
                    d7 = (zc.GetSeaLevelSunset().Value);
                    d8 = (zc.GetTzaisGeonim4Point37Degrees().Value);
                    d9 = (zc.GetCandleLighting().Value);
                    lblTi2.Text = d1.ToString(TimeFormat);
                    lblTi3.Text = d2.ToString(TimeFormat);
                    lblTi4.Text = d3.ToString(TimeFormat);
                    lblTi5.Text = d4.ToString(TimeFormat);
                    lblTi6.Text = d5.ToString(TimeFormat);
                    lblTi7.Text = d6.ToString(TimeFormat);
                    lblTi8.Text = d7.ToString(TimeFormat);
                    //lblTi9.Text = (zc.GetTzaisGeonim8Point5Degrees().ToString());
                    //lblTi9.Text = (zc.GetTzaisGeonim3Point65Degrees().ToString());
                    lblTi9.Text = d8.ToString(TimeFormat);
                    lblCandles.Text = d9.ToString(TimeFormat);
                }
            }
        }
        /// <summary>
        /// show the syn Hader name in the application from XML
        /// </summary>
        private void synName()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("SynName.xml"))
            {
                SynChangeNamecs syn = new SynChangeNamecs();
                syn.SetAppSynName();
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
                lblSynName.Text = SynName1;
                
            }
        }
        /// <summary>
        /// show full date and year in the application
        /// </summary>
        public void showDate()
        {
            string value;
            HebrewDateFormatter hdf = new HebrewDateFormatter();
            JewishDate jd = new JewishDate();
            JewishCalendar jc = new JewishCalendar();
            jd.resetDate();
            hdf.HebrewFormat = true;
            jc.InIsrael = true;
            value = jc.GregorianDayOfMonth.ToString() + "/" + jc.GregorianMonth.ToString() + "/" + jc.GregorianYear.ToString();
            ILDate.Text = value;
        }
        /// <summary>
        /// show hebrew date and convert it to leetres
        /// </summary>
        /// 
        private void ShowHebDate()
        {
            //CultureInfo ci = CultureInfo.CreateSpecificCulture("he-IL");
            //ci.DateTimeFormat.Calendar = new System.Globalization.HebrewCalendar();
            //lblHolides.Text = (DateTime.Today.ToString("d MMM yyyy", ci));
            /****************************************************************************/
            string value;
            HebrewDateFormatter hdf = new HebrewDateFormatter();
            JewishDate jd = new JewishDate();
            JewishCalendar jc = new JewishCalendar();
            // jd.resetDate();
            jc.InIsrael = false;
            hdf.HebrewFormat = true;
            value = hdf.format(jd);
            lblHebDate.Text = value;
        }
        private void Hagim()
        {
            string value;
            HebrewDateFormatter hdf = new HebrewDateFormatter();
            JewishDate jd = new JewishDate();
            JewishCalendar jc = new JewishCalendar();
            jd.resetDate();
            hdf.HebrewFormat = true;
            jc.InIsrael = false;
            value = hdf.formatYomTov(jc);
            lblHolides.Text = value;
        }
        private void CheckRoshHodesh()
        {
            string A = "ראש חודש", B=" " ;
            JewishCalendar jc = new JewishCalendar();
            lblRoshHodesh.Text = jc.RoshChodesh.ToString();
            if (jc.RoshChodesh.ToString() == "True")
            {
                lblRoshHodesh.Text = A;
            }
            else
            {
                lblRoshHodesh.Text = B;
            }
        }
        public void Pharsha()
        {
            string value,value2;
            HebrewDateFormatter hdf = new HebrewDateFormatter();
            JewishCalendar jc = new JewishCalendar();
            JewishDate jd = new JewishDate();
            jc.InIsrael = false;
            hdf.HebrewFormat = false;
            value =  hdf.formatParsha(jc);
            lblPharsha.Text = value;

            value2 = jc.ParshaIndex.ToString();
            lblIsHead.Text = value2;  
        }
        private void Daf()
        {
            string value;
            HebrewDateFormatter hdf = new HebrewDateFormatter();
            JewishCalendar jc = new JewishCalendar();
            jc.InIsrael = true;
            hdf.HebrewFormat = true;
            value = hdf.formatDafYomiBavli(jc.DafYomiBavli);
            lblDaf.Text = value;
        }
        /// <summary>
        /// show to current day 
        /// </summary>
        private void ShowDay()
        {
            //Thread.CurrentThread.CurrentCulture = new CultureInfo("he-IL");
            //string day = "dddd";
            //lblShowDay.Text = DateTime.Now.ToString(day);
            /*******************************************************************/
            string value1, value2;
            HebrewDateFormatter hdf = new HebrewDateFormatter();
            JewishDate jd = new JewishDate();
            JewishCalendar jc = new JewishCalendar();
            hdf.HebrewFormat = false;
            jc.InIsrael = true;
            //hdf.LongWeekFormat = true;
            value1 = hdf.formatDayOfWeek(jd);
            //value2 = jd.DayOfWeek.ToString();
            if (value1 == "Sunday")
            {
                value1 = "ראשון";
            }
            if (value1 == "Monday")
            {
                value1 = "שני";
            }
            if (value1 == "Tuesday")
            {
                value1 = "שלישי";
            }
            if (value1 == "Wednesday")
            {
                value1 = "רביעי";
            }
            if (value1 == "Thursday")
            {
                value1 = "חמישי";
            }
            if (value1 == "Friday")
            {
                value1 = "שישי";
            }
            if (value1 == "Saturday")
            {
                value1 = "שבת";
            }
            lblShowDay.Text = value1;

            /*******************************************************************/
    

        }
        /// <summary>
        /// set full screen mode remove frame "F10"
        /// </summary>
        private void FullScreenMode()
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            menuStrip1.Hide();
        }
        /// <summary>
        /// remove full screen mode "F9"
        /// </summary>
        private void NonFullScreenMode()
        {
            this.TopMost = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.WindowState = FormWindowState.Normal;
            menuStrip1.Show();
        }
        /// <summary>
        /// change the display size to application 1600 X 900
        /// </summary>
        private void ChangeDisplaySize()
        {
            int tempHeight = 0, tempWidth = 0;
            int FixHeight = 1920, FixWidth = 1080;
            Synagogue_App.Roesolution res = new Roesolution();
            if (tempHeight != FixHeight && tempWidth != FixWidth)
            {
                res.CWindowsFormsApplication(FixHeight, FixWidth);
            }
        }
        /// <summary>
        /// when the application is trigger exit method its return to 1920*1080
        /// </summary>
        private void ExitApp()
        {
            //back to this resulation after exit
            //int FixHeight = 1920, FixWidth = 1080;
            //Synagogue_App.Roesolution res = new Roesolution();
            //res.CWindowsFormsApplication(FixHeight, FixWidth);
            //System.Environment.Exit(1);
        }
        /// <summary>
        /// Application Trade mark
        /// </summary>
        private void TradeMark()
        {
            lblMarkReg.Text = "© כל הזכויות שמורות ל info-sb.com פתרונות תוכנה, לפרטים: 052-8359554";
        }
        /// <summary>
        /// check  if current day is Equuleus to Sunday if so change background color
        /// </summary>
        private void isfriday()
        {
            string isfriday;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            string day = "dddd";
            isfriday = DateTime.Now.ToString(day);
            if (isfriday == "Friday")
            {
                BackgroundImage = (Image)Resources.shabbos;
            }
            else if (isfriday == "Saturday" )
            {
                BackgroundImage = (Image)Resources.shabbos;
            }
            else if(isfriday != "Friday")
            {
                BackgroundImage = (Image)Resources.Rday;
            }
        }
        /// <summary>
        /// change the background according to the day and the holiday
        /// </summary>
 
        /********************************************************************************************/
        /// <summary>
        /// read the parnas 1 name from XML
        /// </summary>
        private void readParansXML()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("parnas.xml"))
            {
                Parnas p = new Parnas();
                p.parnas();
            }
            else
            {
                xmlDoc.Load("parnas.xml");
                XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Parnas");
                string Parnas_id1 = "", prName1 = "";
                foreach (XmlNode node in nodeList)
                {
                    Parnas_id1 = node.SelectSingleNode("Parnas_id").InnerText;
                    prName1 = node.SelectSingleNode("Parnas_name").InnerText;
                    if (Parnas_id1 == "1")
                    {
                        lblParans1.Text = "\u25E6 " + prName1;
                    }
                    if (Parnas_id1 == "2")
                    {
                        lblParans2.Text = "\u25E6 " + prName1;
                    }
                    if (Parnas_id1 == "3")
                    {
                        lblParans3.Text = "\u25E6 " + prName1;
                    }
                    if (Parnas_id1 == "4")
                    {
                        lblParans4.Text = "\u25E6 " + prName1;
                    }
                }
            }
            
        }

        /**********************************************************************************************/
        /// <summary>
        /// strip toll handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ניהולToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMange fm = new FormMange();
            fm.Show();
            this.Hide();
        }
        private void יציאהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExitApp();
        }
        private void רענוןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            FullScreenMode();
        }
        private void מסךמלאToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeDisplaySize();
            FullScreenMode();
        }
        private void מסךממוזערToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NonFullScreenMode();
        }
        private void אודותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }
        private void רישיוןToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            License l = new License();
            l.Show();
        }
        /******************************************************************************************/
        /// <summary>
        /// show messages on the board
        /// </summary>
        private void ShowMsg()
        {
            XmlDocument xmlDoc = new XmlDocument();
            if (!File.Exists("Msg.xml"))
            {
                Messages msg = new Messages();
                msg.Msg();
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
                    if (Msg_id1 == "1")
                    {
                        lblMsg1.Text = "\u25E6 " + MsgTxt1;
                    }
                    if (Msg_id1 == "2")
                    {
                        lblMsg2.Text = "\u25E6 " + MsgTxt1;
                    }
                    if (Msg_id1 == "3")
                    {
                        lblMsg3.Text = "\u25E6 " + MsgTxt1;
                    }
                    if (Msg_id1 == "4")
                    {
                        lblMsg4.Text = "\u25E6 " + MsgTxt1;
                    }
                }
            }
        }
        /******************************************************************************************/
        /// <summary>
        /// check license anf decrypt licanse data
        /// </summary>
        private void CheckLicenseParamter()
        {
            try
            {
                string datestrformat = "dd/MM/yyyy";
                string ILDate = DateTime.Now.ToString(datestrformat);
                XmlDocument xmlDoc = new XmlDocument();
                CreateLicense cl = new CreateLicense();
                if (!File.Exists("License.xml"))
                {
                    cl.BuildLicenseFile();
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
                    DecryptText(license_Date.ToString().Trim());
                    string LicDate = s1.ToString();
                    if (DateTime.Parse(LicDate) <= DateTime.Parse(ILDate))
                    {
                        MessageBox.Show("תקופת הרישיון פגה, פנה לשירות על מנת לחדש");
                        License l = new License();
                        l.Show();
                        showLayoutEmpty();
                        //tableLayoutPanelTodayTimes.Visible = false;
                        //tableLayoutPanelSynName.Visible = false;
                        //tableLayoutPanelPrayTimes.Visible = false;
                        //tableLayoutPanelMsg.Visible = false;
                        //tableLayoutPanelParnas.Visible = false;
                    }
                    else
                    {
                        showLayoutTT();
                        showLayoutPT();
                        showLayoutParns();
                        showLayoutMSG();
                        showLayoutHilio();
                        //tableLayoutPanelTodayTimes.Visible = true;
                        //tableLayoutPanelSynName.Visible = true;
                        //tableLayoutPanelPrayTimes.Visible = true;
                        //tableLayoutPanelMsg.Visible = true;
                        //tableLayoutPanelParnas.Visible = true;

                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// decrypt message in the xml file
        /// </summary>
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
        /*************************************************************************/
         //<summary>
         //show layout status.
         //</summary>
        private void showLayoutTT()
        {
            lblMarkReg.Show();
            isfriday();
            tableLayoutPanelTodayTimes.Show();
            tableLayoutPanelDateTime.Show();
            tableLayoutPanelHoliday.Show();
            tableLayoutPanelSynName.Show();
            tableLayoutPanelHiliNames.Hide();
            tableLayoutPanelPrayTimes.Hide();
            tableLayoutPanelMsg.Hide();
            tableLayoutPanelParnas.Hide();
        }
        private void showLayoutPT()
        {
            lblMarkReg.Show();
            isfriday();
            tableLayoutPanelPrayTimes.Show();
            tableLayoutPanelDateTime.Show();
            tableLayoutPanelHoliday.Show();
            tableLayoutPanelSynName.Show();
            tableLayoutPanelHiliNames.Hide();
            tableLayoutPanelTodayTimes.Hide();
            tableLayoutPanelMsg.Hide();
            tableLayoutPanelParnas.Hide();
        }
        private void showLayoutMSG()
        {
            lblMarkReg.Show();
            isfriday();
            tableLayoutPanelMsg.Show();
            tableLayoutPanelDateTime.Show();
            tableLayoutPanelHoliday.Show();
            tableLayoutPanelSynName.Show();
            tableLayoutPanelHiliNames.Hide();
            tableLayoutPanelTodayTimes.Hide();
            tableLayoutPanelPrayTimes.Hide();
            tableLayoutPanelParnas.Hide();
        }
        private void showLayoutParns()
        {
            lblMarkReg.Show();
            isfriday();
            tableLayoutPanelParnas.Show();
            tableLayoutPanelDateTime.Show();
            tableLayoutPanelHoliday.Show();
            tableLayoutPanelSynName.Show();
            tableLayoutPanelTodayTimes.Hide();
            tableLayoutPanelPrayTimes.Hide();
            tableLayoutPanelMsg.Hide();
        }
        private void showLayoutHilio()
        {
            BackgroundImage = (Image)Resources.Hiloi;
            lblMarkReg.Hide();
            tableLayoutPanelHiliNames.Show();
            tableLayoutPanelTodayTimes.Hide();
            tableLayoutPanelPrayTimes.Hide();
            tableLayoutPanelMsg.Hide();
            tableLayoutPanelParnas.Hide();
            tableLayoutPanelDateTime.Hide();
            tableLayoutPanelHoliday.Hide();
            tableLayoutPanelSynName.Hide();

        }
        private void showLayoutEmpty()
        {
            lblMarkReg.Show();
            isfriday();
            tableLayoutPanelDateTime.Show();
            tableLayoutPanelHoliday.Show();
            tableLayoutPanelSynName.Show();
            tableLayoutPanelTodayTimes.Hide();
            tableLayoutPanelPrayTimes.Hide();
            tableLayoutPanelMsg.Hide();
            tableLayoutPanelParnas.Hide();
            tableLayoutPanelHiliNames.Hide();
        }
        /****************************************************************/

        /// <summary>
        /// create timer of 12 seconds  that trigger TimerEventProcessor
        /// </summary>
        public void ScrrenTimer()
        {
            
            //Adds the event and the event handler for the method that will 
            //process the timer event to the timer
            theTimer.Tick += new EventHandler(TimerEventProcessor);
            // Sets the timer interval to 12 seconds
            theTimer.Interval = 12000;
            //theTimer.Interval = 1000;
            theTimer.Start();

        }
        // Timer raised method
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            theTimer.Stop();
            theTimer.Dispose();
            if (alarmCounter == 0)
            {
                alarmCounter += 1;
                theTimer.Enabled = true;
                showLayoutTT();
            }
            else if (alarmCounter == 1)
            {
                alarmCounter += 1;
                theTimer.Enabled = true;
                showLayoutPT();
            }
            else if (alarmCounter == 2)
            {
                alarmCounter += 1;
                theTimer.Enabled = true;
                showLayoutParns();
            }
            else if (alarmCounter == 3)
            {
                alarmCounter += 1;
                theTimer.Enabled = true;
                showLayoutMSG();
            }
            else if (alarmCounter == 4)
            {
                alarmCounter += 1;
                theTimer.Enabled = true;
                showLayoutHilio();
            }
            else if (alarmCounter == 5)
            {
                theTimer.Enabled = true;
                alarmCounter = 0; 
            }
        }

    }
}       

    