   M S B A M L   `   `   `  ����I  EDomaciRozpocet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:DomaciRozpocetDomaciRozpocet  5   	   !    DomaciRozpocet.FilterWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:DomaciRozpocet     5   	     � Title$  Filtrovat záznamy��5   	   $	��200��6#   $	��200��60    � ShowInTaskbar$ False��6<    � 
ResizeMode$ NoResize=�6R    � WindowStartupLocation$ CenterOwner=�6h   .��5	      � .+�5
   
   �� -   5         ��Name$ cbFilterSelection��5
      $��20,20,20,120q�6.    �� 
IsReadOnly$
 True��6D   $y�Visible=�6V   .@�5      �� $��Příjmy��6   �� 5      $��Výdaje��6   �� 5      $��Osoba��6   �� 5      $��Důvod��6   �� 5      $��Datum - od-do��6   �� 5      $��Částka - >=��6   �� 5      $��Částka - <=��6   5      �� 5   
   -   5         ��Name$ tbValue��5      $�� ��6#   $��20,70,20,70q�6+   $y�Hidden=�6@   �� 5   
   -   5         ��Name$ lblFrom��5      $	��Od:��6!   $��15,52,130,82q�6/   $y�Hidden=�6E   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpFrom��5      $��45,55,20,85q�6%   $y�Hidden=�6:   �� 5   
   -   5        $ lblTo��5      $	��Do:��6   $��15,88,130,47q�6-   $y�Hidden=�6C     5   
   -   5        $
 dpTo��5      $��45,90,20,50q�6#   $y�Hidden=�68   �� 5   
   -   5        	 ��Name$	 	btnFilter��5      $��	Filtrovat��6$   $��20,124,20,20q�68   ${�False��6f   
 �� 	IsDefault$

 True��6x   5      5      