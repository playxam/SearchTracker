namespace SearchTracker
{
    partial class MainWindow
    {
        private System.ComponentModel.IContainer components = null;

        // Set UI components to internal
        internal System.Windows.Forms.TextBox txtDirInfo;
        internal System.Windows.Forms.Label lblBlinkedDirNews;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uIChangeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.Button btnSearchAction;

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
            this.chckBxWord = new System.Windows.Forms.CheckBox();
            this.chckBxTXT = new System.Windows.Forms.CheckBox();
            this.chckBxPDF = new System.Windows.Forms.CheckBox();
            this.chckBxPowerpoint = new System.Windows.Forms.CheckBox();
            this.chckBxExcel = new System.Windows.Forms.CheckBox();
            this.chckBxXML = new System.Windows.Forms.CheckBox();
            this.chckBoxCSV = new System.Windows.Forms.CheckBox();
            this.tabCollectRight = new System.Windows.Forms.TabControl();
            this.tabCachePanel = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chckBxOnlyCacheRead = new System.Windows.Forms.CheckBox();
            this.btnCacheEmpty = new System.Windows.Forms.Button();
            this.lblCacheEmpty = new System.Windows.Forms.Label();
            this.lblCacheReadIn = new System.Windows.Forms.Label();
            this.btnCacheReadIn = new System.Windows.Forms.Button();
            this.listBxCache = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MainMenu.SuspendLayout();
            this.tabCollectRight.SuspendLayout();
            this.tabCachePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1616, 24);
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
            this.txtDir.Font = new System.Drawing.Font("Segoe UI", 11.25F);
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
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtSearch.Location = new System.Drawing.Point(703, 73);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(350, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Suchtext eingeben";
            // 
            // txtDirInfo
            // 
            this.txtDirInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtDirInfo.Location = new System.Drawing.Point(35, 116);
            this.txtDirInfo.Multiline = true;
            this.txtDirInfo.Name = "txtDirInfo";
            this.txtDirInfo.Size = new System.Drawing.Size(532, 71);
            this.txtDirInfo.TabIndex = 3;
            this.txtDirInfo.Visible = false;
            // 
            // lblBlinkedDirNews
            // 
            this.lblBlinkedDirNews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBlinkedDirNews.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.lblBlinkedDirNews.Location = new System.Drawing.Point(196, 37);
            this.lblBlinkedDirNews.Name = "lblBlinkedDirNews";
            this.lblBlinkedDirNews.Size = new System.Drawing.Size(371, 28);
            this.lblBlinkedDirNews.TabIndex = 4;
            this.lblBlinkedDirNews.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBlinkedDirNews.Visible = false;
            // 
            // btnDir
            // 
            this.btnDir.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnDir.Location = new System.Drawing.Point(394, 69);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(173, 34);
            this.btnDir.TabIndex = 5;
            this.btnDir.Text = "Auswahl";
            this.btnDir.UseVisualStyleBackColor = true;
            this.btnDir.Click += new System.EventHandler(this.btnDir_Click);
            // 
            // btnSearchAction
            // 
            this.btnSearchAction.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSearchAction.Location = new System.Drawing.Point(880, 116);
            this.btnSearchAction.Name = "btnSearchAction";
            this.btnSearchAction.Size = new System.Drawing.Size(173, 34);
            this.btnSearchAction.TabIndex = 6;
            this.btnSearchAction.Text = "Suchen";
            this.btnSearchAction.UseVisualStyleBackColor = true;
            // 
            // chckBxWord
            // 
            this.chckBxWord.AutoSize = true;
            this.chckBxWord.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxWord.Location = new System.Drawing.Point(186, 230);
            this.chckBxWord.Name = "chckBxWord";
            this.chckBxWord.Size = new System.Drawing.Size(64, 24);
            this.chckBxWord.TabIndex = 7;
            this.chckBxWord.Text = "Word";
            this.chckBxWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckBxWord.UseVisualStyleBackColor = true;
            // 
            // chckBxTXT
            // 
            this.chckBxTXT.AutoSize = true;
            this.chckBxTXT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxTXT.Location = new System.Drawing.Point(666, 230);
            this.chckBxTXT.Name = "chckBxTXT";
            this.chckBxTXT.Size = new System.Drawing.Size(53, 24);
            this.chckBxTXT.TabIndex = 8;
            this.chckBxTXT.Text = "TXT";
            this.chckBxTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckBxTXT.UseVisualStyleBackColor = true;
            // 
            // chckBxPDF
            // 
            this.chckBxPDF.AutoSize = true;
            this.chckBxPDF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxPDF.Location = new System.Drawing.Point(561, 230);
            this.chckBxPDF.Name = "chckBxPDF";
            this.chckBxPDF.Size = new System.Drawing.Size(54, 24);
            this.chckBxPDF.TabIndex = 9;
            this.chckBxPDF.Text = "PDF";
            this.chckBxPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckBxPDF.UseVisualStyleBackColor = true;
            // 
            // chckBxPowerpoint
            // 
            this.chckBxPowerpoint.AutoSize = true;
            this.chckBxPowerpoint.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxPowerpoint.Location = new System.Drawing.Point(416, 230);
            this.chckBxPowerpoint.Name = "chckBxPowerpoint";
            this.chckBxPowerpoint.Size = new System.Drawing.Size(103, 24);
            this.chckBxPowerpoint.TabIndex = 10;
            this.chckBxPowerpoint.Text = "Powerpoint";
            this.chckBxPowerpoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckBxPowerpoint.UseVisualStyleBackColor = true;
            // 
            // chckBxExcel
            // 
            this.chckBxExcel.AutoSize = true;
            this.chckBxExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxExcel.Location = new System.Drawing.Point(306, 230);
            this.chckBxExcel.Name = "chckBxExcel";
            this.chckBxExcel.Size = new System.Drawing.Size(62, 24);
            this.chckBxExcel.TabIndex = 11;
            this.chckBxExcel.Text = "Excel";
            this.chckBxExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckBxExcel.UseVisualStyleBackColor = true;
            // 
            // chckBxXML
            // 
            this.chckBxXML.AutoSize = true;
            this.chckBxXML.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBxXML.Location = new System.Drawing.Point(861, 230);
            this.chckBxXML.Name = "chckBxXML";
            this.chckBxXML.Size = new System.Drawing.Size(57, 24);
            this.chckBxXML.TabIndex = 12;
            this.chckBxXML.Text = "XML";
            this.chckBxXML.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckBxXML.UseVisualStyleBackColor = true;
            // 
            // chckBoxCSV
            // 
            this.chckBoxCSV.AutoSize = true;
            this.chckBoxCSV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBoxCSV.Location = new System.Drawing.Point(766, 230);
            this.chckBoxCSV.Name = "chckBoxCSV";
            this.chckBoxCSV.Size = new System.Drawing.Size(54, 24);
            this.chckBoxCSV.TabIndex = 13;
            this.chckBoxCSV.Text = "CSV";
            this.chckBoxCSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chckBoxCSV.UseVisualStyleBackColor = true;
            // 
            // tabCollectRight
            // 
            this.tabCollectRight.Controls.Add(this.tabCachePanel);
            this.tabCollectRight.Controls.Add(this.tabPage2);
            this.tabCollectRight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCollectRight.Location = new System.Drawing.Point(1148, 43);
            this.tabCollectRight.Name = "tabCollectRight";
            this.tabCollectRight.SelectedIndex = 0;
            this.tabCollectRight.Size = new System.Drawing.Size(386, 695);
            this.tabCollectRight.TabIndex = 14;
            // 
            // tabCachePanel
            // 
            this.tabCachePanel.BackColor = System.Drawing.Color.Transparent;
            this.tabCachePanel.Controls.Add(this.listBxCache);
            this.tabCachePanel.Controls.Add(this.lblCacheReadIn);
            this.tabCachePanel.Controls.Add(this.btnCacheReadIn);
            this.tabCachePanel.Controls.Add(this.lblCacheEmpty);
            this.tabCachePanel.Controls.Add(this.btnCacheEmpty);
            this.tabCachePanel.Controls.Add(this.chckBxOnlyCacheRead);
            this.tabCachePanel.Location = new System.Drawing.Point(4, 29);
            this.tabCachePanel.Name = "tabCachePanel";
            this.tabCachePanel.Padding = new System.Windows.Forms.Padding(3);
            this.tabCachePanel.Size = new System.Drawing.Size(378, 662);
            this.tabCachePanel.TabIndex = 0;
            this.tabCachePanel.Text = "Cache Section";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(378, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chckBxOnlyCacheRead
            // 
            this.chckBxOnlyCacheRead.AutoSize = true;
            this.chckBxOnlyCacheRead.BackColor = System.Drawing.Color.Transparent;
            this.chckBxOnlyCacheRead.Location = new System.Drawing.Point(79, 20);
            this.chckBxOnlyCacheRead.Name = "chckBxOnlyCacheRead";
            this.chckBxOnlyCacheRead.Size = new System.Drawing.Size(194, 24);
            this.chckBxOnlyCacheRead.TabIndex = 0;
            this.chckBxOnlyCacheRead.Text = "Nur aus dem Cache lesen";
            this.chckBxOnlyCacheRead.UseVisualStyleBackColor = false;
            // 
            // btnCacheEmpty
            // 
            this.btnCacheEmpty.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCacheEmpty.Location = new System.Drawing.Point(199, 75);
            this.btnCacheEmpty.Name = "btnCacheEmpty";
            this.btnCacheEmpty.Size = new System.Drawing.Size(173, 34);
            this.btnCacheEmpty.TabIndex = 15;
            this.btnCacheEmpty.Text = "Cache Leeren";
            this.btnCacheEmpty.UseVisualStyleBackColor = true;
            // 
            // lblCacheEmpty
            // 
            this.lblCacheEmpty.AutoSize = true;
            this.lblCacheEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblCacheEmpty.Location = new System.Drawing.Point(6, 82);
            this.lblCacheEmpty.Name = "lblCacheEmpty";
            this.lblCacheEmpty.Size = new System.Drawing.Size(158, 20);
            this.lblCacheEmpty.TabIndex = 16;
            this.lblCacheEmpty.Text = "Cache komplett leeren";
            // 
            // lblCacheReadIn
            // 
            this.lblCacheReadIn.AutoSize = true;
            this.lblCacheReadIn.BackColor = System.Drawing.Color.Transparent;
            this.lblCacheReadIn.Location = new System.Drawing.Point(201, 165);
            this.lblCacheReadIn.Name = "lblCacheReadIn";
            this.lblCacheReadIn.Size = new System.Drawing.Size(171, 20);
            this.lblCacheReadIn.TabIndex = 18;
            this.lblCacheReadIn.Text = "Cache komplett einlesen";
            // 
            // btnCacheReadIn
            // 
            this.btnCacheReadIn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnCacheReadIn.Location = new System.Drawing.Point(6, 158);
            this.btnCacheReadIn.Name = "btnCacheReadIn";
            this.btnCacheReadIn.Size = new System.Drawing.Size(173, 34);
            this.btnCacheReadIn.TabIndex = 17;
            this.btnCacheReadIn.Text = "Einlesen";
            this.btnCacheReadIn.UseVisualStyleBackColor = true;
            // 
            // listBxCache
            // 
            this.listBxCache.FormattingEnabled = true;
            this.listBxCache.ItemHeight = 20;
            this.listBxCache.Location = new System.Drawing.Point(6, 245);
            this.listBxCache.Name = "listBxCache";
            this.listBxCache.Size = new System.Drawing.Size(366, 144);
            this.listBxCache.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(967, 452);
            this.dataGridView1.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(1616, 779);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabCollectRight);
            this.Controls.Add(this.chckBoxCSV);
            this.Controls.Add(this.chckBxXML);
            this.Controls.Add(this.chckBxExcel);
            this.Controls.Add(this.chckBxPowerpoint);
            this.Controls.Add(this.chckBxPDF);
            this.Controls.Add(this.chckBxTXT);
            this.Controls.Add(this.chckBxWord);
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
            this.tabCollectRight.ResumeLayout(false);
            this.tabCachePanel.ResumeLayout(false);
            this.tabCachePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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

        private System.Windows.Forms.CheckBox chckBxWord;
        private System.Windows.Forms.CheckBox chckBxTXT;
        private System.Windows.Forms.CheckBox chckBxPDF;
        private System.Windows.Forms.CheckBox chckBxPowerpoint;
        private System.Windows.Forms.CheckBox chckBxExcel;
        private System.Windows.Forms.CheckBox chckBxXML;
        private System.Windows.Forms.CheckBox chckBoxCSV;
        private System.Windows.Forms.TabControl tabCollectRight;
        private System.Windows.Forms.TabPage tabCachePanel;
        private System.Windows.Forms.CheckBox chckBxOnlyCacheRead;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCacheEmpty;
        private System.Windows.Forms.Label lblCacheEmpty;
        private System.Windows.Forms.Label lblCacheReadIn;
        private System.Windows.Forms.Button btnCacheReadIn;
        private System.Windows.Forms.ListBox listBxCache;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
