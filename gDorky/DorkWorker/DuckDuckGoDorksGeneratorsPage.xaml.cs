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
    public partial class DuckDuckGoDorksGeneratorsPage : Window
    {
        static bool DuckDuckGoIsBtnDorkPatternsClicked = false;
        static bool DuckDuckGoIsBtnTLDExtensionClicked = false;
        static bool DuckDuckGoIsBtnKeywordsClicked = false;
        static bool DuckDuckGoIsBtnPageTypesClicked = false;
        static bool DuckDuckGoIsBtnSearchOperatorsClicked = false;

        static List<TLDExtension> DuckDuckGoTLDExtensionData = new List<TLDExtension>();
        static TLDExtension DuckDuckGoTLDExtension;

        static List<Keywords> DuckDuckGoKeywordsData = new List<Keywords>();
        static Keywords DuckDuckGoKeywords;

        static List<PageTypes> DuckDuckGoPageTypesData = new List<PageTypes>();
        static PageTypes DuckDuckGoPageTypes;

        static List<SearchOperators> DuckDuckGoSearchOperatorsData = new List<SearchOperators>();
        static SearchOperators DuckDuckGoSearchOperators;

        static string rootFolderName;

        static int GeneratedDorks = 0;
        public DuckDuckGoDorksGeneratorsPage()
        {
            InitializeComponent();

            CreateDirectory("DuckDuckGo Dorks");
        }

        private void CreateDirectory(string folderName)
        {
            rootFolderName = folderName;
            if (!Directory.Exists(rootFolderName))
            {
                Directory.CreateDirectory(rootFolderName);
            }
        }

        private void DuckDuckGoAppBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void DuckDuckGoBtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DuckDuckGoBtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void DuckDuckGoBtnDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (DuckDuckGoIsBtnTLDExtensionClicked)
                    DuckDuckGoBtnTLDExtension.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnKeywordsClicked)
                    DuckDuckGoBtnKeywords.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnPageTypesClicked)
                    DuckDuckGoBtnPageTypes.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnSearchOperatorsClicked)
                    DuckDuckGoBtnSearchOperators.BorderThickness = new Thickness(0);

                DuckDuckGoBtnDorkPatterns.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                DuckDuckGoBtnDorkPatterns.BorderThickness = new Thickness(2);
                DuckDuckGoIsBtnDorkPatternsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DuckDuckGoDorkPatternsUI.Visibility = Visibility.Visible;
                    DuckDuckGoTLDExtensionUI.Visibility = Visibility.Hidden;
                    DuckDuckGoKeywordsUI.Visibility = Visibility.Hidden;
                    DuckDuckGoPageTypesUI.Visibility = Visibility.Hidden;
                    DuckDuckGoSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void DuckDuckGoBtnTLDExtension_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (DuckDuckGoIsBtnDorkPatternsClicked)
                    DuckDuckGoBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnKeywordsClicked)
                    DuckDuckGoBtnKeywords.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnPageTypesClicked)
                    DuckDuckGoBtnPageTypes.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnSearchOperatorsClicked)
                    DuckDuckGoBtnSearchOperators.BorderThickness = new Thickness(0);

                DuckDuckGoBtnTLDExtension.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                DuckDuckGoBtnTLDExtension.BorderThickness = new Thickness(2);
                DuckDuckGoIsBtnTLDExtensionClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DuckDuckGoDorkPatternsUI.Visibility = Visibility.Hidden;
                    DuckDuckGoTLDExtensionUI.Visibility = Visibility.Visible;
                    DuckDuckGoKeywordsUI.Visibility = Visibility.Hidden;
                    DuckDuckGoPageTypesUI.Visibility = Visibility.Hidden;
                    DuckDuckGoSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void DuckDuckGoBtnKeywords_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (DuckDuckGoIsBtnDorkPatternsClicked)
                    DuckDuckGoBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnTLDExtensionClicked)
                    DuckDuckGoBtnTLDExtension.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnPageTypesClicked)
                    DuckDuckGoBtnPageTypes.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnSearchOperatorsClicked)
                    DuckDuckGoBtnSearchOperators.BorderThickness = new Thickness(0);

                DuckDuckGoBtnKeywords.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                DuckDuckGoBtnKeywords.BorderThickness = new Thickness(2);
                DuckDuckGoIsBtnKeywordsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DuckDuckGoDorkPatternsUI.Visibility = Visibility.Hidden;
                    DuckDuckGoTLDExtensionUI.Visibility = Visibility.Hidden;
                    DuckDuckGoKeywordsUI.Visibility = Visibility.Visible;
                    DuckDuckGoPageTypesUI.Visibility = Visibility.Hidden;
                    DuckDuckGoSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void DuckDuckGoBtnPageTypes_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (DuckDuckGoIsBtnDorkPatternsClicked)
                    DuckDuckGoBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnKeywordsClicked)
                    DuckDuckGoBtnKeywords.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnTLDExtensionClicked)
                    DuckDuckGoBtnTLDExtension.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnSearchOperatorsClicked)
                    DuckDuckGoBtnSearchOperators.BorderThickness = new Thickness(0);

                DuckDuckGoBtnPageTypes.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                DuckDuckGoBtnPageTypes.BorderThickness = new Thickness(2);
                DuckDuckGoIsBtnPageTypesClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DuckDuckGoDorkPatternsUI.Visibility = Visibility.Hidden;
                    DuckDuckGoTLDExtensionUI.Visibility = Visibility.Hidden;
                    DuckDuckGoKeywordsUI.Visibility = Visibility.Hidden;
                    DuckDuckGoPageTypesUI.Visibility = Visibility.Visible;
                    DuckDuckGoSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void DuckDuckGoBtnSearchOperators_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (DuckDuckGoIsBtnDorkPatternsClicked)
                    DuckDuckGoBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnKeywordsClicked)
                    DuckDuckGoBtnKeywords.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnPageTypesClicked)
                    DuckDuckGoBtnPageTypes.BorderThickness = new Thickness(0);
                if (DuckDuckGoIsBtnTLDExtensionClicked)
                    DuckDuckGoBtnTLDExtension.BorderThickness = new Thickness(0);

                DuckDuckGoBtnSearchOperators.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                DuckDuckGoBtnSearchOperators.BorderThickness = new Thickness(2);
                DuckDuckGoIsBtnSearchOperatorsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DuckDuckGoDorkPatternsUI.Visibility = Visibility.Hidden;
                    DuckDuckGoTLDExtensionUI.Visibility = Visibility.Hidden;
                    DuckDuckGoKeywordsUI.Visibility = Visibility.Hidden;
                    DuckDuckGoPageTypesUI.Visibility = Visibility.Hidden;
                    DuckDuckGoSearchOperatorsUI.Visibility = Visibility.Visible;
                }));
            }));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private void DuckDuckGoBtnCleantxtBoxKeywordsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                DuckDuckGoTxtBoxKeywordsField.Clear();
            }));

        }

        private void DuckDuckGoBtnCleantxtBoxPageTypesField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                DuckDuckGoTxtBoxPageTypesField.Clear();
            }));
        }

        private void DuckDuckGoBtnCleantxtBoxSearchOperatorsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                DuckDuckGoTxtBoxSearchOperatorsField.Clear();
            }));
        }

        private void DuckDuckGoBtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string DateNow = $"{DateTime.Now.Year}-{DateTime.Now.Month.ToString("d2")}-{DateTime.Now.Day.ToString("d2")}-{DateTime.Now.Hour.ToString("d2")}-{DateTime.Now.Minute.ToString("d2")}-{DateTime.Now.Second.ToString("d2")}-{DateTime.Now.Millisecond.ToString("d2")}";
            FileStream fajl = new FileStream($"{rootFolderName}/DuckDuckGo-dorks-{DateNow}.txt", FileMode.Create);
            StreamWriter ki = new StreamWriter(fajl, Encoding.UTF8);

            HashSet<string> generatedDorks = new HashSet<string>();

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                DuckDuckGoTLDExtensionData.Clear();
                DuckDuckGoKeywordsData.Clear();
                DuckDuckGoPageTypesData.Clear();
                DuckDuckGoSearchOperatorsData.Clear();
                DuckDuckGoLblGeneratedDorks.Content = "Please wait, now generating dorks!";
                GeneratedDorks = 0;
                DuckDuckGoBtnOpenSaveFolder.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                DuckDuckGoBtnGenerate.IsEnabled = false;
                DuckDuckGoBtnCleantxtBoxKeywordsField.IsEnabled = false;
                DuckDuckGoBtnCleantxtBoxPageTypesField.IsEnabled = false;
                DuckDuckGoBtnCleantxtBoxSearchOperatorsField.IsEnabled = false;
                DuckDuckGoBtnCleantxtBoxTLDExtensionField.IsEnabled = false;
                DuckDuckGoBtnAllSelectionDorkPatterns.IsEnabled = false;
                DuckDuckGoBtnClearSelectionDorkPatterns.IsEnabled = false;
                DuckDuckGoCheckBoxKWFT.IsEnabled = false;
                DuckDuckGoCheckBoxKWFTTLD.IsEnabled = false;
                DuckDuckGoCheckBoxKWTLD.IsEnabled = false;
                DuckDuckGoCheckBoxSOKWFT.IsEnabled = false;
                DuckDuckGoCheckBoxSOKWFTTLD.IsEnabled = false;
                DuckDuckGoCheckBoxSOKWTLD.IsEnabled = false;
                DuckDuckGoCheckBoxPrefix.IsEnabled = false;
                DuckDuckGoCheckBoxSuffix.IsEnabled = false;
                DuckDuckGoTxtBoxKeywordsField.IsEnabled = false;
                DuckDuckGoTxtBoxPageTypesField.IsEnabled = false;
                DuckDuckGoTxtBoxSearchOperatorsField.IsEnabled = false;
                DuckDuckGoTxtBoxTLDExtensionField.IsEnabled = false;
                DuckDuckGoTreePattern.IsEnabled = false;
                DuckDuckGoTreeSearch.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                for (int i = 0; i < DuckDuckGoTxtBoxTLDExtensionField.LineCount; i++)
                {
                    DuckDuckGoTLDExtension = new TLDExtension(DuckDuckGoTxtBoxTLDExtensionField.GetLineText(i).Trim());
                    DuckDuckGoTLDExtensionData.Add(DuckDuckGoTLDExtension);
                }

                for (int i = 0; i < DuckDuckGoTxtBoxKeywordsField.LineCount; i++)
                {
                    DuckDuckGoKeywords = new Keywords(DuckDuckGoTxtBoxKeywordsField.GetLineText(i).Trim());
                    DuckDuckGoKeywordsData.Add(DuckDuckGoKeywords);
                }

                for (int i = 0; i < DuckDuckGoTxtBoxPageTypesField.LineCount; i++)
                {
                    DuckDuckGoPageTypes = new PageTypes(DuckDuckGoTxtBoxPageTypesField.GetLineText(i).Trim());
                    DuckDuckGoPageTypesData.Add(DuckDuckGoPageTypes);
                }

                for (int i = 0; i < DuckDuckGoTxtBoxSearchOperatorsField.LineCount; i++)
                {
                    DuckDuckGoSearchOperators = new SearchOperators(DuckDuckGoTxtBoxSearchOperatorsField.GetLineText(i).Trim());
                    DuckDuckGoSearchOperatorsData.Add(DuckDuckGoSearchOperators);
                }

                Console.WriteLine("Done with uploading user input datas!");
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DuckDuckGoLblGeneratedDorks.Content = "Please wait, now generating dorks...";
                }));

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    if (DuckDuckGoCheckBoxSOKWFTTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < DuckDuckGoSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < DuckDuckGoKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < DuckDuckGoPageTypesData.Count; actFileType++)
                                {
                                    for (int actTLD = 0; actTLD < DuckDuckGoTLDExtensionData.Count; actTLD++)
                                    {
                                        Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                        {
                                            Console.WriteLine($"{DuckDuckGoSearchOperatorsData[actSearchOperator].SearchOperator} {(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                            ki.WriteLine($"{DuckDuckGoSearchOperatorsData[actSearchOperator].SearchOperator} {(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                            ki.Flush();

                                            GeneratedDorks++;
                                            DuckDuckGoLblGeneratedDorks.Visibility = Visibility.Visible;
                                            DuckDuckGoLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                            generatedDorks.Add($"{DuckDuckGoSearchOperatorsData[actSearchOperator].SearchOperator} {(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                        }));
                                    }
                                }
                            }
                        }
                    }

                    if (DuckDuckGoCheckBoxSOKWFT.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < DuckDuckGoSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < DuckDuckGoKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < DuckDuckGoPageTypesData.Count; actFileType++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{DuckDuckGoSearchOperatorsData[actSearchOperator].SearchOperator} {(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType}");
                                        ki.WriteLine($"{DuckDuckGoSearchOperatorsData[actSearchOperator].SearchOperator} {(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        DuckDuckGoLblGeneratedDorks.Visibility = Visibility.Visible;
                                        DuckDuckGoLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{DuckDuckGoSearchOperatorsData[actSearchOperator].SearchOperator} {(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType}");
                                    }));
                                }
                            }
                        }
                    }

                    if (DuckDuckGoCheckBoxSOKWTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < DuckDuckGoSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < DuckDuckGoKeywordsData.Count; actKeyword++)
                            {
                                for (int actTLD = 0; actTLD < DuckDuckGoTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{DuckDuckGoSearchOperatorsData[actSearchOperator].SearchOperator} {(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{DuckDuckGoSearchOperatorsData[actSearchOperator].SearchOperator} {(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        DuckDuckGoLblGeneratedDorks.Visibility = Visibility.Visible;
                                        DuckDuckGoLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{DuckDuckGoSearchOperatorsData[actSearchOperator].SearchOperator} {(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (DuckDuckGoCheckBoxKWFTTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < DuckDuckGoKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < DuckDuckGoPageTypesData.Count; actFileType++)
                            {
                                for (int actTLD = 0; actTLD < DuckDuckGoTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        DuckDuckGoLblGeneratedDorks.Visibility = Visibility.Visible;
                                        DuckDuckGoLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (DuckDuckGoCheckBoxKWFT.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < DuckDuckGoKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < DuckDuckGoPageTypesData.Count; actFileType++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType}");
                                    ki.WriteLine($"{(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    DuckDuckGoLblGeneratedDorks.Visibility = Visibility.Visible;
                                    DuckDuckGoLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoPageTypesData[actFileType].PageType}");
                                }));
                            }
                        }
                    }

                    if (DuckDuckGoCheckBoxKWTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < DuckDuckGoKeywordsData.Count; actKeyword++)
                        {
                            for (int actTLD = 0; actTLD < DuckDuckGoTLDExtensionData.Count; actTLD++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                    ki.WriteLine($"{(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    DuckDuckGoLblGeneratedDorks.Visibility = Visibility.Visible;
                                    DuckDuckGoLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(DuckDuckGoCheckBoxPrefix.IsChecked == true ? $"{DuckDuckGoTxtBoxPrefix.Text}" : "")}{DuckDuckGoKeywordsData[actKeyword].Keyword}{(DuckDuckGoCheckBoxSuffix.IsChecked == true ? $"{DuckDuckGoTxtBoxSuffix.Text}" : "")} {DuckDuckGoTLDExtensionData[actTLD].TLD}");
                                }));
                            }
                        }
                    }
                }));
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                DuckDuckGoBtnGenerate.IsEnabled = true;
                DuckDuckGoBtnCleantxtBoxKeywordsField.IsEnabled = true;
                DuckDuckGoBtnCleantxtBoxPageTypesField.IsEnabled = true;
                DuckDuckGoBtnCleantxtBoxSearchOperatorsField.IsEnabled = true;
                DuckDuckGoBtnCleantxtBoxTLDExtensionField.IsEnabled = true;
                DuckDuckGoBtnAllSelectionDorkPatterns.IsEnabled = true;
                DuckDuckGoBtnClearSelectionDorkPatterns.IsEnabled = true;
                DuckDuckGoCheckBoxKWFT.IsEnabled = true;
                DuckDuckGoCheckBoxKWFTTLD.IsEnabled = true;
                DuckDuckGoCheckBoxKWTLD.IsEnabled = true;
                DuckDuckGoCheckBoxSOKWFT.IsEnabled = true;
                DuckDuckGoCheckBoxSOKWFTTLD.IsEnabled = true;
                DuckDuckGoCheckBoxSOKWTLD.IsEnabled = true;
                DuckDuckGoCheckBoxPrefix.IsEnabled = true;
                DuckDuckGoCheckBoxSuffix.IsEnabled = true;
                DuckDuckGoTxtBoxKeywordsField.IsEnabled = true;
                DuckDuckGoTxtBoxPageTypesField.IsEnabled = true;
                DuckDuckGoTxtBoxSearchOperatorsField.IsEnabled = true;
                DuckDuckGoTxtBoxTLDExtensionField.IsEnabled = true;
                DuckDuckGoTreePattern.IsEnabled = true;
                DuckDuckGoTreeSearch.IsEnabled = true;
                DuckDuckGoBtnOpenSaveFolder.IsEnabled = true;
                DuckDuckGoBtnOpenSaveFolder.Visibility = Visibility.Visible;
            }));

            ki.Close();
            Console.WriteLine("Kész");
            if ((GeneratedDorks - generatedDorks.Count) >= 1)
                DuckDuckGoLblGeneratedDorks.Content += $" | Removed duplicates: {GeneratedDorks - generatedDorks.Count}";
            File.Delete($"{rootFolderName}/DuckDuckGo-dorks-{DateNow}.txt");
            StreamWriter ki2 = new StreamWriter($"{rootFolderName}/{generatedDorks.Count}-DuckDuckGo-dorks-{DateNow}.txt");
            foreach (var item in generatedDorks)
            {
                ki2.WriteLine(item);
                ki2.Flush();
            }
            ki2.Close();
            fajl.Close();
        }

        private void DuckDuckGoBtnClearSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                DuckDuckGoCheckBoxKWFT.IsChecked = false;
                DuckDuckGoCheckBoxKWFTTLD.IsChecked = false;
                DuckDuckGoCheckBoxSOKWFT.IsChecked = false;
                DuckDuckGoCheckBoxSOKWFTTLD.IsChecked = false;
                DuckDuckGoCheckBoxSOKWTLD.IsChecked = false;
                DuckDuckGoCheckBoxKWTLD.IsChecked = false;
            }));
        }

        private void DuckDuckGoBtnCleantxtBoxTLDExtensionField_Click(object sender, RoutedEventArgs e)
        {
            DuckDuckGoTxtBoxTLDExtensionField.Clear();
        }

        private void DuckDuckGoBtnAllSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                DuckDuckGoCheckBoxKWFT.IsChecked = true;
                DuckDuckGoCheckBoxKWFTTLD.IsChecked = true;
                DuckDuckGoCheckBoxSOKWFT.IsChecked = true;
                DuckDuckGoCheckBoxSOKWFTTLD.IsChecked = true;
                DuckDuckGoCheckBoxSOKWTLD.IsChecked = true;
                DuckDuckGoCheckBoxKWTLD.IsChecked = true;
            }));
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void DuckDuckGoLblGeneratedDorks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void DuckDuckGoBtnOpenSaveFolder_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Process.Start("DuckDuckGo Dorks");
            }));
        }

        private void DuckDuckGoBtnDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnDorkPatterns.Opacity = 0.70;
        }

        private void DuckDuckGoBtnDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnDorkPatterns.Opacity = 1;
        }

        private void DuckDuckGoBtnTLDExtension_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnTLDExtension.Opacity = 0.70;
        }

        private void DuckDuckGoBtnTLDExtension_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnTLDExtension.Opacity = 1;
        }

        private void DuckDuckGoBtnKeywords_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnKeywords.Opacity = 0.70;
        }

        private void DuckDuckGoBtnKeywords_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnKeywords.Opacity = 1;
        }

        private void DuckDuckGoBtnPageTypes_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnPageTypes.Opacity = 0.70;
        }

        private void DuckDuckGoBtnPageTypes_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnPageTypes.Opacity = 1;
        }

        private void DuckDuckGoBtnSearchOperators_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnSearchOperators.Opacity = 0.70;
        }

        private void DuckDuckGoBtnSearchOperators_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnSearchOperators.Opacity = 1;
        }

        private void DuckDuckGoBtnClearSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnClearSelectionDorkPatterns.Opacity = 0.70;
        }

        private void DuckDuckGoBtnClearSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnClearSelectionDorkPatterns.Opacity = 1;
        }

        private void DuckDuckGoBtnAllSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnAllSelectionDorkPatterns.Opacity = 0.70;
        }

        private void DuckDuckGoBtnAllSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnAllSelectionDorkPatterns.Opacity = 1;
        }

        private void DuckDuckGoBtnCleantxtBoxTLDExtensionField_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnCleantxtBoxTLDExtensionField.Opacity = 0.70;
        }

        private void DuckDuckGoBtnCleantxtBoxTLDExtensionField_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnCleantxtBoxTLDExtensionField.Opacity = 1;
        }

        private void DuckDuckGoBtnCleantxtBoxKeywordsField_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnCleantxtBoxKeywordsField.Opacity = 0.70;
        }

        private void DuckDuckGoBtnCleantxtBoxKeywordsField_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnCleantxtBoxKeywordsField.Opacity = 1;
        }

        private void DuckDuckGoBtnCleantxtBoxPageTypesField_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnCleantxtBoxPageTypesField.Opacity = 0.70;
        }

        private void DuckDuckGoBtnCleantxtBoxPageTypesField_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnCleantxtBoxPageTypesField.Opacity = 1;
        }

        private void DuckDuckGoBtnCleantxtBoxSearchOperatorsField_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnCleantxtBoxSearchOperatorsField.Opacity = 0.70;
        }

        private void DuckDuckGoBtnCleantxtBoxSearchOperatorsField_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnCleantxtBoxSearchOperatorsField.Opacity = 1;
        }

        private void DuckDuckGoBtnGenerate_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnGenerate.Opacity = 0.70;
        }

        private void DuckDuckGoBtnGenerate_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnGenerate.Opacity = 1;
        }

        private void DuckDuckGoBtnOpenSaveFolder_MouseEnter(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnOpenSaveFolder.Opacity = 0.70;
        }

        private void DuckDuckGoBtnOpenSaveFolder_MouseLeave(object sender, MouseEventArgs e)
        {
            DuckDuckGoBtnOpenSaveFolder.Opacity = 1;
        }
    }
}
