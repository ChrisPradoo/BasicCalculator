namespace BasicCalculator
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
            Operand1Label = new Label();
            label1 = new Label();
            Operand1TextBox = new TextBox();
            OperatorLabel = new Label();
            Operand2Label = new Label();
            Operand2TextBox = new TextBox();
            Result = new Label();
            ResultTextBox = new TextBox();
            CalculateButton = new Button();
            ExitButton = new Button();
            OperatorTextBox = new TextBox();
            SuspendLayout();
            // 
            // Operand1Label
            // 
            Operand1Label.AutoSize = true;
            Operand1Label.Location = new Point(32, 42);
            Operand1Label.Name = "Operand1Label";
            Operand1Label.Size = new Size(65, 15);
            Operand1Label.TabIndex = 0;
            Operand1Label.Text = "Operand 1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 88);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 1;
            // 
            // Operand1TextBox
            // 
            Operand1TextBox.Location = new Point(116, 42);
            Operand1TextBox.Name = "Operand1TextBox";
            Operand1TextBox.Size = new Size(100, 23);
            Operand1TextBox.TabIndex = 3;
            // 
            // OperatorLabel
            // 
            OperatorLabel.AutoSize = true;
            OperatorLabel.Location = new Point(32, 96);
            OperatorLabel.Name = "OperatorLabel";
            OperatorLabel.Size = new Size(57, 15);
            OperatorLabel.TabIndex = 4;
            OperatorLabel.Text = "Operator:";
            // 
            // Operand2Label
            // 
            Operand2Label.AutoSize = true;
            Operand2Label.Location = new Point(32, 148);
            Operand2Label.Name = "Operand2Label";
            Operand2Label.Size = new Size(65, 15);
            Operand2Label.TabIndex = 5;
            Operand2Label.Text = "Operand 2:";
            // 
            // Operand2TextBox
            // 
            Operand2TextBox.Location = new Point(113, 148);
            Operand2TextBox.Name = "Operand2TextBox";
            Operand2TextBox.Size = new Size(100, 23);
            Operand2TextBox.TabIndex = 6;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(32, 194);
            Result.Name = "Result";
            Result.Size = new Size(42, 15);
            Result.TabIndex = 7;
            Result.Text = "Result:";
            // 
            // ResultTextBox
            // 
            ResultTextBox.Location = new Point(113, 194);
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new Size(100, 23);
            ResultTextBox.TabIndex = 8;
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(32, 234);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(108, 39);
            CalculateButton.TabIndex = 9;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(146, 234);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(108, 39);
            ExitButton.TabIndex = 10;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // OperatorTextBox
            // 
            OperatorTextBox.Location = new Point(113, 96);
            OperatorTextBox.Name = "OperatorTextBox";
            OperatorTextBox.Size = new Size(100, 23);
            OperatorTextBox.TabIndex = 11;
            // 
            // SimpleCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 298);
            Controls.Add(OperatorTextBox);
            Controls.Add(ExitButton);
            Controls.Add(CalculateButton);
            Controls.Add(ResultTextBox);
            Controls.Add(Result);
            Controls.Add(Operand2TextBox);
            Controls.Add(Operand2Label);
            Controls.Add(OperatorLabel);
            Controls.Add(Operand1TextBox);
            Controls.Add(label1);
            Controls.Add(Operand1Label);
            Name = "SimpleCalculator";
            Text = "Simple Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Operand1Label;
        private Label label1;
        private TextBox Operand1TextBox;
        private Label OperatorLabel;
        private Label Operand2Label;
        private TextBox Operand2TextBox;
        private Label Result;
        private TextBox ResultTextBox;
        private Button CalculateButton;
        private Button ExitButton;
        private TextBox OperatorTextBox;
    }
}
