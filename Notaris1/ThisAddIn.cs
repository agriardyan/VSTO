using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Interop.Word;

namespace Notaris1
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {

        }

        public void insertBilangan(int mataUang, String bacaan)
        {
            String currency = "";

            Word.Selection currentSelection = Application.Selection;

            bool userOvertype = Application.Options.Overtype;

            if (Application.Options.Overtype)
            {
                Application.Options.Overtype = false;  
            }

            switch (mataUang)
            {
                case 0:
                    currency = "Rupiah";
                    break;
                case 1:
                    currency = "US Dollars";
                    break;
                case 2:
                    currency = "Euro";
                    break;
                default:
                    currency = "Rupiah";
                    break;
            }

            if (currentSelection.Type == Word.WdSelectionType.wdSelectionIP)
            {
                currentSelection.TypeText(bacaan + currency);
                currentSelection.TypeParagraph();
            }
            else
            {
                if (currentSelection.Type == Word.WdSelectionType.wdSelectionNormal)
                {
                    if (Application.Options.ReplaceSelection)
                    {
                        object direction = Word.WdCollapseDirection.wdCollapseStart;
                        currentSelection.Collapse(ref direction);
                    }
                    currentSelection.TypeText("Inserting before a text block");
                    currentSelection.TypeParagraph();
                }
                else
                {
                    // Do nothing
                }
            }

            Application.Options.Overtype = userOvertype;
        }

        public void garisPutus()
        {
            // still to do
        }

        public void insertTanggal(String bacaan)
        {
            Word.Selection currentSelection = Application.Selection;

            bool userOvertype = Application.Options.Overtype;

            if (Application.Options.Overtype)
            {
                Application.Options.Overtype = false;
            }

            if (currentSelection.Type == Word.WdSelectionType.wdSelectionIP)
            {
                currentSelection.TypeText(bacaan);
                currentSelection.TypeParagraph();
            }
            else
            {
                if (currentSelection.Type == Word.WdSelectionType.wdSelectionNormal)
                {
                    if (Application.Options.ReplaceSelection)
                    {
                        object direction = Word.WdCollapseDirection.wdCollapseStart;
                        currentSelection.Collapse(ref direction);
                    }
                    currentSelection.TypeText("Inserting before a text block");
                    currentSelection.TypeParagraph();
                }
                else
                {
                    // Do nothing
                }
            }

            Application.Options.Overtype = userOvertype;
        }

        public void openTemplateFiducia()
        {
            Word.Application word = new Word.Application();
            Word.Document doc = word.Documents.Open("\templateDocument\templateFiducia.dotx");

            /*
            foreach (Field myMergeField in doc.Fields)
            {
                Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {
                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLength = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);
                    fieldName = fieldName.Trim();

                    if (fieldName == "name")
                    {
                        myMergeField.Select();
                        word.Selection.TypeText("John");
                    }

                }
            }
             */
            
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
