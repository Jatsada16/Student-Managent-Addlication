﻿namespace Student_Managent_Addlication
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMinGPA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaxGPA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGPAx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGPA_input = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxName_input = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMinGPA);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxMaxGPA);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxGPAx);
            this.groupBox1.Location = new System.Drawing.Point(39, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(223, 158);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Min";
            // 
            // textBoxMinGPA
            // 
            this.textBoxMinGPA.Location = new System.Drawing.Point(66, 124);
            this.textBoxMinGPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMinGPA.Name = "textBoxMinGPA";
            this.textBoxMinGPA.Size = new System.Drawing.Size(138, 27);
            this.textBoxMinGPA.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Max";
            // 
            // textBoxMaxGPA
            // 
            this.textBoxMaxGPA.Location = new System.Drawing.Point(66, 81);
            this.textBoxMaxGPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaxGPA.Name = "textBoxMaxGPA";
            this.textBoxMaxGPA.Size = new System.Drawing.Size(138, 27);
            this.textBoxMaxGPA.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "GPAx";
            // 
            // textBoxGPAx
            // 
            this.textBoxGPAx.Location = new System.Drawing.Point(66, 29);
            this.textBoxGPAx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGPAx.Name = "textBoxGPAx";
            this.textBoxGPAx.Size = new System.Drawing.Size(138, 27);
            this.textBoxGPAx.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "GPA";
            // 
            // textBoxGPA_input
            // 
            this.textBoxGPA_input.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxGPA_input.Location = new System.Drawing.Point(636, 63);
            this.textBoxGPA_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGPA_input.Name = "textBoxGPA_input";
            this.textBoxGPA_input.Size = new System.Drawing.Size(115, 27);
            this.textBoxGPA_input.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CIS",
            "DS"});
            this.comboBox1.Location = new System.Drawing.Point(446, 63);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 28);
            this.comboBox1.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Major";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox2.Location = new System.Drawing.Point(251, 66);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 27);
            this.textBox2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxName_input
            // 
            this.textBoxName_input.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxName_input.Location = new System.Drawing.Point(69, 65);
            this.textBoxName_input.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName_input.Name = "textBoxName_input";
            this.textBoxName_input.Size = new System.Drawing.Size(115, 27);
            this.textBoxName_input.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnMajor});
            this.dataGridView1.Location = new System.Drawing.Point(306, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(575, 143);
            this.dataGridView1.TabIndex = 15;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Width = 125;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 125;
            // 
            // ColumnMajor
            // 
            this.ColumnMajor.HeaderText = "Major";
            this.ColumnMajor.MinimumWidth = 6;
            this.ColumnMajor.Name = "ColumnMajor";
            this.ColumnMajor.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // oPToolStripMenuItem
            // 
            this.oPToolStripMenuItem.Name = "oPToolStripMenuItem";
            this.oPToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.oPToolStripMenuItem.Text = "Open";
            this.oPToolStripMenuItem.Click += new System.EventHandler(this.oPToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(914, 390);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxGPA_input);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxName_input);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label label7;
        private TextBox textBoxMinGPA;
        private Label label6;
        private TextBox textBoxMaxGPA;
        private Label label5;
        private TextBox textBoxGPAx;
        private Label label4;
        private TextBox textBoxGPA_input;
        private ComboBox comboBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private TextBox textBoxName_input;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnMajor;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem oPToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}