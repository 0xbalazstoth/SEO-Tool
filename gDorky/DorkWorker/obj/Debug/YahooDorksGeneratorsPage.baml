   M S B A M L   `   `   `  ����E  ADorkWorker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DorkWorker
DorkWorker  5   	   )    #DorkWorker.YahooDorksGeneratorsPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   d `SciChart.Wpf.UI.Transitionz, Version=3.1.251.0, Culture=neutral, PublicKeyToken=8eea68d53aa73a835tz,http://schemas.abtsoftware.co.uk/transitionz  5   	   $localclr-namespace:DorkWorker  5   	   -   5          � Title$  YahooDorkGeneratorPage��5
   	   $	��590��6E   $	��800��6R    � 
ResizeMode$ NoResize=�6^    � WindowStyle$
 None=�6t    � AllowsTransparency .  � WindowState$ Normal=�6�    � WindowStartupLocation$ CenterScreen=�6�   
������ .��5      � -  'SciChart.Wpf.UI.Transitionz.Transitionz   Opacity 6   8  2SciChart.Wpf.UI.Transitionz.OpacityParamsExtension  �  �SciChart.Wpf.UI.Transitionz.BaseTransitionzExtension`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Duration$	 500Q�   From$ 0Q�		   To$	 1Q�
   TransitionOn$
 Loaded=�   Blur 6g   5  /SciChart.Wpf.UI.Transitionz.BlurParamsExtension  $	 500Q�$ 20Q�$	 0Q�$
 Loaded=� � RowDefinitions 5   
   �� 5      $
