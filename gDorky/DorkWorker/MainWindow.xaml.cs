using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace DorkWorker
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

        private void appBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnGoogle_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                GoogleDorkGeneratorPage gPage = new GoogleDorkGeneratorPage();
                gPage.Visibility = Visibility.Visible;
                gPage.Show();
            });
        }

        private void btnBing_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                BingDorksGeneratorsPage bPage = new BingDorksGeneratorsPage();
                bPage.Visibility = Visibility.Visible;
                bPage.Show();
            });
        }

        private void btnYahoo_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                YahooDorksGeneratorsPage yPage = new YahooDorksGeneratorsPage();
                yPage.Visibility = Visibility.Visible;
                yPage.Show();
            });
        }

        private void btnStartPage_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                StartPageDorksGeneratorsPage sPage = new StartPageDorksGeneratorsPage();
                sPage.Visibility = Visibility.Visible;
                sPage.Show();
            });
        }

        private void btnGoogle_MouseEnter(object sender, MouseEventArgs e)
        {
            btnGoogle.Opacity = 0.70;
        }

        private void btnGoogle_MouseLeave(object sender, MouseEventArgs e)
        {
            btnGoogle.Opacity = 1;
        }

        private void btnBing_MouseEnter(object sender, MouseEventArgs e)
        {
            btnBing.Opacity = 0.70;
        }

        private void btnBing_MouseLeave(object sender, MouseEventArgs e)
        {
            btnBing.Opacity = 1;
        }

        private void btnYahoo_MouseEnter(object sender, MouseEventArgs e)
        {
            btnYahoo.Opacity = 0.70;
        }

        private void btnYahoo_MouseLeave(object sender, MouseEventArgs e)
        {
            btnYahoo.Opacity = 1;
        }

        private void btnStartPage_MouseEnter(object sender, MouseEventArgs e)
        {
            btnStartPage.Opacity = 0.70;
        }

        private void btnStartPage_MouseLeave(object sender, MouseEventArgs e)
        {
            btnStartPage.Opacity = 1;
        }

        private void btnYandex_MouseEnter(object sender, MouseEventArgs e)
        {
            btnYandex.Opacity = 0.70;
        }

        private void btnYandex_MouseLeave(object sender, MouseEventArgs e)
        {
            btnYandex.Opacity = 1;
        }

        private void btnExalead_MouseEnter(object sender, MouseEventArgs e)
        {
            btnExalead.Opacity = 0.70;
        }

        private void btnExalead_MouseLeave(object sender, MouseEventArgs e)
        {
            btnExalead.Opacity = 1;
        }

        private void btnDuckDuckGo_MouseEnter(object sender, MouseEventArgs e)
        {
            btnDuckDuckGo.Opacity = 0.70;
        }

        private void btnDuckDuckGo_MouseLeave(object sender, MouseEventArgs e)
        {
            btnDuckDuckGo.Opacity = 1;
        }

        private void btnQwant_MouseEnter(object sender, MouseEventArgs e)
        {
            btnQwant.Opacity = 0.70;
        }

        private void btnQwant_MouseLeave(object sender, MouseEventArgs e)
        {
            btnQwant.Opacity = 1;
        }

        private void btnUniversal_MouseEnter(object sender, MouseEventArgs e)
        {
            btnUniversal.Opacity = 0.70;
        }

        private void btnUniversal_MouseLeave(object sender, MouseEventArgs e)
        {
            btnUniversal.Opacity = 1;
        }

        private void btnYandex_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                YandexDorksGeneratorsPage yandexPage = new YandexDorksGeneratorsPage();
                yandexPage.Visibility = Visibility.Visible;
                yandexPage.ShowDialog();
            });
        }

        private void btnExalead_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                ExaleadDorksGeneratorsPage exaleadPage = new ExaleadDorksGeneratorsPage();
                exaleadPage.Visibility = Visibility.Visible;
                exaleadPage.ShowDialog();
            });
        }

        private void btnDuckDuckGo_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                DuckDuckGoDorksGeneratorsPage duckduckGoPage = new DuckDuckGoDorksGeneratorsPage();
                duckduckGoPage.Visibility = Visibility.Visible;
                duckduckGoPage.ShowDialog();
            });
        }

        private void btnQwant_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                QwantDorksGeneratorsPage qPage = new QwantDorksGeneratorsPage();
                qPage.Visibility = Visibility.Visible;
                qPage.ShowDialog();
            });
        }

        private void btnUniversal_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                YippyDorksGeneratorsPage yPage = new YippyDorksGeneratorsPage();
                yPage.Visibility = Visibility.Visible;
                yPage.ShowDialog();
            });
        }
    }
}
