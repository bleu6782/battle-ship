using System;
using System.IO;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public String Path="";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Remove(object sender, RoutedEventArgs e)
        {
            while (Path.Equals(""))
            {
                var dialog = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();
                if (dialog.ShowDialog(this).GetValueOrDefault())
                {
                    Path = dialog.SelectedPath;
                }
            }
            if (!Directory.Exists(@Path + "\\patients"))
            {
                Directory.CreateDirectory(@Path + "\\patients");
            }
            Path = Path + "\\patients";
            Adding adding = new Adding(3, Path);
            adding.Show();
            this.Close();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            while (Path.Equals(""))
            {
                var dialog = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();
                if (dialog.ShowDialog(this).GetValueOrDefault())
                {
                    Path = dialog.SelectedPath;
                }
            }
            if (!Directory.Exists(@Path + "\\patients"))
            {
                Directory.CreateDirectory(@Path + "\\patients");
            }
            Path = Path + "\\patients";
            Adding adding = new Adding(2 , Path);
            adding.Show();
            this.Close();
        }

        private void Add(object  sender, RoutedEventArgs e)
        {
            while (Path.Equals(""))
            {
                var dialog = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();
                if (dialog.ShowDialog(this).GetValueOrDefault())
                {
                    Path = dialog.SelectedPath;
                }
            }
            if (!Directory.Exists(@Path + "\\patients"))
            {
                Directory.CreateDirectory(@Path + "\\patients");
            }
            Path = Path + "\\patients";
            Adding adding = new Adding(1, Path);
            adding.Show();
            this.Close();
        }

        private void Show(object sender, RoutedEventArgs e)
        {
            while (Path.Equals(""))
            {
                var dialog = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();
                if (dialog.ShowDialog(this).GetValueOrDefault())
                {
                    Path = dialog.SelectedPath;
                }
            }
            Path = Path + "\\patients";
            if (!Directory.Exists(@Path))
            {
                Directory.CreateDirectory(@Path);
            }
            Adding adding = new Adding(4, Path);
            adding.Show(); this.Close();
        }
    }
}