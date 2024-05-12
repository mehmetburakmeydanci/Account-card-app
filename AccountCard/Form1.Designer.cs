
namespace StajDeneme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btngiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lyKullaniciAdi = new DevExpress.XtraLayout.LayoutControlItem();
            this.lySifre = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem2 = new DevExpress.XtraLayout.SplitterItem();
            this.kullanicitabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbhesapkartDataSet = new StajDeneme.DbhesapkartDataSet();
            this.kullanicitabloTableAdapter = new StajDeneme.DbhesapkartDataSetTableAdapters.kullanicitabloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyKullaniciAdi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySifre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicitabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbhesapkartDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btngiris);
            this.layoutControl1.Controls.Add(this.txtSifre);
            this.layoutControl1.Controls.Add(this.txtKullaniciAdi);
            this.layoutControl1.Location = new System.Drawing.Point(12, 12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(529, 118);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btngiris
            // 
            this.btngiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btngiris.ImageOptions.Image")));
            this.btngiris.Location = new System.Drawing.Point(12, 80);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(505, 22);
            this.btngiris.StyleController = this.layoutControl1;
            this.btngiris.TabIndex = 6;
            this.btngiris.Text = "Giriş Yap";
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(83, 46);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.UseSystemPasswordChar = true;
            this.txtSifre.Size = new System.Drawing.Size(434, 20);
            this.txtSifre.StyleController = this.layoutControl1;
            this.txtSifre.TabIndex = 5;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(83, 12);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(434, 20);
            this.txtKullaniciAdi.StyleController = this.layoutControl1;
            this.txtKullaniciAdi.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lyKullaniciAdi,
            this.lySifre,
            this.splitterItem1,
            this.layoutControlItem3,
            this.splitterItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(529, 118);
            this.Root.TextVisible = false;
            // 
            // lyKullaniciAdi
            // 
            this.lyKullaniciAdi.Control = this.txtKullaniciAdi;
            this.lyKullaniciAdi.Location = new System.Drawing.Point(0, 0);
            this.lyKullaniciAdi.Name = "lyKullaniciAdi";
            this.lyKullaniciAdi.Size = new System.Drawing.Size(509, 24);
            this.lyKullaniciAdi.Text = "Kullanıcı Adı:";
            this.lyKullaniciAdi.TextSize = new System.Drawing.Size(59, 13);
            // 
            // lySifre
            // 
            this.lySifre.Control = this.txtSifre;
            this.lySifre.Location = new System.Drawing.Point(0, 34);
            this.lySifre.Name = "lySifre";
            this.lySifre.Size = new System.Drawing.Size(509, 24);
            this.lySifre.Text = "Şifre:";
            this.lySifre.TextSize = new System.Drawing.Size(59, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 24);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(509, 10);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btngiris;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(509, 30);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // splitterItem2
            // 
            this.splitterItem2.AllowHotTrack = true;
            this.splitterItem2.Location = new System.Drawing.Point(0, 58);
            this.splitterItem2.Name = "splitterItem2";
            this.splitterItem2.Size = new System.Drawing.Size(509, 10);
            // 
            // kullanicitabloBindingSource
            // 
            this.kullanicitabloBindingSource.DataMember = "kullanicitablo";
            this.kullanicitabloBindingSource.DataSource = this.dbhesapkartDataSet;
            // 
            // dbhesapkartDataSet
            // 
            this.dbhesapkartDataSet.DataSetName = "DbhesapkartDataSet";
            this.dbhesapkartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanicitabloTableAdapter
            // 
            this.kullanicitabloTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 135);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lyKullaniciAdi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lySifre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicitabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbhesapkartDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btngiris;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lyKullaniciAdi;
        private DevExpress.XtraLayout.LayoutControlItem lySifre;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.SplitterItem splitterItem2;
        private DbhesapkartDataSet dbhesapkartDataSet;
        private System.Windows.Forms.BindingSource kullanicitabloBindingSource;
        private DbhesapkartDataSetTableAdapters.kullanicitabloTableAdapter kullanicitabloTableAdapter;
    }
}

