   M S B A M L   `   `   `  ����@  <Polic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Polic.Windows.Frame.MainDoctorPage"Polic.Windows.Frame.MainDoctorPage  5      4    .Polic.Windows.Frame.MainDoctorPage.PatientPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Blocal0clr-namespace:Polic.Windows.Frame.MainDoctorPage     5        N� Title$  PatientPage��5	      .��5      � .+�5   
   �� -   5         ��Name$ listView��5   $    � Language$ ru-RU�6   $��Stretch=�66   $
��Auto��6T   $	��Top=�6b   $
��Auto��6z   $��1��6�   $��1��6�    �� View 5      �� 5      .P�5      �� $��Фамилия��6%    �� Width$	 150��66   -   5        
lvPatientF�� �� DisplayMemberBinding 5   B   �� *	FirstName+6m   �� 5      $��Имя��6%   $	 150��62   -   5        
lvPatientL�� 5   >   �� *
LastName+6h   �� 5      $��Отчество��6%   $	 150��67   -   5        
lvPatientM�� 5   C   �� *	MidleName+6n   �� 5      $��Дата рождения��6%   $	 100��6<   -   5        
lvBirthDay�� 5   H   �� *
BirthDay+ �� StringFormat$ 
dd.MM.yyyy��6�   �� 5      $��Номер полиса��6%   $	 100��6;   -   5        lvPolis�� 5   G   �� *Polis+6n   5      5      5      5      