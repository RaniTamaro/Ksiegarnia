   M S B A M L   `   `   `  ����@  <Firma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Firma.ViewResourcesFirma.ViewResources  5      )clr-namespace:Firma.ViewsFirma.Views  5          Firma.Views.NowyTowarView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4restab!clr-namespace:Firma.ViewResources     5      +localclr-namespace:Firma.Views     5        � 	Resources  5
       �� Source�� 5   
   $! StyleZakladekResources.xaml?�6   %    .��5      �    	TloGlowne#��[  6    � ColumnDefinitions 5   
   �� 5      �� 5      $��50 �6   .+�5   
   �� .@�5      �� $��
1. Ogólne��6   .��5      �� .��5      � #��[  6    � RowDefinitions 5      �� 5      $
��Auto �6,   �� 5      $
��Auto �6,   �� 5      $
��Auto �6,   �� 5      $
��Auto �6,   �� 5      $
��Auto �6,    5      �� 5      �� 5      .+�5"      9� $��Dane Ogólne��6#     Expander#��[ 68   .��5#      �   TloExpanderG#��[ 6#    5$   "   �� 5%   &   �� 5&   &   �� 5'   &    5)   "   �� 5*   &   $
��Auto �64   �� 5+   &   $
��Auto �64   �� 5,   &   $
��Auto �64   �� 5-   &   $
��Auto �64   �� 5.   &   $
��Auto �64   .+�51   "   �� $
��Kod:��6(     LabelStPogrubiony#��[ 67   �� 52   "   $��	KSIĄŻKA��6*   $��1��69   $��2��6I     TextBoxStandardowy#��[ 6]   �� 54   "   $��1��6(   $��Nr katalogowy:��65     LabelStandardowy#��[ 6N   �� 55   "   $�� ��6*   $��1��62   $��1��6?   $��2��6O   #��[ 6c   �� 57   "   $��2��6)     BorderStylizacja#��[ 66   ._�58   &   �� $��Grupa:��6,     LabelStylizowany#��[ 6=   59   #   �� 5:   "   $��2��6+   $��1��68   $��2��6H     ComboBoxStandardowy#��[ 6\   .@�5;   &   �� $��Fantasy��63    �� 
IsSelected$
 True��6E   �� 5<   &   $��Romans��63   �� 5=   &   $��Horror��63   �� 5>   &   $��Młodzieżowa��63   5?   #   �� 5A   "   $��3��6(   $
��Typ:��65   #��[ 6D   �� 5B   "   $��3��6+   $��1��68   ${�False��6H   #��[ 6Z   .@�5C   &   �� $��Towar��63   $
 True��6C   �� 5D   &   $��Usługa��63   5E   #   �� 5F   "   $��3��6+   $��2��68   ${�False��6H   #��[ 6Z   .@�5G   &   �� $��Prosty��63   $
 True��6D   �� 5H   &   $��	Złożony��63   5I   #   5K      5L      9� 5N      $��VAT, EAN, PKWiU, CN��6#   $��1��6@   #��[ 6P   .��5O      � #��[ 6#    5P   "   �� 5Q   &   �� 5R   &   �� 5S   &   $��40 �67    5U   "   �� 5V   &   $
��Auto �64   �� 5W   &   $
��Auto �64   �� 5X   &   $
��Auto �64   �� 5Y   &   $
��Auto �64   �� 5Z   &   $
��Auto �64   .+�5]   "   �� #��[ 6)   ._�5^   &   �� $
��EAN:��6,   #��[ 6;   5_   #   �� 5`   "   $��1��6*   $��2��6:   #��[ 6N   �� 5b   "   $��1��6(   $��PKWiU:��65   #��[ 6F   �� 5c   "   $��1��6*   $��1��67   $��2��6G   #��[ 6[   �� 5e   "   $��2��6)   #��[ 66   ._�5f   &   �� $��Kod CN:��6,   #��[ 6>   5g   #   �� 5h   "   $��2��6+   $��1��68   #��[ 6H   .@�5i   &   �� $��
4901 10 00��63   5j   #   �� 5k   "   $��2��6)   $��2��66   $��25��6F    	 ButtonStandard#��[	 6R   .��5l   &   �� $��/Views/IconFiltr.png��6,   5m   #   �� 5o   "   $��3��6(   $��Stawka VAT:��65   #��[ 6K   �� 5p   "   $��3��6+   $��1��68   $��2��6H   #��[ 6\   .@�5q   &   �� $��5%��63   $
 True��6@   �� 5r   &   $��8%��63   �� 5s   &   $	��23%��63   5t   #   �� 5v   "   $��4��6(   $��Cena domyślna:��65   #��[ 6N   �� 5w   "   $��4��6+   $��1��68   $��2��6H   #��[ 6\   .@�5x   &   �� $��Zakupu��63   $
 True��6D   �� 5y   &   $��	Hurtowa 1��63   �� 5z   &   $��
Detaliczna��63   5{   #   5}      5~      9� 5�      $��Nazwa, kategorie��6#   $��1��6=   $��2��6J   #��[ 6^   .��5�      � #��[ 6#    5�   "   �� 5�   &   �� 5�   &   $
��1.5* �67   �� 5�   &   $
��2.8* �67    5�   "   �� 5�   &   $
��Auto �64   �� 5�   &   $
��Auto �64   �� 5�   &   $
��Auto �64   .+�5�   "   �� $��Nazwa:��6(   #��[ 69   �� 5�   "   $)��#Harry Potter i Kamień Filozoficzny��6*   $��1��6T   $��2��6d   " �� VerticalScrollBarVisibility$ Visible=�6x    
 TextBoxStandardowyGora#��[
 6�   �� 5�   "   $��1��6)   #��[ 66   ._�5�   &   �� $��Kategoria sprzedaży:��6,   #��[ 6K   5�   #   �� 5�   "   $��1��6+   $��1��68   #��[ 6H   .@�5�   &   �� $��Kategoria 1��63   �� 5�   &   $��Kategoria 2��63   �� 5�   &   $��Kategoria 3��63   5�   #   �� 5�   "   $��1��6*   $��2��67     TBStZablokowany#��[ 6G   �� 5�   "   $��2��6)   #��[ 66   ._�5�   &   �� $��Kategoria zakupu:��6,   #��[ 6H   5�   #   �� 5�   "   $��2��6+   $��1��68   #��[ 6H   .@�5�   &   �� $��Kategoria 1��63   �� 5�   &   $��Kategoria 2��63   �� 5�   &   $��Kategoria 3��63   5�   #   �� 5�   "   $��2��6*   $��2��67   #��[ 6G   5�      5�      9� 5�      $ ��Jednoska miary, opakowania��6#   $��2��6G   $��2��6T   #��[ 6h   .��5�      ��  �� Orientation$ 
Horizontal=�6)     TloExpanderS#��[ 6B   .+�5�   "   �� $��Jedn. podstawowa:��6(   $	��130��6D   #��[ 6P   �� 5�   "   $	��100��6+   #��[ 67   .@�5�   &   �� $	��Szt��63   $
 True��6A   �� 5�   &   $
