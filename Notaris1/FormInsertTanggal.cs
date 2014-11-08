using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notaris1
{
    public partial class FormInsertTanggal : Form
    {
        public FormInsertTanggal()
        {
            InitializeComponent();
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("id-ID");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;

            
        }

        private void insertTanggalButton_Click(object sender, EventArgs e)
        {
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo ci = new System.Globalization.CultureInfo("id-ID");
            System.Threading.Thread.CurrentThread.CurrentCulture = ci;

            DateTime date = DateTime.Parse("22/2/2012");
            string formattedDate = date.ToString("dddd, d MMMM yyyy");
            label1.Text = formattedDate;

            label2.Text = date.ToString("dd/MM/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BacaBilangan bb = new BacaBilangan();
            string[] separators = { ",", ".", "!", "?", ";", ":", " ", "/" };
            string value = label2.Text;
            string[] words = value.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                String a = bb.changeNumericToWords(Convert.ToDouble(word));
                label3.Text = label3.Text + " " + a;
            }
        }
         * */
    }
}
