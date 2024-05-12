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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartGrup' table. You can move, or remove it, as needed.
            this.hesapKartGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartGrup);
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.kullaniciwiew' table. You can move, or remove it, as needed.
            

        }

        private void guncellebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.hesapKartGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartGrup);
        }

        private void geribtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Silbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbhesapkartDataSet.HesapKartGrupRow selectedRow = (DbhesapkartDataSet.HesapKartGrupRow)gridView1.GetFocusedDataRow();
            if (selectedRow != null)
            {

                hesapKartGrupTableAdapter.Delete(selectedRow.GrupID);

                this.hesapKartGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartGrup);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Grup Seçiniz!");
            }
        }

        private void Duzenlebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbhesapkartDataSet.HesapKartGrupRow selectedRow = (DbhesapkartDataSet.HesapKartGrupRow)gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if (selectedRow != null)
            {
                Form11 Form11 = new Form11();
                Form11.ID = selectedRow.GrupID;
                Form11.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Grup Seçiniz!");
            }
        }

        private void Eklebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form11 Form11 = new Form11();
            Form11.ID = -1;
            Form11.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbhesapkartDataSet.HesapKartGrupRow selectedRow = (DbhesapkartDataSet.HesapKartGrupRow)gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if (selectedRow != null)
            {
                Form10 Form10 = new Form10();
                Form10.GrupListedenAcildi = true;
                Form10.GrupID = selectedRow.GrupID;
                Form10.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Grup Seçiniz!");
            }
           
        }
    }
}
