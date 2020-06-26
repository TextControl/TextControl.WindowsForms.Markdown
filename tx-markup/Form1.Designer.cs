namespace tx_markup
{
    partial class Form1
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
            this.textControl1 = new TXTextControl.TextControl();
            this.textControl2 = new TXTextControl.TextControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sidebar1 = new TXTextControl.Windows.Forms.Sidebar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textControl1
            // 
            this.textControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl1.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl1.Location = new System.Drawing.Point(20, 0);
            this.textControl1.Name = "textControl1";
            this.textControl1.Size = new System.Drawing.Size(487, 656);
            this.textControl1.TabIndex = 1;
            this.textControl1.UserNames = null;
            this.textControl1.ViewMode = TXTextControl.ViewMode.FloatingText;
            this.textControl1.Changed += new System.EventHandler(this.textControl1_Changed);
            // 
            // textControl2
            // 
            this.textControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textControl2.Font = new System.Drawing.Font("Arial", 10F);
            this.textControl2.Location = new System.Drawing.Point(0, 0);
            this.textControl2.Name = "textControl2";
            this.textControl2.PageMargins.Bottom = 78.75D;
            this.textControl2.PageMargins.Left = 78.75D;
            this.textControl2.PageMargins.Right = 78.75D;
            this.textControl2.PageMargins.Top = 78.75D;
            this.textControl2.PageSize.Height = 1169.31D;
            this.textControl2.PageSize.Width = 826.81D;
            this.textControl2.Size = new System.Drawing.Size(398, 656);
            this.textControl2.TabIndex = 2;
            this.textControl2.UserNames = null;
            this.textControl2.Resize += new System.EventHandler(this.textControl2_Resize);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.textControl1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textControl2);
            this.splitContainer1.Panel2.Controls.Add(this.sidebar1);
            this.splitContainer1.Size = new System.Drawing.Size(1131, 656);
            this.splitContainer1.SplitterDistance = 507;
            this.splitContainer1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sidebar1
            // 
            this.sidebar1.ContentLayout = TXTextControl.Windows.Forms.Sidebar.SidebarContentLayout.Styles;
            this.sidebar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidebar1.Location = new System.Drawing.Point(398, 0);
            this.sidebar1.Name = "sidebar1";
            this.sidebar1.ShowCloseButton = false;
            this.sidebar1.ShowPinButton = false;
            this.sidebar1.Size = new System.Drawing.Size(222, 656);
            this.sidebar1.TabIndex = 3;
            this.sidebar1.TextControl = this.textControl2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 680);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Markdown Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TXTextControl.TextControl textControl1;
        private TXTextControl.TextControl textControl2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private TXTextControl.Windows.Forms.Sidebar sidebar1;
    }
}

