
namespace Final_project
{
    partial class SimpleCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleCalculator));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_dot = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.buttonsub = new System.Windows.Forms.Button();
            this.buttondev = new System.Windows.Forms.Button();
            this.buttonmultiply = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_equ = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.Take_button = new System.Windows.Forms.Button();
            this.negative_checkBox = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_dot);
            this.groupBox1.Controls.Add(this.buttonadd);
            this.groupBox1.Controls.Add(this.buttonsub);
            this.groupBox1.Controls.Add(this.buttondev);
            this.groupBox1.Controls.Add(this.buttonmultiply);
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.button0);
            this.groupBox1.Controls.Add(this.button_equ);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(227, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 275);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // button_dot
            // 
            this.button_dot.Location = new System.Drawing.Point(212, 22);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(45, 45);
            this.button_dot.TabIndex = 16;
            this.button_dot.Text = ",";
            this.button_dot.UseVisualStyleBackColor = true;
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(159, 22);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(45, 45);
            this.buttonadd.TabIndex = 15;
            this.buttonadd.Text = "+";
            this.buttonadd.UseVisualStyleBackColor = true;
            // 
            // buttonsub
            // 
            this.buttonsub.Location = new System.Drawing.Point(159, 85);
            this.buttonsub.Name = "buttonsub";
            this.buttonsub.Size = new System.Drawing.Size(45, 45);
            this.buttonsub.TabIndex = 14;
            this.buttonsub.Text = "-";
            this.buttonsub.UseVisualStyleBackColor = true;
            // 
            // buttondev
            // 
            this.buttondev.Location = new System.Drawing.Point(159, 147);
            this.buttondev.Name = "buttondev";
            this.buttondev.Size = new System.Drawing.Size(45, 45);
            this.buttondev.TabIndex = 13;
            this.buttondev.Text = "/";
            this.buttondev.UseVisualStyleBackColor = true;
            // 
            // buttonmultiply
            // 
            this.buttonmultiply.Location = new System.Drawing.Point(159, 210);
            this.buttonmultiply.Name = "buttonmultiply";
            this.buttonmultiply.Size = new System.Drawing.Size(45, 45);
            this.buttonmultiply.TabIndex = 12;
            this.buttonmultiply.Text = "*";
            this.buttonmultiply.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(108, 210);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(45, 45);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(57, 210);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(45, 45);
            this.button0.TabIndex = 10;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // button_equ
            // 
            this.button_equ.Location = new System.Drawing.Point(6, 210);
            this.button_equ.Name = "button_equ";
            this.button_equ.Size = new System.Drawing.Size(45, 45);
            this.button_equ.TabIndex = 9;
            this.button_equ.Text = "=";
            this.button_equ.UseVisualStyleBackColor = true;
            this.button_equ.Click += new System.EventHandler(this.button_equ_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(108, 147);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 45);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(57, 147);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 147);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 45);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(57, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 45);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 2;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(227, 59);
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Size = new System.Drawing.Size(219, 23);
            this.Result.TabIndex = 3;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // Take_button
            // 
            this.Take_button.Location = new System.Drawing.Point(12, 30);
            this.Take_button.Name = "Take_button";
            this.Take_button.Size = new System.Drawing.Size(121, 23);
            this.Take_button.TabIndex = 4;
            this.Take_button.Text = "Apply";
            this.Take_button.UseVisualStyleBackColor = true;
            this.Take_button.Click += new System.EventHandler(this.button10_Click);
            // 
            // negative_checkBox
            // 
            this.negative_checkBox.AutoSize = true;
            this.negative_checkBox.Location = new System.Drawing.Point(227, 103);
            this.negative_checkBox.Name = "negative_checkBox";
            this.negative_checkBox.Size = new System.Drawing.Size(44, 19);
            this.negative_checkBox.TabIndex = 18;
            this.negative_checkBox.Text = "+/-";
            this.negative_checkBox.UseVisualStyleBackColor = true;
            this.negative_checkBox.CheckedChanged += new System.EventHandler(this.negative_checkBox_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 267);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(193, 136);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.negative_checkBox);
            this.Controls.Add(this.Take_button);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "SimpleCalculator";
            this.Text = "Simple Calculator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Button buttonsub;
        private System.Windows.Forms.Button buttondev;
        private System.Windows.Forms.Button buttonmultiply;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_equ;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button Take_button;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.CheckBox negative_checkBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

