   M S B A M L   `   `   `  ����E  ASTDManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Desktop01.ViewDesktop01.View  5   	   9!clr-namespace:Desktop01.ViewModelDesktop01.ViewModel  64        Desktop01.View.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Desktop01.View     5   	   4local1!clr-namespace:Desktop01.ViewModel     64     � Title$  Student Manager Login��5   	   $	��450��6'   $	��400��64    � WindowState$ 	Minimized=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5   	   
������  � DataContext 5      '   !Desktop01.ViewModel.LoginWindowVM  5   
   .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63    �� Opacity$	 0.5Q�6B   .��5      �  � Color$ DimGray��6   	 � Offset$	 0Q�60   � 5      $ 	SlateGray��6   $		 0.5Q�62   � 5      $
 Gray��6   $		 1.0Q�6-   5      .+�5   
   �� 
���   �$��3,3,3,3q�6%   
 �� CornerRadius$
 20��6?   $��Center=�6Q   $	��250��6n   $��0,70,0,0q�6{   $	��Top=�6�   $	��300��6�   ��5      �� 5      $	 0,0&�6&   $	 1,1&�67   .��5      � $ DarkOliveGreen��6#   $		 0.0Q�6;   � 5      $ ForestGreen��6#   $		 0.5Q�68   � 5      $ SeaGreen��6#   $		 1.0Q�65   5      5!      �� 5"   
   $
��Bold"�6   $��Center=�6$   $��	0,125,0,0q�6A   
������� �� TextWrapping$
 Wrap=�6l   $	��Top=�6�   $	��200��6�   $��30��6�   $��Center=�6�   $��Center=�6�   ��6�   �� *	UserName_+6�   �� 5#   
   $
��Bold"�6   $��Center=�6$   $��	0,250,0,0q�6A   $
 Wrap=�6T   $	��Top=�6�   $	��200��6�   $��30��6�   $��Center=�6�   $��Center=�6�   ��6h   �� *
Password__+6�   �� 5$   
   -   5         ��Name$ Login��5$      
�������$��Login��67   $��Center=�6G   $��	0,350,0,0q�6d   $	��Top=�6w   $	��120��6�   $��45��6�   
���/kU����	#FF00060E$��20(�6�   $��	UltraBold"�6�   $��Times New Roman)�6     RoundButtonDesign#��[  6?  ��6  �� *LoginCommand+6?  �� 5%   
   $
��Bold"�6   $��Center=�6&   $��0,95,0,0q�6C   $
��Wrap=�6U   $��	User Name��6i   $	��Top=�6z   $��30��6�   $	��200��6�   $��Times New Roman)�6�   $��20(�6�   
�������6�   �� 5&   
   $
��Bold"�6   $��Center=�6&   $��	0,220,0,0q�6C   $
��Wrap=�6V   $��Password��6j   $	��Top=�6z   $��30��6�   $	��200��6�   $��Times New Roman)�6�   $��20(�6�   
�������6�   5(      5)      