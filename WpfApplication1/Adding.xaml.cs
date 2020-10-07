using System;
using System.IO;
using System.Windows;
namespace WpfApplication1
{
    public partial class Adding
    {
        private readonly int _mode;
        private String _nId;
        private String path;
        public Adding(int mode , String path)
        {
            this._mode = mode;
            InitializeComponent();
            this.path = path;
        }
        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Next(object sender, RoutedEventArgs e)
        {
            _nId = TextBox.Text;
            String s1 = path+"\\" + _nId + ".bin";
            Checking checking = new Checking("ID", TextBox.Text);
            if (checking.EmptyCheck() && checking.IdLength() && checking.IdCheck())
            {
                if (_mode == 1 )
                {
                    if (!File.Exists(@s1))
                    {
                        AdditionForm additionForm = new AdditionForm(_nId,s1);
                        additionForm.Show();
                        this.Close();
                    }
                    else
                    {
                        Errors errors = new Errors("file already exists !");
                        errors.Show();
                    }
                }else
                {
                    if (File.Exists(@s1))
                    {
                        Patient patient2 = BinarySerialization.ReadFromBinaryFile<Patient>(@s1);
                        if (_mode == 2)
                        {
                            Editting editting = new Editting(patient2,s1);
                            editting.Show(); 
                            this.Close();
                        }
                        if (_mode == 3)
                        { 
                            Removing removing = new Removing(_nId, patient2,s1); 
                            removing.Show(); 
                            this.Close();
                        }

                        if (_mode == 4)
                        {
                            Show show = new Show(patient2);
                            show.Show();
                            this.Close();
                        }
                    }
                    else
                    { 
                        Errors errors = new Errors("file dose not exist!"); 
                        errors.Show();
                    }
                }
            }
        }
    }
}