   M S B A M L   `   `   `  ����@  <Polic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Polic.Windows.Frame.MainDoctorPage"Polic.Windows.Frame.MainDoctorPage  5      2    ,Polic.Windows.Frame.MainDoctorPage.StaffPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:Polic.Windows.Frame.MainDoctorPage     5        N� Title$  	StaffPage��5	      .��5      � .+�5      �� -   5         ��Name$ listView��5   (    � Language$ ru-RU�6   $��Stretch=�6:   $
��Auto��6X   $	��Top=�6f   $
��Auto��6~   $��1��6�   $��1��6�    �� View 5      �� 5      .P�5      �� $��Фамилия��6)    �� Width$	 150��6:   -   5        
lvPatientF�� �� DisplayMemberBinding 5   F   �� *	FirstName+6q   �� 5      $��Имя��6)   $	 150��66   -   5        
lvPatientL�� 5   B   �� *
LastName+6l   �� 5      $��Отчество��6)   $	 150��6;   -   5        
lvPatientM�� 5   G   �� *	MidleName+6r   �� 5      $��Дата рождения��6)   $	 100��6@   -   5        
lvBirthDay�� 5   L   �� *
BirthDay+ �� StringFormat$ 
dd.MM.yyyy��6�   �� 5      $��Роль��6)   $	 150��67   -   5        
lvRole�� 5   C   �� *
NameRole+6m   �� 5      $ ��Специальность��6)   $	 150��6@   -   5        lvSpeciality�� 5   L   �� *NameSpeciality+6|   �� 5      $��Кабинет��6)   $ 50��6:   -   5        	lvCab�� 5   E   �� *	CabNumber+6p   5      5      5      5      