��Zest��63   5�   #   �� 5�   "   $��Format całkwity��6+   $	��150��6E     ChBStStackPanel#��[ 6Q   5�      5�      9� 5�      $
��Ceny��6#   $��3��61   $��2��6>   #��[ 6R   .��5�      � #��[ 6#    5�   "   �� 5�   &   $
��Auto �64   �� 5�   &   $��* �64   .+�5�   "   &   System.Windows.Controls.DataGrid    TabelaStandard#��[ 6+      Columns 5�   &   0  *System.Windows.Controls.DataGridTextColumn  5�   *   ,  &System.Windows.Controls.DataGridColumn   Header$ 
Numer ceny��6=   	   
IsReadOnly$
	 True��6Q   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 90 6c      CanUserSort$
 True��6n   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6�   ��  �� Path$ Nazwa�  5�   *   $ Typ ceny��6=   $
	 True��6O   $
 80 6a    6m   �� $	 Typ�  5�   *   $
 Akt.��6=   $
 50 6K    6V   �� $	 Akt�  5�   *   $ Marża��6=    6L   �� $ Marza�  5�   *   $ Zaokr.��6=    6M   �� $ Zaokr�  5�   *   $ Offset��6=    6M   �� $	 Off�  5�   *   $ 
Cena netto��6=   $	
 100 6Q    6]   �� $ CenaN�  5�   *   $ Cena brutto��6=   $	
 100 6R    6^   �� $ CenaB�  5�   *   $ Waluta��6=    6M   �� $ Waluta�.@�5�   &   %  Firma.ViewResources.TowaryTable     Nazwa$ Zakupu��69   
   Typ$ Netto��6H   
   Akt$
 ----��6T      Marza$
 ----��6_      Zaokr$
 0,01��6l   
   Off$
 0,00��6y      CenaN$
 0.00~�6�      CenaB$
 0.00~�6�      Waluta$	 PLN��6�     5�   &   $ 	Hurtowa 1��69   $ Netto��6K   $	 Nie��6W   $ 5%��6a   $
 0,01��6l   $
 0,00��6y   $
 0.00~�6�   $
 0.00~�6�   $	 PLN��6�     5�   &   $ 	Hurtowa 2��69   $ Netto��6K   $	 Nie��6W   $	 10%��6a   $
 0,01��6m   $
 0,00��6z   $
 0.00~�6�   $
 0.00~�6�   $	 PLN��6�     5�   &   $ 
