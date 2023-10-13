using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private char[,] gameboard = new char[3,3];
       

        public MainWindow(){
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e){
            if (sender is Button button)
            {
                if (string.IsNullOrEmpty(button.Content as string))
                {
                    button.Content = isPlayerX ? "X" : "O";
                    UpdateGameboard(button.Tag.ToString());
                    isPlayerX = !isPlayerX;
                }
            }
        }
        private void UpdateGameboard(String code){
            string[] parts = code.Split(',');
            int x = int.Parse(parts[0]);
            int y = int.Parse(parts[1]);
            Console.WriteLine(parts[0] + " " + parts[1]);
            gameboard[x, y] = isPlayerX ? 'X' : 'O';
        }

        private void CheckWin(){
            for (int i = 0; i < gameboard.Length; i++)
            {
                if (gameboard[i, 0].Equals(gameboard[i, 1]) && gameboard[i, 1].Equals(gameboard[i, 2]))
                {
                    if(!gameboard[i, 0].Equals(null)) { 
                    Console.WriteLine("Winner is " + gameboard[i, 0]);
                    }
                }
            }
        }
    }
}
