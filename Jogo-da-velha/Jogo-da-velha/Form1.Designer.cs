namespace Jogo_da_velha
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.a5 = new System.Windows.Forms.Button();
            this.a6 = new System.Windows.Forms.Button();
            this.a7 = new System.Windows.Forms.Button();
            this.a8 = new System.Windows.Forms.Button();
            this.a9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "É só um jogo-da-velha normal";
            // 
            // a1
            // 
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(14, 66);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(72, 66);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.a1_Click);
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(123, 66);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(72, 66);
            this.a2.TabIndex = 2;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.a1_Click);
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(228, 66);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(72, 66);
            this.a3.TabIndex = 3;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.a1_Click);
            // 
            // a4
            // 
            this.a4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a4.Location = new System.Drawing.Point(14, 141);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(72, 66);
            this.a4.TabIndex = 4;
            this.a4.UseVisualStyleBackColor = true;
            this.a4.Click += new System.EventHandler(this.a1_Click);
            // 
            // a5
            // 
            this.a5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a5.Location = new System.Drawing.Point(123, 141);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(72, 66);
            this.a5.TabIndex = 5;
            this.a5.UseVisualStyleBackColor = true;
            this.a5.Click += new System.EventHandler(this.a1_Click);
            // 
            // a6
            // 
            this.a6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a6.Location = new System.Drawing.Point(228, 141);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(72, 66);
            this.a6.TabIndex = 6;
            this.a6.UseVisualStyleBackColor = true;
            this.a6.Click += new System.EventHandler(this.a1_Click);
            // 
            // a7
            // 
            this.a7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a7.Location = new System.Drawing.Point(14, 221);
            this.a7.Name = "a7";
            this.a7.Size = new System.Drawing.Size(72, 66);
            this.a7.TabIndex = 7;
            this.a7.UseVisualStyleBackColor = true;
            this.a7.Click += new System.EventHandler(this.a1_Click);
            // 
            // a8
            // 
            this.a8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a8.Location = new System.Drawing.Point(123, 221);
            this.a8.Name = "a8";
            this.a8.Size = new System.Drawing.Size(72, 66);
            this.a8.TabIndex = 8;
            this.a8.UseVisualStyleBackColor = true;
            this.a8.Click += new System.EventHandler(this.a1_Click);
            // 
            // a9
            // 
            this.a9.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a9.Location = new System.Drawing.Point(228, 221);
            this.a9.Name = "a9";
            this.a9.Size = new System.Drawing.Size(72, 66);
            this.a9.TabIndex = 9;
            this.a9.UseVisualStyleBackColor = true;
            this.a9.Click += new System.EventHandler(this.a1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(248, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 19);
            this.button1.TabIndex = 10;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(301, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 324);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.a9);
            this.Controls.Add(this.a8);
            this.Controls.Add(this.a7);
            this.Controls.Add(this.a6);
            this.Controls.Add(this.a5);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button a5;
        private System.Windows.Forms.Button a6;
        private System.Windows.Forms.Button a7;
        private System.Windows.Forms.Button a8;
        private System.Windows.Forms.Button a9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

    }
}

