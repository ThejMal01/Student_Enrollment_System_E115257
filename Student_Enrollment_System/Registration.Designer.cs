
namespace Student_Enrollment_System
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.txtStuName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBoxM = new System.Windows.Forms.CheckBox();
            this.checkBoxF = new System.Windows.Forms.CheckBox();
            this.txtCNo = new System.Windows.Forms.TextBox();
            this.domainUpDownSport = new System.Windows.Forms.DomainUpDown();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.btnRegExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.labelPay = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelMF = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Date of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sport";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(171, 73);
            this.txtRegNo.MaxLength = 50;
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(131, 20);
            this.txtRegNo.TabIndex = 2;
            this.txtRegNo.TextChanged += new System.EventHandler(this.txtRegNo_TextChanged);
            // 
            // txtStuName
            // 
            this.txtStuName.Location = new System.Drawing.Point(171, 99);
            this.txtStuName.Name = "txtStuName";
            this.txtStuName.Size = new System.Drawing.Size(282, 20);
            this.txtStuName.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBoxM
            // 
            this.checkBoxM.AutoSize = true;
            this.checkBoxM.Location = new System.Drawing.Point(171, 151);
            this.checkBoxM.Name = "checkBoxM";
            this.checkBoxM.Size = new System.Drawing.Size(49, 17);
            this.checkBoxM.TabIndex = 4;
            this.checkBoxM.Text = "Male";
            this.checkBoxM.UseVisualStyleBackColor = true;
            this.checkBoxM.CheckedChanged += new System.EventHandler(this.checkBoxM_CheckedChanged);
            // 
            // checkBoxF
            // 
            this.checkBoxF.AutoSize = true;
            this.checkBoxF.Location = new System.Drawing.Point(242, 151);
            this.checkBoxF.Name = "checkBoxF";
            this.checkBoxF.Size = new System.Drawing.Size(60, 17);
            this.checkBoxF.TabIndex = 4;
            this.checkBoxF.Text = "Female";
            this.checkBoxF.UseVisualStyleBackColor = true;
            this.checkBoxF.CheckedChanged += new System.EventHandler(this.checkBoxF_CheckedChanged);
            // 
            // txtCNo
            // 
            this.txtCNo.Location = new System.Drawing.Point(171, 174);
            this.txtCNo.MaxLength = 10;
            this.txtCNo.Name = "txtCNo";
            this.txtCNo.Size = new System.Drawing.Size(166, 20);
            this.txtCNo.TabIndex = 5;
            this.txtCNo.TextChanged += new System.EventHandler(this.txtCNo_TextChanged);
            // 
            // domainUpDownSport
            // 
            this.domainUpDownSport.Location = new System.Drawing.Point(171, 204);
            this.domainUpDownSport.Name = "domainUpDownSport";
            this.domainUpDownSport.Size = new System.Drawing.Size(166, 20);
            this.domainUpDownSport.Sorted = true;
            this.domainUpDownSport.TabIndex = 6;
            this.domainUpDownSport.Text = "Sport";
            this.domainUpDownSport.SelectedItemChanged += new System.EventHandler(this.domainUpDownSport_SelectedItemChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(203, 249);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(203, 278);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(203, 308);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(411, 124);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(42, 20);
            this.txtAge.TabIndex = 9;
            // 
            // btnRegExit
            // 
            this.btnRegExit.Location = new System.Drawing.Point(360, 308);
            this.btnRegExit.Name = "btnRegExit";
            this.btnRegExit.Size = new System.Drawing.Size(75, 23);
            this.btnRegExit.TabIndex = 11;
            this.btnRegExit.Text = "Log Out";
            this.btnRegExit.UseVisualStyleBackColor = true;
            this.btnRegExit.Click += new System.EventHandler(this.btnRegExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.txtPay);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.txtFee);
            this.groupBox1.Controls.Add(this.labelPay);
            this.groupBox1.Controls.Add(this.labelDiscount);
            this.groupBox1.Controls.Add(this.labelMF);
            this.groupBox1.Location = new System.Drawing.Point(360, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 117);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(99, 80);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(138, 20);
            this.txtPay.TabIndex = 1;
            this.txtPay.TextChanged += new System.EventHandler(this.txtPay_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(99, 51);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(138, 20);
            this.txtDiscount.TabIndex = 1;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(99, 23);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(138, 20);
            this.txtFee.TabIndex = 1;
            this.txtFee.TextChanged += new System.EventHandler(this.txtFee_TextChanged);
            // 
            // labelPay
            // 
            this.labelPay.AutoSize = true;
            this.labelPay.Location = new System.Drawing.Point(20, 87);
            this.labelPay.Name = "labelPay";
            this.labelPay.Size = new System.Drawing.Size(73, 13);
            this.labelPay.TabIndex = 0;
            this.labelPay.Text = "Final Payment";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(20, 58);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(66, 13);
            this.labelDiscount.TabIndex = 0;
            this.labelDiscount.Text = "Discount (%)";
            // 
            // labelMF
            // 
            this.labelMF.AutoSize = true;
            this.labelMF.Location = new System.Drawing.Point(20, 30);
            this.labelMF.Name = "labelMF";
            this.labelMF.Size = new System.Drawing.Size(65, 13);
            this.labelMF.TabIndex = 0;
            this.labelMF.Text = "Monthly Fee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Age";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(698, 348);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegExit);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.domainUpDownSport);
            this.Controls.Add(this.txtCNo);
            this.Controls.Add(this.checkBoxF);
            this.Controls.Add(this.checkBoxM);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtStuName);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtStuName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBoxM;
        private System.Windows.Forms.CheckBox checkBoxF;
        private System.Windows.Forms.TextBox txtCNo;
        private System.Windows.Forms.DomainUpDown domainUpDownSport;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button btnRegExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label labelPay;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelMF;
        private System.Windows.Forms.Label label7;
    }
}