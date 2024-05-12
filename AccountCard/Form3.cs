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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.hesapkartıdenemetablo' table. You can move, or remove it, as needed.
            this.hesapkartıdenemetabloTableAdapter.Fill(this.dbhesapkartDataSet.hesapkartıdenemetablo);
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.Denemeview' table. You can move, or remove it, as needed.
            this.denemeviewTableAdapter.Fill(this.dbhesapkartDataSet.Denemeview);
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.hesapkartıdenemetablo' table. You can move, or remove it, as needed.
            this.hesapkartıdenemetabloTableAdapter.Fill(this.dbhesapkartDataSet.hesapkartıdenemetablo);

        }

        private void geribtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void eklebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form4 Form4 = new Form4();
            Form4.ID = -1;
            Form4.Show();
        }

        private void duzenlebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            DbhesapkartDataSet.DenemeviewRow selectedRow = (DbhesapkartDataSet.DenemeviewRow)gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if (selectedRow != null)
            {
                Form4 Form4 = new Form4();
                Form4.ID = selectedRow.KartID;
                Form4.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Hesap Seçiniz!");
            }
        }

        private void silbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbhesapkartDataSet.hesapkartıdenemetabloRow selectedRow = (DbhesapkartDataSet.hesapkartıdenemetabloRow)gridView1.GetFocusedDataRow();
            if (selectedRow != null)
            {
               
                hesapkartıdenemetabloTableAdapter.Delete(selectedRow.KartID);

                denemeviewTableAdapter.Fill(dbhesapkartDataSet.Denemeview);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Hesap Seçiniz!");
            }
        }

        private void guncellebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            denemeviewTableAdapter.Fill(dbhesapkartDataSet.Denemeview);
        }
    }
}