��219* �6   6,   �� 5      $
��241* �6   6,   �� 5      $
��130* �6   6,   .+�5   
   �� 
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�6!      ShadowEdges$	 All=�6R   $��3��6�   $��10q�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 2Q�6#      
BlurRadius$ 15Q�63      RenderingBias$ Quality=�6C    �� BitmapScalingMode$ HighQuality=�6[      Opacity$	 0.2Q�6�   5      �� 5   
   -   5         ��Name$ YahooAppBar��5      
�������$	��780��66   $��40��6B   $��Center=�6N   $	��Top=�6k   $��
10,10,10,0q�6�    5        5      $ 20Q�6#   $	 0.1Q�63   $ 20Q�6A   $ Quality=�6R      	Direction$	 -90Q�6j   5      �� 5   
   -   5         ��Name$ YahooBtnClose��5      ���#FF6A6A$��20��6T   $��20��6_   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 30��6k   $��Right=�6�   $	��Top=�6�   $��	0,20,15,0q�6�   ��6=   Z� 6�   �� 5   
   -   5        $ YahooBtnMin��5      ���	#FFFFC948$��20��6T   $��20��6_   $ 30��6k   $��Right=�6�   $	��Top=�6�   $��	0,20,40,0q�6�   ��6=   Z� 6�   � 5    
   $��
10,50,10,0q�6   $��Center=�6#   $	��780��6@   .+�5!      �� -   5        $ YahooBtnDorkPatterns��5!   "   $��0��6    � UseLayoutRounding .  J� SnapsToDevicePixels . $ HighQuality=�6�   $��Dork Patterns��6  ���	#FF4B4B4B$��Arial)�6N  $
��Bold"�6a  $��13(�6s  $��0��6�  $ 20��6�  $��80��6�  $��Center=�6�  $��Center=�6�  $	��142��6  $��19,44,619,45q�6  
����������	#FFECECEC$ Depth0=�6P  $��0q�6�   5"        5#      $ 20Q�6'   $ 10Q�67   $ Quality=�6H   $ HighQuality=�6`   $
 0.15Q�6�   $	 280Q�6�   5%      �� 5&      -   5        $ YahooBtnTLDExtension��5&   "   $��0��6    .  . $ HighQuality=�6�   $��TLD extension��6  $
��Bold"�67  ���	#FF4B4B4B$��Arial)�6`  $��13(�6s  $��0��6�  $ 20��6�  $��80��6�  $��Center=�6�  $��Center=�6�  $	��142��6  $��169,44,469,45q�6  
����������	#FFECECEC$ Depth0=�6Q  $��0q�6�   5'        5(      $ 20Q�6'   $ 10Q�67   $ Quality=�6H   $ HighQuality=�6`   $
 0.15Q�6�   $	 280Q�6�   5*      �� 5+      -   5        $ YahooBtnKeywords��5+   "   $��0��6    .  . $ HighQuality=�6�   $��Keywords��6  ���	#FF4B4B4B$��Arial)�69  $
��Bold"�6L  $��13(�6^  $��0��6l  $ 20��6|  $��80��6�  $��Center=�6�  $��Center=�6�  $	��142��6�  $��290,0q�6�  
����������	#FFECECEC$ Depth0=�64  $��0q�6e   5,        5-      $ 20Q�6'   $ 10Q�67   $ Quality=�6H   $ HighQuality=�6`   $
 0.15Q�6�   $	 280Q�6�   5/      �� 50      -   5        $ YahooBtnSearchOperators��50   "   $��0��6    .  . $ HighQuality=�6�   $��Search Operators��6+  ���	#FF4B4B4B$��Arial)�6]  $
��Bold"�6p  $��13(�6�  $��0��6�  $ 20��6�  $��80��6�  $��Center=�6�  $��Center=�6�  $	��289��6  $��471,44,20,45q�6  
����������	#FFECECEC$ Depth0=�6_  $��0q�6�   51        52      $ 20Q�6'   $ 10Q�67   $ Quality=�6H   $ HighQuality=�6`   $
 0.15Q�6�   $	 280Q�6�   54      55      �� 56   
   -	   5         ��Name$ YahooDorkPatternsUI��56      $y�Visible=�60   .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�6E      MaterialDesignGroupBox#���   6r   $ Depth3=�6�   $��0q�6�   $��
10,0,10,10q�6�   $��1��6�   $��2��6	  .��57      � .+�58      �� 
������� �� RadiusX$ 20��6)    �� RadiusY$ 20��66    . $ HighQuality=�6\   $��11,0,12,125q�6�   $ Depth2=�6�   $��Center=�6�   $��Center=�6�    �� 
LineHeight$ 2��6  $	��739��6  $	��200��6)   59        5:      $ 20Q�6+   $ 10Q�6;   $ Quality=�6L   $ HighQuality=�6d   $
 0.15Q�6�   $	 -35Q�6�   )	  #MaterialDesignThemes.Wpf.HintAssist  	  Hint  5<      �� 5=      ���	#FF363535" Write your dork patterns here...6]   5?      �� 5@      -
   5        $( "YahooBtnClearSelectionDorkPatterns��5@   P   $��Center=�6   $��Right=�64    .  . $ HighQuality=�6W  ���	#FF4B4B4B$��Arial)�6�  $
��Bold"�6�  $��13(�6�  $��0��6�  $ 20��6�  $��51��6  $��57��6  
����������	#FFECECEC$ Depth0=�6O  $��0q�6�  $��0,-56,9,330q�6�   5A        5B      $ 20Q�6+   $ 10Q�6;   $ Quality=�6L   $ HighQuality=�6d   $
 0.15Q�6�   $	 280Q�6�   .��5D      '
  !MaterialDesignThemes.Wpf.PackIcon
  ! 
  Kind$! Clear=�6.   $��30��6;   $��25��6G   " J� RenderTransformOrigin$" -0.12,0.467&�6R   5E      �� 5F      -   5        # ��Name$# YahooCheckBoxSOKWTLD��5F      -  'MaterialDesignThemes.Wpf.CheckBoxAssist$   CheckBoxSize$$ 50Q�69   % d� 	IsChecked$
% TrueY�6i   ���	#FF4B4B4B$��Arial)�6�   $
��Bold"�6�   $��13(�6�    .  . $ HighQuality=�6�   $��	SO.KW.TLD��6&  $	��Top=�6:  $
��Left=�6R  $��	62,17,0,0q�6m  $
��auto��6�  $��51��6�  ���	#FF42C1596�  �� 5G      -   5        $# YahooCheckBoxSOKW��5G      $$ 50Q�66   $
% TrueY�6f   ���	#FF4B4B4B$��Arial)�6�   $
��Bold"�6�   $��13(�6�    .  . $ HighQuality=�6�   $��SO.KW��6#  $	��Top=�63  $
��Left=�6K  $��	62,68,0,0q�6f  $
��auto��6y  $��51��6�  ���	#FF42C1596�  �� 5H      -   5        $# YahooCheckBoxKWTLD��5H      $$ 50Q�67   $
% TrueY�6g   ���	#FF4B4B4B$��Arial)�6�   $
��Bold"�6�   $��13(�6�    .  . $ HighQuality=�6�   $��KW.TLD��6$  $	��Top=�65  $
��Left=�6M  $��
62,119,0,0q�6h  $
��auto��6|  $��51��6�  ���	#FF42C1596�  �� 5I      -   5        $&  YahooBtnAllSelectionDorkPatterns��5I   P   $��Center=�6   $��Right=�64    .  . $ HighQuality=�6O  ���	#FF4B4B4B$��Arial)�6�  $
��Bold"�6�  $��13(�6�  $��0��6�  $ 20��6�  $��51��6  $��57��6  
����������	#FFECECEC$ Depth0=�6G  $��0q�6x  $��0,-56,71,330q�6�   5J        5K      $ 20Q�6+   $ 10Q�6;   $ Quality=�6L   $ HighQuality=�6d   $
 0.15Q�6�   $	 280Q�6�   .��5M      
  $! 	SelectAll=�6.   $��30��6?   $��25��6K   $" -0.12,0.467&�6V   5N      5O      5P      �� 5R   
   -   5        $ YahooTLDExtensionUI��5R      $y�Hidden=�60   $ Custom=�6D   #���   6q   $ Depth3=�6�   $��0q�6�   $��
10,0,10,10q�6�   $��1��6�   $��2��6  .��5S      � .+�5T      �� -   5        & ��Name$"& YahooTxtBoxTLDExtensionField��5T      "' �� VerticalScrollBarVisibility$
' Auto=�6@   ( �� TextWrapping$( WrapWithOverflow=�6c   ) �� TextAlignment$) Center=�6�   ���	#FF4B4B4B$��Center=�6�   $��40(�6�   $��Arial)�6�   $��
UltraLight"�6�   .  (MaterialDesignThemes.Wpf.ScrollBarAssist*   ButtonsVisibility$* Visible=�6  1  +MaterialDesignThemes.Wpf.ScrollViewerAssist+   IsAutoHideEnabled+ . .  (MaterialDesignThemes.Wpf.TextFieldAssist,   DecorationVisibility$, Hidden=�6�  -   UnderlineBrush
- ���� 
�������
������ .   TextFieldCornerRadius$. 20��6*   . $ HighQuality=�6}  $��0q�6�  $��11,0,12,125q�6�  $ Depth2=�6�  $��Center=�6  $��Center=�6   $ 2��6=  / �� 
AcceptsTab/ . 0 �� AcceptsReturn0 . $	��739��6y  $	��200��6�  1 �� 
CaretBrush1 �	#FF4B4B4B.��6�   5U        5V      $ 20Q�6+   $ 10Q�6;   $ Quality=�6L   $ HighQuality=�6d   $
 0.15Q�6�   $	 -35Q�6�   .��5W   &     5X      �� 5Y      ���	#FF363535&$Write your Top-level domains here...6a   .��5Z   6   5[      �� 5\      -   5        $* $YahooBtnCleantxtBoxTLDExtensionField��5\   P   $��Center=�6   $��Right=�64    .  . $ HighQuality=�6_  ���	#FF4B4B4B$��Arial)�6�  $
