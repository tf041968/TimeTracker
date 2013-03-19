namespace WindowsFormsApplication1
{
    partial class MainFrame
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
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lbGrid = new System.Windows.Forms.ListBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(31, 24);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 21);
            this.cmbMonth.TabIndex = 0;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmbDay
            // 
            this.cmbDay.DropDownHeight = 750;
            this.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.IntegralHeight = false;
            this.cmbDay.Location = new System.Drawing.Point(183, 24);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(46, 21);
            this.cmbDay.TabIndex = 1;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(355, 31);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(85, 13);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Number of hours";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(472, 24);
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(100, 20);
            this.tbHours.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(628, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(812, 31);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(31, 13);
            this.lblSum.TabIndex = 5;
            this.lblSum.Text = "Sum:";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(884, 30);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(40, 15);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = " ";
            // 
            // lbGrid
            // 
            this.lbGrid.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrid.FormattingEnabled = true;
            this.lbGrid.ItemHeight = 14;
            this.lbGrid.Location = new System.Drawing.Point(31, 65);
            this.lbGrid.Name = "lbGrid";
            this.lbGrid.Size = new System.Drawing.Size(893, 634);
            this.lbGrid.TabIndex = 7;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(236, 24);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(89, 21);
            this.cbYear.TabIndex = 8;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 726);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.lbGrid);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.cmbDay);
            this.Controls.Add(this.cmbMonth);
            this.Name = "MainFrame";
            this.Text = "Timetracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.ListBox lbGrid;
        private System.Windows.Forms.ComboBox cbYear;
    }
}

