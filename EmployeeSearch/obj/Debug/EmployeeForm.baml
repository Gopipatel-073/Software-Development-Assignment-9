   M S B A M L   `   `   `  ����I  EEmployeeSearch, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:EmployeeSearchEmployeeSearch  5   	   !    EmployeeSearch.EmployeeForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:EmployeeSearch     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	      MaterialDesignBody#���   5   	   $��Regular"�5	   	   $��13(�5
   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � Title$ Employee Form��5   	   $	��400��6   $	��400��6,   .��5      � $��5q�6    � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��Title_TextBlock��5   <   $��0��6   $
��Left=�6!   {�.  $	��Top=�6e   $��	10,10,0,0q�6}    $  MaterialDesignSubtitle1TextBlock#��[ 6�    J� Opacity$ .7Q�6�   $��ADD EMPLOYEE��6�   �� 5   
   -   5        $��1��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ ID��6N    % !MaterialDesignFloatingHintTextBox#��[ 6�   $��Center=�6�   {�6r   �� *IsNew+��6�   �� *Id+6�   �� 5   
   $��2��6   $
 Name��6   #��[ 6[   $��Center=�6�   ��6E   �� *Name+6�   �� 5   
   $��3��6   $ Position��6   #��[ 6c   $��Center=�6�   ��6I   �� *
Position+6�   �� 5   
   -   5        $��4��5      $ Hourly Rate��6K   #��[ 6�   $��Center=�6�   ��6x   �� *	HourlyPay+6�   �� 5   
   $��5��6   $��Right=�6"    �� Orientation$ 
Horizontal=�6>   .+�5       �� -   5        $��Cancel_BUtton��5    ,   $	��100��6   $��5q�6!   
���  ��$��Right=�6R   .��6�   Cancel6�   �� 5!      -   5        $��Save_Button��5!   "   $��5��6   $	��100��65   $��5q�6A   
��� � �$��Right=�6_   .��6�   Add6�   5"      '  !MaterialDesignThemes.Wpf.Snackbar  5#   
   -   5          Name$ Snackbar��5#   s   $��0��6"   $��Center=�62   $��Center=�6O      MessageQueue 6�   4  .MaterialDesignThemes.Wpf.MessageQueueExtension  5$      5%      5&      