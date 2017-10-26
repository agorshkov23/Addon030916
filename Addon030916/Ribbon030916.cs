using Microsoft.Office.Tools.Ribbon;

namespace Addon030916
{
    public partial class Ribbon030916
    {
        private void Ribbon030916_Load(object sender, RibbonUIEventArgs e)
        {
        }

        private void ZeroNegativeButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.ZeroNegative();
        }

        private void BankRoundButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.BankRound();
        }
    }
}
