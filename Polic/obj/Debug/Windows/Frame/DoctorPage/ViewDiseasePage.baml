   M S B A M L   `   `   `  ����@  <Polic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Polic.Windows.Frame.DoctorPagePolic.Windows.Frame.DoctorPage  5      4    .Polic.Windows.Frame.DoctorPage.ViewDiseasePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:Polic.Windows.Frame.DoctorPage     5        N� Title$  ViewDisease��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6"   $��2��62    �� Orientation$ 
Horizontal=�6F   .+�5      �� $*��$   Обслужиивал врач: ��6   $��Center=�65   $��16(�6P   �� 5      -   5         ��Name$ 
nameDoctor��5      $��ФИО��6,   $��Center=�67   $��16(�6R   5      �� 5   
   $ Vertical=�6   $��1��6,   $��2��69   .+�5      �� �� 5      $��   Жалобы: ��6   $��16(�6+   �� 5      -   5        $ name1��5   @   $��11111��6   $
��Auto��6%   $
��Auto��63   6@   �� 5      �� 5       $!��   Общий осмотр:��6   $��16(�60   �� 5!      -   5        $ name2��5!   @   $��11111��6   $
��Auto��6%   $
��Auto��63   6@   �� 5"      �� 5#      $)��#   Основной диагноз:��6   $��16(�64   �� 5$      -   5        $ name3��5$   @   $��11111��6   $
��Auto��6%   $
��Auto��63   6@   �� 5%      �� 5&      $/��)   Назначенное лечение:��6   $��16(�67   �� 5'      -   5        $ name4��5'   @   $��11111��6   $
��Auto��6%   $
��Auto��63   6@   5(      5)      5*      