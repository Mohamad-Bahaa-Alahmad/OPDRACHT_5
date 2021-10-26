namespace Oefening3
{
    partial class Form2
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
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.Alph = new System.Windows.Forms.NumericUpDown();
            this.Red = new System.Windows.Forms.NumericUpDown();
            this.Green = new System.Windows.Forms.NumericUpDown();
            this.Blue = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Alph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(56, 50);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(42, 16);
            this.l1.TabIndex = 0;
            this.l1.Text = "Alpha";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(56, 96);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(41, 16);
            this.l2.TabIndex = 1;
            this.l2.Text = "Rood";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(56, 145);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(44, 16);
            this.l3.TabIndex = 2;
            this.l3.Text = "Groen";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(56, 193);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(43, 16);
            this.l4.TabIndex = 3;
            this.l4.Text = "Blauw";
            // 
            // Alph
            // 
            this.Alph.Location = new System.Drawing.Point(145, 50);
            this.Alph.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Alph.Name = "Alph";
            this.Alph.Size = new System.Drawing.Size(120, 22);
            this.Alph.TabIndex = 4;
            this.Alph.ValueChanged += new System.EventHandler(this.Alph_ValueChanged);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(145, 89);
            this.Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(120, 22);
            this.Red.TabIndex = 5;
            this.Red.ValueChanged += new System.EventHandler(this.Red_ValueChanged);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(145, 138);
            this.Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(120, 22);
            this.Green.TabIndex = 6;
            this.Green.ValueChanged += new System.EventHandler(this.Green_ValueChanged);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(145, 186);
            this.Blue.Maximum = new decimal(new int[] {
            155,
            0,
            0,
            0});
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(120, 22);
            this.Blue.TabIndex = 7;
            this.Blue.ValueChanged += new System.EventHandler(this.Blue_ValueChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 295);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Alph);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Alph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l4;
        private System.Windows.Forms.NumericUpDown Alph;
        private System.Windows.Forms.NumericUpDown Red;
        private System.Windows.Forms.NumericUpDown Green;
        private System.Windows.Forms.NumericUpDown Blue;
    }
}