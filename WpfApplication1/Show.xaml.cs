using System;
using System.Windows;

namespace WpfApplication1
{
    public partial class Show
    {
        public Show(Patient p )
        {
            InitializeComponent();
            this.Id.Text = p.nId;
            Name2.Text = p.name;
            LastName.Text = p.lastName;
            DoctorsName.Text = p.doctorsName;
            Disease.Text = p.disease;
            Medications.Text = p.medications;
            Age.Text = p.age.ToString();
            Date.Text = p.receptionDateTime.ToLongDateString();
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}