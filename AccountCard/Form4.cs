using DevExpress.XtraEditors;
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
    public partial class Form4 : Form
    {
        public int ID = -1;

        void Yeni()
        {

            var row = dbhesapkartDataSet.hesapkartıdenemetablo.NewhesapkartıdenemetabloRow();
            dbhesapkartDataSet.hesapkartıdenemetablo.AddhesapkartıdenemetabloRow(row);
        }

        private void InitData()
        {
            dbhesapkartDataSet.hesapkartıdenemetablo.TableNewRow += (o, e) =>
            {
                e.Row[dbhesapkartDataSet.hesapkartıdenemetablo.UnvanColumn] = string.Empty;
                e.Row[dbhesapkartDataSet.hesapkartıdenemetablo.VergiDairesiColumn] = string.Empty;
                e.Row[dbhesapkartDataSet.hesapkartıdenemetablo.TcColumn] = string.Empty;
                e.Row[dbhesapkartDataSet.hesapkartıdenemetablo.AdresColumn] = string.Empty;
                e.Row[dbhesapkartDataSet.hesapkartıdenemetablo.TipIDColumn] = 0;
                e.Row[dbhesapkartDataSet.hesapkartıdenemetablo.TurIDColumn] = 0;
                e.Row[dbhesapkartDataSet.hesapkartıdenemetablo.GrupIDColumn] = 0;
                e.Row[dbhesapkartDataSet.hesapkartıdenemetablo.AltgrupIDColumn] = 0;
                e.Row[dbhesapkartDataSet.hesapkartıdenemetablo.SilindiColumn] = false;
                



            };
        }

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartGrup' table. You can move, or remove it, as needed.
            this.hesapKartGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartGrup);
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartAltGrup' table. You can move, or remove it, as needed.
            this.hesapKartAltGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartAltGrup);
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartTur' table. You can move, or remove it, as needed.
            this.hesapKartTurTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartTur);
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartTip' table. You can move, or remove it, as needed.
            this.hesapKartTipTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartTip);

            InitData();
            if (ID == -1)
            {
                Yeni();
            }
            else
            {
                this.hesapkartıdenemetabloTableAdapter.FillByID(this.dbhesapkartDataSet.hesapkartıdenemetablo, ID);
            }



        }

        private void kapatbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void kaydetbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                var row = dbhesapkartDataSet.hesapkartıdenemetablo.First();
                if (ID == -1)
                {
                    hesapkartıdenemetabloTableAdapter.Insert(row.Unvan, row.VergiDairesi, row.Tc, row.Adres, row.TipID, row.TurID, row.GrupID, row.AltgrupID, row.Silindi);
                }
                else
                {
                    hesapkartıdenemetabloTableAdapter.Update(row.Unvan, row.VergiDairesi, row.Tc, row.Adres, row.TipID, row.TurID, row.GrupID, row.AltgrupID, row.KartID);
                }


                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textEdit7_EditValueChanged(object sender, EventArgs e)
        {
            var grup = ((LookUpEdit)sender).EditValue;
            if (grup != null)
            {
                hesapKartAltGrupTableAdapter.FillByGrupID(dbhesapkartDataSet.HesapKartAltGrup,Convert.ToInt32 (grup));

            }
        }
    }
}

