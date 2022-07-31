namespace Calculator1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Mul = new System.Windows.Forms.Button();
            this.Sub = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Cube = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Shonar Bangla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Shonar Bangla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Shonar Bangla", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 52);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result =";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(308, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 43);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(308, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 43);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(211, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 42);
            this.label4.TabIndex = 5;
            this.label4.Text = "Simple Calculator";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add.Location = new System.Drawing.Point(12, 239);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(94, 37);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Divide.Location = new System.Drawing.Point(445, 239);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(94, 37);
            this.Divide.TabIndex = 7;
            this.Divide.Text = "Divide";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Mul
            // 
            this.Mul.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mul.Location = new System.Drawing.Point(296, 239);
            this.Mul.Name = "Mul";
            this.Mul.Size = new System.Drawing.Size(127, 37);
            this.Mul.TabIndex = 8;
            this.Mul.Text = "Multiply";
            this.Mul.UseVisualStyleBackColor = true;
            this.Mul.Click += new System.EventHandler(this.Mul_Click);
            // 
            // Sub
            // 
            this.Sub.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sub.Location = new System.Drawing.Point(131, 239);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(144, 37);
            this.Sub.TabIndex = 9;
            this.Sub.Text = "Substract";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.Click += new System.EventHandler(this.Sub_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(180, 328);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 43);
            this.textBox3.TabIndex = 10;
            // 
            // Cube
            // 
            this.Cube.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cube.Location = new System.Drawing.Point(693, 239);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(94, 37);
            this.Cube.TabIndex = 11;
            this.Cube.Text = "Cube";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.Cube_Click);
            // 
            // Square
            // 
            this.Square.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Square.Location = new System.Drawing.Point(564, 239);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(110, 37);
            this.Square.TabIndex = 12;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(697, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "****For Square and Cube Enter the First Number only*****";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Shonar Bangla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(487, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 39);
            this.label6.TabIndex = 14;
            this.label6.Text = "Enter Breadth:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Shonar Bangla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(45, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 39);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter Length:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(664, 399);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(243, 43);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(211, 399);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(243, 43);
            this.textBox5.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Shonar Bangla", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 523);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 52);
            this.label8.TabIndex = 18;
            this.label8.Text = "Result =";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(180, 523);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(243, 43);
            this.textBox6.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(308, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Area";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(487, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 37);
            this.button2.TabIndex = 21;
            this.button2.Text = "Diagonal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Shonar Bangla", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(131, 464);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 37);
            this.button3.TabIndex = 22;
            this.button3.Text = "Perimeter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1165, 741);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button Add;
        private Button Divide;
        private Button Mul;
        private Button Sub;
        private TextBox textBox3;
        private Button Cube;
        private Button Square;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}