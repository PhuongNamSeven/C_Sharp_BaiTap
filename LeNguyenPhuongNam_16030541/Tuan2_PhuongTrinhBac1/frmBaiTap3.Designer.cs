namespace Tuan2_PhuongTrinhBac1
{
	partial class frmBaiTap3
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNhapA = new System.Windows.Forms.TextBox();
			this.txtNhapB = new System.Windows.Forms.TextBox();
			this.btnTinh = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblNghiemPT = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Coral;
			this.label1.Location = new System.Drawing.Point(293, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(397, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "PHUONG TRINH AX + B =0";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(182, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nhập A :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(182, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 20);
			this.label3.TabIndex = 1;
			this.label3.Text = "Nhập B : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(158, 263);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Nghiệm PT :  ";
			// 
			// txtNhapA
			// 
			this.txtNhapA.Location = new System.Drawing.Point(293, 119);
			this.txtNhapA.Name = "txtNhapA";
			this.txtNhapA.Size = new System.Drawing.Size(479, 26);
			this.txtNhapA.TabIndex = 2;
			this.txtNhapA.TextChanged += new System.EventHandler(this.txtNhapA_TextChanged);
			// 
			// txtNhapB
			// 
			this.txtNhapB.Location = new System.Drawing.Point(293, 182);
			this.txtNhapB.Name = "txtNhapB";
			this.txtNhapB.Size = new System.Drawing.Size(479, 26);
			this.txtNhapB.TabIndex = 2;
			this.txtNhapB.TextChanged += new System.EventHandler(this.txtNhapB_TextChanged);
			// 
			// btnTinh
			// 
			this.btnTinh.Location = new System.Drawing.Point(293, 330);
			this.btnTinh.Name = "btnTinh";
			this.btnTinh.Size = new System.Drawing.Size(116, 38);
			this.btnTinh.TabIndex = 3;
			this.btnTinh.Text = "&Tính";
			this.btnTinh.UseVisualStyleBackColor = true;
			this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(457, 330);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(111, 38);
			this.btnXoa.TabIndex = 3;
			this.btnXoa.Text = "&Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(630, 330);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(105, 38);
			this.btnThoat.TabIndex = 3;
			this.btnThoat.Text = "Th&oát";
			this.btnThoat.UseVisualStyleBackColor = true;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// lblNghiemPT
			// 
			this.lblNghiemPT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNghiemPT.Location = new System.Drawing.Point(293, 252);
			this.lblNghiemPT.Name = "lblNghiemPT";
			this.lblNghiemPT.Size = new System.Drawing.Size(475, 31);
			this.lblNghiemPT.TabIndex = 4;
			// 
			// frmBaiTap3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.lblNghiemPT);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnTinh);
			this.Controls.Add(this.txtNhapB);
			this.Controls.Add(this.txtNhapA);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmBaiTap3";
			this.Text = "Giải Phương Trình Bậc 1";
			this.Load += new System.EventHandler(this.frmBaiTap3_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNhapA;
		private System.Windows.Forms.TextBox txtNhapB;
		private System.Windows.Forms.Button btnTinh;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label lblNghiemPT;
	}
}

