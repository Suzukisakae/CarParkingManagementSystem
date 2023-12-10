﻿namespace CarParkingManagementSystem
{
    partial class formReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgReport = new System.Windows.Forms.DataGridView();
            this.dtpDayEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDayStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Thông tin Doanh Thu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReload);
            this.panel2.Controls.Add(this.txtFind);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 73);
            this.panel2.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReload.Image = global::CarParkingManagementSystem.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(288, 21);
            this.btnReload.Margin = new System.Windows.Forms.Padding(0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(47, 33);
            this.btnReload.TabIndex = 19;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgReport);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 424);
            this.panel1.TabIndex = 20;
            // 
            // dtgReport
            // 
            this.dtgReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgReport.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgReport.Location = new System.Drawing.Point(0, 73);
            this.dtgReport.Margin = new System.Windows.Forms.Padding(0);
            this.dtgReport.Name = "dtgReport";
            this.dtgReport.RowHeadersWidth = 51;
            this.dtgReport.Size = new System.Drawing.Size(983, 351);
            this.dtgReport.TabIndex = 2;
            // 
            // dtpDayEnd
            // 
            this.dtpDayEnd.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDayEnd.Location = new System.Drawing.Point(539, 486);
            this.dtpDayEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDayEnd.Name = "dtpDayEnd";
            this.dtpDayEnd.Size = new System.Drawing.Size(348, 24);
            this.dtpDayEnd.TabIndex = 0;
            // 
            // dtpDayStart
            // 
            this.dtpDayStart.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDayStart.Location = new System.Drawing.Point(163, 486);
            this.dtpDayStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDayStart.Name = "dtpDayStart";
            this.dtpDayStart.Size = new System.Drawing.Size(350, 24);
            this.dtpDayStart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 486);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select Time:";
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Xuat.FlatAppearance.BorderSize = 0;
            this.btn_Xuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xuat.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xuat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Xuat.Location = new System.Drawing.Point(382, 612);
            this.btn_Xuat.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(182, 44);
            this.btn_Xuat.TabIndex = 22;
            this.btn_Xuat.Text = "Xuất ";
            this.btn_Xuat.UseVisualStyleBackColor = false;
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 541);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Select Type:";
            // 
            // cb_Type
            // 
            this.cb_Type.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Items.AddRange(new object[] {
            "Chưa trả",
            "Trả"});
            this.cb_Type.Location = new System.Drawing.Point(163, 541);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(121, 27);
            this.cb_Type.TabIndex = 25;
            // 
            // btn_Xem
            // 
            this.btn_Xem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Xem.FlatAppearance.BorderSize = 2;
            this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xem.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_Xem.Location = new System.Drawing.Point(177, 612);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(180, 44);
            this.btn_Xem.TabIndex = 26;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.UseVisualStyleBackColor = false;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // txtFind
            // 
            this.txtFind.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFind.Location = new System.Drawing.Point(527, 15);
            this.txtFind.Margin = new System.Windows.Forms.Padding(0);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(337, 32);
            this.txtFind.TabIndex = 18;
            // 
            // formReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 756);
            this.Controls.Add(this.btn_Xem);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Xuat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDayEnd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpDayStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formReport";
            this.Text = "formReport";
            this.Load += new System.EventHandler(this.formReport_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpDayEnd;
        private System.Windows.Forms.DateTimePicker dtpDayStart;
        private System.Windows.Forms.DataGridView dtgReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Xuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.TextBox txtFind;
    }
}