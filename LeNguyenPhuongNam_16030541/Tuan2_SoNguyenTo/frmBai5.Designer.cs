namespace Tuan2_SoNguyenTo
{
	partial class frmBai5
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
			this.txtSoNguyen = new System.Windows.Forms.TextBox();
			this.btnKiemTraSNT = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblKiemTra = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(146, 194);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập số nguyên :";
			// 
			// txtSoNguyen
			// 
			this.txtSoNguyen.Location = new System.Drawing.Point(296, 188);
			this.txtSoNguyen.Name = "txtSoNguyen";
			this.txtSoNguyen.Size = new System.Drawing.Size(364, 26);
			this.txtSoNguyen.TabIndex = 1;
			// 
			// btnKiemTraSNT
			// 
			this.btnKiemTraSNT.Location = new System.Drawing.Point(296, 273);
			this.btnKiemTraSNT.Name = "btnKiemTraSNT";
			this.btnKiemTraSNT.Size = new System.Drawing.Size(264, 57);
			this.btnKiemTraSNT.TabIndex = 2;
			this.btnKiemTraSNT.Text = "Kiểm tra số nguyên tố";
			this.btnKiemTraSNT.UseVisualStyleBackColor = true;
			this.btnKiemTraSNT.Click += new System.EventHandler(this.btnKiemTraSNT_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(211, 379);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Kiểm tra";
			// 
			// lblKiemTra
			// 
			this.lblKiemTra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblKiemTra.Location = new System.Drawing.Point(292, 367);
			this.lblKiemTra.Name = "lblKiemTra";
			this.lblKiemTra.Size = new System.Drawing.Size(368, 32);
			this.lblKiemTra.TabIndex = 3;
			// 
			// frmBai5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.lblKiemTra);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnKiemTraSNT);
			this.Controls.Add(this.txtSoNguyen);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmBai5";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtSoNguyen;
		private System.Windows.Forms.Button btnKiemTraSNT;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblKiemTra;
	}
}

