using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Synagogue_App
{
    public partial class FormMange : Form
    {
        
        public FormMange()
        {
            InitializeComponent();
            
        }


        private void btnChangeSynName_Click(object sender, EventArgs e)
        {
            SynChangeNamecs nm = new SynChangeNamecs();
            nm.Show();
        }

        private void btnmainForm_Click(object sender, EventArgs e)
        {
            FormMain fm = new FormMain();
            fm.Show();
            this.Hide();
        }




        private void btnWeekParans_Click(object sender, EventArgs e)
        {
            Parnas p = new Parnas();
            p.Show();
        }

        private void btnPraysName_Click(object sender, EventArgs e)
        {
            HiloiNames hn = new HiloiNames();
            hn.Show();
            //AdminLogin al = new AdminLogin();
            //al.Show();
        }

        private void btnPrayTimes_Click(object sender, EventArgs e)
        {
            PrayTimes pt = new PrayTimes();
            pt.Show();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            Messages msg = new Messages();
            msg.Show();
        }

        private void btnGeoLocationForm_Click(object sender, EventArgs e)
        {
            GeoLocationTimes glt = new GeoLocationTimes();
            glt.Show();
        }


    }
}
