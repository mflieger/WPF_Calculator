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
        public double DisplayValue { get; set; }
        public int Operand { get; set; }
        public char Operator { get; set; }
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

        }
    }
}
