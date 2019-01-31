namespace odevV2
{
    partial class musteriPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapÖzetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapKapamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapAçmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraToolStripMenuItem,
            this.paraYatırmaToolStripMenuItem,
            this.havaleYapToolStripMenuItem,
            this.hesapÖzetiToolStripMenuItem,
            this.hesapKapamaToolStripMenuItem,
            this.hesapAçmaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(863, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paraToolStripMenuItem
            // 
            this.paraToolStripMenuItem.Name = "paraToolStripMenuItem";
            this.paraToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.paraToolStripMenuItem.Text = "Para Çekme";
            this.paraToolStripMenuItem.Click += new System.EventHandler(this.paraToolStripMenuItem_Click);
            // 
            // paraYatırmaToolStripMenuItem
            // 
            this.paraYatırmaToolStripMenuItem.Name = "paraYatırmaToolStripMenuItem";
            this.paraYatırmaToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.paraYatırmaToolStripMenuItem.Text = "Para Yatırma";
            this.paraYatırmaToolStripMenuItem.Click += new System.EventHandler(this.paraYatırmaToolStripMenuItem_Click);
            // 
            // havaleYapToolStripMenuItem
            // 
            this.havaleYapToolStripMenuItem.Name = "havaleYapToolStripMenuItem";
            this.havaleYapToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.havaleYapToolStripMenuItem.Text = "Havale Yap";
            this.havaleYapToolStripMenuItem.Click += new System.EventHandler(this.havaleYapToolStripMenuItem_Click);
            // 
            // hesapÖzetiToolStripMenuItem
            // 
            this.hesapÖzetiToolStripMenuItem.Name = "hesapÖzetiToolStripMenuItem";
            this.hesapÖzetiToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.hesapÖzetiToolStripMenuItem.Text = "Hesap Özeti";
            this.hesapÖzetiToolStripMenuItem.Click += new System.EventHandler(this.hesapÖzetiToolStripMenuItem_Click);
            // 
            // hesapKapamaToolStripMenuItem
            // 
            this.hesapKapamaToolStripMenuItem.Name = "hesapKapamaToolStripMenuItem";
            this.hesapKapamaToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.hesapKapamaToolStripMenuItem.Text = "Hesap Kapama";
            this.hesapKapamaToolStripMenuItem.Click += new System.EventHandler(this.hesapKapamaToolStripMenuItem_Click);
            // 
            // hesapAçmaToolStripMenuItem
            // 
            this.hesapAçmaToolStripMenuItem.Name = "hesapAçmaToolStripMenuItem";
            this.hesapAçmaToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.hesapAçmaToolStripMenuItem.Text = "Hesap Açma";
            this.hesapAçmaToolStripMenuItem.Click += new System.EventHandler(this.hesapAçmaToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // musteriPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(863, 516);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "musteriPanel";
            this.Text = "musteriPanel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapÖzetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapKapamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapAçmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}