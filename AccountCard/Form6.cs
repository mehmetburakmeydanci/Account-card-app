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
    public partial class Form6 : Form
    {
        public int ID = -1;

        void Yeni()
        {

            var row = dbhesapkartDataSet.HesapKartTur.NewHesapKartTurRow();
            dbhesapkartDataSet.HesapKartTur.AddHesapKartTurRow(row);
        }

        private void InitData()
        {
            dbhesapkartDataSet.HesapKartTur.TableNewRow += (o, e) =>
            {
                e.Row[dbhesapkartDataSet.HesapKartTur.TurAdıColumn] = string.Empty;
                e.Row[dbhesapkartDataSet.HesapKartTur.TurIDColumn] = 0;
                e.Row[dbhesapkartDataSet.HesapKartTur.SilindiColumn] = false;

            };
        }

        public Form6()
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
                var row = dbhesapkartDataSet.HesapKartTur.First();
                if (ID == -1)
                {
                    hesapKartTurTableAdapter.Insert(row.TurAdı);
                }
                else
                {
                    hesapKartTurTableAdapter.Update(dbhesapkartDataSet.HesapKartTur);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            InitData();
            if (ID == -1)
            {
                Yeni();
            }
            else
            {
                this.hesapKartTurTableAdapter.FillByID(dbhesapkartDataSet.HesapKartTur, ID);
            }

        }
    }
}



