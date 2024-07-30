namespace SearchTracker
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uIChangeToolStripMenuItem;

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uIChangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtDirInfo = new System.Windows.Forms.TextBox();
            this.lblBlinkedDirNews = new System.Windows.Forms.Label();
            this.btnDir = new System.Windows.Forms.Button();
            this.btnSearchAction = new System.Windows.Forms.Button();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1379, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "MainMenu";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.uIChangeToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // uIChangeToolStripMenuItem
            // 
            this.uIChangeToolStripMenuItem.Name = "uIChangeToolStripMenuItem";
            this.uIChangeToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.uIChangeToolStripMenuItem.Text = "UI-Change";
            this.uIChangeToolStripMenuItem.Click += new System.EventHandler(this.UIChangeToolStripMenuItem_Click);
            // 
            // txtDir
            // 
            this.txtDir.AcceptsReturn = true;
            this.txtDir.AcceptsTab = true;
            this.txtDir.AllowDrop = true;
            this.txtDir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDir.Location = new System.Drawing.Point(35, 73);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(330, 27);
            this.txtDir.TabIndex = 1;
            this.txtDir.Text = "Verzeichnis angeben";
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = true;
            this.txtSearch.AcceptsTab = true;
            this.txtSearch.AllowDrop = true;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(703, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Suchtext eingeben";
            // 
            // txtDirInfo
            // 
            this.txtDirInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirInfo.Location = new System.Drawing.Point(35, 116);
            this.txtDirInfo.Multiline = true;
            this.txtDirInfo.Name = "txtDirInfo";
            this.txtDirInfo.Size = new System.Drawing.Size(330, 71);
            this.txtDirInfo.TabIndex = 3;
            this.txtDirInfo.Visible = false;
            // 
            // lblBlinkedDirNews
            // 
            this.lblBlinkedDirNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlinkedDirNews.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlinkedDirNews.Location = new System.Drawing.Point(196, 37);
            this.lblBlinkedDirNews.Name = "lblBlinkedDirNews";
            this.lblBlinkedDirNews.Size = new System.Drawing.Size(371, 28);
            this.lblBlinkedDirNews.TabIndex = 4;
            this.lblBlinkedDirNews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBlinkedDirNews.Visible = false;
            // 
            // btnDir
            // 
            this.btnDir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDir.Location = new System.Drawing.Point(394, 69);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(173, 34);
            this.btnDir.TabIndex = 5;
            this.btnDir.Text = "Auswahl";
            this.btnDir.UseVisualStyleBackColor = true;
            // 
            // btnSearchAction
            // 
            this.btnSearchAction.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAction.Location = new System.Drawing.Point(930, 116);
            this.btnSearchAction.Name = "btnSearchAction";
            this.btnSearchAction.Size = new System.Drawing.Size(173, 34);
            this.btnSearchAction.TabIndex = 6;
            this.btnSearchAction.Text = "Suchen";
            this.btnSearchAction.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1379, 779);
            this.Controls.Add(this.btnSearchAction);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.lblBlinkedDirNews);
            this.Controls.Add(this.txtDirInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainWindow";
            this.Text = "SearchTracker";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /// <summary>
        /// Bereinigt alle verwendeten Ressourcen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDirInfo;
        private System.Windows.Forms.Label lblBlinkedDirNews;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnSearchAction;
    }
}
