   M S B A M L   `   `   `  ����E  ASTDManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Desktop01.ViewDesktop01.View  5   	   9!clr-namespace:Desktop01.ViewModelDesktop01.ViewModel  64        Desktop01.View.AdminWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Desktop01.View     5   	   4local1!clr-namespace:Desktop01.ViewModel     64     � Title$  AdminWindow��5   	   $	��800��6   $	��800��6*   
������  � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      '   !Desktop01.ViewModel.AdminWindowVM  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��4* �6   .+�5   
   � $��0��6   .+�5      �� $��20q�6    �� CornerRadius$ 20��6*    J� Opacity$	 0.5Q�6<   ��5      
� 5       
� GradientOrigin$ 0.5 0.5&�6*    
� RadiusX$	 0.5Q�6C    
� RadiusY$ 1Q�6Q   	 
� Center$	 0.5 0.5&�6]   .��5      � 
 � Color$

 Aqua��6'    � Offset$ 0Q�65   � 5      $
 
Chartreuse��6'   $ 1Q�6;   5      5      �� 5      $��Admin Section��6   $��50(�6-   $
��Bold"�6;   $��Center=�6M   $��Center=�6j   5      � 5    
   $��1��6   .+�5!      �� $��20q�6   $ 20 20 20 20��6*   $	 0.3Q�6E   ��5"      �� 5#       �� 
StartPoint$	 0 0&�6*    �� EndPoint$	 1 1&�6;   .��5$      � $
 	DarkKhaki��6'   $ 0Q�6:   � 5%      $
 
Aquamarine��6'   $ 1Q�6:   5&      5(      �� 5)      $��..\images\Icon\user.ico��6   $��105,435,627,140q�65   $	 0.8Q�6N   �� 5*      $��..\images\Icon\blue.ico��6   $��405,433,335,141q�65   $	 0.6Q�6N   �� 5+      $
��Name��6   $	��Top=�6$   $
��Left=�6<   $��15(�6W   $
��Bold"�6e   $��185,408,0,0q�6w   $��25��6�   $	��194��6�   �� 5,      $��Password��6   $
��Left=�6(   $	��Top=�6C   $��15(�6[   $
��Bold"�6i   $��486,407,0,0q�6{   $��26��6�   $	��199��6�   �� 5-      $��15(�6-   $
��Bold"�6;   $��185,433,421,141q�6M   $	 0.6Q�6f   ��6   �� *Name_+6f   �� 5.      $��15(�61   $
��Bold"�6?   $��485,433,115,140q�6Q   $	 0.6Q�6j   ��6   �� *	Password_+6j   �� 5/      $��Create user��6   $��40,539,610,36q�6+      ButtonDesign#��[  6B   ��6h   �� *CreateUserCommand+�� 50      $��Modify user��6   $��230,538,420,36q�6+   #��[  6C   ��6i   �� *ModifyUserCommand+�� 51      $��Delete user��6   $��409,538,241,37q�6+   #��[  6C   ��6i   �� *DeleteUserCommand+�� 52      $
��Back��6   $��610,539,40,36q�6$   #��[  6;   ��6a   �� *BackCommand+�� 54      $��2q�6   
���   �$ 20��6=   $��40,49,40,257q�6O   
������$	 0.5Q�6~    J� Effect 55      3  -System.Windows.Media.Effects.DropShadowEffect  56         ShadowDepth$ 10Q�6'      Color$ Black��68   58      �� 59      $��Id��6   $��18(�6"   $��	ExtraBold"�60   $��150,73,555,0q�6G   $	��Top=�6]   $��24��6u   
�������6�   �� 5:      $��   Name��6   $��18(�6'   $��	ExtraBold"�65   $��250,73,362,0q�6L   $	��Top=�6b   $��29��6z   
�������6�   �� 5;      $��Password��6   $��18(�6(   $��	ExtraBold"�66   $��550,76,150,0q�6M   $	��Top=�6c   
�������6{   �� 5=      -   5         ��Name$ Listview��5=      $��0q�6)   $��77,102,77,293q�65   
������ ��5>      �� *Userscollection+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 5?      �� *SelectedUser+$ PropertyChanged=� 5A        5B      $ 5Q�6'   $ Black��67   ��5D      �� 5E      .R�5F      �� 
���   �$��2q�65   $ 20��5G   %   $��10 0 0 0q�67   $��50��6I   
�������._�5H      �� $	��600��6)   
������  �� Orientation$ 
Horizontal=�6O   $��Center=�5I   -   $��Center=�6J   .+�5J   "   �� $��50��6(   $��40��63   $��1q�6?    J� OpacityMask �	#FF08FFD1��6J   �� *Image+6c   �� 5K   "   $
��Bold"�6d   $��14(�6v   $��10 0 0 0q�6�   $��Center=�6�   ��6,   �� *Id+$ PropertyChanged=�6�   �� 5L   "   $
��Bold"�6f   $��14(�6x   $��	100 0 0 0q�6�   $��Center=�6�   $	��200��6�   ��6,   �� *Name+$ PropertyChanged=�6�   �� 5M   "   $
��Bold"�6j   $��14(�6|   $��
100 0 30 0q�6�   $��Center=�6�   ��6,   �� *
Password+$ PropertyChanged=�6�   5N      5P      5Q      5S      5T      5U      5V      