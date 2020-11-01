namespace Tuan2_NamAmLich
{
	partial class frmBaiTap4
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtDuongLich = new System.Windows.Forms.TextBox();
			this.lblNamAmLich = new System.Windows.Forms.Label();
			this.btnAmLich = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 147);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(166, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nhập năm dương lịch: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(117, 307);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Năm Âm lịch:";
			// 
			// txtDuongLich
			// 
			this.txtDuongLich.Location = new System.Drawing.Point(244, 141);
			this.txtDuongLich.Name = "txtDuongLich";
			this.txtDuongLich.Size = new System.Drawing.Size(393, 26);
			this.txtDuongLich.TabIndex = 1;
			// 
			// lblNamAmLich
			// 
			this.lblNamAmLich.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNamAmLich.Location = new System.Drawing.Point(240, 292);
			this.lblNamAmLich.Name = "lblNamAmLich";
			this.lblNamAmLich.Size = new System.Drawing.Size(397, 35);
			this.lblNamAmLich.TabIndex = 0;
			// 
			// btnAmLich
			// 
			this.btnAmLich.Location = new System.Drawing.Point(244, 217);
			this.btnAmLich.Name = "btnAmLich";
			this.btnAmLich.Size = new System.Drawing.Size(393, 49);
			this.btnAmLich.TabIndex = 2;
			this.btnAmLich.Text = "Xem năm âm lịch tương ứng";
			this.btnAmLich.UseVisualStyleBackColor = true;
			this.btnAmLich.Click += new System.EventHandler(this.btnAmLich_Click);
			// 
			// frmBaiTap4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 692);
			this.Controls.Add(this.btnAmLich);
			this.Controls.Add(this.txtDuongLich);
			this.Controls.Add(this.lblNamAmLich);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmBaiTap4";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDuongLich;
		private System.Windows.Forms.Label lblNamAmLich;
		private System.Windows.Forms.Button btnAmLich;
	}
}

