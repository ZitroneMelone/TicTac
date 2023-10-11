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

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        private bool isPlayerX = true;
        private char[,] gameboard;



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                if (string.IsNullOrEmpty(button.Content as string))
                {
                    button.Content = isPlayerX ? "X" : "O";
                    isPlayerX = !isPlayerX;
                }
            }
        }
    }
}
