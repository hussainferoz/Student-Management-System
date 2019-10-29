namespace MainForm
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSearchID = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblCGPA = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblSemester = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.lblPOB = new System.Windows.Forms.Label();
            this.lblCNIC = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(81, 48);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(210, 46);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchID.TabIndex = 2;
            this.btnSearchID.Text = "Search";
            this.btnSearchID.UseVisualStyleBackColor = true;
            this.btnSearchID.Click += new System.EventHandler(this.btnSearchID_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlDetails.Controls.Add(this.lblCGPA);
            this.pnlDetails.Controls.Add(this.label13);
            this.pnlDetails.Controls.Add(this.lblSemester);
            this.pnlDetails.Controls.Add(this.label12);
            this.pnlDetails.Controls.Add(this.lblAddress);
            this.pnlDetails.Controls.Add(this.label11);
            this.pnlDetails.Controls.Add(this.lblDOB);
            this.pnlDetails.Controls.Add(this.label10);
            this.pnlDetails.Controls.Add(this.lblAge);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.lblFatherName);
            this.pnlDetails.Controls.Add(this.lblPOB);
            this.pnlDetails.Controls.Add(this.lblCNIC);
            this.pnlDetails.Controls.Add(this.lblLName);
            this.pnlDetails.Controls.Add(this.lblFName);
            this.pnlDetails.Controls.Add(this.lblID);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Location = new System.Drawing.Point(24, 84);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(308, 270);
            this.pnlDetails.TabIndex = 3;
            this.pnlDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDetails_Paint);
            // 
            // lblCGPA
            // 
            this.lblCGPA.AutoSize = true;
            this.lblCGPA.Location = new System.Drawing.Point(101, 238);
            this.lblCGPA.Name = "lblCGPA";
            this.lblCGPA.Size = new System.Drawing.Size(0, 13);
            this.lblCGPA.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Float: ";
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Location = new System.Drawing.Point(101, 216);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(0, 13);
            this.lblSemester.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Semester: ";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(101, 194);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 13);
            this.lblAddress.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Address: ";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(101, 125);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(0, 13);
            this.lblDOB.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Date Of Birth:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(101, 103);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(0, 13);
            this.lblAge.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(101, 81);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(0, 13);
            this.lblFatherName.TabIndex = 1;
            // 
            // lblPOB
            // 
            this.lblPOB.AutoSize = true;
            this.lblPOB.Location = new System.Drawing.Point(101, 171);
            this.lblPOB.Name = "lblPOB";
            this.lblPOB.Size = new System.Drawing.Size(0, 13);
            this.lblPOB.TabIndex = 1;
            // 
            // lblCNIC
            // 
            this.lblCNIC.AutoSize = true;
            this.lblCNIC.Location = new System.Drawing.Point(101, 149);
            this.lblCNIC.Name = "lblCNIC";
            this.lblCNIC.Size = new System.Drawing.Size(0, 13);
            this.lblCNIC.TabIndex = 1;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(101, 59);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(0, 13);
            this.lblLName.TabIndex = 1;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(101, 37);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(0, 13);
            this.lblFName.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(101, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Father Name: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Place Of Birth: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "CNIC: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last Name: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "First Name: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID: ";
            // 
            // lnkClear
            // 
            this.lnkClear.AutoSize = true;
            this.lnkClear.Location = new System.Drawing.Point(301, 357);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(31, 13);
            this.lnkClear.TabIndex = 4;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "Clear";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClear_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(219, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 36);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(47, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(257, 24);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "SEARCH STUDENT DATA";
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 404);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lnkClear);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSearchID;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label lblPOB;
        private System.Windows.Forms.Label lblCNIC;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lnkClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCGPA;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblSearch;
    }
}