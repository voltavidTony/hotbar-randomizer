using System.Drawing;

namespace Hotbar_Randomizer {
    partial class AboutBox1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.bookLayout = new System.Windows.Forms.TableLayoutPanel();
            this.forwardButton = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Panel();
            this.aboutRTF = new Hotbar_Randomizer.RichTextBoxTransparent();
            this.pageCount = new System.Windows.Forms.Label();
            this.bookLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookLayout
            // 
            this.bookLayout.BackColor = System.Drawing.Color.Transparent;
            this.bookLayout.ColumnCount = 5;
            this.bookLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.bookLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.bookLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bookLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.bookLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.bookLayout.Controls.Add(this.forwardButton, 3, 1);
            this.bookLayout.Controls.Add(this.backButton, 1, 1);
            this.bookLayout.Controls.Add(this.aboutRTF, 0, 0);
            this.bookLayout.Controls.Add(this.pageCount, 2, 1);
            this.bookLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookLayout.Location = new System.Drawing.Point(9, 9);
            this.bookLayout.Name = "bookLayout";
            this.bookLayout.RowCount = 3;
            this.bookLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bookLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.bookLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.bookLayout.Size = new System.Drawing.Size(566, 702);
            this.bookLayout.TabIndex = 0;
            this.bookLayout.Click += new System.EventHandler(this.BookLayout_Click);
            this.bookLayout.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookLayout_MouseMove);
            // 
            // forwardButton
            // 
            this.forwardButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forwardButton.Location = new System.Drawing.Point(390, 626);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(0);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(72, 40);
            this.forwardButton.TabIndex = 1;
            this.forwardButton.Tag = new System.Drawing.Rectangle(0, 0, 72, 40);
            this.forwardButton.Click += new System.EventHandler(this.ButtonForward_Click);
            this.forwardButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
            this.forwardButton.DoubleClick += new System.EventHandler(this.ButtonForward_Click);
            this.forwardButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.forwardButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // backButton
            // 
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.Enabled = false;
            this.backButton.Location = new System.Drawing.Point(92, 626);
            this.backButton.Margin = new System.Windows.Forms.Padding(0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(72, 40);
            this.backButton.TabIndex = 0;
            this.backButton.Tag = new System.Drawing.Rectangle(0, 40, 72, 40);
            this.backButton.Click += new System.EventHandler(this.ButtonBack_Click);
            this.backButton.Paint += new System.Windows.Forms.PaintEventHandler(this.Button_Paint);
            this.backButton.DoubleClick += new System.EventHandler(this.ButtonBack_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // aboutRTF
            // 
            this.aboutRTF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookLayout.SetColumnSpan(this.aboutRTF, 5);
            this.aboutRTF.Cursor = System.Windows.Forms.Cursors.Default;
            this.aboutRTF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutRTF.Location = new System.Drawing.Point(52, 48);
            this.aboutRTF.Margin = new System.Windows.Forms.Padding(52, 48, 52, 4);
            this.aboutRTF.Name = "aboutRTF";
            this.aboutRTF.ReadOnly = true;
            this.aboutRTF.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.aboutRTF.Size = new System.Drawing.Size(462, 574);
            this.aboutRTF.TabIndex = 2;
            this.aboutRTF.TabStop = false;
            this.aboutRTF.Text = "";
            this.aboutRTF.TransparentToMouse = true;
            this.aboutRTF.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.AboutRTF_LinkClicked);
            // 
            // pageCount
            // 
            this.pageCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pageCount.AutoSize = true;
            this.pageCount.Location = new System.Drawing.Point(265, 639);
            this.pageCount.Name = "pageCount";
            this.pageCount.Size = new System.Drawing.Size(24, 13);
            this.pageCount.TabIndex = 4;
            this.pageCount.Text = "0/0";
            // 
            // AboutBox1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.book;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(584, 720);
            this.Controls.Add(this.bookLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox1";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(8)))), ((int)(((byte)(0)))));
            this.Deactivate += new System.EventHandler(this.AboutBox1_Deactivate);
            this.Shown += new System.EventHandler(this.AboutBox1_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.AboutBox1_KeyUp);
            this.bookLayout.ResumeLayout(false);
            this.bookLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel bookLayout;
        private System.Windows.Forms.Panel backButton;
        private System.Windows.Forms.Panel forwardButton;
        private RichTextBoxTransparent aboutRTF;
        private System.Windows.Forms.Label pageCount;
    }
}
