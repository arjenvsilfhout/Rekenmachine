// ReSharper disable SpecifyACultureInStringConversionExplicitly

namespace ScientificCalculator
{
    using System;
    using System.Windows;
    using System.Windows.Controls;

    using ScientificCalculator.Model;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        /// <summary>
        /// The num1
        /// </summary>
        private decimal num1;

        /// <summary>
        /// The num2
        /// </summary>
        private decimal num2;

        /// <summary>
        /// The current operator
        /// </summary>
        private Operator currentOperator;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Inputs the specified a.
        /// </summary>
        /// <param name="a">a.</param>
        private void Input(string a)
        {
            this.TxtMain.Text += a;
        }

        /// <summary>
        /// Handles the Click event of the btn_O control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnOClick(object sender, RoutedEventArgs e)
        {
            var btnOperator = (Button)sender;
            this.currentOperator = (Operator)Enum.Parse(typeof(Operator), btnOperator.Name);
            this.num1 = decimal.Parse(this.TxtMain.Text);
            this.TxtMain.Text = "0";
        }

        /// <summary>
        /// BTNs the number click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnNumberClick(object sender, RoutedEventArgs e)
        {
            var btnNumber = (Button)sender;
            this.Input(btnNumber.Content.ToString());
        }

        /// <summary>
        /// Handles the Click event of the btn_Dot control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnDotClick(object sender, RoutedEventArgs e)
        {
            if (this.TxtMain.Text != string.Empty)
            {
                if (!this.TxtMain.Text.Contains("."))
                {
                    this.Input(".");
                }
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the txt_Main control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="TextChangedEventArgs"/> instance containing the event data.</param>
        private void TxtMainTextChanged(object sender, TextChangedEventArgs e)
        {    
        }

        /// <summary>
        /// BTNs the remove click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnRemoveClick(object sender, RoutedEventArgs e)
        {
            if (this.TxtMain.Text != string.Empty)
            {
                if (this.TxtMain.Text.Length == 1)
                {
                    this.TxtMain.Text = string.Empty;
                }
                else if (this.TxtMain.Text.Length > 0)
                {
                    this.TxtMain.Text = this.TxtMain.Text.Substring(0, this.TxtMain.Text.Length - 1);
                }
            }
        }

        /// <summary>
        /// BTNs the clear click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnClearClick(object sender, RoutedEventArgs e)
        {
            this.TxtMain.Text = string.Empty;
            this.currentOperator = Operator.Identity;
            this.num1 = 0;
            this.num2 = 0;
        }

        /// <summary>
        /// BTNs the equal click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnEqualClick(object sender, RoutedEventArgs e)
        {
            this.num2 = decimal.Parse(this.TxtMain.Text);

            switch (this.currentOperator)
            {
                case Operator.Addition:
                    this.TxtMain.Text = Operations.Add(this.num1, this.num2).ToString();
                    break;
                case Operator.Substraction:
                    this.TxtMain.Text = Operations.Substract(this.num1, this.num2).ToString();
                    break;
                case Operator.Multiplication:
                    this.TxtMain.Text = Operations.Multiply(this.num1, this.num2).ToString();
                    break;
                case Operator.Division:
                    this.TxtMain.Text = Operations.Division(this.num1, this.num2).ToString();
                    break;
                case Operator.Power:
                    this.TxtMain.Text = Operations.Power(this.num1, (int)this.num2).ToString();
                    break;
                case Operator.Modulo:
                    this.TxtMain.Text = Operations.Modulo(this.num1, this.num2).ToString();
                    break;
            }
        }

        /// <summary>
        /// BTNs the sin click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnSinClick(object sender, RoutedEventArgs e)
        {
            if (this.currentOperator == Operator.Sinus)
            {
                // TODO: Sinus methode aanroepen
            }
            else
            {
                // TODO: Sinus methode aanroepen
            }
        }

        /// <summary>
        /// BTNs the cos click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnCosClick(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// BTNs the cos click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnSqrtClick(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// BTNs the log click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnLogClick(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// BTNs the tan click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnTanClick(object sender, RoutedEventArgs e)
        {
        }

        /// <summary>
        /// BTNs the fact click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void BtnFactClick(object sender, RoutedEventArgs e)
        {
            //TODO: factorial implementeren
        }
    }
}