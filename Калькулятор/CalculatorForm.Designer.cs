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
            this.SuspendLayout();

            this.firstOperandTextBox.Font = new Font("Segoe UI", 16F);
            this.firstOperandTextBox.Location = new Point(45, 50);
            this.firstOperandTextBox.Name = "firstOperandTextBox";
            this.firstOperandTextBox.Size = new Size(125, 36);
            this.firstOperandTextBox.TabIndex = 0;

            this.operationTextBox.Font = new Font("Segoe UI", 16F);
            this.operationTextBox.Location = new Point(210, 50);
            this.operationTextBox.Name = "operationTextBox";
            this.operationTextBox.Size = new Size(115, 36);
            this.operationTextBox.TabIndex = 1;

            this.secondOperandTextBox.Font = new Font("Segoe UI", 16F);
            this.secondOperandTextBox.Location = new Point(365, 50);
            this.secondOperandTextBox.Name = "secondOperandTextBox";
            this.secondOperandTextBox.Size = new Size(115, 36);
            this.secondOperandTextBox.TabIndex = 2;

            this.calculateButton.Font = new Font("Segoe UI", 16F);
            this.calculateButton.Location = new Point(45, 105);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new Size(435, 42);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "=";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);

            this.resultTextBox.Font = new Font("Segoe UI", 16F);
            this.resultTextBox.Location = new Point(45, 175);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new Size(435, 36);
            this.resultTextBox.TabIndex = 4;

            this.ClientSize = new Size(525, 245);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.secondOperandTextBox);
            this.Controls.Add(this.operationTextBox);
            this.Controls.Add(this.firstOperandTextBox);
            this.Name = "CalculatorForm";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
