   M S B A M L   `   `   `  ����I  EEmployeeSearch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:EmployeeSearchEmployeeSearch  5   	       EmployeeSearch.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:EmployeeSearch     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Employee Search��5   	   $	��450��6!   $	��800��6.   .��5      �  � RowDefinitions 5   
   �� 5      $	��20* �6   �� 5      $
��100* �6   �� 5      $	��20* �6   .+�5   
   ]� $��Center=�6   $��10 0 0 0q�6/   $��0��6A   .+�5      d� -   5        $��DarkModeToggle��5   <   $��Center=�6R    d� 	IsChecked 6   �� *
IsDarkMode+6�   �� 5      $��0 0 0 3q�6   	Dark Mode65   5      ]� 5   
   $��0��6   $��Right=�6!   .+�5      �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Employee Name...��6   $��35��6d   $��10q�6p   $	��240��6|   $��Center=�6�   ��6H   �� *
SearchText+6�   �� 5      -   5        $��Search_Button��5      $��10q�6*   $	��100��66   $
��Left=�6B   .��6y   Search6�   5      �� 5   
   $��1��6_   $��5q�6l   ��6   �� *	Employees+ �� SelectedItem 65   �� *SelectedEmployee+ �� View 5       �� 5!      P�5"      �� 5#      $��ID��6)    �� Width$ 90��65   	 �� CellTemplate	 5$      �� 5%   "   .R�5&   &   �� $��45��6,   $��Center=�67   $��Center=�6[   .��5'   *   �� ��64   �� *Id+6J   5(   '   5)   #   5+      �� 5,      $
��Name��6)   $	 180��67   	 5-      �� 5.   "   .R�5/   &   �� $��Center=�6,   $��Center=�6I   .��50   *   �� ��64   �� *Name+6L   51   '   52   #   54      �� 55      $��Position��6)   $	 150��6;   	 56      �� 57   "   .R�58   &   �� $��Center=�6,   $��Center=�6I   .��59   *   �� ��64   �� *
Position+6P   5:   '   5;   #   5=      �� 5>      $��Hourly Rate��6)   $	 180��6>   	 5?      �� 5@   "   .R�5A   &   �� $
��Left=�6,   $
��Left=�6N   .��5B   *   �� ��64   �� *	HourlyPay+6Q   5C   '   5D   #   5F      5H      5J      �� 5K   
   
 �� Orientation$
 
Horizontal=�6   $��Right=�6.   $��0 0 5 0q�6J   $��2��6[   .+�5L      '  !MaterialDesignThemes.Wpf.Snackbar  -   5          Name$ Snackbar��5L   �   $��0��6&   $
��Left=�66   $��
10 0 70 10q�6Q   $��Center=�6e      MessageQueue 6�   4  .MaterialDesignThemes.Wpf.MessageQueueExtension  5M      �� 5N      -   5        $��Delete��5N      $��5q�6#   
���\\��$	��100��6E   .��6f   Delete6n   �� 5O      -   5        $
��Edit��5O      $��5q�6!   
�����_�$	��100��6C   .��6b   Edit6h   �� 5P      -   5        $	��Add��5P      $��5q�6    
��� � �$	��100��6P   .��6\   Add6a   5Q      5R      5S      