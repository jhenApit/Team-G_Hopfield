namespace Hopfield
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
            this.ni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.I00 = new System.Windows.Forms.Button();
            this.I01 = new System.Windows.Forms.Button();
            this.I02 = new System.Windows.Forms.Button();
            this.I03 = new System.Windows.Forms.Button();
            this.I04 = new System.Windows.Forms.Button();
            this.I05 = new System.Windows.Forms.Button();
            this.I06 = new System.Windows.Forms.Button();
            this.I07 = new System.Windows.Forms.Button();
            this.I08 = new System.Windows.Forms.Button();
            this.O08 = new System.Windows.Forms.Button();
            this.O07 = new System.Windows.Forms.Button();
            this.O06 = new System.Windows.Forms.Button();
            this.O05 = new System.Windows.Forms.Button();
            this.O04 = new System.Windows.Forms.Button();
            this.O03 = new System.Windows.Forms.Button();
            this.O02 = new System.Windows.Forms.Button();
            this.O01 = new System.Windows.Forms.Button();
            this.O00 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ni
            // 
            this.ni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ni.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ni.Location = new System.Drawing.Point(200, 413);
            this.ni.Name = "ni";
            this.ni.Size = new System.Drawing.Size(573, 47);
            this.ni.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(213, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 66;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(563, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Output";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(49, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Neuron Inputs";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(103, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 70;
            this.label4.Text = "Output";
            // 
            // o
            // 
            this.o.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.o.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.o.Location = new System.Drawing.Point(200, 468);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(573, 47);
            this.o.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(85, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 72;
            this.label6.Text = "Threshold";
            // 
            // t
            // 
            this.t.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.t.Location = new System.Drawing.Point(200, 523);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(573, 47);
            this.t.TabIndex = 71;
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calculate.Location = new System.Drawing.Point(549, 611);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(133, 51);
            this.Calculate.TabIndex = 73;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear.Location = new System.Drawing.Point(688, 611);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(133, 51);
            this.Clear.TabIndex = 74;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // I00
            // 
            this.I00.BackColor = System.Drawing.Color.WhiteSmoke;
            this.I00.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.I00.Location = new System.Drawing.Point(108, 99);
            this.I00.Name = "I00";
            this.I00.Size = new System.Drawing.Size(86, 76);
            this.I00.TabIndex = 75;
            this.I00.UseVisualStyleBackColor = false;
            this.I00.Click += new System.EventHandler(this.I00_Click);
            // 
            // I01
            // 
            this.I01.BackColor = System.Drawing.Color.WhiteSmoke;
            this.I01.Location = new System.Drawing.Point(200, 99);
            this.I01.Name = "I01";
            this.I01.Size = new System.Drawing.Size(86, 76);
            this.I01.TabIndex = 76;
            this.I01.UseVisualStyleBackColor = false;
            this.I01.Click += new System.EventHandler(this.I01_Click);
            // 
            // I02
            // 
            this.I02.BackColor = System.Drawing.Color.WhiteSmoke;
            this.I02.Location = new System.Drawing.Point(292, 99);
            this.I02.Name = "I02";
            this.I02.Size = new System.Drawing.Size(86, 76);
            this.I02.TabIndex = 77;
            this.I02.UseVisualStyleBackColor = false;
            this.I02.Click += new System.EventHandler(this.I02_Click);
            // 
            // I03
            // 
            this.I03.BackColor = System.Drawing.Color.WhiteSmoke;
            this.I03.Location = new System.Drawing.Point(108, 183);
            this.I03.Name = "I03";
            this.I03.Size = new System.Drawing.Size(86, 76);
            this.I03.TabIndex = 78;
            this.I03.UseVisualStyleBackColor = false;
            this.I03.Click += new System.EventHandler(this.I03_Click);
            // 
            // I04
            // 
            this.I04.BackColor = System.Drawing.Color.WhiteSmoke;
            this.I04.Location = new System.Drawing.Point(200, 183);
            this.I04.Name = "I04";
            this.I04.Size = new System.Drawing.Size(86, 76);
            this.I04.TabIndex = 79;
            this.I04.UseVisualStyleBackColor = false;
            this.I04.Click += new System.EventHandler(this.I04_Click);
            // 
            // I05
            // 
            this.I05.BackColor = System.Drawing.Color.WhiteSmoke;
            this.I05.Location = new System.Drawing.Point(292, 183);
            this.I05.Name = "I05";
            this.I05.Size = new System.Drawing.Size(86, 76);
            this.I05.TabIndex = 80;
            this.I05.UseVisualStyleBackColor = false;
            this.I05.Click += new System.EventHandler(this.I05_Click);
            // 
            // I06
            // 
            this.I06.BackColor = System.Drawing.Color.WhiteSmoke;
            this.I06.Location = new System.Drawing.Point(108, 267);
            this.I06.Name = "I06";
            this.I06.Size = new System.Drawing.Size(86, 76);
            this.I06.TabIndex = 81;
            this.I06.UseVisualStyleBackColor = false;
            this.I06.Click += new System.EventHandler(this.I06_Click);
            // 
            // I07
            // 
            this.I07.BackColor = System.Drawing.Color.WhiteSmoke;
            this.I07.Location = new System.Drawing.Point(200, 267);
            this.I07.Name = "I07";
            this.I07.Size = new System.Drawing.Size(86, 76);
            this.I07.TabIndex = 82;
            this.I07.UseVisualStyleBackColor = false;
            this.I07.Click += new System.EventHandler(this.I07_Click);
            // 
            // I08
            // 
            this.I08.BackColor = System.Drawing.Color.WhiteSmoke;
            this.I08.Location = new System.Drawing.Point(292, 267);
            this.I08.Name = "I08";
            this.I08.Size = new System.Drawing.Size(86, 76);
            this.I08.TabIndex = 83;
            this.I08.UseVisualStyleBackColor = false;
            this.I08.Click += new System.EventHandler(this.I08_Click);
            // 
            // O08
            // 
            this.O08.BackColor = System.Drawing.Color.WhiteSmoke;
            this.O08.Location = new System.Drawing.Point(655, 267);
            this.O08.Name = "O08";
            this.O08.Size = new System.Drawing.Size(86, 76);
            this.O08.TabIndex = 92;
            this.O08.UseVisualStyleBackColor = false;
            // 
            // O07
            // 
            this.O07.BackColor = System.Drawing.Color.WhiteSmoke;
            this.O07.Location = new System.Drawing.Point(563, 265);
            this.O07.Name = "O07";
            this.O07.Size = new System.Drawing.Size(86, 76);
            this.O07.TabIndex = 91;
            this.O07.UseVisualStyleBackColor = false;
            // 
            // O06
            // 
            this.O06.BackColor = System.Drawing.Color.WhiteSmoke;
            this.O06.Location = new System.Drawing.Point(471, 267);
            this.O06.Name = "O06";
            this.O06.Size = new System.Drawing.Size(86, 76);
            this.O06.TabIndex = 90;
            this.O06.UseVisualStyleBackColor = false;
            // 
            // O05
            // 
            this.O05.BackColor = System.Drawing.Color.WhiteSmoke;
            this.O05.Location = new System.Drawing.Point(655, 183);
            this.O05.Name = "O05";
            this.O05.Size = new System.Drawing.Size(86, 76);
            this.O05.TabIndex = 89;
            this.O05.UseVisualStyleBackColor = false;
            // 
            // O04
            // 
            this.O04.BackColor = System.Drawing.Color.WhiteSmoke;
            this.O04.Location = new System.Drawing.Point(563, 183);
            this.O04.Name = "O04";
            this.O04.Size = new System.Drawing.Size(86, 76);
            this.O04.TabIndex = 88;
            this.O04.UseVisualStyleBackColor = false;
            // 
            // O03
            // 
            this.O03.BackColor = System.Drawing.Color.WhiteSmoke;
            this.O03.Location = new System.Drawing.Point(471, 183);
            this.O03.Name = "O03";
            this.O03.Size = new System.Drawing.Size(86, 76);
            this.O03.TabIndex = 87;
            this.O03.UseVisualStyleBackColor = false;
            // 
            // O02
            // 
            this.O02.BackColor = System.Drawing.Color.WhiteSmoke;
            this.O02.Location = new System.Drawing.Point(655, 99);
            this.O02.Name = "O02";
            this.O02.Size = new System.Drawing.Size(86, 76);
            this.O02.TabIndex = 86;
            this.O02.UseVisualStyleBackColor = false;
            // 
            // O01
            // 
            this.O01.BackColor = System.Drawing.Color.WhiteSmoke;
            this.O01.Location = new System.Drawing.Point(563, 99);
            this.O01.Name = "O01";
            this.O01.Size = new System.Drawing.Size(86, 76);
            this.O01.TabIndex = 85;
            this.O01.UseVisualStyleBackColor = false;
            // 
            // O00
            // 
            this.O00.BackColor = System.Drawing.Color.WhiteSmoke;
            this.O00.Location = new System.Drawing.Point(471, 99);
            this.O00.Name = "O00";
            this.O00.Size = new System.Drawing.Size(86, 76);
            this.O00.TabIndex = 84;
            this.O00.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(855, 700);
            this.Controls.Add(this.O08);
            this.Controls.Add(this.O07);
            this.Controls.Add(this.O06);
            this.Controls.Add(this.O05);
            this.Controls.Add(this.O04);
            this.Controls.Add(this.O03);
            this.Controls.Add(this.O02);
            this.Controls.Add(this.O01);
            this.Controls.Add(this.O00);
            this.Controls.Add(this.I08);
            this.Controls.Add(this.I07);
            this.Controls.Add(this.I06);
            this.Controls.Add(this.I05);
            this.Controls.Add(this.I04);
            this.Controls.Add(this.I03);
            this.Controls.Add(this.I02);
            this.Controls.Add(this.I01);
            this.Controls.Add(this.I00);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.o);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ni);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Team G Hopfield Activity";
            this.TransparencyKey = System.Drawing.Color.Navy;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label ni;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label o;
        private Label label6;
        private Label t;
        private Button Calculate;
        private Button Clear;
        private Button I01;
        private Button I00;
        private Button I02;
        private Button I03;
        private Button I04;
        private Button I05;
        private Button I06;
        private Button I07;
        private Button I08;
        private Button O08;
        private Button O07;
        private Button O06;
        private Button O05;
        private Button O04;
        private Button O03;
        private Button O02;
        private Button O01;
        private Button O00;
    }
}