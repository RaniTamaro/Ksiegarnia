   M S B A M L   `   `   `  ����@  <Firma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Firma.ViewResourcesFirma.ViewResources  5      )clr-namespace:Firma.ViewsFirma.Views  5      %    Firma.Views.WszystkieTowaryView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4restab!clr-namespace:Firma.ViewResources     5      +localclr-namespace:Firma.Views     5        � 	Resources  5
       �� Source�� 5   
   $! StyleZakladekResources.xaml?�6   %    .��5      �    	TloGlowne#��[  6    � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��280 �6   �� 5      $
��Auto �6   �� 5      $��0.25* �6   .+�5   
   ��   BorderStandardowy#��[ 6   ._�5      &   System.Windows.Controls.DataGrid    TabelaStandard#��[ 6      Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 6-   0  *System.Windows.Controls.DataGridTextColumn  5         Header$	 Kod��6)      CanUserSort$
 True��66   $	 120 6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6U   �� 	 �� Path$		 Kod�  5      $ Nazwa��6)   $	 200 68    6D   �� $	 Nazwa�  5      $ Grupa��6)   $	 120 68    6D   �� $	 Grupa�  5      $ Ilość��6)   $ 80 68    6C   �� $	 Ilosc�  5       $	 EAN��6)   $	 150 66    6B   �� $		 Ean�.@�5#      %  Firma.ViewResources.TowaryTable  

   Kod$
 	Książka��6%      Nazwa$) #Harry Potter i Kamień Filozoficzny��63      Grupa$ Fantasy��6^      Ilosc$ 25Q�6n   
   Ean$ 111122223333��6y     5$      $
 	Książka��6%   $% Harry Potter i Komnata Tajemnic��63   $ Fantasy��6[   $ 20Q�6k   $ 111122223333��6v     5%      $
 	Książka��6%   $) #Harry Potter i Więzień z Azkabanu��63   $ Fantasy��6]   $ 20Q�6m   $ 111122223333��6x     5&      $
 	Książka��6%   $  Harry Potter i Czara Ognia��63   $ Fantasy��6V   $ 20Q�6f   $ 111122223333��6q     5'      $
 	Książka��6%   $" Harry Potter i Zakon Feniksa��63   $ Fantasy��6X   $ 20Q�6h   $ 111122223333��6s     5(      $
 	Książka��6%   $' !Harry Potter i Książe Półkrwi��63   $ Fantasy��6Y   $ 20Q�6i   $ 111122223333��6t     5)      $
 	Książka��6%   $&  Harry Potter i Insignia Śmierci��63   $ Fantasy��6[   $ 20Q�6k   $ 111122223333��6v     5*      $
 Manga��6%   $ Jujutsu Kaisen 1��61   $ Akcja��6J   $ 15Q�6X   $ 111122223333��6c     5+      $
 Manga��6%   $ Jujutsu Kaisen 2��61   $ Akcja��6J   $ 10Q�6X   $ 111122223333��6c     5,      $
 Manga��6%   $ Jujutsu Kaisen 3��61   $ Akcja��6J   $ 10Q�6X   $ 111122223333��6c     5-      $
 Manga��6%   $ Jujutsu Kaisen 4��61   $ Akcja��6J   $ 10Q�6X   $ 111122223333��6c     5.      $
 Manga��6%   $ Jujutsu Kaisen 5��61   $ Akcja��6J   $ 10Q�6X   $ 111122223333��6c     5/      $
 	Książka��6%   $ 	Balladyna��63   $ Lektury��6E   $ 5Q�6U   $ 111122223333��6_     50      $
 	Książka��6%   $ 	Krzyżacy��63   $ Lektury��6D   $ 5Q�6T   $ 111122223333��6^     51      $
 	Książka��6%   $ Pan Tadeusz��63   $ Lektury��6G   $ 5Q�6W   $ 111122223333��6a   52      53      9� 55   
   $��1��6   $��Filtr aktywny��6      Expander#��[ 67   .��56      �   TloExpanderG#��[ 6    57      �� 58      �� 59      $��0.85* �6'   �� 5:      $��1.25* �6'   �� 5;      $
��0.4* �6'   �� 5<      �� 5=      $��2* �6'    5?      �� 5@      $
��Auto �6$   �� 5A      $
��Auto �6$   �� 5B      $
��Auto �6$   �� 5C      $
��Auto �6$   .+�5F      �� $	��Typ��6   $��4��6(     GroupBoxStandardowy#��[ 69   .��5G      �  5H      �� 5I      �� 5J      �� 5K      �� 5L      .+�5O      �� $��Towary proste��6#    d� 	IsChecked$
 TrueY�6;     CheckBoxStandardowy#��[ 6L   �� 5P      $��Towary złożone��6#   $��1��6<   $
 TrueY�6I   #��[ 6Z   5Q      5R      �� 5T      $��1��6     BorderStylizacja#��[ 6)   ._�5U      �� $��Magazyn��6     LabelStylizowany#��[ 6.   5V      �� 5W      $��2��6    	 ComboBoxStandardowy#��[	 6+   .@�5X      �� $��Magazyn��6#    �� 
IsSelected$
 True��65   �� 5Y      $��Magazyn Zew��6#   5Z      �� 5[      $��Data:��6   $��3��6(   (  "System.Windows.Controls.DatePicker  5\      $��4��6    
 DatePickerStandard#��[
 6-   �� 5^      $��Ceny:��6   $��1��6(   $��1��65     LabelStandardowy#��[ 6E   �� 5_      $��1��6   $��2��6(   #��[	 68   .@�5`      �� $��Netto��6#   $
 True��63   �� 5a      $��Brutto��6#   5b      �� 5c      $��Zerowe��6   $��1��6,   $��4��69   #��[ 6I   �� 5e      $��Tylko braki��6   $��2��61   $��4��6>   #��[ 6N   �� 5g      $	��EAN��6   $��3��6&   $��1��63   #��[ 6C   �� 5h      $��3��6   $��2��6'     TextBoxStandardowy#��[ 67   �� 5i      $��
Nieaktywne��6   $��3��60   $��4��6=   #��[ 6M   �� 5k      $��Towary udostępniome:��6   $��5��69   $��4��6I   #��[ 6Z   .��5l      �  5m      �� 5n      $
��Auto �6,   �� 5o      $
��Auto �6,   �� 5p      $
��Auto �6,    5r      �� 5s      $
��0.5* �6/   �� 5t      .+�5w      �� $��e-Sklep:��6    #��[ 63   �� 5x      $��1��6#   $��2��60   #��[	 6D   .@�5y      �� $��Opcja1��6+   �� 5z      $��Opcja2��6+   �� 5{      $��Opcja3��6+   5|      	� 5}      $	��Nie��6&   $��2��64     RadioButtonStandardowy#��[ 6A   	� 5~      $	��Tak��6&   $��2��64   $��1��6A   #��[ 6Q   5�      5�      5�      5�      5�      5�      