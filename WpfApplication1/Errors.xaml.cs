using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication1
{
    
    public partial class Errors : Window
    {
        public Errors(String message)
        {
            InitializeComponent();
            Message.Text = message;
        }


        private void Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}