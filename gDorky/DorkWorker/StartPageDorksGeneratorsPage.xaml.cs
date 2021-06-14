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
    public partial class StartPageDorksGeneratorsPage : Window
    {
        static bool StartPageIsBtnDorkPatternsClicked = false;
        static bool StartPageIsBtnTLDExtensionClicked = false;
        static bool StartPageIsBtnKeywordsClicked = false;
        static bool StartPageIsBtnPageTypesClicked = false;
        static bool StartPageIsBtnSearchOperatorsClicked = false;

        static List<TLDExtension> StartPageTLDExtensionData = new List<TLDExtension>();
        static TLDExtension StartPageTLDExtension;

        static List<Keywords> StartPageKeywordsData = new List<Keywords>();
        static Keywords StartPageKeywords;

        static List<PageTypes> StartPagePageTypesData = new List<PageTypes>();
        static PageTypes StartPagePageTypes;

        static List<SearchOperators> StartPageSearchOperatorsData = new List<SearchOperators>();
        static SearchOperators StartPageSearchOperators;

        static string rootFolderName;

        static int GeneratedDorks = 0;
        public StartPageDorksGeneratorsPage()
        {
            InitializeComponent();

            CreateDirectory("StartPage Dorks");
        }

        private void CreateDirectory(string folderName)
        {
            rootFolderName = folderName;
            if (!Directory.Exists(rootFolderName))
            {
                Directory.CreateDirectory(rootFolderName);
            }
        }

        private void StartPageAppBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void StartPageBtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StartPageBtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void StartPageBtnDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (StartPageIsBtnTLDExtensionClicked)
                    StartPageBtnTLDExtension.BorderThickness = new Thickness(0);
                if (StartPageIsBtnKeywordsClicked)
                    StartPageBtnKeywords.BorderThickness = new Thickness(0);
                if (StartPageIsBtnPageTypesClicked)
                    StartPageBtnPageTypes.BorderThickness = new Thickness(0);
                if (StartPageIsBtnSearchOperatorsClicked)
                    StartPageBtnSearchOperators.BorderThickness = new Thickness(0);

                StartPageBtnDorkPatterns.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                StartPageBtnDorkPatterns.BorderThickness = new Thickness(2);
                StartPageIsBtnDorkPatternsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    StartPageDorkPatternsUI.Visibility = Visibility.Visible;
                    StartPageTLDExtensionUI.Visibility = Visibility.Hidden;
                    StartPageKeywordsUI.Visibility = Visibility.Hidden;
                    StartPagePageTypesUI.Visibility = Visibility.Hidden;
                    StartPageSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void StartPageBtnTLDExtension_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (StartPageIsBtnDorkPatternsClicked)
                    StartPageBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (StartPageIsBtnKeywordsClicked)
                    StartPageBtnKeywords.BorderThickness = new Thickness(0);
                if (StartPageIsBtnPageTypesClicked)
                    StartPageBtnPageTypes.BorderThickness = new Thickness(0);
                if (StartPageIsBtnSearchOperatorsClicked)
                    StartPageBtnSearchOperators.BorderThickness = new Thickness(0);

                StartPageBtnTLDExtension.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                StartPageBtnTLDExtension.BorderThickness = new Thickness(2);
                StartPageIsBtnTLDExtensionClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    StartPageDorkPatternsUI.Visibility = Visibility.Hidden;
                    StartPageTLDExtensionUI.Visibility = Visibility.Visible;
                    StartPageKeywordsUI.Visibility = Visibility.Hidden;
                    StartPagePageTypesUI.Visibility = Visibility.Hidden;
                    StartPageSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void StartPageBtnKeywords_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (StartPageIsBtnDorkPatternsClicked)
                    StartPageBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (StartPageIsBtnTLDExtensionClicked)
                    StartPageBtnTLDExtension.BorderThickness = new Thickness(0);
                if (StartPageIsBtnPageTypesClicked)
                    StartPageBtnPageTypes.BorderThickness = new Thickness(0);
                if (StartPageIsBtnSearchOperatorsClicked)
                    StartPageBtnSearchOperators.BorderThickness = new Thickness(0);

                StartPageBtnKeywords.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                StartPageBtnKeywords.BorderThickness = new Thickness(2);
                StartPageIsBtnKeywordsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    StartPageDorkPatternsUI.Visibility = Visibility.Hidden;
                    StartPageTLDExtensionUI.Visibility = Visibility.Hidden;
                    StartPageKeywordsUI.Visibility = Visibility.Visible;
                    StartPagePageTypesUI.Visibility = Visibility.Hidden;
                    StartPageSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void StartPageBtnPageTypes_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (StartPageIsBtnDorkPatternsClicked)
                    StartPageBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (StartPageIsBtnKeywordsClicked)
                    StartPageBtnKeywords.BorderThickness = new Thickness(0);
                if (StartPageIsBtnTLDExtensionClicked)
                    StartPageBtnTLDExtension.BorderThickness = new Thickness(0);
                if (StartPageIsBtnSearchOperatorsClicked)
                    StartPageBtnSearchOperators.BorderThickness = new Thickness(0);

                StartPageBtnPageTypes.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                StartPageBtnPageTypes.BorderThickness = new Thickness(2);
                StartPageIsBtnPageTypesClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    StartPageDorkPatternsUI.Visibility = Visibility.Hidden;
                    StartPageTLDExtensionUI.Visibility = Visibility.Hidden;
                    StartPageKeywordsUI.Visibility = Visibility.Hidden;
                    StartPagePageTypesUI.Visibility = Visibility.Visible;
                    StartPageSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void StartPageBtnSearchOperators_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (StartPageIsBtnDorkPatternsClicked)
                    StartPageBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (StartPageIsBtnKeywordsClicked)
                    StartPageBtnKeywords.BorderThickness = new Thickness(0);
                if (StartPageIsBtnPageTypesClicked)
                    StartPageBtnPageTypes.BorderThickness = new Thickness(0);
                if (StartPageIsBtnTLDExtensionClicked)
                    StartPageBtnTLDExtension.BorderThickness = new Thickness(0);

                StartPageBtnSearchOperators.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                StartPageBtnSearchOperators.BorderThickness = new Thickness(2);
                StartPageIsBtnSearchOperatorsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    StartPageDorkPatternsUI.Visibility = Visibility.Hidden;
                    StartPageTLDExtensionUI.Visibility = Visibility.Hidden;
                    StartPageKeywordsUI.Visibility = Visibility.Hidden;
                    StartPagePageTypesUI.Visibility = Visibility.Hidden;
                    StartPageSearchOperatorsUI.Visibility = Visibility.Visible;
                }));
            }));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private void StartPageBtnCleantxtBoxKeywordsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                StartPageTxtBoxKeywordsField.Clear();
            }));

        }

        private void StartPageBtnCleantxtBoxPageTypesField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                StartPageTxtBoxPageTypesField.Clear();
            }));
        }

        private void StartPageBtnCleantxtBoxSearchOperatorsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                StartPageTxtBoxSearchOperatorsField.Clear();
            }));
        }

        private void StartPageBtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string DateNow = $"{DateTime.Now.Year}-{DateTime.Now.Month.ToString("d2")}-{DateTime.Now.Day.ToString("d2")}-{DateTime.Now.Hour.ToString("d2")}-{DateTime.Now.Minute.ToString("d2")}-{DateTime.Now.Second.ToString("d2")}-{DateTime.Now.Millisecond.ToString("d2")}";
            FileStream fajl = new FileStream($"{rootFolderName}/StartPage-dorks-{DateNow}.txt", FileMode.Create);
            StreamWriter ki = new StreamWriter(fajl, Encoding.UTF8);

            HashSet<string> generatedDorks = new HashSet<string>();

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                StartPageTLDExtensionData.Clear();
                StartPageKeywordsData.Clear();
                StartPagePageTypesData.Clear();
                StartPageSearchOperatorsData.Clear();
                StartPageLblGeneratedDorks.Content = "Please wait, now generating dorks!";
                GeneratedDorks = 0;
                StartPageBtnOpenSaveFolder.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                StartPageBtnGenerate.IsEnabled = false;
                StartPageBtnCleantxtBoxKeywordsField.IsEnabled = false;
                StartPageBtnCleantxtBoxPageTypesField.IsEnabled = false;
                StartPageBtnCleantxtBoxSearchOperatorsField.IsEnabled = false;
                StartPageBtnCleantxtBoxTLDExtensionField.IsEnabled = false;
                StartPageBtnAllSelectionDorkPatterns.IsEnabled = false;
                StartPageBtnClearSelectionDorkPatterns.IsEnabled = false;
                StartPageCheckBoxKWFT.IsEnabled = false;
                StartPageCheckBoxKWFTTLD.IsEnabled = false;
                StartPageCheckBoxKWTLD.IsEnabled = false;
                StartPageCheckBoxSOKWFT.IsEnabled = false;
                StartPageCheckBoxSOKWFTTLD.IsEnabled = false;
                StartPageCheckBoxSOKWTLD.IsEnabled = false;
                StartPageCheckBoxPrefix.IsEnabled = false;
                StartPageCheckBoxSuffix.IsEnabled = false;
                StartPageTxtBoxKeywordsField.IsEnabled = false;
                StartPageTxtBoxPageTypesField.IsEnabled = false;
                StartPageTxtBoxSearchOperatorsField.IsEnabled = false;
                StartPageTxtBoxTLDExtensionField.IsEnabled = false;
                StartPageTreePattern.IsEnabled = false;
                StartPageTreeSearch.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                for (int i = 0; i < StartPageTxtBoxTLDExtensionField.LineCount; i++)
                {
                    StartPageTLDExtension = new TLDExtension(StartPageTxtBoxTLDExtensionField.GetLineText(i).Trim());
                    StartPageTLDExtensionData.Add(StartPageTLDExtension);
                }

                for (int i = 0; i < StartPageTxtBoxKeywordsField.LineCount; i++)
                {
                    StartPageKeywords = new Keywords(StartPageTxtBoxKeywordsField.GetLineText(i).Trim());
                    StartPageKeywordsData.Add(StartPageKeywords);
                }

                for (int i = 0; i < StartPageTxtBoxPageTypesField.LineCount; i++)
                {
                    StartPagePageTypes = new PageTypes(StartPageTxtBoxPageTypesField.GetLineText(i).Trim());
                    StartPagePageTypesData.Add(StartPagePageTypes);
                }

                for (int i = 0; i < StartPageTxtBoxSearchOperatorsField.LineCount; i++)
                {
                    StartPageSearchOperators = new SearchOperators(StartPageTxtBoxSearchOperatorsField.GetLineText(i).Trim());
                    StartPageSearchOperatorsData.Add(StartPageSearchOperators);
                }

                Console.WriteLine("Done with uploading user input datas!");
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    StartPageLblGeneratedDorks.Content = "Please wait, now generating dorks...";
                }));

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    if (StartPageCheckBoxSOKWFTTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < StartPageSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < StartPageKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < StartPagePageTypesData.Count; actFileType++)
                                {
                                    for (int actTLD = 0; actTLD < StartPageTLDExtensionData.Count; actTLD++)
                                    {
                                        Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                        {
                                            Console.WriteLine($"{StartPageSearchOperatorsData[actSearchOperator].SearchOperator} {(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType} {StartPageTLDExtensionData[actTLD].TLD}");
                                            ki.WriteLine($"{StartPageSearchOperatorsData[actSearchOperator].SearchOperator} {(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType} {StartPageTLDExtensionData[actTLD].TLD}");
                                            ki.Flush();

                                            GeneratedDorks++;

                                            StartPageLblGeneratedDorks.Visibility = Visibility.Visible;
                                            StartPageLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";

                                            generatedDorks.Add($"{StartPageSearchOperatorsData[actSearchOperator].SearchOperator} {(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType} {StartPageTLDExtensionData[actTLD].TLD}");
                                        }));
                                    }
                                }
                            }
                        }
                    }

                    if (StartPageCheckBoxSOKWFT.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < StartPageSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < StartPageKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < StartPagePageTypesData.Count; actFileType++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{StartPageSearchOperatorsData[actSearchOperator].SearchOperator} {(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType}");
                                        ki.WriteLine($"{StartPageSearchOperatorsData[actSearchOperator].SearchOperator} {(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        StartPageLblGeneratedDorks.Visibility = Visibility.Visible;
                                        StartPageLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{StartPageSearchOperatorsData[actSearchOperator].SearchOperator} {(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType}");
                                    }));
                                }
                            }
                        }
                    }

                    if (StartPageCheckBoxSOKWTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < StartPageSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < StartPageKeywordsData.Count; actKeyword++)
                            {
                                for (int actTLD = 0; actTLD < StartPageTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{StartPageSearchOperatorsData[actSearchOperator].SearchOperator} {(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPageTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{StartPageSearchOperatorsData[actSearchOperator].SearchOperator} {(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPageTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        StartPageLblGeneratedDorks.Visibility = Visibility.Visible;
                                        StartPageLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{StartPageSearchOperatorsData[actSearchOperator].SearchOperator} {(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPageTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (StartPageCheckBoxKWFTTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < StartPageKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < StartPagePageTypesData.Count; actFileType++)
                            {
                                for (int actTLD = 0; actTLD < StartPageTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType} {StartPageTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType} {StartPageTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;

                                        StartPageLblGeneratedDorks.Visibility = Visibility.Visible;
                                        StartPageLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType} {StartPageTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (StartPageCheckBoxKWFT.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < StartPageKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < StartPagePageTypesData.Count; actFileType++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType}");
                                    ki.WriteLine($"{(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    StartPageLblGeneratedDorks.Visibility = Visibility.Visible;
                                    StartPageLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPagePageTypesData[actFileType].PageType}");
                                }));
                            }
                        }
                    }

                    if (StartPageCheckBoxKWTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < StartPageKeywordsData.Count; actKeyword++)
                        {
                            for (int actTLD = 0; actTLD < StartPageTLDExtensionData.Count; actTLD++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPageTLDExtensionData[actTLD].TLD}");
                                    ki.WriteLine($"{(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPageTLDExtensionData[actTLD].TLD}");
                                    ki.Flush();

                                    GeneratedDorks++;

                                    StartPageLblGeneratedDorks.Visibility = Visibility.Visible;
                                    StartPageLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(StartPageCheckBoxPrefix.IsChecked == true ? $"{StartPageTxtBoxPrefix.Text}" : "")}{StartPageKeywordsData[actKeyword].Keyword}{(StartPageCheckBoxSuffix.IsChecked == true ? $"{StartPageTxtBoxSuffix.Text}" : "")} {StartPageTLDExtensionData[actTLD].TLD}");
                                }));
                            }
                        }
                    }
                }));
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                StartPageBtnGenerate.IsEnabled = true;
                StartPageBtnCleantxtBoxKeywordsField.IsEnabled = true;
                StartPageBtnCleantxtBoxPageTypesField.IsEnabled = true;
                StartPageBtnCleantxtBoxSearchOperatorsField.IsEnabled = true;
                StartPageBtnCleantxtBoxTLDExtensionField.IsEnabled = true;
                StartPageBtnAllSelectionDorkPatterns.IsEnabled = true;
                StartPageBtnClearSelectionDorkPatterns.IsEnabled = true;
                StartPageCheckBoxKWFT.IsEnabled = true;
                StartPageCheckBoxKWFTTLD.IsEnabled = true;
                StartPageCheckBoxKWTLD.IsEnabled = true;
                StartPageCheckBoxSOKWFT.IsEnabled = true;
                StartPageCheckBoxSOKWFTTLD.IsEnabled = true;
                StartPageCheckBoxSOKWTLD.IsEnabled = true;
                StartPageCheckBoxPrefix.IsEnabled = true;
                StartPageCheckBoxSuffix.IsEnabled = true;
                StartPageTxtBoxKeywordsField.IsEnabled = true;
                StartPageTxtBoxPageTypesField.IsEnabled = true;
                StartPageTxtBoxSearchOperatorsField.IsEnabled = true;
                StartPageTxtBoxTLDExtensionField.IsEnabled = true;
                StartPageTreePattern.IsEnabled = true;
                StartPageTreeSearch.IsEnabled = true;
                StartPageBtnOpenSaveFolder.IsEnabled = true;
                StartPageBtnOpenSaveFolder.Visibility = Visibility.Visible;
            }));

            ki.Close();
            Console.WriteLine("Kész");
            if((GeneratedDorks - generatedDorks.Count) >= 1)
                StartPageLblGeneratedDorks.Content += $" | Removed duplicates: {GeneratedDorks - generatedDorks.Count}";
            File.Delete($"{rootFolderName}/StartPage-dorks-{DateNow}.txt");
            StreamWriter ki2 = new StreamWriter($"{rootFolderName}/{generatedDorks.Count}-StartPage-dorks-{DateNow}.txt");
            foreach (var item in generatedDorks)
            {
                ki2.WriteLine(item);
                ki2.Flush();
            }
            ki2.Close();
        }

        private void StartPageBtnClearSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                StartPageCheckBoxKWFT.IsChecked = false;
                StartPageCheckBoxKWFTTLD.IsChecked = false;
                StartPageCheckBoxSOKWFT.IsChecked = false;
                StartPageCheckBoxSOKWFTTLD.IsChecked = false;
                StartPageCheckBoxSOKWTLD.IsChecked = false;
                StartPageCheckBoxKWTLD.IsChecked = false;
            }));
        }

        private void StartPageBtnCleantxtBoxTLDExtensionField_Click(object sender, RoutedEventArgs e)
        {
            StartPageTxtBoxTLDExtensionField.Clear();
        }

        private void StartPageBtnAllSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                StartPageCheckBoxKWFT.IsChecked = true;
                StartPageCheckBoxKWFTTLD.IsChecked = true;
                StartPageCheckBoxSOKWFT.IsChecked = true;
                StartPageCheckBoxSOKWFTTLD.IsChecked = true;
                StartPageCheckBoxSOKWTLD.IsChecked = true;
                StartPageCheckBoxKWTLD.IsChecked = true;
            }));
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void StartPageLblGeneratedDorks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void StartPageBtnOpenSaveFolder_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Process.Start("StartPage Dorks");
            }));
        }

        private void StartPageBtnDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnDorkPatterns.Opacity = 0.70;
        }

        private void StartPageBtnDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnDorkPatterns.Opacity = 1;
        }

        private void StartPageBtnTLDExtension_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnTLDExtension.Opacity = 0.70;
        }

        private void StartPageBtnTLDExtension_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnTLDExtension.Opacity = 1;
        }

        private void StartPageBtnKeywords_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnKeywords.Opacity = 0.70;
        }

        private void StartPageBtnKeywords_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnKeywords.Opacity = 1;
        }

        private void StartPageBtnPageTypes_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnPageTypes.Opacity = 0.70;
        }

        private void StartPageBtnPageTypes_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnPageTypes.Opacity = 1;
        }

        private void StartPageBtnSearchOperators_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnSearchOperators.Opacity = 0.70;
        }

        private void StartPageBtnSearchOperators_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnSearchOperators.Opacity = 1;
        }

        private void StartPageBtnClearSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnClearSelectionDorkPatterns.Opacity = 0.70;
        }

        private void StartPageBtnClearSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnClearSelectionDorkPatterns.Opacity = 1;
        }

        private void StartPageBtnAllSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnAllSelectionDorkPatterns.Opacity = 0.70;
        }

        private void StartPageBtnAllSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnAllSelectionDorkPatterns.Opacity = 1;
        }

        private void StartPageBtnCleantxtBoxTLDExtensionField_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnCleantxtBoxTLDExtensionField.Opacity = 0.70;
        }

        private void StartPageBtnCleantxtBoxTLDExtensionField_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnCleantxtBoxTLDExtensionField.Opacity = 1;
        }

        private void StartPageBtnCleantxtBoxKeywordsField_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnCleantxtBoxKeywordsField.Opacity = 0.70;
        }

        private void StartPageBtnCleantxtBoxKeywordsField_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnCleantxtBoxKeywordsField.Opacity = 1;
        }

        private void StartPageBtnCleantxtBoxPageTypesField_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnCleantxtBoxPageTypesField.Opacity = 0.70;
        }

        private void StartPageBtnCleantxtBoxPageTypesField_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnCleantxtBoxPageTypesField.Opacity = 1;
        }

        private void StartPageBtnCleantxtBoxSearchOperatorsField_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnCleantxtBoxSearchOperatorsField.Opacity = 0.70;
        }

        private void StartPageBtnCleantxtBoxSearchOperatorsField_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnCleantxtBoxSearchOperatorsField.Opacity = 1;
        }

        private void StartPageBtnGenerate_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnGenerate.Opacity = 0.70;
        }

        private void StartPageBtnGenerate_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnGenerate.Opacity = 1;
        }

        private void StartPageBtnOpenSaveFolder_MouseEnter(object sender, MouseEventArgs e)
        {
            StartPageBtnOpenSaveFolder.Opacity = 0.70;
        }

        private void StartPageBtnOpenSaveFolder_MouseLeave(object sender, MouseEventArgs e)
        {
            StartPageBtnOpenSaveFolder.Opacity = 1;
        }
    }
}
