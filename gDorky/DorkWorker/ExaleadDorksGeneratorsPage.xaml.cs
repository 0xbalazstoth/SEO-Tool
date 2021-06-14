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
    public partial class ExaleadDorksGeneratorsPage : Window
    {
        static bool ExaleadIsBtnDorkPatternsClicked = false;
        static bool ExaleadIsBtnTLDExtensionClicked = false;
        static bool ExaleadIsBtnKeywordsClicked = false;
        static bool ExaleadIsBtnSearchOperatorsClicked = false;

        static List<TLDExtension> ExaleadTLDExtensionData = new List<TLDExtension>();
        static TLDExtension ExaleadTLDExtension;

        static List<Keywords> ExaleadKeywordsData = new List<Keywords>();
        static Keywords ExaleadKeywords;

        static List<SearchOperators> ExaleadSearchOperatorsData = new List<SearchOperators>();
        static SearchOperators ExaleadSearchOperators;

        static string rootFolderName;

        static int GeneratedDorks = 0;
        public ExaleadDorksGeneratorsPage()
        {
            InitializeComponent();

            CreateDirectory("Exalead Dorks");
        }

        private void CreateDirectory(string folderName)
        {
            rootFolderName = folderName;
            if (!Directory.Exists(rootFolderName))
            {
                Directory.CreateDirectory(rootFolderName);
            }
        }

        private void ExaleadAppBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ExaleadBtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExaleadBtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ExaleadBtnDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (ExaleadIsBtnTLDExtensionClicked)
                    ExaleadBtnTLDExtension.BorderThickness = new Thickness(0);
                if (ExaleadIsBtnKeywordsClicked)
                    ExaleadBtnKeywords.BorderThickness = new Thickness(0);
                if (ExaleadIsBtnSearchOperatorsClicked)
                    ExaleadBtnSearchOperators.BorderThickness = new Thickness(0);

                ExaleadBtnDorkPatterns.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                ExaleadBtnDorkPatterns.BorderThickness = new Thickness(2);
                ExaleadIsBtnDorkPatternsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    ExaleadDorkPatternsUI.Visibility = Visibility.Visible;
                    ExaleadTLDExtensionUI.Visibility = Visibility.Hidden;
                    ExaleadKeywordsUI.Visibility = Visibility.Hidden;
                    ExaleadSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void ExaleadBtnTLDExtension_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (ExaleadIsBtnDorkPatternsClicked)
                    ExaleadBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (ExaleadIsBtnKeywordsClicked)
                    ExaleadBtnKeywords.BorderThickness = new Thickness(0);
                if (ExaleadIsBtnSearchOperatorsClicked)
                    ExaleadBtnSearchOperators.BorderThickness = new Thickness(0);

                ExaleadBtnTLDExtension.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                ExaleadBtnTLDExtension.BorderThickness = new Thickness(2);
                ExaleadIsBtnTLDExtensionClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    ExaleadDorkPatternsUI.Visibility = Visibility.Hidden;
                    ExaleadTLDExtensionUI.Visibility = Visibility.Visible;
                    ExaleadKeywordsUI.Visibility = Visibility.Hidden;
                    ExaleadSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void ExaleadBtnKeywords_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (ExaleadIsBtnDorkPatternsClicked)
                    ExaleadBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (ExaleadIsBtnTLDExtensionClicked)
                    ExaleadBtnTLDExtension.BorderThickness = new Thickness(0);
                if (ExaleadIsBtnSearchOperatorsClicked)
                    ExaleadBtnSearchOperators.BorderThickness = new Thickness(0);

                ExaleadBtnKeywords.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                ExaleadBtnKeywords.BorderThickness = new Thickness(2);
                ExaleadIsBtnKeywordsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    ExaleadDorkPatternsUI.Visibility = Visibility.Hidden;
                    ExaleadTLDExtensionUI.Visibility = Visibility.Hidden;
                    ExaleadKeywordsUI.Visibility = Visibility.Visible;
                    ExaleadSearchOperatorsUI.Visibility = Visibility.Hidden;
                }));
            }));
        }

        private void ExaleadBtnSearchOperators_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                if (ExaleadIsBtnDorkPatternsClicked)
                    ExaleadBtnDorkPatterns.BorderThickness = new Thickness(0);
                if (ExaleadIsBtnKeywordsClicked)
                    ExaleadBtnKeywords.BorderThickness = new Thickness(0);
                if (ExaleadIsBtnTLDExtensionClicked)
                    ExaleadBtnTLDExtension.BorderThickness = new Thickness(0);

                ExaleadBtnSearchOperators.BorderBrush = new SolidColorBrush(Colors.DarkGray);
                ExaleadBtnSearchOperators.BorderThickness = new Thickness(2);
                ExaleadIsBtnSearchOperatorsClicked = true;

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    ExaleadDorkPatternsUI.Visibility = Visibility.Hidden;
                    ExaleadTLDExtensionUI.Visibility = Visibility.Hidden;
                    ExaleadKeywordsUI.Visibility = Visibility.Hidden;
                    ExaleadSearchOperatorsUI.Visibility = Visibility.Visible;
                }));
            }));
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
        }

        private void ExaleadBtnCleantxtBoxKeywordsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                ExaleadTxtBoxKeywordsField.Clear();
            }));

        }

        private void ExaleadBtnCleantxtBoxSearchOperatorsField_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                ExaleadTxtBoxSearchOperatorsField.Clear();
            }));
        }

        private void ExaleadBtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            string DateNow = $"{DateTime.Now.Year}-{DateTime.Now.Month.ToString("d2")}-{DateTime.Now.Day.ToString("d2")}-{DateTime.Now.Hour.ToString("d2")}-{DateTime.Now.Minute.ToString("d2")}-{DateTime.Now.Second.ToString("d2")}-{DateTime.Now.Millisecond.ToString("d2")}";
            FileStream fajl = new FileStream($"{rootFolderName}/Exalead-dorks-{DateNow}.txt", FileMode.Create);
            StreamWriter ki = new StreamWriter(fajl, Encoding.UTF8);

            HashSet<string> generatedDorks = new HashSet<string>();

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                ExaleadTLDExtensionData.Clear();
                ExaleadKeywordsData.Clear();
                ExaleadSearchOperatorsData.Clear();
                ExaleadLblGeneratedDorks.Content = "Please wait, now generating dorks!";
                GeneratedDorks = 0;
                ExaleadBtnOpenSaveFolder.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                ExaleadBtnGenerate.IsEnabled = false;
                ExaleadBtnCleantxtBoxKeywordsField.IsEnabled = false;
                ExaleadBtnCleantxtBoxSearchOperatorsField.IsEnabled = false;
                ExaleadBtnCleantxtBoxTLDExtensionField.IsEnabled = false;
                ExaleadBtnAllSelectionDorkPatterns.IsEnabled = false;
                ExaleadBtnClearSelectionDorkPatterns.IsEnabled = false;
                ExaleadCheckBoxSOKWTLD.IsEnabled = false;
                ExaleadCheckBoxSOKW.IsEnabled = false;
                ExaleadCheckBoxKWTLD.IsEnabled = false;
                ExaleadCheckBoxPrefix.IsEnabled = false;
                ExaleadCheckBoxSuffix.IsEnabled = false;
                ExaleadTxtBoxKeywordsField.IsEnabled = false;
                ExaleadTxtBoxSearchOperatorsField.IsEnabled = false;
                ExaleadTxtBoxTLDExtensionField.IsEnabled = false;
                ExaleadTreePattern.IsEnabled = false;
                ExaleadTreeSearch.IsEnabled = false;
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                for (int i = 0; i < ExaleadTxtBoxTLDExtensionField.LineCount; i++)
                {
                    ExaleadTLDExtension = new TLDExtension(ExaleadTxtBoxTLDExtensionField.GetLineText(i).Trim());
                    ExaleadTLDExtensionData.Add(ExaleadTLDExtension);
                }

                for (int i = 0; i < ExaleadTxtBoxKeywordsField.LineCount; i++)
                {
                    ExaleadKeywords = new Keywords(ExaleadTxtBoxKeywordsField.GetLineText(i).Trim());
                    ExaleadKeywordsData.Add(ExaleadKeywords);
                }

                for (int i = 0; i < ExaleadTxtBoxSearchOperatorsField.LineCount; i++)
                {
                    ExaleadSearchOperators = new SearchOperators(ExaleadTxtBoxSearchOperatorsField.GetLineText(i).Trim());
                    ExaleadSearchOperatorsData.Add(ExaleadSearchOperators);
                }

                Console.WriteLine("Done with uploading user input datas!");
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    ExaleadLblGeneratedDorks.Content = "Please wait, now generating dorks...";
                }));

                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                {
                    if (ExaleadCheckBoxSOKWTLD.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < ExaleadSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < ExaleadKeywordsData.Count; actKeyword++)
                            {
                                for (int actTLD = 0; actTLD < ExaleadTLDExtensionData.Count; actTLD++)
                                {
                                    
                                    Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                    {
                                        Console.WriteLine($"{ExaleadSearchOperatorsData[actSearchOperator].SearchOperator} {(ExaleadCheckBoxPrefix.IsChecked == true ? $"{ExaleadTxtBoxPrefix.Text}" : "")}{ExaleadKeywordsData[actKeyword].Keyword}{(ExaleadCheckBoxSuffix.IsChecked == true ? $"{ExaleadTxtBoxSuffix.Text}" : "")} {ExaleadTLDExtensionData[actTLD].TLD}");
                                        ki.WriteLine($"{ExaleadSearchOperatorsData[actSearchOperator].SearchOperator} {(ExaleadCheckBoxPrefix.IsChecked == true ? $"{ExaleadTxtBoxPrefix.Text}" : "")}{ExaleadKeywordsData[actKeyword].Keyword}{(ExaleadCheckBoxSuffix.IsChecked == true ? $"{ExaleadTxtBoxSuffix.Text}" : "")} {ExaleadTLDExtensionData[actTLD].TLD}");
                                        ki.Flush();

                                        GeneratedDorks++;
                                        ExaleadLblGeneratedDorks.Visibility = Visibility.Visible;
                                        ExaleadLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                        generatedDorks.Add($"{ExaleadSearchOperatorsData[actSearchOperator].SearchOperator} {(ExaleadCheckBoxPrefix.IsChecked == true ? $"{ExaleadTxtBoxPrefix.Text}" : "")}{ExaleadKeywordsData[actKeyword].Keyword}{(ExaleadCheckBoxSuffix.IsChecked == true ? $"{ExaleadTxtBoxSuffix.Text}" : "")} {ExaleadTLDExtensionData[actTLD].TLD}");
                                    }));
                                }
                            }
                        }
                    }

                    if (ExaleadCheckBoxSOKW.IsChecked == true)
                    {
                        for (int actSearchOperator = 0; actSearchOperator < ExaleadSearchOperatorsData.Count; actSearchOperator++)
                        {
                            for (int actKeyword = 0; actKeyword < ExaleadKeywordsData.Count; actKeyword++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{ExaleadSearchOperatorsData[actSearchOperator].SearchOperator} {(ExaleadCheckBoxPrefix.IsChecked == true ? $"{ExaleadTxtBoxPrefix.Text}" : "")}{ExaleadKeywordsData[actKeyword].Keyword}{(ExaleadCheckBoxSuffix.IsChecked == true ? $"{ExaleadTxtBoxSuffix.Text}" : "")}");
                                    ki.WriteLine($"{ExaleadSearchOperatorsData[actSearchOperator].SearchOperator} {(ExaleadCheckBoxPrefix.IsChecked == true ? $"{ExaleadTxtBoxPrefix.Text}" : "")}{ExaleadKeywordsData[actKeyword].Keyword}{(ExaleadCheckBoxSuffix.IsChecked == true ? $"{ExaleadTxtBoxSuffix.Text}" : "")}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    ExaleadLblGeneratedDorks.Visibility = Visibility.Visible;
                                    ExaleadLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{ExaleadSearchOperatorsData[actSearchOperator].SearchOperator} {(ExaleadCheckBoxPrefix.IsChecked == true ? $"{ExaleadTxtBoxPrefix.Text}" : "")}{ExaleadKeywordsData[actKeyword].Keyword}{(ExaleadCheckBoxSuffix.IsChecked == true ? $"{ExaleadTxtBoxSuffix.Text}" : "")}");
                                }));
                            }
                        }
                    }

                    if (ExaleadCheckBoxKWTLD.IsChecked == true)
                    {
                        for (int actKeyword = 0; actKeyword < ExaleadKeywordsData.Count; actKeyword++)
                        {
                            for (int actTLD = 0; actTLD < ExaleadTLDExtensionData.Count; actTLD++)
                            {
                                Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
                                {
                                    Console.WriteLine($"{(ExaleadCheckBoxPrefix.IsChecked == true ? $"{ExaleadTxtBoxPrefix.Text}" : "")}{ExaleadKeywordsData[actKeyword].Keyword}{(ExaleadCheckBoxSuffix.IsChecked == true ? $"{ExaleadTxtBoxSuffix.Text}" : "")} {ExaleadTLDExtensionData[actTLD].TLD}");
                                    ki.WriteLine($"{(ExaleadCheckBoxPrefix.IsChecked == true ? $"{ExaleadTxtBoxPrefix.Text}" : "")}{ExaleadKeywordsData[actKeyword].Keyword}{(ExaleadCheckBoxSuffix.IsChecked == true ? $"{ExaleadTxtBoxSuffix.Text}" : "")} {ExaleadTLDExtensionData[actTLD].TLD}");
                                    ki.Flush();

                                    GeneratedDorks++;
                                    ExaleadLblGeneratedDorks.Visibility = Visibility.Visible;
                                    ExaleadLblGeneratedDorks.Content = $"Generated dorks: {GeneratedDorks}";
                                    generatedDorks.Add($"{(ExaleadCheckBoxPrefix.IsChecked == true ? $"{ExaleadTxtBoxPrefix.Text}" : "")}{ExaleadKeywordsData[actKeyword].Keyword}{(ExaleadCheckBoxSuffix.IsChecked == true ? $"{ExaleadTxtBoxSuffix.Text}" : "")} {ExaleadTLDExtensionData[actTLD].TLD}");
                                }));
                            }
                        }
                    }
                }));
            }));

            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                ExaleadBtnGenerate.IsEnabled = true;
                ExaleadBtnCleantxtBoxKeywordsField.IsEnabled = true;
                ExaleadBtnCleantxtBoxSearchOperatorsField.IsEnabled = true;
                ExaleadBtnCleantxtBoxTLDExtensionField.IsEnabled = true;
                ExaleadBtnAllSelectionDorkPatterns.IsEnabled = true;
                ExaleadBtnClearSelectionDorkPatterns.IsEnabled = true;
                ExaleadCheckBoxKWTLD.IsEnabled = true;
                ExaleadCheckBoxSOKWTLD.IsEnabled = true;
                ExaleadCheckBoxSOKW.IsEnabled = true;
                ExaleadCheckBoxPrefix.IsEnabled = true;
                ExaleadCheckBoxSuffix.IsEnabled = true;
                ExaleadTxtBoxKeywordsField.IsEnabled = true;
                ExaleadTxtBoxSearchOperatorsField.IsEnabled = true;
                ExaleadTxtBoxTLDExtensionField.IsEnabled = true;
                ExaleadTreePattern.IsEnabled = true;
                ExaleadTreeSearch.IsEnabled = true;
                ExaleadBtnOpenSaveFolder.IsEnabled = true;
                ExaleadBtnOpenSaveFolder.Visibility = Visibility.Visible;
            }));

            ki.Close();
            Console.WriteLine("Kész");
            if ((GeneratedDorks - generatedDorks.Count) >= 1)
                ExaleadLblGeneratedDorks.Content += $" | Removed duplicates: {GeneratedDorks - generatedDorks.Count}";
            File.Delete($"{rootFolderName}/Exalead-dorks-{DateNow}.txt");
            StreamWriter ki2 = new StreamWriter($"{rootFolderName}/{generatedDorks.Count}-Exalead-dorks-{DateNow}.txt");
            foreach (var item in generatedDorks)
            {
                ki2.WriteLine(item);
                ki2.Flush();
            }
            ki2.Close();
        }

        private void ExaleadBtnClearSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                ExaleadCheckBoxSOKWTLD.IsChecked = false;
                ExaleadCheckBoxKWTLD.IsChecked = false;
                ExaleadCheckBoxSOKW.IsChecked = false;
            }));
        }

        private void ExaleadBtnCleantxtBoxTLDExtensionField_Click(object sender, RoutedEventArgs e)
        {
            ExaleadTxtBoxTLDExtensionField.Clear();
        }

        private void ExaleadBtnAllSelectionDorkPatterns_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                ExaleadCheckBoxSOKWTLD.IsChecked = true;
                ExaleadCheckBoxKWTLD.IsChecked = true;
                ExaleadCheckBoxSOKW.IsChecked = true;
            }));
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ExaleadLblGeneratedDorks_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ExaleadBtnOpenSaveFolder_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.Invoke(DispatcherPriority.Background, new Action(() =>
            {
                Process.Start("Exalead Dorks");
            }));
        }

        private void ExaleadBtnDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnDorkPatterns.Opacity = 0.70;
        }

        private void ExaleadBtnDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnDorkPatterns.Opacity = 1;
        }

        private void ExaleadBtnTLDExtension_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnTLDExtension.Opacity = 0.70;
        }

        private void ExaleadBtnTLDExtension_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnTLDExtension.Opacity = 1;
        }

        private void ExaleadBtnKeywords_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnKeywords.Opacity = 0.70;
        }

        private void ExaleadBtnKeywords_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnKeywords.Opacity = 1;
        }

        private void ExaleadBtnSearchOperators_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnSearchOperators.Opacity = 0.70;
        }

        private void ExaleadBtnSearchOperators_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnSearchOperators.Opacity = 1;
        }

        private void ExaleadBtnClearSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnClearSelectionDorkPatterns.Opacity = 0.70;
        }

        private void ExaleadBtnClearSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnClearSelectionDorkPatterns.Opacity = 1;
        }

        private void ExaleadBtnAllSelectionDorkPatterns_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnAllSelectionDorkPatterns.Opacity = 0.70;
        }

        private void ExaleadBtnAllSelectionDorkPatterns_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnAllSelectionDorkPatterns.Opacity = 1;
        }

        private void ExaleadBtnCleantxtBoxTLDExtensionField_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnCleantxtBoxTLDExtensionField.Opacity = 0.70;
        }

        private void ExaleadBtnCleantxtBoxTLDExtensionField_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnCleantxtBoxTLDExtensionField.Opacity = 1;
        }

        private void ExaleadBtnCleantxtBoxKeywordsField_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnCleantxtBoxKeywordsField.Opacity = 0.70;
        }

        private void ExaleadBtnCleantxtBoxKeywordsField_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnCleantxtBoxKeywordsField.Opacity = 1;
        }

        private void ExaleadBtnCleantxtBoxSearchOperatorsField_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnCleantxtBoxSearchOperatorsField.Opacity = 0.70;
        }

        private void ExaleadBtnCleantxtBoxSearchOperatorsField_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnCleantxtBoxSearchOperatorsField.Opacity = 1;
        }

        private void ExaleadBtnGenerate_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnGenerate.Opacity = 0.70;
        }

        private void ExaleadBtnGenerate_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnGenerate.Opacity = 1;
        }

        private void ExaleadBtnOpenSaveFolder_MouseEnter(object sender, MouseEventArgs e)
        {
            ExaleadBtnOpenSaveFolder.Opacity = 0.70;
        }

        private void ExaleadBtnOpenSaveFolder_MouseLeave(object sender, MouseEventArgs e)
        {
            ExaleadBtnOpenSaveFolder.Opacity = 1;
        }
    }
}
