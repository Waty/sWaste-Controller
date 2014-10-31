namespace sWasteController
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.bDisconnect = new System.Windows.Forms.Button();
            this.bConnect = new System.Windows.Forms.Button();
            this.cbSerialPorts = new System.Windows.Forms.ComboBox();
            this.lAvaillablePorts = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.tReceiveMessages = new System.Windows.Forms.Timer(this.components);
            this.tsslRed = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslWhite = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslBlack = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbConnection.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.bDisconnect);
            this.gbConnection.Controls.Add(this.bConnect);
            this.gbConnection.Controls.Add(this.cbSerialPorts);
            this.gbConnection.Controls.Add(this.lAvaillablePorts);
            this.gbConnection.Location = new System.Drawing.Point(16, 15);
            this.gbConnection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConnection.Size = new System.Drawing.Size(347, 87);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Bluetooth verbinding";
            // 
            // bDisconnect
            // 
            this.bDisconnect.Enabled = false;
            this.bDisconnect.Location = new System.Drawing.Point(8, 49);
            this.bDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(147, 28);
            this.bDisconnect.TabIndex = 1;
            this.bDisconnect.Text = "Verbreek verbinding";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(163, 49);
            this.bConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(176, 28);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(163, 16);
            this.cbSerialPorts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(175, 24);
            this.cbSerialPorts.TabIndex = 1;
            // 
            // lAvaillablePorts
            // 
            this.lAvaillablePorts.AutoSize = true;
            this.lAvaillablePorts.Location = new System.Drawing.Point(8, 20);
            this.lAvaillablePorts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAvaillablePorts.Name = "lAvaillablePorts";
            this.lAvaillablePorts.Size = new System.Drawing.Size(143, 17);
            this.lAvaillablePorts.TabIndex = 0;
            this.lAvaillablePorts.Text = "Beschikbare poorten:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslConnected,
            this.tsslRed,
            this.tsslWhite,
            this.tsslBlack});
            this.statusStrip.Location = new System.Drawing.Point(0, 296);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(379, 25);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tslConnected
            // 
            this.tslConnected.ForeColor = System.Drawing.Color.Red;
            this.tslConnected.Name = "tslConnected";
            this.tslConnected.Size = new System.Drawing.Size(112, 20);
            this.tslConnected.Text = "Niet verbonden";
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.lbLogs);
            this.gbControls.Controls.Add(this.bStop);
            this.gbControls.Controls.Add(this.bStart);
            this.gbControls.Enabled = false;
            this.gbControls.Location = new System.Drawing.Point(16, 110);
            this.gbControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbControls.Name = "gbControls";
            this.gbControls.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbControls.Size = new System.Drawing.Size(347, 181);
            this.gbControls.TabIndex = 2;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // lbLogs
            // 
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 16;
            this.lbLogs.Location = new System.Drawing.Point(8, 59);
            this.lbLogs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(329, 116);
            this.lbLogs.TabIndex = 2;
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(160, 23);
            this.bStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(179, 28);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop het algoritme";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStartStop_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(8, 23);
            this.bStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(140, 28);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start algoritme";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStartStop_Click);
            // 
            // tReceiveMessages
            // 
            this.tReceiveMessages.Tick += new System.EventHandler(this.tReceiveMessages_Tick);
            // 
            // tsslRed
            // 
            this.tsslRed.Name = "tsslRed";
            this.tsslRed.Size = new System.Drawing.Size(60, 20);
            this.tsslRed.Text = "Rood: 0";
            // 
            // tsslWhite
            // 
            this.tsslWhite.Name = "tsslWhite";
            this.tsslWhite.Size = new System.Drawing.Size(47, 20);
            this.tsslWhite.Text = "Wit: 0";
            // 
            // tsslBlack
            // 
            this.tsslBlack.Name = "tsslBlack";
            this.tsslBlack.Size = new System.Drawing.Size(62, 20);
            this.tsslBlack.Text = "Zwart: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbConnection);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "sWaste Bediening";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Label lAvaillablePorts;
        private System.Windows.Forms.ComboBox cbSerialPorts;
        private System.Windows.Forms.Button bDisconnect;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslConnected;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.ListBox lbLogs;
        private System.Windows.Forms.Timer tReceiveMessages;
        private System.Windows.Forms.ToolStripStatusLabel tsslRed;
        private System.Windows.Forms.ToolStripStatusLabel tsslWhite;
        private System.Windows.Forms.ToolStripStatusLabel tsslBlack;
    }
}

