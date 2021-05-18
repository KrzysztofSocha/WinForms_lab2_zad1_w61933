
namespace winForms_lab2_zad1_w61933
{
    partial class Form1
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
            this.lWynik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbWoman = new System.Windows.Forms.RadioButton();
            this.rbMan = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.gbWaga = new System.Windows.Forms.GroupBox();
            this.chbStandardowa = new System.Windows.Forms.CheckBox();
            this.chbIdealna = new System.Windows.Forms.CheckBox();
            this.lwynik2 = new System.Windows.Forms.Label();
            this.gbWaga.SuspendLayout();
            this.SuspendLayout();
            // 
            // lWynik
            // 
            this.lWynik.AutoSize = true;
            this.lWynik.Location = new System.Drawing.Point(22, 228);
            this.lWynik.Name = "lWynik";
            this.lWynik.Size = new System.Drawing.Size(49, 20);
            this.lWynik.TabIndex = 0;
            this.lWynik.Text = "Wynik";
            this.lWynik.Click += new System.EventHandler(this.lWynik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj wzrost [cm]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj płeć";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 27);
            this.textBox1.TabIndex = 3;
            // 
            // rbWoman
            // 
            this.rbWoman.AutoSize = true;
            this.rbWoman.Location = new System.Drawing.Point(151, 79);
            this.rbWoman.Name = "rbWoman";
            this.rbWoman.Size = new System.Drawing.Size(82, 24);
            this.rbWoman.TabIndex = 4;
            this.rbWoman.TabStop = true;
            this.rbWoman.Text = "Kobieta";
            this.rbWoman.UseVisualStyleBackColor = true;
            // 
            // rbMan
            // 
            this.rbMan.AutoSize = true;
            this.rbMan.Location = new System.Drawing.Point(250, 79);
            this.rbMan.Name = "rbMan";
            this.rbMan.Size = new System.Drawing.Size(102, 24);
            this.rbMan.TabIndex = 5;
            this.rbMan.TabStop = true;
            this.rbMan.Text = "Mężczyzna";
            this.rbMan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbWaga
            // 
            this.gbWaga.Controls.Add(this.chbIdealna);
            this.gbWaga.Controls.Add(this.chbStandardowa);
            this.gbWaga.Location = new System.Drawing.Point(370, 34);
            this.gbWaga.Name = "gbWaga";
            this.gbWaga.Size = new System.Drawing.Size(185, 114);
            this.gbWaga.TabIndex = 7;
            this.gbWaga.TabStop = false;
            this.gbWaga.Text = "Waga";
            // 
            // chbStandardowa
            // 
            this.chbStandardowa.AutoSize = true;
            this.chbStandardowa.Location = new System.Drawing.Point(17, 27);
            this.chbStandardowa.Name = "chbStandardowa";
            this.chbStandardowa.Size = new System.Drawing.Size(119, 24);
            this.chbStandardowa.TabIndex = 0;
            this.chbStandardowa.Text = "Standardowa";
            this.chbStandardowa.UseVisualStyleBackColor = true;
            this.chbStandardowa.CheckedChanged += new System.EventHandler(this.chbStandardowa_CheckedChanged);
            // 
            // chbIdealna
            // 
            this.chbIdealna.AutoSize = true;
            this.chbIdealna.Location = new System.Drawing.Point(17, 74);
            this.chbIdealna.Name = "chbIdealna";
            this.chbIdealna.Size = new System.Drawing.Size(80, 24);
            this.chbIdealna.TabIndex = 1;
            this.chbIdealna.Text = "Idealna";
            this.chbIdealna.UseVisualStyleBackColor = true;
            // 
            // lwynik2
            // 
            this.lwynik2.AutoSize = true;
            this.lwynik2.Location = new System.Drawing.Point(98, 228);
            this.lwynik2.Name = "lwynik2";
            this.lwynik2.Size = new System.Drawing.Size(0, 20);
            this.lwynik2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 266);
            this.Controls.Add(this.lwynik2);
            this.Controls.Add(this.gbWaga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbMan);
            this.Controls.Add(this.rbWoman);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lWynik);
            this.Name = "Form1";
            this.Text = "w61933";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbWaga.ResumeLayout(false);
            this.gbWaga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWynik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbWoman;
        private System.Windows.Forms.RadioButton rbMan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbWaga;
        private System.Windows.Forms.CheckBox chbIdealna;
        private System.Windows.Forms.CheckBox chbStandardowa;
        private System.Windows.Forms.Label lwynik2;
    }
}

