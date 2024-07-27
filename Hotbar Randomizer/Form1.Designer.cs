namespace Hotbar_Randomizer {
    partial class HotbarRandomizerWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotbarRandomizerWindow));
            this.mainFrame = new System.Windows.Forms.TableLayoutPanel();
            this.optionsFrame = new System.Windows.Forms.TableLayoutPanel();
            this.leverSlots = new System.Windows.Forms.Panel();
            this.layoutSwap = new System.Windows.Forms.TableLayoutPanel();
            this.labelSwap = new System.Windows.Forms.Label();
            this.layoutSignSlots = new System.Windows.Forms.TableLayoutPanel();
            this.labelSlots = new System.Windows.Forms.Label();
            this.leverSwap = new System.Windows.Forms.Panel();
            this.panelCmd = new System.Windows.Forms.Panel();
            this.leverCount = new System.Windows.Forms.Panel();
            this.layoutCount = new System.Windows.Forms.TableLayoutPanel();
            this.labelCount = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.TableLayoutPanel();
            this.layoutClose = new System.Windows.Forms.TableLayoutPanel();
            this.layoutQuestion = new System.Windows.Forms.TableLayoutPanel();
            this.hotbarLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.mainFrame.SuspendLayout();
            this.optionsFrame.SuspendLayout();
            this.layoutSwap.SuspendLayout();
            this.layoutSignSlots.SuspendLayout();
            this.layoutCount.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.hotbarLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFrame
            // 
            this.mainFrame.AutoSize = true;
            this.mainFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainFrame.BackColor = System.Drawing.Color.Transparent;
            this.mainFrame.ColumnCount = 1;
            this.mainFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainFrame.Controls.Add(this.optionsFrame, 0, 1);
            this.mainFrame.Controls.Add(this.titleBar, 0, 0);
            this.mainFrame.Controls.Add(this.hotbarLayout, 0, 2);
            this.mainFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFrame.Location = new System.Drawing.Point(0, 0);
            this.mainFrame.Name = "mainFrame";
            this.mainFrame.RowCount = 3;
            this.mainFrame.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFrame.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFrame.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainFrame.Size = new System.Drawing.Size(576, 369);
            this.mainFrame.TabIndex = 0;
            // 
            // optionsFrame
            // 
            this.optionsFrame.AutoSize = true;
            this.optionsFrame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optionsFrame.BackColor = System.Drawing.Color.Transparent;
            this.optionsFrame.ColumnCount = 4;
            this.optionsFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.optionsFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.optionsFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.optionsFrame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.optionsFrame.Controls.Add(this.leverSlots, 3, 0);
            this.optionsFrame.Controls.Add(this.layoutSwap, 1, 0);
            this.optionsFrame.Controls.Add(this.layoutSignSlots, 2, 0);
            this.optionsFrame.Controls.Add(this.leverSwap, 0, 0);
            this.optionsFrame.Controls.Add(this.panelCmd, 2, 1);
            this.optionsFrame.Controls.Add(this.leverCount, 0, 1);
            this.optionsFrame.Controls.Add(this.layoutCount, 1, 1);
            this.optionsFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsFrame.Location = new System.Drawing.Point(0, 32);
            this.optionsFrame.Margin = new System.Windows.Forms.Padding(0);
            this.optionsFrame.Name = "optionsFrame";
            this.optionsFrame.RowCount = 2;
            this.optionsFrame.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.optionsFrame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.optionsFrame.Size = new System.Drawing.Size(576, 256);
            this.optionsFrame.TabIndex = 3;
            // 
            // leverSlots
            // 
            this.leverSlots.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.lever_off;
            this.leverSlots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leverSlots.Location = new System.Drawing.Point(480, 0);
            this.leverSlots.Margin = new System.Windows.Forms.Padding(0);
            this.leverSlots.Name = "leverSlots";
            this.leverSlots.Size = new System.Drawing.Size(96, 128);
            this.leverSlots.TabIndex = 5;
            this.leverSlots.Click += new System.EventHandler(this.LeverSlots_Click);
            this.leverSlots.DoubleClick += new System.EventHandler(this.LeverSlots_Click);
            // 
            // layoutSwap
            // 
            this.layoutSwap.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.sign;
            this.layoutSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.layoutSwap.ColumnCount = 1;
            this.layoutSwap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutSwap.Controls.Add(this.labelSwap, 0, 0);
            this.layoutSwap.Location = new System.Drawing.Point(96, 0);
            this.layoutSwap.Margin = new System.Windows.Forms.Padding(0);
            this.layoutSwap.Name = "layoutSwap";
            this.layoutSwap.RowCount = 1;
            this.layoutSwap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutSwap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.layoutSwap.Size = new System.Drawing.Size(192, 128);
            this.layoutSwap.TabIndex = 3;
            // 
            // labelSwap
            // 
            this.labelSwap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSwap.AutoSize = true;
            this.labelSwap.ForeColor = System.Drawing.Color.Black;
            this.labelSwap.Location = new System.Drawing.Point(23, 57);
            this.labelSwap.MaximumSize = new System.Drawing.Size(150, 0);
            this.labelSwap.Name = "labelSwap";
            this.labelSwap.Size = new System.Drawing.Size(145, 13);
            this.labelSwap.TabIndex = 0;
            this.labelSwap.Text = "Swap to offhand while mining";
            this.labelSwap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutSignSlots
            // 
            this.layoutSignSlots.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.sign;
            this.layoutSignSlots.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.layoutSignSlots.ColumnCount = 1;
            this.layoutSignSlots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutSignSlots.Controls.Add(this.labelSlots, 0, 0);
            this.layoutSignSlots.Location = new System.Drawing.Point(288, 0);
            this.layoutSignSlots.Margin = new System.Windows.Forms.Padding(0);
            this.layoutSignSlots.Name = "layoutSignSlots";
            this.layoutSignSlots.RowCount = 1;
            this.layoutSignSlots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutSignSlots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.layoutSignSlots.Size = new System.Drawing.Size(192, 128);
            this.layoutSignSlots.TabIndex = 2;
            // 
            // labelSlots
            // 
            this.labelSlots.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSlots.AutoSize = true;
            this.labelSlots.ForeColor = System.Drawing.Color.Black;
            this.labelSlots.Location = new System.Drawing.Point(34, 51);
            this.labelSlots.MaximumSize = new System.Drawing.Size(150, 0);
            this.labelSlots.Name = "labelSlots";
            this.labelSlots.Size = new System.Drawing.Size(123, 26);
            this.labelSlots.TabIndex = 0;
            this.labelSlots.Text = "Select random slot when placing block";
            this.labelSlots.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leverSwap
            // 
            this.leverSwap.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.lever_off;
            this.leverSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leverSwap.Location = new System.Drawing.Point(0, 0);
            this.leverSwap.Margin = new System.Windows.Forms.Padding(0);
            this.leverSwap.Name = "leverSwap";
            this.leverSwap.Size = new System.Drawing.Size(96, 128);
            this.leverSwap.TabIndex = 4;
            this.leverSwap.Click += new System.EventHandler(this.LeverSwap_Click);
            this.leverSwap.DoubleClick += new System.EventHandler(this.LeverSwap_Click);
            // 
            // panelCmd
            // 
            this.panelCmd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.optionsFrame.SetColumnSpan(this.panelCmd, 2);
            this.panelCmd.Location = new System.Drawing.Point(307, 182);
            this.panelCmd.Margin = new System.Windows.Forms.Padding(0);
            this.panelCmd.Name = "panelCmd";
            this.panelCmd.Size = new System.Drawing.Size(250, 20);
            this.panelCmd.TabIndex = 6;
            this.panelCmd.Visible = false;
            this.panelCmd.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCmd_Paint);
            // 
            // leverCount
            // 
            this.leverCount.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.lever_off;
            this.leverCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leverCount.Location = new System.Drawing.Point(0, 128);
            this.leverCount.Margin = new System.Windows.Forms.Padding(0);
            this.leverCount.Name = "leverCount";
            this.leverCount.Size = new System.Drawing.Size(96, 128);
            this.leverCount.TabIndex = 7;
            this.leverCount.Click += new System.EventHandler(this.LeverCount_Click);
            this.leverCount.DoubleClick += new System.EventHandler(this.LeverCount_Click);
            // 
            // layoutCount
            // 
            this.layoutCount.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.sign;
            this.layoutCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.layoutCount.ColumnCount = 1;
            this.layoutCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCount.Controls.Add(this.labelCount, 0, 0);
            this.layoutCount.Location = new System.Drawing.Point(96, 128);
            this.layoutCount.Margin = new System.Windows.Forms.Padding(0);
            this.layoutCount.Name = "layoutCount";
            this.layoutCount.RowCount = 1;
            this.layoutCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCount.Size = new System.Drawing.Size(192, 128);
            this.layoutCount.TabIndex = 8;
            // 
            // labelCount
            // 
            this.labelCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCount.AutoSize = true;
            this.labelCount.ForeColor = System.Drawing.Color.Black;
            this.labelCount.Location = new System.Drawing.Point(24, 51);
            this.labelCount.MaximumSize = new System.Drawing.Size(150, 0);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(143, 26);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Decrement current slot when placing block";
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleBar
            // 
            this.titleBar.AutoSize = true;
            this.titleBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.titleBar.BackColor = System.Drawing.Color.Transparent;
            this.titleBar.ColumnCount = 3;
            this.titleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.titleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.titleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.titleBar.Controls.Add(this.layoutClose, 2, 0);
            this.titleBar.Controls.Add(this.layoutQuestion, 1, 0);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(0);
            this.titleBar.Name = "titleBar";
            this.titleBar.RowCount = 1;
            this.titleBar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.titleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.titleBar.Size = new System.Drawing.Size(576, 32);
            this.titleBar.TabIndex = 4;
            this.titleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBar_Paint);
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // layoutClose
            // 
            this.layoutClose.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.button_off;
            this.layoutClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.layoutClose.ColumnCount = 1;
            this.layoutClose.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutClose.Location = new System.Drawing.Point(528, 0);
            this.layoutClose.Margin = new System.Windows.Forms.Padding(0);
            this.layoutClose.Name = "layoutClose";
            this.layoutClose.RowCount = 1;
            this.layoutClose.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutClose.Size = new System.Drawing.Size(48, 32);
            this.layoutClose.TabIndex = 6;
            this.layoutClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.layoutClose.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonClose_Paint);
            // 
            // layoutQuestion
            // 
            this.layoutQuestion.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.button_off;
            this.layoutQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.layoutQuestion.ColumnCount = 1;
            this.layoutQuestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutQuestion.Location = new System.Drawing.Point(480, 0);
            this.layoutQuestion.Margin = new System.Windows.Forms.Padding(0);
            this.layoutQuestion.Name = "layoutQuestion";
            this.layoutQuestion.RowCount = 1;
            this.layoutQuestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutQuestion.Size = new System.Drawing.Size(48, 32);
            this.layoutQuestion.TabIndex = 5;
            this.layoutQuestion.Click += new System.EventHandler(this.ButtonQuestion_Click);
            this.layoutQuestion.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonQuestion_Paint);
            // 
            // hotbarLayout
            // 
            this.hotbarLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hotbarLayout.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.hotbar;
            this.hotbarLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hotbarLayout.ColumnCount = 9;
            this.hotbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hotbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hotbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hotbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hotbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hotbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hotbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hotbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hotbarLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hotbarLayout.Controls.Add(this.panel1, 0, 0);
            this.hotbarLayout.Controls.Add(this.panel2, 1, 0);
            this.hotbarLayout.Controls.Add(this.panel3, 2, 0);
            this.hotbarLayout.Controls.Add(this.panel4, 3, 0);
            this.hotbarLayout.Controls.Add(this.panel5, 4, 0);
            this.hotbarLayout.Controls.Add(this.panel6, 5, 0);
            this.hotbarLayout.Controls.Add(this.panel7, 6, 0);
            this.hotbarLayout.Controls.Add(this.panel8, 7, 0);
            this.hotbarLayout.Controls.Add(this.panel9, 8, 0);
            this.hotbarLayout.Location = new System.Drawing.Point(12, 293);
            this.hotbarLayout.Margin = new System.Windows.Forms.Padding(5);
            this.hotbarLayout.Name = "hotbarLayout";
            this.hotbarLayout.Padding = new System.Windows.Forms.Padding(6);
            this.hotbarLayout.RowCount = 1;
            this.hotbarLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.hotbarLayout.Size = new System.Drawing.Size(552, 72);
            this.hotbarLayout.TabIndex = 5;
            this.hotbarLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.HotbarLayout_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 48);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.HotbarCell_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotbarCell_MouseClick);
            this.panel1.MouseEnter += new System.EventHandler(this.HotbarCell_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.HotbarCell_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(72, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(48, 48);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.HotbarCell_Paint);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotbarCell_MouseClick);
            this.panel2.MouseEnter += new System.EventHandler(this.HotbarCell_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.HotbarCell_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(132, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(48, 48);
            this.panel3.TabIndex = 6;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.HotbarCell_Paint);
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotbarCell_MouseClick);
            this.panel3.MouseEnter += new System.EventHandler(this.HotbarCell_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.HotbarCell_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(192, 12);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(48, 48);
            this.panel4.TabIndex = 7;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.HotbarCell_Paint);
            this.panel4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotbarCell_MouseClick);
            this.panel4.MouseEnter += new System.EventHandler(this.HotbarCell_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.HotbarCell_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(252, 12);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(48, 48);
            this.panel5.TabIndex = 8;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.HotbarCell_Paint);
            this.panel5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotbarCell_MouseClick);
            this.panel5.MouseEnter += new System.EventHandler(this.HotbarCell_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.HotbarCell_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(312, 12);
            this.panel6.Margin = new System.Windows.Forms.Padding(6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(48, 48);
            this.panel6.TabIndex = 9;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.HotbarCell_Paint);
            this.panel6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotbarCell_MouseClick);
            this.panel6.MouseEnter += new System.EventHandler(this.HotbarCell_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.HotbarCell_MouseLeave);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(372, 12);
            this.panel7.Margin = new System.Windows.Forms.Padding(6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(48, 48);
            this.panel7.TabIndex = 10;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.HotbarCell_Paint);
            this.panel7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotbarCell_MouseClick);
            this.panel7.MouseEnter += new System.EventHandler(this.HotbarCell_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.HotbarCell_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(432, 12);
            this.panel8.Margin = new System.Windows.Forms.Padding(6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(48, 48);
            this.panel8.TabIndex = 11;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.HotbarCell_Paint);
            this.panel8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotbarCell_MouseClick);
            this.panel8.MouseEnter += new System.EventHandler(this.HotbarCell_MouseEnter);
            this.panel8.MouseLeave += new System.EventHandler(this.HotbarCell_MouseLeave);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(492, 12);
            this.panel9.Margin = new System.Windows.Forms.Padding(6);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(48, 48);
            this.panel9.TabIndex = 12;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.HotbarCell_Paint);
            this.panel9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HotbarCell_MouseClick);
            this.panel9.MouseEnter += new System.EventHandler(this.HotbarCell_MouseEnter);
            this.panel9.MouseLeave += new System.EventHandler(this.HotbarCell_MouseLeave);
            // 
            // HotbarRandomizerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Hotbar_Randomizer.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(576, 369);
            this.ControlBox = false;
            this.Controls.Add(this.mainFrame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HotbarRandomizerWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HotbarRandomizerWindow_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.HotbarRandomizerWindow_KeyUp);
            this.mainFrame.ResumeLayout(false);
            this.mainFrame.PerformLayout();
            this.optionsFrame.ResumeLayout(false);
            this.layoutSwap.ResumeLayout(false);
            this.layoutSwap.PerformLayout();
            this.layoutSignSlots.ResumeLayout(false);
            this.layoutSignSlots.PerformLayout();
            this.layoutCount.ResumeLayout(false);
            this.layoutCount.PerformLayout();
            this.titleBar.ResumeLayout(false);
            this.hotbarLayout.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainFrame;
        private System.Windows.Forms.TableLayoutPanel optionsFrame;
        private System.Windows.Forms.TableLayoutPanel titleBar;
        private System.Windows.Forms.TableLayoutPanel layoutSignSlots;
        private System.Windows.Forms.Label labelSlots;
        private System.Windows.Forms.TableLayoutPanel layoutSwap;
        private System.Windows.Forms.Label labelSwap;
        private System.Windows.Forms.TableLayoutPanel layoutClose;
        private System.Windows.Forms.TableLayoutPanel layoutQuestion;
        private System.Windows.Forms.TableLayoutPanel hotbarLayout;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel leverSwap;
        private System.Windows.Forms.Panel leverSlots;
        private System.Windows.Forms.Panel panelCmd;
        private System.Windows.Forms.Panel leverCount;
        private System.Windows.Forms.TableLayoutPanel layoutCount;
        private System.Windows.Forms.Label labelCount;
    }
}

