   M S B A M L   `   `   `  ���� I  EDomaciRozpocet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DomaciRozpocetDomaciRozpocet      DomaciRozpocet.AddWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:DomaciRozpocet     -     �Name$  AddWindo�� � Title$ Přidat záznam��$	��250��$	��250�� � WindowStartupLocation$ CenterOwner=� � WindowStyle$ SingleBorderWindow=� � 
ResizeMode$ NoResize=� � ShowInTaskbar$ False��.��� .+�	� -   $��radioIncome��$��45,10,130,180q� d� 	IsChecked$
 TrueY�.��
Příjem	� -   $��radioExpense��$��135,10,40,180q�.��Výdaj�� $��Osoba:��$
��Left=�$��	10,40,0,0q�$	��Top=��� $��Datum:��$
��Left=�$��	10,69,0,0q�$	��Top=��� $��Důvod:��$
��Left=�$��
10,101,0,0q�$	��Top=��� $��	Částka:��$
��Left=�$��
10,132,0,0q�$	��Top=��� -    ��Name$ tbPerson��$
��Left=�$��	62,44,0,0q�$�� �� �� TextWrapping$
 Wrap=�$	��Top=�$	��150��(  "System.Windows.Controls.DatePicker  -   	  Name$	 dpDate��$
��Left=�$��	62,72,0,0q�$	��Top=�$	��150��
   IsTodayHighlighted$

 True��   SelectedDateFormat$
 Long=�   FirstDayOfWeek$ Monday=��� -   $ tbReason��$
��Left=�$��
62,105,0,0q�$�� ��$
 Wrap=�$	��Top=�$	��150���� -   $ tbAmount��$
��Left=�$��
62,136,0,0q�$�� ��$
 Wrap=�$	��Top=�$	��150���� -    ��Name$ btnAdd��$��Přidat��$
��Left=�$��
14,171,0,0q�$	��Top=�$	��198��$��30�� �� 	IsDefault$
 True��