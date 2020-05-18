namespace RandomPractice1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_p1 = new System.Windows.Forms.Button();
            this.btn_rdm_occur = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_15 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(312, 385);
            this.textBox1.TabIndex = 0;
            // 
            // btn_p1
            // 
            this.btn_p1.Location = new System.Drawing.Point(0, 19);
            this.btn_p1.Name = "btn_p1";
            this.btn_p1.Size = new System.Drawing.Size(290, 56);
            this.btn_p1.TabIndex = 1;
            this.btn_p1.Text = "Play";
            this.btn_p1.UseVisualStyleBackColor = true;
            this.btn_p1.Click += new System.EventHandler(this.btn_p1_Click);
            // 
            // btn_rdm_occur
            // 
            this.btn_rdm_occur.Location = new System.Drawing.Point(443, 160);
            this.btn_rdm_occur.Name = "btn_rdm_occur";
            this.btn_rdm_occur.Size = new System.Drawing.Size(290, 56);
            this.btn_rdm_occur.TabIndex = 2;
            this.btn_rdm_occur.Text = "Occurances of the number of 47 in Random 1-100 ";
            this.btn_rdm_occur.UseVisualStyleBackColor = true;
            this.btn_rdm_occur.Click += new System.EventHandler(this.btn_rdm_occur_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(9, 37);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(275, 56);
            this.btn_8.TabIndex = 3;
            this.btn_8.Text = "$8 Game";
            this.btn_8.UseVisualStyleBackColor = true;
            // 
            // btn_15
            // 
            this.btn_15.Location = new System.Drawing.Point(9, 99);
            this.btn_15.Name = "btn_15";
            this.btn_15.Size = new System.Drawing.Size(275, 56);
            this.btn_15.TabIndex = 4;
            this.btn_15.Text = "$15 Game";
            this.btn_15.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_8);
            this.groupBox1.Controls.Add(this.btn_15);
            this.groupBox1.Location = new System.Drawing.Point(443, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 166);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gambling Game";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_p1);
            this.groupBox2.Location = new System.Drawing.Point(443, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 90);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Random Number Battle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_rdm_occur);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_p1;
        private System.Windows.Forms.Button btn_rdm_occur;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

