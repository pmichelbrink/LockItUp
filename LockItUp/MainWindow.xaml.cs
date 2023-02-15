using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace LockItUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FileStream _fileStream;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                txtPath.Text = openFileDialog.FileName;
        }

        private void btnLock_Click(object sender, RoutedEventArgs e)
        {
            _fileStream = new FileStream(txtPath.Text, FileMode.Open);
            txtStatus.Text = "Locked";
        }

        private void btnUnlock_Click(object sender, RoutedEventArgs e)
        {
            _fileStream.Close();
            txtStatus.Text = "Unlocked";
        }
    }
}
