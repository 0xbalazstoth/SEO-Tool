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
    public partial class GoogleDorkGeneratorPage : Window
    {
        static bool isBtnDorkPatternsClicked = false;
        static bool isBtnTLDExtensionClicked = false;
        static bool isBtnKeywordsClicked = false;
        static bool isBtnPageTypesClicked = false;
        static bool isBtnSearchOperatorsClicked = false;

        static List<TLDExtension> TLDExtensionData = new List<TLDExtension>();
        static TLDExtension TLDExtension;

        static List<Keywords> KeywordsData = new List<Keywords>();
        static Keywords Keywords;

        static List<PageTypes> PageTypesData = new List<PageTypes>();
        static PageTypes PageTypes;

        static List<SearchOperators> SearchOperatorsData = new List<SearchOperators>();
        static SearchOperators SearchOperators;

        static string rootFolderName;

        static int GeneratedDorks = 0;
        public GoogleDorkGeneratorPage()
        {
            InitializeComponent();

            CreateDirectory("Google Dorks");
        }

        private void CreateDirectory(string folderName)
        {
            rootFolderName = folderName;
            if (!Directory.Exists(rootFolderName))
            {
                Directory.CreateDirectory(rootFolderName);
            }
        }

        private void appBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (isBtnTLDExtensionClicked)
                    btnTLDExtension.BorderThickness = new Thickness(0);
                if (isBtnKeywordsClicked)
                    btnKeywords.BorderThickness = new Thickness(0);
                if (isBtnPageTypesClicked)
                    btnPageTypes.BorderThickness = new Thickness(0);
                if (isBtnSearchOperatorsClicked)
                    btnSearchOperators.BorderThickness = new Thickness(0);

                btnDorkPatterns.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                btnDorkPatterns.BorderThickness = new Thickness(2);
                isBtnDorkPatternsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DorkPatternsUI.Visibility = Visibility.Visible;
                    TLDExtensionUI.Visibility = Visibility.Hidden;
                    KeywordsUI.Visibility = Visibility.Hidden;
                    PageTypesUI.Visibility = Visibility.Hidden;
                    SearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void btnTLDExtension_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (isBtnDorkPatternsClicked)
                    btnDorkPatterns.BorderThickness = new Thickness(0);
                if (isBtnKeywordsClicked)
                    btnKeywords.BorderThickness = new Thickness(0);
                if (isBtnPageTypesClicked)
                    btnPageTypes.BorderThickness = new Thickness(0);
                if (isBtnSearchOperatorsClicked)
                    btnSearchOperators.BorderThickness = new Thickness(0);

                btnTLDExtension.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                btnTLDExtension.BorderThickness = new Thickness(2);
                isBtnTLDExtensionClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DorkPatternsUI.Visibility = Visibility.Hidden;
                    TLDExtensionUI.Visibility = Visibility.Visible;
                    KeywordsUI.Visibility = Visibility.Hidden;
                    PageTypesUI.Visibility = Visibility.Hidden;
                    SearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void btnKeywords_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (isBtnDorkPatternsClicked)
                    btnDorkPatterns.BorderThickness = new Thickness(0);
                if (isBtnTLDExtensionClicked)
                    btnTLDExtension.BorderThickness = new Thickness(0);
                if (isBtnPageTypesClicked)
                    btnPageTypes.BorderThickness = new Thickness(0);
                if (isBtnSearchOperatorsClicked)
                    btnSearchOperators.BorderThickness = new Thickness(0);

                btnKeywords.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                btnKeywords.BorderThickness = new Thickness(2);
                isBtnKeywordsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DorkPatternsUI.Visibility = Visibility.Hidden;
                    TLDExtensionUI.Visibility = Visibility.Hidden;
                    KeywordsUI.Visibility = Visibility.Visible;
                    PageTypesUI.Visibility = Visibility.Hidden;
                    SearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void btnPageTypes_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (isBtnDorkPatternsClicked)
                    btnDorkPatterns.BorderThickness = new Thickness(0);
                if (isBtnKeywordsClicked)
                    btnKeywords.BorderThickness = new Thickness(0);
                if (isBtnTLDExtensionClicked)
                    btnTLDExtension.BorderThickness = new Thickness(0);
                if (isBtnSearchOperatorsClicked)
                    btnSearchOperators.BorderThickness = new Thickness(0);

                btnPageTypes.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                btnPageTypes.BorderThickness = new Thickness(2);
                isBtnPageTypesClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DorkPatternsUI.Visibility = Visibility.Hidden;
                    TLDExtensionUI.Visibility = Visibility.Hidden;
                    KeywordsUI.Visibility = Visibility.Hidden;
                    PageTypesUI.Visibility = Visibility.Visible;
                    SearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void btnSearchOperators_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (isBtnDorkPatternsClicked)
                    btnDorkPatterns.BorderThickness = new Thickness(0);
                if (isBtnKeywordsClicked)
                    btnKeywords.BorderThickness = new Thickness(0);
                if (isBtnPageTypesClicked)
                    btnPageTypes.BorderThickness = new Thickness(0);
                if (isBtnTLDExtensionClicked)
                    btnTLDExtension.BorderThickness = new Thickness(0);

                btnSearchOperators.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                btnSearchOperators.BorderThickness = new Thickness(2);
                isBtnSearchOperatorsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    DorkPatternsUI.Visibility = Visibility.Hidden;
                    TLDExtensionUI.Visibility = Visibility.Hidden;
                    KeywordsUI.Visibility = Visibility.Hidden;
                    PageTypesUI.Visibility = Visibility.Hidden;
                    SearchOperatorsUI.Visibility = Visibility.Visible;
                }));
            }));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private void btnCleantxtBoxKeywordsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                txtBoxKeywordsField.Clear();
            }));
            
        }

        private void btnCleantxtBoxPageTypesField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                txtBoxPageTypesField.Clear();
            }));
        }

        private void btnCleantxtBoxSearchOperatorsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                txtBoxSearchOperatorsField.Clear();
            }));
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string DateNow = $"{DateTime.Now.Year}-{DateTime.Now.Month.ToString("d2")}-{DateTime.Now.Day.ToString("d2")}-{DateTime.Now.Hour.ToString("d2")}-{DateTime.Now.Minute.ToString("d2")}-{DateTime.Now.Second.ToString("d2")}-{DateTime.Now.Millisecond.ToString("d2")}";
            FileStream fajl = new FileStream($"{rootFolderName}/Google-dorks-{DateNow}.txt", FileMode.Create);
            StreamWriter ki = new StreamWriter(fajl, Encoding.UTF8);

            HashSet<string> generatedDorks = new HashSet<string>();

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                TLDExtensionData.Clear();
                KeywordsData.Clear();
                PageTypesData.Clear();
                SearchOperatorsData.Clear();
                lblGeneratedDorks.Content = "Please wait, now generating dorks!";
                GeneratedDorks = 0;
                btnOpenSaveFolder.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                btnGenerate.IsEnabled = false;
                btnCleantxtBoxKeywordsField.IsEnabled = false;
                btnCleantxtBoxPageTypesField.IsEnabled = false;
                btnCleantxtBoxSearchOperatorsField.IsEnabled = false;
                btnCleantxtBoxTLDExtensionField.IsEnabled = false;
                btnAllSelectionDorkPatterns.IsEnabled = false;
                btnClearSelectionDorkPatterns.IsEnabled = false;
                checkBoxKWFT.IsEnabled = false;
                checkBoxKWFTTLD.IsEnabled = false;
                checkBoxKWTLD.IsEnabled = false;
                checkBoxSOKWFT.IsEnabled = false;
                checkBoxSOKWFTTLD.IsEnabled = false;
                checkBoxSOKWTLD.IsEnabled = false;
                checkBoxPrefix.IsEnabled = false;
                checkBoxSuffix.IsEnabled = false;
                txtBoxKeywordsField.IsEnabled = false;
                txtBoxPageTypesField.IsEnabled = false;
                txtBoxSearchOperatorsField.IsEnabled = false;
                txtBoxTLDExtensionField.IsEnabled = false;
                treePattern.IsEnabled = false;
                treeSearch.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                for (int i = 0; i < txtBoxTLDExtensionField.LineCount; i++)
                {
                    TLDExtension = new TLDExtension(txtBoxTLDExtensionField.GetLineText(i).Trim());
                    TLDExtensionData.Add(TLDExtension);
                }

                for (int i = 0; i < txtBoxKeywordsField.LineCount; i++)
                {
                    Keywords = new Keywords(txtBoxKeywordsField.GetLineText(i).Trim());
                    KeywordsData.Add(Keywords);
                }

                for (int i = 0; i < txtBoxPageTypesField.LineCount; i++)
                {
                    PageTypes = new PageTypes(txtBoxPageTypesField.GetLineText(i).Trim());
                    PageTypesData.Add(PageTypes);
                }

                for (int i = 0; i < txtBoxSearchOperatorsField.LineCount; i++)
                {
                    SearchOperators = new SearchOperators(txtBoxSearchOperatorsField.GetLineText(i).Trim());
                    SearchOperatorsData.Add(SearchOperators);
                }

                Console.WriteLine("Done with uploading user input datas!");
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    lblGeneratedDorks.Content = "Please wait, now generating dorks...";
                }));

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    if (checkBoxSOKWFTTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < SearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < KeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < PageTypesData.Count; actFileType++)
                                {
                                    for (int actTLD = 0; actTLD < TLDExtensionData.Count; actTLD++)
                                    {
                                        Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                        {
                                            Console.WriteLine($"{SearchOperatorsData[actSearchOperator].SearchOperator} {(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType} {TLDExtensionData[actTLD].TLD}");
                                            ki.WriteLine($"{SearchOperatorsData[actSearchOperator].SearchOperator} {(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType} {TLDExtensionData[actTLD].TLD}");
                                            ki.Flush();

                                            GeneratedDorks++;

                                            lblGeneratedDorks.Visibility = Visibility.Visible;
                                            lblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                            generatedDorks.Add($"{SearchOperatorsData[actSearchOperator].SearchOperator} {(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType} {TLDExtensionData[actTLD].TLD}");
                                        }));
                                    }
                                }
                            }
                        }
                    }

                    if (checkBoxSOKWFT.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < SearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < KeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < PageTypesData.Count; actFileType++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{SearchOperatorsData[actSearchOperator].SearchOperator} {(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType}");
                                        ki.WriteLine($"{SearchOperatorsData[actSearchOperator].SearchOperator} {(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        lblGeneratedDorks.Visibility = Visibility.Visible;
                                        lblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{SearchOperatorsData[actSearchOperator].SearchOperator} {(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType}");
                                    }));
                                }
                            }
                        }
                    }

                    if (checkBoxSOKWTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < SearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < KeywordsData.Count; actKeyword++)
                            {
                                for (int actTLD = 0; actTLD < TLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{SearchOperatorsData[actSearchOperator].SearchOperator} {(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {TLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{SearchOperatorsData[actSearchOperator].SearchOperator} {(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {TLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        lblGeneratedDorks.Visibility = Visibility.Visible;
                                        lblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{SearchOperatorsData[actSearchOperator].SearchOperator} {(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {TLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (checkBoxKWFTTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < KeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < PageTypesData.Count; actFileType++)
                            {
                                for (int actTLD = 0; actTLD < TLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType} {TLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType} {TLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        lblGeneratedDorks.Visibility = Visibility.Visible;
                                        lblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType} {TLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (checkBoxKWFT.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < KeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < PageTypesData.Count; actFileType++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType}");
                                    ki.WriteLine($"{(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    lblGeneratedDorks.Visibility = Visibility.Visible;
                                    lblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {PageTypesData[actFileType].PageType}");
                                }));
                            }
                        }
                    }

                    if (checkBoxKWTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < KeywordsData.Count; actKeyword++)
                        {
                            for (int actTLD = 0; actTLD < TLDExtensionData.Count; actTLD++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {TLDExtensionData[actTLD].TLD}");
                                    ki.WriteLine($"{(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {TLDExtensionData[actTLD].TLD}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    lblGeneratedDorks.Visibility = Visibility.Visible;
                                    lblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(checkBoxPrefix.IsChecked == true ? $"{txtBoxPrefix.Text}" : "")}{KeywordsData[actKeyword].Keyword}{(checkBoxSuffix.IsChecked == true ? $"{txtBoxSuffix.Text}" : "")} {TLDExtensionData[actTLD].TLD}");
                                }));
                            }
                        }
                    }
                }));
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                btnGenerate.IsEnabled = true;
                btnCleantxtBoxKeywordsField.IsEnabled = true;
                btnCleantxtBoxPageTypesField.IsEnabled = true;
                btnCleantxtBoxSearchOperatorsField.IsEnabled = true;
                btnCleantxtBoxTLDExtensionField.IsEnabled = true;
                btnAllSelectionDorkPatterns.IsEnabled = true;
                btnClearSelectionDorkPatterns.IsEnabled = true;
                checkBoxKWFT.IsEnabled = true;
                checkBoxKWFTTLD.IsEnabled = true;
                checkBoxKWTLD.IsEnabled = true;
                checkBoxSOKWFT.IsEnabled = true;
                checkBoxSOKWFTTLD.IsEnabled = true;
                checkBoxSOKWTLD.IsEnabled = true;
                checkBoxPrefix.IsEnabled = true;
                checkBoxSuffix.IsEnabled = true;
                txtBoxKeywordsField.IsEnabled = true;
                txtBoxPageTypesField.IsEnabled = true;
                txtBoxSearchOperatorsField.IsEnabled = true;
                txtBoxTLDExtensionField.IsEnabled = true;
                treePattern.IsEnabled = true;
                treeSearch.IsEnabled = true;
                btnOpenSaveFolder.IsEnabled = true;
                btnOpenSaveFolder.Visibility = Visibility.Visible;
            }));

            ki.Close();
            Console.WriteLine("Kész");
            if ((GeneratedDorks - generatedDorks.Count) >= 1)
                lblGeneratedDorks.Content += $" | Removed duplicates: {GeneratedDorks - generatedDorks.Count}";
            File.Delete($"{rootFolderName}/Google-dorks-{DateNow}.txt");
            StreamWriter ki2 = new StreamWriter($"{rootFolderName}/{generatedDorks.Count}-Google-dorks-{DateNow}.txt");
            foreach (var item in generatedDorks)
            {
                ki2.WriteLine(item);
                ki2.Flush();
            }
            ki2.Close();
        }

        private void btnClearSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                checkBoxKWFT.IsChecked = false;
                checkBoxKWFTTLD.IsChecked = false;
                checkBoxSOKWFT.IsChecked = false;
                checkBoxSOKWFTTLD.IsChecked = false;
                checkBoxSOKWTLD.IsChecked = false;
                checkBoxKWTLD.IsChecked = false; 
            }));
        }

        private void btnCleantxtBoxTLDExtensionField_Click(object sender, RoutedEventArgs e)
        {
            txtBoxTLDExtensionField.Clear();
        }

        private void btnAllSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                checkBoxKWFT.IsChecked = true;
                checkBoxKWFTTLD.IsChecked = true;
                checkBoxSOKWFT.IsChecked = true;
                checkBoxSOKWFTTLD.IsChecked = true;
                checkBoxSOKWTLD.IsChecked = true;
                checkBoxKWTLD.IsChecked = true;
            }));
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnOpenSaveFolder_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Process.Start("Google Dorks");
            }));
        }

        private void lblGeneratedDorks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            btnDorkPatterns.Opacity = 0.70;
        }

        private void btnDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            btnDorkPatterns.Opacity = 1;
        }

        private void btnTLDExtension_MouseEnter(object sender, MouseEventArgs e)
        {
            btnTLDExtension.Opacity = 0.70;
        }

        private void btnTLDExtension_MouseLeave(object sender, MouseEventArgs e)
        {
            btnTLDExtension.Opacity = 1;
        }

        private void btnKeywords_MouseEnter(object sender, MouseEventArgs e)
        {
            btnKeywords.Opacity = 0.70;
        }

        private void btnKeywords_MouseLeave(object sender, MouseEventArgs e)
        {
            btnKeywords.Opacity = 1;
        }

        private void btnPageTypes_MouseEnter(object sender, MouseEventArgs e)
        {
            btnPageTypes.Opacity = 0.70;
        }

        private void btnPageTypes_MouseLeave(object sender, MouseEventArgs e)
        {
            btnPageTypes.Opacity = 1;
        }

        private void btnSearchOperators_MouseEnter(object sender, MouseEventArgs e)
        {
            btnSearchOperators.Opacity = 0.70;
        }

        private void btnSearchOperators_MouseLeave(object sender, MouseEventArgs e)
        {
            btnSearchOperators.Opacity = 1;
        }

        private void btnAllSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            btnAllSelectionDorkPatterns.Opacity = 0.70;
        }

        private void btnAllSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            btnAllSelectionDorkPatterns.Opacity = 1;
        }

        private void btnClearSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            btnClearSelectionDorkPatterns.Opacity = 0.70;
        }

        private void btnClearSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            btnClearSelectionDorkPatterns.Opacity = 1;
        }

        private void btnOpenSaveFolder_MouseEnter(object sender, MouseEventArgs e)
        {
            btnOpenSaveFolder.Opacity = 0.70;
        }

        private void btnOpenSaveFolder_MouseLeave(object sender, MouseEventArgs e)
        {
            btnOpenSaveFolder.Opacity = 1;
        }

        private void btnGenerate_MouseEnter(object sender, MouseEventArgs e)
        {
            btnGenerate.Opacity = 0.70;
        }

        private void btnGenerate_MouseLeave(object sender, MouseEventArgs e)
        {
            btnGenerate.Opacity = 1;
        }

        private void btnCleantxtBoxTLDExtensionField_MouseEnter(object sender, MouseEventArgs e)
        {
            btnCleantxtBoxTLDExtensionField.Opacity = 0.70;
        }

        private void btnCleantxtBoxTLDExtensionField_MouseLeave(object sender, MouseEventArgs e)
        {
            btnCleantxtBoxTLDExtensionField.Opacity = 1;
        }

        private void btnCleantxtBoxKeywordsField_MouseEnter(object sender, MouseEventArgs e)
        {
            btnCleantxtBoxKeywordsField.Opacity = 0.70;
        }

        private void btnCleantxtBoxKeywordsField_MouseLeave(object sender, MouseEventArgs e)
        {
            btnCleantxtBoxKeywordsField.Opacity = 1;
        }

        private void btnCleantxtBoxPageTypesField_MouseEnter(object sender, MouseEventArgs e)
        {
            btnCleantxtBoxPageTypesField.Opacity = 0.70;
        }

        private void btnCleantxtBoxPageTypesField_MouseLeave(object sender, MouseEventArgs e)
        {
            btnCleantxtBoxPageTypesField.Opacity = 1;
        }

        private void btnCleantxtBoxSearchOperatorsField_MouseEnter(object sender, MouseEventArgs e)
        {
            btnCleantxtBoxSearchOperatorsField.Opacity = 0.70;
        }

        private void btnCleantxtBoxSearchOperatorsField_MouseLeave(object sender, MouseEventArgs e)
        {
            btnCleantxtBoxSearchOperatorsField.Opacity = 1;
        }
    }
}
