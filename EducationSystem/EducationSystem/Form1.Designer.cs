namespace EducationSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Completion = new System.Windows.Forms.TextBox();
            this.Reading = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Participation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Assesment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Completion :";
            // 
            // Completion
            // 
            this.Completion.Location = new System.Drawing.Point(83, 33);
            this.Completion.Name = "Completion";
            this.Completion.Size = new System.Drawing.Size(37, 20);
            this.Completion.TabIndex = 1;
            this.Completion.Text = "0";
            // 
            // Reading
            // 
            this.Reading.Location = new System.Drawing.Point(83, 59);
            this.Reading.Name = "Reading";
            this.Reading.Size = new System.Drawing.Size(37, 20);
            this.Reading.TabIndex = 3;
            this.Reading.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reading :";
            // 
            // Participation
            // 
            this.Participation.Location = new System.Drawing.Point(83, 85);
            this.Participation.Name = "Participation";
            this.Participation.Size = new System.Drawing.Size(37, 20);
            this.Participation.TabIndex = 5;
            this.Participation.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Participation :";
            // 
            // Assesment
            // 
            this.Assesment.Location = new System.Drawing.Point(83, 111);
            this.Assesment.Name = "Assesment";
            this.Assesment.Size = new System.Drawing.Size(37, 20);
            this.Assesment.TabIndex = 7;
            this.Assesment.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Assesment :";
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(62, 137);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(58, 20);
            this.Output.TabIndex = 9;
            this.Output.Text = "Retake";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Output :";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(14, 172);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(61, 23);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(81, 172);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(53, 23);
            this.Cancel.TabIndex = 11;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "[0;100]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(151, 124);
            this.textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(297, 33);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(47, 124);
            this.textBox2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 33);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(56, 124);
            this.textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(412, 33);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(53, 124);
            this.textBox4.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Input values";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(294, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Desired";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(356, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Result";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(409, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "| D - R |";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 207);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Assesment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Participation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Reading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Completion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mark Evaluation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Completion;
        private System.Windows.Forms.TextBox Reading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Participation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Assesment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

