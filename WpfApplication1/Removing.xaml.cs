using System;
using System.IO;
using System.Windows;


namespace WpfApplication1
{
    public partial class Removing
    {
        private String s1;
        public Removing(String id , Patient patient , String path)
        {
            s1 = path;
            InitializeComponent();
            Id.Text = patient.nId; 
            Name2.Text = patient.name;
            LastName.Text = patient.lastName; 
            DoctorsName.Text = patient.doctorsName;
            Disease.Text = patient.disease;
            Medications.Text = patient.medications;
            Age.Text = patient.age.ToString();
            Date.Text = patient.receptionDateTime.ToLongDateString();
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            File.Delete(@s1);
            if (!File.Exists(@s1))
            {
                Errors errors = new Errors("successfully deleted .");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                errors.Show();
                this.Close();
            }
        }
    }
}