   M S B A M L   `   `   `  ����@  <Polic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Polic.Windows.Frame.DoctorPagePolic.Windows.Frame.DoctorPage  5   	   3    -Polic.Windows.Frame.DoctorPage.MedCardPatient   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:Polic.Windows.Frame.DoctorPage     5   	     � Title$  MedCardPatient��5   	   $	��450��6    $	��800��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      $	��350 �6   �� 5      .+�5   
   �� ���#00adc6$��0��6%   $��2��62   5      �� 5   
   $��0��6   $��0��6"    �� Orientation$ 
Horizontal=�62   $
��Left=�6K   $��2��6f   .+�5      �� $��Пациент: ��6   $��Center=�6)   $
��Bold"�6D   $��20(�6V   �� 5      -   5         ��Name$ namePatient��5      $��Center=�6-   $��ФИО пациента��6H   $
��Bold"�6\   $��20(�6n   5      �� 5   
   $��0��6   $��1��6"   $ 
Horizontal=�62   $��Right=�6K   .+�5       �� -   5        $��Закрыть окно��5       $��Center=�6,   $��18(�6h   5!      �� 5#   
   -   5         ��Name$ listView��5#      $��2��6%   $��0��62    �� View 5$      �� 5%      .P�5&      �� $!��Начало болезни��6%    �� Width$
 Auto��6=   -   5        lvStartDate�� �� DisplayMemberBinding 5&   J   �� *	StartTime+	 �� StringFormat$	 
dd.MM.yyyy��6�   �� 5'      $��Конец болезни��6%   $
 Auto��6<   -   5        	lvEndDate�� 5'   I   �� *	EndTime+$	 
dd.MM.yyyy��6�   �� 5(      $��Диагноз��6%   $
 Auto��66   -   5        lvMainDiagnosis�� 5(   C   �� *MainDiagnosis+6r   5)      5+       � 5-   
   -   5        
  �Name$
 
frmMedCard��5-   -   $��2��6   $��1��6     � NavigationUIVisibility$ Hidden=�6A   �� 59   
   -   5        $��3��59      $)��#Посмотреть болезнь��6   $
��Left=�6;   $
��Auto��6V   $��18(�6c   ���#00adc66�   5<      5=      