��Bold"�6�  $��13(�6�  $��0��6�  $ 20��6�  $��51��6  $��57��6!  
����������	#FFECECEC$ Depth0=�6W  $��0q�6�  $��0,-56,9,330q�6�   5]        5^      $ 20Q�6+   $ 10Q�6;   $ Quality=�6L   $ HighQuality=�6d   $
 0.15Q�6�   $	 280Q�6�   .��5`      
  $! Clear=�6.   $��30��6;   $��25��6G   $" -0.12,0.467&�6R   5a      5b      5c      �� 5e   
   -   5        $ YahooKeywordsUI��5e      $y�Hidden=�6,   $ Custom=�6@   #���   6m   $ Depth3=�6�   $��0q�6�   $��
10,0,10,10q�6�   $��1��6�   $��2��6  .��5f      � .+�5g      �� -   5        $& YahooTxtBoxPrefix��5g      
�������2   HasClearButton2 . 3 �� 	MaxLength$3 5��6�   $
��Bold"�6�   $, Hidden=�6�   
- ���� 
������ $. 20��6v  $��13(�6�   . $��Center=�6�  $
��Left=�6�   . $ HighQuality=�66  ���	#FF4B4B4B$
) Left=�6{  $	��Top=�6�  $
��Left=�6�  $��
56,-50,0,0q�6�  $��85��6�  $��38��6�  {�65   �� 4 �� ElementName$4 YahooCheckBoxPrefix��5 �� Path$5 	IsChecked�.��6�    5h      �� 5i      ���	#FF3635356 �� TextAlignment$
6 Left=�6;   $��80��6P   Prefix6c   .��5j   6   5k      �� 5l      -   5        $& YahooTxtBoxKeywordsField��5l      $
' Auto=�6<   $( WrapWithOverflow=�6_   $) Center=�6   ���	#FF4B4B4B$��Center=�6�   $��40(�6�   $��Arial)�6�   $��
UltraLight"�6�   $* Visible=�6
  + . $, Hidden=�6�  
- ���� 
�������
������ $. 20��6&   . $ HighQuality=�6y  $��0q�6�  $��11,0,12,125q�6�  $ Depth2=�6�  $��Center=�6  $��Center=�6  $ 2��69  / . 0 . $	��739��6u  $	��200��6�  1 �	#FF4B4B4B.��6�   5m        5n      $ 20Q�6+   $ 10Q�6;   $ Quality=�6L   $ HighQuality=�6d   $
 0.15Q�6�   $	 -35Q�6�   .��5o   &     5p      �� 5q      ���	#FF363535Write your keywords here...6X   .��5r   6   5s      �� 5t      -   5        $&  YahooBtnCleantxtBoxKeywordsField��5t   P   $��Center=�6   $��Right=�64    .  . $ HighQuality=�6O  ���	#FF4B4B4B$��Arial)�6�  $
��Bold"�6�  $��13(�6�  $��0��6�  $ 20��6�  $��51��6  $��57��6  
����������	#FFECECEC$ Depth0=�6G  $��0q�6x  $��0,-56,9,330q�6�   5u        5v      $ 20Q�6+   $ 10Q�6;   $ Quality=�6L   $ HighQuality=�6d   $
 0.15Q�6�   $	 280Q�6�   .��5x      
  $! Clear=�6.   $��30��6;   $��25��6G   $" -0.12,0.467&�6R   5y      �� 5z      -   5        $# YahooCheckBoxPrefix��5z      $$ 50Q�68   $
% TrueY�6h   ���	#FF4B4B4B$��Arial)�6�   $
��Bold"�6�   $��13(�6�    .  . $ HighQuality=�6�   $	��Top=�6%  $
��Left=�6=  $��	6,-56,0,0q�6X  $��50��6k  $��51��6v  ���	#FF42C1596�  �� 5{      -   5        $& YahooTxtBoxSuffix��5{      
�������2 . $3 5��6�   $
��Bold"�6�   $, Hidden=�6�   
- ���� 
������ $. 20��6q  $��13(�6�   . $��Center=�6�  $
��Left=�6�   . $ HighQuality=�61  ���	#FF4B4B4B$
) Left=�6v  $	��Top=�6�  $
��Left=�6�  $��196,-50,0,0q�6�  $��85��6�  $��38��6�  {�65   �� *	IsChecked+$4 YahooCheckBoxSuffix��.��6�    5|      �� 5}      ���	#FF363535$
6 Left=�6;   $��80��6P   �� 6\   $�Suffix��6`   6q   .��5~   6   5      �� 5�      -   5        $# YahooCheckBoxSuffix��5�      $$ 50Q�68   $
% TrueY�6h   ���	#FF4B4B4B$��Arial)�6�   $
��Bold"�6�   $��13(�6�    .  . $ HighQuality=�6�   $	��Top=�6%  $
��Left=�6=  $��146,-56,0,0q�6X  $��50��6m  $��51��6x  ���	#FF42C1596�  �� 5�      $��Bottom=�6   $
��Left=�66   $	��176��6Q   5�      5�      �� 5�   
   -   5        $ YahooSearchOperatorsUI��5�      $y�Hidden=�63   $ Custom=�6G   #���   6t   $ Depth3=�6�   $��0q�6�   $��
