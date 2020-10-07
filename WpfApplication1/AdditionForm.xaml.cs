using System;
using System.IO;
using System.Windows;

namespace WpfApplication1
{
    public partial class AdditionForm
    {
        private String s1;
        public AdditionForm(String id , String path)
        {
            InitializeComponent();
            s1 = path;
            Date.Text = DateTime.Now.ToLongDateString();
            Id.Text = id; 
        }
        private void Next(object sender, RoutedEventArgs e)
        {
            if (!File.Exists(@s1))
            {
                Checking c1 = new Checking("name",Name1.Text);
                Checking c2 = new Checking("last name ",LastName.Text);
                Checking c3 = new Checking("doctors name",DoctorsName.Text);
                Checking c4 = new Checking("disease",Disease.Text);
                Checking c5 = new Checking("age",Age.Text);
                Checking c6 = new Checking("",Age.Text);
                Checking c7 = new Checking("medication field",Medications.Text);
                bool b1, b2, b3, b4, b5, b6, b7;
                b1=c1.EmptyCheck();
                b2=c2.EmptyCheck();
                b3=c3.EmptyCheck();
                b4=c4.EmptyCheck();
                b5=c5.EmptyCheck();
                b6=c6.AgeCheck();
                b7=c7.EmptyCheck();
                if (b1 && b2 && b3 && b4 && b5 && b6 && b7) 
                {
                    Patient patient = new Patient();
                    patient.nId = Id.Text;
                    patient.name = Name1.Text;
                    patient.lastName = LastName.Text;
                    patient.doctorsName = DoctorsName.Text;
                    patient.disease = Disease.Text;
                    patient.medications = Medications.Text;
                    patient.age = Int32.Parse(Age.Text);
                    patient.receptionDateTime = DateTime.Now;
                    BinarySerialization.WriteToBinaryFile(@s1, patient);
                    Errors errors = new Errors("successfully saved !");
                    this.Close();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    errors.Show();
                }
                
            }
            else
            {
                Errors errors = new Errors("already exists !!!!");
                errors.Show();
            }
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}