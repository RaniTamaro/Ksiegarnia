   M S B A M L   `   `   `  ����@  <Firma, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Firma.ViewModelsFirma.ViewModels  5   	   clr-namespace:FirmaFirma  5   	       Firma.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   AControls,http://metro.mahapps.com/winfx/xaml/controls     5   	   4	ViewModelclr-namespace:Firma.ViewModels     5   	   %localclr-namespace:Firma     5   	     � Title$  Księgarnia��5
   	   $	��450��6   $
��1000��6)    � WindowState$ 	Maximized=�5   	    � 	Resources 5       �� Source�� 5   
   $ MainWindowResources.xaml?�6   %     J� InputBindings 5      �� 5   
   
 �� Key$ Z��6    �� 	Modifiers$ Ctrl+Altf�6    �� Command 62   �� *ZamknijAplikacjeCommand+�� 5   
   $ P��6   $ 
Ctrl+Shiftf�6    64   �� *PrzyjecieCommand+�� 5   
   $ W��6   $ 
Ctrl+Shiftf�6    64   �� *WydanieCommand+�� 5   
   $ T��6   $ Ctrl+Altf�6    62   �� *NowyTowarCommand+�� 5   
   $ T��6   $
 Ctrlf�6    6.   �� *TowaryCommand+�� 5   
   $ P��6   $ Ctrl+Altf�6    62   �� *NowyPracownikCommand+�� 5   
   $ P��6   $
 Ctrlf�6    6.   �� *PracownicyCommand+�� 5   
   $ F��6   $ Ctrl+Altf�6    62   �� *NowaFakturaCommand+�� 5   
   $ F��6   $
 Ctrlf�6    6.   �� *FakturyCommand+�� 5   
   $ W��6   $
 Ctrlf�6    6.   �� *NowaWyplataCommand+.��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��40 �6   �� 5       $��* �6   �� 5!      $��30 �6   	 � ColumnDefinitions	 5#   
   �� 5$      $
��Auto �6   �� 5%      .+�5(   
   o� $��0��6   $��0��6   $��2��6,   $��3q�6@   .@�5)      m� $
��Plik��6   .@�5*      m� $��_Zamknij��6   
 m� InputGestureText$
 
Ctrl+Alt+Z��6Y    m� Command 6-   �� *ZamknijAplikacjeCommand+ m� Icon 5+      �� 5,      $��/Views/IconZamknij.png��6    5.      5/      m� 50      $��_Magazyn��6   .@�51      m� $��Towary��6   .@�52      m� $��	Dodawanie��6   $
 
Ctrl+Alt+T��6W    62   �� *NowyTowarCommand+ 53      �� 54      $��/Views/IconNowyTowar.png��6$   56      m� 57      $��	Wszystkie��6   $
 Ctr+T��6T    62   �� *TowaryCommand+6T   58      m� 59      $��Przyjecie zewnetrzne (PZ)��6   $
 Ctrl+Shift+P��6c    6>   �� *PrzyjecieCommand+ 5:      �� 5;      $��/Views/IconPrzyjecie.png��6    5=      m� 5>      $��Wydanie zewnetrzne (WZ)��6   $
 Ctrl+Shift+W��6_    6<   �� *WydanieCommand+ 5?      �� 5@      $��/Views/IconWydanie.png��6    5B      5C      m� 5D      $��
Pracownicy��6   .@�5E      m� $��	Pracownik��6   .@�5F      m� $��Dodaj��6   $
 
Ctrl+Alt+P��6W    6.   �� *NowyPracownikCommand+ 5G      �� 5H      $$��/Views/IconDodajPracownika.png��6$   5J      5K      m� 5L      $��Wyswietl wszystkich��6   $
 Ctrl+P��6^    68   �� *PracownicyCommand+ 5M      �� 5N      $��/Views/IconPracownicy.png��6    5P      5Q      m� 5R      $��_Ksiegowosc��6   .@�5S      m� $��Faktury��6   .@�5T      m� $��Dodaj nową��6   $
 
Ctrl+Alt+F��6Z    63   �� *NowaFakturaCommand+ 5U      �� 5V      $ ��/Views/IconNowaFaktura.png��6$   5X      m� 5Y      $��Wyświetl wszystkie��6   $
 Ctrl+F��6^    6;   �� *FakturyCommand+ 5Z      �� 5[      $��/Views/IconFaktury.png��6$   5]      5^      m� 5_      $��Wyplaty��6   .@�5`      m� $��Dodaj wypłatę��6   $
 Ctrl+W��6]    66   �� *NowaWyplataCommand+6]   5a      5b      5c      c� 5e   
   $��1��6   $��0��6   .@�5f      d� $��32��6   $��32��6&   $��2q�62    � ToolTip$ Zamknij zakładki��6=   .��5g      �� $��/Views/IconHome.png��6   5h      �� 5i      d� 5j      $��32��6   $��32��6&   $��2q�62   $! Dodaj fakturę (Ctrl+Alt+F)��6b   ��6=   �� *NowyTowarCommand+��5k      �� 5l       �� ImageSource$ /Views/IconNowyTowar.png��6!   5n      d� 5o      $��32��6   $��32��6&   $��2q�62   $0 *Nowe przyjęcie zewnętrzne (Ctrl+Shift+P)��6b   ��6=   �� *PrzyjecieCommand+��5p      �� 5q      $ /Views/IconPrzyjecie.png��6!   5s      d� 5t      $��32��6   $��32��6&   $��2q�62   $- 'Nowe wydanie zewnętrzne (Ctrl+Shift+W)��6`   ��6=   �� *WydanieCommand+��5u      �� 5v      $ /Views/IconWydanie.png��6!   5x      �� 5y      d� 5z      $��32��6   $��32��6&   $��2q�62   $ Nowa faktura (Ctrl+Alt+F)��6d   ��6=   �� *NowaFakturaCommand+��5{      �� 5|      $  /Views/IconNowaFaktura.png��6!   5~      d� 5      $��32��6   $��32��6&   $��2q�62   $  Wszystkie faktury (Ctrl+F)��6`   ��6=   �� *FakturyCommand+��5�      �� 5�      $ /Views/IconFaktury.png��6!   5�      5�      � 5�   
   ���#E4E6C3$��1��6$   $��1��61   � 5�   
   $��2��6   $��2��6   	 5�      �� 5�      $
