namespace SearchTracker
{
    partial class ThemeManageWindow
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cbBoxThemeChange;
        private System.Windows.Forms.Label lblThemeChange;
        private System.Windows.Forms.Label lblUeberschrift;

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbBoxThemeChange = new System.Windows.Forms.ComboBox();
            this.lblThemeChange = new System.Windows.Forms.Label();
            this.lblUeberschrift = new System.Windows.Forms.Label();

            // cbBoxThemeChange
            this.cbBoxThemeChange.FormattingEnabled = true;
            this.cbBoxThemeChange.Location = new System.Drawing.Point(427, 153);
            this.cbBoxThemeChange.Name = "cbBoxThemeChange";
            this.cbBoxThemeChange.Size = new System.Drawing.Size(200, 28);
            this.cbBoxThemeChange.TabIndex = 0;

            // lblThemeChange
            this.lblThemeChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblThemeChange.Location = new System.Drawing.Point(111, 152);
            this.lblThemeChange.Name = "lblThemeChange";
            this.lblThemeChange.Size = new System.Drawing.Size(200, 28);
            this.lblThemeChange.TabIndex = 1;
            this.lblThemeChange.Text = "GUI Theme wechseln";
            this.lblThemeChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblUeberschrift
            this.lblUeberschrift.Location = new System.Drawing.Point(275, 24);
            this.lblUeberschrift.Name = "lblUeberschrift";
            this.lblUeberschrift.Size = new System.Drawing.Size(200, 28);
            this.lblUeberschrift.TabIndex = 2;
            this.lblUeberschrift.Text = "Hier kannst du das Aussehen wechseln";
            this.lblUeberschrift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ThemeManageWindow
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbBoxThemeChange);
            this.Controls.Add(this.lblThemeChange);
            this.Controls.Add(this.lblUeberschrift);
            this.Name = "ThemeManageWindow";
            this.Text = "ThemeManageWindow";
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
    }
}
