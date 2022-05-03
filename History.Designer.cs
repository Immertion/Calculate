namespace WinFormsApp2
{
    partial class History
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
            this.window = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // window
            // 
            this.window.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.window.AutoEllipsis = true;
            this.window.AutoSize = true;
            this.window.BackColor = System.Drawing.Color.PowderBlue;
            this.window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.window.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.window.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.window.Location = new System.Drawing.Point(17, 9);
            this.window.Name = "window";
            this.window.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.window.Size = new System.Drawing.Size(0, 37);
            this.window.TabIndex = 17;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(486, 578);
            this.Controls.Add(this.window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label window;
    }
}