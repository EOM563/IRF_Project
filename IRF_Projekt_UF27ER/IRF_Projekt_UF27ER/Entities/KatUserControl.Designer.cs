namespace IRF_Projekt_UF27ER.Entities
{
    partial class KatUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alKatButton1 = new IRF_Projekt_UF27ER.Entities.AlKatButton();
            this.katButton1 = new IRF_Projekt_UF27ER.Entities.KatButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // alKatButton1
            // 
            this.alKatButton1.AlKat = null;
            this.alKatButton1.AlKatActive = false;
            this.alKatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(239)))), ((int)(((byte)(139)))));
            this.alKatButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.alKatButton1.FlatAppearance.BorderSize = 2;
            this.alKatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alKatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.alKatButton1.HatterSzin = "126,239,139";
            this.alKatButton1.Location = new System.Drawing.Point(140, 3);
            this.alKatButton1.Name = "alKatButton1";
            this.alKatButton1.Size = new System.Drawing.Size(175, 35);
            this.alKatButton1.TabIndex = 11;
            this.alKatButton1.Text = "alKatButton1";
            this.alKatButton1.UseVisualStyleBackColor = true;
            // 
            // katButton1
            // 
            this.katButton1.BackColor = System.Drawing.SystemColors.Control;
            this.katButton1.BetuSzin = "0,46,115";
            this.katButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.katButton1.FlatAppearance.BorderSize = 2;
            this.katButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.katButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.katButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(133)))), ((int)(((byte)(50)))));
            this.katButton1.Kat = null;
            this.katButton1.katActive = false;
            this.katButton1.Location = new System.Drawing.Point(3, 3);
            this.katButton1.Name = "katButton1";
            this.katButton1.Size = new System.Drawing.Size(130, 100);
            this.katButton1.TabIndex = 10;
            this.katButton1.Text = "katButton1";
            this.katButton1.UseVisualStyleBackColor = false;
            // 
            // KatUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.alKatButton1);
            this.Controls.Add(this.katButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KatUserControl";
            this.Size = new System.Drawing.Size(857, 105);
            this.Load += new System.EventHandler(this.KatUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private KatButton katButton1;
        private AlKatButton alKatButton1;
    }
}
