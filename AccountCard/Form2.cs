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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.Denemeview' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.kullanicitablo' table. You can move, or remove it, as needed.
            this.kullanicitabloTableAdapter.Fill(this.dbhesapkartDataSet.kullanicitablo);
            // TODO: This line of code loads data into the 'dbhesapkartDataSet.kullanicitablo' table. You can move, or remove it, as needed.
            this.kullanicitabloTableAdapter.Fill(this.dbhesapkartDataSet.kullanicitablo);

        }

        private void hesapkarttanımbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
        }

        private void hesapkarttipbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void hesapkartturbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form7 Form7 = new Form7();
            Form7.Show();
        }

        private void hesapkartgrupbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form9 Form9 = new Form9();
            Form9.Show();
        }

        private void hesapkartaltgrupbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form10 Form10 = new Form10();
            Form10.Show();
        }
    }
}
