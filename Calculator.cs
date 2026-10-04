namespace Calculator
{
    public class Calculator
    {
        /// <summary>
        /// Running total decimal
        /// </summary>
        private decimal? RunningTotal { get; set; }

        /// <summary>
        /// Current operation
        /// </summary>
        private Math? Operation { get; set; }

        /// <summary>
        /// Self-explanatory
        /// </summary>
        readonly Exception DIVIDE_BY_ZERO = new("ERR: Cannot divide by zero.");

        /// <summary>
        /// string cannot convert to decimal due to value being too big/small
        /// </summary>
        readonly Exception INVALID_DECIMAL = new($"Number must be between {decimal.MinValue} and {decimal.MaxValue}.");

        public Calculator() {}

        /// <summary>
        /// Clear running total and current operation from memory
        /// </summary>
        public void Clear()
        {
            this.RunningTotal = null;
            this.Operation = null;
        }

        /// <summary>
        /// Get running total as a string, or 0 if total is null.
        /// </summary>
        /// <returns>string</returns>
        public string Total()
        {
            if (!this.RunningTotal.HasValue)
            {
                return "0";
            }

            return this.RunningTotal.Value.ToString();
        }

        /// <summary>
        /// Update running total with number and operation chosen in calculator
        /// </summary>
        /// <param name="number">The number currently on screen</param>
        /// <param name="operation">The operation chosen</param>
        public void Update(string number, Math operation)
        {
            decimal dec;

            // Try to parse number, throw error if out of bounds
            try
            {
                dec = decimal.Parse(number);
            }
            catch
            {
                this.Clear();
                throw INVALID_DECIMAL;
            }

            // Set total to new number
            if (!this.RunningTotal.HasValue || !this.Operation.HasValue)
            {
                this.RunningTotal = dec;
                this.Operation = operation;
                return;
            }

            // Show error if user attempts to divide by zero
            if (dec == 0 && this.Operation == Math.Divide)
            {
                this.Clear();
                throw DIVIDE_BY_ZERO;
            }

            switch (this.Operation)
            {
                case Math.Add:
                    this.RunningTotal += dec;
                    break;
                case Math.Subtract:
                    this.RunningTotal -= dec;
                    break;
                case Math.Multiply:
                    this.RunningTotal *= dec;
                    break;
                case Math.Divide:
                    this.RunningTotal /= dec;
                    break;
                default:
                    break;
            }

            // Set next operation to argument passed in function
            this.Operation = operation;
        }
    }
}
