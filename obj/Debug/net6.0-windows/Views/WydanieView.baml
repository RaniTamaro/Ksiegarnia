   M S B A M L   `   `   `  ����@  <Firma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Firma.ViewResourcesFirma.ViewResources  5      )clr-namespace:Firma.ViewsFirma.Views  5          Firma.Views.WydanieView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4restab!clr-namespace:Firma.ViewResources     5      +localclr-namespace:Firma.Views     5        � 	Resources  5
       �� Source�� 5   
   $! StyleZakladekResources.xaml?�6   %    .��5      �    	TloGlowne#��[  6    � ColumnDefinitions 5   
   �� 5      �� 5      $��50 �6   .+�5   
   �� .@�5      �� $��
1. Ogólne��6   .��5      �� .��5      � #��[  6    � RowDefinitions 5      �� 5      $
��Auto �6,   �� 5      $
��Auto �6,   �� 5      $
��Auto �6,   �� 5      $
��Auto �6,    5      �� 5      $
��3.5* �6/   �� 5      .+�5!      ��  �� Orientation$ 
Horizontal=�6%   $��2��6>     TloExpanderS#��[ 6R   .+�5"      �� $��80��6%     BorderStylizacja#��[ 60   ._�5#   "   �� $��	Dokument:��6(     LabelStylizowanyPogrubiony#��[ 6<   5$      �� 5%      $��70��6'     ComboBoxStandardowy#��[ 62   .@�5&   "   �� $��PZ��6/    �� 
IsSelected$
 True��6<   �� 5'   "   $	��PZ2��6/   �� 5(   "   $	��PZ3��6/   5)      �� 5*      $��40��6$   �� 5+      $��Numer��6$   $��50��64     LabelStandardowy#��[ 6?   �� 5,      $��PZ��6&   $��70��60     TBStZablokowany#��[ 6;   �� 5-      $
��Auto��6&   $��70��62     TBStandPrawo#��[ 6=   �� 5.      $
��2018��6&   $��40��62   #��[ 6=   5/      9� 51      $��
Nagłówek��6#   $��1��65   $��2��6B     Expander#��[ 6V   .��52      �  	 TloExpanderG#��[	 6#    53   "   �� 54   &   $��1* �67   �� 55   &   $��2* �67   �� 56   &   $��4* �67    58   "   �� 59   &   �� 5:   &   �� 5;   &   .+�5>   "   ��  
 CBStylizowany#��[
 6+   .@�5?   &   �� $��
Kontrahent��63   $
 True��6H   �� 5@   &   $��Kontrahent1��63   �� 5A   &   $��Kontrahent2��63   5B   #   �� 5C   "   $��1��6+   #��[ 6;   .@�5D   &   �� $��	MagazyZew��63   $
 True��6G   �� 5E   &   $��Biuro��63   �� 5F   &   $��Biuro2��63   5G   #   �� 5H   "   $��Magazyn Zewnętrzny��6*   $��2��6D   #��[ 6T   �� 5J   "   $��1��6)   #��[ 66   ._�5K   &   �� $��	Kategoria��6,     LabelStylizowany#��[ 6@   5L   #   �� 5M   "   $��1��6+   $��1��68   #��[ 6H   .@�5N   &   �� $��Lektury��63   $
 True��6E   �� 5O   &   $��	Książki��63   �� 5P   &   $��Mangi��63   5Q   #   �� 5R   "   $��Lektory szkolne��6*   $��1��6A   $��2��6N     TextBoxStandardowy#��[ 6^   �� 5T   "   $��2��6)   #��[ 66   ._�5U   &   �� $��Magazyn��6,   #��[ 6>   5V   #   �� 5W   "   $��2��6+   $��1��68   #��[ 6H   .@�5X   &   �� $��Magazyn��63   $
 True��6E   �� 5Y   &   $��	Magazyn Z��63   5Z   #   �� 5[   "   $��Magazyn główny��6*   $��2��6@   $��2��6M   #��[ 6]   5]      5^      9� 5`      $��Daty i Wartości��6#   $��2��6<   #��[ 6I   .��5a      � #��[	 6#    5b   "   �� 5c   &   �� 5d   &   �� 5e   &    5g   "   �� 5h   &   �� 5i   &   .+�5l   "   ��   GroupBoxStandardowy#��[ 6+   .��5m   &   �  5n   *   �� 5o   .   $��1.55* �6?   �� 5p   .   $
