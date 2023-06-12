namespace PayrollGUI04
{
    partial class frmPayrollGUI04
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
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTotalGrossPays = new System.Windows.Forms.TextBox();
            this.txtTotalGrossPayAmt = new System.Windows.Forms.TextBox();
            this.txtAvgGrossPayAmt = new System.Windows.Forms.TextBox();
            this.lblAvgGrossPayAmt = new System.Windows.Forms.Label();
            this.lblTotalGrossPayAmt = new System.Windows.Forms.Label();
            this.lblTotalGrossPays = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearMenuItem
            // 
            this.clearMenuItem.Name = "clearMenuItem";
            this.clearMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearMenuItem.Text = "Clear";
            // 
            // calculateMenuItem
            // 
            this.calculateMenuItem.Name = "calculateMenuItem";
            this.calculateMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateMenuItem.Text = "Calculate";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitMenuItem.Text = "Exit";
            // 
            // txtTotalGrossPays
            // 
            this.txtTotalGrossPays.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGrossPays.Location = new System.Drawing.Point(1019, 168);
            this.txtTotalGrossPays.Name = "txtTotalGrossPays";
            this.txtTotalGrossPays.ReadOnly = true;
            this.txtTotalGrossPays.Size = new System.Drawing.Size(311, 44);
            this.txtTotalGrossPays.TabIndex = 8;
            this.txtTotalGrossPays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalGrossPayAmt
            // 
            this.txtTotalGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGrossPayAmt.Location = new System.Drawing.Point(1019, 227);
            this.txtTotalGrossPayAmt.Name = "txtTotalGrossPayAmt";
            this.txtTotalGrossPayAmt.ReadOnly = true;
            this.txtTotalGrossPayAmt.Size = new System.Drawing.Size(311, 44);
            this.txtTotalGrossPayAmt.TabIndex = 9;
            this.txtTotalGrossPayAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAvgGrossPayAmt
            // 
            this.txtAvgGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgGrossPayAmt.Location = new System.Drawing.Point(1019, 296);
            this.txtAvgGrossPayAmt.Name = "txtAvgGrossPayAmt";
            this.txtAvgGrossPayAmt.ReadOnly = true;
            this.txtAvgGrossPayAmt.Size = new System.Drawing.Size(311, 44);
            this.txtAvgGrossPayAmt.TabIndex = 10;
            this.txtAvgGrossPayAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAvgGrossPayAmt
            // 
            this.lblAvgGrossPayAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAvgGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgGrossPayAmt.ForeColor = System.Drawing.Color.White;
            this.lblAvgGrossPayAmt.Location = new System.Drawing.Point(714, 298);
            this.lblAvgGrossPayAmt.Name = "lblAvgGrossPayAmt";
            this.lblAvgGrossPayAmt.Size = new System.Drawing.Size(290, 38);
            this.lblAvgGrossPayAmt.TabIndex = 57;
            this.lblAvgGrossPayAmt.Text = "Avg Gross Pay Amt:";
            this.lblAvgGrossPayAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalGrossPayAmt
            // 
            this.lblTotalGrossPayAmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrossPayAmt.ForeColor = System.Drawing.Color.White;
            this.lblTotalGrossPayAmt.Location = new System.Drawing.Point(714, 232);
            this.lblTotalGrossPayAmt.Name = "lblTotalGrossPayAmt";
            this.lblTotalGrossPayAmt.Size = new System.Drawing.Size(290, 38);
            this.lblTotalGrossPayAmt.TabIndex = 56;
            this.lblTotalGrossPayAmt.Text = "Total Gross Pay Amt:";
            this.lblTotalGrossPayAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalGrossPays
            // 
            this.lblTotalGrossPays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalGrossPays.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrossPays.ForeColor = System.Drawing.Color.White;
            this.lblTotalGrossPays.Location = new System.Drawing.Point(714, 170);
            this.lblTotalGrossPays.Name = "lblTotalGrossPays";
            this.lblTotalGrossPays.Size = new System.Drawing.Size(290, 38);
            this.lblTotalGrossPays.TabIndex = 55;
            this.lblTotalGrossPays.Text = "Total Gross Pays:";
            this.lblTotalGrossPays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(369, 108);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(329, 44);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.Tag = "last name";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(369, 170);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(329, 44);
            this.txtHoursWorked.TabIndex = 2;
            this.txtHoursWorked.Tag = "hours worked";
            this.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(369, 239);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(329, 44);
            this.txtHourlyRate.TabIndex = 3;
            this.txtHourlyRate.Tag = "hourly rate";
            this.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPay.Location = new System.Drawing.Point(369, 304);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(329, 44);
            this.txtGrossPay.TabIndex = 7;
            this.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(369, 45);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(329, 44);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.Tag = "first name";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGrossPay.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.ForeColor = System.Drawing.Color.White;
            this.lblGrossPay.Location = new System.Drawing.Point(65, 307);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(290, 38);
            this.lblGrossPay.TabIndex = 15;
            this.lblGrossPay.Text = "Gross Pay:";
            this.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.ForeColor = System.Drawing.Color.White;
            this.lblHourlyRate.Location = new System.Drawing.Point(65, 239);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(290, 38);
            this.lblHourlyRate.TabIndex = 14;
            this.lblHourlyRate.Text = "Hourly Rate;";
            this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.ForeColor = System.Drawing.Color.White;
            this.lblHoursWorked.Location = new System.Drawing.Point(65, 173);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(290, 38);
            this.lblHoursWorked.TabIndex = 13;
            this.lblHoursWorked.Text = "HoursWorked:";
            this.lblHoursWorked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.White;
            this.lblLastName.Location = new System.Drawing.Point(65, 108);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(288, 38);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.White;
            this.lblFirstName.Location = new System.Drawing.Point(65, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(290, 38);
            this.lblFirstName.TabIndex = 11;
            this.lblFirstName.Text = "FIrst Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(834, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 70);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(584, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 70);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(320, 367);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(190, 70);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateMenuItem,
            this.clearMenuItem,
            this.exitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1389, 24);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmPayrollGUI04
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1389, 450);
            this.Controls.Add(this.txtTotalGrossPays);
            this.Controls.Add(this.txtTotalGrossPayAmt);
            this.Controls.Add(this.txtAvgGrossPayAmt);
            this.Controls.Add(this.lblAvgGrossPayAmt);
            this.Controls.Add(this.lblTotalGrossPayAmt);
            this.Controls.Add(this.lblTotalGrossPays);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmPayrollGUI04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# GUI Payroll Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.TextBox txtTotalGrossPays;
        private System.Windows.Forms.TextBox txtTotalGrossPayAmt;
        private System.Windows.Forms.TextBox txtAvgGrossPayAmt;
        private System.Windows.Forms.Label lblAvgGrossPayAmt;
        private System.Windows.Forms.Label lblTotalGrossPayAmt;
        private System.Windows.Forms.Label lblTotalGrossPays;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

