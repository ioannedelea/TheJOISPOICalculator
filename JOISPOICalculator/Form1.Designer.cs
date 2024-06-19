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
            lblSelectedPlayers = new Label();
            lstSelectedPlayers = new ListBox();
            lblResul = new Label();
            textBox1 = new TextBox();
            btnConvert = new Button();
            sharpClipboard1 = new WK.Libraries.SharpClipboardNS.SharpClipboard(components);
            button1 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSelectedPlayers
            // 
            lblSelectedPlayers.AutoSize = true;
            lblSelectedPlayers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedPlayers.Location = new Point(24, 34);
            lblSelectedPlayers.Name = "lblSelectedPlayers";
            lblSelectedPlayers.Size = new Size(142, 21);
            lblSelectedPlayers.TabIndex = 0;
            lblSelectedPlayers.Text = "Selected players: ";
            // 
            // lstSelectedPlayers
            // 
            lstSelectedPlayers.FormattingEnabled = true;
            lstSelectedPlayers.ItemHeight = 15;
            lstSelectedPlayers.Location = new Point(172, 34);
            lstSelectedPlayers.Name = "lstSelectedPlayers";
            lstSelectedPlayers.Size = new Size(223, 64);
            lstSelectedPlayers.TabIndex = 1;
            lstSelectedPlayers.SelectedIndexChanged += lstSelectedPlayers_SelectedIndexChanged;
            // 
            // lblResul
            // 
            lblResul.AutoSize = true;
            lblResul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResul.Location = new Point(24, 157);
            lblResul.Name = "lblResul";
            lblResul.Size = new Size(65, 21);
            lblResul.TabIndex = 2;
            lblResul.Text = "Result: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 159);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(517, 29);
            textBox1.TabIndex = 3;
            // 
            // btnConvert
            // 
            btnConvert.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvert.Location = new Point(172, 109);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(227, 44);
            btnConvert.TabIndex = 4;
            btnConvert.Text = "Gimme the commands";
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
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(401, 34);
            button1.Name = "button1";
            button1.Size = new Size(113, 30);
            button1.TabIndex = 5;
            button1.Text = "Clear List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            statusStrip1.Location = new Point(0, 193);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(699, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.RightToLeft = RightToLeft.No;
            toolStripStatusLabel1.Size = new Size(239, 17);
            toolStripStatusLabel1.Text = "Made for JOISPOI with love from stilgartf";
            toolStripStatusLabel1.TextAlign = ContentAlignment.MiddleLeft;
            toolStripStatusLabel1.TextDirection = ToolStripTextDirection.Horizontal;
            toolStripStatusLabel1.TextImageRelation = TextImageRelation.TextBeforeImage;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 215);
            Controls.Add(statusStrip1);
            Controls.Add(button1);
            Controls.Add(btnConvert);
            Controls.Add(textBox1);
            Controls.Add(lblResul);
            Controls.Add(lstSelectedPlayers);
            Controls.Add(lblSelectedPlayers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "The JOISPOI Calculator";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSelectedPlayers;
        private ListBox lstSelectedPlayers;
        private Label lblResul;
        private TextBox textBox1;
        private Button btnConvert;
        private WK.Libraries.SharpClipboardNS.SharpClipboard sharpClipboard1;
        private Button button1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
