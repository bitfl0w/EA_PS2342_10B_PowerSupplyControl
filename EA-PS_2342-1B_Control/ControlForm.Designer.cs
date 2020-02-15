namespace EA_PS_2342_1B_Control
{
    partial class ControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.label_titleComPort = new System.Windows.Forms.Label();
            this.button_createComPort = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_connectivity = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectivityIssuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputNode2 = new EA_PS_2342_1B_Control.OutputNode();
            this.outputNode1 = new EA_PS_2342_1B_Control.OutputNode();
            this.statusStrip1.SuspendLayout();
            this.groupBox_connectivity.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control Panel: POWER SUPPLY EA-PS 2342-10B";
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(64, 20);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(502, 21);
            this.comboBox_comPort.TabIndex = 2;
            this.comboBox_comPort.DropDown += new System.EventHandler(this.comboBox_comPort_DropDown);
            this.comboBox_comPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_comPort_KeyDown);
            // 
            // label_titleComPort
            // 
            this.label_titleComPort.AutoSize = true;
            this.label_titleComPort.Location = new System.Drawing.Point(6, 23);
            this.label_titleComPort.Name = "label_titleComPort";
            this.label_titleComPort.Size = new System.Drawing.Size(56, 13);
            this.label_titleComPort.TabIndex = 3;
            this.label_titleComPort.Text = "COM Port:";
            // 
            // button_createComPort
            // 
            this.button_createComPort.Location = new System.Drawing.Point(572, 18);
            this.button_createComPort.Name = "button_createComPort";
            this.button_createComPort.Size = new System.Drawing.Size(75, 23);
            this.button_createComPort.TabIndex = 4;
            this.button_createComPort.Text = "connect";
            this.button_createComPort.UseVisualStyleBackColor = true;
            this.button_createComPort.Click += new System.EventHandler(this.button_createComPort_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 8, 0);
            this.statusStrip1.Size = new System.Drawing.Size(666, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabel1.Text = "v1.01.00.2400";
            // 
            // groupBox_connectivity
            // 
            this.groupBox_connectivity.Controls.Add(this.button_createComPort);
            this.groupBox_connectivity.Controls.Add(this.comboBox_comPort);
            this.groupBox_connectivity.Controls.Add(this.label_titleComPort);
            this.groupBox_connectivity.Location = new System.Drawing.Point(7, 59);
            this.groupBox_connectivity.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox_connectivity.Name = "groupBox_connectivity";
            this.groupBox_connectivity.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox_connectivity.Size = new System.Drawing.Size(655, 47);
            this.groupBox_connectivity.TabIndex = 6;
            this.groupBox_connectivity.TabStop = false;
            this.groupBox_connectivity.Text = "Connectivity";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectivityIssuesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // connectivityIssuesToolStripMenuItem
            // 
            this.connectivityIssuesToolStripMenuItem.Name = "connectivityIssuesToolStripMenuItem";
            this.connectivityIssuesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.connectivityIssuesToolStripMenuItem.Text = "Connectivity issues";
            this.connectivityIssuesToolStripMenuItem.Click += new System.EventHandler(this.connectivityIssuesToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // outputNode2
            // 
            this.outputNode2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputNode2.Enabled = false;
            this.outputNode2.Location = new System.Drawing.Point(337, 114);
            this.outputNode2.Margin = new System.Windows.Forms.Padding(6);
            this.outputNode2.Name = "outputNode2";
            this.outputNode2.Size = new System.Drawing.Size(325, 305);
            this.outputNode2.TabIndex = 0;
            // 
            // outputNode1
            // 
            this.outputNode1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputNode1.Enabled = false;
            this.outputNode1.Location = new System.Drawing.Point(7, 114);
            this.outputNode1.Margin = new System.Windows.Forms.Padding(6);
            this.outputNode1.Name = "outputNode1";
            this.outputNode1.Size = new System.Drawing.Size(325, 305);
            this.outputNode1.TabIndex = 0;
            this.outputNode1.Load += new System.EventHandler(this.outputNode1_Load);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 445);
            this.Controls.Add(this.groupBox_connectivity);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputNode2);
            this.Controls.Add(this.outputNode1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ControlForm";
            this.Text = "Control Panel for EA-PS 2342-10B PSU";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ControlForm_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_connectivity.ResumeLayout(false);
            this.groupBox_connectivity.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OutputNode outputNode1;
        private OutputNode outputNode2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label label_titleComPort;
        private System.Windows.Forms.Button button_createComPort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox_connectivity;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectivityIssuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

