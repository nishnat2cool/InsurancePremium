namespace InsurancePremiumApp
{
    partial class frmMonthlyPremCalc
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
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtDeathSumIns = new System.Windows.Forms.TextBox();
            this.lblDeathSumIns = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.cmbOccupation = new System.Windows.Forms.ComboBox();
            this.lblMonthlyPrem = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtMonthlyPremCalc = new System.Windows.Forms.TextBox();
            this.lblValidation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(89, 96);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(70, 13);
            this.lblDOB.TabIndex = 49;
            this.lblDOB.Text = "Date of Birth*";
            // 
            // txtDeathSumIns
            // 
            this.txtDeathSumIns.Location = new System.Drawing.Point(185, 171);
            this.txtDeathSumIns.Name = "txtDeathSumIns";
            this.txtDeathSumIns.Size = new System.Drawing.Size(190, 20);
            this.txtDeathSumIns.TabIndex = 4;
            // 
            // lblDeathSumIns
            // 
            this.lblDeathSumIns.AutoSize = true;
            this.lblDeathSumIns.Location = new System.Drawing.Point(51, 178);
            this.lblDeathSumIns.Name = "lblDeathSumIns";
            this.lblDeathSumIns.Size = new System.Drawing.Size(108, 13);
            this.lblDeathSumIns.TabIndex = 48;
            this.lblDeathSumIns.Text = "Death - Sum Insured*";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(185, 130);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(190, 20);
            this.txtAge.TabIndex = 3;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(129, 137);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(30, 13);
            this.lblAge.TabIndex = 43;
            this.lblAge.Text = "Age*";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(185, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(120, 55);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Name*";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(93, 219);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(66, 13);
            this.lblOccupation.TabIndex = 50;
            this.lblOccupation.Text = "Occupation*";
            // 
            // cmbOccupation
            // 
            this.cmbOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOccupation.FormattingEnabled = true;
            this.cmbOccupation.Location = new System.Drawing.Point(185, 212);
            this.cmbOccupation.Name = "cmbOccupation";
            this.cmbOccupation.Size = new System.Drawing.Size(190, 21);
            this.cmbOccupation.TabIndex = 5;
            // 
            // lblMonthlyPrem
            // 
            this.lblMonthlyPrem.AutoSize = true;
            this.lblMonthlyPrem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyPrem.Location = new System.Drawing.Point(40, 290);
            this.lblMonthlyPrem.Name = "lblMonthlyPrem";
            this.lblMonthlyPrem.Size = new System.Drawing.Size(119, 15);
            this.lblMonthlyPrem.TabIndex = 53;
            this.lblMonthlyPrem.Text = "Monthly Premium";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(185, 89);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(190, 20);
            this.dtpDOB.TabIndex = 2;
            this.dtpDOB.Value = new System.DateTime(2003, 6, 11, 0, 0, 0, 0);
            // 
            // txtMonthlyPremCalc
            // 
            this.txtMonthlyPremCalc.BackColor = System.Drawing.Color.LightGray;
            this.txtMonthlyPremCalc.Enabled = false;
            this.txtMonthlyPremCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonthlyPremCalc.Location = new System.Drawing.Point(186, 285);
            this.txtMonthlyPremCalc.Name = "txtMonthlyPremCalc";
            this.txtMonthlyPremCalc.ReadOnly = true;
            this.txtMonthlyPremCalc.Size = new System.Drawing.Size(189, 20);
            this.txtMonthlyPremCalc.TabIndex = 6;
            this.txtMonthlyPremCalc.WordWrap = false;
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Location = new System.Drawing.Point(440, 292);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(0, 13);
            this.lblValidation.TabIndex = 54;
            // 
            // frmMonthlyPremCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 406);
            this.Controls.Add(this.lblValidation);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.txtMonthlyPremCalc);
            this.Controls.Add(this.lblMonthlyPrem);
            this.Controls.Add(this.cmbOccupation);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.txtDeathSumIns);
            this.Controls.Add(this.lblDeathSumIns);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.MaximizeBox = false;
            this.Name = "frmMonthlyPremCalc";
            this.Text = "Monthly Premium Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtDeathSumIns;
        private System.Windows.Forms.Label lblDeathSumIns;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.ComboBox cmbOccupation;
        private System.Windows.Forms.Label lblMonthlyPrem;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtMonthlyPremCalc;
        private System.Windows.Forms.Label lblValidation;
    }
}

