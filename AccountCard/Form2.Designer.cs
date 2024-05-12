
namespace StajDeneme
{
    partial class Form2
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbhesapkartDataSet = new StajDeneme.DbhesapkartDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullanıcıAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefonNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kullanicitabloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.hesapkarttanımbtn = new DevExpress.XtraBars.BarButtonItem();
            this.hesapkarttipbtn = new DevExpress.XtraBars.BarButtonItem();
            this.hesapkartturbtn = new DevExpress.XtraBars.BarButtonItem();
            this.hesapkartgrupbtn = new DevExpress.XtraBars.BarButtonItem();
            this.hesapkartaltgrupbtn = new DevExpress.XtraBars.BarButtonItem();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.kullanicitabloTableAdapter = new StajDeneme.DbhesapkartDataSetTableAdapters.kullanicitabloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbhesapkartDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicitabloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 410);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "kullanicitablo";
            this.bindingSource1.DataSource = this.dbhesapkartDataSet;
            // 
            // dbhesapkartDataSet
            // 
            this.dbhesapkartDataSet.DataSetName = "DbhesapkartDataSet";
            this.dbhesapkartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserID,
            this.colAd,
            this.colSoyad,
            this.colKullanıcıAdı,
            this.colSifre,
            this.gridColumn1,
            this.colTelefonNo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colUserID
            // 
            this.colUserID.FieldName = "UserID";
            this.colUserID.Name = "colUserID";
            this.colUserID.Visible = true;
            this.colUserID.VisibleIndex = 0;
            // 
            // colAd
            // 
            this.colAd.FieldName = "Ad";
            this.colAd.Name = "colAd";
            this.colAd.Visible = true;
            this.colAd.VisibleIndex = 1;
            // 
            // colSoyad
            // 
            this.colSoyad.FieldName = "Soyad";
            this.colSoyad.Name = "colSoyad";
            this.colSoyad.Visible = true;
            this.colSoyad.VisibleIndex = 2;
            // 
            // colKullanıcıAdı
            // 
            this.colKullanıcıAdı.FieldName = "KullanıcıAdı";
            this.colKullanıcıAdı.Name = "colKullanıcıAdı";
            this.colKullanıcıAdı.Visible = true;
            this.colKullanıcıAdı.VisibleIndex = 3;
            // 
            // colSifre
            // 
            this.colSifre.FieldName = "Sifre";
            this.colSifre.Name = "colSifre";
            this.colSifre.Visible = true;
            this.colSifre.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "E-Mail";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // colTelefonNo
            // 
            this.colTelefonNo.FieldName = "TelefonNo";
            this.colTelefonNo.Name = "colTelefonNo";
            this.colTelefonNo.Visible = true;
            this.colTelefonNo.VisibleIndex = 6;
            // 
            // kullanicitabloBindingSource
            // 
            this.kullanicitabloBindingSource.DataMember = "kullanicitablo";
            this.kullanicitabloBindingSource.DataSource = this.dbhesapkartDataSet;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.DockCol = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.Text = "Status bar";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Main menu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar5,
            this.bar6});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.hesapkarttanımbtn,
            this.hesapkarttipbtn,
            this.hesapkartturbtn,
            this.hesapkartgrupbtn,
            this.hesapkartaltgrupbtn});
            this.barManager1.MainMenu = this.bar5;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar6;
            // 
            // bar5
            // 
            this.bar5.BarName = "Main menu";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.hesapkarttanımbtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.hesapkarttipbtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.hesapkartturbtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.hesapkartgrupbtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.hesapkartaltgrupbtn)});
            this.bar5.OptionsBar.MultiLine = true;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Main menu";
            // 
            // hesapkarttanımbtn
            // 
            this.hesapkarttanımbtn.Caption = "Hesap Kartı Tanımları";
            this.hesapkarttanımbtn.Id = 2;
            this.hesapkarttanımbtn.Name = "hesapkarttanımbtn";
            this.hesapkarttanımbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.hesapkarttanımbtn_ItemClick);
            // 
            // hesapkarttipbtn
            // 
            this.hesapkarttipbtn.Caption = "Hesap Kartı Türleri";
            this.hesapkarttipbtn.Id = 3;
            this.hesapkarttipbtn.Name = "hesapkarttipbtn";
            this.hesapkarttipbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.hesapkarttipbtn_ItemClick);
            // 
            // hesapkartturbtn
            // 
            this.hesapkartturbtn.Caption = "Hesap Kartı Tipi";
            this.hesapkartturbtn.Id = 4;
            this.hesapkartturbtn.Name = "hesapkartturbtn";
            this.hesapkartturbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.hesapkartturbtn_ItemClick);
            // 
            // hesapkartgrupbtn
            // 
            this.hesapkartgrupbtn.Caption = "Hesap Kartı Grup";
            this.hesapkartgrupbtn.Id = 5;
            this.hesapkartgrupbtn.Name = "hesapkartgrupbtn";
            this.hesapkartgrupbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.hesapkartgrupbtn_ItemClick);
            // 
            // hesapkartaltgrupbtn
            // 
            this.hesapkartaltgrupbtn.Caption = "Hesap Kartı Alt Grup";
            this.hesapkartaltgrupbtn.Id = 6;
            this.hesapkartaltgrupbtn.Name = "hesapkartaltgrupbtn";
            this.hesapkartaltgrupbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.hesapkartaltgrupbtn_ItemClick);
            // 
            // bar6
            // 
            this.bar6.BarName = "Status bar";
            this.bar6.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar6.OptionsBar.AllowQuickCustomization = false;
            this.bar6.OptionsBar.DrawDragBorder = false;
            this.bar6.OptionsBar.UseWholeRow = true;
            this.bar6.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 430);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(800, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 410);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 410);
            // 
            // kullanicitabloTableAdapter
            // 
            this.kullanicitabloTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbhesapkartDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanicitabloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DbhesapkartDataSet dbhesapkartDataSet;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarButtonItem hesapkarttanımbtn;
        private DevExpress.XtraBars.Bar bar6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem hesapkarttipbtn;
        private DevExpress.XtraBars.BarButtonItem hesapkartturbtn;
        private DevExpress.XtraBars.BarButtonItem hesapkartgrupbtn;
        private DevExpress.XtraBars.BarButtonItem hesapkartaltgrupbtn;
        private DevExpress.XtraGrid.Columns.GridColumn colUserID;
        private DevExpress.XtraGrid.Columns.GridColumn colAd;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colKullanıcıAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colSifre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefonNo;
        private System.Windows.Forms.BindingSource kullanicitabloBindingSource;
        private DbhesapkartDataSetTableAdapters.kullanicitabloTableAdapter kullanicitabloTableAdapter;
    }
}