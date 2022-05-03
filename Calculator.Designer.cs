namespace WinFormsApp2
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button C;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.number_1 = new System.Windows.Forms.Button();
            this.number_2 = new System.Windows.Forms.Button();
            this.number_3 = new System.Windows.Forms.Button();
            this.number_4 = new System.Windows.Forms.Button();
            this.number_5 = new System.Windows.Forms.Button();
            this.number_6 = new System.Windows.Forms.Button();
            this.number_7 = new System.Windows.Forms.Button();
            this.number_8 = new System.Windows.Forms.Button();
            this.number_9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.window = new System.Windows.Forms.Label();
            this.DELETE = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.fiend = new System.Windows.Forms.Button();
            this.squere = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.one_on_number = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.proc = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            C = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // C
            // 
            C.BackColor = System.Drawing.SystemColors.ControlLight;
            C.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            C.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            C.ForeColor = System.Drawing.SystemColors.ControlText;
            C.Location = new System.Drawing.Point(221, 191);
            C.Name = "C";
            C.Size = new System.Drawing.Size(100, 68);
            C.TabIndex = 19;
            C.Text = "C";
            C.UseVisualStyleBackColor = false;
            C.Click += new System.EventHandler(this.C_Click);
            // 
            // number_1
            // 
            this.number_1.BackColor = System.Drawing.SystemColors.Control;
            this.number_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number_1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_1.Location = new System.Drawing.Point(10, 339);
            this.number_1.Name = "number_1";
            this.number_1.Size = new System.Drawing.Size(100, 68);
            this.number_1.TabIndex = 0;
            this.number_1.Text = "1";
            this.number_1.UseVisualStyleBackColor = false;
            this.number_1.Click += new System.EventHandler(this.add_number_1);
            // 
            // number_2
            // 
            this.number_2.BackColor = System.Drawing.SystemColors.Control;
            this.number_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number_2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_2.Location = new System.Drawing.Point(115, 339);
            this.number_2.Name = "number_2";
            this.number_2.Size = new System.Drawing.Size(100, 68);
            this.number_2.TabIndex = 1;
            this.number_2.Text = "2";
            this.number_2.UseVisualStyleBackColor = false;
            this.number_2.Click += new System.EventHandler(this.add_number_2);
            // 
            // number_3
            // 
            this.number_3.BackColor = System.Drawing.SystemColors.Control;
            this.number_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number_3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_3.Location = new System.Drawing.Point(222, 339);
            this.number_3.Name = "number_3";
            this.number_3.Size = new System.Drawing.Size(100, 68);
            this.number_3.TabIndex = 2;
            this.number_3.Text = "3";
            this.number_3.UseVisualStyleBackColor = false;
            this.number_3.Click += new System.EventHandler(this.add_number_3);
            // 
            // number_4
            // 
            this.number_4.BackColor = System.Drawing.SystemColors.Control;
            this.number_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number_4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_4.Location = new System.Drawing.Point(9, 413);
            this.number_4.Name = "number_4";
            this.number_4.Size = new System.Drawing.Size(100, 68);
            this.number_4.TabIndex = 3;
            this.number_4.Text = "4";
            this.number_4.UseVisualStyleBackColor = false;
            this.number_4.Click += new System.EventHandler(this.add_number_4);
            // 
            // number_5
            // 
            this.number_5.BackColor = System.Drawing.SystemColors.Control;
            this.number_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number_5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_5.Location = new System.Drawing.Point(115, 413);
            this.number_5.Name = "number_5";
            this.number_5.Size = new System.Drawing.Size(100, 68);
            this.number_5.TabIndex = 4;
            this.number_5.Text = "5";
            this.number_5.UseVisualStyleBackColor = false;
            this.number_5.Click += new System.EventHandler(this.add_number_5);
            // 
            // number_6
            // 
            this.number_6.BackColor = System.Drawing.SystemColors.Control;
            this.number_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number_6.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_6.Location = new System.Drawing.Point(222, 413);
            this.number_6.Name = "number_6";
            this.number_6.Size = new System.Drawing.Size(100, 68);
            this.number_6.TabIndex = 5;
            this.number_6.Text = "6";
            this.number_6.UseVisualStyleBackColor = false;
            this.number_6.Click += new System.EventHandler(this.add_number_6);
            // 
            // number_7
            // 
            this.number_7.BackColor = System.Drawing.SystemColors.Control;
            this.number_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number_7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_7.Location = new System.Drawing.Point(10, 487);
            this.number_7.Name = "number_7";
            this.number_7.Size = new System.Drawing.Size(100, 68);
            this.number_7.TabIndex = 6;
            this.number_7.Text = "7";
            this.number_7.UseVisualStyleBackColor = false;
            this.number_7.Click += new System.EventHandler(this.add_number_7);
            // 
            // number_8
            // 
            this.number_8.BackColor = System.Drawing.SystemColors.Control;
            this.number_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number_8.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_8.Location = new System.Drawing.Point(116, 487);
            this.number_8.Name = "number_8";
            this.number_8.Size = new System.Drawing.Size(100, 68);
            this.number_8.TabIndex = 7;
            this.number_8.Text = "8";
            this.number_8.UseVisualStyleBackColor = false;
            this.number_8.Click += new System.EventHandler(this.add_number_8);
            // 
            // number_9
            // 
            this.number_9.BackColor = System.Drawing.SystemColors.Control;
            this.number_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number_9.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_9.Location = new System.Drawing.Point(222, 487);
            this.number_9.Name = "number_9";
            this.number_9.Size = new System.Drawing.Size(100, 68);
            this.number_9.TabIndex = 8;
            this.number_9.Text = "9";
            this.number_9.UseVisualStyleBackColor = false;
            this.number_9.Click += new System.EventHandler(this.add_number_9);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Control;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(115, 561);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 68);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.add_number_0);
            // 
            // equally
            // 
            this.equally.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.equally.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.equally.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.equally.Location = new System.Drawing.Point(328, 561);
            this.equally.Name = "equally";
            this.equally.Size = new System.Drawing.Size(100, 68);
            this.equally.TabIndex = 10;
            this.equally.Text = "=";
            this.equally.UseVisualStyleBackColor = false;
            this.equally.Click += new System.EventHandler(this.result);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.SystemColors.ControlLight;
            this.X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.X.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X.Location = new System.Drawing.Point(328, 339);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(100, 68);
            this.X.TabIndex = 11;
            this.X.Text = "x";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.minus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minus.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.minus.Location = new System.Drawing.Point(328, 413);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(100, 68);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.plus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plus.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(328, 487);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(100, 68);
            this.plus.TabIndex = 13;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // window
            // 
            this.window.BackColor = System.Drawing.Color.PowderBlue;
            this.window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.window.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.window.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.window.Location = new System.Drawing.Point(9, 78);
            this.window.Name = "window";
            this.window.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.window.Size = new System.Drawing.Size(419, 48);
            this.window.TabIndex = 16;
            this.window.Text = "0";
            this.window.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DELETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DELETE.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DELETE.Location = new System.Drawing.Point(328, 191);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(100, 68);
            this.DELETE.TabIndex = 18;
            this.DELETE.Text = "<--";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.delete_last_number);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(328, 265);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 68);
            this.button11.TabIndex = 20;
            this.button11.Text = "/";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.divison_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.Control;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button12.Location = new System.Drawing.Point(9, 561);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(100, 68);
            this.button12.TabIndex = 21;
            this.button12.Text = "+/-";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.change_sign);
            // 
            // fiend
            // 
            this.fiend.BackColor = System.Drawing.SystemColors.Control;
            this.fiend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fiend.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fiend.Location = new System.Drawing.Point(221, 561);
            this.fiend.Name = "fiend";
            this.fiend.Size = new System.Drawing.Size(100, 68);
            this.fiend.TabIndex = 22;
            this.fiend.Text = ",";
            this.fiend.UseVisualStyleBackColor = false;
            this.fiend.Click += new System.EventHandler(this.add_comma);
            // 
            // squere
            // 
            this.squere.BackColor = System.Drawing.SystemColors.ControlLight;
            this.squere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.squere.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.squere.Location = new System.Drawing.Point(221, 265);
            this.squere.Name = "squere";
            this.squere.Size = new System.Drawing.Size(100, 68);
            this.squere.TabIndex = 23;
            this.squere.Text = "x²";
            this.squere.UseVisualStyleBackColor = false;
            this.squere.Click += new System.EventHandler(this.squere_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sqrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sqrt.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sqrt.Location = new System.Drawing.Point(115, 265);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(100, 68);
            this.sqrt.TabIndex = 24;
            this.sqrt.Text = "√";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // one_on_number
            // 
            this.one_on_number.BackColor = System.Drawing.SystemColors.ControlLight;
            this.one_on_number.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.one_on_number.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.one_on_number.Location = new System.Drawing.Point(9, 265);
            this.one_on_number.Name = "one_on_number";
            this.one_on_number.Size = new System.Drawing.Size(100, 68);
            this.one_on_number.TabIndex = 25;
            this.one_on_number.Text = "1/x";
            this.one_on_number.UseVisualStyleBackColor = false;
            this.one_on_number.Click += new System.EventHandler(this.one_on_number_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CE.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CE.Location = new System.Drawing.Point(116, 191);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(100, 68);
            this.CE.TabIndex = 27;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // proc
            // 
            this.proc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.proc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proc.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.proc.Location = new System.Drawing.Point(9, 191);
            this.proc.Name = "proc";
            this.proc.Size = new System.Drawing.Size(100, 68);
            this.proc.TabIndex = 28;
            this.proc.Text = "%";
            this.proc.UseVisualStyleBackColor = false;
            this.proc.Click += new System.EventHandler(this.proc_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.PowderBlue;
            this.History.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("History.BackgroundImage")));
            this.History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.History.Location = new System.Drawing.Point(403, 0);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(34, 29);
            this.History.TabIndex = 29;
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(437, 637);
            this.Controls.Add(this.History);
            this.Controls.Add(this.proc);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.one_on_number);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.squere);
            this.Controls.Add(this.fiend);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(C);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.window);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.X);
            this.Controls.Add(this.equally);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.number_9);
            this.Controls.Add(this.number_8);
            this.Controls.Add(this.number_7);
            this.Controls.Add(this.number_6);
            this.Controls.Add(this.number_5);
            this.Controls.Add(this.number_4);
            this.Controls.Add(this.number_3);
            this.Controls.Add(this.number_2);
            this.Controls.Add(this.number_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button number_1;
        private Button number_2;
        private Button number_3;
        private Button number_4;
        private Button number_5;
        private Button number_6;
        private Button number_7;
        private Button number_8;
        private Button number_9;
        private Button button10;
        private Button equally;
        private Button X;
        private Button minus;
        private Button plus;
        private Label window;
        private Button DELETE;
        private Button C;
        private Button button11;
        private Button button12;
        private Button fiend;
        private Button squere;
        private Button sqrt;
        private Button one_on_number;
        private Button CE;
        private Button proc;
        private Button History;
    }
}