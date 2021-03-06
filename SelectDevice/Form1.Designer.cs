﻿namespace SelectDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtBoard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCpu = new System.Windows.Forms.Label();
            this.comboCPU = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCleanGlobal = new System.Windows.Forms.Button();
            this.Port = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.board = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Port,
            this.board,
            this.Name1,
            this.PID,
            this.VID,
            this.SN,
            this.cpu});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Location = new System.Drawing.Point(26, 38);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(694, 169);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // txtPort
            // 
            this.txtPort.Enabled = false;
            this.txtPort.Location = new System.Drawing.Point(394, 252);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(79, 20);
            this.txtPort.TabIndex = 3;
            // 
            // txtBoard
            // 
            this.txtBoard.Enabled = false;
            this.txtBoard.Location = new System.Drawing.Point(479, 252);
            this.txtBoard.Name = "txtBoard";
            this.txtBoard.Size = new System.Drawing.Size(100, 20);
            this.txtBoard.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected board";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(264, 232);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(67, 13);
            this.lblCpu.TabIndex = 9;
            this.lblCpu.Text = "Select a cpu";
            // 
            // comboCPU
            // 
            this.comboCPU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCPU.FormattingEnabled = true;
            this.comboCPU.Location = new System.Drawing.Point(267, 251);
            this.comboCPU.Name = "comboCPU";
            this.comboCPU.Size = new System.Drawing.Size(121, 21);
            this.comboCPU.TabIndex = 2;
            this.comboCPU.SelectedIndexChanged += new System.EventHandler(this.comboCPU_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Select the device";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::SelectDevice.Properties.Resources.refresh1;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(642, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(78, 24);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCleanGlobal
            // 
            this.btnCleanGlobal.Location = new System.Drawing.Point(26, 230);
            this.btnCleanGlobal.Name = "btnCleanGlobal";
            this.btnCleanGlobal.Size = new System.Drawing.Size(95, 42);
            this.btnCleanGlobal.TabIndex = 16;
            this.btnCleanGlobal.Text = "Clean Global Config";
            this.btnCleanGlobal.UseVisualStyleBackColor = true;
            this.btnCleanGlobal.Click += new System.EventHandler(this.btnCleanGlobal_Click);
            // 
            // Port
            // 
            this.Port.HeaderText = "Port";
            this.Port.Name = "Port";
            this.Port.ReadOnly = true;
            // 
            // board
            // 
            this.board.HeaderText = "board";
            this.board.Name = "board";
            this.board.ReadOnly = true;
            this.board.Visible = false;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Name";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            this.Name1.Width = 200;
            // 
            // PID
            // 
            this.PID.HeaderText = "PID";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            // 
            // VID
            // 
            this.VID.HeaderText = "VID";
            this.VID.Name = "VID";
            this.VID.ReadOnly = true;
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 150;
            // 
            // cpu
            // 
            this.cpu.HeaderText = "cpu";
            this.cpu.Name = "cpu";
            this.cpu.ReadOnly = true;
            this.cpu.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(748, 285);
            this.Controls.Add(this.btnCleanGlobal);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboCPU);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoard);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Céu-maker: select device";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.ComboBox comboCPU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCleanGlobal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port;
        private System.Windows.Forms.DataGridViewTextBoxColumn board;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn VID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpu;
    }
}

