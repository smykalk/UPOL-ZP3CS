   M S B A M L   `   `   `  ����I  EDomaciRozpocet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DomaciRozpocetDomaciRozpocet  5   	       DomaciRozpocet.AddWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DomaciRozpocet     5   	   -   5          �Name$  AddWindo��5   	    � Title$ Přidat záznam��5   	   $	��250��6   $	��250��6,    � WindowStartupLocation$ CenterOwner=�68    � WindowStyle$ SingleBorderWindow=�6\    � 
ResizeMode$ NoResize=�6}    � ShowInTaskbar$ False��6�   .��5	      � .+�5
   
   	� -   5        $��radioIncome��5
      $��45,10,130,180q�6)    d� 	IsChecked$
 TrueY�6@   .��6Q   
Příjem6Y   	� 5   
   -   5        $��radioExpense��5      $��135,10,40,180q�6+   .��6B   Výdaj6I   �� 5   
   $��Osoba:��6   $
��Left=�6!   $��	10,40,0,0q�6<   $	��Top=�6O   �� 5   
   $��Datum:��6   $
��Left=�6!   $��	10,69,0,0q�6<   $	��Top=�6O   �� 5   
   $��Důvod:��6   $
��Left=�6!   $��
10,101,0,0q�6<   $	��Top=�6P   �� 5   
   $��	Částka:��6   $
��Left=�6"   $��
10,132,0,0q�6=   $	��Top=�6Q   �� 5   
   -   5         ��Name$ tbPerson��5      $
��Left=�6$   $��	62,44,0,0q�6?   $�� ��6R    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��150��6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        	  Name$	 dpDate��5      $
��Left=�6%   $��	62,72,0,0q�6@   $	��Top=�6S   $	��150��6k   
   IsTodayHighlighted$

 True��6w      SelectedDateFormat$
 Long=�6�      FirstDayOfWeek$ Monday=�6�   �� 5   
   -   5        $ tbReason��5      $
��Left=�6$   $��
62,105,0,0q�6?   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��150��6�   �� 5   
   -   5        $ tbAmount��5      $
��Left=�6$   $��
62,136,0,0q�6?   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��150��6�   �� 5   
   -   5         ��Name$ btnAdd��5      $��Přidat��6!   $
��Left=�62   $��
14,171,0,0q�6M   $	��Top=�6a   $	��198��6y   $��30��6�    �� 	IsDefault$
 True��6�   5      5      