   M S B A M L   `   `   `  ����G  CtravelAgency, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:travelAgencytravelAgency  5   	       travelAgency.Tours   5   	   \ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   8x,http://schemas.microsoft.com/winfx/2006/xaml    5   	   >d2http://schemas.microsoft.com/expression/blend/2008    5   	   Hmc;http://schemas.openxmlformats.org/markup-compatibility/2006    5   	   *localclr-namespace:travelAgency    5   	   -   5          �Name$  tours��5   	    � Title$' !Проданные путевки��5   	   $	��600��5	   	   $	��950��6   $	��600��6"   $	��950��62   $	��800��6A   $	��950��6Q    � WindowStartupLocation$ CenterScreen=�5
   	   ��5      �� 5   
    �� ImageSource$ /images/beach.jpg��6   67   .��5      � ���	#88FFFFFF � ColumnDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $	��125 �6   �� 5      $	��125 �6   �� 5      $	��125 �6   �� 5      $��30 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��478* �6   �� 5      $��20 �6   �� 5       $��30 �6   �� 5!      $��20 �6   .+�5$   
   �� -   5         ��Name$ 	toursList��5$      $��1��6&   $��1��66   ���	#EEFFFFFF���#ccc$��14(�5%   %   $��4��63    �� View 5&      �� 5'      .P�5(      ��  �� Width$
 Auto��6%   $��Клиент��62   	 �� DisplayMemberBinding	 6B   �� *Client+�� 5)      $
 Auto��6%   $��Страна��62   	 6B   �� *	Country+�� 5*      $
 Auto��6%   $��
Отель��62   	 6A   �� *Hotel+�� 5+      $
 Auto��6%   $��Длительность��62   	 6H   �� *
Duration+�� 5,      $
 Auto��6%   $%��Дата отправления��62   	 6L   �� *Date+�� 5-      $
 Auto��6%   $��Количество��62   	 6F   �� *Count+�� 5.      $
 Auto��6%   $��Скидка��62   	 6B   �� *
Discount+�� 5/      $
 Auto��6%   $��Стоимость��62   	 6E   �� *Price+50      52      �� 54   
   -   5        
 ��Name$
 BackBtn��54      $��1��6"   $��3��62   $	��110��55      $��30��6   $
��Left=�6%   $��Bottom=�6@   $��14(�56      .��61   
Назад68   57      58      