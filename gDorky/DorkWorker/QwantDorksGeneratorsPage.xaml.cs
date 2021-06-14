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
    public partial class QwantDorksGeneratorsPage : Window
    {
        static bool QwantIsBtnDorkPatternsClicked = false;
        static bool QwantIsBtnTLDExtensionClicked = false;
        static bool QwantIsBtnKeywordsClicked = false;
        static bool QwantIsBtnPageTypesClicked = false;
        static bool QwantIsBtnSearchOperatorsClicked = false;

        static List<TLDExtension> QwantTLDExtensionData = new List<TLDExtension>();
        static TLDExtension QwantTLDExtension;

        static List<Keywords> QwantKeywordsData = new List<Keywords>();
        static Keywords QwantKeywords;

        static List<PageTypes> QwantPageTypesData = new List<PageTypes>();
        static PageTypes QwantPageTypes;

        static List<SearchOperators> QwantSearchOperatorsData = new List<SearchOperators>();
        static SearchOperators QwantSearchOperators;

        static string rootFolderName;

        static int GeneratedDorks = 0;
        public QwantDorksGeneratorsPage()
        {
            InitializeComponent();

            CreateDirectory("Qwant Dorks");
        }

        private void CreateDirectory(string folderName)
        {
            rootFolderName = folderName;
            if (!Directory.Exists(rootFolderName))
            {
                Directory.CreateDirectory(rootFolderName);
            }
        }

        private void QwantAppBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void QwantBtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void QwantBtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void QwantBtnDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (QwantIsBtnTLDExtensionClicked)
                    QwantBtnTLDExtension.BorderThickness = new Thickness(0);
                if (QwantIsBtnKeywordsClicked)
                    QwantBtnKeywords.BorderThickness = new Thickness(0);
                if (QwantIsBtnPageTypesClicked)
                    QwantBtnPageTypes.BorderThickness = new Thickness(0);
                if (QwantIsBtnSearchOperatorsClicked)
                    QwantBtnSearchOperators.BorderThickness = new Thickness(0);

                QwantBtnDorkPatterns.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                QwantBtnDorkPatterns.BorderThickness = new Thickness(2);
                QwantIsBtnDorkPatternsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    QwantDorkPatternsUI.Visibility = Visibility.Visible;
                    QwantTLDExtensionUI.Visibility = Visibility.Hidden;
                    QwantKeywordsUI.Visibility = Visibility.Hidden;
                    QwantPageTypesUI.Visibility = Visibility.Hidden;
                    QwantSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void QwantBtnTLDExtension_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (QwantIsBtnDorkPatternsClicked)
                    QwantBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (QwantIsBtnKeywordsClicked)
                    QwantBtnKeywords.BorderThickness = new Thickness(0);
                if (QwantIsBtnPageTypesClicked)
                    QwantBtnPageTypes.BorderThickness = new Thickness(0);
                if (QwantIsBtnSearchOperatorsClicked)
                    QwantBtnSearchOperators.BorderThickness = new Thickness(0);

                QwantBtnTLDExtension.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                QwantBtnTLDExtension.BorderThickness = new Thickness(2);
                QwantIsBtnTLDExtensionClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    QwantDorkPatternsUI.Visibility = Visibility.Hidden;
                    QwantTLDExtensionUI.Visibility = Visibility.Visible;
                    QwantKeywordsUI.Visibility = Visibility.Hidden;
                    QwantPageTypesUI.Visibility = Visibility.Hidden;
                    QwantSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void QwantBtnKeywords_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (QwantIsBtnDorkPatternsClicked)
                    QwantBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (QwantIsBtnTLDExtensionClicked)
                    QwantBtnTLDExtension.BorderThickness = new Thickness(0);
                if (QwantIsBtnPageTypesClicked)
                    QwantBtnPageTypes.BorderThickness = new Thickness(0);
                if (QwantIsBtnSearchOperatorsClicked)
                    QwantBtnSearchOperators.BorderThickness = new Thickness(0);

                QwantBtnKeywords.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                QwantBtnKeywords.BorderThickness = new Thickness(2);
                QwantIsBtnKeywordsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    QwantDorkPatternsUI.Visibility = Visibility.Hidden;
                    QwantTLDExtensionUI.Visibility = Visibility.Hidden;
                    QwantKeywordsUI.Visibility = Visibility.Visible;
                    QwantPageTypesUI.Visibility = Visibility.Hidden;
                    QwantSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void QwantBtnPageTypes_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (QwantIsBtnDorkPatternsClicked)
                    QwantBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (QwantIsBtnKeywordsClicked)
                    QwantBtnKeywords.BorderThickness = new Thickness(0);
                if (QwantIsBtnTLDExtensionClicked)
                    QwantBtnTLDExtension.BorderThickness = new Thickness(0);
                if (QwantIsBtnSearchOperatorsClicked)
                    QwantBtnSearchOperators.BorderThickness = new Thickness(0);

                QwantBtnPageTypes.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                QwantBtnPageTypes.BorderThickness = new Thickness(2);
                QwantIsBtnPageTypesClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    QwantDorkPatternsUI.Visibility = Visibility.Hidden;
                    QwantTLDExtensionUI.Visibility = Visibility.Hidden;
                    QwantKeywordsUI.Visibility = Visibility.Hidden;
                    QwantPageTypesUI.Visibility = Visibility.Visible;
                    QwantSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void QwantBtnSearchOperators_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (QwantIsBtnDorkPatternsClicked)
                    QwantBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (QwantIsBtnKeywordsClicked)
                    QwantBtnKeywords.BorderThickness = new Thickness(0);
                if (QwantIsBtnPageTypesClicked)
                    QwantBtnPageTypes.BorderThickness = new Thickness(0);
                if (QwantIsBtnTLDExtensionClicked)
                    QwantBtnTLDExtension.BorderThickness = new Thickness(0);

                QwantBtnSearchOperators.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                QwantBtnSearchOperators.BorderThickness = new Thickness(2);
                QwantIsBtnSearchOperatorsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    QwantDorkPatternsUI.Visibility = Visibility.Hidden;
                    QwantTLDExtensionUI.Visibility = Visibility.Hidden;
                    QwantKeywordsUI.Visibility = Visibility.Hidden;
                    QwantPageTypesUI.Visibility = Visibility.Hidden;
                    QwantSearchOperatorsUI.Visibility = Visibility.Visible;
                }));
            }));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private void QwantBtnCleantxtBoxKeywordsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                QwantTxtBoxKeywordsField.Clear();
            }));

        }

        private void QwantBtnCleantxtBoxPageTypesField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                QwantTxtBoxPageTypesField.Clear();
            }));
        }

        private void QwantBtnCleantxtBoxSearchOperatorsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                QwantTxtBoxSearchOperatorsField.Clear();
            }));
        }

        private void QwantBtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string DateNow = $"{DateTime.Now.Year}-{DateTime.Now.Month.ToString("d2")}-{DateTime.Now.Day.ToString("d2")}-{DateTime.Now.Hour.ToString("d2")}-{DateTime.Now.Minute.ToString("d2")}-{DateTime.Now.Second.ToString("d2")}-{DateTime.Now.Millisecond.ToString("d2")}";
            FileStream fajl = new FileStream($"{rootFolderName}/Qwant-dorks-{DateNow}.txt", FileMode.Create);
            StreamWriter ki = new StreamWriter(fajl, Encoding.UTF8);

            HashSet<string> generatedDorks = new HashSet<string>();

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                QwantTLDExtensionData.Clear();
                QwantKeywordsData.Clear();
                QwantPageTypesData.Clear();
                QwantSearchOperatorsData.Clear();
                QwantLblGeneratedDorks.Content = "Please wait, now generating dorks!";
                GeneratedDorks = 0;
                QwantBtnOpenSaveFolder.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                QwantBtnGenerate.IsEnabled = false;
                QwantBtnCleantxtBoxKeywordsField.IsEnabled = false;
                QwantBtnCleantxtBoxPageTypesField.IsEnabled = false;
                QwantBtnCleantxtBoxSearchOperatorsField.IsEnabled = false;
                QwantBtnCleantxtBoxTLDExtensionField.IsEnabled = false;
                QwantBtnAllSelectionDorkPatterns.IsEnabled = false;
                QwantBtnClearSelectionDorkPatterns.IsEnabled = false;
                QwantCheckBoxKWFT.IsEnabled = false;
                QwantCheckBoxKWFTTLD.IsEnabled = false;
                QwantCheckBoxKWTLD.IsEnabled = false;
                QwantCheckBoxSOKWFT.IsEnabled = false;
                QwantCheckBoxSOKWFTTLD.IsEnabled = false;
                QwantCheckBoxSOKWTLD.IsEnabled = false;
                QwantCheckBoxPrefix.IsEnabled = false;
                QwantCheckBoxSuffix.IsEnabled = false;
                QwantTxtBoxKeywordsField.IsEnabled = false;
                QwantTxtBoxPageTypesField.IsEnabled = false;
                QwantTxtBoxSearchOperatorsField.IsEnabled = false;
                QwantTxtBoxTLDExtensionField.IsEnabled = false;
                QwantTreePattern.IsEnabled = false;
                QwantTreeSearch.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                for (int i = 0; i < QwantTxtBoxTLDExtensionField.LineCount; i++)
                {
                    QwantTLDExtension = new TLDExtension(QwantTxtBoxTLDExtensionField.GetLineText(i).Trim());
                    QwantTLDExtensionData.Add(QwantTLDExtension);
                }

                for (int i = 0; i < QwantTxtBoxKeywordsField.LineCount; i++)
                {
                    QwantKeywords = new Keywords(QwantTxtBoxKeywordsField.GetLineText(i).Trim());
                    QwantKeywordsData.Add(QwantKeywords);
                }

                for (int i = 0; i < QwantTxtBoxPageTypesField.LineCount; i++)
                {
                    QwantPageTypes = new PageTypes(QwantTxtBoxPageTypesField.GetLineText(i).Trim());
                    QwantPageTypesData.Add(QwantPageTypes);
                }

                for (int i = 0; i < QwantTxtBoxSearchOperatorsField.LineCount; i++)
                {
                    QwantSearchOperators = new SearchOperators(QwantTxtBoxSearchOperatorsField.GetLineText(i).Trim());
                    QwantSearchOperatorsData.Add(QwantSearchOperators);
                }

                Console.WriteLine("Done with uploading user input datas!");
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    QwantLblGeneratedDorks.Content = "Please wait, now generating dorks...";
                }));

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    if (QwantCheckBoxSOKWFTTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < QwantSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < QwantKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < QwantPageTypesData.Count; actFileType++)
                                {
                                    for (int actTLD = 0; actTLD < QwantTLDExtensionData.Count; actTLD++)
                                    {
                                        Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                        {
                                            Console.WriteLine($"{QwantSearchOperatorsData[actSearchOperator].SearchOperator} {(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType} {QwantTLDExtensionData[actTLD].TLD}");
                                            ki.WriteLine($"{QwantSearchOperatorsData[actSearchOperator].SearchOperator} {(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType} {QwantTLDExtensionData[actTLD].TLD}");
                                            ki.Flush();

                                            GeneratedDorks++;
                                            QwantLblGeneratedDorks.Visibility = Visibility.Visible;
                                            QwantLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                            generatedDorks.Add($"{QwantSearchOperatorsData[actSearchOperator].SearchOperator} {(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType} {QwantTLDExtensionData[actTLD].TLD}");
                                        }));
                                    }
                                }
                            }
                        }
                    }

                    if (QwantCheckBoxSOKWFT.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < QwantSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < QwantKeywordsData.Count; actKeyword++)
                            {
                                for (int actFileType = 0; actFileType < QwantPageTypesData.Count; actFileType++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{QwantSearchOperatorsData[actSearchOperator].SearchOperator} {(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType}");
                                        ki.WriteLine($"{QwantSearchOperatorsData[actSearchOperator].SearchOperator} {(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        QwantLblGeneratedDorks.Visibility = Visibility.Visible;
                                        QwantLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{QwantSearchOperatorsData[actSearchOperator].SearchOperator} {(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType}");
                                    }));
                                }
                            }
                        }
                    }

                    if (QwantCheckBoxSOKWTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < QwantSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < QwantKeywordsData.Count; actKeyword++)
                            {
                                for (int actTLD = 0; actTLD < QwantTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{QwantSearchOperatorsData[actSearchOperator].SearchOperator} {(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{QwantSearchOperatorsData[actSearchOperator].SearchOperator} {(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        QwantLblGeneratedDorks.Visibility = Visibility.Visible;
                                        QwantLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{QwantSearchOperatorsData[actSearchOperator].SearchOperator} {(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (QwantCheckBoxKWFTTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < QwantKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < QwantPageTypesData.Count; actFileType++)
                            {
                                for (int actTLD = 0; actTLD < QwantTLDExtensionData.Count; actTLD++)
                                {
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType} {QwantTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType} {QwantTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        QwantLblGeneratedDorks.Visibility = Visibility.Visible;
                                        QwantLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType} {QwantTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (QwantCheckBoxKWFT.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < QwantKeywordsData.Count; actKeyword++)
                        {
                            for (int actFileType = 0; actFileType < QwantPageTypesData.Count; actFileType++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType}");
                                    ki.WriteLine($"{(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    QwantLblGeneratedDorks.Visibility = Visibility.Visible;
                                    QwantLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantPageTypesData[actFileType].PageType}");
                                }));
                            }
                        }
                    }

                    if (QwantCheckBoxKWTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < QwantKeywordsData.Count; actKeyword++)
                        {
                            for (int actTLD = 0; actTLD < QwantTLDExtensionData.Count; actTLD++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantTLDExtensionData[actTLD].TLD}");
                                    ki.WriteLine($"{(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantTLDExtensionData[actTLD].TLD}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    QwantLblGeneratedDorks.Visibility = Visibility.Visible;
                                    QwantLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(QwantCheckBoxPrefix.IsChecked == true ? $"{QwantTxtBoxPrefix.Text}" : "")}{QwantKeywordsData[actKeyword].Keyword}{(QwantCheckBoxSuffix.IsChecked == true ? $"{QwantTxtBoxSuffix.Text}" : "")} {QwantTLDExtensionData[actTLD].TLD}");
                                }));
                            }
                        }
                    }
                }));
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                QwantBtnGenerate.IsEnabled = true;
                QwantBtnCleantxtBoxKeywordsField.IsEnabled = true;
                QwantBtnCleantxtBoxPageTypesField.IsEnabled = true;
                QwantBtnCleantxtBoxSearchOperatorsField.IsEnabled = true;
                QwantBtnCleantxtBoxTLDExtensionField.IsEnabled = true;
                QwantBtnAllSelectionDorkPatterns.IsEnabled = true;
                QwantBtnClearSelectionDorkPatterns.IsEnabled = true;
                QwantCheckBoxKWFT.IsEnabled = true;
                QwantCheckBoxKWFTTLD.IsEnabled = true;
                QwantCheckBoxKWTLD.IsEnabled = true;
                QwantCheckBoxSOKWFT.IsEnabled = true;
                QwantCheckBoxSOKWFTTLD.IsEnabled = true;
                QwantCheckBoxSOKWTLD.IsEnabled = true;
                QwantCheckBoxPrefix.IsEnabled = true;
                QwantCheckBoxSuffix.IsEnabled = true;
                QwantTxtBoxKeywordsField.IsEnabled = true;
                QwantTxtBoxPageTypesField.IsEnabled = true;
                QwantTxtBoxSearchOperatorsField.IsEnabled = true;
                QwantTxtBoxTLDExtensionField.IsEnabled = true;
                QwantTreePattern.IsEnabled = true;
                QwantTreeSearch.IsEnabled = true;
                QwantBtnOpenSaveFolder.IsEnabled = true;
                QwantBtnOpenSaveFolder.Visibility = Visibility.Visible;
            }));

            ki.Close();
            Console.WriteLine("Kész");
            if ((GeneratedDorks - generatedDorks.Count) >= 1)
                QwantLblGeneratedDorks.Content += $" | Removed duplicates: {GeneratedDorks - generatedDorks.Count}";
            File.Delete($"{rootFolderName}/Qwant-dorks-{DateNow}.txt");
            StreamWriter ki2 = new StreamWriter($"{rootFolderName}/{generatedDorks.Count}-Qwant-dorks-{DateNow}.txt");
            foreach (var item in generatedDorks)
            {
                ki2.WriteLine(item);
                ki2.Flush();
            }
            ki2.Close();
            fajl.Close();
        }

        private void QwantBtnClearSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                QwantCheckBoxKWFT.IsChecked = false;
                QwantCheckBoxKWFTTLD.IsChecked = false;
                QwantCheckBoxSOKWFT.IsChecked = false;
                QwantCheckBoxSOKWFTTLD.IsChecked = false;
                QwantCheckBoxSOKWTLD.IsChecked = false;
                QwantCheckBoxKWTLD.IsChecked = false;
            }));
        }

        private void QwantBtnCleantxtBoxTLDExtensionField_Click(object sender, RoutedEventArgs e)
        {
            QwantTxtBoxTLDExtensionField.Clear();
        }

        private void QwantBtnAllSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                QwantCheckBoxKWFT.IsChecked = true;
                QwantCheckBoxKWFTTLD.IsChecked = true;
                QwantCheckBoxSOKWFT.IsChecked = true;
                QwantCheckBoxSOKWFTTLD.IsChecked = true;
                QwantCheckBoxSOKWTLD.IsChecked = true;
                QwantCheckBoxKWTLD.IsChecked = true;
            }));
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void QwantLblGeneratedDorks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void QwantBtnOpenSaveFolder_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Process.Start("Qwant Dorks");
            }));
        }

        private void QwantBtnDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnDorkPatterns.Opacity = 0.70;
        }

        private void QwantBtnDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnDorkPatterns.Opacity = 1;
        }

        private void QwantBtnTLDExtension_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnTLDExtension.Opacity = 0.70;
        }

        private void QwantBtnTLDExtension_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnTLDExtension.Opacity = 1;
        }

        private void QwantBtnKeywords_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnKeywords.Opacity = 0.70;
        }

        private void QwantBtnKeywords_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnKeywords.Opacity = 1;
        }

        private void QwantBtnPageTypes_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnPageTypes.Opacity = 0.70;
        }

        private void QwantBtnPageTypes_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnPageTypes.Opacity = 1;
        }

        private void QwantBtnSearchOperators_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnSearchOperators.Opacity = 0.70;
        }

        private void QwantBtnSearchOperators_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnSearchOperators.Opacity = 1;
        }

        private void QwantBtnClearSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnClearSelectionDorkPatterns.Opacity = 0.70;
        }

        private void QwantBtnClearSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnClearSelectionDorkPatterns.Opacity = 1;
        }

        private void QwantBtnAllSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnAllSelectionDorkPatterns.Opacity = 0.70;
        }

        private void QwantBtnAllSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnAllSelectionDorkPatterns.Opacity = 1;
        }

        private void QwantBtnCleantxtBoxTLDExtensionField_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnCleantxtBoxTLDExtensionField.Opacity = 0.70;
        }

        private void QwantBtnCleantxtBoxTLDExtensionField_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnCleantxtBoxTLDExtensionField.Opacity = 1;
        }

        private void QwantBtnCleantxtBoxKeywordsField_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnCleantxtBoxKeywordsField.Opacity = 0.70;
        }

        private void QwantBtnCleantxtBoxKeywordsField_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnCleantxtBoxKeywordsField.Opacity = 1;
        }

        private void QwantBtnCleantxtBoxPageTypesField_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnCleantxtBoxPageTypesField.Opacity = 0.70;
        }

        private void QwantBtnCleantxtBoxPageTypesField_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnCleantxtBoxPageTypesField.Opacity = 1;
        }

        private void QwantBtnCleantxtBoxSearchOperatorsField_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnCleantxtBoxSearchOperatorsField.Opacity = 0.70;
        }

        private void QwantBtnCleantxtBoxSearchOperatorsField_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnCleantxtBoxSearchOperatorsField.Opacity = 1;
        }

        private void QwantBtnGenerate_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnGenerate.Opacity = 0.70;
        }

        private void QwantBtnGenerate_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnGenerate.Opacity = 1;
        }

        private void QwantBtnOpenSaveFolder_MouseEnter(object sender, MouseEventArgs e)
        {
            QwantBtnOpenSaveFolder.Opacity = 0.70;
        }

        private void QwantBtnOpenSaveFolder_MouseLeave(object sender, MouseEventArgs e)
        {
            QwantBtnOpenSaveFolder.Opacity = 1;
        }
    }
}
