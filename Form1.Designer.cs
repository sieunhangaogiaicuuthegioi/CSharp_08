namespace CSharp_08
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
            this.TinhCanChi = new System.Windows.Forms.Label();
            this.DuongLich = new System.Windows.Forms.Label();
            this.AmLich = new System.Windows.Forms.Label();
            this.txtDuongLich = new System.Windows.Forms.TextBox();
            this.txtAmLich = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TinhCanChi
            // 
            this.TinhCanChi.AutoSize = true;
            this.TinhCanChi.Font = new System.Drawing.Font("News701 BT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhCanChi.Location = new System.Drawing.Point(510, 39);
            this.TinhCanChi.Name = "TinhCanChi";
            this.TinhCanChi.Size = new System.Drawing.Size(473, 78);
            this.TinhCanChi.TabIndex = 0;
            this.TinhCanChi.Text = "Tính Can Chi";
            this.TinhCanChi.Click += new System.EventHandler(this.label1_Click);
            // 
            // DuongLich
            // 
            this.DuongLich.AutoSize = true;
            this.DuongLich.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DuongLich.Location = new System.Drawing.Point(174, 220);
            this.DuongLich.Name = "DuongLich";
            this.DuongLich.Size = new System.Drawing.Size(220, 46);
            this.DuongLich.TabIndex = 1;
            this.DuongLich.Text = "Dương Lịch";
            this.DuongLich.Click += new System.EventHandler(this.label2_Click);
            // 
            // AmLich
            // 
            this.AmLich.AutoSize = true;
            this.AmLich.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmLich.Location = new System.Drawing.Point(174, 394);
            this.AmLich.Name = "AmLich";
            this.AmLich.Size = new System.Drawing.Size(160, 46);
            this.AmLich.TabIndex = 2;
            this.AmLich.Text = "Âm Lịch";
            this.AmLich.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDuongLich
            // 
            this.txtDuongLich.Location = new System.Drawing.Point(469, 231);
            this.txtDuongLich.Name = "txtDuongLich";
            this.txtDuongLich.Size = new System.Drawing.Size(514, 20);
            this.txtDuongLich.TabIndex = 3;
            // 
            // txtAmLich
            // 
            this.txtAmLich.Location = new System.Drawing.Point(469, 408);
            this.txtAmLich.Name = "txtAmLich";
            this.txtAmLich.Size = new System.Drawing.Size(514, 20);
            this.txtAmLich.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSalmon;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(556, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 112);
            this.button1.TabIndex = 5;
            this.button1.Text = "Chuyển Đổi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 840);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAmLich);
            this.Controls.Add(this.txtDuongLich);
            this.Controls.Add(this.AmLich);
            this.Controls.Add(this.DuongLich);
            this.Controls.Add(this.TinhCanChi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TinhCanChi;
        private System.Windows.Forms.Label DuongLich;
        private System.Windows.Forms.Label AmLich;
        private System.Windows.Forms.TextBox txtDuongLich;
        private System.Windows.Forms.TextBox txtAmLich;
        private System.Windows.Forms.Button button1;
    }
}

