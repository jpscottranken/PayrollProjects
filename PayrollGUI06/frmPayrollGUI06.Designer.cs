namespace PayrollGUI06
{
    partial class frmPayrollGUI06
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
            this.ldlDepartment = new System.Windows.Forms.Label();
            this.txtYearsOfService = new System.Windows.Forms.TextBox();
            this.lblYearsOfService = new System.Windows.Forms.Label();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.lblHireDate = new System.Windows.Forms.Label();
            this.btnLookup = new System.Windows.Forms.Button();
            this.lookupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.lblEmployeeID = new System.Windows.Forms.Label();
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
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ldlDepartment
            // 
            this.ldlDepartment.BackColor = System.Drawing.Color.Cyan;
            this.ldlDepartment.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldlDepartment.ForeColor = System.Drawing.Color.Black;
            this.ldlDepartment.Location = new System.Drawing.Point(713, 59);
            this.ldlDepartment.Name = "ldlDepartment";
            this.ldlDepartment.Size = new System.Drawing.Size(290, 38);
            this.ldlDepartment.TabIndex = 17;
            this.ldlDepartment.Text = "Department:";
            this.ldlDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYearsOfService
            // 
            this.txtYearsOfService.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearsOfService.Location = new System.Drawing.Point(1017, 198);
            this.txtYearsOfService.Name = "txtYearsOfService";
            this.txtYearsOfService.ReadOnly = true;
            this.txtYearsOfService.Size = new System.Drawing.Size(311, 44);
            this.txtYearsOfService.TabIndex = 9;
            this.txtYearsOfService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblYearsOfService
            // 
            this.lblYearsOfService.BackColor = System.Drawing.Color.Cyan;
            this.lblYearsOfService.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearsOfService.ForeColor = System.Drawing.Color.Black;
            this.lblYearsOfService.Location = new System.Drawing.Point(713, 200);
            this.lblYearsOfService.Name = "lblYearsOfService";
            this.lblYearsOfService.Size = new System.Drawing.Size(290, 38);
            this.lblYearsOfService.TabIndex = 21;
            this.lblYearsOfService.Text = "Years Of Service:";
            this.lblYearsOfService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHireDate.Location = new System.Drawing.Point(368, 200);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.ReadOnly = true;
            this.txtHireDate.Size = new System.Drawing.Size(329, 44);
            this.txtHireDate.TabIndex = 8;
            this.txtHireDate.Tag = "hire date";
            this.txtHireDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHireDate
            // 
            this.lblHireDate.BackColor = System.Drawing.Color.Cyan;
            this.lblHireDate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHireDate.ForeColor = System.Drawing.Color.Black;
            this.lblHireDate.Location = new System.Drawing.Point(64, 203);
            this.lblHireDate.Name = "lblHireDate";
            this.lblHireDate.Size = new System.Drawing.Size(290, 38);
            this.lblHireDate.TabIndex = 20;
            this.lblHireDate.Text = "Hire Date:";
            this.lblHireDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLookup
            // 
            this.btnLookup.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookup.Location = new System.Drawing.Point(447, 681);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(190, 70);
            this.btnLookup.TabIndex = 3;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // lookupToolStripMenuItem
            // 
            this.lookupToolStripMenuItem.Name = "lookupToolStripMenuItem";
            this.lookupToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.lookupToolStripMenuItem.Text = "Lookup";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitMenuItem.Text = "Exit";
            // 
            // clearMenuItem
            // 
            this.clearMenuItem.Name = "clearMenuItem";
            this.clearMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // calculateMenuItem
            // 
            this.calculateMenuItem.Name = "calculateMenuItem";
            this.calculateMenuItem.Size = new System.Drawing.Size(68, 20);
            this.calculateMenuItem.Text = "Calculate";
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.Location = new System.Drawing.Point(368, 59);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(329, 44);
            this.txtEmployeeID.TabIndex = 0;
            this.txtEmployeeID.Tag = "employeeID";
            this.txtEmployeeID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmployeeID
            // 
            this.lblEmployeeID.BackColor = System.Drawing.Color.Cyan;
            this.lblEmployeeID.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeID.Location = new System.Drawing.Point(64, 59);
            this.lblEmployeeID.Name = "lblEmployeeID";
            this.lblEmployeeID.Size = new System.Drawing.Size(290, 38);
            this.lblEmployeeID.TabIndex = 16;
            this.lblEmployeeID.Text = "Employee ID:";
            this.lblEmployeeID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalGrossPays
            // 
            this.txtTotalGrossPays.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGrossPays.Location = new System.Drawing.Point(1019, 273);
            this.txtTotalGrossPays.Name = "txtTotalGrossPays";
            this.txtTotalGrossPays.ReadOnly = true;
            this.txtTotalGrossPays.Size = new System.Drawing.Size(311, 44);
            this.txtTotalGrossPays.TabIndex = 11;
            this.txtTotalGrossPays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalGrossPayAmt
            // 
            this.txtTotalGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGrossPayAmt.Location = new System.Drawing.Point(1019, 350);
            this.txtTotalGrossPayAmt.Name = "txtTotalGrossPayAmt";
            this.txtTotalGrossPayAmt.ReadOnly = true;
            this.txtTotalGrossPayAmt.Size = new System.Drawing.Size(311, 44);
            this.txtTotalGrossPayAmt.TabIndex = 13;
            this.txtTotalGrossPayAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAvgGrossPayAmt
            // 
            this.txtAvgGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvgGrossPayAmt.Location = new System.Drawing.Point(1019, 424);
            this.txtAvgGrossPayAmt.Name = "txtAvgGrossPayAmt";
            this.txtAvgGrossPayAmt.ReadOnly = true;
            this.txtAvgGrossPayAmt.Size = new System.Drawing.Size(311, 44);
            this.txtAvgGrossPayAmt.TabIndex = 15;
            this.txtAvgGrossPayAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAvgGrossPayAmt
            // 
            this.lblAvgGrossPayAmt.BackColor = System.Drawing.Color.Cyan;
            this.lblAvgGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgGrossPayAmt.ForeColor = System.Drawing.Color.Black;
            this.lblAvgGrossPayAmt.Location = new System.Drawing.Point(722, 426);
            this.lblAvgGrossPayAmt.Name = "lblAvgGrossPayAmt";
            this.lblAvgGrossPayAmt.Size = new System.Drawing.Size(290, 38);
            this.lblAvgGrossPayAmt.TabIndex = 27;
            this.lblAvgGrossPayAmt.Text = "Avg Gross Pay Amt:";
            this.lblAvgGrossPayAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalGrossPayAmt
            // 
            this.lblTotalGrossPayAmt.BackColor = System.Drawing.Color.Cyan;
            this.lblTotalGrossPayAmt.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrossPayAmt.ForeColor = System.Drawing.Color.Black;
            this.lblTotalGrossPayAmt.Location = new System.Drawing.Point(722, 352);
            this.lblTotalGrossPayAmt.Name = "lblTotalGrossPayAmt";
            this.lblTotalGrossPayAmt.Size = new System.Drawing.Size(290, 38);
            this.lblTotalGrossPayAmt.TabIndex = 25;
            this.lblTotalGrossPayAmt.Text = "Total Gross Pay Amt:";
            this.lblTotalGrossPayAmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalGrossPays
            // 
            this.lblTotalGrossPays.BackColor = System.Drawing.Color.Cyan;
            this.lblTotalGrossPays.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrossPays.ForeColor = System.Drawing.Color.Black;
            this.lblTotalGrossPays.Location = new System.Drawing.Point(722, 275);
            this.lblTotalGrossPays.Name = "lblTotalGrossPays";
            this.lblTotalGrossPays.Size = new System.Drawing.Size(290, 38);
            this.lblTotalGrossPays.TabIndex = 23;
            this.lblTotalGrossPays.Text = "Total Gross Pays:";
            this.lblTotalGrossPays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(1018, 129);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(312, 44);
            this.txtLastName.TabIndex = 7;
            this.txtLastName.Tag = "last name";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(377, 275);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.ReadOnly = true;
            this.txtHoursWorked.Size = new System.Drawing.Size(329, 44);
            this.txtHoursWorked.TabIndex = 10;
            this.txtHoursWorked.Tag = "hours worked";
            this.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(377, 359);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.ReadOnly = true;
            this.txtHourlyRate.Size = new System.Drawing.Size(329, 44);
            this.txtHourlyRate.TabIndex = 12;
            this.txtHourlyRate.Tag = "hourly rate";
            this.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPay.Location = new System.Drawing.Point(377, 432);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(329, 44);
            this.txtGrossPay.TabIndex = 14;
            this.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(368, 129);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(329, 44);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.Tag = "first name";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.BackColor = System.Drawing.Color.Cyan;
            this.lblGrossPay.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.ForeColor = System.Drawing.Color.Black;
            this.lblGrossPay.Location = new System.Drawing.Point(73, 435);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(290, 38);
            this.lblGrossPay.TabIndex = 26;
            this.lblGrossPay.Text = "Gross Pay:";
            this.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.BackColor = System.Drawing.Color.Cyan;
            this.lblHourlyRate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.ForeColor = System.Drawing.Color.Black;
            this.lblHourlyRate.Location = new System.Drawing.Point(73, 359);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(290, 38);
            this.lblHourlyRate.TabIndex = 24;
            this.lblHourlyRate.Text = "Hourly Rate;";
            this.lblHourlyRate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.BackColor = System.Drawing.Color.Cyan;
            this.lblHoursWorked.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.ForeColor = System.Drawing.Color.Black;
            this.lblHoursWorked.Location = new System.Drawing.Point(73, 278);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(290, 38);
            this.lblHoursWorked.TabIndex = 22;
            this.lblHoursWorked.Text = "HoursWorked:";
            this.lblHoursWorked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.BackColor = System.Drawing.Color.Cyan;
            this.lblLastName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Black;
            this.lblLastName.Location = new System.Drawing.Point(713, 129);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(290, 38);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BackColor = System.Drawing.Color.Cyan;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Black;
            this.lblFirstName.Location = new System.Drawing.Point(64, 129);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(290, 38);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = "FIrst Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(947, 681);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 70);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(691, 681);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 70);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(188, 681);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(190, 70);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateMenuItem,
            this.clearMenuItem,
            this.exitMenuItem,
            this.clearToolStripMenuItem,
            this.lookupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1403, 24);
            this.menuStrip1.TabIndex = 109;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartment.Location = new System.Drawing.Point(1019, 59);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(313, 44);
            this.txtDepartment.TabIndex = 110;
            this.txtDepartment.Tag = "employeeID";
            this.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPayrollGUI06
            // 
            this.AcceptButton = this.btnLookup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1403, 766);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.ldlDepartment);
            this.Controls.Add(this.txtYearsOfService);
            this.Controls.Add(this.lblYearsOfService);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.lblHireDate);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.lblEmployeeID);
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
            this.Name = "frmPayrollGUI06";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPayrollGUI06_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ldlDepartment;
        private System.Windows.Forms.TextBox txtYearsOfService;
        private System.Windows.Forms.Label lblYearsOfService;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.Label lblHireDate;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.ToolStripMenuItem lookupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateMenuItem;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label lblEmployeeID;
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
        private System.Windows.Forms.TextBox txtDepartment;
    }
}

