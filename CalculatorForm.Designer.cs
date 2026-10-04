namespace Calculator
{
    partial class CalculatorForm
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
            numberBox = new TextBox();
            one = new Button();
            three = new Button();
            two = new Button();
            five = new Button();
            six = new Button();
            four = new Button();
            eight = new Button();
            nine = new Button();
            seven = new Button();
            ce = new Button();
            zero = new Button();
            c = new Button();
            add = new Button();
            subtract = new Button();
            multiply = new Button();
            divide = new Button();
            posNeg = new Button();
            addDecimal = new Button();
            equals = new Button();
            delete = new Button();
            SuspendLayout();
            // 
            // numberBox
            // 
            numberBox.BorderStyle = BorderStyle.FixedSingle;
            numberBox.Dock = DockStyle.Top;
            numberBox.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberBox.Location = new Point(0, 0);
            numberBox.Multiline = true;
            numberBox.Name = "numberBox";
            numberBox.ReadOnly = true;
            numberBox.Size = new Size(590, 100);
            numberBox.TabIndex = 1;
            numberBox.TabStop = false;
            numberBox.Text = "0";
            // 
            // one
            // 
            one.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            one.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            one.Location = new Point(12, 184);
            one.Name = "one";
            one.Size = new Size(137, 62);
            one.TabIndex = 6;
            one.Text = "&1";
            one.UseVisualStyleBackColor = true;
            one.Click += one_Click;
            // 
            // three
            // 
            three.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            three.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            three.Location = new Point(298, 184);
            three.Name = "three";
            three.Size = new Size(137, 62);
            three.TabIndex = 8;
            three.Text = "&3";
            three.UseVisualStyleBackColor = true;
            three.Click += three_Click;
            // 
            // two
            // 
            two.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            two.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            two.Location = new Point(155, 184);
            two.Name = "two";
            two.Size = new Size(137, 62);
            two.TabIndex = 7;
            two.Text = "&2";
            two.UseVisualStyleBackColor = true;
            two.Click += two_Click;
            // 
            // five
            // 
            five.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            five.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            five.Location = new Point(155, 252);
            five.Name = "five";
            five.Size = new Size(137, 62);
            five.TabIndex = 11;
            five.Text = "&5";
            five.UseVisualStyleBackColor = true;
            five.Click += five_Click;
            // 
            // six
            // 
            six.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            six.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            six.Location = new Point(298, 252);
            six.Name = "six";
            six.Size = new Size(137, 62);
            six.TabIndex = 12;
            six.Text = "&6";
            six.UseVisualStyleBackColor = true;
            six.Click += six_Click;
            // 
            // four
            // 
            four.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            four.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            four.Location = new Point(12, 252);
            four.Name = "four";
            four.Size = new Size(137, 62);
            four.TabIndex = 10;
            four.Text = "&4";
            four.UseVisualStyleBackColor = true;
            four.Click += four_Click;
            // 
            // eight
            // 
            eight.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eight.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            eight.Location = new Point(155, 320);
            eight.Name = "eight";
            eight.Size = new Size(137, 62);
            eight.TabIndex = 15;
            eight.Text = "&8";
            eight.UseVisualStyleBackColor = true;
            eight.Click += eight_Click;
            // 
            // nine
            // 
            nine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nine.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            nine.Location = new Point(298, 320);
            nine.Name = "nine";
            nine.Size = new Size(137, 62);
            nine.TabIndex = 16;
            nine.Text = "&9";
            nine.UseVisualStyleBackColor = true;
            nine.Click += nine_Click;
            // 
            // seven
            // 
            seven.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            seven.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            seven.Location = new Point(12, 320);
            seven.Name = "seven";
            seven.Size = new Size(137, 62);
            seven.TabIndex = 14;
            seven.Text = "&7";
            seven.UseVisualStyleBackColor = true;
            seven.Click += seven_Click;
            // 
            // ce
            // 
            ce.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ce.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            ce.Location = new Point(12, 116);
            ce.Name = "ce";
            ce.Size = new Size(137, 62);
            ce.TabIndex = 2;
            ce.Text = "C&E";
            ce.UseVisualStyleBackColor = true;
            ce.Click += ce_Click;
            // 
            // zero
            // 
            zero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            zero.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            zero.Location = new Point(155, 388);
            zero.Name = "zero";
            zero.Size = new Size(137, 62);
            zero.TabIndex = 19;
            zero.Text = "&0";
            zero.UseVisualStyleBackColor = true;
            zero.Click += zero_Click;
            // 
            // c
            // 
            c.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            c.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            c.Location = new Point(155, 116);
            c.Name = "c";
            c.Size = new Size(137, 62);
            c.TabIndex = 3;
            c.Text = "&C";
            c.UseVisualStyleBackColor = true;
            c.Click += c_Click;
            // 
            // add
            // 
            add.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            add.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            add.Location = new Point(441, 320);
            add.Name = "add";
            add.Size = new Size(137, 62);
            add.TabIndex = 17;
            add.Text = "&+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // subtract
            // 
            subtract.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subtract.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            subtract.Location = new Point(441, 252);
            subtract.Name = "subtract";
            subtract.Size = new Size(137, 62);
            subtract.TabIndex = 13;
            subtract.Text = "&—";
            subtract.UseVisualStyleBackColor = true;
            subtract.Click += subtract_Click;
            // 
            // multiply
            // 
            multiply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            multiply.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            multiply.Location = new Point(441, 184);
            multiply.Name = "multiply";
            multiply.Size = new Size(137, 62);
            multiply.TabIndex = 9;
            multiply.Text = "&x";
            multiply.UseVisualStyleBackColor = true;
            multiply.Click += multiply_Click;
            // 
            // divide
            // 
            divide.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            divide.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            divide.Location = new Point(441, 116);
            divide.Name = "divide";
            divide.Size = new Size(137, 62);
            divide.TabIndex = 5;
            divide.Text = "&/";
            divide.UseVisualStyleBackColor = true;
            divide.Click += divide_Click;
            // 
            // posNeg
            // 
            posNeg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            posNeg.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            posNeg.Location = new Point(12, 388);
            posNeg.Name = "posNeg";
            posNeg.Size = new Size(137, 62);
            posNeg.TabIndex = 18;
            posNeg.Text = "+/-";
            posNeg.UseVisualStyleBackColor = true;
            posNeg.Click += posNeg_Click;
            // 
            // addDecimal
            // 
            addDecimal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addDecimal.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            addDecimal.Location = new Point(298, 388);
            addDecimal.Name = "addDecimal";
            addDecimal.Size = new Size(137, 62);
            addDecimal.TabIndex = 20;
            addDecimal.Text = "&.";
            addDecimal.UseVisualStyleBackColor = true;
            addDecimal.Click += addDecimal_Click;
            // 
            // equals
            // 
            equals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            equals.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            equals.Location = new Point(441, 388);
            equals.Name = "equals";
            equals.Size = new Size(137, 62);
            equals.TabIndex = 0;
            equals.Text = "&=";
            equals.UseVisualStyleBackColor = true;
            equals.Click += equals_Click;
            // 
            // delete
            // 
            delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            delete.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            delete.Location = new Point(298, 116);
            delete.Name = "delete";
            delete.Size = new Size(137, 62);
            delete.TabIndex = 4;
            delete.Text = "&DEL";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // CalculatorForm
            // 
            AcceptButton = equals;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = c;
            ClientSize = new Size(590, 462);
            Controls.Add(delete);
            Controls.Add(equals);
            Controls.Add(addDecimal);
            Controls.Add(posNeg);
            Controls.Add(add);
            Controls.Add(subtract);
            Controls.Add(multiply);
            Controls.Add(divide);
            Controls.Add(c);
            Controls.Add(zero);
            Controls.Add(ce);
            Controls.Add(eight);
            Controls.Add(nine);
            Controls.Add(seven);
            Controls.Add(five);
            Controls.Add(six);
            Controls.Add(four);
            Controls.Add(two);
            Controls.Add(three);
            Controls.Add(one);
            Controls.Add(numberBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberBox;
        private Button one;
        private Button three;
        private Button two;
        private Button five;
        private Button six;
        private Button four;
        private Button eight;
        private Button nine;
        private Button seven;
        private Button ce;
        private Button zero;
        private Button c;
        private Button add;
        private Button subtract;
        private Button multiply;
        private Button divide;
        private Button posNeg;
        private Button addDecimal;
        private Button equals;
        private Button delete;
    }
}
