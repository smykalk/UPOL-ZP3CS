   M S B A M L   `   `   `  ����I  EDomaciRozpocet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DomaciRozpocetDomaciRozpocet  5   	       DomaciRozpocet.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DomaciRozpocet     5   	   -   5          �Name$  MainWindow1��5   	    � Title$ Domácí rozpočet��5   	   $	��450��6!   $	��520��6.    � 
ResizeMode$ CanMinimize=�6:    � 	Resources 5	        DomaciRozpocet.Records   	MyRecords.   (DomaciRozpocet.ValueToCellColorConverter  ccConverter��%:   &	        &	        5
   
   6     5   
   6*   5      .��5      � .+�5   
   � $��	130,0,0,0q�6    � RowDefinitions 5      �� 5      $	��18* �6    �� 5      $
��199* �6    .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	DGRecords��5   (   $��0,0,0,0q�6      AutoGenerateColumns$ False��6;   #��[  6W      AlternatingRowBackground
 �����   
IsReadOnly$
 True��6�   	   CanUserReorderColumns$	 False��6�   
   CanUserResizeColumns$
 False��6�      CanUserResizeRows$ False��6�   $��2��6,  "   VerticalScrollBarVisibility$ Visible=�6=     	CellStyle 5      �� 5       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6   .�5      ��  �� Property �@��TextAlignment �� Value$ Center=�6D   �� 5       � ��$ DemiBold"�67   �� 5       � ��$
 Wrap=�6C   5         ColumnHeaderStyle 5      �� 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  � ��$ Center=�6M   �� 5       � ��$
 Bold"�67   5         Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Osoba��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6X   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 68   ��  �� Path$ Person� 	  ElementStyle 5#      �� 5$      " ��6$   .�5%   "   ��  � ��$
 Wrap=�6A   5&      5(        5)      $ Datum��6)   $ 70 6p    68   �� $
 Date� �� StringFormat$ 
dd-MM-yyyy��6p     5*      $ Důvod��6)   $ 90 6X    68   �� $ Reason� 5+      �� 5,      " ��6$   .�5-   "   ��  � ��$
 Wrap=�6A   5.      50        51      $ Částka��6)   $	 100 6�    69   �� $ Amount� �� ConverterCulture$ cs-CZ��$ C�� 52      �� 53      " ��6$   .�54   "   ��  � �� 6?   �� *Amount+ �� 	Converter# [ �� 55   "    � ��$
 Wrap=�6A   56      58      5:      5;      � 5<   
   $��	0,0,390,0q�6   .+�5=      �� -   5         ��Name$ btnAdd��5=      $��_Přidat��6%   $
��Left=�67   $��	13,70,0,0q�6R   $	��Top=�6e   $	��100��6�   �� 5>      -   5        $ 	btnDelete��5>      $��_Vymazat��6(   $
��Left=�6;   $��
13,100,0,0q�6V   $	��Top=�6j   $	��100��6�   �� 5?      -   5        $ 	btnFilter��5?      $��
_Filtrovat��6(   $
��Left=�6=   $��
13,130,0,0q�6X   $	��Top=�6l   $	��100��6�   �� 5@      -   5        $ btnRemoveFilter��5@      $��_Zrušit filtr��6.   $
��Left=�6F   $��
13,160,0,0q�6a   $	��Top=�6u   $	��100��6�   �� 5A      -   5        $ 	btnExport��5A      $��_Export do .csv��6(   $
��Left=�6B   $��
13,190,0,0q�6]   $	��Top=�6q   $	��100��6�   �� 5B      -   5         ��Name$ lblTotalText��5B      $��Center=�6*   $��Celkem:��6N   $��Center=�6`   $	��Top=�6}   $	��110��6�   $��SemiBold"�6�   $��	0,350,0,0q�6�   �� 5C      -	   5        $ lblTotal��5C      $��Center=�6&   $�� ��6J    �� ContentStringFormat$ {0:C}��6U   $��	0,370,0,0q�6s   $��Center=�6�   $	��Top=�6�   $	��110��6�   $��SemiBold"�6�   5D      5E      5F      