Detaliczna��69   $ Brutto��6L   $	 Nie��6Y   $	 15%��6c   $
 0,01��6o   $
 0,00��6|   $
 0.00~�6�   $
 0.00~�6�   $	 PLN��6�   5�   #   �� 5�   "   $��1��6)     BorderStandardowy#��[ 66   ._�5�   &   �� $ 
Horizontal=�61   .+�5�   *   �� $��Granica ceny:��60   $	��100��6H   #��[ 6T   �� 5�   *   $��60��63   #��[ 6>   .@�5�   .   �� $
��Brak��6;   $
 True��6J   �� 5�   .   $��1��6;   �� 5�   .   $��2��6;   5�   +   �� 5�   *   $��0,00%��62   ${�False��6?   $	��100��6Q     TBStZablokowanyPrawo#��[ 6]   �� 5�   *   $��Ceny nieaktywne��63   #��[ 6M   5�   '   5�   #   5�      5�      5�      5�      5�      �� 5�      $��2. Dodatkowe��6   .��5�      �� .��5�      � #��[  6    5�      �� 5�      $��1.75* �6/   �� 5�       5�      �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   .+�5�      9� $��	Opis, URL��6#   $��2��66   #��[ 6J   .��5�      � #��[ 6#    5�   "   �� 5�   &   $��60 �67   �� 5�   &   �� 5�   &   $��60 �67    5�   "   �� 5�   &   �� 5�   &   .+�5�   "   �� $
��URL:��6(   #��[ 67   �� 5�   "   $��1��6*   #��[ 6:   �� 5�   "   $��2��6)   #��[	 69   �� 5�   "   $
��Opis��6(   $��1��67   #��[ 6D   �� 5�   "   $��1��6*   $��1��67   $��2��6G     TBRozciągnięty#��[ 6[   5�      5�      9� 5     $��	Parametry��6#   $��1��66   #��[ 6C   .��5     � #��[ 6#    5  "   �� 5  &   $	��100 �67   �� 5  &   �� 5  &   $	��100 �67   �� 5  &    5	  "   �� 5
  &   �� 5  &   �� 5  &   �� 5  &   �� 5  &   .+�5  "   �� $��Kopiuj opis na fakturę��6+   $��2��6L     CheckBoxStandardowy#��[ 6`   �� 5  "   $*��$Pozwól na edycję nazwy na fakturze��6+   $��2��6X   $��2��6h   #��[ 6|   �� 5  "   $)��#Udostępniaj w cenniku zewnętrznym��6+   $��1��6W   $��2��6d   #��[ 6x   �� 5  "   $*��$Pozwól na edycję opisu na fakturze��6+   $��1��6X   $��2��6e   $��2��6u   #��[ 6�   �� 5  "   $��Karta nieaktywna��6+   $��2��6F   $��2��6S   #��[ 6g   �� 5  "   $��3��6)   #��[ 66   ._�5  &   �� $��Wydawca:��6,   #��[ 6?   5  #   �� 5  "   $��3��6+   $��1��68   #��[ 6H   .@�5  &   �� $��Mięta��63   �� 5  &   $��Media Rodzina��63   �� 5  &   $��
We Need Ya��63   �� 5   &   $��Waneko��63   �� 5!  &   $��	Studio JG��63   5"  #   �� 5#  "   $��3��6*   $��2��67   $��2��6G   #��[ 6[   �� 5%  "   $��Kod producenta��6(   $��4��6A   #��[ 6N   �� 5&  "   $��4��6*   $��1��67   #��[ 6G   �� 5'  "   $��4��6)   $��2��66   #��[ 6F   ._�5(  &   �� $��Marka��6,   #��[ 6<   5)  #   �� 5*  "   $��4��6+   $��3��68   #��[ 6H   .@�5+  &   �� $��Marka 1��63   �� 5,  &   $��Marka 2��63   �� 5-  &   $��Marka 3��63   5.  #   5/     50     9� 52     $��Koszt��6#   $��1��62   $��1��6?   #��[ 6O   .��53     � #��[ 6#    54  "   �� 55  &   �� 56  &   $��2* �67    58  "   �� 59  &   $
��Auto �64   �� 5:  &   $
��Auto �64   .+�5=  "   �� $��Typ kosztu usługi:��6+   $��1��6G     GroupBoxStandardowy#��[ 6W   .��5>  &   �� $ 
Horizontal=�61   .+�5?  *   	� $��
Procentowy��66   	� 5@  *   $��Kwotowy��66   5A  '   5B  #   �� 5D  "   $��Koszt usługi:��6(   $��1��6@   #��[ 6M   �� 5E  "   $��0.00%��6*   $��1��67   $��1��6D   #��[ 6T   5F     5G     9� 5I     $��Zamówienia��6#   $��2��67   $��2��6D   #��[ 6X   .��5J     � #��[ 6#    5K  "   �� 5L  &   $	��110 �67   �� 5M  &   $	��110 �67   �� 5N  &   $	��110 �67   �� 5O  &   �� 5P  &   $	��110 �67   �� 5Q  &   $	��200 �67    5S  "   �� 5T  &   �� 5U  &   �� 5V  &   .+�5Y  "   �� $��Ilość minimalna:��6(   #��[ 6C   �� 5Z  "   $	��500��6*   $��1��65     TBStandPrawo#��[ 6E   �� 5[  "   $��2��6+   #��[ 6;   .@�5\  &   �� $	��Szt��63   $
 True��6A   �� 5]  &   $
��Zest��63   5^  #   �� 5_  "   $��4��6)   #��[ 69   ._�5`  &   �� $��
Kontrahent��6,   #��[ 6A   5a  #   �� 5b  "   $��5��6+   #��[ 6;   .@�5c  &   �� $
��Muza��63   $
 True��6B   �� 5d  &   $��Matras��63   �� 5e  &   $��Yatta��63   5f  #   �� 5h  "   $��Ilość maksymalna:��6(   $��1��6D   #��[ 6Q   �� 5i  "   $��1.000��6*   $��1��67   $��1��6G   #��[ 6T   �� 5j  "   $��2��6+   $��1��6;   #��[ 6H   .@�5k  &   �� $	��Szt��63   $
 True��6A   �� 5l  &   $
��Zest��63   5m  #   �� 5n  "   $��	Matras SA��6*   $��1��6;   $��4��6H   $��2��6X   #��[ 6l   �� 5p  "   $��Zamawiać po:��6(   $��2��6?   #��[ 6L   �� 5q  "   $��2��6*   $��1��63   $��2��6C   #��[ 6P   �� 5r  "   $��2��6+   $��2��6;   #��[ 6H   .@�5s  &   �� $	��Szt��63   $
 True��6A   �� 5t  &   $
��Zest��63   5u  #   �� 5v  "   $��Kod u nadawcy��6(   $��4��6@   $��2��6P   #��[ 6]   �� 5w  "   $��2��6*   $��5��67   #��[ 6G   5y     5z     9� 5|     $��Urządzenia fiskalne��6#   $��3��6@   $��2��6M   #��[ 6a   .��5}     �� $ 
Horizontal=�6)   #��[ 6B   .+�5~  "   �� $
��PLU:��6(   $��50��67   #��[ 6B   �� 5  "   $	��180��6*   #��[ 66   �� 5�  "   $��40��6)   #��[	 64   �� 5�  "   $��83��6(   �� 5�  "   $��Nazwa:��6(   $��50��69   #��[ 6D   �� 5�  "   $	��300��6*   #��[ 66   �� 5�  "   $��40��6)   #��[	 64   5�     5�     5�     5�     5�     �� 5�     $��3. Grupy��6   .��5�     �� .��5�       #��[ 6    5�       5�     $	 Kod��61   $
	 True��6>   $	
 140 6P   $
 True��6\    6o   �� $	 Kod�  5�     $ Nazwa��61   $
	 True��6@   $	
 400 6R    6_   �� $ 
NazwaDluga�.@�5�       
   Kod$
 Kod1��6-      
NazwaDluga$ Dluga nazwa1��68     5�     $
 Kod2��6-   $ Dluga nazwa2��68     5�     $
 Kod3��6-   $ Dluga nazwa3��68   5�     5�     5�     5�     �� 5�  
   $��1��6   .+�5�     �� $��25��6   �� 5�     #��[	 6    � ToolTip$ Zapis��6=   .��5�     �� $��/Views/IconZapisz.png��6   5�     �� 5�     #��[	 6   $ Anuluj��6=   .��5�     �� $��/Views/IconAnuluj.png��6   5�     5�     5�     5�     