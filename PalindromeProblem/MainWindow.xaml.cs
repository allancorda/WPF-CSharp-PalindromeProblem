using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PalindromeProblem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool isEven(int l)
        {
            if ((l % 2) == 0)
                return true;
            else
                return false;
        }

        private int GetMiddlePoint()
        {
            int len = txtAns.Text.Length;
            if (isEven(len))
            {
                return len / 2;
            }
            else
            {
                double odd = len / 2.0;
                Math.Ceiling(odd);
                return Convert.ToInt32(odd);
            }
        }

        private bool CheckPalindrome(int max)
        {
            for (int j, i = 0; i < max; i++)
            {
                j = (txtAns.Text.Length - 1) - i;
                if(txtAns.Text[i] != txtAns.Text[j])
                {
                    return false;
                }

            }
            return true;
        }

        private bool CheckPalindrome2()
        {
            int i, j;
            for (j = (txtAns.Text.Length - 1), i = 0; i < j; i++,j--)
            {
                if (txtAns.Text[i] != txtAns.Text[j])
                {
                    return false;
                }

            }
            return true;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (txtAns.Text.Length > 2)
            {
                if (CheckPalindrome2())
                    lblResult.Content = "True";
                else
                    lblResult.Content = "False";
            }
            else
                lblResult.Content = "Invalid";

        }
    }
}
