
namespace Presentation.Forms
{
    partial class FormMain
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
            this.MaunMenu = new System.Windows.Forms.MenuStrip();
            this.MenuItemMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVoucher = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemManager = new System.Windows.Forms.ToolStripMenuItem();
            this.MaunMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaunMenu
            // 
            this.MaunMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemMaintenance,
            this.MenuItemVoucher,
            this.MenuItemManager});
            this.MaunMenu.Location = new System.Drawing.Point(0, 0);
            this.MaunMenu.Name = "MaunMenu";
            this.MaunMenu.Size = new System.Drawing.Size(800, 24);
            this.MaunMenu.TabIndex = 0;
            this.MaunMenu.Text = "menuStrip1";
            this.MaunMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MaunMenu_ItemClicked);
            // 
            // MenuItemMaintenance
            // 
            this.MenuItemMaintenance.Name = "MenuItemMaintenance";
            this.MenuItemMaintenance.Size = new System.Drawing.Size(101, 20);
            this.MenuItemMaintenance.Text = "Mantenimiento";
            this.MenuItemMaintenance.Click += new System.EventHandler(this.MenuItemMaintenance_Click);
            // 
            // MenuItemVoucher
            // 
            this.MenuItemVoucher.Name = "MenuItemVoucher";
            this.MenuItemVoucher.Size = new System.Drawing.Size(98, 20);
            this.MenuItemVoucher.Text = "Comprobantes";
            this.MenuItemVoucher.Click += new System.EventHandler(this.MenuItemVoucher_Click);
            // 
            // MenuItemManager
            // 
            this.MenuItemManager.Name = "MenuItemManager";
            this.MenuItemManager.Size = new System.Drawing.Size(65, 20);
            this.MenuItemManager.Text = "Gerencia";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MaunMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MaunMenu;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROCONT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MaunMenu.ResumeLayout(false);
            this.MaunMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MaunMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuItemMaintenance;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVoucher;
        private System.Windows.Forms.ToolStripMenuItem MenuItemManager;
    }
}