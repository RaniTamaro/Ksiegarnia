   M S B A M L   `   `   `  ����@  <Firma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Firma.ViewResourcesFirma.ViewResources  5      )clr-namespace:Firma.ViewsFirma.Views  5      '    !Firma.Views.WszyscyPracownicyView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4restab!clr-namespace:Firma.ViewResources     5      +localclr-namespace:Firma.Views     5        � 	Resources  5
       �� Source�� 5   
   $! StyleZakladekResources.xaml?�6   %    .��5      �� .��5   
   �    	TloGlowne#��[  6    � ColumnDefinitions 5      �� 5       � RowDefinitions 5      �� 5      $	��280 �6    �� 5      $
��Auto �6    �� 5      $��0.25* �6    .+�5      ��   BorderStandardowy#��[ 6   ._�5      &   System.Windows.Controls.DataGrid    TabelaStandard#��[ 6      Columns 5      4  .System.Windows.Controls.DataGridCheckBoxColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 30 61   0  *System.Windows.Controls.DataGridTextColumn  5         Header$ Akronim��6-      CanUserSort$
 True��6>   $	 100 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6]   �� 	 �� Path$	 Akronim�  5      $ Nazwisko��6-   $ 90 6?    6J   �� $	 Nazwisko�  5      $ Imię��6-   $ 90 6;    6F   �� $
	 Imie�  5       $ PESEL��6-   $	 120 6<    6H   �� $	 Pesel�  5!      $ Zatrudnienie��6-   $	 100 6C    6O   �� $	 Zatrudnienie�  5"      $ Stawka��6-   $ 80 6=    6H   �� $	 Stawka�  5#      $ Data zatrud.��6-   $	 140 6C    6O   �� $	 DataZatrudnienia�.@�5&      %  Firma.ViewResources.TowaryTable  
   Akronim$
 001/A��6)      Nazwisko$ Kowalski��69      Imie$	 Jan��6M      Pesel$ 11223300674��6X      Zatrudnienie$ Umowa��6l      Stawka$ 2500,00/mies.��6�      DataZatrudnienia$ 
2022-05-20��6�     5'      $
 002/A��6)   $ Kowalski��69   $	 Jan��6M   $ 11223300674��6X   $ Zlecenie��6l   $ 24,00/godz.��6�   $ 
2022-05-20��6�     5(      $
 003/A��6)   $ Kowalski��69   $	 Jan��6M   $ 11223300674��6X   $ Zlecenie��6l   $ 20,00/godz.��6�   $ 
2022-05-20��6�     5)      $
 004/A��6)   $ Kowalski��69   $	 Jan��6M   $ 11223300674��6X   $ Umowa��6l   $ 2800,00/mies.��6�   $ 
2022-05-20��6�     5*      $
 001/B��6)   $ Kowalski��69   $	 Jan��6M   $ 11223300674��6X   $ Umowa��6l   $ 3000,00/mies.��6�   $ 
2022-05-20��6�     5+      $
 001/C��6)   $ Kowalski��69   $	 Jan��6M   $ 11223300674��6X   $ Zlecenie��6l   $ 18,00/godz.��6�   $ 
2022-05-20��6�     5,      $
 002/B��6)   $ Kowalski��69   $	 Jan��6M   $ 11223300674��6X   $ Umowa��6l   $ 2500,00/mies.��6�   $ 
2022-05-20��6�     5-      $
 003/B��6)   $ Kowalski��69   $	 Jan��6M   $ 11223300674��6X   $ Umowa��6l   $ 2200,00/mies.��6�   $ 
2022-05-20��6�   5.      5/      9� 51      $��1��6   $��Filtr zaawansowany��6$     Expander#��[ 6@   .��52      �   TloExpanderG#��[ 6    53      �� 54      $��1* �6+   �� 55      $
��1.2* �6+   �� 56      $
��0.7* �6+   �� 57      �� 58      $
��1.2* �6+   �� 59      $
��0.9* �6+   �� 5:       5<      �� 5=      $
��Auto �6(   �� 5>      $
��Auto �6(   �� 5?      $
��Auto �6(   .+�5B      �� $��Lista:��6     LabelStandardowy#��[ 6-   �� 5C      $��1��6     ComboBoxStandardowy#��[ 6/   .@�5D      �� $��Wszyscy��6'    �� 
IsSelected$
 True��69   �� 5E      $��Zlecenie��6'   �� 5F      $��Umowa��6'   5G      �� 5H      $��Pokaż archiwalnych��6   $��2��6<   $��2��6L    d� 	IsChecked$
 TrueY�6`     CheckBoxStandardowy#��[ 6q   �� 5I      $��Data aktualności:��6   $��5��68   #��[ 6H   (  "System.Windows.Controls.DatePicker  5J      $��6��6!     DatePickerStandard#��[ 61   �� 5L      $��1��6    	 BorderStylizacja#��[	 6*   ._�5M      �� $��Centrum podległ.��6     
 LabelStylizowany#��[
 6;   5N      �� 5O      $��1��6   $��1��6,   #��[ 6<   .@�5P      �� $��Firma��6'   $
 True��67   �� 5Q      $��Sklep��6'   5R      �� 5S      $��	Podcentra��6   $��1��63   $��2��6@   #��[ 6P   �� 5T      $��1��6   $��3��6*   #��[	 6:   ._�5U      �� $��Wydział��6    #��[
 62   5V      �� 5W      $��1��6   $��4��6,   #��[ 6<   .@�5X      �� $��Firma��6'   $
 True��67   �� 5Y      $��Sklep��6'   5Z      �� 5[      $��Podwydziały��6   $��1��65   $��5��6B   #��[ 6R   �� 5]      $��2��6   #��[	 6*   ._�5^      �� $��	Kierownik��6    #��[
 64   5_      �� 5`      $��2��6   $��1��6,   #��[ 6<   .@�5a      �� $��Działu��6'   �� 5b      $��Sklepu��6'   �� 5c      $��Główny��6'   5d      �� 5e      $��2��6   $��2��6+   $��4��6;     TBStZablokowany#��[ 6O   5f      5g      5i      5j      5k      