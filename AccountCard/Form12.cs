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
    public partial class Form12 : Form
    {
        public int ID = -1;

        void Yeni()
        {

            var row = dbhesapkartDataSet.HesapKartAltGrup.NewHesapKartAltGrupRow();
            dbhesapkartDataSet.HesapKartAltGrup.AddHesapKartAltGrupRow(row);
        }

        private void InitData()
        {
            dbhesapkartDataSet.HesapKartAltGrup.TableNewRow += (o, e) =>
            {
                e.Row[dbhesapkartDataSet.HesapKartAltGrup.AltGrupAdıColumn] = string.Empty;
                e.Row[dbhesapkartDataSet.HesapKartAltGrup.AltgrupIDColumn] = 0;
                e.Row[dbhesapkartDataSet.HesapKartAltGrup.GrupIDColumn] = 0;
                e.Row[dbhesapkartDataSet.HesapKartAltGrup.SilindiColumn] = false;

            };
        }
        public Form12()
        {
            InitializeComponent();
        }

        private void Kapatbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Kaydetbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                var row = dbhesapkartDataSet.HesapKartAltGrup.First();
                if (ID == -1)
                {
                    hesapKartAltGrupTableAdapter.Insert(row.AltGrupAdı,row.GrupID);
                }
                else
                {
                    hesapKartAltGrupTableAdapter.Update(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartGrup' table. You can move, or remove it, as needed.
            this.hesapKartGrupTableAdapter.Fill(this.dbhesapkartDataSet.HesapKartGrup);
            InitData();
            if (ID == -1)
            {
                Yeni();
            }
            else
            {
                this.hesapKartAltGrupTableAdapter.FillByID(dbhesapkartDataSet.HesapKartAltGrup, ID);
            }

        }
    }
}
