
namespace programmingproject2
{
    partial class Calculator
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
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.secondNumber = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.operationChooser = new System.Windows.Forms.ListBox();
            this.calculate = new System.Windows.Forms.Button();
            this.Answer = new System.Windows.Forms.Label();
            this.clearText = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxItalcized = new System.Windows.Forms.CheckBox();
            this.checkBoxBold = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultOutput = new System.Windows.Forms.Label();
            this.checkBoxUnderline = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNumberLabel.Location = new System.Drawing.Point(12, 50);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(313, 38);
            this.firstNumberLabel.TabIndex = 0;
            this.firstNumberLabel.Text = "Enter the First Number: ";
            // 
            // secondNumber
            // 
            this.secondNumber.AutoSize = true;
            this.secondNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondNumber.Location = new System.Drawing.Point(12, 131);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(352, 38);
            this.secondNumber.TabIndex = 1;
            this.secondNumber.Text = "Enter the Second Number: ";
            this.secondNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(331, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 31);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(370, 139);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 31);
            this.textBox2.TabIndex = 3;
            // 
            // operationChooser
            // 
            this.operationChooser.FormattingEnabled = true;
            this.operationChooser.ItemHeight = 25;
            this.operationChooser.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Division"});
            this.operationChooser.Location = new System.Drawing.Point(45, 234);
            this.operationChooser.Name = "operationChooser";
            this.operationChooser.Size = new System.Drawing.Size(352, 229);
            this.operationChooser.TabIndex = 4;
            this.operationChooser.SelectedIndexChanged += new System.EventHandler(this.operationChooser_SelectedIndexChanged);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(36, 505);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(289, 67);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Answer
            // 
            this.Answer.AutoSize = true;
            this.Answer.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Answer.Location = new System.Drawing.Point(12, 597);
            this.Answer.Name = "Answer";
            this.Answer.Size = new System.Drawing.Size(122, 38);
            this.Answer.TabIndex = 6;
            this.Answer.Text = "Answer: ";
            this.Answer.Click += new System.EventHandler(this.Answer_Click);
            // 
            // clearText
            // 
            this.clearText.Location = new System.Drawing.Point(504, 587);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(289, 60);
            this.clearText.TabIndex = 9;
            this.clearText.Text = "Clear Text";
            this.clearText.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(443, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 145);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please select the Unit";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 86);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 29);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inches";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 40);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 29);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Centimeters";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(631, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 621);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxUnderline);
            this.groupBox2.Controls.Add(this.checkBoxItalcized);
            this.groupBox2.Controls.Add(this.checkBoxBold);
            this.groupBox2.Location = new System.Drawing.Point(443, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 201);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Please Select the Formating of the Answer:";
            // 
            // checkBoxItalcized
            // 
            this.checkBoxItalcized.AutoSize = true;
            this.checkBoxItalcized.Location = new System.Drawing.Point(6, 109);
            this.checkBoxItalcized.Name = "checkBoxItalcized";
            this.checkBoxItalcized.Size = new System.Drawing.Size(106, 29);
            this.checkBoxItalcized.TabIndex = 1;
            this.checkBoxItalcized.Text = "Italicized";
            this.checkBoxItalcized.UseVisualStyleBackColor = true;
            // 
            // checkBoxBold
            // 
            this.checkBoxBold.AutoSize = true;
            this.checkBoxBold.Location = new System.Drawing.Point(6, 63);
            this.checkBoxBold.Name = "checkBoxBold";
            this.checkBoxBold.Size = new System.Drawing.Size(74, 29);
            this.checkBoxBold.TabIndex = 0;
            this.checkBoxBold.Text = "Bold";
            this.checkBoxBold.UseVisualStyleBackColor = true;
            this.checkBoxBold.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Select Your Operation:";
            // 
            // resultOutput
            // 
            this.resultOutput.AutoSize = true;
            this.resultOutput.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultOutput.Location = new System.Drawing.Point(140, 610);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.Size = new System.Drawing.Size(91, 38);
            this.resultOutput.TabIndex = 16;
            this.resultOutput.Text = "label5";
            // 
            // checkBoxUnderline
            // 
            this.checkBoxUnderline.AutoSize = true;
            this.checkBoxUnderline.Location = new System.Drawing.Point(6, 156);
            this.checkBoxUnderline.Name = "checkBoxUnderline";
            this.checkBoxUnderline.Size = new System.Drawing.Size(113, 29);
            this.checkBoxUnderline.TabIndex = 2;
            this.checkBoxUnderline.Text = "Underline";
            this.checkBoxUnderline.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 684);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clearText);
            this.Controls.Add(this.Answer);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.operationChooser);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.firstNumberLabel);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label secondNumber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox operationChooser;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label Answer;
        private System.Windows.Forms.Button clearText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxBold;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxItalcized;
        private System.Windows.Forms.Label resultOutput;
        private System.Windows.Forms.CheckBox checkBoxUnderline;
    }
}

