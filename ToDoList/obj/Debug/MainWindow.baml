   M S B A M L   `   `   `  ����  ToDoList    ToDoList.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          � Title$  ToDoList��5   	   $	��500��6   $	��300��6'    � WindowStartupLocation$ CenterScreen=�63    � 
ResizeMode$ NoResize=�6X   .��5
      � ���	#FFE8563B � RowDefinitions 5   
   �� 5      $��65 �6   6*   �� 5      6   �� 5      $��35 �6   6*   .+�5   
   �� -   5         ��Name$	 Add��5      $%��+ Добавить запись��6   $
��Left=�6:   $	��Top=�6U   $	��270��6m   $��45��6y   $��22(�6�   ���	#FF708AFF
����������	#FF444040$��8,13,0,0q�6�   $��0q�6�    J� Clip 5      �� 5       �� RadiusX$ 5Q�5       �� RadiusY$ 5Q�5       �� Rect$ 
0,0,270,45�5      5      �� 5   
   -   5        	 ��Name$
	 note��5      $��0��6    $
��Left=�6-   
 �� TextWrapping$
 NoWrap=�6H   $y�Hidden=�6^   $��45��6t   $��Заметка��6�   $	��Top=�6�   $	��292��6�   $��Center=�6�   $��5,0,50,0q�6�   $��16(�6�   $��0,13,0,0q�6�   6  �� 5   
   $
��Auto=�6   $��1��6:   .��5      �� -   5         ��Name$
 Main��5      5      �� 5   
   -   5        $ buttonCompleted��5      $��2��6*   $3��-Просмотреть завершенные��67   ���#f92525$��Center=�6o   $��16(�6�   
�������$	��294��6�   6�   5      5!      