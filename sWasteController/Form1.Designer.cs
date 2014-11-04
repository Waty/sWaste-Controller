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
            this.tsslConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.lTotalCount = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.lvResults = new System.Windows.Forms.ListView();
            this.chCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bStop = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.tReceiveMessages = new System.Windows.Forms.Timer(this.components);
            this.cmsTrash = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiProcessWaste = new System.Windows.Forms.ToolStripMenuItem();
            this.gbConnection.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gbControls.SuspendLayout();
            this.cmsTrash.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbConnection.Controls.Add(this.bDisconnect);
            this.gbConnection.Controls.Add(this.bConnect);
            this.gbConnection.Controls.Add(this.cbSerialPorts);
            this.gbConnection.Controls.Add(this.lAvaillablePorts);
            this.gbConnection.Location = new System.Drawing.Point(16, 15);
            this.gbConnection.Margin = new System.Windows.Forms.Padding(4);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Padding = new System.Windows.Forms.Padding(4);
            this.gbConnection.Size = new System.Drawing.Size(347, 87);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Bluetooth verbinding";
            // 
            // bDisconnect
            // 
            this.bDisconnect.Enabled = false;
            this.bDisconnect.Location = new System.Drawing.Point(8, 49);
            this.bDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.bDisconnect.Name = "bDisconnect";
            this.bDisconnect.Size = new System.Drawing.Size(147, 28);
            this.bDisconnect.TabIndex = 1;
            this.bDisconnect.Text = "Verbreek verbinding";
            this.bDisconnect.UseVisualStyleBackColor = true;
            this.bDisconnect.Click += new System.EventHandler(this.bDisconnect_Click);
            // 
            // bConnect
            // 
            this.bConnect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bConnect.Location = new System.Drawing.Point(163, 49);
            this.bConnect.Margin = new System.Windows.Forms.Padding(4);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(176, 28);
            this.bConnect.TabIndex = 2;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(163, 16);
            this.cbSerialPorts.Margin = new System.Windows.Forms.Padding(4);
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
            this.tsslConnected,
            this.tsslStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 296);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(379, 25);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslConnected
            // 
            this.tsslConnected.ForeColor = System.Drawing.Color.Red;
            this.tsslConnected.Name = "tsslConnected";
            this.tsslConnected.Size = new System.Drawing.Size(112, 20);
            this.tsslConnected.Text = "Niet verbonden";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(43, 20);
            this.tsslStatus.Text = "Idle...";
            // 
            // gbControls
            // 
            this.gbControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbControls.Controls.Add(this.lTotalCount);
            this.gbControls.Controls.Add(this.lTotal);
            this.gbControls.Controls.Add(this.lvResults);
            this.gbControls.Controls.Add(this.bStop);
            this.gbControls.Controls.Add(this.bStart);
            this.gbControls.Enabled = false;
            this.gbControls.Location = new System.Drawing.Point(16, 110);
            this.gbControls.Margin = new System.Windows.Forms.Padding(4);
            this.gbControls.Name = "gbControls";
            this.gbControls.Padding = new System.Windows.Forms.Padding(4);
            this.gbControls.Size = new System.Drawing.Size(347, 182);
            this.gbControls.TabIndex = 2;
            this.gbControls.TabStop = false;
            this.gbControls.Text = "Controls";
            // 
            // lTotalCount
            // 
            this.lTotalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTotalCount.AutoSize = true;
            this.lTotalCount.Location = new System.Drawing.Point(65, 161);
            this.lTotalCount.Name = "lTotalCount";
            this.lTotalCount.Size = new System.Drawing.Size(16, 17);
            this.lTotalCount.TabIndex = 4;
            this.lTotalCount.Text = "0";
            // 
            // lTotal
            // 
            this.lTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lTotal.AutoSize = true;
            this.lTotal.Location = new System.Drawing.Point(7, 161);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(52, 17);
            this.lTotal.TabIndex = 3;
            this.lTotal.Text = "Totaal:";
            // 
            // lvResults
            // 
            this.lvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCount,
            this.chColor});
            this.lvResults.ContextMenuStrip = this.cmsTrash;
            this.lvResults.FullRowSelect = true;
            this.lvResults.GridLines = true;
            this.lvResults.Location = new System.Drawing.Point(7, 58);
            this.lvResults.Name = "lvResults";
            this.lvResults.Size = new System.Drawing.Size(333, 100);
            this.lvResults.TabIndex = 2;
            this.lvResults.UseCompatibleStateImageBehavior = false;
            this.lvResults.View = System.Windows.Forms.View.Details;
            // 
            // chCount
            // 
            this.chCount.Text = "#";
            this.chCount.Width = 20;
            // 
            // chColor
            // 
            this.chColor.Text = "Soort afval";
            this.chColor.Width = 250;
            // 
            // bStop
            // 
            this.bStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bStop.Location = new System.Drawing.Point(160, 23);
            this.bStop.Margin = new System.Windows.Forms.Padding(4);
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
            this.bStart.Margin = new System.Windows.Forms.Padding(4);
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
            // cmsTrash
            // 
            this.cmsTrash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiProcessWaste});
            this.cmsTrash.Name = "cmsTrash";
            this.cmsTrash.Size = new System.Drawing.Size(176, 56);
            // 
            // tsmiProcessWaste
            // 
            this.tsmiProcessWaste.Name = "tsmiProcessWaste";
            this.tsmiProcessWaste.Size = new System.Drawing.Size(175, 24);
            this.tsmiProcessWaste.Text = "Verwerk Afval";
            this.tsmiProcessWaste.Click += new System.EventHandler(this.tsmiProcessWaste_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbConnection);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "sWaste Bediening";
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gbControls.ResumeLayout(false);
            this.gbControls.PerformLayout();
            this.cmsTrash.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripStatusLabel tsslConnected;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer tReceiveMessages;
        private System.Windows.Forms.ListView lvResults;
        private System.Windows.Forms.ColumnHeader chCount;
        private System.Windows.Forms.ColumnHeader chColor;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.Label lTotalCount;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.ContextMenuStrip cmsTrash;
        private System.Windows.Forms.ToolStripMenuItem tsmiProcessWaste;
    }
}

