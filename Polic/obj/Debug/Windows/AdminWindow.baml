   M S B A M L   `   `   `  ����@  <Polic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Polic.WindowsPolic.Windows  5   	   -clr-namespace:Polic.WindowsPolic.Windows  5   	       Polic.Windows.AdminWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Polic.Windows     5   	   /windowsclr-namespace:Polic.Windows     5   	   -   5          � Title$  AdminWindow��5	   	   $	��450��6   $	��800��6*   $	��450��66   $	��800��6F    � Icon$ /Resources/logo.png��6l   .��5
      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $
��600* �6   .+�5   
      Polic.Windows.Header  $��0��6   $��3��6&   �� 5   
   $��1��6   ���#749cad6   �� 5   
   $��1��6   $��0��6"   $��Center=�62   .+�5      �� -   5         ��Name$
 awb1��5   C   $'��!Записать пациента��6   $��7 10 7 0q�61   6Q   �� 5      -   5        $
 awb2��5   D   $+��%Прикрепить пациента��6   $��7 5 7 0q�63   6R   �� 5      -   5        $
 awb3��5   B   $'��!Расписание врачей��6   $��7 5 7 0q�61   6P   5      �� 5   
   $��0��6   $��2��6"   .+�5      �� -   5         ��Name$ lbName��5      $��2��6$   $��Ф.И.О��64   $��Right=�6D   $��Stretch=�6`   $
��Bold"�6|   $��14(�6�   �� 5      -   5        $ tb_exit��5   %   $��
Выход��6   $��Right=�6L   5        � 5"   
   -   5          �Name$ frmAdmin��5"      $��1��6"   $��1��62     � NavigationUIVisibility$ Hidden=�6?   5$      5%      