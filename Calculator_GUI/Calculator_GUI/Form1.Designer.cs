namespace Calculator_GUI
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            plus = new Button();
            minus = new Button();
            mal = new Button();
            durch = new Button();
            outputfield = new Label();
            gleich = new Button();
            clear = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 101);
            button1.Name = "button1";
            button1.Size = new Size(50, 50);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(70, 101);
            button2.Name = "button2";
            button2.Size = new Size(50, 50);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(126, 101);
            button3.Name = "button3";
            button3.Size = new Size(50, 50);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(14, 157);
            button4.Name = "button4";
            button4.Size = new Size(50, 50);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(70, 157);
            button5.Name = "button5";
            button5.Size = new Size(50, 50);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(126, 157);
            button6.Name = "button6";
            button6.Size = new Size(50, 50);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(14, 213);
            button7.Name = "button7";
            button7.Size = new Size(50, 50);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(70, 213);
            button8.Name = "button8";
            button8.Size = new Size(50, 50);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(126, 213);
            button9.Name = "button9";
            button9.Size = new Size(50, 50);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button0
            // 
            button0.Location = new Point(70, 269);
            button0.Name = "button0";
            button0.Size = new Size(50, 50);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // plus
            // 
            plus.BackColor = SystemColors.ActiveCaption;
            plus.Location = new Point(182, 101);
            plus.Name = "plus";
            plus.Size = new Size(50, 50);
            plus.TabIndex = 10;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = false;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.BackColor = SystemColors.ActiveCaption;
            minus.Location = new Point(182, 157);
            minus.Name = "minus";
            minus.Size = new Size(50, 50);
            minus.TabIndex = 11;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = false;
            minus.Click += minus_Click;
            // 
            // mal
            // 
            mal.BackColor = SystemColors.ActiveCaption;
            mal.Location = new Point(182, 213);
            mal.Name = "mal";
            mal.Size = new Size(50, 50);
            mal.TabIndex = 12;
            mal.Text = "*";
            mal.UseVisualStyleBackColor = false;
            mal.Click += mal_Click;
            // 
            // durch
            // 
            durch.BackColor = SystemColors.ActiveCaption;
            durch.Location = new Point(182, 270);
            durch.Name = "durch";
            durch.Size = new Size(50, 50);
            durch.TabIndex = 13;
            durch.Text = "/";
            durch.UseVisualStyleBackColor = false;
            durch.Click += durch_Click;
            // 
            // outputfield
            // 
            outputfield.AutoSize = true;
            outputfield.BackColor = Color.Transparent;
            outputfield.Font = new Font("Segoe UI", 20F);
            outputfield.Location = new Point(26, 24);
            outputfield.Name = "outputfield";
            outputfield.Size = new Size(0, 54);
            outputfield.TabIndex = 15;
            // 
            // gleich
            // 
            gleich.BackColor = SystemColors.ActiveCaption;
            gleich.Location = new Point(182, 326);
            gleich.Name = "gleich";
            gleich.Size = new Size(50, 50);
            gleich.TabIndex = 17;
            gleich.Text = "=";
            gleich.UseVisualStyleBackColor = false;
            gleich.Click += gleich_Click;
            // 
            // clear
            // 
            clear.BackColor = SystemColors.ActiveBorder;
            clear.Location = new Point(12, 326);
            clear.Name = "clear";
            clear.Size = new Size(50, 50);
            clear.TabIndex = 18;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 382);
            Controls.Add(clear);
            Controls.Add(gleich);
            Controls.Add(outputfield);
            Controls.Add(durch);
            Controls.Add(mal);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button plus;
        private Button minus;
        private Button mal;
        private Button durch;
        private Label outputfield;
        private Button gleich;
        private Button clear;
    }
}
