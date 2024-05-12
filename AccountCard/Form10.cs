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
    public partial class Form10 : Form
    {
        public bool GrupListedenAcildi = false;
        public int GrupID = -1;
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            if (GrupListedenAcildi)
            {
            this.hesapKartAltGrupTableAdapter.FillByGrupID(this.dbhesapkartDataSet.HesapKartAltGrup,GrupID);
            dtAltGrupListe.FillByID(dbhesapkartDataSet.V_AltGrupListe,GrupID);

            }
            else
            {
            this.hesapKartAltGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartAltGrup);
            dtAltGrupListe.Fill(dbhesapkartDataSet.V_AltGrupListe);

            }
        }

        private void geribtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void guncellebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.hesapKartAltGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartAltGrup);
            dtAltGrupListe.Fill(dbhesapkartDataSet.V_AltGrupListe);
        }

        private void silbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbhesapkartDataSet.V_AltGrupListeRow selectedRow = (DbhesapkartDataSet.V_AltGrupListeRow)gridView1.GetFocusedDataRow();
            if (selectedRow != null)
            {

                hesapKartAltGrupTableAdapter.Delete(selectedRow.AltgrupID);

                this.hesapKartAltGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartAltGrup);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Grup Seçiniz!");
            }
        }

        private void duzenlebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DbhesapkartDataSet.V_AltGrupListeRow selectedRow = (DbhesapkartDataSet.V_AltGrupListeRow)gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            if (GrupListedenAcildi == true)
            {
                Form13 Form13 = new Form13();
                Form13.ID = selectedRow.GrupID;
                Form13.Show();
            }
            else
            {
              
                if (selectedRow != null)
                {
                    Form12 Form12 = new Form12();
                    Form12.ID = selectedRow.AltgrupID;
                    Form12.Show();
                }
                else
                {
                    MessageBox.Show("Lütfen Bir Grup Seçiniz!");
                }
            }

        }

        private void eklebtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form12 Form12 = new Form12();
            Form12.ID = -1;
            Form12.Show();
        }
    }
}
