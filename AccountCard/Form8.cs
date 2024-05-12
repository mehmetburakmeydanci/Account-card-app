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
    public partial class Form8 : Form
    {
        public int ID = -1;

        void Yeni()
        {

            var row = dbhesapkartDataSet.HesapKartTip.NewHesapKartTipRow();
            dbhesapkartDataSet.HesapKartTip.AddHesapKartTipRow(row);
        }

        private void InitData()
        {
            dbhesapkartDataSet.HesapKartTip.TableNewRow += (o, e) =>
            {
                e.Row[dbhesapkartDataSet.HesapKartTip.TipAdıColumn] = string.Empty;
                e.Row[dbhesapkartDataSet.HesapKartTip.TipIDColumn] = 0;
                e.Row[dbhesapkartDataSet.HesapKartTip.SilindiColumn] = false;
                

            };
        }
        public Form8()
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
                var row = dbhesapkartDataSet.HesapKartTip.First();
                if (ID == -1)
                {
                    hesapKartTipTableAdapter.Insert(row.TipAdı);
                }
                else
                {
                    hesapKartTipTableAdapter.Update(row.TipAdı,row.TipID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            Close();
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.HesapKartTip' table. You can move, or remove it, as needed.
            InitData();
            if (ID == -1)
            {
                Yeni();
            }
            else
            {
                this.hesapKartTipTableAdapter.FillByID(dbhesapkartDataSet.HesapKartTip, ID);
            }


        }

       
    }
}
