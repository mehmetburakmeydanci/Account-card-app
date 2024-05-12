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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartTur' table. You can move, or remove it, as needed.
            this.hesapKartTurTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartTur);

        }

        private void geribtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void guncellebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hesapKartTurTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartTur);
        }

        private void silbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbhesapkartDataSet.HesapKartTurRow selectedRow = (DbhesapkartDataSet.HesapKartTurRow)gridView1.GetFocusedDataRow();
            if (selectedRow != null)
            {

                hesapKartTurTableAdapter.Delete(selectedRow.TurID);

                this.hesapKartTurTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartTur);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Hesap Seçiniz!");
            }
        }

        private void duzenlebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbhesapkartDataSet.HesapKartTurRow selectedRow = (DbhesapkartDataSet.HesapKartTurRow)gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if (selectedRow != null)
            {
                Form6 Form6 = new Form6();
                Form6.ID = selectedRow.TurID;
                Form6.Show();
            }
            else
            {
                MessageBox.Show("Lütfen Bir Hesap Seçiniz!");
            }
        }

        private void eklebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form6 Form6 = new Form6();
            Form6.ID = -1;
            Form6.Show();
        }
    }
}