10,0,10,10q�6�   $��1��6�   $��2��6  .��5�      � .+�5�      �� -   5        $%& YahooTxtBoxSearchOperatorsField��5�      $
' Auto=�6C   $( WrapWithOverflow=�6f   $) Center=�6�   ���	#FF4B4B4B$��Center=�6�   $��40(�6�   $��Arial)�6�   $��
UltraLight"�6�   $* Visible=�6  + . $, Hidden=�6�  
- ���� 
�������
������ $. 20��6-   . $ HighQuality=�6�  $��0q�6�  $��11,0,12,125q�6�  $ Depth2=�6�  $��Center=�6  $��Center=�6#  $ 2��6@  / . 0 . $	��739��6|  $	��200��6�  1 �	#FF4B4B4B.��6�   5�        5�      $ 20Q�6+   $ 10Q�6;   $ Quality=�6L   $ HighQuality=�6d   $
 0.15Q�6�   $	 -35Q�6�   .��5�   &     5�      �� 5�      ���	#FF363535%#Write your search operators here...6`   .��5�   6   5�      �� 5�      -   5        $- 'YahooBtnCleantxtBoxSearchOperatorsField��5�   P   $��Center=�6   $��Right=�64    .  . $ HighQuality=�6k  ���	#FF4B4B4B$��Arial)�6�  $
