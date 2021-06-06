
namespace Hotel
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
            this.printButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addToArrayButton = new System.Windows.Forms.Button();
            this.spaces = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(51, 381);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(168, 46);
            this.printButton.TabIndex = 0;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(42, 52);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(41, 13);
            this.lable1.TabIndex = 2;
            this.lable1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество мест";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество проживающих";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Наличие телевизора";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Наличие холодильника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Стоимость места";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(173, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "1";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // addToArrayButton
            // 
            this.addToArrayButton.Location = new System.Drawing.Point(51, 312);
            this.addToArrayButton.Name = "addToArrayButton";
            this.addToArrayButton.Size = new System.Drawing.Size(168, 46);
            this.addToArrayButton.TabIndex = 11;
            this.addToArrayButton.Text = "Add to list";
            this.addToArrayButton.UseVisualStyleBackColor = true;
            this.addToArrayButton.Click += new System.EventHandler(this.addToArrayButton_Click);
            // 
            // spaces
            // 
            this.spaces.AutoSize = true;
            this.spaces.Location = new System.Drawing.Point(225, 92);
            this.spaces.Name = "spaces";
            this.spaces.Size = new System.Drawing.Size(13, 13);
            this.spaces.TabIndex = 12;
            this.spaces.Text = "0";
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(225, 260);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(13, 13);
            this.sum.TabIndex = 13;
            this.sum.Text = "0";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(173, 217);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(173, 178);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 46);
            this.button1.TabIndex = 16;
            this.button1.Text = "Profit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.spaces);
            this.Controls.Add(this.addToArrayButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.printButton);
            this.Name = "Form1";
            this.Text = "t";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addToArrayButton;
        private System.Windows.Forms.Label spaces;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
    }
}