��0.5* �6?   �� 5q   .   $
��1.5* �6?    5s   *   �� 5t   .   �� 5u   .   �� 5v   .   .+�5y   *   �� $��Data wystawienia:��60   #��[ 6L   (  "System.Windows.Controls.DatePicker  5z   *   $��2��65     DatePickerStandard#��[ 6E   �� 5|   *   $��Data przyjęcia:��60   $��1��6J   #��[ 6W     5}   *   $��1��65   $��2��6B   #��[ 6R   �� 5   *   $��Data przyjęcia:��60   $��2��6J   #��[ 6W   �� 5�   *   $��2��63   $��2��6@     CBStZablokowany#��[ 6P   .@�5�   .   �� $��Netto��6;   $
 True��6K   �� 5�   .   $��Brutto��6;   5�   +   5�   '   5�   #   �� 5�   "   $��1��6+   #��[ 6;   .��5�   &   �  5�   *   �� 5�   .   $��60 �6?   �� 5�   .   $��20 �6?   �� 5�   .    5�   *   �� 5�   .   �� 5�   .   �� 5�   .   .+�5�   *   �� $��Rabat:��60   #��[ 6A   �� 5�   *   $��0.00%��62   $��2��6?   #��[ 6O   5�   '   5�   #   �� 5�   "   $��2��6+   #��[ 6;   .��5�   &   �  5�   *   �� 5�   .   $��1.25* �6?   �� 5�   .   $
��0.4* �6?   �� 5�   .   $
��1.5* �6?    5�   *   �� 5�   .   �� 5�   .   �� 5�   .   �� 5�   .   .+�5�   *   �� $��Netto:��60   #��[ 6A   �� 5�   *   $��1070,95 PLN��62   $��2��6E     TBStZablokowanyPrawo#��[ 6U   �� 5�   *   $��Razem��60   $��1��6@     LabelStPogrubiony#��[ 6M   �� 5�   *   $��
1124,5 PLN��62   $��1��6D   $��2��6Q   #��[ 6a   $
��Bold"�6�   5�   '   5�   #   � 5�   "   $��1��6'   $��2��64    5�   &   �� 5�   *   $
��0.9* �6;   �� 5�   *   $
��0.4* �6;   �� 5�   *   $��* �6;   �� 5�   *   $
��0.9* �6;   �� 5�   *   $
��0.4* �6;   �� 5�   *   $��* �6;   .+�5�   &   �� $��Po terminie:��6,   #��[ 6C   �� 5�   &   $��1��6-     ButtonStandard#��[ 6=   �� 5�   &   $
��0,00��6.   $��2��6:   #��[ 6J   �� 5�   &   $��Zadłużenie��6,   $��3��6A   #��[ 6Q   �� 5�   &   $��4��6-   #��[ 6=   �� 5�   &   $
��0,00��6.   $��5��6:   #��[ 6J   5�   #   5�      5�      9� 5�      $��2��6#   $��1��60   #��[ 6@   .��5�      � #��[	 6#   .+�5�   "   �� #��[ 6+   .��5�   &   �� .+�5�   *   �� $��30��60   �� 5�   *   $!��Wartość podlegająca MPP:��60   #��[ 6S   �� 5�   *   $��0.00 PLN��62   #��[ 6B   5�   '   5�   #   5�      5�      &   System.Windows.Controls.DataGrid  5�      $��3��6#   $��2��60     TabelaStandard#��[ 6D      Columns 5�      4  .System.Windows.Controls.DataGridCheckBoxColumn  5�   "   ,  &System.Windows.Controls.DataGridColumn   Header$  ��69      Width5  /System.Windows.Controls.DataGridLengthConverter$ 20 6C   0  *System.Windows.Controls.DataGridTextColumn  5�   "   $	 Lp.��65   $ 30 6B   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6M   �� 
 �� Path$
 LP�  5�   "   $ Nazwa��65   $	 100 6D   	 6P   �� $
 NazwaTowaru�  5�   "   $ Ilość��65   $	 120 6D   	 6P   �� $
 Ilosc�  5�   "   $ Jm��65   $ 50 6A   	 6L   �� $
 JM�  5�   "   $ C.pocz.��65   $	 100 6F   	 6R   �� $
 CenaPoczatkowa�  5�   "   $ Rabat��65   $ 60 6D   	 6O   �� $
 Rabat�  5�   "   $
 Cena��65   $	 120 6C   	 6O   �� $

 Cena�  5�   "   $ 	Wartość��65   $	 120 6F   	 6R   �� $
 Wartosc�.@�5�      %  Firma.ViewResources.TowaryTable  	   LP$ 1��61      NazwaTowaru$ 	Balladyna��68      Ilosc$ 25Q�6P   	   Jm$	 SZT��6[      CenaPoczatkowa$ 19.99~�6d      Rabat$
 0.00~�6{      Cena$ 19.99~�6�      Wartosc$ 499.75~�6�     5�      $ 2��61   $ 	Krzyżacy��68   $ 10Q�6O   $	 SZT��6Z   $ 39.99~�6c   $
 0.00~�6z   $ 39.99~�6�   $ 399.90~�6�     5�      $ 3��61   $ Dziady cz.II��68   $ 15Q�6S   $	 SZT��6^   $ 14.99~�6g   $
 0.00~�6~   $ 14.99~�6�   $ 224.85~�6�   5�      5�      5�      5�      5�      �� 5�   
   $��1��6   .+�5�      �� $��25��6   �� 5�      #��[ 6    � ToolTip$ Zapis��6=   .��5�      �� $��/Views/IconZapisz.png��6   5�      �� 5�      #��[ 6   $ Anuluj��6=   .��5�      �� $��/Views/IconAnuluj.png��6   5�      5�      5�      5�      