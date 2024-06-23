namespace JOISPOICalculator
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            lstSelectedPlayers = new ListBox();
            textBox1 = new TextBox();
            btnConvert = new Button();
            sharpClipboard1 = new WK.Libraries.SharpClipboardNS.SharpClipboard(components);
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            btnDelSelected = new Button();
            grpStep1 = new GroupBox();
            lblSuccess1 = new Label();
            btnCopyInitialCMDS = new Button();
            txtInitialCMDS = new TextBox();
            label1 = new Label();
            grpStep2 = new GroupBox();
            lblStep2 = new Label();
            grpStep3 = new GroupBox();
            lblSuccess2 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            lnkDiscord = new LinkLabel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel5 = new LinkLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            toolTip1 = new ToolTip(components);
            statusStrip1.SuspendLayout();
            grpStep1.SuspendLayout();
            grpStep2.SuspendLayout();
            grpStep3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lstSelectedPlayers
            // 
            lstSelectedPlayers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lstSelectedPlayers.FormattingEnabled = true;
            lstSelectedPlayers.ItemHeight = 17;
            lstSelectedPlayers.Location = new Point(194, 29);
            lstSelectedPlayers.Name = "lstSelectedPlayers";
            lstSelectedPlayers.Size = new Size(223, 106);
            lstSelectedPlayers.TabIndex = 1;
            lstSelectedPlayers.SelectedIndexChanged += lstSelectedPlayers_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(194, 65);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(388, 29);
            textBox1.TabIndex = 3;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConvert.ForeColor = Color.Black;
            btnConvert.Image = Properties.Resources.icons8_log_16;
            btnConvert.Location = new Point(194, 15);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(227, 44);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "&Gimme the commands";
            btnConvert.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnConvert, "This generates and copies the needed commands to the clipboard");
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // sharpClipboard1
            // 
            sharpClipboard1.MonitorClipboard = true;
            sharpClipboard1.ObservableFormats.All = false;
            sharpClipboard1.ObservableFormats.Files = false;
            sharpClipboard1.ObservableFormats.Images = false;
            sharpClipboard1.ObservableFormats.Others = false;
            sharpClipboard1.ObservableFormats.Texts = true;
            sharpClipboard1.ObserveLastEntry = true;
            sharpClipboard1.Tag = null;
            sharpClipboard1.ClipboardChanged += sharpClipboard1_ClipboardChanged;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Image = Properties.Resources.icons8_clear_16;
            button1.Location = new Point(423, 102);
            button1.Name = "button1";
            button1.Size = new Size(99, 36);
            button1.TabIndex = 5;
            button1.Text = "&Clear List";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(button1, "Clears all the data in the list");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            statusStrip1.Location = new Point(0, 535);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(648, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.RightToLeft = RightToLeft.No;
            toolStripStatusLabel1.Size = new Size(239, 17);
            toolStripStatusLabel1.Text = "Made for JOISPOI with love from stilgartf";
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            toolStripStatusLabel1.TextDirection = ToolStripTextDirection.Horizontal;
            toolStripStatusLabel1.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // btnDelSelected
            // 
            btnDelSelected.Enabled = false;
            btnDelSelected.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelSelected.ForeColor = Color.Black;
            btnDelSelected.Image = Properties.Resources.icons8_delete_16;
            btnDelSelected.Location = new Point(423, 29);
            btnDelSelected.Name = "btnDelSelected";
            btnDelSelected.Size = new Size(99, 36);
            btnDelSelected.TabIndex = 7;
            btnDelSelected.Text = "Delete &item";
            btnDelSelected.TextImageRelation = TextImageRelation.ImageBeforeText;
            toolTip1.SetToolTip(btnDelSelected, "Deletes an item from the list");
            btnDelSelected.UseVisualStyleBackColor = true;
            btnDelSelected.Click += btnDelSelected_Click;
            // 
            // grpStep1
            // 
            grpStep1.Controls.Add(lblSuccess1);
            grpStep1.Controls.Add(btnCopyInitialCMDS);
            grpStep1.Controls.Add(txtInitialCMDS);
            grpStep1.Controls.Add(label1);
            grpStep1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpStep1.ForeColor = Color.Red;
            grpStep1.Location = new Point(24, 28);
            grpStep1.Name = "grpStep1";
            grpStep1.Size = new Size(602, 100);
            grpStep1.TabIndex = 8;
            grpStep1.TabStop = false;
            grpStep1.Text = "Step 1:";
            // 
            // lblSuccess1
            // 
            lblSuccess1.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuccess1.ForeColor = Color.Green;
            lblSuccess1.Image = Properties.Resources.Paomedia_Small_N_Flat_Sign_check_16;
            lblSuccess1.ImageAlign = ContentAlignment.MiddleLeft;
            lblSuccess1.Location = new Point(549, 65);
            lblSuccess1.Name = "lblSuccess1";
            lblSuccess1.Size = new Size(23, 20);
            lblSuccess1.TabIndex = 7;
            lblSuccess1.Visible = false;
            // 
            // btnCopyInitialCMDS
            // 
            btnCopyInitialCMDS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCopyInitialCMDS.Image = Properties.Resources.icons8_new_copy_30;
            btnCopyInitialCMDS.Location = new Point(538, 21);
            btnCopyInitialCMDS.Name = "btnCopyInitialCMDS";
            btnCopyInitialCMDS.Size = new Size(44, 41);
            btnCopyInitialCMDS.TabIndex = 6;
            btnCopyInitialCMDS.TextImageRelation = TextImageRelation.ImageAboveText;
            toolTip1.SetToolTip(btnCopyInitialCMDS, "Copies the commands on the left to clipboard");
            btnCopyInitialCMDS.UseVisualStyleBackColor = true;
            btnCopyInitialCMDS.Click += btnCopyInitialCMDS_Click;
            // 
            // txtInitialCMDS
            // 
            txtInitialCMDS.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtInitialCMDS.ForeColor = Color.FromArgb(0, 192, 0);
            txtInitialCMDS.Location = new Point(194, 29);
            txtInitialCMDS.Name = "txtInitialCMDS";
            txtInitialCMDS.ReadOnly = true;
            txtInitialCMDS.Size = new Size(338, 25);
            txtInitialCMDS.TabIndex = 5;
            txtInitialCMDS.Text = "tv_listen_voice_indices -1; tv_listen_voice_indices_h -1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 21);
            label1.MaximumSize = new Size(200, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 63);
            label1.TabIndex = 4;
            label1.Text = "Copy and paste these commands to CS2 console: ";
            // 
            // grpStep2
            // 
            grpStep2.Controls.Add(lblStep2);
            grpStep2.Controls.Add(lstSelectedPlayers);
            grpStep2.Controls.Add(btnDelSelected);
            grpStep2.Controls.Add(button1);
            grpStep2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpStep2.ForeColor = Color.ForestGreen;
            grpStep2.Location = new Point(24, 144);
            grpStep2.Name = "grpStep2";
            grpStep2.Size = new Size(602, 150);
            grpStep2.TabIndex = 9;
            grpStep2.TabStop = false;
            grpStep2.Text = "Step 2:";
            // 
            // lblStep2
            // 
            lblStep2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblStep2.Location = new Point(12, 29);
            lblStep2.MaximumSize = new Size(200, 0);
            lblStep2.Name = "lblStep2";
            lblStep2.Size = new Size(176, 63);
            lblStep2.TabIndex = 4;
            lblStep2.Text = "Copy the 'spec_player X' strings from CS2 console:";
            // 
            // grpStep3
            // 
            grpStep3.Controls.Add(lblSuccess2);
            grpStep3.Controls.Add(label2);
            grpStep3.Controls.Add(textBox1);
            grpStep3.Controls.Add(btnConvert);
            grpStep3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            grpStep3.ForeColor = Color.RoyalBlue;
            grpStep3.Location = new Point(24, 312);
            grpStep3.Name = "grpStep3";
            grpStep3.Size = new Size(602, 125);
            grpStep3.TabIndex = 10;
            grpStep3.TabStop = false;
            grpStep3.Text = "Step 3:";
            // 
            // lblSuccess2
            // 
            lblSuccess2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuccess2.ForeColor = Color.Green;
            lblSuccess2.Image = Properties.Resources.Paomedia_Small_N_Flat_Sign_check_16;
            lblSuccess2.ImageAlign = ContentAlignment.MiddleLeft;
            lblSuccess2.Location = new Point(427, 27);
            lblSuccess2.Name = "lblSuccess2";
            lblSuccess2.Size = new Size(23, 20);
            lblSuccess2.TabIndex = 8;
            lblSuccess2.Visible = false;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 21);
            label2.MaximumSize = new Size(200, 0);
            label2.Name = "label2";
            label2.Size = new Size(176, 63);
            label2.TabIndex = 4;
            label2.Text = "Get the results and paste them to CS2 console:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Discord_Icon1;
            pictureBox1.Location = new Point(24, 443);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.vecteezy_youtube_logo_png_youtube_icon_transparent_189305721;
            pictureBox2.Location = new Point(23, 481);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.twitch1;
            pictureBox3.Location = new Point(139, 443);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.instagram_41381241;
            pictureBox4.Location = new Point(139, 481);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Twitter1;
            pictureBox5.Location = new Point(245, 443);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.tiktok;
            pictureBox6.Location = new Point(245, 481);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(32, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // lnkDiscord
            // 
            lnkDiscord.AutoSize = true;
            lnkDiscord.LinkColor = Color.RoyalBlue;
            lnkDiscord.Location = new Point(62, 447);
            lnkDiscord.Name = "lnkDiscord";
            lnkDiscord.Size = new Size(47, 15);
            lnkDiscord.TabIndex = 17;
            lnkDiscord.TabStop = true;
            lnkDiscord.Text = "Discord";
            lnkDiscord.LinkClicked += lnkDiscord_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.RoyalBlue;
            linkLabel1.Location = new Point(61, 481);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 15);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "YouTube";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.RoyalBlue;
            linkLabel2.Location = new Point(177, 481);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(60, 15);
            linkLabel2.TabIndex = 19;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Instagram";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.RoyalBlue;
            linkLabel3.Location = new Point(177, 447);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(41, 15);
            linkLabel3.TabIndex = 20;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Twitch";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.LinkColor = Color.RoyalBlue;
            linkLabel4.Location = new Point(283, 447);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(60, 15);
            linkLabel4.TabIndex = 21;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "X (Twitter)";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.LinkColor = Color.RoyalBlue;
            linkLabel5.Location = new Point(283, 481);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(40, 15);
            linkLabel5.TabIndex = 22;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "TikTok";
            linkLabel5.LinkClicked += linkLabel5_LinkClicked;
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 557);
            Controls.Add(linkLabel5);
            Controls.Add(linkLabel4);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(lnkDiscord);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(grpStep3);
            Controls.Add(grpStep2);
            Controls.Add(grpStep1);
            Controls.Add(statusStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The JOISPOI Calculator";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grpStep1.ResumeLayout(false);
            grpStep1.PerformLayout();
            grpStep2.ResumeLayout(false);
            grpStep3.ResumeLayout(false);
            grpStep3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectedPlayers;
        private ListBox lstSelectedPlayers;
        private TextBox textBox1;
        private Button btnConvert;
        private WK.Libraries.SharpClipboardNS.SharpClipboard sharpClipboard1;
        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button btnDelSelected;
        private GroupBox grpStep1;
        private TextBox txtInitialCMDS;
        private Label label1;
        private Button btnCopyInitialCMDS;
        private GroupBox grpStep2;
        private Label lblStep2;
        private GroupBox grpStep3;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private LinkLabel lnkDiscord;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel5;
        private System.Windows.Forms.Timer timer1;
        private Label lblSuccess1;
        private Label lblSuccess2;
        private ToolTip toolTip1;
    }
}
