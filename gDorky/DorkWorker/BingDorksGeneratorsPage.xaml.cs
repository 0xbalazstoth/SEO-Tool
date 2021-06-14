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
    public partial class BingDorksGeneratorsPage : Window
    {
        static bool BingIsBtnDorkPatternsClicked = false;
        static bool BingIsBtnTLDExtensionClicked = false;
        static bool BingIsBtnKeywordsClicked = false;
        static bool BingIsBtnPageTypesClicked = false;
        static bool BingIsBtnSearchOperatorsClicked = false;

        static List<TLDExtension> BingTLDExtensionData = new List<TLDExtension>();
        static TLDExtension BingTLDExtension;

        static List<Keywords> BingKeywordsData = new List<Keywords>();
        static Keywords BingKeywords;

        static List<PageTypes> BingPageTypesData = new List<PageTypes>();
        static PageTypes BingPageTypes;

        static List<SearchOperators> BingSearchOperatorsData = new List<SearchOperators>();
        static SearchOperators BingSearchOperators;

        static string rootFolderName;

        static int GeneratedDorks = 0;
        public BingDorksGeneratorsPage()
        {
            InitializeComponent();

            CreateDirectory("Bing Dorks");
        }

        private void CreateDirectory(string folderName)
        {
            rootFolderName = folderName;
            if (!Directory.Exists(rootFolderName))
            {
                Directory.CreateDirectory(rootFolderName);
            }
        }

        private void BingAppBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BingBtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BingBtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BingBtnDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (BingIsBtnTLDExtensionClicked)
                    BingBtnTLDExtension.BorderThickness = new Thickness(0);
                if (BingIsBtnKeywordsClicked)
                    BingBtnKeywords.BorderThickness = new Thickness(0);
                if (BingIsBtnPageTypesClicked)
                    BingBtnPageTypes.BorderThickness = new Thickness(0);
                if (BingIsBtnSearchOperatorsClicked)
                    BingBtnSearchOperators.BorderThickness = new Thickness(0);

                BingBtnDorkPatterns.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                BingBtnDorkPatterns.BorderThickness = new Thickness(2);
                BingIsBtnDorkPatternsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    BingDorkPatternsUI.Visibility = Visibility.Visible;
                    BingTLDExtensionUI.Visibility = Visibility.Hidden;
                    BingKeywordsUI.Visibility = Visibility.Hidden;
                    BingPageTypesUI.Visibility = Visibility.Hidden;
                    BingSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void BingBtnTLDExtension_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (BingIsBtnDorkPatternsClicked)
                    BingBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (BingIsBtnKeywordsClicked)
                    BingBtnKeywords.BorderThickness = new Thickness(0);
                if (BingIsBtnPageTypesClicked)
                    BingBtnPageTypes.BorderThickness = new Thickness(0);
                if (BingIsBtnSearchOperatorsClicked)
                    BingBtnSearchOperators.BorderThickness = new Thickness(0);

                BingBtnTLDExtension.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                BingBtnTLDExtension.BorderThickness = new Thickness(2);
                BingIsBtnTLDExtensionClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    BingDorkPatternsUI.Visibility = Visibility.Hidden;
                    BingTLDExtensionUI.Visibility = Visibility.Visible;
                    BingKeywordsUI.Visibility = Visibility.Hidden;
                    BingPageTypesUI.Visibility = Visibility.Hidden;
                    BingSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void BingBtnKeywords_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (BingIsBtnDorkPatternsClicked)
                    BingBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (BingIsBtnTLDExtensionClicked)
                    BingBtnTLDExtension.BorderThickness = new Thickness(0);
                if (BingIsBtnPageTypesClicked)
                    BingBtnPageTypes.BorderThickness = new Thickness(0);
                if (BingIsBtnSearchOperatorsClicked)
                    BingBtnSearchOperators.BorderThickness = new Thickness(0);

                BingBtnKeywords.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                BingBtnKeywords.BorderThickness = new Thickness(2);
                BingIsBtnKeywordsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    BingDorkPatternsUI.Visibility = Visibility.Hidden;
                    BingTLDExtensionUI.Visibility = Visibility.Hidden;
                    BingKeywordsUI.Visibility = Visibility.Visible;
                    BingPageTypesUI.Visibility = Visibility.Hidden;
                    BingSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void BingBtnPageTypes_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (BingIsBtnDorkPatternsClicked)
                    BingBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (BingIsBtnKeywordsClicked)
                    BingBtnKeywords.BorderThickness = new Thickness(0);
                if (BingIsBtnTLDExtensionClicked)
                    BingBtnTLDExtension.BorderThickness = new Thickness(0);
                if (BingIsBtnSearchOperatorsClicked)
                    BingBtnSearchOperators.BorderThickness = new Thickness(0);

                BingBtnPageTypes.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                BingBtnPageTypes.BorderThickness = new Thickness(2);
                BingIsBtnPageTypesClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    BingDorkPatternsUI.Visibility = Visibility.Hidden;
                    BingTLDExtensionUI.Visibility = Visibility.Hidden;
                    BingKeywordsUI.Visibility = Visibility.Hidden;
                    BingPageTypesUI.Visibility = Visibility.Visible;
                    BingSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void BingBtnSearchOperators_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (BingIsBtnDorkPatternsClicked)
                    BingBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (BingIsBtnKeywordsClicked)
                    BingBtnKeywords.BorderThickness = new Thickness(0);
                if (BingIsBtnPageTypesClicked)
                    BingBtnPageTypes.BorderThickness = new Thickness(0);
                if (BingIsBtnTLDExtensionClicked)
                    BingBtnTLDExtension.BorderThickness = new Thickness(0);

                BingBtnSearchOperators.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                BingBtnSearchOperators.BorderThickness = new Thickness(2);
                BingIsBtnSearchOperatorsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    BingDorkPatternsUI.Visibility = Visibility.Hidden;
                    BingTLDExtensionUI.Visibility = Visibility.Hidden;
                    BingKeywordsUI.Visibility = Visibility.Hidden;
                    BingPageTypesUI.Visibility = Visibility.Hidden;
                    BingSearchOperatorsUI.Visibility = Visibility.Visible;
                }));
            }));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private void BingBtnCleantxtBoxKeywordsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                BingTxtBoxKeywordsField.Clear();
            }));

        }

        private void BingBtnCleantxtBoxPageTypesField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                BingTxtBoxPageTypesField.Clear();
            }));
        }

        private void BingBtnCleantxtBoxSearchOperatorsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                BingTxtBoxSearchOperatorsField.Clear();
            }));
        }

        private void BingBtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string DateNow = $"{DateTime.Now.Year}-{DateTime.Now.Month.ToString("d2")}-{DateTime.Now.Day.ToString("d2")}-{DateTime.Now.Hour.ToString("d2")}-{DateTime.Now.Minute.ToString("d2")}-{DateTime.Now.Second.ToString("d2")}-{DateTime.Now.Millisecond.ToString("d2")}";
            FileStream fajl = new FileStream($"{rootFolderName}/Bing-dorks-{DateNow}.txt", FileMode.Create);
            StreamWriter ki = new StreamWriter(fajl, Encoding.UTF8);

            HashSet<string> generatedDorks = new HashSet<string>();

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                BingTLDExtensionData.Clear();
                BingKeywordsData.Clear();
                BingPageTypesData.Clear();
                BingSearchOperatorsData.Clear();
                BingLblGeneratedDorks.Content = "Please wait, now generating dorks!";
                GeneratedDorks = 0;
                BingBtnOpenSaveFolder.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                BingBtnGenerate.IsEnabled = false;
                BingBtnCleantxtBoxKeywordsField.IsEnabled = false;
                BingBtnCleantxtBoxPageTypesField.IsEnabled = false;
                BingBtnCleantxtBoxSearchOperatorsField.IsEnabled = false;
                BingBtnCleantxtBoxTLDExtensionField.IsEnabled = false;
                BingBtnAllSelectionDorkPatterns.IsEnabled = false;
                BingBtnClearSelectionDorkPatterns.IsEnabled = false;
                BingCheckBoxKWFT.IsEnabled = false;
                BingCheckBoxKWFTTLD.IsEnabled = false;
                BingCheckBoxKWTLD.IsEnabled = false;
                BingCheckBoxSOKWFT.IsEnabled = false;
                BingCheckBoxSOKWFTTLD.IsEnabled = false;
                BingCheckBoxSOKWTLD.IsEnabled = false;
                BingCheckBoxPrefix.IsEnabled = false;
                BingCheckBoxSuffix.IsEnabled = false;
                BingTxtBoxKeywordsField.IsEnabled = false;
                BingTxtBoxPageTypesField.IsEnabled = false;
                BingTxtBoxSearchOperatorsField.IsEnabled = false;
                BingTxtBoxTLDExtensionField.IsEnabled = false;
                BingTreePattern.IsEnabled = false;
                BingTreeSearch.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                for (int i = 0; i < BingTxtBoxTLDExtensionField.LineCount; i++)
                {
                    BingTLDExtension = new TLDExtension(BingTxtBoxTLDExtensionField.GetLineText(i).Trim());
                    BingTLDExtensionData.Add(BingTLDExtension);
                }

                for (int i = 0; i < BingTxtBoxKeywordsField.LineCount; i++)
                {
                    BingKeywords = new Keywords(BingTxtBoxKeywordsField.GetLineText(i).Trim());
                    BingKeywordsData.Add(BingKeywords);
                }

                for (int i = 0; i < BingTxtBoxPageTypesField.LineCount; i++)
                {
                    BingPageTypes = new PageTypes(BingTxtBoxPageTypesField.GetLineText(i).Trim());
                    BingPageTypesData.Add(BingPageTypes);
                }

                for (int i = 0; i < BingTxtBoxSearchOperatorsField.LineCount; i++)
                {
                    BingSearchOperators = new SearchOperators(BingTxtBoxSearchOperatorsField.GetLineText(i).Trim());
                    BingSearchOperatorsData.Add(BingSearchOperators);
                }

                Console.WriteLine("Done with uploading user input datas!");
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    BingLblGeneratedDorks.Content = "Please wait, now generating dorks...";
                }));

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    if (BingCheckBoxSOKWFTTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < BingSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < BingKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < BingPageTypesData.Count; actFileType++)
                                {
                                    for (int actTLD = 0; actTLD < BingTLDExtensionData.Count; actTLD++)
                                    {
                                        Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                        {
                                            Console.WriteLine($"{BingSearchOperatorsData[actSearchOperator].SearchOperator} {(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType} {BingTLDExtensionData[actTLD].TLD}");
                                            ki.WriteLine($"{BingSearchOperatorsData[actSearchOperator].SearchOperator} {(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType} {BingTLDExtensionData[actTLD].TLD}");
                                            ki.Flush();

                                            GeneratedDorks++;
                                            BingLblGeneratedDorks.Visibility = Visibility.Visible;
                                            BingLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                            generatedDorks.Add($"{BingSearchOperatorsData[actSearchOperator].SearchOperator} {(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType} {BingTLDExtensionData[actTLD].TLD}");
                                        }));
                                    }
                                }
                            }
                        }
                    }

                    if (BingCheckBoxSOKWFT.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < BingSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < BingKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < BingPageTypesData.Count; actFileType++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{BingSearchOperatorsData[actSearchOperator].SearchOperator} {(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType}");
                                        ki.WriteLine($"{BingSearchOperatorsData[actSearchOperator].SearchOperator} {(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        BingLblGeneratedDorks.Visibility = Visibility.Visible;
                                        BingLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{BingSearchOperatorsData[actSearchOperator].SearchOperator} {(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType}");
                                    }));
                                }
                            }
                        }
                    }

                    if (BingCheckBoxSOKWTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < BingSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < BingKeywordsData.Count; actKeyword++)
                            {
                                for (int actTLD = 0; actTLD < BingTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{BingSearchOperatorsData[actSearchOperator].SearchOperator} {(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{BingSearchOperatorsData[actSearchOperator].SearchOperator} {(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        BingLblGeneratedDorks.Visibility = Visibility.Visible;
                                        BingLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{BingSearchOperatorsData[actSearchOperator].SearchOperator} {(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (BingCheckBoxKWFTTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < BingKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < BingPageTypesData.Count; actFileType++)
                            {
                                for (int actTLD = 0; actTLD < BingTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType} {BingTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType} {BingTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        BingLblGeneratedDorks.Visibility = Visibility.Visible;
                                        BingLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType} {BingTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (BingCheckBoxKWFT.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < BingKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < BingPageTypesData.Count; actFileType++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType}");
                                    ki.WriteLine($"{(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    BingLblGeneratedDorks.Visibility = Visibility.Visible;
                                    BingLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingPageTypesData[actFileType].PageType}");
                                }));
                            }
                        }
                    }

                    if (BingCheckBoxKWTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < BingKeywordsData.Count; actKeyword++)
                        {
                            for (int actTLD = 0; actTLD < BingTLDExtensionData.Count; actTLD++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingTLDExtensionData[actTLD].TLD}");
                                    ki.WriteLine($"{(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingTLDExtensionData[actTLD].TLD}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    BingLblGeneratedDorks.Visibility = Visibility.Visible;
                                    BingLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(BingCheckBoxPrefix.IsChecked == true ? $"{BingTxtBoxPrefix.Text}" : "")}{BingKeywordsData[actKeyword].Keyword}{(BingCheckBoxSuffix.IsChecked == true ? $"{BingTxtBoxSuffix.Text}" : "")} {BingTLDExtensionData[actTLD].TLD}");
                                }));
                            }
                        }
                    }
                }));
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                BingBtnGenerate.IsEnabled = true;
                BingBtnCleantxtBoxKeywordsField.IsEnabled = true;
                BingBtnCleantxtBoxPageTypesField.IsEnabled = true;
                BingBtnCleantxtBoxSearchOperatorsField.IsEnabled = true;
                BingBtnCleantxtBoxTLDExtensionField.IsEnabled = true;
                BingBtnAllSelectionDorkPatterns.IsEnabled = true;
                BingBtnClearSelectionDorkPatterns.IsEnabled = true;
                BingCheckBoxKWFT.IsEnabled = true;
                BingCheckBoxKWFTTLD.IsEnabled = true;
                BingCheckBoxKWTLD.IsEnabled = true;
                BingCheckBoxSOKWFT.IsEnabled = true;
                BingCheckBoxSOKWFTTLD.IsEnabled = true;
                BingCheckBoxSOKWTLD.IsEnabled = true;
                BingCheckBoxPrefix.IsEnabled = true;
                BingCheckBoxSuffix.IsEnabled = true;
                BingTxtBoxKeywordsField.IsEnabled = true;
                BingTxtBoxPageTypesField.IsEnabled = true;
                BingTxtBoxSearchOperatorsField.IsEnabled = true;
                BingTxtBoxTLDExtensionField.IsEnabled = true;
                BingTreePattern.IsEnabled = true;
                BingTreeSearch.IsEnabled = true;
                BingBtnOpenSaveFolder.IsEnabled = true;
                BingBtnOpenSaveFolder.Visibility = Visibility.Visible;
            }));

            ki.Close();
            Console.WriteLine("Kész");
            if ((GeneratedDorks - generatedDorks.Count) >= 1)
                BingLblGeneratedDorks.Content += $" | Removed duplicates: {GeneratedDorks - generatedDorks.Count}";
            File.Delete($"{rootFolderName}/Bing-dorks-{DateNow}.txt");
            StreamWriter ki2 = new StreamWriter($"{rootFolderName}/{generatedDorks.Count}-Bing-dorks-{DateNow}.txt");
            foreach (var item in generatedDorks)
            {
                ki2.WriteLine(item);
                ki2.Flush();
            }
            ki2.Close();
            fajl.Close();
        }

        private void BingBtnClearSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                BingCheckBoxKWFT.IsChecked = false;
                BingCheckBoxKWFTTLD.IsChecked = false;
                BingCheckBoxSOKWFT.IsChecked = false;
                BingCheckBoxSOKWFTTLD.IsChecked = false;
                BingCheckBoxSOKWTLD.IsChecked = false;
                BingCheckBoxKWTLD.IsChecked = false;
            }));
        }

        private void BingBtnCleantxtBoxTLDExtensionField_Click(object sender, RoutedEventArgs e)
        {
            BingTxtBoxTLDExtensionField.Clear();
        }

        private void BingBtnAllSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                BingCheckBoxKWFT.IsChecked = true;
                BingCheckBoxKWFTTLD.IsChecked = true;
                BingCheckBoxSOKWFT.IsChecked = true;
                BingCheckBoxSOKWFTTLD.IsChecked = true;
                BingCheckBoxSOKWTLD.IsChecked = true;
                BingCheckBoxKWTLD.IsChecked = true;
            }));
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BingLblGeneratedDorks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void BingBtnOpenSaveFolder_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Process.Start("Bing Dorks");
            }));
        }

        private void BingBtnDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnDorkPatterns.Opacity = 0.70;
        }

        private void BingBtnDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnDorkPatterns.Opacity = 1;
        }

        private void BingBtnTLDExtension_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnTLDExtension.Opacity = 0.70;
        }

        private void BingBtnTLDExtension_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnTLDExtension.Opacity = 1;
        }

        private void BingBtnKeywords_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnKeywords.Opacity = 0.70;
        }

        private void BingBtnKeywords_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnKeywords.Opacity = 1;
        }

        private void BingBtnPageTypes_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnPageTypes.Opacity = 0.70;
        }

        private void BingBtnPageTypes_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnPageTypes.Opacity = 1;
        }

        private void BingBtnSearchOperators_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnSearchOperators.Opacity = 0.70;
        }

        private void BingBtnSearchOperators_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnSearchOperators.Opacity = 1;
        }

        private void BingBtnClearSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnClearSelectionDorkPatterns.Opacity = 0.70;
        }

        private void BingBtnClearSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnClearSelectionDorkPatterns.Opacity = 1;
        }

        private void BingBtnAllSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnAllSelectionDorkPatterns.Opacity = 0.70;
        }

        private void BingBtnAllSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnAllSelectionDorkPatterns.Opacity = 1;
        }

        private void BingBtnCleantxtBoxTLDExtensionField_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnCleantxtBoxTLDExtensionField.Opacity = 0.70;
        }

        private void BingBtnCleantxtBoxTLDExtensionField_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnCleantxtBoxTLDExtensionField.Opacity = 1;
        }

        private void BingBtnCleantxtBoxKeywordsField_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnCleantxtBoxKeywordsField.Opacity = 0.70;
        }

        private void BingBtnCleantxtBoxKeywordsField_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnCleantxtBoxKeywordsField.Opacity = 1;
        }

        private void BingBtnCleantxtBoxPageTypesField_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnCleantxtBoxPageTypesField.Opacity = 0.70;
        }

        private void BingBtnCleantxtBoxPageTypesField_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnCleantxtBoxPageTypesField.Opacity = 1;
        }

        private void BingBtnCleantxtBoxSearchOperatorsField_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnCleantxtBoxSearchOperatorsField.Opacity = 0.70;
        }

        private void BingBtnCleantxtBoxSearchOperatorsField_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnCleantxtBoxSearchOperatorsField.Opacity = 1;
        }

        private void BingBtnGenerate_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnGenerate.Opacity = 0.70;
        }

        private void BingBtnGenerate_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnGenerate.Opacity = 1;
        }

        private void BingBtnOpenSaveFolder_MouseEnter(object sender, MouseEventArgs e)
        {
            BingBtnOpenSaveFolder.Opacity = 0.70;
        }

        private void BingBtnOpenSaveFolder_MouseLeave(object sender, MouseEventArgs e)
        {
            BingBtnOpenSaveFolder.Opacity = 1;
        }
    }
}
