
namespace veriTabani2023Proje
{
    partial class frm_müsteri
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
            this.receteli_grpbox = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.receteliAdet_txtbox = new System.Windows.Forms.TextBox();
            this.receteliAdet_lbl = new System.Windows.Forms.Label();
            this.receteliAlım_btn = new System.Windows.Forms.Button();
            this.recete_txtbox = new System.Windows.Forms.TextBox();
            this.recete_lbl = new System.Windows.Forms.Label();
            this.recetesiz_grpbox = new System.Windows.Forms.GroupBox();
            this.recetesizAdet_txtbox = new System.Windows.Forms.TextBox();
            this.recetesizAdet_lbl = new System.Windows.Forms.Label();
            this.recetesizAlım_btn = new System.Windows.Forms.Button();
            this.ilacAd_txtbox = new System.Windows.Forms.TextBox();
            this.ilacAd_lbl = new System.Windows.Forms.Label();
            this.receteli_grpbox.SuspendLayout();
            this.recetesiz_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // receteli_grpbox
            // 
            this.receteli_grpbox.Controls.Add(this.radioButton2);
            this.receteli_grpbox.Controls.Add(this.radioButton1);
            this.receteli_grpbox.Controls.Add(this.receteliAdet_txtbox);
            this.receteli_grpbox.Controls.Add(this.receteliAdet_lbl);
            this.receteli_grpbox.Controls.Add(this.receteliAlım_btn);
            this.receteli_grpbox.Controls.Add(this.recete_txtbox);
            this.receteli_grpbox.Controls.Add(this.recete_lbl);
            this.receteli_grpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.receteli_grpbox.Location = new System.Drawing.Point(45, 27);
            this.receteli_grpbox.Name = "receteli_grpbox";
            this.receteli_grpbox.Size = new System.Drawing.Size(419, 282);
            this.receteli_grpbox.TabIndex = 3;
            this.receteli_grpbox.TabStop = false;
            this.receteli_grpbox.Text = "REÇETEYLE İLAÇ ALMA";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(12, 229);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(159, 29);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sigortam yok";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(12, 193);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(155, 29);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Sigortam var";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // receteliAdet_txtbox
            // 
            this.receteliAdet_txtbox.Location = new System.Drawing.Point(143, 147);
            this.receteliAdet_txtbox.Name = "receteliAdet_txtbox";
            this.receteliAdet_txtbox.Size = new System.Drawing.Size(162, 30);
            this.receteliAdet_txtbox.TabIndex = 4;
            // 
            // receteliAdet_lbl
            // 
            this.receteliAdet_lbl.AutoSize = true;
            this.receteliAdet_lbl.ForeColor = System.Drawing.Color.Black;
            this.receteliAdet_lbl.Location = new System.Drawing.Point(7, 147);
            this.receteliAdet_lbl.Name = "receteliAdet_lbl";
            this.receteliAdet_lbl.Size = new System.Drawing.Size(114, 25);
            this.receteliAdet_lbl.TabIndex = 3;
            this.receteliAdet_lbl.Text = "Kaç Adet :";
            // 
            // receteliAlım_btn
            // 
            this.receteliAlım_btn.ForeColor = System.Drawing.Color.Black;
            this.receteliAlım_btn.Location = new System.Drawing.Point(267, 244);
            this.receteliAlım_btn.Name = "receteliAlım_btn";
            this.receteliAlım_btn.Size = new System.Drawing.Size(104, 32);
            this.receteliAlım_btn.TabIndex = 2;
            this.receteliAlım_btn.Text = "İlacı Al";
            this.receteliAlım_btn.UseVisualStyleBackColor = true;
            this.receteliAlım_btn.Click += new System.EventHandler(this.receteliAlım_btn_Click);
            // 
            // recete_txtbox
            // 
            this.recete_txtbox.Location = new System.Drawing.Point(94, 74);
            this.recete_txtbox.Name = "recete_txtbox";
            this.recete_txtbox.Size = new System.Drawing.Size(211, 30);
            this.recete_txtbox.TabIndex = 1;
            // 
            // recete_lbl
            // 
            this.recete_lbl.AutoSize = true;
            this.recete_lbl.ForeColor = System.Drawing.Color.Black;
            this.recete_lbl.Location = new System.Drawing.Point(7, 74);
            this.recete_lbl.Name = "recete_lbl";
            this.recete_lbl.Size = new System.Drawing.Size(92, 25);
            this.recete_lbl.TabIndex = 0;
            this.recete_lbl.Text = "Reçete: ";
            // 
            // recetesiz_grpbox
            // 
            this.recetesiz_grpbox.Controls.Add(this.recetesizAdet_txtbox);
            this.recetesiz_grpbox.Controls.Add(this.recetesizAdet_lbl);
            this.recetesiz_grpbox.Controls.Add(this.recetesizAlım_btn);
            this.recetesiz_grpbox.Controls.Add(this.ilacAd_txtbox);
            this.recetesiz_grpbox.Controls.Add(this.ilacAd_lbl);
            this.recetesiz_grpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recetesiz_grpbox.ForeColor = System.Drawing.Color.Black;
            this.recetesiz_grpbox.Location = new System.Drawing.Point(535, 27);
            this.recetesiz_grpbox.Name = "recetesiz_grpbox";
            this.recetesiz_grpbox.Size = new System.Drawing.Size(342, 282);
            this.recetesiz_grpbox.TabIndex = 4;
            this.recetesiz_grpbox.TabStop = false;
            this.recetesiz_grpbox.Text = "REÇETESİZ İLAÇ ALMA";
            // 
            // recetesizAdet_txtbox
            // 
            this.recetesizAdet_txtbox.Location = new System.Drawing.Point(132, 159);
            this.recetesizAdet_txtbox.Name = "recetesizAdet_txtbox";
            this.recetesizAdet_txtbox.Size = new System.Drawing.Size(205, 30);
            this.recetesizAdet_txtbox.TabIndex = 4;
            // 
            // recetesizAdet_lbl
            // 
            this.recetesizAdet_lbl.AutoSize = true;
            this.recetesizAdet_lbl.Location = new System.Drawing.Point(11, 159);
            this.recetesizAdet_lbl.Name = "recetesizAdet_lbl";
            this.recetesizAdet_lbl.Size = new System.Drawing.Size(114, 25);
            this.recetesizAdet_lbl.TabIndex = 3;
            this.recetesizAdet_lbl.Text = "Kaç Adet :";
            // 
            // recetesizAlım_btn
            // 
            this.recetesizAlım_btn.Location = new System.Drawing.Point(132, 224);
            this.recetesizAlım_btn.Name = "recetesizAlım_btn";
            this.recetesizAlım_btn.Size = new System.Drawing.Size(99, 34);
            this.recetesizAlım_btn.TabIndex = 2;
            this.recetesizAlım_btn.Text = "İlacı Al";
            this.recetesizAlım_btn.UseVisualStyleBackColor = true;
            this.recetesizAlım_btn.Click += new System.EventHandler(this.recetesizAlım_btn_Click);
            // 
            // ilacAd_txtbox
            // 
            this.ilacAd_txtbox.Location = new System.Drawing.Point(109, 74);
            this.ilacAd_txtbox.Name = "ilacAd_txtbox";
            this.ilacAd_txtbox.Size = new System.Drawing.Size(228, 30);
            this.ilacAd_txtbox.TabIndex = 1;
            // 
            // ilacAd_lbl
            // 
            this.ilacAd_lbl.AutoSize = true;
            this.ilacAd_lbl.Location = new System.Drawing.Point(6, 74);
            this.ilacAd_lbl.Name = "ilacAd_lbl";
            this.ilacAd_lbl.Size = new System.Drawing.Size(97, 25);
            this.ilacAd_lbl.TabIndex = 0;
            this.ilacAd_lbl.Text = "İlaç Adı :";
            // 
            // frm_müsteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 492);
            this.Controls.Add(this.recetesiz_grpbox);
            this.Controls.Add(this.receteli_grpbox);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frm_müsteri";
            this.Text = "frm_müsteri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.receteli_grpbox.ResumeLayout(false);
            this.receteli_grpbox.PerformLayout();
            this.recetesiz_grpbox.ResumeLayout(false);
            this.recetesiz_grpbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox receteli_grpbox;
        private System.Windows.Forms.Label recete_lbl;
        private System.Windows.Forms.GroupBox recetesiz_grpbox;
        private System.Windows.Forms.Label ilacAd_lbl;
        private System.Windows.Forms.Button receteliAlım_btn;
        private System.Windows.Forms.TextBox recete_txtbox;
        private System.Windows.Forms.Button recetesizAlım_btn;
        private System.Windows.Forms.TextBox ilacAd_txtbox;
        private System.Windows.Forms.TextBox receteliAdet_txtbox;
        private System.Windows.Forms.Label receteliAdet_lbl;
        private System.Windows.Forms.TextBox recetesizAdet_txtbox;
        private System.Windows.Forms.Label recetesizAdet_lbl;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

