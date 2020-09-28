using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _op1;
        private double _op2;
        private char _opr;
        private double _result;
        public MainWindow()
        {
            InitializeComponent();

            btnone.Click += CalculatorDisplayer;
            btntwo.Click += CalculatorDisplayer;
            btnthree.Click += CalculatorDisplayer;
            btnfour.Click += CalculatorDisplayer;
            btnfive.Click += CalculatorDisplayer;
            btnsix.Click += CalculatorDisplayer;
            btnseven.Click += CalculatorDisplayer;
            btneight.Click += CalculatorDisplayer;
            btnnine.Click += CalculatorDisplayer;
            btnzero.Click += CalculatorDisplayer;
            btnplus.Click += CalculatorDisplayer;
            btnminus.Click += CalculatorDisplayer;
            btnmulti.Click += CalculatorDisplayer;
            btndiv.Click += CalculatorDisplayer;
            btnequals.Click += CalculatorDisplayer;
            btnC.Click += CalculatorDisplayer;
        }

        private void CalculatorDisplayer(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

            if (button.Content.ToString() == "+" || button.Content.ToString() == "-" || button.Content.ToString() == "*" || button.Content.ToString() == "/" && _result != default)
            {
                double.TryParse(txtdisplay.Text, out _op1);
            }
            else
            {
                double.TryParse(txtdisplay.Text, out _result);
            }

            switch (button.Content.ToString())
            {
                case "+":
                    _result = _result + _op1;
                    txtdisplay.Text = _result.ToString();
                    break;
                case "-":
                    _result = _result - _op1;
                    txtdisplay.Text = _result.ToString();
                    break;
                case "*":
                    _result = _result * _op1;
                    txtdisplay.Text = _result.ToString();
                    break;
                case "/":
                    if (_op1 == 0)
                    {
                        txtdisplay.Text = "ERROR";
                    }
                    else
                    {
                        _result = _result / _op1;
                        txtdisplay.Text = _result.ToString();
                    }
                    break;

                case "C":
                    txtdisplay.Text = "";
                    break;
                case "=":
                    txtdisplay.Text = _result.ToString();
                    break;
                default:
                    if (_result == default)
                    {
                        _result = Convert.ToDouble(button.Content.ToString());
                    }
                    txtdisplay.Text += button.Content.ToString();
                    break;
            }
        }

        private void UpdateResult()
        {
            if(_op1 != default)
            {
                switch (_opr)
                {
                    case '+':
                        _result = _result + _op1;
                        txtdisplay.Text = _result.ToString();
                        break;
                    case '-':
                        _result = _result - _op1;
                        txtdisplay.Text = _result.ToString();
                        break;
                    case '*':
                        _result = _result * _op1;
                        txtdisplay.Text = _result.ToString();
                        break;
                    case '/':
                        if (_op1 == 0)
                        {
                            txtdisplay.Text = "ERROR";
                        }
                        else
                        {
                            _result = _result / _op1;
                            txtdisplay.Text = _result.ToString();
                        }
                        break;
                }
            }
        }
    }
}
