   M S B A M L   `   `   `  ���� I  EDomaciRozpocet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DomaciRozpocetDomaciRozpocet      DomaciRozpocet.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:DomaciRozpocet     -     �Name$  MainWindow1�� � Title$ Domácí rozpočet��$	��450��$	��520�� � 
ResizeMode$ CanMinimize=� � 	Resources   DomaciRozpocet.Records   	MyRecords.   (DomaciRozpocet.ValueToCellColorConverter  ccConverter��%   &	        &	          .��� .+�� $��	130,0,0,0q� � RowDefinitions �� $	��18* ��� $
��199* �.+�&   System.Windows.Controls.DataGrid  -     Name$ 	DGRecords��$��0,0,0,0q�   AutoGenerateColumns$ False��#��[     AlternatingRowBackground
 �����   
IsReadOnly$
 True��	   CanUserReorderColumns$	 False��
   CanUserResizeColumns$
 False��   CanUserResizeRows$ False��$��2��"   VerticalScrollBarVisibility$ Visible=�   	CellStyle ��  �� 
TargetType*  $System.Windows.Controls.DataGridCell"  .���  �� Property �@��TextAlignment �� Value$ Center=���  � ��$ DemiBold"���  � ��$
 Wrap=�   ColumnHeaderStyle �� =  7System.Windows.Controls.Primitives.DataGridColumnHeader"  .���  � ��$ Center=���  � ��$
 Bold"�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Osoba��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding ��  �� Path$ Person� 	  ElementStyle �� " ��.���  � ��$
 Wrap=�  $ Datum��$ 70  �� $
 Date� �� StringFormat$ 
dd-MM-yyyy��  $ Důvod��$ 90  �� $ Reason� �� " ��.���  � ��$
 Wrap=�  $ Částka��$	 100  �� $ Amount� �� ConverterCulture$ cs-CZ��$ C�� �� " ��.���  � �� �� *Amount+ �� 	Converter# [ ��  � ��$
 Wrap=�� $��	0,0,390,0q�.+��� -    ��Name$ btnAdd��$��_Přidat��$
��Left=�$��	13,70,0,0q�$	��Top=�$	��100���� -   $ 	btnDelete��$��_Vymazat��$
��Left=�$��
13,100,0,0q�$	��Top=�$	��100���� -   $ 	btnFilter��$��
_Filtrovat��$
��Left=�$��
13,130,0,0q�$	��Top=�$	��100���� -   $ btnRemoveFilter��$��_Zrušit filtr��$
��Left=�$��
13,160,0,0q�$	��Top=�$	��100���� -   $ 	btnExport��$��_Export do .csv��$
��Left=�$��
13,190,0,0q�$	��Top=�$	��100���� -    ��Name$ lblTotalText��$��Center=�$��Celkem:��$��Center=�$	��Top=�$	��110��$��SemiBold"�$��	0,350,0,0q��� -	   $ lblTotal��$��Center=�$�� �� �� ContentStringFormat$ {0:C}��$��	0,370,0,0q�$��Center=�$	��Top=�$	��110��$��SemiBold"