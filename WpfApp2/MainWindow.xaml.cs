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
        private static object x = new object();
        Thread t1;
        Thread t2;
        Thread t3;
        Thread t4;


        public MainWindow()
        {
            InitializeComponent();
            btn2.IsEnabled = false;
            btn3.IsEnabled = false;
            btn5.IsEnabled = false;
            btn6.IsEnabled = false;
            txt2.IsEnabled = false;
            txt1.IsEnabled = false;
            t1 = new Thread(OccupaPosto);
            t2 = new Thread(OccupaPosto2);
            t3 = new Thread(OccupaPostoCasuale);
            t4 = new Thread(OccupaPostoCasuale2);



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
            t1.Start();
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            t2.Start();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            t3.Start();
        }
 
        public void OccupaPosto()
        {
            int numeroInserito = 0;
            bool b = true;
            
            this.Dispatcher.BeginInvoke(new Action(() =>
            {
               b = int.TryParse(txt1.Text, out numeroInserito);
            }));

            if (numeroInserito >= 1 && numeroInserito <= 16 && b == true)
                {
                lock (x)
                {
                    if (PostoLibero(numeroInserito) == true)
                    {
                        numeroInserito--;
                        switch (numeroInserito + 1)
                        {

                            case 1:
                                img1.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 2:
                                img2.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 3:
                                img3.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 4:
                                img4.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 5:
                                img5.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 6:
                                img6.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 7:
                                img7.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 8:
                                img8.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 9:
                                img9.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 10:
                                img10.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 11:
                                img11.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 12:
                                img12.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 13:
                                img13.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 14:
                                img14.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 15:
                                img15.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 16:
                                img16.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Posto già occupato");
                    }
                }
                }
        }

        public void OccupaPosto2()
        {
            int numeroInserito = 0;
            bool b = true;

            this.Dispatcher.BeginInvoke(new Action(() =>
            {
                b = int.TryParse(txt2.Text, out numeroInserito);
            }));

            if (numeroInserito >= 1 && numeroInserito <= 16 && b == true)
            {
                lock (x)
                {
                    if (PostoLibero(numeroInserito) == true)
                    {
                        numeroInserito--;
                        switch (numeroInserito + 1)
                        {

                            case 1:
                                img1.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 2:
                                img2.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 3:
                                img3.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 4:
                                img4.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 5:
                                img5.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 6:
                                img6.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 7:
                                img7.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 8:
                                img8.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 9:
                                img9.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 10:
                                img10.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 11:
                                img11.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 12:
                                img12.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 13:
                                img13.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 14:
                                img14.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 15:
                                img15.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 16:
                                img16.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Posto già occupato");
                    }
                }
            }
        }


        public void OccupaPostoCasuale()
        {
            int numeroInserito;
            Random r = new Random();
            numeroInserito = r.Next(1, 17);

            lock (x)
                {
                    if (PostoLibero(numeroInserito) == true)
                    {
                        numeroInserito--;
                        switch (numeroInserito + 1)
                        {

                            case 1:
                                img1.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 2:
                                img2.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 3:
                                img3.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 4:
                                img4.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 5:
                                img5.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 6:
                                img6.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 7:
                                img7.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 8:
                                img8.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 9:
                                img9.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 10:
                                img10.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 11:
                                img11.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 12:
                                img12.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 13:
                                img13.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 14:
                                img14.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 15:
                                img15.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                            case 16:
                                img16.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Posto già occupato");
                    }
            }

            
            }
        public void OccupaPostoCasuale2()
        {
            int numeroInserito;
            Random r = new Random();
            numeroInserito = r.Next(1, 17);

            lock (x)
            {
                if (PostoLibero(numeroInserito) == true)
                {
                    numeroInserito--;
                    switch (numeroInserito + 1)
                    {

                        case 1:
                            img1.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 2:
                            img2.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 3:
                            img3.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 4:
                            img4.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 5:
                            img5.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 6:
                            img6.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 7:
                            img7.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 8:
                            img8.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 9:
                            img9.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 10:
                            img10.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 11:
                            img11.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 12:
                            img12.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 13:
                            img13.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 14:
                            img14.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 15:
                            img15.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                        case 16:
                            img16.Source = new BitmapImage(new Uri(@".\Immagini\" + occupati[numeroInserito]));
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Posto già occupato");
                }
            }
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            t4.Start();
        }
    }
}


