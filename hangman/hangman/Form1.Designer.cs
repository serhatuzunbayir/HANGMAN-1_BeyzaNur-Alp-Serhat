namespace hangman
{
    partial class Form1
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
            this.lbl_kelime = new System.Windows.Forms.Label();
            this.pcb_adam = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_soylenenler = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_kategori = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_adam)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_kelime
            // 
            this.lbl_kelime.AutoSize = true;
            this.lbl_kelime.Location = new System.Drawing.Point(66, 26);
            this.lbl_kelime.Name = "lbl_kelime";
            this.lbl_kelime.Size = new System.Drawing.Size(0, 13);
            this.lbl_kelime.TabIndex = 0;
            // 
            // pcb_adam
            // 
            this.pcb_adam.BackColor = System.Drawing.Color.White;
            this.pcb_adam.Location = new System.Drawing.Point(485, 16);
            this.pcb_adam.Name = "pcb_adam";
            this.pcb_adam.Size = new System.Drawing.Size(213, 472);
            this.pcb_adam.TabIndex = 1;
            this.pcb_adam.TabStop = false;
            this.pcb_adam.Visible = false;
            this.pcb_adam.Paint += new System.Windows.Forms.PaintEventHandler(this.pcb_adam_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_soylenenler);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lbl_kategori);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pcb_adam);
            this.panel1.Controls.Add(this.lbl_kelime);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 552);
            this.panel1.TabIndex = 2;
            this.panel1.SizeChanged += new System.EventHandler(this.panel1_SizeChanged);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_soylenenler
            // 
            this.lbl_soylenenler.AutoSize = true;
            this.lbl_soylenenler.Location = new System.Drawing.Point(81, 304);
            this.lbl_soylenenler.Name = "lbl_soylenenler";
            this.lbl_soylenenler.Size = new System.Drawing.Size(0, 13);
            this.lbl_soylenenler.TabIndex = 6;
            this.lbl_soylenenler.Visible = false;
            this.lbl_soylenenler.Click += new System.EventHandler(this.lbl_soylenenler_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Seç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 261);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Visible = false;
            // 
            // lbl_kategori
            // 
            this.lbl_kategori.AutoSize = true;
            this.lbl_kategori.Location = new System.Drawing.Point(171, 26);
            this.lbl_kategori.Name = "lbl_kategori";
            this.lbl_kategori.Size = new System.Drawing.Size(46, 13);
            this.lbl_kategori.TabIndex = 3;
            this.lbl_kategori.Text = "Kategori";
            this.lbl_kategori.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Oyuna Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.button2;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 576);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_adam)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_kelime;
        private System.Windows.Forms.PictureBox pcb_adam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_kategori;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_soylenenler;
    }
}

