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

namespace Lesson_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }

        private EventHandler addition;
        private EventHandler subtraction;
        private EventHandler multiplication;
        private EventHandler division;

        public event EventHandler AddEvent
        {
            add { this.addition += value; }
            remove { this.addition -= value; }
        }

        public event EventHandler SubEvent
        {
            add { this.subtraction += value; }
            remove { this.subtraction -= value; }
        }

        public event EventHandler MulEvent
        {
            add { this.multiplication += value; }
            remove { this.multiplication -= value; }
        }

        public event EventHandler DivEvent
        {
            add { this.division += value; }
            remove { this.division -= value; }
        }

        private void Addition_Click(object sender, RoutedEventArgs e)
        {
            addition.Invoke(sender, e);
        }

        private void Subtraction_Click(object sender, RoutedEventArgs e)
        {
            subtraction.Invoke(sender, e);
        }

        private void Multiplication_Click(object sender, RoutedEventArgs e)
        {
            multiplication.Invoke(sender, e);
        }

        private void Division_Click(object sender, RoutedEventArgs e)
        {
            division.Invoke(sender, e);
        }
    }
}
