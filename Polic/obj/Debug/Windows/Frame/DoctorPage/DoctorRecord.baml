   M S B A M L   `   `   `  ����@  <Polic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Polic.Windows.FramePolic.Windows.Frame  5      &     Polic.Windows.Frame.DoctorRecord   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Polic.Windows.Frame     5        N� Title$  DoctorRecord��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ listView��5      $��Stretch=�6%   $
��Auto��6C   $	��Top=�6Q   $
��Auto��6i   $��1��6v    �� View 5      �� 5      .P�5      �� $��Фамилия��6%    �� Width$
 Auto��66   -   5        
lvPatientF�� �� DisplayMemberBinding 5   C   �� *	FirstName+6n   �� 5      $��Имя��6%   $
 Auto��62   -   5        
lvPatientL�� 5   ?   �� *
LastName+6i   �� 5      $��Отчество��6%   $
 Auto��67   -   5        
lvPatientM�� 5   D   �� *	MidleName+6o   �� 5      $��
Время��6%   $
 Auto��64   -   5        
lvDateTime�� 5   A   �� *
DateTime+6k   5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   .+�5      �� -   5        $��<��5      $��30��6$   $
��Bold"�6/   6A   �� 5      -   5        $��Открыть сеанс��5      $��30,0,0,0q�6-   $��Center=�6\   5      5       5!      