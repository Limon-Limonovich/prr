using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox firstOperandTextBox;
        private TextBox operationTextBox;
        private TextBox secondOperandTextBox;
        private Button calculateButton;
        private TextBox resultTextBox;
        private Label hintLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.firstOperandTextBox = new TextBox();
            this.operationTextBox = new TextBox();
            this.secondOperandTextBox = new TextBox();
            this.calculateButton = new Button();
            this.resultTextBox = new TextBox();
            this.hintLabel = new Label();
            this.SuspendLayout();

            // firstOperandTextBox
            this.firstOperandTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.firstOperandTextBox.Location = new Point(45, 50);
            this.firstOperandTextBox.Name = "firstOperandTextBox";
            this.firstOperandTextBox.Size = new Size(125, 36);
            this.firstOperandTextBox.TabIndex = 0;

            // operationTextBox
            this.operationTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.operationTextBox.Location = new Point(210, 50);
            this.operationTextBox.Name = "operationTextBox";
            this.operationTextBox.Size = new Size(115, 36);
            this.operationTextBox.TabIndex = 1;

            // secondOperandTextBox
            this.secondOperandTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.secondOperandTextBox.Location = new Point(365, 50);
            this.secondOperandTextBox.Name = "secondOperandTextBox";
            this.secondOperandTextBox.Size = new Size(115, 36);
            this.secondOperandTextBox.TabIndex = 2;

            // calculateButton
            this.calculateButton.BackColor = Color.FromArgb(225, 225, 225);
            this.calculateButton.FlatStyle = FlatStyle.Flat;
            this.calculateButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.calculateButton.Location = new Point(45, 105);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new Size(435, 42);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "=";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            // resultTextBox
            this.resultTextBox.BackColor = Color.White;
            this.resultTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            this.resultTextBox.Location = new Point(45, 175);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new Size(435, 36);
            this.resultTextBox.TabIndex = 4;

            // hintLabel
            this.hintLabel.AutoSize = true;
            this.hintLabel.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            this.hintLabel.ForeColor = Color.White;
            this.hintLabel.Location = new Point(45, 222);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new Size(435, 17);
            this.hintLabel.Text = "Операции: +  -  *  /  ! (факториал)  avg или ср (среднее цифр)";

            // CalculatorForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(106, 159, 168);
            this.ClientSize = new Size(525, 255);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.secondOperandTextBox);
            this.Controls.Add(this.operationTextBox);
            this.Controls.Add(this.firstOperandTextBox);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CalculatorForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
