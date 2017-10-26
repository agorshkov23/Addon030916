using System;
using Microsoft.Office.Interop.Excel;

namespace Addon030916
{
    public partial class ThisAddIn
    {
        public void ZeroNegative()
        {
            foreach (Range cell in Application.Selection)
            {
                if (cell.Value2 is Double && cell.Value2 < 0.0)
                {
                    cell.Value2 = 0.0;
                }
            }
        }

        public void BankRound()
        {
            foreach (Range cell in Application.Selection)
            {
                if (cell.Value2 is Double)
                {
                    cell.Value2 = Math.Round(cell.Value2);
                }
            }
        }

        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            Startup += new EventHandler(ThisAddIn_Startup);
            Shutdown += new EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
