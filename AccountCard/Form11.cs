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
    public partial class Form11 : Form
    {
        public int ID = -1;

        void Yeni()
        {

            var row = dbhesapkartDataSet.HesapKartGrup.NewHesapKartGrupRow();
            dbhesapkartDataSet.HesapKartGrup.AddHesapKartGrupRow(row);
        }

        private void InitData()
        {
            dbhesapkartDataSet.HesapKartGrup.TableNewRow += (o, e) =>
            {
                e.Row[dbhesapkartDataSet.HesapKartGrup.GrupAdıColumn] = string.Empty;
                e.Row[dbhesapkartDataSet.HesapKartGrup.GrupIDColumn] = 0;
                e.Row[dbhesapkartDataSet.HesapKartGrup.SilindiColumn] = false;

            };
        }
            public Form11()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            InitData();
            if (ID == -1)
            {
                Yeni();
            }
            else
            {
                this.hesapKartGrupTableAdapter.FillByID(dbhesapkartDataSet.HesapKartGrup,ID);
            }
        }

        private void Kaydetbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bindingSource1.EndEdit();
                var row = dbhesapkartDataSet.HesapKartGrup.First();
                if (ID == -1)
                {
                    hesapKartGrupTableAdapter.Insert(row.GrupAdı);
                }
                else
                {
                    hesapKartGrupTableAdapter.Update(dbhesapkartDataSet.HesapKartGrup);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            Close();
        }
    }
}
