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
    public partial class YandexDorksGeneratorsPage : Window
    {
        static bool YandexIsBtnDorkPatternsClicked = false;
        static bool YandexIsBtnTLDExtensionClicked = false;
        static bool YandexIsBtnKeywordsClicked = false;
        static bool YandexIsBtnPageTypesClicked = false;
        static bool YandexIsBtnSearchOperatorsClicked = false;

        static List<TLDExtension> YandexTLDExtensionData = new List<TLDExtension>();
        static TLDExtension YandexTLDExtension;

        static List<Keywords> YandexKeywordsData = new List<Keywords>();
        static Keywords YandexKeywords;

        static List<PageTypes> YandexPageTypesData = new List<PageTypes>();
        static PageTypes YandexPageTypes;

        static List<SearchOperators> YandexSearchOperatorsData = new List<SearchOperators>();
        static SearchOperators YandexSearchOperators;

        static string rootFolderName;

        static int GeneratedDorks = 0;
        public YandexDorksGeneratorsPage()
        {
            InitializeComponent();

            CreateDirectory("Yandex Dorks");
        }

        private void CreateDirectory(string folderName)
        {
            rootFolderName = folderName;
            if (!Directory.Exists(rootFolderName))
            {
                Directory.CreateDirectory(rootFolderName);
            }
        }

        private void YandexAppBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void YandexBtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void YandexBtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void YandexBtnDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YandexIsBtnTLDExtensionClicked)
                    YandexBtnTLDExtension.BorderThickness = new Thickness(0);
                if (YandexIsBtnKeywordsClicked)
                    YandexBtnKeywords.BorderThickness = new Thickness(0);
                if (YandexIsBtnPageTypesClicked)
                    YandexBtnPageTypes.BorderThickness = new Thickness(0);
                if (YandexIsBtnSearchOperatorsClicked)
                    YandexBtnSearchOperators.BorderThickness = new Thickness(0);

                YandexBtnDorkPatterns.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YandexBtnDorkPatterns.BorderThickness = new Thickness(2);
                YandexIsBtnDorkPatternsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YandexDorkPatternsUI.Visibility = Visibility.Visible;
                    YandexTLDExtensionUI.Visibility = Visibility.Hidden;
                    YandexKeywordsUI.Visibility = Visibility.Hidden;
                    YandexPageTypesUI.Visibility = Visibility.Hidden;
                    YandexSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YandexBtnTLDExtension_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YandexIsBtnDorkPatternsClicked)
                    YandexBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YandexIsBtnKeywordsClicked)
                    YandexBtnKeywords.BorderThickness = new Thickness(0);
                if (YandexIsBtnPageTypesClicked)
                    YandexBtnPageTypes.BorderThickness = new Thickness(0);
                if (YandexIsBtnSearchOperatorsClicked)
                    YandexBtnSearchOperators.BorderThickness = new Thickness(0);

                YandexBtnTLDExtension.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YandexBtnTLDExtension.BorderThickness = new Thickness(2);
                YandexIsBtnTLDExtensionClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YandexDorkPatternsUI.Visibility = Visibility.Hidden;
                    YandexTLDExtensionUI.Visibility = Visibility.Visible;
                    YandexKeywordsUI.Visibility = Visibility.Hidden;
                    YandexPageTypesUI.Visibility = Visibility.Hidden;
                    YandexSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YandexBtnKeywords_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YandexIsBtnDorkPatternsClicked)
                    YandexBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YandexIsBtnTLDExtensionClicked)
                    YandexBtnTLDExtension.BorderThickness = new Thickness(0);
                if (YandexIsBtnPageTypesClicked)
                    YandexBtnPageTypes.BorderThickness = new Thickness(0);
                if (YandexIsBtnSearchOperatorsClicked)
                    YandexBtnSearchOperators.BorderThickness = new Thickness(0);

                YandexBtnKeywords.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YandexBtnKeywords.BorderThickness = new Thickness(2);
                YandexIsBtnKeywordsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YandexDorkPatternsUI.Visibility = Visibility.Hidden;
                    YandexTLDExtensionUI.Visibility = Visibility.Hidden;
                    YandexKeywordsUI.Visibility = Visibility.Visible;
                    YandexPageTypesUI.Visibility = Visibility.Hidden;
                    YandexSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YandexBtnPageTypes_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YandexIsBtnDorkPatternsClicked)
                    YandexBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YandexIsBtnKeywordsClicked)
                    YandexBtnKeywords.BorderThickness = new Thickness(0);
                if (YandexIsBtnTLDExtensionClicked)
                    YandexBtnTLDExtension.BorderThickness = new Thickness(0);
                if (YandexIsBtnSearchOperatorsClicked)
                    YandexBtnSearchOperators.BorderThickness = new Thickness(0);

                YandexBtnPageTypes.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YandexBtnPageTypes.BorderThickness = new Thickness(2);
                YandexIsBtnPageTypesClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YandexDorkPatternsUI.Visibility = Visibility.Hidden;
                    YandexTLDExtensionUI.Visibility = Visibility.Hidden;
                    YandexKeywordsUI.Visibility = Visibility.Hidden;
                    YandexPageTypesUI.Visibility = Visibility.Visible;
                    YandexSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YandexBtnSearchOperators_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YandexIsBtnDorkPatternsClicked)
                    YandexBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YandexIsBtnKeywordsClicked)
                    YandexBtnKeywords.BorderThickness = new Thickness(0);
                if (YandexIsBtnPageTypesClicked)
                    YandexBtnPageTypes.BorderThickness = new Thickness(0);
                if (YandexIsBtnTLDExtensionClicked)
                    YandexBtnTLDExtension.BorderThickness = new Thickness(0);

                YandexBtnSearchOperators.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YandexBtnSearchOperators.BorderThickness = new Thickness(2);
                YandexIsBtnSearchOperatorsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YandexDorkPatternsUI.Visibility = Visibility.Hidden;
                    YandexTLDExtensionUI.Visibility = Visibility.Hidden;
                    YandexKeywordsUI.Visibility = Visibility.Hidden;
                    YandexPageTypesUI.Visibility = Visibility.Hidden;
                    YandexSearchOperatorsUI.Visibility = Visibility.Visible;
                }));
            }));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private void YandexBtnCleantxtBoxKeywordsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YandexTxtBoxKeywordsField.Clear();
            }));

        }

        private void YandexBtnCleantxtBoxPageTypesField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YandexTxtBoxPageTypesField.Clear();
            }));
        }

        private void YandexBtnCleantxtBoxSearchOperatorsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YandexTxtBoxSearchOperatorsField.Clear();
            }));
        }

        private void YandexBtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string DateNow = $"{DateTime.Now.Year}-{DateTime.Now.Month.ToString("d2")}-{DateTime.Now.Day.ToString("d2")}-{DateTime.Now.Hour.ToString("d2")}-{DateTime.Now.Minute.ToString("d2")}-{DateTime.Now.Second.ToString("d2")}-{DateTime.Now.Millisecond.ToString("d2")}";
            FileStream fajl = new FileStream($"{rootFolderName}/Yandex-dorks-{DateNow}.txt", FileMode.Create);
            StreamWriter ki = new StreamWriter(fajl, Encoding.UTF8);

            HashSet<string> generatedDorks = new HashSet<string>();

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YandexTLDExtensionData.Clear();
                YandexKeywordsData.Clear();
                YandexPageTypesData.Clear();
                YandexSearchOperatorsData.Clear();
                YandexLblGeneratedDorks.Content = "Please wait, now generating dorks!";
                GeneratedDorks = 0;
                YandexBtnOpenSaveFolder.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YandexBtnGenerate.IsEnabled = false;
                YandexBtnCleantxtBoxKeywordsField.IsEnabled = false;
                YandexBtnCleantxtBoxPageTypesField.IsEnabled = false;
                YandexBtnCleantxtBoxSearchOperatorsField.IsEnabled = false;
                YandexBtnCleantxtBoxTLDExtensionField.IsEnabled = false;
                YandexBtnAllSelectionDorkPatterns.IsEnabled = false;
                YandexBtnClearSelectionDorkPatterns.IsEnabled = false;
                YandexCheckBoxKWFT.IsEnabled = false;
                YandexCheckBoxKWFTTLD.IsEnabled = false;
                YandexCheckBoxKWTLD.IsEnabled = false;
                YandexCheckBoxSOKWFT.IsEnabled = false;
                YandexCheckBoxSOKWFTTLD.IsEnabled = false;
                YandexCheckBoxSOKWTLD.IsEnabled = false;
                YandexCheckBoxPrefix.IsEnabled = false;
                YandexCheckBoxSuffix.IsEnabled = false;
                YandexTxtBoxKeywordsField.IsEnabled = false;
                YandexTxtBoxPageTypesField.IsEnabled = false;
                YandexTxtBoxSearchOperatorsField.IsEnabled = false;
                YandexTxtBoxTLDExtensionField.IsEnabled = false;
                YandexTreePattern.IsEnabled = false;
                YandexTreeSearch.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                for (int i = 0; i < YandexTxtBoxTLDExtensionField.LineCount; i++)
                {
                    YandexTLDExtension = new TLDExtension(YandexTxtBoxTLDExtensionField.GetLineText(i).Trim());
                    YandexTLDExtensionData.Add(YandexTLDExtension);
                }

                for (int i = 0; i < YandexTxtBoxKeywordsField.LineCount; i++)
                {
                    YandexKeywords = new Keywords(YandexTxtBoxKeywordsField.GetLineText(i).Trim());
                    YandexKeywordsData.Add(YandexKeywords);
                }

                for (int i = 0; i < YandexTxtBoxPageTypesField.LineCount; i++)
                {
                    YandexPageTypes = new PageTypes(YandexTxtBoxPageTypesField.GetLineText(i).Trim());
                    YandexPageTypesData.Add(YandexPageTypes);
                }

                for (int i = 0; i < YandexTxtBoxSearchOperatorsField.LineCount; i++)
                {
                    YandexSearchOperators = new SearchOperators(YandexTxtBoxSearchOperatorsField.GetLineText(i).Trim());
                    YandexSearchOperatorsData.Add(YandexSearchOperators);
                }

                Console.WriteLine("Done with uploading user input datas!");
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YandexLblGeneratedDorks.Content = "Please wait, now generating dorks...";
                }));

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    if (YandexCheckBoxSOKWFTTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < YandexSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < YandexKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < YandexPageTypesData.Count; actFileType++)
                                {
                                    for (int actTLD = 0; actTLD < YandexTLDExtensionData.Count; actTLD++)
                                    {
                                        Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                        {
                                            Console.WriteLine($"{YandexSearchOperatorsData[actSearchOperator].SearchOperator} {(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType} {YandexTLDExtensionData[actTLD].TLD}");
                                            ki.WriteLine($"{YandexSearchOperatorsData[actSearchOperator].SearchOperator} {(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType} {YandexTLDExtensionData[actTLD].TLD}");
                                            ki.Flush();

                                            GeneratedDorks++;
                                            YandexLblGeneratedDorks.Visibility = Visibility.Visible;
                                            YandexLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                            generatedDorks.Add($"{YandexSearchOperatorsData[actSearchOperator].SearchOperator} {(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType} {YandexTLDExtensionData[actTLD].TLD}");
                                        }));
                                    }
                                }
                            }
                        }
                    }

                    if (YandexCheckBoxSOKWFT.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < YandexSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < YandexKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < YandexPageTypesData.Count; actFileType++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{YandexSearchOperatorsData[actSearchOperator].SearchOperator} {(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType}");
                                        ki.WriteLine($"{YandexSearchOperatorsData[actSearchOperator].SearchOperator} {(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        YandexLblGeneratedDorks.Visibility = Visibility.Visible;
                                        YandexLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{YandexSearchOperatorsData[actSearchOperator].SearchOperator} {(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType}");
                                    }));
                                }
                            }
                        }
                    }

                    if (YandexCheckBoxSOKWTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < YandexSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < YandexKeywordsData.Count; actKeyword++)
                            {
                                for (int actTLD = 0; actTLD < YandexTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{YandexSearchOperatorsData[actSearchOperator].SearchOperator} {(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{YandexSearchOperatorsData[actSearchOperator].SearchOperator} {(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        YandexLblGeneratedDorks.Visibility = Visibility.Visible;
                                        YandexLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{YandexSearchOperatorsData[actSearchOperator].SearchOperator} {(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (YandexCheckBoxKWFTTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < YandexKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < YandexPageTypesData.Count; actFileType++)
                            {
                                for (int actTLD = 0; actTLD < YandexTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType} {YandexTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType} {YandexTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        YandexLblGeneratedDorks.Visibility = Visibility.Visible;
                                        YandexLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType} {YandexTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (YandexCheckBoxKWFT.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < YandexKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < YandexPageTypesData.Count; actFileType++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType}");
                                    ki.WriteLine($"{(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    YandexLblGeneratedDorks.Visibility = Visibility.Visible;
                                    YandexLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexPageTypesData[actFileType].PageType}");
                                }));
                            }
                        }
                    }

                    if (YandexCheckBoxKWTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < YandexKeywordsData.Count; actKeyword++)
                        {
                            for (int actTLD = 0; actTLD < YandexTLDExtensionData.Count; actTLD++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexTLDExtensionData[actTLD].TLD}");
                                    ki.WriteLine($"{(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexTLDExtensionData[actTLD].TLD}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    YandexLblGeneratedDorks.Visibility = Visibility.Visible;
                                    YandexLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(YandexCheckBoxPrefix.IsChecked == true ? $"{YandexTxtBoxPrefix.Text}" : "")}{YandexKeywordsData[actKeyword].Keyword}{(YandexCheckBoxSuffix.IsChecked == true ? $"{YandexTxtBoxSuffix.Text}" : "")} {YandexTLDExtensionData[actTLD].TLD}");
                                }));
                            }
                        }
                    }
                }));
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YandexBtnGenerate.IsEnabled = true;
                YandexBtnCleantxtBoxKeywordsField.IsEnabled = true;
                YandexBtnCleantxtBoxPageTypesField.IsEnabled = true;
                YandexBtnCleantxtBoxSearchOperatorsField.IsEnabled = true;
                YandexBtnCleantxtBoxTLDExtensionField.IsEnabled = true;
                YandexBtnAllSelectionDorkPatterns.IsEnabled = true;
                YandexBtnClearSelectionDorkPatterns.IsEnabled = true;
                YandexCheckBoxKWFT.IsEnabled = true;
                YandexCheckBoxKWFTTLD.IsEnabled = true;
                YandexCheckBoxKWTLD.IsEnabled = true;
                YandexCheckBoxSOKWFT.IsEnabled = true;
                YandexCheckBoxSOKWFTTLD.IsEnabled = true;
                YandexCheckBoxSOKWTLD.IsEnabled = true;
                YandexCheckBoxPrefix.IsEnabled = true;
                YandexCheckBoxSuffix.IsEnabled = true;
                YandexTxtBoxKeywordsField.IsEnabled = true;
                YandexTxtBoxPageTypesField.IsEnabled = true;
                YandexTxtBoxSearchOperatorsField.IsEnabled = true;
                YandexTxtBoxTLDExtensionField.IsEnabled = true;
                YandexTreePattern.IsEnabled = true;
                YandexTreeSearch.IsEnabled = true;
                YandexBtnOpenSaveFolder.IsEnabled = true;
                YandexBtnOpenSaveFolder.Visibility = Visibility.Visible;
            }));

            ki.Close();
            Console.WriteLine("Kész");
            if ((GeneratedDorks - generatedDorks.Count) >= 1)
                YandexLblGeneratedDorks.Content += $" | Removed duplicates: {GeneratedDorks - generatedDorks.Count}";
            File.Delete($"{rootFolderName}/Yandex-dorks-{DateNow}.txt");
            StreamWriter ki2 = new StreamWriter($"{rootFolderName}/{generatedDorks.Count}-Yandex-dorks-{DateNow}.txt");
            foreach (var item in generatedDorks)
            {
                ki2.WriteLine(item);
                ki2.Flush();
            }
            ki2.Close();
            fajl.Close();
        }

        private void YandexBtnClearSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YandexCheckBoxKWFT.IsChecked = false;
                YandexCheckBoxKWFTTLD.IsChecked = false;
                YandexCheckBoxSOKWFT.IsChecked = false;
                YandexCheckBoxSOKWFTTLD.IsChecked = false;
                YandexCheckBoxSOKWTLD.IsChecked = false;
                YandexCheckBoxKWTLD.IsChecked = false;
            }));
        }

        private void YandexBtnCleantxtBoxTLDExtensionField_Click(object sender, RoutedEventArgs e)
        {
            YandexTxtBoxTLDExtensionField.Clear();
        }

        private void YandexBtnAllSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YandexCheckBoxKWFT.IsChecked = true;
                YandexCheckBoxKWFTTLD.IsChecked = true;
                YandexCheckBoxSOKWFT.IsChecked = true;
                YandexCheckBoxSOKWFTTLD.IsChecked = true;
                YandexCheckBoxSOKWTLD.IsChecked = true;
                YandexCheckBoxKWTLD.IsChecked = true;
            }));
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void YandexLblGeneratedDorks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void YandexBtnOpenSaveFolder_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Process.Start("Yandex Dorks");
            }));
        }

        private void YandexBtnDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnDorkPatterns.Opacity = 0.70;
        }

        private void YandexBtnDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnDorkPatterns.Opacity = 1;
        }

        private void YandexBtnTLDExtension_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnTLDExtension.Opacity = 0.70;
        }

        private void YandexBtnTLDExtension_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnTLDExtension.Opacity = 1;
        }

        private void YandexBtnKeywords_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnKeywords.Opacity = 0.70;
        }

        private void YandexBtnKeywords_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnKeywords.Opacity = 1;
        }

        private void YandexBtnPageTypes_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnPageTypes.Opacity = 0.70;
        }

        private void YandexBtnPageTypes_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnPageTypes.Opacity = 1;
        }

        private void YandexBtnSearchOperators_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnSearchOperators.Opacity = 0.70;
        }

        private void YandexBtnSearchOperators_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnSearchOperators.Opacity = 1;
        }

        private void YandexBtnClearSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnClearSelectionDorkPatterns.Opacity = 0.70;
        }

        private void YandexBtnClearSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnClearSelectionDorkPatterns.Opacity = 1;
        }

        private void YandexBtnAllSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnAllSelectionDorkPatterns.Opacity = 0.70;
        }

        private void YandexBtnAllSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnAllSelectionDorkPatterns.Opacity = 1;
        }

        private void YandexBtnCleantxtBoxTLDExtensionField_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnCleantxtBoxTLDExtensionField.Opacity = 0.70;
        }

        private void YandexBtnCleantxtBoxTLDExtensionField_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnCleantxtBoxTLDExtensionField.Opacity = 1;
        }

        private void YandexBtnCleantxtBoxKeywordsField_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnCleantxtBoxKeywordsField.Opacity = 0.70;
        }

        private void YandexBtnCleantxtBoxKeywordsField_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnCleantxtBoxKeywordsField.Opacity = 1;
        }

        private void YandexBtnCleantxtBoxPageTypesField_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnCleantxtBoxPageTypesField.Opacity = 0.70;
        }

        private void YandexBtnCleantxtBoxPageTypesField_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnCleantxtBoxPageTypesField.Opacity = 1;
        }

        private void YandexBtnCleantxtBoxSearchOperatorsField_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnCleantxtBoxSearchOperatorsField.Opacity = 0.70;
        }

        private void YandexBtnCleantxtBoxSearchOperatorsField_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnCleantxtBoxSearchOperatorsField.Opacity = 1;
        }

        private void YandexBtnGenerate_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnGenerate.Opacity = 0.70;
        }

        private void YandexBtnGenerate_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnGenerate.Opacity = 1;
        }

        private void YandexBtnOpenSaveFolder_MouseEnter(object sender, MouseEventArgs e)
        {
            YandexBtnOpenSaveFolder.Opacity = 0.70;
        }

        private void YandexBtnOpenSaveFolder_MouseLeave(object sender, MouseEventArgs e)
        {
            YandexBtnOpenSaveFolder.Opacity = 1;
        }
    }
}
