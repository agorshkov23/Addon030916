namespace Addon030916
{
    partial class Ribbon030916 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon030916()
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
            this.Tab = this.Factory.CreateRibbonTab();
            this.GeneralGroup = this.Factory.CreateRibbonGroup();
            this.ZeroNegativeButton = this.Factory.CreateRibbonButton();
            this.BankRoundButton = this.Factory.CreateRibbonButton();
            this.Tab.SuspendLayout();
            this.GeneralGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab
            // 
            this.Tab.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.Tab.Groups.Add(this.GeneralGroup);
            this.Tab.Label = "030916";
            this.Tab.Name = "Tab";
            // 
            // GeneralGroup
            // 
            this.GeneralGroup.Items.Add(this.ZeroNegativeButton);
            this.GeneralGroup.Items.Add(this.BankRoundButton);
            this.GeneralGroup.Label = "Общие";
            this.GeneralGroup.Name = "GeneralGroup";
            // 
            // ZeroNegativeButton
            // 
            this.ZeroNegativeButton.Label = "Обнулить отрицательные";
            this.ZeroNegativeButton.Name = "ZeroNegativeButton";
            this.ZeroNegativeButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ZeroNegativeButton_Click);
            // 
            // BankRoundButton
            // 
            this.BankRoundButton.Label = "Банковское округление";
            this.BankRoundButton.Name = "BankRoundButton";
            this.BankRoundButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BankRoundButton_Click);
            // 
            // Ribbon030916
            // 
            this.Name = "Ribbon030916";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.Tab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon030916_Load);
            this.Tab.ResumeLayout(false);
            this.Tab.PerformLayout();
            this.GeneralGroup.ResumeLayout(false);
            this.GeneralGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab Tab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup GeneralGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ZeroNegativeButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BankRoundButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon030916 Ribbon030916
        {
            get { return this.GetRibbon<Ribbon030916>(); }
        }
    }
}
