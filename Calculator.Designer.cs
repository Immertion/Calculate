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
            this.number_0 = new System.Windows.Forms.Button();
            this.equally = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Label();
            this.DELETE = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.squere = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.one_on_number = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.percent = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Button();
            this.last_calculate = new System.Windows.Forms.Label();
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
            // number_0
            // 
            this.number_0.BackColor = System.Drawing.SystemColors.Control;
            this.number_0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.number_0.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.number_0.Location = new System.Drawing.Point(115, 561);
            this.number_0.Name = "number_0";
            this.number_0.Size = new System.Drawing.Size(100, 68);
            this.number_0.TabIndex = 9;
            this.number_0.Text = "0";
            this.number_0.UseVisualStyleBackColor = false;
            this.number_0.Click += new System.EventHandler(this.add_number_0);
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
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.PowderBlue;
            this.calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculate.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.calculate.Location = new System.Drawing.Point(6, 40);
            this.calculate.Name = "calculate";
            this.calculate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.calculate.Size = new System.Drawing.Size(419, 48);
            this.calculate.TabIndex = 16;
            this.calculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.ControlLight;
            this.division.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.division.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.division.Location = new System.Drawing.Point(328, 265);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(100, 68);
            this.division.TabIndex = 20;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = false;
            this.division.Click += new System.EventHandler(this.divison_Click);
            // 
            // sign
            // 
            this.sign.BackColor = System.Drawing.SystemColors.Control;
            this.sign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sign.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sign.Location = new System.Drawing.Point(9, 561);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(100, 68);
            this.sign.TabIndex = 21;
            this.sign.Text = "+/-";
            this.sign.UseVisualStyleBackColor = false;
            this.sign.Click += new System.EventHandler(this.change_sign);
            // 
            // comma
            // 
            this.comma.BackColor = System.Drawing.SystemColors.Control;
            this.comma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.comma.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comma.Location = new System.Drawing.Point(221, 561);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(100, 68);
            this.comma.TabIndex = 22;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = false;
            this.comma.Click += new System.EventHandler(this.add_comma);
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
            // percent
            // 
            this.percent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.percent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.percent.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.percent.Location = new System.Drawing.Point(9, 191);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(100, 68);
            this.percent.TabIndex = 28;
            this.percent.Text = "%";
            this.percent.UseVisualStyleBackColor = false;
            this.percent.Click += new System.EventHandler(this.proc_Click);
            // 
            // History
            // 
            this.History.BackColor = System.Drawing.Color.PowderBlue;
            this.History.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("History.BackgroundImage")));
            this.History.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.History.Location = new System.Drawing.Point(403, 0);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(34, 37);
            this.History.TabIndex = 29;
            this.History.UseVisualStyleBackColor = false;
            this.History.Click += new System.EventHandler(this.History_Click);
            // 
            // last_calculate
            // 
            this.last_calculate.BackColor = System.Drawing.Color.PowderBlue;
            this.last_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.last_calculate.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.last_calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.last_calculate.Location = new System.Drawing.Point(9, 79);
            this.last_calculate.Name = "last_calculate";
            this.last_calculate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.last_calculate.Size = new System.Drawing.Size(419, 48);
            this.last_calculate.TabIndex = 30;
            this.last_calculate.Text = "0";
            this.last_calculate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(437, 637);
            this.Controls.Add(this.last_calculate);
            this.Controls.Add(this.History);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.one_on_number);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.squere);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.division);
            this.Controls.Add(C);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.X);
            this.Controls.Add(this.equally);
            this.Controls.Add(this.number_0);
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
        private Button number_0;
        private Button equally;
        private Button X;
        private Button minus;
        private Button plus;
        private Label calculate;
        private Button DELETE;
        private Button C;
        private Button division;
        private Button sign;
        private Button comma;
        private Button squere;
        private Button sqrt;
        private Button one_on_number;
        private Button CE;
        private Button percent;
        private Button History;
        private Label last_calculate;
    }
}