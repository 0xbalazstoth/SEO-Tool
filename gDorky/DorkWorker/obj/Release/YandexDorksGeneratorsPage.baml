   M S B A M L   `   `   `  ���� E  ADorkWorker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:DorkWorker
DorkWorker  *    $DorkWorker.YandexDorksGeneratorsPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     d `SciChart.Wpf.UI.Transitionz, Version=3.1.251.0, Culture=neutral, PublicKeyToken=8eea68d53aa73a835tz,http://schemas.abtsoftware.co.uk/transitionz  V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $localclr-namespace:DorkWorker  -     � Title$  YandexDorkGeneratorPage��$	��590��$	��800�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � AllowsTransparency .  � WindowState$ Normal=� � WindowStartupLocation$ CenterScreen=�
������ .��� -  'SciChart.Wpf.UI.Transitionz.Transitionz   Opacity 8  2SciChart.Wpf.UI.Transitionz.OpacityParamsExtension  �  �SciChart.Wpf.UI.Transitionz.BaseTransitionzExtension`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]   Duration$	 500Q�   From$ 0Q�		   To$	 1Q�
   TransitionOn$
 Loaded=�   Blur 5  /SciChart.Wpf.UI.Transitionz.BlurParamsExtension  $	 500Q�$ 20Q�$	 0Q�$
 Loaded=� � RowDefinitions �� $
��219* ��� $
��241* ��� $
��130* �.+��� 
�������+  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�   ShadowEdges$	 All=�$��3��$��10q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 2Q�   
BlurRadius$ 15Q�   RenderingBias$ Quality=� �� BitmapScalingMode$ HighQuality=�   Opacity$	 0.2Q��� -    ��Name$ YandexAppBar��
�������$	��780��$��40��$��Center=�$	��Top=�$��
10,10,10,0q�   $ 20Q�$	 0.1Q�$ 20Q�$ Quality=�   	Direction$	 -90Q��� -    ��Name$ YandexBtnClose�����#FF6A6A$��20��$��20��+  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 30��$��Right=�$	��Top=�$��	0,20,15,0q���Z� �� -   $ YandexBtnMin�����	#FFFFC948$��20��$��20��$ 30��$��Right=�$	��Top=�$��	0,20,40,0q���Z� � $��
10,50,10,0q�$��Center=�$	��780��.+��� -   $ YandexBtnDorkPatterns��$��0�� � UseLayoutRounding .  J� SnapsToDevicePixels . $ HighQuality=�$��Dork Patterns�����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��80��$��Center=�$��Center=�$	��142��$��19,44,619,45q�
����������	#FFECECEC$ Depth0=�$��0q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q��� -   $ YandexBtnTLDExtension��$��0�� .  . $ HighQuality=�$��TLD extension��$
��Bold"����	#FF4B4B4B$��Arial)�$��13(�$��0��$ 20��$��80��$��Center=�$��Center=�$	��142��$��169,44,469,45q�
����������	#FFECECEC$ Depth0=�$��0q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q��� -   $ YandexBtnKeywords��$��0�� .  . $ HighQuality=�$��Keywords�����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��80��$��Center=�$��Center=�$	��142��$��290,0q�
����������	#FFECECEC$ Depth0=�$��0q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q��� -   $ YandexBtnPageTypes��$��0�� .  . $ HighQuality=�$��	Pagetypes�����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��80��$��Center=�$��Center=�$	��142��$��469,44,169,45q�
����������	#FFECECEC$ Depth0=�$��0q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q��� -	   $ YandexBtnSearchOperators��$��0�� .  . $ HighQuality=�$��Search Operators�����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��80��$��Center=�$��Center=�$	��142��$��619,44,19,45q�
����������	#FFECECEC$ Depth0=�$��0q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q��� -
    ��Name$ YandexDorkPatternsUI��$y�Visible=�.  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Custom=�   MaterialDesignGroupBox#���   $ Depth3=�$��0q�$��
