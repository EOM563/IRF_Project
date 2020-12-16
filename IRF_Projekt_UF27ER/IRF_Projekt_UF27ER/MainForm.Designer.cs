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
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFormNelkul
            // 
            this.buttonFormNelkul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormNelkul.Location = new System.Drawing.Point(875, 8);
            this.buttonFormNelkul.Name = "buttonFormNelkul";
            this.buttonFormNelkul.Size = new System.Drawing.Size(175, 45);
            this.buttonFormNelkul.TabIndex = 0;
            this.buttonFormNelkul.Text = "Excel megjeleneítése\r\nformázás nélkül";
            this.buttonFormNelkul.UseVisualStyleBackColor = true;
            this.buttonFormNelkul.Click += new System.EventHandler(this.buttonFormNelkul_Click);
            // 
            // buttonFormazott
            // 
            this.buttonFormazott.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFormazott.Location = new System.Drawing.Point(875, 63);
            this.buttonFormazott.Name = "buttonFormazott";
            this.buttonFormazott.Size = new System.Drawing.Size(175, 45);
            this.buttonFormazott.TabIndex = 0;
            this.buttonFormazott.Text = "Excel megjeleneítése\r\nformázással\r\n";
            this.buttonFormazott.UseVisualStyleBackColor = true;
            this.buttonFormazott.Click += new System.EventHandler(this.buttonFormazott_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(875, 404);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 45);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Kilépés";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(875, 114);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 45);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Formázott excel mentése";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1062, 461);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonFormazott);
            this.Controls.Add(this.buttonFormNelkul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Árukészlet";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFormNelkul;
        private System.Windows.Forms.Button buttonFormazott;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button saveButton;
    }
}