��Bold"�6�  $��13(�6�  $��0��6�  $ 20��6�  $��51��6!  $��57��6-  
����������	#FFECECEC$ Depth0=�6c  $��0q�6�  $��0,-56,9,330q�6�   5�        5�      $ 20Q�6+   $ 10Q�6;   $ Quality=�6L   $ HighQuality=�6d   $
 0.15Q�6�   $	 280Q�6�   .��5�      
  $! Clear=�6.   $��30��6;   $��25��6G   $" -0.12,0.467&�6R   5�      R� 5�      -   5        7 R�Name$7 YahooTreeSearch��5�      $��Bottom=�64   $
��Left=�6O   $��	256,0,0,5q�6j   $	��106��6}   $	��245��6�   
�������$��Arial)�6�   .@�5�      Q� $��Search Operators��6#   
�������$
��Bold"�6P   $��16(�6b   ���	#FF363535.@�5�      Q� $
��site��6'   
�������$��Light"�6H   $��13(�6[   ���	#FF363535-  'MaterialDesignThemes.Wpf.TreeViewAssist!8   SuppressAdditionalTemplate9   AdditionalTemplate#9 Z8 6�   Q� 5�      $��hostname��6'   $��13(�69   
�������$��Light"�6Z   ���	#FF363535#9 Z8 6�   Q� 5�      $
��link��6'   $��13(�65   
�������$��Light"�6V   ���	#FF363535#9 Z8 6�   Q� 5�      $	��url��6'   $��13(�64   ���	#FF363535
�������$��Light"�6l   #9 Z8 6   Q� 5�      $��inurl��6'   $��13(�66   ���	#FF363535
�������$��Light"�6n   #9 Z8 6�   Q� 5�      $��intitle��6'   $��13(�68   ���	#FF363535
�������$��Light"�6p   #9 Z8 6�   Q� 5�      $	��map��6'   $��13(�64   ���	#FF363535
�������$��Light"�6l   #9 Z8 6   Q� 5�      $��weather��6'   $��13(�68   ���	#FF363535
�������$��Light"�6p   #9 Z8 6�   Q� 5�      $��define��6'   $��13(�67   ���	#FF363535
�������$��Light"�6o   #9 Z8 6�   Q� 5�      $��convert��6'   $��13(�68   ���	#FF363535
�������$��Light"�6p   #9 Z8 6�   Q� 5�      $��region��6'   $��13(�67   ���	#FF363535
�������$��Light"�6o   #9 Z8 6�   5�      5�      5�      5�      �� 5�   
   -   5        $ YahooBtnGenerate��5�      $��2��6   $��2q�6�   ���	#FF42C159 .  . $ HighQuality=�6	  $��Generate��67  ���	#FF4B4B4B$��Arial)�6a  $
