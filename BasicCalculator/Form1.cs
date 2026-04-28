namespace BasicCalculator;

public partial class SimpleCalculator : Form
{
    public SimpleCalculator()
    {
        InitializeComponent();
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        {
            // collect the operands and operator
            // (two numbers beind used to do math with, and what type)
            string operand1 = Operand1TextBox.Text;
            string operand2 = Operand2TextBox.Text;
            string operatorSymbol = OperatorTextBox.Text;


            // validate
            if (string.IsNullOrWhiteSpace(operand1) ||
                string.IsNullOrWhiteSpace(operand2) ||
                string.IsNullOrWhiteSpace(operatorSymbol))
            {
                MessageBox.Show("All of the boxes need to be filled in.");
                return;
            }



            // converting to doubles
            double operand1Convert = Convert.ToDouble(operand1);
            double operand2Convert = Convert.ToDouble(operand2);


            // show results
        }
    }
}
