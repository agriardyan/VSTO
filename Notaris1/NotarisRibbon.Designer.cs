namespace Notaris1
{
    partial class NotarisRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public NotarisRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.separator1 = this.Factory.CreateRibbonSeparator();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.aboutButton = this.Factory.CreateRibbonButton();
            this.bantuanButton = this.Factory.CreateRibbonButton();
            this.pageSetupButton = this.Factory.CreateRibbonButton();
            this.buatDokumenSplitButton = this.Factory.CreateRibbonSplitButton();
            this.buatAktaFiduciaButton = this.Factory.CreateRibbonButton();
            this.insertBilanganButton = this.Factory.CreateRibbonButton();
            this.insertTanggalButton = this.Factory.CreateRibbonSplitButton();
            this.tanggalLainButton = this.Factory.CreateRibbonButton();
            this.insertJamButton = this.Factory.CreateRibbonSplitButton();
            this.jamLainButton = this.Factory.CreateRibbonButton();
            this.button3 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "Software Notaris";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.aboutButton);
            this.group1.Items.Add(this.bantuanButton);
            this.group1.Label = "Bantuan";
            this.group1.Name = "group1";
            // 
            // group2
            // 
            this.group2.Items.Add(this.pageSetupButton);
            this.group2.Items.Add(this.buatDokumenSplitButton);
            this.group2.Items.Add(this.insertBilanganButton);
            this.group2.Items.Add(this.insertTanggalButton);
            this.group2.Items.Add(this.insertJamButton);
            this.group2.Items.Add(this.separator1);
            this.group2.Items.Add(this.button3);
            this.group2.Label = "Dokumen";
            this.group2.Name = "group2";
            // 
            // separator1
            // 
            this.separator1.Name = "separator1";
            // 
            // aboutButton
            // 
            this.aboutButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.aboutButton.Label = "About";
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.OfficeImageId = "MeetingsWorkspace";
            this.aboutButton.ShowImage = true;
            this.aboutButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.aboutButton_Click);
            // 
            // bantuanButton
            // 
            this.bantuanButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.bantuanButton.Label = "Bantuan";
            this.bantuanButton.Name = "bantuanButton";
            this.bantuanButton.OfficeImageId = "TentativeAcceptInvitation";
            this.bantuanButton.ShowImage = true;
            this.bantuanButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bantuanButton_Click);
            // 
            // pageSetupButton
            // 
            this.pageSetupButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.pageSetupButton.Label = "Page Setup";
            this.pageSetupButton.Name = "pageSetupButton";
            this.pageSetupButton.OfficeImageId = "DesignMode";
            this.pageSetupButton.ShowImage = true;
            this.pageSetupButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.pageSetupButton_Click);
            // 
            // buatDokumenSplitButton
            // 
            this.buatDokumenSplitButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buatDokumenSplitButton.Items.Add(this.buatAktaFiduciaButton);
            this.buatDokumenSplitButton.Label = "Buat Dokumen";
            this.buatDokumenSplitButton.Name = "buatDokumenSplitButton";
            this.buatDokumenSplitButton.OfficeImageId = "SignatureInsertMenu";
            this.buatDokumenSplitButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buatDokumenSplitButton_Click);
            // 
            // buatAktaFiduciaButton
            // 
            this.buatAktaFiduciaButton.Label = "Akta Fiducia";
            this.buatAktaFiduciaButton.Name = "buatAktaFiduciaButton";
            this.buatAktaFiduciaButton.OfficeImageId = "SignatureInsertMenu";
            this.buatAktaFiduciaButton.ShowImage = true;
            this.buatAktaFiduciaButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buatAktaFiduciaButton_Click);
            // 
            // insertBilanganButton
            // 
            this.insertBilanganButton.Label = "Insert Bilangan";
            this.insertBilanganButton.Name = "insertBilanganButton";
            this.insertBilanganButton.OfficeImageId = "AccountingFormat";
            this.insertBilanganButton.ShowImage = true;
            this.insertBilanganButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertBilanganButton_Click);
            // 
            // insertTanggalButton
            // 
            this.insertTanggalButton.Items.Add(this.tanggalLainButton);
            this.insertTanggalButton.ItemSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.insertTanggalButton.Label = "Insert Tanggal";
            this.insertTanggalButton.Name = "insertTanggalButton";
            this.insertTanggalButton.OfficeImageId = "AdpViewGridPane";
            this.insertTanggalButton.ScreenTip = "Insert Tanggal";
            this.insertTanggalButton.SuperTip = "Menyisipkan tanggal hari ini ke dalam dokumen";
            this.insertTanggalButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertTanggalButton_Click);
            // 
            // tanggalLainButton
            // 
            this.tanggalLainButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.tanggalLainButton.Label = "Tanggal Lain";
            this.tanggalLainButton.Name = "tanggalLainButton";
            this.tanggalLainButton.OfficeImageId = "ChartSwitchRowColumn";
            this.tanggalLainButton.ScreenTip = "Tanggal Lain";
            this.tanggalLainButton.ShowImage = true;
            this.tanggalLainButton.SuperTip = "Menyisipkan tanggal yang lalu atau mendatang";
            this.tanggalLainButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.tanggalLainButton_Click);
            // 
            // insertJamButton
            // 
            this.insertJamButton.Items.Add(this.jamLainButton);
            this.insertJamButton.ItemSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.insertJamButton.Label = "Insert Jam";
            this.insertJamButton.Name = "insertJamButton";
            this.insertJamButton.OfficeImageId = "DelayDeliveryOutlook";
            // 
            // jamLainButton
            // 
            this.jamLainButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.jamLainButton.Label = "Jam Lain";
            this.jamLainButton.Name = "jamLainButton";
            this.jamLainButton.OfficeImageId = "DelayDeliveryOutlook";
            this.jamLainButton.ShowImage = true;
            // 
            // button3
            // 
            this.button3.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button3.Label = "Simpan Dokumen";
            this.button3.Name = "button3";
            this.button3.OfficeImageId = "FileSaveAs";
            this.button3.ShowImage = true;
            // 
            // NotarisRibbon
            // 
            this.Name = "NotarisRibbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.NotarisRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton aboutButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bantuanButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton pageSetupButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton buatDokumenSplitButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertBilanganButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button3;
        internal Microsoft.Office.Tools.Ribbon.RibbonSeparator separator1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton insertTanggalButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton tanggalLainButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buatAktaFiduciaButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton insertJamButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton jamLainButton;
    }

    partial class ThisRibbonCollection
    {
        internal NotarisRibbon NotarisRibbon
        {
            get { return this.GetRibbon<NotarisRibbon>(); }
        }
    }
}
