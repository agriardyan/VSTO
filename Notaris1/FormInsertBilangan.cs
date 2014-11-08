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
    public partial class FormInsertBilangan : Form
    {
        public FormInsertBilangan()
        {
            InitializeComponent();
        }

        private void insertBilanganButton_Click(object sender, EventArgs e)
        {
            BacaBilangan bb = new BacaBilangan();
            String bil = insertBilanganTextBox.Text;
            String baca = bb.changeNumericToWords(Convert.ToDouble(bil));
            int mataUang = mataUangComboBox.SelectedIndex;
            Globals.ThisAddIn.insertBilangan(mataUang, baca);
        }
    }
}
