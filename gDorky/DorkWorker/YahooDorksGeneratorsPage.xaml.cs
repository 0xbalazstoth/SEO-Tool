using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace DorkWorker
{
    /// <summary>
    /// Interaction logic for GoogleDorkGeneratorPage.xaml
    /// </summary>
    public partial class YahooDorksGeneratorsPage : Window
    {
        static bool YahooIsBtnDorkPatternsClicked = false;
        static bool YahooIsBtnTLDExtensionClicked = false;
        static bool YahooIsBtnKeywordsClicked = false;
        static bool YahooIsBtnSearchOperatorsClicked = false;

        static List<TLDExtension> YahooTLDExtensionData = new List<TLDExtension>();
        static TLDExtension YahooTLDExtension;

        static List<Keywords> YahooKeywordsData = new List<Keywords>();
        static Keywords YahooKeywords;

        static List<SearchOperators> YahooSearchOperatorsData = new List<SearchOperators>();
        static SearchOperators YahooSearchOperators;

        static string rootFolderName;

        static int GeneratedDorks = 0;
        public YahooDorksGeneratorsPage()
        {
            InitializeComponent();

            CreateDirectory("Yahoo Dorks");
        }

        private void CreateDirectory(string folderName)
        {
            rootFolderName = folderName;
            if (!Directory.Exists(rootFolderName))
            {
                Directory.CreateDirectory(rootFolderName);
            }
        }

        private void YahooAppBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void YahooBtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void YahooBtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void YahooBtnDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YahooIsBtnTLDExtensionClicked)
                    YahooBtnTLDExtension.BorderThickness = new Thickness(0);
                if (YahooIsBtnKeywordsClicked)
                    YahooBtnKeywords.BorderThickness = new Thickness(0);
                if (YahooIsBtnSearchOperatorsClicked)
                    YahooBtnSearchOperators.BorderThickness = new Thickness(0);

                YahooBtnDorkPatterns.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YahooBtnDorkPatterns.BorderThickness = new Thickness(2);
                YahooIsBtnDorkPatternsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YahooDorkPatternsUI.Visibility = Visibility.Visible;
                    YahooTLDExtensionUI.Visibility = Visibility.Hidden;
                    YahooKeywordsUI.Visibility = Visibility.Hidden;
                    YahooSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YahooBtnTLDExtension_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YahooIsBtnDorkPatternsClicked)
                    YahooBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YahooIsBtnKeywordsClicked)
                    YahooBtnKeywords.BorderThickness = new Thickness(0);
                if (YahooIsBtnSearchOperatorsClicked)
                    YahooBtnSearchOperators.BorderThickness = new Thickness(0);

                YahooBtnTLDExtension.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YahooBtnTLDExtension.BorderThickness = new Thickness(2);
                YahooIsBtnTLDExtensionClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YahooDorkPatternsUI.Visibility = Visibility.Hidden;
                    YahooTLDExtensionUI.Visibility = Visibility.Visible;
                    YahooKeywordsUI.Visibility = Visibility.Hidden;
                    YahooSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YahooBtnKeywords_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YahooIsBtnDorkPatternsClicked)
                    YahooBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YahooIsBtnTLDExtensionClicked)
                    YahooBtnTLDExtension.BorderThickness = new Thickness(0);
                if (YahooIsBtnSearchOperatorsClicked)
                    YahooBtnSearchOperators.BorderThickness = new Thickness(0);

                YahooBtnKeywords.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YahooBtnKeywords.BorderThickness = new Thickness(2);
                YahooIsBtnKeywordsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YahooDorkPatternsUI.Visibility = Visibility.Hidden;
                    YahooTLDExtensionUI.Visibility = Visibility.Hidden;
                    YahooKeywordsUI.Visibility = Visibility.Visible;
                    YahooSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YahooBtnSearchOperators_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YahooIsBtnDorkPatternsClicked)
                    YahooBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YahooIsBtnKeywordsClicked)
                    YahooBtnKeywords.BorderThickness = new Thickness(0);
                if (YahooIsBtnTLDExtensionClicked)
                    YahooBtnTLDExtension.BorderThickness = new Thickness(0);

                YahooBtnSearchOperators.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YahooBtnSearchOperators.BorderThickness = new Thickness(2);
                YahooIsBtnSearchOperatorsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YahooDorkPatternsUI.Visibility = Visibility.Hidden;
                    YahooTLDExtensionUI.Visibility = Visibility.Hidden;
                    YahooKeywordsUI.Visibility = Visibility.Hidden;
                    YahooSearchOperatorsUI.Visibility = Visibility.Visible;
                }));
            }));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private void YahooBtnCleantxtBoxKeywordsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YahooTxtBoxKeywordsField.Clear();
            }));

        }

        private void YahooBtnCleantxtBoxSearchOperatorsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YahooTxtBoxSearchOperatorsField.Clear();
            }));
        }

        private void YahooBtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string DateNow = $"{DateTime.Now.Year}-{DateTime.Now.Month.ToString("d2")}-{DateTime.Now.Day.ToString("d2")}-{DateTime.Now.Hour.ToString("d2")}-{DateTime.Now.Minute.ToString("d2")}-{DateTime.Now.Second.ToString("d2")}-{DateTime.Now.Millisecond.ToString("d2")}";
            FileStream fajl = new FileStream($"{rootFolderName}/Yahoo-dorks-{DateNow}.txt", FileMode.Create);
            StreamWriter ki = new StreamWriter(fajl, Encoding.UTF8);

            HashSet<string> generatedDorks = new HashSet<string>();

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YahooTLDExtensionData.Clear();
                YahooKeywordsData.Clear();
                YahooSearchOperatorsData.Clear();
                YahooLblGeneratedDorks.Content = "Please wait, now generating dorks!";
                GeneratedDorks = 0;
                YahooBtnOpenSaveFolder.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YahooBtnGenerate.IsEnabled = false;
                YahooBtnCleantxtBoxKeywordsField.IsEnabled = false;
                YahooBtnCleantxtBoxSearchOperatorsField.IsEnabled = false;
                YahooBtnCleantxtBoxTLDExtensionField.IsEnabled = false;
                YahooBtnAllSelectionDorkPatterns.IsEnabled = false;
                YahooBtnClearSelectionDorkPatterns.IsEnabled = false;
                YahooCheckBoxSOKWTLD.IsEnabled = false;
                YahooCheckBoxSOKW.IsEnabled = false;
                YahooCheckBoxKWTLD.IsEnabled = false;
                YahooCheckBoxPrefix.IsEnabled = false;
                YahooCheckBoxSuffix.IsEnabled = false;
                YahooTxtBoxKeywordsField.IsEnabled = false;
                YahooTxtBoxSearchOperatorsField.IsEnabled = false;
                YahooTxtBoxTLDExtensionField.IsEnabled = false;
                YahooTreePattern.IsEnabled = false;
                YahooTreeSearch.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                for (int i = 0; i < YahooTxtBoxTLDExtensionField.LineCount; i++)
                {
                    YahooTLDExtension = new TLDExtension(YahooTxtBoxTLDExtensionField.GetLineText(i).Trim());
                    YahooTLDExtensionData.Add(YahooTLDExtension);
                }

                for (int i = 0; i < YahooTxtBoxKeywordsField.LineCount; i++)
                {
                    YahooKeywords = new Keywords(YahooTxtBoxKeywordsField.GetLineText(i).Trim());
                    YahooKeywordsData.Add(YahooKeywords);
                }

                for (int i = 0; i < YahooTxtBoxSearchOperatorsField.LineCount; i++)
                {
                    YahooSearchOperators = new SearchOperators(YahooTxtBoxSearchOperatorsField.GetLineText(i).Trim());
                    YahooSearchOperatorsData.Add(YahooSearchOperators);
                }

                Console.WriteLine("Done with uploading user input datas!");
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YahooLblGeneratedDorks.Content = "Please wait, now generating dorks...";
                }));

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    if (YahooCheckBoxSOKWTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < YahooSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < YahooKeywordsData.Count; actKeyword++)
                            {
                                for (int actTLD = 0; actTLD < YahooTLDExtensionData.Count; actTLD++)
                                {
                                    
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{YahooSearchOperatorsData[actSearchOperator].SearchOperator} {(YahooCheckBoxPrefix.IsChecked == true ? $"{YahooTxtBoxPrefix.Text}" : "")}{YahooKeywordsData[actKeyword].Keyword}{(YahooCheckBoxSuffix.IsChecked == true ? $"{YahooTxtBoxSuffix.Text}" : "")} {YahooTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{YahooSearchOperatorsData[actSearchOperator].SearchOperator} {(YahooCheckBoxPrefix.IsChecked == true ? $"{YahooTxtBoxPrefix.Text}" : "")}{YahooKeywordsData[actKeyword].Keyword}{(YahooCheckBoxSuffix.IsChecked == true ? $"{YahooTxtBoxSuffix.Text}" : "")} {YahooTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        YahooLblGeneratedDorks.Visibility = Visibility.Visible;
                                        YahooLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{YahooSearchOperatorsData[actSearchOperator].SearchOperator} {(YahooCheckBoxPrefix.IsChecked == true ? $"{YahooTxtBoxPrefix.Text}" : "")}{YahooKeywordsData[actKeyword].Keyword}{(YahooCheckBoxSuffix.IsChecked == true ? $"{YahooTxtBoxSuffix.Text}" : "")} {YahooTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (YahooCheckBoxSOKW.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < YahooSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < YahooKeywordsData.Count; actKeyword++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{YahooSearchOperatorsData[actSearchOperator].SearchOperator} {(YahooCheckBoxPrefix.IsChecked == true ? $"{YahooTxtBoxPrefix.Text}" : "")}{YahooKeywordsData[actKeyword].Keyword}{(YahooCheckBoxSuffix.IsChecked == true ? $"{YahooTxtBoxSuffix.Text}" : "")}");
                                    ki.WriteLine($"{YahooSearchOperatorsData[actSearchOperator].SearchOperator} {(YahooCheckBoxPrefix.IsChecked == true ? $"{YahooTxtBoxPrefix.Text}" : "")}{YahooKeywordsData[actKeyword].Keyword}{(YahooCheckBoxSuffix.IsChecked == true ? $"{YahooTxtBoxSuffix.Text}" : "")}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    YahooLblGeneratedDorks.Visibility = Visibility.Visible;
                                    YahooLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{YahooSearchOperatorsData[actSearchOperator].SearchOperator} {(YahooCheckBoxPrefix.IsChecked == true ? $"{YahooTxtBoxPrefix.Text}" : "")}{YahooKeywordsData[actKeyword].Keyword}{(YahooCheckBoxSuffix.IsChecked == true ? $"{YahooTxtBoxSuffix.Text}" : "")}");
                                }));
                            }
                        }
                    }

                    if (YahooCheckBoxKWTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < YahooKeywordsData.Count; actKeyword++)
                        {
                            for (int actTLD = 0; actTLD < YahooTLDExtensionData.Count; actTLD++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(YahooCheckBoxPrefix.IsChecked == true ? $"{YahooTxtBoxPrefix.Text}" : "")}{YahooKeywordsData[actKeyword].Keyword}{(YahooCheckBoxSuffix.IsChecked == true ? $"{YahooTxtBoxSuffix.Text}" : "")} {YahooTLDExtensionData[actTLD].TLD}");
                                    ki.WriteLine($"{(YahooCheckBoxPrefix.IsChecked == true ? $"{YahooTxtBoxPrefix.Text}" : "")}{YahooKeywordsData[actKeyword].Keyword}{(YahooCheckBoxSuffix.IsChecked == true ? $"{YahooTxtBoxSuffix.Text}" : "")} {YahooTLDExtensionData[actTLD].TLD}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    YahooLblGeneratedDorks.Visibility = Visibility.Visible;
                                    YahooLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(YahooCheckBoxPrefix.IsChecked == true ? $"{YahooTxtBoxPrefix.Text}" : "")}{YahooKeywordsData[actKeyword].Keyword}{(YahooCheckBoxSuffix.IsChecked == true ? $"{YahooTxtBoxSuffix.Text}" : "")} {YahooTLDExtensionData[actTLD].TLD}");
                                }));
                            }
                        }
                    }
                }));
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YahooBtnGenerate.IsEnabled = true;
                YahooBtnCleantxtBoxKeywordsField.IsEnabled = true;
                YahooBtnCleantxtBoxSearchOperatorsField.IsEnabled = true;
                YahooBtnCleantxtBoxTLDExtensionField.IsEnabled = true;
                YahooBtnAllSelectionDorkPatterns.IsEnabled = true;
                YahooBtnClearSelectionDorkPatterns.IsEnabled = true;
                YahooCheckBoxKWTLD.IsEnabled = true;
                YahooCheckBoxSOKWTLD.IsEnabled = true;
                YahooCheckBoxSOKW.IsEnabled = true;
                YahooCheckBoxPrefix.IsEnabled = true;
                YahooCheckBoxSuffix.IsEnabled = true;
                YahooTxtBoxKeywordsField.IsEnabled = true;
                YahooTxtBoxSearchOperatorsField.IsEnabled = true;
                YahooTxtBoxTLDExtensionField.IsEnabled = true;
                YahooTreePattern.IsEnabled = true;
                YahooTreeSearch.IsEnabled = true;
                YahooBtnOpenSaveFolder.IsEnabled = true;
                YahooBtnOpenSaveFolder.Visibility = Visibility.Visible;
            }));

            ki.Close();
            Console.WriteLine("Kész");
            if ((GeneratedDorks - generatedDorks.Count) >= 1)
                YahooLblGeneratedDorks.Content += $" | Removed duplicates: {GeneratedDorks - generatedDorks.Count}";
            File.Delete($"{rootFolderName}/Yahoo-dorks-{DateNow}.txt");
            StreamWriter ki2 = new StreamWriter($"{rootFolderName}/{generatedDorks.Count}-Yahoo-dorks-{DateNow}.txt");
            foreach (var item in generatedDorks)
            {
                ki2.WriteLine(item);
                ki2.Flush();
            }
            ki2.Close();
        }

        private void YahooBtnClearSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YahooCheckBoxSOKWTLD.IsChecked = false;
                YahooCheckBoxKWTLD.IsChecked = false;
                YahooCheckBoxSOKW.IsChecked = false;
            }));
        }

        private void YahooBtnCleantxtBoxTLDExtensionField_Click(object sender, RoutedEventArgs e)
        {
            YahooTxtBoxTLDExtensionField.Clear();
        }

        private void YahooBtnAllSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YahooCheckBoxSOKWTLD.IsChecked = true;
                YahooCheckBoxKWTLD.IsChecked = true;
                YahooCheckBoxSOKW.IsChecked = true;
            }));
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void YahooLblGeneratedDorks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void YahooBtnOpenSaveFolder_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Process.Start("Yahoo Dorks");
            }));
        }

        private void YahooBtnDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnDorkPatterns.Opacity = 0.70;
        }

        private void YahooBtnDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnDorkPatterns.Opacity = 1;
        }

        private void YahooBtnTLDExtension_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnTLDExtension.Opacity = 0.70;
        }

        private void YahooBtnTLDExtension_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnTLDExtension.Opacity = 1;
        }

        private void YahooBtnKeywords_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnKeywords.Opacity = 0.70;
        }

        private void YahooBtnKeywords_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnKeywords.Opacity = 1;
        }

        private void YahooBtnSearchOperators_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnSearchOperators.Opacity = 0.70;
        }

        private void YahooBtnSearchOperators_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnSearchOperators.Opacity = 1;
        }

        private void YahooBtnClearSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnClearSelectionDorkPatterns.Opacity = 0.70;
        }

        private void YahooBtnClearSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnClearSelectionDorkPatterns.Opacity = 1;
        }

        private void YahooBtnAllSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnAllSelectionDorkPatterns.Opacity = 0.70;
        }

        private void YahooBtnAllSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnAllSelectionDorkPatterns.Opacity = 1;
        }

        private void YahooBtnCleantxtBoxTLDExtensionField_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnCleantxtBoxTLDExtensionField.Opacity = 0.70;
        }

        private void YahooBtnCleantxtBoxTLDExtensionField_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnCleantxtBoxTLDExtensionField.Opacity = 1;
        }

        private void YahooBtnCleantxtBoxKeywordsField_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnCleantxtBoxKeywordsField.Opacity = 0.70;
        }

        private void YahooBtnCleantxtBoxKeywordsField_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnCleantxtBoxKeywordsField.Opacity = 1;
        }

        private void YahooBtnCleantxtBoxSearchOperatorsField_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnCleantxtBoxSearchOperatorsField.Opacity = 0.70;
        }

        private void YahooBtnCleantxtBoxSearchOperatorsField_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnCleantxtBoxSearchOperatorsField.Opacity = 1;
        }

        private void YahooBtnGenerate_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnGenerate.Opacity = 0.70;
        }

        private void YahooBtnGenerate_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnGenerate.Opacity = 1;
        }

        private void YahooBtnOpenSaveFolder_MouseEnter(object sender, MouseEventArgs e)
        {
            YahooBtnOpenSaveFolder.Opacity = 0.70;
        }

        private void YahooBtnOpenSaveFolder_MouseLeave(object sender, MouseEventArgs e)
        {
            YahooBtnOpenSaveFolder.Opacity = 1;
        }
    }
}
