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
    public partial class YippyDorksGeneratorsPage : Window
    {
        static bool YippyIsBtnDorkPatternsClicked = false;
        static bool YippyIsBtnTLDExtensionClicked = false;
        static bool YippyIsBtnKeywordsClicked = false;
        static bool YippyIsBtnPageTypesClicked = false;
        static bool YippyIsBtnSearchOperatorsClicked = false;

        static List<TLDExtension> YippyTLDExtensionData = new List<TLDExtension>();
        static TLDExtension YippyTLDExtension;

        static List<Keywords> YippyKeywordsData = new List<Keywords>();
        static Keywords YippyKeywords;

        static List<PageTypes> YippyPageTypesData = new List<PageTypes>();
        static PageTypes YippyPageTypes;

        static List<SearchOperators> YippySearchOperatorsData = new List<SearchOperators>();
        static SearchOperators YippySearchOperators;

        static string rootFolderName;

        static int GeneratedDorks = 0;
        public YippyDorksGeneratorsPage()
        {
            InitializeComponent();

            CreateDirectory("Yippy Dorks");
        }

        private void CreateDirectory(string folderName)
        {
            rootFolderName = folderName;
            if (!Directory.Exists(rootFolderName))
            {
                Directory.CreateDirectory(rootFolderName);
            }
        }

        private void YippyAppBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void YippyBtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void YippyBtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void YippyBtnDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YippyIsBtnTLDExtensionClicked)
                    YippyBtnTLDExtension.BorderThickness = new Thickness(0);
                if (YippyIsBtnKeywordsClicked)
                    YippyBtnKeywords.BorderThickness = new Thickness(0);
                if (YippyIsBtnPageTypesClicked)
                    YippyBtnPageTypes.BorderThickness = new Thickness(0);
                if (YippyIsBtnSearchOperatorsClicked)
                    YippyBtnSearchOperators.BorderThickness = new Thickness(0);

                YippyBtnDorkPatterns.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YippyBtnDorkPatterns.BorderThickness = new Thickness(2);
                YippyIsBtnDorkPatternsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YippyDorkPatternsUI.Visibility = Visibility.Visible;
                    YippyTLDExtensionUI.Visibility = Visibility.Hidden;
                    YippyKeywordsUI.Visibility = Visibility.Hidden;
                    YippyPageTypesUI.Visibility = Visibility.Hidden;
                    YippySearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YippyBtnTLDExtension_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YippyIsBtnDorkPatternsClicked)
                    YippyBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YippyIsBtnKeywordsClicked)
                    YippyBtnKeywords.BorderThickness = new Thickness(0);
                if (YippyIsBtnPageTypesClicked)
                    YippyBtnPageTypes.BorderThickness = new Thickness(0);
                if (YippyIsBtnSearchOperatorsClicked)
                    YippyBtnSearchOperators.BorderThickness = new Thickness(0);

                YippyBtnTLDExtension.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YippyBtnTLDExtension.BorderThickness = new Thickness(2);
                YippyIsBtnTLDExtensionClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YippyDorkPatternsUI.Visibility = Visibility.Hidden;
                    YippyTLDExtensionUI.Visibility = Visibility.Visible;
                    YippyKeywordsUI.Visibility = Visibility.Hidden;
                    YippyPageTypesUI.Visibility = Visibility.Hidden;
                    YippySearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YippyBtnKeywords_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YippyIsBtnDorkPatternsClicked)
                    YippyBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YippyIsBtnTLDExtensionClicked)
                    YippyBtnTLDExtension.BorderThickness = new Thickness(0);
                if (YippyIsBtnPageTypesClicked)
                    YippyBtnPageTypes.BorderThickness = new Thickness(0);
                if (YippyIsBtnSearchOperatorsClicked)
                    YippyBtnSearchOperators.BorderThickness = new Thickness(0);

                YippyBtnKeywords.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YippyBtnKeywords.BorderThickness = new Thickness(2);
                YippyIsBtnKeywordsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YippyDorkPatternsUI.Visibility = Visibility.Hidden;
                    YippyTLDExtensionUI.Visibility = Visibility.Hidden;
                    YippyKeywordsUI.Visibility = Visibility.Visible;
                    YippyPageTypesUI.Visibility = Visibility.Hidden;
                    YippySearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YippyBtnPageTypes_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YippyIsBtnDorkPatternsClicked)
                    YippyBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YippyIsBtnKeywordsClicked)
                    YippyBtnKeywords.BorderThickness = new Thickness(0);
                if (YippyIsBtnTLDExtensionClicked)
                    YippyBtnTLDExtension.BorderThickness = new Thickness(0);
                if (YippyIsBtnSearchOperatorsClicked)
                    YippyBtnSearchOperators.BorderThickness = new Thickness(0);

                YippyBtnPageTypes.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YippyBtnPageTypes.BorderThickness = new Thickness(2);
                YippyIsBtnPageTypesClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YippyDorkPatternsUI.Visibility = Visibility.Hidden;
                    YippyTLDExtensionUI.Visibility = Visibility.Hidden;
                    YippyKeywordsUI.Visibility = Visibility.Hidden;
                    YippyPageTypesUI.Visibility = Visibility.Visible;
                    YippySearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void YippyBtnSearchOperators_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (YippyIsBtnDorkPatternsClicked)
                    YippyBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (YippyIsBtnKeywordsClicked)
                    YippyBtnKeywords.BorderThickness = new Thickness(0);
                if (YippyIsBtnPageTypesClicked)
                    YippyBtnPageTypes.BorderThickness = new Thickness(0);
                if (YippyIsBtnTLDExtensionClicked)
                    YippyBtnTLDExtension.BorderThickness = new Thickness(0);

                YippyBtnSearchOperators.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                YippyBtnSearchOperators.BorderThickness = new Thickness(2);
                YippyIsBtnSearchOperatorsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YippyDorkPatternsUI.Visibility = Visibility.Hidden;
                    YippyTLDExtensionUI.Visibility = Visibility.Hidden;
                    YippyKeywordsUI.Visibility = Visibility.Hidden;
                    YippyPageTypesUI.Visibility = Visibility.Hidden;
                    YippySearchOperatorsUI.Visibility = Visibility.Visible;
                }));
            }));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private void YippyBtnCleantxtBoxKeywordsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YippyTxtBoxKeywordsField.Clear();
            }));

        }

        private void YippyBtnCleantxtBoxPageTypesField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YippyTxtBoxPageTypesField.Clear();
            }));
        }

        private void YippyBtnCleantxtBoxSearchOperatorsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YippyTxtBoxSearchOperatorsField.Clear();
            }));
        }

        private void YippyBtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string DateNow = $"{DateTime.Now.Year}-{DateTime.Now.Month.ToString("d2")}-{DateTime.Now.Day.ToString("d2")}-{DateTime.Now.Hour.ToString("d2")}-{DateTime.Now.Minute.ToString("d2")}-{DateTime.Now.Second.ToString("d2")}-{DateTime.Now.Millisecond.ToString("d2")}";
            FileStream fajl = new FileStream($"{rootFolderName}/Yippy-dorks-{DateNow}.txt", FileMode.Create);
            StreamWriter ki = new StreamWriter(fajl, Encoding.UTF8);

            HashSet<string> generatedDorks = new HashSet<string>();

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YippyTLDExtensionData.Clear();
                YippyKeywordsData.Clear();
                YippyPageTypesData.Clear();
                YippySearchOperatorsData.Clear();
                YippyLblGeneratedDorks.Content = "Please wait, now generating dorks!";
                GeneratedDorks = 0;
                YippyBtnOpenSaveFolder.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YippyBtnGenerate.IsEnabled = false;
                YippyBtnCleantxtBoxKeywordsField.IsEnabled = false;
                YippyBtnCleantxtBoxPageTypesField.IsEnabled = false;
                YippyBtnCleantxtBoxSearchOperatorsField.IsEnabled = false;
                YippyBtnCleantxtBoxTLDExtensionField.IsEnabled = false;
                YippyBtnAllSelectionDorkPatterns.IsEnabled = false;
                YippyBtnClearSelectionDorkPatterns.IsEnabled = false;
                YippyCheckBoxKWFT.IsEnabled = false;
                YippyCheckBoxKWFTTLD.IsEnabled = false;
                YippyCheckBoxKWTLD.IsEnabled = false;
                YippyCheckBoxSOKWFT.IsEnabled = false;
                YippyCheckBoxSOKWFTTLD.IsEnabled = false;
                YippyCheckBoxSOKWTLD.IsEnabled = false;
                YippyCheckBoxPrefix.IsEnabled = false;
                YippyCheckBoxSuffix.IsEnabled = false;
                YippyTxtBoxKeywordsField.IsEnabled = false;
                YippyTxtBoxPageTypesField.IsEnabled = false;
                YippyTxtBoxSearchOperatorsField.IsEnabled = false;
                YippyTxtBoxTLDExtensionField.IsEnabled = false;
                YippyTreePattern.IsEnabled = false;
                YippyTreeSearch.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                for (int i = 0; i < YippyTxtBoxTLDExtensionField.LineCount; i++)
                {
                    YippyTLDExtension = new TLDExtension(YippyTxtBoxTLDExtensionField.GetLineText(i).Trim());
                    YippyTLDExtensionData.Add(YippyTLDExtension);
                }

                for (int i = 0; i < YippyTxtBoxKeywordsField.LineCount; i++)
                {
                    YippyKeywords = new Keywords(YippyTxtBoxKeywordsField.GetLineText(i).Trim());
                    YippyKeywordsData.Add(YippyKeywords);
                }

                for (int i = 0; i < YippyTxtBoxPageTypesField.LineCount; i++)
                {
                    YippyPageTypes = new PageTypes(YippyTxtBoxPageTypesField.GetLineText(i).Trim());
                    YippyPageTypesData.Add(YippyPageTypes);
                }

                for (int i = 0; i < YippyTxtBoxSearchOperatorsField.LineCount; i++)
                {
                    YippySearchOperators = new SearchOperators(YippyTxtBoxSearchOperatorsField.GetLineText(i).Trim());
                    YippySearchOperatorsData.Add(YippySearchOperators);
                }

                Console.WriteLine("Done with uploading user input datas!");
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    YippyLblGeneratedDorks.Content = "Please wait, now generating dorks...";
                }));

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    if (YippyCheckBoxSOKWFTTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < YippySearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < YippyKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < YippyPageTypesData.Count; actFileType++)
                                {
                                    for (int actTLD = 0; actTLD < YippyTLDExtensionData.Count; actTLD++)
                                    {
                                        Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                        {
                                            Console.WriteLine($"{YippySearchOperatorsData[actSearchOperator].SearchOperator} {(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType} {YippyTLDExtensionData[actTLD].TLD}");
                                            ki.WriteLine($"{YippySearchOperatorsData[actSearchOperator].SearchOperator} {(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType} {YippyTLDExtensionData[actTLD].TLD}");
                                            ki.Flush();

                                            GeneratedDorks++;
                                            YippyLblGeneratedDorks.Visibility = Visibility.Visible;
                                            YippyLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                            generatedDorks.Add($"{YippySearchOperatorsData[actSearchOperator].SearchOperator} {(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType} {YippyTLDExtensionData[actTLD].TLD}");
                                        }));
                                    }
                                }
                            }
                        }
                    }

                    if (YippyCheckBoxSOKWFT.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < YippySearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < YippyKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < YippyPageTypesData.Count; actFileType++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{YippySearchOperatorsData[actSearchOperator].SearchOperator} {(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType}");
                                        ki.WriteLine($"{YippySearchOperatorsData[actSearchOperator].SearchOperator} {(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        YippyLblGeneratedDorks.Visibility = Visibility.Visible;
                                        YippyLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{YippySearchOperatorsData[actSearchOperator].SearchOperator} {(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType}");
                                    }));
                                }
                            }
                        }
                    }

                    if (YippyCheckBoxSOKWTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < YippySearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < YippyKeywordsData.Count; actKeyword++)
                            {
                                for (int actTLD = 0; actTLD < YippyTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{YippySearchOperatorsData[actSearchOperator].SearchOperator} {(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{YippySearchOperatorsData[actSearchOperator].SearchOperator} {(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        YippyLblGeneratedDorks.Visibility = Visibility.Visible;
                                        YippyLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{YippySearchOperatorsData[actSearchOperator].SearchOperator} {(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (YippyCheckBoxKWFTTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < YippyKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < YippyPageTypesData.Count; actFileType++)
                            {
                                for (int actTLD = 0; actTLD < YippyTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType} {YippyTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType} {YippyTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        YippyLblGeneratedDorks.Visibility = Visibility.Visible;
                                        YippyLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType} {YippyTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (YippyCheckBoxKWFT.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < YippyKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < YippyPageTypesData.Count; actFileType++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType}");
                                    ki.WriteLine($"{(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    YippyLblGeneratedDorks.Visibility = Visibility.Visible;
                                    YippyLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyPageTypesData[actFileType].PageType}");
                                }));
                            }
                        }
                    }

                    if (YippyCheckBoxKWTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < YippyKeywordsData.Count; actKeyword++)
                        {
                            for (int actTLD = 0; actTLD < YippyTLDExtensionData.Count; actTLD++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyTLDExtensionData[actTLD].TLD}");
                                    ki.WriteLine($"{(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyTLDExtensionData[actTLD].TLD}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    YippyLblGeneratedDorks.Visibility = Visibility.Visible;
                                    YippyLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(YippyCheckBoxPrefix.IsChecked == true ? $"{YippyTxtBoxPrefix.Text}" : "")}{YippyKeywordsData[actKeyword].Keyword}{(YippyCheckBoxSuffix.IsChecked == true ? $"{YippyTxtBoxSuffix.Text}" : "")} {YippyTLDExtensionData[actTLD].TLD}");
                                }));
                            }
                        }
                    }
                }));
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YippyBtnGenerate.IsEnabled = true;
                YippyBtnCleantxtBoxKeywordsField.IsEnabled = true;
                YippyBtnCleantxtBoxPageTypesField.IsEnabled = true;
                YippyBtnCleantxtBoxSearchOperatorsField.IsEnabled = true;
                YippyBtnCleantxtBoxTLDExtensionField.IsEnabled = true;
                YippyBtnAllSelectionDorkPatterns.IsEnabled = true;
                YippyBtnClearSelectionDorkPatterns.IsEnabled = true;
                YippyCheckBoxKWFT.IsEnabled = true;
                YippyCheckBoxKWFTTLD.IsEnabled = true;
                YippyCheckBoxKWTLD.IsEnabled = true;
                YippyCheckBoxSOKWFT.IsEnabled = true;
                YippyCheckBoxSOKWFTTLD.IsEnabled = true;
                YippyCheckBoxSOKWTLD.IsEnabled = true;
                YippyCheckBoxPrefix.IsEnabled = true;
                YippyCheckBoxSuffix.IsEnabled = true;
                YippyTxtBoxKeywordsField.IsEnabled = true;
                YippyTxtBoxPageTypesField.IsEnabled = true;
                YippyTxtBoxSearchOperatorsField.IsEnabled = true;
                YippyTxtBoxTLDExtensionField.IsEnabled = true;
                YippyTreePattern.IsEnabled = true;
                YippyTreeSearch.IsEnabled = true;
                YippyBtnOpenSaveFolder.IsEnabled = true;
                YippyBtnOpenSaveFolder.Visibility = Visibility.Visible;
            }));

            ki.Close();
            Console.WriteLine("Kész");
            if ((GeneratedDorks - generatedDorks.Count) >= 1)
                YippyLblGeneratedDorks.Content += $" | Removed duplicates: {GeneratedDorks - generatedDorks.Count}";
            File.Delete($"{rootFolderName}/Yippy-dorks-{DateNow}.txt");
            StreamWriter ki2 = new StreamWriter($"{rootFolderName}/{generatedDorks.Count}-Yippy-dorks-{DateNow}.txt");
            foreach (var item in generatedDorks)
            {
                ki2.WriteLine(item);
                ki2.Flush();
            }
            ki2.Close();
            fajl.Close();
        }

        private void YippyBtnClearSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YippyCheckBoxKWFT.IsChecked = false;
                YippyCheckBoxKWFTTLD.IsChecked = false;
                YippyCheckBoxSOKWFT.IsChecked = false;
                YippyCheckBoxSOKWFTTLD.IsChecked = false;
                YippyCheckBoxSOKWTLD.IsChecked = false;
                YippyCheckBoxKWTLD.IsChecked = false;
            }));
        }

        private void YippyBtnCleantxtBoxTLDExtensionField_Click(object sender, RoutedEventArgs e)
        {
            YippyTxtBoxTLDExtensionField.Clear();
        }

        private void YippyBtnAllSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                YippyCheckBoxKWFT.IsChecked = true;
                YippyCheckBoxKWFTTLD.IsChecked = true;
                YippyCheckBoxSOKWFT.IsChecked = true;
                YippyCheckBoxSOKWFTTLD.IsChecked = true;
                YippyCheckBoxSOKWTLD.IsChecked = true;
                YippyCheckBoxKWTLD.IsChecked = true;
            }));
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void YippyLblGeneratedDorks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void YippyBtnOpenSaveFolder_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Process.Start("Yippy Dorks");
            }));
        }

        private void YippyBtnDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnDorkPatterns.Opacity = 0.70;
        }

        private void YippyBtnDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnDorkPatterns.Opacity = 1;
        }

        private void YippyBtnTLDExtension_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnTLDExtension.Opacity = 0.70;
        }

        private void YippyBtnTLDExtension_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnTLDExtension.Opacity = 1;
        }

        private void YippyBtnKeywords_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnKeywords.Opacity = 0.70;
        }

        private void YippyBtnKeywords_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnKeywords.Opacity = 1;
        }

        private void YippyBtnPageTypes_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnPageTypes.Opacity = 0.70;
        }

        private void YippyBtnPageTypes_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnPageTypes.Opacity = 1;
        }

        private void YippyBtnSearchOperators_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnSearchOperators.Opacity = 0.70;
        }

        private void YippyBtnSearchOperators_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnSearchOperators.Opacity = 1;
        }

        private void YippyBtnClearSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnClearSelectionDorkPatterns.Opacity = 0.70;
        }

        private void YippyBtnClearSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnClearSelectionDorkPatterns.Opacity = 1;
        }

        private void YippyBtnAllSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnAllSelectionDorkPatterns.Opacity = 0.70;
        }

        private void YippyBtnAllSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnAllSelectionDorkPatterns.Opacity = 1;
        }

        private void YippyBtnCleantxtBoxTLDExtensionField_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnCleantxtBoxTLDExtensionField.Opacity = 0.70;
        }

        private void YippyBtnCleantxtBoxTLDExtensionField_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnCleantxtBoxTLDExtensionField.Opacity = 1;
        }

        private void YippyBtnCleantxtBoxKeywordsField_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnCleantxtBoxKeywordsField.Opacity = 0.70;
        }

        private void YippyBtnCleantxtBoxKeywordsField_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnCleantxtBoxKeywordsField.Opacity = 1;
        }

        private void YippyBtnCleantxtBoxPageTypesField_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnCleantxtBoxPageTypesField.Opacity = 0.70;
        }

        private void YippyBtnCleantxtBoxPageTypesField_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnCleantxtBoxPageTypesField.Opacity = 1;
        }

        private void YippyBtnCleantxtBoxSearchOperatorsField_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnCleantxtBoxSearchOperatorsField.Opacity = 0.70;
        }

        private void YippyBtnCleantxtBoxSearchOperatorsField_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnCleantxtBoxSearchOperatorsField.Opacity = 1;
        }

        private void YippyBtnGenerate_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnGenerate.Opacity = 0.70;
        }

        private void YippyBtnGenerate_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnGenerate.Opacity = 1;
        }

        private void YippyBtnOpenSaveFolder_MouseEnter(object sender, MouseEventArgs e)
        {
            YippyBtnOpenSaveFolder.Opacity = 0.70;
        }

        private void YippyBtnOpenSaveFolder_MouseLeave(object sender, MouseEventArgs e)
        {
            YippyBtnOpenSaveFolder.Opacity = 1;
        }
    }
}
