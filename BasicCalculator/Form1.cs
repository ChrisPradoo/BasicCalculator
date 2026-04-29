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

            // validate presence, checks if the textboxes are empty,
            // then we pass in the current operand
            if (!IsPresent(operand1, "Operand 1"))
            {
                // return to make sure the program does not keep going
                return;
            }
            if (!IsPresent(operand2, "Operand 2"))
            {
                return;
            }
            if (!IsPresent(operatorSymbol, "Operator"))
            {
                return;
            }

            // if its not one the correct operators it'll display an error message
            if (!IsOperator(operatorSymbol))
            {
                MessageBox.Show("Operator must be +, -, *, /");
            }

            // validate by trying to convert to a decimal, pass in the operand and the current one
            if (!IsDecimal(operand1, "Operand 1"))
            {
                return;
            }
            if (!IsDecimal(operand2, "Operand 2"))
            {
                return;
            }

            // converting to decimals
            decimal operand1Convert = Convert.ToDecimal(operand1);
            decimal operand2Convert = Convert.ToDecimal(operand2);

            // checking the range
            if (!IsValidData(operand1Convert, operand2Convert))
            {
                return;
            }

            // calculate
            decimal result = Calculate(operand1Convert, operatorSymbol, operand2Convert);

            // rounding the result to 4 decimal places
            decimal rounedResult= Math.Round(result, 4);

            // show the results
            ResultTextBox.Text = rounedResult.ToString();
            
        }
    }


    // validation methods

    /// <summary>
    /// Calculates two numbers based on the operator described.
    /// </summary>
    /// <param name="operand1"></param>
    /// <param name="operatorSymbol"></param>
    /// <param name="operand2"></param>
    /// <returns></returns>
    private decimal Calculate(decimal operand1, string operatorSymbol, decimal operand2)
    {
        // results variable
        decimal result = 0;

        // checking if it matches the symbol and doing the correct math then returning
        if (operatorSymbol == "+" || operatorSymbol == "add")
        {
            return result = operand1 + operand2;
        }
        else if (operatorSymbol == "-" || operatorSymbol == "subtract")
        {
           return result = operand1 - operand2;
        }
        else if (operatorSymbol == "*" || operatorSymbol == "multiply")
        {
           return result = operand1 * operand2;
        }
        else if (operatorSymbol == "/" || operatorSymbol == "divide")
        {
           return result = operand1 / operand2;
        }

        return 0;
    }

    /// <summary>
    /// Checks for text in textbox.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    private bool IsPresent(string text, string name)
    {
        // basically if there is no text then give an error message
        if (string.IsNullOrWhiteSpace(text))
        {
            MessageBox.Show($"{name} is required");
            return false;
        }
        return true;
    }

    /// <summary>
    /// Trys to convert text into a decimal, if fails gives an error message.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="name"></param>
    /// <returns></returns>
    private bool IsDecimal(string text, string name)
    {
        decimal number;

        // trys to convert the text into a decimal
        // if it fails it gives an error message
        if (!decimal.TryParse(text, out number))
        {
            MessageBox.Show($"{name} must be a number.");
            return false;
        }

        return true;
    }

    /// <summary>
    /// Determines what math to do based on the math operator.
    /// </summary>
    /// <param name="Operator"></param>
    /// <returns></returns>
    private bool IsOperator(string Operator)
    {
        // turning into lower case
        string operatorLower = Operator.ToLower();

        // if of these symbols are the case it returns it
        return operatorLower == "+" ||
               operatorLower == "-" ||
               operatorLower == "*" ||
               operatorLower == "/" ||
               operatorLower == "add" ||
               operatorLower == "subtract" ||
               operatorLower == "multiply" ||
               operatorLower == "divide";
    }

    /// <summary>
    /// Checks to see if the values is whithin a certain range (0-100000)
    /// </summary>
    /// <param name="operand1"></param>
    /// <param name="operand2"></param>
    /// <returns></returns>
    private bool IsValidData(decimal operand1, decimal operand2)
    {
        if (operand1 < 0 || operand1 > 1000000)
        {
            MessageBox.Show("Operand 1 must be between the correct range");
            return false;
        }
        if (operand2 < 0 || operand2 > 1000000)
        {
            MessageBox.Show("Operand 2 must be between the correct range");
            return false;
        }

        return true;
    }

    // just exits the program when a button is clicked
    private void ExitButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}
