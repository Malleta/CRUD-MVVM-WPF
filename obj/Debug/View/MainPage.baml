   M S B A M L   `   `   `  ����d  `Mini-projekat 2 – Entity Framework MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:Mini_projekat_2___Entity_Framework_MVVM.View,Mini_projekat_2___Entity_Framework_MVVM.View  5      ;    5Mini_projekat_2___Entity_Framework_MVVM.View.MainPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Llocal:clr-namespace:Mini_projekat_2___Entity_Framework_MVVM.View     5        N� WindowWidth$	  800Q�5       N� WindowHeight$	 400Q�6*    N� Title$ MainPage��5       N� 
Background
 �����.��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��50px �6   �� 5      $��* �6   .+�5   
   � 
�����_�$��0��6'   $��50��64   $	��Top=�6@   .+�5      �� $��Center=�6   $��Center=�61   $
��20px(�6L   
�������.��6o   
Students6y   �� 5      -   5        $
��50px��5   0   $��Right=�6=   
���  ��
�������.��6}   Delete6�   �� 5      -   5        $
��50px��5   -   $��Right=�6:   
��� � �
�������$��	0,0,102,0q�6|   .��6�   Add6�   �� 5      -   5        $
��50px��5   0   $��Right=�6=   
��� ���
�������$��0,0,51,0q�6�   .��6�   Modify6�   5      � 5   
   $��
30 0 30 30q�6   $��2��6#    5      �� 5      $��* �6#   �� 5      $	��200 �6#    5      �� 5      $
��10px �6    �� 5       $
��20px �6    60   �� 5!      $
��10px �6    �� 5"      6"   .+�5$      � $��1��6    5%      �� 5&      �� 5'      �� 5(      .+�5+      �� -   5         ��Name$ ListBoxSort��5+   K   $��0��6`   $
��Left=�6p   $��20��6�   $	��Top=�6�   .@�5,      �� .��6#   First Name - Ascending6;   �� 5-      .��6#   First Name - Descending6<   �� 5.      .��6#   Last Name - Ascending6:   �� 5/      .��6#   Last Name - Descending6;   50      �� 51      -   5        $��1��51      .��6I   Sort with Courses6\   �� 52      -   5        $��2��52   4   $��Right=�6D   .��6`   Reload6h   53      &   System.Windows.Controls.DataGrid  54      -   5          Name$ StudentsDataGrid��54   $   $��3��6      AutoGenerateColumns .  	   
IsReadOnly	 . 
   Columns
 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn   Header$ 
First name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *
sFirstName+  57      $ 	Last name��6)    6=   �� *	sLastName+   RowDetailsTemplate 59      �� 5:      .R�5;      �� $��0q�6!   
������� �� Padding$ 10q�6M   ._�5<      ��  �� Orientation$ Vertical=�6)   .+�5=   "   �� $ 
Horizontal=�6-   .+�5>   &   �� $��15(�60   $��Address details��6>   $��Center=�6U   $
��Bold"�6p   5?   #   �� 5@   "   $ 
Horizontal=�6-   .+�5A   &   �� $��12(�60   $��	Address: ��6>   $��Center=�6O   �� 5B   &   $��16(�60   
���p�$��Center=�6z   ��6X   �� *Address.Address1+6z   5C   #   �� 5D   "   $ 
Horizontal=�6-   .+�5E   &   �� $��12(�60   $��City: ��6>   $��Center=�6L   �� 5F   &   $��16(�60   
���p�$��Center=�6v   ��6X   �� *Address.City+6v   5G   #   �� 5H   "   $ 
Horizontal=�6-   .+�5I   &   �� $��12(�60   $��	Country: ��6>   $��Center=�6O   �� 5J   &   $��16(�60   
���p�$��Center=�6y   ��6X   �� *Address.Country+6y   5K   #   �� 5L   "   $ 
Horizontal=�6-   .+�5M   &   �� $��12(�60   $��	Courses: ��6>   $��Center=�6O   �� 5N   &   $
��auto��6O   ��6/   �� *	Courses+��5O   *   �� 5P   .   .R�5Q   2   �� $ 
Horizontal=�6=   6X   5R   /   ��5T   *   �� 5U   .   .R�5V   2   �� ��6<   �� *cName+6U   5W   /   5Y   '   5Z   #   5[      5\      5]      5_      �� 5a      $��1��6   $��3��6)   .+�5b      �� .��6   List of Courses:6*   �� 5c      -   5         ��Name$ CoursesListBox��5c       �� DisplayMemberPath$ cName��62    �� SelectionMode$ Multiple=�6L   $��Visible=�6e   $	��150��6�   6�   �� 5d      -	   5        .��5d   =   Sort6C   5e      5f      5g      5h      