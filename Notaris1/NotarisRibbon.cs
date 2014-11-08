using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Notaris1
{
    public partial class NotarisRibbon
    {
        private void NotarisRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void pageSetupButton_Click(object sender, RibbonControlEventArgs e)
        {
            pageSetupDialog1.PageSettings = new System.Drawing.Printing.PageSettings();
            pageSetupDialog1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
            //pageSetupDialog1.EnableMetric = true;
            //pageSetupDialog1.AllowMargins = true;
            //pageSetupDialog1.ShowDialog();

            pageSetupDialog1.ShowNetwork = false;

            pageSetupDialog1.AllowPrinter = true;

            System.Windows.Forms.DialogResult result = pageSetupDialog1.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                object[] res = new object[] { 
                    pageSetupDialog1.PageSettings.Margins,
                    pageSetupDialog1.PageSettings.PaperSize,
                    pageSetupDialog1.PageSettings.Landscape
                };
                
            }

        }

        private void bantuanButton_Click(object sender, RibbonControlEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Bantuan clicked");
        }

        private void insertBilanganButton_Click(object sender, RibbonControlEventArgs e)
        {
            new FormInsertBilangan().Visible = true;
        }

        private void insertTanggalButton_Click(object sender, RibbonControlEventArgs e)
        {
            BacaBilangan bb = new BacaBilangan();
            /* Ubah bahasa (culture) */
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("id-ID");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;

            DateTime date = DateTime.Now;
            String formattedDate = date.ToString("dddd, d MMMM yyyy");
            String hari = date.ToString("dddd");
            String tanggal = bb.changeNumericToWords(date.ToString("dd"));
            String bulan = date.ToString("MMMM");
            String tahun = bb.changeNumericToWords(date.ToString("yyyy"));
            String result = hari + ", " + tanggal + bulan + " " + tahun;
            Globals.ThisAddIn.insertTanggal(result);
        }

        private void tanggalLainButton_Click(object sender, RibbonControlEventArgs e)
        {
            new FormInsertTanggal().Visible = true;
        }

        private void aboutButton_Click(object sender, RibbonControlEventArgs e)
        {
            new AboutBox().Visible = true;
        }

        private void buatAktaFiduciaButton_Click(object sender, RibbonControlEventArgs e)
        {
            new wizard.FormPihakFidusia().Visible = true;
        }

        private void buatDokumenSplitButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.openTemplateFiducia();
        }



    }
}