��Bold"�6t  $��13(�6�  $��0��6�  $ 20��6�  $��80��6�  $��Center=�6�  $��Center=�6�  $	��142��6  
�������$ Depth0=�65  $��633,20,25,30q�6f   5�        5�      $ 20Q�6#   $ 10Q�63   $ Quality=�6D   $ HighQuality=�6\   $
 0.15Q�6�   $	 280Q�6�   5�      R� 5�   
   -   5        $7 YahooTreePattern��5�      $	��Top=�6-   $��2��6E   $
��Left=�6R   $��25,0,0,0q�6m   $	��106��6   $	��245��6�   
�������$��Arial)�6�   .@�5�      Q� $��Pattern explanation��6   
�������$
��Bold"�6K   $��16(�6]   ���	#FF363535.@�5�      Q� $��SO: Search Operator��6   
�������$��Light"�6O   $��13(�6b   ���	#FF363535#9 Z8 6�   Q� 5�      $��KW: Keyword��6   $��13(�64   
�������$��Light"�6U   ���	#FF363535#9 Z8 6   Q� 5�      $��TLD: Top-level domain��6   $��13(�6>   
�������$��Light"�6_   ���	#FF363535#9 Z8 6�   5�      5�      �� 5�   
   -   5        : ��Name$: YahooLblGeneratedDorks��5�      $��Center=�6]   $��Center=�6   ���	#FF363535$
��Bold"�6�   $��15(�6�   $
��auto��6�   $��40��6�   $	��Top=�6�   $��Center=�6  $��0,10,0,0q�6(  �� 5�   
   -    5        ; �� Orientation$; 
Horizontal=�5�      $	��Top=�6O   $
��Left=�6g   $��	10,10,0,0q�6�   $��40��6�   .+�5�      �� $��Assets/yahoo.png��6   $ HighQuality=�6.    .  . $��27��6�   $��51��6�   �� 5�      $��Yahoo��6   $��Regular"�6%   $��Center=�6:   $��30(�6U   ���#673ab7$��Center=�6x   $
��auto��6�   5�      �� 5�   
   -!   5        $ YahooBtnOpenSaveFolder��5�      $��2��6   $��2q�6�   ���	#FF2CABBF .  . $ HighQuality=�6!  ���	#FF4B4B4B$��Arial)�6f  $
��Bold"�6y  $��13(�6�  $��0��6�  $ 20��6�  $��80��6�  $��Center=�6�  $��Center=�6�  $��63��6  
�������$ Depth0=�69  $��565,20,172,30q�6j   5�        5�      $ 20Q�6#   $ 10Q�63   $ Quality=�6D   $ HighQuality=�6\   $
 0.15Q�6�   $	 280Q�6�   .��5�      
  $! Folder=�6&   $��50��64   $��40��6@   $��Center=�6K   $��Center=�6f   5�      5�      5�      