10,0,10,10q�$��1��$��2��.��� .+��� 
������� �� RadiusX$ 20�� �� RadiusY$ 20�� . $ HighQuality=�$��11,0,12,125q�$ Depth2=�$��Center=�$��Center=� �� 
LineHeight$ 2��$	��739��$	��200��   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 -35Q�)	  #MaterialDesignThemes.Wpf.HintAssist  	  Hint  �� ���	#FF363535" Write your dork patterns here...�� -   $) #YandexBtnClearSelectionDorkPatterns��$��Center=�$��Right=� .  . $ HighQuality=����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��51��$��57��
����������	#FFECECEC$ Depth0=�$��0q�$��0,-56,9,330q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q�.��'
  !MaterialDesignThemes.Wpf.PackIcon
  ! 
  Kind$! Clear=�$��30��$��25��" J� RenderTransformOrigin$" -0.12,0.467&��� -   # ��Name$# YandexCheckBoxSOKWFTTLD��-  'MaterialDesignThemes.Wpf.CheckBoxAssist$   CheckBoxSize$$ 50Q�% d� 	IsChecked$
% TrueY����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(� .  . $ HighQuality=�$��SO.KW.FT.TLD��$	��Top=�$
��Left=�$��	62,17,0,0q�$
��auto��$��51�����	#FF42C159�� -   $# YandexCheckBoxSOKWFT��$$ 50Q�$
% TrueY����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(� .  . $ HighQuality=�$��SO.KW.FT��$	��Top=�$
��Left=�$��	62,68,0,0q�$
��auto��$��51�����	#FF42C159�� -   $# YandexCheckBoxSOKWTLD��$$ 50Q�$
% TrueY����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(� .  . $ HighQuality=�$��	SO.KW.TLD��$	��Top=�$
��Left=�$��
62,119,0,0q�$
��auto��$��51�����	#FF42C159�� -   $# YandexCheckBoxKWFTTLD��$$ 50Q�$
% TrueY����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(� .  . $ HighQuality=�$��	KW.FT.TLD��$	��Top=�$
��Left=�$��
284,17,0,0q�$
��auto��$��51�����	#FF42C159�� -   $# YandexCheckBoxKWFT��$$ 50Q�$
% TrueY����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(� .  . $ HighQuality=�$��KW.FT��$	��Top=�$
��Left=�$��
284,68,0,0q�$
��auto��$��51�����	#FF42C159�� -   $# YandexCheckBoxKWTLD��$$ 50Q�$
% TrueY����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(� .  . $ HighQuality=�$��KW.TLD��$	��Top=�$
��Left=�$��284,119,0,0q�$
��auto��$��51�����	#FF42C159�� -   $' !YandexBtnAllSelectionDorkPatterns��$��Center=�$��Right=� .  . $ HighQuality=����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��51��$��57��
����������	#FFECECEC$ Depth0=�$��0q�$��0,-56,71,330q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q�.��
  $! 	SelectAll=�$��30��$��25��$" -0.12,0.467&��� -   $ YandexTLDExtensionUI��$y�Hidden=�$ Custom=�#���   $ Depth3=�$��0q�$��
10,0,10,10q�$��1��$��2��.��� .+��� -   & ��Name$#& YandexTxtBoxTLDExtensionField��"' �� VerticalScrollBarVisibility$
' Auto=�( �� TextWrapping$( WrapWithOverflow=�) �� TextAlignment$) Center=����	#FF4B4B4B$��Center=�$��40(�$��Arial)�$��
UltraLight"�.  (MaterialDesignThemes.Wpf.ScrollBarAssist*   ButtonsVisibility$* Visible=�1  +MaterialDesignThemes.Wpf.ScrollViewerAssist+   IsAutoHideEnabled+ . .  (MaterialDesignThemes.Wpf.TextFieldAssist,   DecorationVisibility$, Hidden=�-   UnderlineBrush
- ���� 
�������
������ .   TextFieldCornerRadius$. 20�� . $ HighQuality=�$��0q�$��11,0,12,125q�$ Depth2=�$��Center=�$��Center=�$ 2��/ �� 
AcceptsTab/ . 0 �� AcceptsReturn0 . $	��739��$	��200��1 �� 
CaretBrush1 �	#FF4B4B4B.��   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 -35Q�.��  �� ���	#FF363535&$Write your Top-level domains here....���� -   $+ %YandexBtnCleantxtBoxTLDExtensionField��$��Center=�$��Right=� .  . $ HighQuality=����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��51��$��57��
����������	#FFECECEC$ Depth0=�$��0q�$��0,-56,9,330q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q�.��
  $! Clear=�$��30��$��25��$" -0.12,0.467&��� -   $ YandexKeywordsUI��$y�Hidden=�$ Custom=�#���   $ Depth3=�$��0q�$��
10,0,10,10q�$��1��$��2��.��� .+��� -   $& YandexTxtBoxPrefix��
�������2   HasClearButton2 . 3 �� 	MaxLength$3 5��$
��Bold"�$, Hidden=�
- ���� 
������ $. 20��$��13(� . $��Center=�$
��Left=� . $ HighQuality=����	#FF4B4B4B$
) Left=�$	��Top=�$
��Left=�$��
56,-50,0,0q�$��85��$��38��{��� 4 �� ElementName$4 YandexCheckBoxPrefix��5 �� Path$5 	IsChecked�.��  �� ���	#FF3635356 �� TextAlignment$
6 Left=�$��80��Prefix.���� -   $& YandexTxtBoxKeywordsField��$
' Auto=�$( WrapWithOverflow=�$) Center=����	#FF4B4B4B$��Center=�$��40(�$��Arial)�$��
UltraLight"�$* Visible=�+ . $, Hidden=�
- ���� 
�������
������ $. 20�� . $ HighQuality=�$��0q�$��11,0,12,125q�$ Depth2=�$��Center=�$��Center=�$ 2��/ . 0 . $	��739��$	��200��1 �	#FF4B4B4B.��   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 -35Q�.��  �� ���	#FF363535Write your keywords here....���� -   $' !YandexBtnCleantxtBoxKeywordsField��$��Center=�$��Right=� .  . $ HighQuality=����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��51��$��57��
����������	#FFECECEC$ Depth0=�$��0q�$��0,-56,9,330q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q�.��
  $! Clear=�$��30��$��25��$" -0.12,0.467&��� -   $# YandexCheckBoxPrefix��$$ 50Q�$
% TrueY����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(� .  . $ HighQuality=�$	��Top=�$
��Left=�$��	6,-56,0,0q�$��50��$��51�����	#FF42C159�� -   $& YandexTxtBoxSuffix��
�������2 . $3 5��$
��Bold"�$, Hidden=�
- ���� 
������ $. 20��$��13(� . $��Center=�$
��Left=� . $ HighQuality=����	#FF4B4B4B$
) Left=�$	��Top=�$
��Left=�$��196,-50,0,0q�$��85��$��38��{��� *	IsChecked+$4 YandexCheckBoxSuffix��.��  �� ���	#FF363535$
6 Left=�$��80���� $�Suffix��.���� -   $# YandexCheckBoxSuffix��$$ 50Q�$
% TrueY����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(� .  . $ HighQuality=�$	��Top=�$
��Left=�$��146,-56,0,0q�$��50��$��51�����	#FF42C159�� $��Bottom=�$
��Left=�$	��176���� -   $ YandexPageTypesUI��$y�Hidden=�$ Custom=�#���   $ Depth3=�$��0q�$��
10,0,10,10q�$��1��$��2��.��� .+��� -   $ & YandexTxtBoxPageTypesField��$
' Auto=�$( WrapWithOverflow=�$) Center=����	#FF4B4B4B$��Center=�$��40(�$��Arial)�$��
UltraLight"�$* Visible=�+ . $, Hidden=�
- ���� 
�������
������ $. 20�� . $ HighQuality=�$��0q�$��11,0,12,125q�$ Depth2=�$��Center=�$��Center=�$ 2��/ . 0 . $	��739��$	��200��1 �	#FF4B4B4B.��   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 -35Q�.��  �� ���	#FF363535Write your pagetypes here....���� -   $( "YandexBtnCleantxtBoxPageTypesField��$��Center=�$��Right=� .  . $ HighQuality=����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��51��$��57��
����������	#FFECECEC$ Depth0=�$��0q�$��0,-56,9,330q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q�.��
  $! Clear=�$��30��$��25��$" -0.12,0.467&��� -    $ YandexSearchOperatorsUI��$y�Hidden=�$ Custom=�#���   $ Depth3=�$��0q�$��
10,0,10,10q�$��1��$��2��.��� .+��� -!   $&&  YandexTxtBoxSearchOperatorsField��$
' Auto=�$( WrapWithOverflow=�$) Center=����	#FF4B4B4B$��Center=�$��40(�$��Arial)�$��
UltraLight"�$* Visible=�+ . $, Hidden=�
- ���� 
�������
������ $. 20�� . $ HighQuality=�$��0q�$��11,0,12,125q�$ Depth2=�$��Center=�$��Center=�$ 2��/ . 0 . $	��739��$	��200��1 �	#FF4B4B4B.��   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 -35Q�.��  �� ���	#FF363535%#Write your search operators here....���� -"   $. (YandexBtnCleantxtBoxSearchOperatorsField��$��Center=�$��Right=� .  . $ HighQuality=����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��51��$��57��
����������	#FFECECEC$ Depth0=�$��0q�$��0,-56,9,330q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q�.��
  $! Clear=�$��30��$��25��$" -0.12,0.467&�R� -#   7 R�Name$7 YandexTreeSearch��$��Bottom=�$
��Left=�$��	256,0,0,5q�$	��106��$	��245��
�������$��Arial)�.@�Q� $��Search Operators��
�������$
��Bold"�$��16(����	#FF363535.@�Q� $	��url��
�������$��Light"�$��13(����	#FF363535-  'MaterialDesignThemes.Wpf.TreeViewAssist!8   SuppressAdditionalTemplate9   AdditionalTemplate#9 Z8 Q� $
��site��$��13(�
�������$��Light"����	#FF363535#9 Z8 Q� $
��host��$��13(�
�������$��Light"����	#FF363535#9 Z8 Q� $��rhost��$��13(����	#FF363535
�������$��Light"�#9 Z8 Q� $��domain��$��13(����	#FF363535
�������$��Light"�#9 Z8 Q� $
��mime��$��13(����	#FF363535
�������$��Light"�#9 Z8 Q� $
��lang��$��13(����	#FF363535
�������$��Light"�#9 Z8 Q� $
��date��$��13(����	#FF363535
�������$��Light"�#9 Z8 �� -$   $ YandexBtnGenerate��$��2��$��2q����	#FF42C159 .  . $ HighQuality=�$��Generate�����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��80��$��Center=�$��Center=�$	��142��
�������$ Depth0=�$��633,20,25,30q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q�R� -%   $7 YandexTreePattern��$	��Top=�$��2��$
��Left=�$��25,0,0,0q�$	��106��$	��245��
�������$��Arial)�.@�Q� $��Pattern explanation��
�������$
��Bold"�$��16(����	#FF363535.@�Q� $��SO: Search Operator��
�������$��Light"�$��13(����	#FF363535#9 Z8 Q� $��KW: Keyword��$��13(�
�������$��Light"����	#FF363535#9 Z8 Q� $��TLD: Top-level domain��$��13(�
�������$��Light"����	#FF363535#9 Z8 Q� $��FT: FileType��$��13(����	#FF363535
�������$��Light"�#9 Z8 �� -&   : ��Name$: YandexLblGeneratedDorks��$��Center=�$��Center=����	#FF363535$
��Bold"�$��15(�$
��auto��$��40��$	��Top=�$��Center=�$��0,10,0,0q��� -'   ; �� Orientation$; 
Horizontal=�$	��Top=�$
��Left=�$��	10,10,0,0q�$��40��.+��� $��Assets/yandex.png��$ HighQuality=� .  . $��27��$��51���� $��Yandex��$��Regular"�$��Center=�$��30(����#FE2400$��Center=�$
��auto���� -(   $ YandexBtnOpenSaveFolder��$��2��$��2q����	#FF2CABBF .  . $ HighQuality=����	#FF4B4B4B$��Arial)�$
��Bold"�$��13(�$��0��$ 20��$��80��$��Center=�$��Center=�$��63��
�������$ Depth0=�$��565,20,172,30q�   $ 20Q�$ 10Q�$ Quality=�$ HighQuality=�$
 0.15Q�$	 280Q�.��
  $! Folder=�$��50��$��40��$��Center=�$��Center=