��Auto �6#   �� 5�      $��* �6#   .+�5�      � $��0��6   .+�5�      � -   5         �Name$ 
menuBoczne��5�      ���#E4E6C3$
��Left=�6@   ��6[   �� *SzerokoscKolumnyMenu+.+�5�      �� .+�5�      � $��40��6   .+�5�      d�  
  TBMenu#��[  6+   $ Rozwijanie menu boczne��6�   ��6K   �� *" PokazUkryjMenuBoczneAsyncCommand+ �� IsAsync$
 True��{�6�   �� *DostepnoscPrzycisku+.��5�   "   �� $��/Views/IconMenu.png��6(   5�      5�      �� 5�      $	��150��6!   
������ 
������ ._�5�      �� $��Operacje��5�   !   
������ $
��Bold"�5�   !   $��Center=�5�   !     CommandsTemplate#��[ 5�   !     MainHCCStyle#��[ 5�   !   ��5�   !   �� *
Commands+5�   !   5�      5�      5�      5�      �� 5�      $��1��6   ._�5�      �� $��Przestrzeń robocza��5�      
������   WorkspacesTemplate#��[ 5�      #��[ 5�      ��5�      ��  �� Path$ 
Workspaces�5�      5�      5�      �� 5�   
   $��3��6   $��2��6!   .@�5�      �� .��5�      ��   TextBlockStandard#��[ 6   Klaudia Kurela6W   5�      �� 5�      $��Right=�6   .��5�      ��  �� Orientation$ 
Horizontal=�6   .+�5�      �� #��[ 6    Administrator6Z   �� 5�      -   5         ��Name$ WyswietlCzas��5�       #��[ 66   � 5�      .+�5�      d� -   5        $��button��5�   K     
TBBezRamki#��[ 6'   .��5�      �� $ ��/Views/IconAktywność.png��6$   6H   5�      � 5�       	 PopUp#��[ 6    ��6?   �� *	IsChecked+ �� ElementName$ button��.��5�      ��   BorderPopUP#��[ 6%   ._�5�   "   �� .+�5�   &   �� $
��Bold"�60   $��24(�6B   $��Center=�6P   Powiadomienia6|   �� 5�   &   $��Center=�60   Brak powiadomień6_   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      