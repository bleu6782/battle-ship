using System.Windows;

namespace WpfApplication1
{
    public partial class Path : Window
    {
        public Path()
        {
            InitializeComponent();
            var dialog = new Ookii.Dialogs.Wpf.VistaFolderBrowserDialog();
            if (dialog.ShowDialog(this).GetValueOrDefault())
            {
                FolderPath.Text = dialog.SelectedPath;
            }
        }
    }
}