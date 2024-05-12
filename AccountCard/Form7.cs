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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartTip' table. You can move, or remove it, as needed.
            this.hesapKartTipTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartTip);
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.hesaptipwiew' table. You can move, or remove it, as needed.
            this.hesapKartTipTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartTip);

        }

        private void geribtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void guncellebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.hesapKartTipTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartTip);
        }

        private void silbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbhesapkartDataSet.HesapKartTipRow selectedRow = (DbhesapkartDataSet.HesapKartTipRow)gridView1.GetFocusedDataRow();
            if (selectedRow != null)
            {

                hesapKartTipTableAdapter.Delete(selectedRow.TipID);

            }
            else
            {
                MessageBox.Show("Lütfen Bir Hesap Seçiniz!");
            }
        }

        private void duzenlebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbhesapkartDataSet.HesapKartTipRow selectedRow = (DbhesapkartDataSet.HesapKartTipRow)gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if (selectedRow != null)
            {
                Form8 Form8 = new Form8();
                Form8.ID = selectedRow.TipID;
                Form8.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Hesap Seçiniz!");
            }
        }

        private void eklebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form8 Form8 = new Form8();
            Form8.ID = -1;
            Form8.Show();
        }
    }
}
