   M S B A M L   `   `   `  ����@  <Polic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PolicPolic  5   	   -clr-namespace:Polic.WindowsPolic.Windows  5   	       Polic.AuthWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Polic     5   	   /windowsclr-namespace:Polic.Windows     5   	     � Title$
  Auth��5	   	   $	��300��6   $	��400��6#   $	��300��6/   $	��400��6?   $	��300��6N   $	��400��6^    � WindowStartupLocation$ CenterScreen=�5
   	    � Icon$ /Resources/logo.png��6.   .��5      � $	��Top=�6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $	��150 �6   �� 5      $��70 �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
      Polic.Windows.Header  $��0��6   $��3��6&   �� 5   
   $��1��6   $��1��6"   $��0 30 0 0q�62   .+�5      �� $��Авторизация��6   $��Center=�6*   $��Center=�6G   $
��Auto��6b   $
��Bold"�6p   $��16(�6�   �� 5      -   5         ��Name$ tb_login��5      $��Center=�6(   $��23��6E    �� TextWrapping$
 Wrap=�6Q   $��
Логин��6e   $	��Top=�6r   $	��120��6�   $��0,0,0,10q�6�   6�   G� 5      -   5         G�Name$ tb_password��5      $��Center=�6/   $��23��6L   $	��120��6X   $	��Top=�6d   $��0,0,0,10q�6�   �� 5      -   5         ��Name$ b_enter��5      $��
Войти��6&   $��Center=�66   $��20��6S   $	��Top=�6_   $��75��6w   $
��Bold"�6�   $��13(�6�   5      �� 5   
   -   5        $ 
btTerminal��5      $��Терминал��6%   $��Right=�68   $��Bottom=�6T   $��75��6p   $��2��6{   $��2��6�   $��	0,0,10,10q�6�   6�   5       5!      