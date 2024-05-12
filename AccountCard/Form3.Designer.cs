
namespace StajDeneme
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dbhesapkartDataSet = new StajDeneme.DbhesapkartDataSet();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.eklebtn = new DevExpress.XtraBars.BarButtonItem();
            this.duzenlebtn = new DevExpress.XtraBars.BarButtonItem();
            this.silbtn = new DevExpress.XtraBars.BarButtonItem();
            this.guncellebtn = new DevExpress.XtraBars.BarButtonItem();
            this.geribtn = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.denemeviewTableAdapter = new StajDeneme.DbhesapkartDataSetTableAdapters.DenemeviewTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTipAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTurAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGrupAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAltGrupAdı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hesapkartıdenemetabloTableAdapter = new StajDeneme.DbhesapkartDataSetTableAdapters.hesapkartıdenemetabloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbhesapkartDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Denemeview";
            this.bindingSource1.DataSource = this.dbhesapkartDataSet;
            // 
            // dbhesapkartDataSet
            // 
            this.dbhesapkartDataSet.DataSetName = "dbhesapkartDataSet";
            this.dbhesapkartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.eklebtn,
            this.duzenlebtn,
            this.silbtn,
            this.barButtonItem1,
            this.geribtn,
            this.guncellebtn});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.eklebtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.duzenlebtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.silbtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.guncellebtn),
            new DevExpress.XtraBars.LinkPersistInfo(this.geribtn)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // eklebtn
            // 
            this.eklebtn.Caption = "Ekle";
            this.eklebtn.Id = 0;
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.eklebtn_ItemClick);
            // 
            // duzenlebtn
            // 
            this.duzenlebtn.Caption = "Düzenle";
            this.duzenlebtn.Id = 1;
            this.duzenlebtn.Name = "duzenlebtn";
            this.duzenlebtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.duzenlebtn_ItemClick);
            // 
            // silbtn
            // 
            this.silbtn.Caption = "Sil";
            this.silbtn.Id = 2;
            this.silbtn.Name = "silbtn";
            this.silbtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.silbtn_ItemClick);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Caption = "Güncelle";
            this.guncellebtn.Id = 5;
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.guncellebtn_ItemClick);
            // 
            // geribtn
            // 
            this.geribtn.Id = 4;
            this.geribtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("geribtn.ImageOptions.SvgImage")));
            this.geribtn.Name = "geribtn";
            this.geribtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.geribtn_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(800, 24);
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
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 406);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(800, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 406);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // denemeviewTableAdapter
            // 
            this.denemeviewTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 406);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUnvan,
            this.colVergiDairesi,
            this.colTc,
            this.colAdres,
            this.colTipAdı,
            this.colTurAdı,
            this.colGrupAdı,
            this.colAltGrupAdı});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            // 
            // colUnvan
            // 
            this.colUnvan.FieldName = "Unvan";
            this.colUnvan.Name = "colUnvan";
            this.colUnvan.Visible = true;
            this.colUnvan.VisibleIndex = 0;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 1;
            // 
            // colTc
            // 
            this.colTc.FieldName = "Tc";
            this.colTc.Name = "colTc";
            this.colTc.Visible = true;
            this.colTc.VisibleIndex = 2;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 3;
            // 
            // colTipAdı
            // 
            this.colTipAdı.FieldName = "TipAdı";
            this.colTipAdı.Name = "colTipAdı";
            this.colTipAdı.Visible = true;
            this.colTipAdı.VisibleIndex = 4;
            // 
            // colTurAdı
            // 
            this.colTurAdı.FieldName = "TurAdı";
            this.colTurAdı.Name = "colTurAdı";
            this.colTurAdı.Visible = true;
            this.colTurAdı.VisibleIndex = 5;
            // 
            // colGrupAdı
            // 
            this.colGrupAdı.FieldName = "GrupAdı";
            this.colGrupAdı.Name = "colGrupAdı";
            this.colGrupAdı.Visible = true;
            this.colGrupAdı.VisibleIndex = 6;
            // 
            // colAltGrupAdı
            // 
            this.colAltGrupAdı.FieldName = "AltGrupAdı";
            this.colAltGrupAdı.Name = "colAltGrupAdı";
            this.colAltGrupAdı.Visible = true;
            this.colAltGrupAdı.VisibleIndex = 7;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "hesapkartıdenemetablo";
            this.bindingSource2.DataSource = this.dbhesapkartDataSet;
            // 
            // hesapkartıdenemetabloTableAdapter
            // 
            this.hesapkartıdenemetabloTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbhesapkartDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem eklebtn;
        private DevExpress.XtraBars.BarButtonItem duzenlebtn;
        private DevExpress.XtraBars.BarButtonItem silbtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DbhesapkartDataSet dbhesapkartDataSet;
        private DevExpress.XtraBars.BarButtonItem geribtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem guncellebtn;
        private DbhesapkartDataSetTableAdapters.DenemeviewTableAdapter denemeviewTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUnvan;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colTc;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colTipAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colTurAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colGrupAdı;
        private DevExpress.XtraGrid.Columns.GridColumn colAltGrupAdı;
        private System.Windows.Forms.BindingSource bindingSource2;
        private DbhesapkartDataSetTableAdapters.hesapkartıdenemetabloTableAdapter hesapkartıdenemetabloTableAdapter;
    }
}