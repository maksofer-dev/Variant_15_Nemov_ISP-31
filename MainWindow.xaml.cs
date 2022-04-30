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

namespace Variant_15
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int width = 8;
        const int height = 8;
        const int min = -1;
        const int max = 10;
        int[,] array = new int[width, height];



        public MainWindow()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            // Заполнение массива
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    array[i, j] = random.Next(min, max);
                }
            }
            try
            {
                dataA.ItemsSource = array.ToDataTable().DefaultView;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void resultBtn_Click(object sender, RoutedEventArgs e)
        {
            resBlock.Text = "";
            resBlock.Text += "Совпадения: ";

            for (int i = 0, j = 0; i < height && j < width; i++, j++)
            {
                resBlock.Text += ("\n Значение в " + (i + 1) + " строке и " + (j + 1) + " столбце равно " + array[i, j]);
            }
            resBlock.Text += "\n\n";
            resBlock.Text += "Сумма элементов в тех строках,которые содержат хотя бы один отрицательный элемент: ";

            NegativeSumRows sum = new NegativeSumRows();
            string result =  sum.NegativeSum(array);
            resBlock.Text += result;

        }
    }
    
}
