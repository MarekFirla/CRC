
namespace CRC
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ZpravaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rBox = new System.Windows.Forms.TextBox();
            this.EncodeButton = new System.Windows.Forms.Button();
            this.DecodeButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PrijataZpravaBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GenPolynomBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.KodovanaZpravaVypis = new System.Windows.Forms.ListBox();
            this.Console = new System.Windows.Forms.TextBox();
            this.ZpravaOdeslanyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Odeslat = new System.Windows.Forms.Button();
            this.OdeslanyPolynomtextBox = new System.Windows.Forms.TextBox();
            this.PrenosChybny = new System.Windows.Forms.TextBox();
            this.OdeslanaZpravaPol = new System.Windows.Forms.TextBox();
            this.ChybaPozice = new System.Windows.Forms.TextBox();
            this.OprZpravaBin = new System.Windows.Forms.TextBox();
            this.OprZpravaPol = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zpráva";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ZpravaBox
            // 
            this.ZpravaBox.Location = new System.Drawing.Point(39, 49);
            this.ZpravaBox.Margin = new System.Windows.Forms.Padding(4);
            this.ZpravaBox.Name = "ZpravaBox";
            this.ZpravaBox.Size = new System.Drawing.Size(132, 22);
            this.ZpravaBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Počet zabezpečujících znaků";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(39, 103);
            this.rBox.Margin = new System.Windows.Forms.Padding(4);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(132, 22);
            this.rBox.TabIndex = 4;
            // 
            // EncodeButton
            // 
            this.EncodeButton.Location = new System.Drawing.Point(59, 135);
            this.EncodeButton.Margin = new System.Windows.Forms.Padding(4);
            this.EncodeButton.Name = "EncodeButton";
            this.EncodeButton.Size = new System.Drawing.Size(100, 28);
            this.EncodeButton.TabIndex = 6;
            this.EncodeButton.Text = "Encode";
            this.EncodeButton.UseVisualStyleBackColor = true;
            this.EncodeButton.Click += new System.EventHandler(this.EncodeButton_Click);
            // 
            // DecodeButton
            // 
            this.DecodeButton.Location = new System.Drawing.Point(57, 331);
            this.DecodeButton.Margin = new System.Windows.Forms.Padding(4);
            this.DecodeButton.Name = "DecodeButton";
            this.DecodeButton.Size = new System.Drawing.Size(100, 28);
            this.DecodeButton.TabIndex = 13;
            this.DecodeButton.Text = "Decode";
            this.DecodeButton.UseVisualStyleBackColor = true;
            this.DecodeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Generující polynom";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PrijataZpravaBox
            // 
            this.PrijataZpravaBox.Location = new System.Drawing.Point(39, 245);
            this.PrijataZpravaBox.Margin = new System.Windows.Forms.Padding(4);
            this.PrijataZpravaBox.Name = "PrijataZpravaBox";
            this.PrijataZpravaBox.Size = new System.Drawing.Size(132, 22);
            this.PrijataZpravaBox.TabIndex = 8;
            this.PrijataZpravaBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Přijatá zpráva";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // GenPolynomBox
            // 
            this.GenPolynomBox.Location = new System.Drawing.Point(39, 299);
            this.GenPolynomBox.Margin = new System.Windows.Forms.Padding(4);
            this.GenPolynomBox.Name = "GenPolynomBox";
            this.GenPolynomBox.Size = new System.Drawing.Size(132, 22);
            this.GenPolynomBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Encoder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Decoder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Syndrom chyby";
            // 
            // KodovanaZpravaVypis
            // 
            this.KodovanaZpravaVypis.FormattingEnabled = true;
            this.KodovanaZpravaVypis.ItemHeight = 16;
            this.KodovanaZpravaVypis.Location = new System.Drawing.Point(444, 49);
            this.KodovanaZpravaVypis.Margin = new System.Windows.Forms.Padding(4);
            this.KodovanaZpravaVypis.Name = "KodovanaZpravaVypis";
            this.KodovanaZpravaVypis.Size = new System.Drawing.Size(297, 52);
            this.KodovanaZpravaVypis.TabIndex = 19;
            // 
            // Console
            // 
            this.Console.Location = new System.Drawing.Point(17, 379);
            this.Console.Margin = new System.Windows.Forms.Padding(4);
            this.Console.Name = "Console";
            this.Console.Size = new System.Drawing.Size(721, 22);
            this.Console.TabIndex = 20;
            // 
            // ZpravaOdeslanyTextBox
            // 
            this.ZpravaOdeslanyTextBox.Location = new System.Drawing.Point(441, 155);
            this.ZpravaOdeslanyTextBox.Name = "ZpravaOdeslanyTextBox";
            this.ZpravaOdeslanyTextBox.Size = new System.Drawing.Size(298, 22);
            this.ZpravaOdeslanyTextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Gen. Polynom";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Odeslaná Zpráva";
            // 
            // Odeslat
            // 
            this.Odeslat.Location = new System.Drawing.Point(444, 108);
            this.Odeslat.Name = "Odeslat";
            this.Odeslat.Size = new System.Drawing.Size(75, 23);
            this.Odeslat.TabIndex = 24;
            this.Odeslat.Text = "Odeslat";
            this.Odeslat.UseVisualStyleBackColor = true;
            this.Odeslat.Click += new System.EventHandler(this.button1_Click);
            // 
            // OdeslanyPolynomtextBox
            // 
            this.OdeslanyPolynomtextBox.Location = new System.Drawing.Point(441, 183);
            this.OdeslanyPolynomtextBox.Name = "OdeslanyPolynomtextBox";
            this.OdeslanyPolynomtextBox.Size = new System.Drawing.Size(298, 22);
            this.OdeslanyPolynomtextBox.TabIndex = 25;
            // 
            // PrenosChybny
            // 
            this.PrenosChybny.Location = new System.Drawing.Point(441, 229);
            this.PrenosChybny.Name = "PrenosChybny";
            this.PrenosChybny.Size = new System.Drawing.Size(297, 22);
            this.PrenosChybny.TabIndex = 26;
            // 
            // OdeslanaZpravaPol
            // 
            this.OdeslanaZpravaPol.Location = new System.Drawing.Point(441, 257);
            this.OdeslanaZpravaPol.Name = "OdeslanaZpravaPol";
            this.OdeslanaZpravaPol.Size = new System.Drawing.Size(297, 22);
            this.OdeslanaZpravaPol.TabIndex = 27;
            // 
            // ChybaPozice
            // 
            this.ChybaPozice.Location = new System.Drawing.Point(441, 285);
            this.ChybaPozice.Name = "ChybaPozice";
            this.ChybaPozice.Size = new System.Drawing.Size(297, 22);
            this.ChybaPozice.TabIndex = 28;
            this.ChybaPozice.TextChanged += new System.EventHandler(this.ChybaPozice_TextChanged);
            // 
            // OprZpravaBin
            // 
            this.OprZpravaBin.Location = new System.Drawing.Point(441, 313);
            this.OprZpravaBin.Name = "OprZpravaBin";
            this.OprZpravaBin.Size = new System.Drawing.Size(297, 22);
            this.OprZpravaBin.TabIndex = 29;
            // 
            // OprZpravaPol
            // 
            this.OprZpravaPol.Location = new System.Drawing.Point(441, 341);
            this.OprZpravaPol.Name = "OprZpravaPol";
            this.OprZpravaPol.Size = new System.Drawing.Size(297, 22);
            this.OprZpravaPol.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Přenos proběhl:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "Zpráva ve formě polynomu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Chyba se nachází na:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(313, 318);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Opravená zpráva:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(189, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(246, 17);
            this.label14.TabIndex = 35;
            this.label14.Text = "Opravená zpráva ve formě polynomu:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(191, 188);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(244, 17);
            this.label16.TabIndex = 37;
            this.label16.Text = "Odeslaná zpráva ve formě polynomu:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(313, 160);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "Odeslaná zpráva:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 418);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OprZpravaPol);
            this.Controls.Add(this.OprZpravaBin);
            this.Controls.Add(this.ChybaPozice);
            this.Controls.Add(this.OdeslanaZpravaPol);
            this.Controls.Add(this.PrenosChybny);
            this.Controls.Add(this.OdeslanyPolynomtextBox);
            this.Controls.Add(this.Odeslat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZpravaOdeslanyTextBox);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.KodovanaZpravaVypis);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GenPolynomBox);
            this.Controls.Add(this.DecodeButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrijataZpravaBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EncodeButton);
            this.Controls.Add(this.rBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ZpravaBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Cyklický kód";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ZpravaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rBox;
        private System.Windows.Forms.Button EncodeButton;
        private System.Windows.Forms.Button DecodeButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PrijataZpravaBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GenPolynomBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox KodovanaZpravaVypis;
        private System.Windows.Forms.TextBox Console;
        private System.Windows.Forms.TextBox ZpravaOdeslanyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Odeslat;
        private System.Windows.Forms.TextBox OdeslanyPolynomtextBox;
        private System.Windows.Forms.TextBox PrenosChybny;
        private System.Windows.Forms.TextBox OdeslanaZpravaPol;
        private System.Windows.Forms.TextBox ChybaPozice;
        private System.Windows.Forms.TextBox OprZpravaBin;
        private System.Windows.Forms.TextBox OprZpravaPol;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
    }
}

