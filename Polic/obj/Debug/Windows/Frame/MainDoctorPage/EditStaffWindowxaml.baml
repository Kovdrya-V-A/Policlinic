   M S B A M L   `   `   `  ����@  <Polic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Polic.Windows.Frame.MainDoctorPage"Polic.Windows.Frame.MainDoctorPage  5   	   <    6Polic.Windows.Frame.MainDoctorPage.EditStaffWindowxaml   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Polic.Windows.Frame.MainDoctorPage     5   	     � Title$7  1Редактирование сотрудника��5   	   $	��400��6+   $	��600��68   $	��400��6D   $	��600��6T   $	��500��6c   $
��1000��6s   .��5	      �  � RowDefinitions 5
   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6    � ColumnDefinitions 5   
   �� 5      $
��100* �6   �� 5      $
��150* �6   �� 5      $
��100* �6   �� 5      $
��150* �6   �� 5      $
��100* �6   .+�5   
   �� $��Фамилия��6   $��1��6#   $��0��60      tbStyle#��[  6@   �� 5   
   $��Имя��6   $��2��6   $��0��6,   #��[  6<   �� 5   
   $��Отчество��6   $��3��6$   $��0��61   #��[  6A   �� 5   
   $��Дата рождения��6   $��4��6)   $��0��66   #��[  6F   �� 5    
   $��Должность��6   $��1��6%   $��2��62   #��[  6B   �� 5!   
   $ ��Специальность��6   $��2��6)   $��2��66   #��[  6F   �� 5"   
   $��Кабинет��6   $��3��6#   $��2��60   #��[  6@   �� 5#   
   $��
Логин��6   $��4��6!   $��2��6.   #��[  6>   �� 5$   
   $��Пароль��6   $��5��6"   $��2��6/   #��[  6?   �� 5&   
   $��1��6   $��1��6"     stckPnlStyle#��[ 62   .+�5'      �� -   5         ��Name$ tbFirstName��5'        	tboxStyle#��[ 6+   5(      �� 5*   
   $��2��6   $��1��6"   #��[ 62   .+�5+      �� -   5        $ 
tbLastName��5+      #��[ 6*   5,      �� 5.   
   $��3��6   $��1��6"   #��[ 62   .+�5/      �� -   5        $ tbMidleName��5/      #��[ 6+   50      �� 52   
   $��4��6   $��1��6"   #��[ 62   .+�53      �� -   5        $ bithDay��53      #��[ 6'   54      �� 56   
   $��1��6   $��3��6"   $��Stretch=�62   $��Center=�6P   .+�57      �� -   5         ��Name$ cmRole��57      58      �� 5:   
   $��2��6   $��3��6"   $��Stretch=�62   $��Center=�6P   .+�5;      �� -   5        $ cmSpeciality��5;      5<      �� 5>   
   $��3��6   $��3��6"   #��[ 62   .+�5?      �� -   5        $ cabNum��5?      #��[ 6&   5@      �� 5B   
   $��4��6   $��3��6"   #��[ 62   .+�5C      �� -   5        $ tbLogin��5C      #��[ 6'   5D      �� 5F   
   $��5��6   $��3��6"   #��[ 62   .+�5G      G� -	   5         G�Name$ passwordBox��5G      $	��120��6/   5H      �� 5J   
   $��7��6   $��10��6"    �� Orientation$ 
Horizontal=�67   $��Center=�6P   $��Center=�6k   .+�5K      �� -
   5         ��Name$ btnSave��5K   )   $��Сохранить��6   6:   �� 5L      -   5        $ 	btnCancel��5L   9   $��Отмена��6   $��	100,0,0,0q�6&   6L   5M      5O      5P      