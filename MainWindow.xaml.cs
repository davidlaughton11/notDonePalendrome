/*David Laughton
 * June 5th 2019
 * palindrome program 2016 
 * not done
 */

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

namespace CulminatingProblemJ3HiddenPalindrome
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] arrayLetters = new string[0];
        string word;
        string newWords;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            word = wordInput.Text;

            for (int i = 0; i < word.Length; i++)
            {
                Array.Resize(ref arrayLetters, arrayLetters.Length + 1);
                arrayLetters[i] = word[i].ToString();
            }

            for (int i = 0; i < word.Length ; i ++)
            {
                newWords += arrayLetters[i];
            }

            CheckIfPalindrome();
        }

        private void CheckIfPalindrome()
        {
            for (int i = 0; i < word.Length + 1 / 2; i++)
            {
                if (areLettersNotTheLength(i) == false)
                {
                    lblOutput.Content = word.Length;
                }
                else
                {
                    lblOutput.Content = "wrong bro";
                }
            }
        }

        private bool areLettersNotTheLength(int i)
        {
            if (arrayLetters[i] != arrayLetters[word.Length - i - 1])
            {
                return true;
            }
            else return false;
        }
    }
}
