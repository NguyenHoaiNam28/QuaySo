
namespace WindowsFormsQuaySo
{
    partial class frm_QuaySoMayMan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSQuay = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboGiaiThuong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMunber5 = new System.Windows.Forms.Label();
            this.lblMunber4 = new System.Windows.Forms.Label();
            this.lblMunber2 = new System.Windows.Forms.Label();
            this.lblMunber3 = new System.Windows.Forms.Label();
            this.lblMunber1 = new System.Windows.Forms.Label();
            this.btnQuay = new System.Windows.Forms.Button();
            this.btnInDS = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSTThuong = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDSach = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAccount = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSQuay)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTThuong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1459, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUAY SỐ TRÚNG THƯỞNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSQuay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(1106, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 646);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách quay";
            // 
            // dgvDSQuay
            // 
            this.dgvDSQuay.AllowUserToAddRows = false;
            this.dgvDSQuay.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSQuay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSQuay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSQuay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colID,
            this.colHoTen,
            this.colPB});
            this.dgvDSQuay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSQuay.Location = new System.Drawing.Point(3, 18);
            this.dgvDSQuay.Name = "dgvDSQuay";
            this.dgvDSQuay.ReadOnly = true;
            this.dgvDSQuay.RowHeadersVisible = false;
            this.dgvDSQuay.RowHeadersWidth = 51;
            this.dgvDSQuay.RowTemplate.Height = 32;
            this.dgvDSQuay.Size = new System.Drawing.Size(347, 625);
            this.dgvDSQuay.TabIndex = 0;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 40;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 50;
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colPB
            // 
            this.colPB.DataPropertyName = "PhongBan";
            this.colPB.HeaderText = "Phòng ban";
            this.colPB.MinimumWidth = 6;
            this.colPB.Name = "colPB";
            this.colPB.ReadOnly = true;
            this.colPB.Width = 110;
            // 
            // cboGiaiThuong
            // 
            this.cboGiaiThuong.FormattingEnabled = true;
            this.cboGiaiThuong.Location = new System.Drawing.Point(132, 76);
            this.cboGiaiThuong.Name = "cboGiaiThuong";
            this.cboGiaiThuong.Size = new System.Drawing.Size(275, 24);
            this.cboGiaiThuong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Chọn giải";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.lblMunber5);
            this.groupBox3.Controls.Add(this.lblMunber4);
            this.groupBox3.Controls.Add(this.lblMunber2);
            this.groupBox3.Controls.Add(this.lblMunber3);
            this.groupBox3.Controls.Add(this.lblMunber1);
            this.groupBox3.Location = new System.Drawing.Point(12, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1088, 309);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblMunber5
            // 
            this.lblMunber5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMunber5.AutoSize = true;
            this.lblMunber5.BackColor = System.Drawing.Color.Cyan;
            this.lblMunber5.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunber5.Location = new System.Drawing.Point(825, 58);
            this.lblMunber5.Name = "lblMunber5";
            this.lblMunber5.Size = new System.Drawing.Size(155, 170);
            this.lblMunber5.TabIndex = 9;
            this.lblMunber5.Text = "0";
            // 
            // lblMunber4
            // 
            this.lblMunber4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMunber4.AutoSize = true;
            this.lblMunber4.BackColor = System.Drawing.Color.Cyan;
            this.lblMunber4.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunber4.Location = new System.Drawing.Point(644, 58);
            this.lblMunber4.Name = "lblMunber4";
            this.lblMunber4.Size = new System.Drawing.Size(155, 170);
            this.lblMunber4.TabIndex = 8;
            this.lblMunber4.Text = "0";
            // 
            // lblMunber2
            // 
            this.lblMunber2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMunber2.AutoSize = true;
            this.lblMunber2.BackColor = System.Drawing.Color.Cyan;
            this.lblMunber2.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunber2.Location = new System.Drawing.Point(290, 58);
            this.lblMunber2.Name = "lblMunber2";
            this.lblMunber2.Size = new System.Drawing.Size(155, 170);
            this.lblMunber2.TabIndex = 7;
            this.lblMunber2.Text = "0";
            // 
            // lblMunber3
            // 
            this.lblMunber3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMunber3.AutoSize = true;
            this.lblMunber3.BackColor = System.Drawing.Color.Cyan;
            this.lblMunber3.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunber3.Location = new System.Drawing.Point(467, 58);
            this.lblMunber3.Name = "lblMunber3";
            this.lblMunber3.Size = new System.Drawing.Size(155, 170);
            this.lblMunber3.TabIndex = 6;
            this.lblMunber3.Text = "0";
            // 
            // lblMunber1
            // 
            this.lblMunber1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMunber1.AutoSize = true;
            this.lblMunber1.BackColor = System.Drawing.Color.Cyan;
            this.lblMunber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunber1.Location = new System.Drawing.Point(112, 58);
            this.lblMunber1.Name = "lblMunber1";
            this.lblMunber1.Size = new System.Drawing.Size(155, 170);
            this.lblMunber1.TabIndex = 5;
            this.lblMunber1.Text = "0";
            // 
            // btnQuay
            // 
            this.btnQuay.Location = new System.Drawing.Point(423, 71);
            this.btnQuay.Name = "btnQuay";
            this.btnQuay.Size = new System.Drawing.Size(92, 34);
            this.btnQuay.TabIndex = 6;
            this.btnQuay.Text = "Quay";
            this.btnQuay.UseVisualStyleBackColor = true;
            this.btnQuay.Click += new System.EventHandler(this.btnQuay_Click);
            // 
            // btnInDS
            // 
            this.btnInDS.Location = new System.Drawing.Point(534, 71);
            this.btnInDS.Name = "btnInDS";
            this.btnInDS.Size = new System.Drawing.Size(119, 34);
            this.btnInDS.TabIndex = 7;
            this.btnInDS.Text = "In DS trúng";
            this.btnInDS.UseVisualStyleBackColor = true;
            this.btnInDS.Click += new System.EventHandler(this.btnInDS_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSTThuong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 426);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1106, 272);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách trúng thưởng";
            // 
            // dgvDSTThuong
            // 
            this.dgvDSTThuong.AllowUserToAddRows = false;
            this.dgvDSTThuong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSTThuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSTThuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTThuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.colGiai});
            this.dgvDSTThuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSTThuong.Location = new System.Drawing.Point(3, 18);
            this.dgvDSTThuong.Name = "dgvDSTThuong";
            this.dgvDSTThuong.ReadOnly = true;
            this.dgvDSTThuong.RowHeadersVisible = false;
            this.dgvDSTThuong.RowHeadersWidth = 51;
            this.dgvDSTThuong.RowTemplate.Height = 32;
            this.dgvDSTThuong.Size = new System.Drawing.Size(1100, 251);
            this.dgvDSTThuong.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "STT";
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn3.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhongBan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phòng ban";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // colGiai
            // 
            this.colGiai.DataPropertyName = "Giai";
            this.colGiai.HeaderText = "Giải";
            this.colGiai.MinimumWidth = 6;
            this.colGiai.Name = "colGiai";
            this.colGiai.ReadOnly = true;
            this.colGiai.Width = 150;
            // 
            // btnDSach
            // 
            this.btnDSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDSach.Location = new System.Drawing.Point(959, 69);
            this.btnDSach.Name = "btnDSach";
            this.btnDSach.Size = new System.Drawing.Size(116, 36);
            this.btnDSach.TabIndex = 9;
            this.btnDSach.Text = "Danh sách";
            this.btnDSach.UseVisualStyleBackColor = true;
            this.btnDSach.Click += new System.EventHandler(this.btnDSach_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(659, 71);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(103, 34);
            this.btnAccount.TabIndex = 10;
            this.btnAccount.Text = "QLTK";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // frm_QuaySoMayMan
            // 
            this.AcceptButton = this.btnQuay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 698);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.btnDSach);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInDS);
            this.Controls.Add(this.btnQuay);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboGiaiThuong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_QuaySoMayMan";
            this.Text = "Quay số may mắn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuaySoMayMan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSQuay)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTThuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGiaiThuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuay;
        private System.Windows.Forms.Button btnInDS;
        private System.Windows.Forms.DataGridView dgvDSQuay;
        private System.Windows.Forms.Label lblMunber1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSTThuong;
        private System.Windows.Forms.Button btnDSach;
        private System.Windows.Forms.Label lblMunber5;
        private System.Windows.Forms.Label lblMunber4;
        private System.Windows.Forms.Label lblMunber2;
        private System.Windows.Forms.Label lblMunber3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPB;
        private System.Windows.Forms.Button btnAccount;
    }
}

