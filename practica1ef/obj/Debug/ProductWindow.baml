   M S B A M L   `   `   `  ����F  Bpractica1ef, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:practica1efpractica1ef  5   	       practica1ef.ProductWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:practica1ef     5   	     � Title$  ProductWindow��5   	   $	��450��6   $	��800��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5   
   �  � ColumnDefinitions 5      �� 5      $��4* �6#   �� 5      .+�5      �� -   5         ��Name$ 
Searchetxt��5      �� 5      -   5        $��
Поиск��5      $��1��6%   $��20��6J   $	��Top=�6V   5      � 5   
   $��1��6    5      �� 5      $��4* �6#   �� 5      .+�5      �� -   5         ��Name$ ComTxt��5   8    �� DisplayMemberPath$ CategoryName��6   6H   �� 5      -   5        $��Очистить��5      $��1��6(   68   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gridProduct��5      $��2��6(   5!      5"      