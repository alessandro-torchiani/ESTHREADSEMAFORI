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
using System.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string[] liberi = new string[16];
        public string[] occupati = new string[16];
        public bool[] checkPosti = new bool[16];
        Semaphore _pool = new Semaphore(1, 1);

        public MainWindow()
        {
            InitializeComponent();
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            txt2.IsEnabled = false;
            txt1.IsEnabled = false;

            for (int i = 0; i < 16; i++)
            {
                liberi[i] = "postolibera" + (i + 1) + ".jpg";
                occupati[i] = "cinema" + (i + 1) + ".jpg";
                checkPosti[i] = true;
            }

        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            txt1.IsEnabled = true;
            BitmapImage posto1 = new BitmapImage();

        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            txt2.IsEnabled = true;
        }

        public bool PostoLibero(int n)
        {
            if (checkPosti[n - 1] == true)
            {
                checkPosti[n - 1] = false;
                MessageBox.Show("Posto acquistato correttamente");
                return true;
            }
            else
            {
                MessageBox.Show("Posto già occupato");
                return false;
            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txt1.Text);
            OccupaPosto(n);

        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txt2.Text);
            OccupaPosto(n);


        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(Random));
            t1.Start();
        }
        int test;
        public void Random()
        {
            Random r = new Random();
            int valore = r.Next(1, 16);
            test = valore;
        }

        public void OccupaPosto(int numeroInserito)
        {
            if (test != -1)
            {
                test = -1;

            }
            else
            {
                if (numeroInserito >= 1 && numeroInserito <= 16)
                {
                    if (PostoLibero(numeroInserito) == true)
                    {
                        numeroInserito--;
                        switch (numeroInserito + 1)
                        {

                            case 1:
                                _pool.WaitOne();
                                img1.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 2:
                                _pool.WaitOne();
                                img2.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 3:
                                _pool.WaitOne();
                                img3.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 4:
                                _pool.WaitOne();
                                img4.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 5:
                                _pool.WaitOne();
                                img5.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 6:
                                _pool.WaitOne();
                                img6.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 7:
                                _pool.WaitOne();
                                img7.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 8:
                                _pool.WaitOne();
                                img8.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 9:
                                _pool.WaitOne();
                                img9.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 10:
                                _pool.WaitOne();
                                img10.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 11:
                                _pool.WaitOne();
                                img11.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 12:
                                _pool.WaitOne();
                                img12.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 13:
                                _pool.WaitOne();
                                img13.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 14:
                                _pool.WaitOne();
                                img14.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 15:
                                _pool.WaitOne();
                                img15.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                            case 16:
                                _pool.WaitOne();
                                img16.Source = new BitmapImage(new Uri(@"C:\Users\aless\source\repos\WpfApp2\WpfApp2\bin\Debug\" + occupati[numeroInserito]));
                                _pool.Release(1);
                                break;
                        }
                    }
                }
            }
        }
    }
}

