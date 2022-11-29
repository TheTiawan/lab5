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

namespace lab5
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

        private void MultiplicateButtonClick(object sender, RoutedEventArgs e)
        {

            try
            {
                int _fpfv = Convert.ToInt32(FirstPairFirstValue.Text);
                int _fpsv = Convert.ToInt32(FirstPairSecondValue.Text);
                int _spfv = Convert.ToInt32(SecondPairFirstValue.Text);
                int _spsv = Convert.ToInt32(SecondPairSecondValue.Text);

                Pair pair1 = new(_fpfv, _spfv);
                Pair pair2 = new(_fpsv, _spsv);

                Pair pair = pair1.Multiplicate(pair2);
                ResultFirstValue.Text = $"{pair.First}";
                ResultSecondValue.Text = $"{pair.Second}";
            }
            catch
            {
                MessageBox.Show("Введите числа");
            }


        }

        private void DoubleButtonClick(object sender, RoutedEventArgs e)
        {

            try
            {
                int _fpfv = Convert.ToInt32(FirstPairFirstValue.Text);
                int _fpsv = Convert.ToInt32(FirstPairSecondValue.Text);
                int _spfv = Convert.ToInt32(SecondPairFirstValue.Text);
                int _spsv = Convert.ToInt32(SecondPairSecondValue.Text);

                Pair pair1 = new(_fpfv, _spfv);
                Pair pair2 = new(_fpsv, _spsv);

                Pair paird1 = pair1.Doubling(pair1);
                Pair paird2 = pair2.Doubling(pair2);

                FirstPairFirstValue.Text = paird1.First.ToString();
                SecondPairFirstValue.Text = paird1.Second.ToString();
                FirstPairSecondValue.Text = paird2.First.ToString();
                SecondPairSecondValue.Text = paird2.Second.ToString();
            }
            catch
            {
                MessageBox.Show("Введите числа");
            }
        }

            

    

        private void AboutProgramClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать класс Pair (пара четных чисел).\nСоздать необходимые методы и свойства.\nОпределить метод перемножения пар (а, b) * (с, d) = (а * c, b * d).\nСоздать перегруженный метод для удвоения пары чисел.\nСоздатель: Халимов Виктор.");
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

