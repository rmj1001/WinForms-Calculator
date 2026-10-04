using System.ComponentModel;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Calculator Calc { get; init; } = new Calculator();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Detects if number in text box is 0
        /// </summary>
        /// <returns>bool</returns>
        private bool IsZero()
        {
            return numberBox.Text == "0";
        }

        /// <summary>
        /// Print the running total to the text box
        /// </summary>
        private void ShowTotal()
        {
            numberBox.Text = this.Calc.Total();
        }

        /// <summary>
        /// Append a chosen number to the text box
        /// </summary>
        /// <param name="number"></param>
        private void AddNumber(int number)
        {
            if (IsZero())
            {
                numberBox.Text = number.ToString();
            }
            else
            {
                numberBox.AppendText(number.ToString());
            }
        }

        /// <summary>
        /// Update the running total with the number in the text box and chosen operation.
        /// Returns true if successful, false if not.
        /// </summary>
        /// <param name="op"></param>
        /// <returns>bool</returns>
        private bool AddOperation(Math op)
        {
            try
            {
                this.Calc.Update(numberBox.Text, op);
                numberBox.Text = "0";

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        /// <summary>
        /// Clear calculator memory and show 0 in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ce_Click(object sender, EventArgs e)
        {
            this.Calc.Clear();
            this.ShowTotal();
        }

        /// <summary>
        /// Reset text box number to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void c_Click(object sender, EventArgs e)
        {
            numberBox.Text = "0";
        }

        /// <summary>
        /// Remove the last char in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_Click(object sender, EventArgs e)
        {
            string oldText = numberBox.Text;

            if (oldText.Length == 1)
            {
                numberBox.Text = "0";
                return;
            }

            string newText = numberBox.Text.Substring(0, numberBox.Text.Length - 1);

            numberBox.Text = newText;
        }

        /// <summary>
        /// Add/remove minus sign from beginning of number in text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void posNeg_Click(object sender, EventArgs e)
        {
            string number = numberBox.Text;

            if (IsZero())
            {
                return;
            }

            if (number.Contains('-'))
            {
                number = number.Substring(1, number.Length - 1);
            }
            else
            {
                number = "-" + number;
            }

            numberBox.Text = number;
        }

        /// <summary>
        /// Add a decimal to the end of the text box string if one is not present
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDecimal_Click(object sender, EventArgs e)
        {
            string number = numberBox.Text;

            if (!number.Contains('.'))
            {
                number += ".";

                numberBox.Text = number;
            }
        }

        /// <summary>
        /// Append a 0 to the end of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zero_Click(object sender, EventArgs e)
        {
            this.AddNumber(0);
        }

        /// <summary>
        /// Append a 1 to the end of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void one_Click(object sender, EventArgs e)
        {
            this.AddNumber(1);
        }

        /// <summary>
        /// Append a 2 to the end of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void two_Click(object sender, EventArgs e)
        {
            this.AddNumber(2);
        }

        /// <summary>
        /// Append a 3 to the end of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void three_Click(object sender, EventArgs e)
        {
            this.AddNumber(3);
        }

        /// <summary>
        /// Append a 4 to the end of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void four_Click(object sender, EventArgs e)
        {
            this.AddNumber(4);
        }

        /// <summary>
        /// Append a 5 to the end of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void five_Click(object sender, EventArgs e)
        {
            this.AddNumber(5);
        }

        /// <summary>
        /// Append a 6 to the end of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void six_Click(object sender, EventArgs e)
        {
            this.AddNumber(6);
        }

        /// <summary>
        /// Append a 7 to the end of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seven_Click(object sender, EventArgs e)
        {
            this.AddNumber(7);
        }

        /// <summary>
        /// Append a 8 to the end of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eight_Click(object sender, EventArgs e)
        {
            this.AddNumber(8);
        }

        /// <summary>
        /// Append a 9 to the end of the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nine_Click(object sender, EventArgs e)
        {
            this.AddNumber(9);
        }

        /// <summary>
        /// Divide running total by number in text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void divide_Click(object sender, EventArgs e)
        {
            this.AddOperation(Math.Divide);
        }

        /// <summary>
        /// Multiply running total by number in text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void multiply_Click(object sender, EventArgs e)
        {
            this.AddOperation(Math.Multiply);
        }

        /// <summary>
        /// Subtract from running total with number in text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subtract_Click(object sender, EventArgs e)
        {
            this.AddOperation(Math.Subtract);
        }

        /// <summary>
        /// Add to running total with number in text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_Click(object sender, EventArgs e)
        {
            this.AddOperation(Math.Add);
        }

        /// <summary>
        /// Show running total in text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void equals_Click(object sender, EventArgs e)
        {
            // Stop further processing if adding operation fails
            if (!this.AddOperation(Math.Equals))
            {
                return;
            }

            this.ShowTotal();
        }
    }
}
