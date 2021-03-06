﻿
namespace GUI
{
    partial class frmChooseTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseTest));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOfficeVersion = new System.Windows.Forms.ComboBox();
            this.cmbOfficeApp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTestName = new System.Windows.Forms.ComboBox();
            this.btnPracticeMode = new System.Windows.Forms.Button();
            this.btnTestingMode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridTasks = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLimitTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblVer = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTasks)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOS Checker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose a test to practice:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Office Version:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Office App:";
            // 
            // cmbOfficeVersion
            // 
            this.cmbOfficeVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOfficeVersion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbOfficeVersion.FormattingEnabled = true;
            this.cmbOfficeVersion.Items.AddRange(new object[] {
            "2013",
            "2016"});
            this.cmbOfficeVersion.Location = new System.Drawing.Point(164, 134);
            this.cmbOfficeVersion.Name = "cmbOfficeVersion";
            this.cmbOfficeVersion.Size = new System.Drawing.Size(104, 29);
            this.cmbOfficeVersion.TabIndex = 5;
            this.cmbOfficeVersion.SelectedIndexChanged += new System.EventHandler(this.cmbOfficeVersion_SelectedIndexChanged);
            // 
            // cmbOfficeApp
            // 
            this.cmbOfficeApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOfficeApp.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbOfficeApp.FormattingEnabled = true;
            this.cmbOfficeApp.Items.AddRange(new object[] {
            "Word",
            "Excel",
            "PowerPoint"});
            this.cmbOfficeApp.Location = new System.Drawing.Point(164, 102);
            this.cmbOfficeApp.Name = "cmbOfficeApp";
            this.cmbOfficeApp.Size = new System.Drawing.Size(104, 29);
            this.cmbOfficeApp.TabIndex = 6;
            this.cmbOfficeApp.SelectedIndexChanged += new System.EventHandler(this.cmbOfficeApp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Test Name:";
            // 
            // cmbTestName
            // 
            this.cmbTestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTestName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbTestName.FormattingEnabled = true;
            this.cmbTestName.Location = new System.Drawing.Point(164, 167);
            this.cmbTestName.Name = "cmbTestName";
            this.cmbTestName.Size = new System.Drawing.Size(104, 29);
            this.cmbTestName.TabIndex = 8;
            this.cmbTestName.SelectedIndexChanged += new System.EventHandler(this.cmbTestName_SelectedIndexChanged);
            // 
            // btnPracticeMode
            // 
            this.btnPracticeMode.AutoSize = true;
            this.btnPracticeMode.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnPracticeMode.Location = new System.Drawing.Point(15, 96);
            this.btnPracticeMode.Name = "btnPracticeMode";
            this.btnPracticeMode.Size = new System.Drawing.Size(96, 30);
            this.btnPracticeMode.TabIndex = 9;
            this.btnPracticeMode.Text = "Practice";
            this.btnPracticeMode.UseVisualStyleBackColor = true;
            this.btnPracticeMode.Click += new System.EventHandler(this.btnPracticeMode_Click);
            // 
            // btnTestingMode
            // 
            this.btnTestingMode.AutoSize = true;
            this.btnTestingMode.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnTestingMode.Location = new System.Drawing.Point(131, 96);
            this.btnTestingMode.Name = "btnTestingMode";
            this.btnTestingMode.Size = new System.Drawing.Size(92, 30);
            this.btnTestingMode.TabIndex = 10;
            this.btnTestingMode.Text = "Testing";
            this.btnTestingMode.UseVisualStyleBackColor = true;
            this.btnTestingMode.Click += new System.EventHandler(this.btnTestingMode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridTasks);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(312, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 295);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saved/Completed Tests";
            // 
            // dataGridTasks
            // 
            this.dataGridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTasks.Location = new System.Drawing.Point(3, 23);
            this.dataGridTasks.Name = "dataGridTasks";
            this.dataGridTasks.ReadOnly = true;
            this.dataGridTasks.Size = new System.Drawing.Size(448, 269);
            this.dataGridTasks.TabIndex = 0;
            this.dataGridTasks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTasks_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(312, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "(*) Double click the row to resume the test";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(108, 55);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(115, 26);
            this.txtUserName.TabIndex = 14;
            this.txtUserName.Text = "guest";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblLimitTime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnPracticeMode);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Controls.Add(this.btnTestingMode);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 141);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // lblLimitTime
            // 
            this.lblLimitTime.AutoSize = true;
            this.lblLimitTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLimitTime.Location = new System.Drawing.Point(106, 22);
            this.lblLimitTime.Name = "lblLimitTime";
            this.lblLimitTime.Size = new System.Drawing.Size(36, 21);
            this.lblLimitTime.TabIndex = 16;
            this.lblLimitTime.Text = "N/a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Limit Time:";
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(20, 356);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(81, 13);
            this.lblVer.TabIndex = 16;
            this.lblVer.Text = "Version: 1.0.0.0";
            // 
            // frmChooseTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 383);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbTestName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOfficeApp);
            this.Controls.Add(this.cmbOfficeVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChooseTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOS Test";
            this.Load += new System.EventHandler(this.frmChooseTest_Load);
            this.VisibleChanged += new System.EventHandler(this.frmChooseTest_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTasks)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOfficeVersion;
        private System.Windows.Forms.ComboBox cmbOfficeApp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTestName;
        private System.Windows.Forms.Button btnPracticeMode;
        private System.Windows.Forms.Button btnTestingMode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridTasks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLimitTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblVer;
    }
}

