namespace PayrollGUI03
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
            this.calculateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTotalGrossPays
            // 
            this.txtTotalGrossPays.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGrossPays.Location = new System.Drawing.Point(1016, 143);
            this.txtTotalGrossPays.Name = "txtTotalGrossPays";
            this.txtTotalGrossPays.ReadOnly = true;
            this.txtTotalGrossPays.Size = new System.Drawing.Size(311, 44);
            this.txtTotalGrossPays.TabIndex = 27;
            this.txtTotalGrossPays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalGrossPayAmt
            // 
            this.txtTotalGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGrossPayAmt.Location = new System.Drawing.Point(1016, 202);
            this.txtTotalGrossPayAmt.Name = "txtTotalGrossPayAmt";
            this.txtTotalGrossPayAmt.ReadOnly = true;
            this.txtTotalGrossPayAmt.Size = new System.Drawing.Size(311, 44);
            this.txtTotalGrossPayAmt.TabIndex = 28;
            this.txtTotalGrossPayAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAvgGrossPayAmt
            // 
            this.txtAvgGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgGrossPayAmt.Location = new System.Drawing.Point(1016, 271);
            this.txtAvgGrossPayAmt.Name = "txtAvgGrossPayAmt";
            this.txtAvgGrossPayAmt.ReadOnly = true;
            this.txtAvgGrossPayAmt.Size = new System.Drawing.Size(311, 44);
            this.txtAvgGrossPayAmt.TabIndex = 29;
            this.txtAvgGrossPayAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAvgGrossPayAmt
            // 
            this.lblAvgGrossPayAmt.BackColor = System.Drawing.Color.Yellow;
            this.lblAvgGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgGrossPayAmt.Location = new System.Drawing.Point(711, 273);
            this.lblAvgGrossPayAmt.Name = "lblAvgGrossPayAmt";
            this.lblAvgGrossPayAmt.Size = new System.Drawing.Size(290, 38);
            this.lblAvgGrossPayAmt.TabIndex = 37;
            this.lblAvgGrossPayAmt.Text = "Avg Gross Pay Amt:";
            this.lblAvgGrossPayAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalGrossPayAmt
            // 
            this.lblTotalGrossPayAmt.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrossPayAmt.Location = new System.Drawing.Point(711, 207);
            this.lblTotalGrossPayAmt.Name = "lblTotalGrossPayAmt";
            this.lblTotalGrossPayAmt.Size = new System.Drawing.Size(290, 38);
            this.lblTotalGrossPayAmt.TabIndex = 36;
            this.lblTotalGrossPayAmt.Text = "Total Gross Pay Amt:";
            this.lblTotalGrossPayAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalGrossPays
            // 
            this.lblTotalGrossPays.BackColor = System.Drawing.Color.Yellow;
            this.lblTotalGrossPays.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrossPays.Location = new System.Drawing.Point(711, 145);
            this.lblTotalGrossPays.Name = "lblTotalGrossPays";
            this.lblTotalGrossPays.Size = new System.Drawing.Size(290, 38);
            this.lblTotalGrossPays.TabIndex = 35;
            this.lblTotalGrossPays.Text = "Total Gross Pays:";
            this.lblTotalGrossPays.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(366, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(329, 44);
            this.txtLastName.TabIndex = 20;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(366, 145);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(329, 44);
            this.txtHoursWorked.TabIndex = 21;
            this.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(366, 214);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(329, 44);
            this.txtHourlyRate.TabIndex = 22;
            this.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPay.Location = new System.Drawing.Point(366, 279);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(329, 44);
            this.txtGrossPay.TabIndex = 26;
            this.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(366, 27);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(329, 44);
            this.txtFirstName.TabIndex = 19;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BackColor = System.Drawing.Color.Yellow;
            this.lblGrossPay.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(62, 282);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(290, 38);
            this.lblGrossPay.TabIndex = 34;
            this.lblGrossPay.Text = "Gross Pay:";
            this.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.BackColor = System.Drawing.Color.Yellow;
            this.lblHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(62, 214);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(290, 38);
            this.lblHourlyRate.TabIndex = 33;
            this.lblHourlyRate.Text = "Hourly Rate;";
            this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.BackColor = System.Drawing.Color.Yellow;
            this.lblHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(62, 148);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(290, 38);
            this.lblHoursWorked.TabIndex = 32;
            this.lblHoursWorked.Text = "HoursWorked:";
            this.lblHoursWorked.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Yellow;
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(62, 86);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(290, 38);
            this.lblLastName.TabIndex = 31;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Yellow;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(62, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(290, 38);
            this.lblFirstName.TabIndex = 30;
            this.lblFirstName.Text = "FIrst Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(834, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 70);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            this.btnExit.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(584, 354);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 70);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnCalculate_Click_1);
            this.btnClear.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(320, 354);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(190, 70);
            this.btnCalculate.TabIndex = 23;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            this.btnCalculate.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnCalculate.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
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
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calculateMenuItem
            // 
            this.calculateMenuItem.Name = "calculateMenuItem";
            this.calculateMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateMenuItem.Text = "Calculate";
            this.calculateMenuItem.Click += new System.EventHandler(this.calculateMenuItem_Click);
            // 
            // clearMenuItem
            // 
            this.clearMenuItem.Name = "clearMenuItem";
            this.clearMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearMenuItem.Text = "Clear";
            this.clearMenuItem.Click += new System.EventHandler(this.clearMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripMenuItem calculateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    }
}

