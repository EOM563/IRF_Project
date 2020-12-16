namespace IRF_Projekt_UF27ER
{
    partial class MainForm
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
            this.buttonFormNelkul = new System.Windows.Forms.Button();
            this.buttonFormazott = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFormNelkul
            // 
            this.buttonFormNelkul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormNelkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFormNelkul.Location = new System.Drawing.Point(875, 12);
            this.buttonFormNelkul.Name = "buttonFormNelkul";
            this.buttonFormNelkul.Size = new System.Drawing.Size(175, 65);
            this.buttonFormNelkul.TabIndex = 0;
            this.buttonFormNelkul.Text = "Excel megjeleneítése\r\nformázás nélkül";
            this.buttonFormNelkul.UseVisualStyleBackColor = true;
            this.buttonFormNelkul.Click += new System.EventHandler(this.buttonFormNelkul_Click);
            // 
            // buttonFormazott
            // 
            this.buttonFormazott.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormazott.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonFormazott.Location = new System.Drawing.Point(875, 88);
            this.buttonFormazott.Name = "buttonFormazott";
            this.buttonFormazott.Size = new System.Drawing.Size(175, 65);
            this.buttonFormazott.TabIndex = 0;
            this.buttonFormazott.Text = "Excel megjeleneítése\r\nformázással\r\n";
            this.buttonFormazott.UseVisualStyleBackColor = true;
            this.buttonFormazott.Click += new System.EventHandler(this.buttonFormazott_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExit.Location = new System.Drawing.Point(875, 404);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 45);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(886, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "A gombokra kattintva válassza \r\nki a kiírni kívánt elemeket.\r\n\r\nKategória gombra " +
    "kattintva az \r\nösszes odatartozó elemet kijelöli.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(872, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Használat:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1062, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFormazott);
            this.Controls.Add(this.buttonFormNelkul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Árukészlet listázás";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFormNelkul;
        private System.Windows.Forms.Button buttonFormazott;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

