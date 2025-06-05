namespace WindowsFormsApp4
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
            this.lblHoTen = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.tx = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnHoLot = new System.Windows.Forms.Button();
            this.btnTen = new System.Windows.Forms.Button();
            this.btnHoVaTen = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHoTen
            // 
            this.lblHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHoTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHoTen.Location = new System.Drawing.Point(0, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(582, 53);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Location = new System.Drawing.Point(2, 82);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(45, 16);
            this.t.TabIndex = 1;
            this.t.Text = "Họ lót:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(68, 76);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(483, 22);
            this.txtHo.TabIndex = 2;
            this.txtHo.TextChanged += new System.EventHandler(this.txtHo_TextChanged);
            // 
            // tx
            // 
            this.tx.AutoSize = true;
            this.tx.Location = new System.Drawing.Point(2, 114);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(34, 16);
            this.tx.TabIndex = 3;
            this.tx.Text = "Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(68, 108);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(483, 22);
            this.txtTen.TabIndex = 4;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // btnHoLot
            // 
            this.btnHoLot.Location = new System.Drawing.Point(82, 152);
            this.btnHoLot.Name = "btnHoLot";
            this.btnHoLot.Size = new System.Drawing.Size(75, 38);
            this.btnHoLot.TabIndex = 5;
            this.btnHoLot.Text = "&Họ lót";
            this.btnHoLot.UseVisualStyleBackColor = true;
            this.btnHoLot.Click += new System.EventHandler(this.btnHoLot_Click);
            // 
            // btnTen
            // 
            this.btnTen.Location = new System.Drawing.Point(211, 152);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(96, 39);
            this.btnTen.TabIndex = 6;
            this.btnTen.Text = "&Tên";
            this.btnTen.UseVisualStyleBackColor = true;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnHoVaTen
            // 
            this.btnHoVaTen.Location = new System.Drawing.Point(353, 152);
            this.btnHoVaTen.Name = "btnHoVaTen";
            this.btnHoVaTen.Size = new System.Drawing.Size(111, 38);
            this.btnHoVaTen.TabIndex = 7;
            this.btnHoVaTen.Text = "Họ và &tên";
            this.btnHoVaTen.UseVisualStyleBackColor = true;
            this.btnHoVaTen.Click += new System.EventHandler(this.btnHoVaTen_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(160, 207);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(176, 39);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát chương trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(582, 258);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHoVaTen);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.btnHoLot);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.t);
            this.Controls.Add(this.lblHoTen);
            this.Name = "Form1";
            this.Text = "Bài tập họ tên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label tx;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnHoLot;
        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnHoVaTen;
        private System.Windows.Forms.Button btnThoat;
    }
}

