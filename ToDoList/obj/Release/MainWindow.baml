   M S B A M L   `   `   `  ����   ToDoList    ToDoList.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -     � Title$  ToDoList��$	��500��$	��300�� � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ NoResize=�.��� ���	#FFE8563B � RowDefinitions �� $��65 ��� �� $��35 �.+��� -    ��Name$	 Add��$%��+ Добавить запись��$
��Left=�$	��Top=�$	��270��$��45��$��22(����	#FF708AFF
����������	#FF444040$��8,13,0,0q�$��0q� J� Clip ��  �� RadiusX$ 5Q� �� RadiusY$ 5Q� �� Rect$ 
0,0,270,45��� -   	 ��Name$
	 note��$��0��$
��Left=�
 �� TextWrapping$
 NoWrap=�$y�Hidden=�$��45��$��Заметка��$	��Top=�$	��292��$��Center=�$��5,0,50,0q�$��16(�$��0,13,0,0q��� $
��Auto=�$��1��.���� -    ��Name$
 Main���� -   $ buttonCompleted��$��2��$3��-Просмотреть завершенные�����#f92525$��Center=�$��16(�
�������$	��294��