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
            this.SuspendLayout();
            // 
            // buttonFormNelkul
            // 
            this.buttonFormNelkul.Location = new System.Drawing.Point(875, 8);
            this.buttonFormNelkul.Name = "buttonFormNelkul";
            this.buttonFormNelkul.Size = new System.Drawing.Size(175, 45);
            this.buttonFormNelkul.TabIndex = 0;
            this.buttonFormNelkul.Text = "Kiírás formázás nélkül";
            this.buttonFormNelkul.UseVisualStyleBackColor = true;
            // 
            // buttonFormazott
            // 
            this.buttonFormazott.Location = new System.Drawing.Point(875, 63);
            this.buttonFormazott.Name = "buttonFormazott";
            this.buttonFormazott.Size = new System.Drawing.Size(175, 45);
            this.buttonFormazott.TabIndex = 0;
            this.buttonFormazott.Text = "Kiírás formázással";
            this.buttonFormazott.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(875, 561);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 45);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 618);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFormazott);
            this.Controls.Add(this.buttonFormNelkul);
            this.Name = "MainForm";
            this.Text = "Árukészlet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFormNelkul;
        private System.Windows.Forms.Button buttonFormazott;
        private System.Windows.Forms.Button buttonExit;
    }
}

