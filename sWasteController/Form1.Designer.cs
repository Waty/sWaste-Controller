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
            this.gbConnection.Location = new System.Drawing.Point(12, 12);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(260, 71);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Bluetooth verbinding";
            // 
            // bDisconnect
            // 
            this.bDisconnect.Enabled = false;
            this.bDisconnect.Location = new System.Drawing.Point(6, 40);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(110, 23);
            this.bDisconnect.TabIndex = 1;
            this.bDisconnect.Text = "Verbreek verbinding";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(122, 40);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(132, 23);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(122, 13);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(132, 21);
            this.cbSerialPorts.TabIndex = 1;
            // 
            // lAvaillablePorts
            // 
            this.lAvaillablePorts.AutoSize = true;
            this.lAvaillablePorts.Location = new System.Drawing.Point(6, 16);
            this.lAvaillablePorts.Name = "lAvaillablePorts";
            this.lAvaillablePorts.Size = new System.Drawing.Size(108, 13);
            this.lAvaillablePorts.TabIndex = 0;
            this.lAvaillablePorts.Text = "Beschikbare poorten:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslConnected});
            this.statusStrip.Location = new System.Drawing.Point(0, 239);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(284, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tslConnected
            // 
            this.tslConnected.ForeColor = System.Drawing.Color.Red;
            this.tslConnected.Name = "tslConnected";
            this.tslConnected.Size = new System.Drawing.Size(89, 17);
            this.tslConnected.Text = "Niet verbonden";
            // 
            // gbControls
            // 
            this.gbControls.Controls.Add(this.lbLogs);
            this.gbControls.Controls.Add(this.bStop);
            this.gbControls.Controls.Add(this.bStart);
            this.gbControls.Enabled = false;
            this.gbControls.Location = new System.Drawing.Point(12, 89);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(260, 147);
            this.gbControls.TabIndex = 2;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // lbLogs
            // 
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.Location = new System.Drawing.Point(6, 48);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(248, 95);
            this.lbLogs.TabIndex = 2;
            // 
            // bStop
            // 
            this.bStop.Location = new System.Drawing.Point(120, 19);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(134, 23);
            this.bStop.TabIndex = 1;
            this.bStop.Text = "Stop het algoritme";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStartStop_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(6, 19);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(105, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Start algoritme";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStartStop_Click);
            // 
            // tReceiveMessages
            // 
            this.tReceiveMessages.Tick += new System.EventHandler(this.tReceiveMessages_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbConnection);
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
    }
}

