namespace kiemTraTaQuan
{
    partial class FrmAll
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
            this.mainText = new System.Windows.Forms.Label();
            this.btnTaiSan = new System.Windows.Forms.Button();
            this.btnSuaChua = new System.Windows.Forms.Button();
            this.btnDieuChuyen = new System.Windows.Forms.Button();
            this.btnLoaiTaiSan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.AutoSize = true;
            this.mainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainText.Location = new System.Drawing.Point(77, 44);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(228, 46);
            this.mainText.TabIndex = 0;
            this.mainText.Text = "Form Chính";
            // 
            // btnTaiSan
            // 
            this.btnTaiSan.Location = new System.Drawing.Point(37, 134);
            this.btnTaiSan.Name = "btnTaiSan";
            this.btnTaiSan.Size = new System.Drawing.Size(146, 68);
            this.btnTaiSan.TabIndex = 1;
            this.btnTaiSan.Text = "Tài sản";
            this.btnTaiSan.UseVisualStyleBackColor = true;
            // 
            // btnSuaChua
            // 
            this.btnSuaChua.Location = new System.Drawing.Point(189, 134);
            this.btnSuaChua.Name = "btnSuaChua";
            this.btnSuaChua.Size = new System.Drawing.Size(146, 68);
            this.btnSuaChua.TabIndex = 2;
            this.btnSuaChua.Text = "Sửa chữa";
            this.btnSuaChua.UseVisualStyleBackColor = true;
            // 
            // btnDieuChuyen
            // 
            this.btnDieuChuyen.Location = new System.Drawing.Point(189, 208);
            this.btnDieuChuyen.Name = "btnDieuChuyen";
            this.btnDieuChuyen.Size = new System.Drawing.Size(146, 68);
            this.btnDieuChuyen.TabIndex = 3;
            this.btnDieuChuyen.Text = "Điều chuyển";
            this.btnDieuChuyen.UseVisualStyleBackColor = true;
            this.btnDieuChuyen.Click += new System.EventHandler(this.btnDieuChuyen_Click);
            // 
            // btnLoaiTaiSan
            // 
            this.btnLoaiTaiSan.Location = new System.Drawing.Point(37, 208);
            this.btnLoaiTaiSan.Name = "btnLoaiTaiSan";
            this.btnLoaiTaiSan.Size = new System.Drawing.Size(146, 68);
            this.btnLoaiTaiSan.TabIndex = 4;
            this.btnLoaiTaiSan.Text = "Loại Tài sản";
            this.btnLoaiTaiSan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tìm thông tin Tài sản điều chuyển";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoaiTaiSan);
            this.Controls.Add(this.btnDieuChuyen);
            this.Controls.Add(this.btnSuaChua);
            this.Controls.Add(this.btnTaiSan);
            this.Controls.Add(this.mainText);
            this.Name = "FrmAll";
            this.Text = "FrmTaiSan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainText;
        private System.Windows.Forms.Button btnTaiSan;
        private System.Windows.Forms.Button btnSuaChua;
        private System.Windows.Forms.Button btnDieuChuyen;
        private System.Windows.Forms.Button btnLoaiTaiSan;
        private System.Windows.Forms.Button button1;
    }
}