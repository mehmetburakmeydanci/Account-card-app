using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StajDeneme
{
    public partial class Form13 : Form
    {
        public int ID = -1;
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartAltGrup' table. You can move, or remove it, as needed.
            this.hesapKartAltGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartAltGrup);
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartGrup' table. You can move, or remove it, as needed.
            this.hesapKartGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartGrup);

        }

        private void kptbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void kaydetbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var row = dbhesapkartDataSet.HesapKartTur.First();
                hesapKartGrupTableAdapter.Update(dbhesapkartDataSet.HesapKartGrup);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
