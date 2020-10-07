using System;
using System.IO;
using System.Windows;

namespace WpfApplication1
{
    public partial class Editting 
    {
        private String s1;
        public Editting( Patient p , String path)
        {
            InitializeComponent();
            s1 = path;
            this.Id .Text = p.nId;
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
        private void Next(object sender, RoutedEventArgs e)
        {
            Checking c1 = new Checking("name",Name2.Text);
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
                File.Delete(@s1);
                Patient p = new Patient();
                p.name = Name2.Text;
                p.lastName = LastName.Text;
                p.nId = Id.Text;
                p.doctorsName = DoctorsName.Text;
                p.disease = Disease.Text;
                p.medications = Medications.Text;
                p.age = Int32.Parse(Age.Text);
                p.receptionDateTime = DateTime.Parse(Date.Text);
                BinarySerialization.WriteToBinaryFile(s1, p);
                Errors errors = new Errors("file successfully edited !");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                errors.Show();
                this.Close();
            }
            
        }
    }
}