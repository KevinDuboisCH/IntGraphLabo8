   M S B A M L   `   `   `  ����H  DIntGraphLabo8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:UserControlsUserControls  5   	       IntGraphLabo8.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:UserControls     5   	     � Title$  ArKdPaintingMachine��5   	   $	��800��6%   $
��1200��62    � 
ResizeMode$ CanMinimize=�5	   	   ���	#FF006899 � 	Resources 5         
fontFamily  BlueDegradedButton �� 
TargetType �� Property �� Value �� 
StartPoint �� EndPoint � Color	 � Offset  ActivatedButton��%4  &	        &	      &	 �    *�5   
   
Tahoma)�60   �� 5   
   " ��6+   .�5      ��  � �� 5      �� 5      $	 0,0&�6*   $	 0,1&�6;   .��5      � $ 	#FFADDCE6��6'   $	 0Q�69   � 5      $ 	#FF00AEFF��6'   $		 0.5Q�69   � 5      $ 	LightBlue��6'   $	 1Q�69   5      5      �� 5       � ��$	 8,4q�6(   �� 5       � ��$ 4q�6'   5      �� 5   
   " ��6(   .�5      ��  � ��
 ��ح�5      �� 5        � ��$	 8,4q�6(   �� 5!       � ��$ 4q�6'   5"      5#      .��5%      ]� .+�5&   
   ]� $��Right=�6   $
��auto��5'      $	��250��5(      .+�5)      %   UserControls.SupervisionControl  -   5        
  Name$
 SupervisionControl��5)   '   $
��auto��5*   '   $
��auto��5+   '      Status$ Arrêté��5,   '   5.      50      ]� 51   
   $	��Top=�6   $
��auto��52      $
��auto��53      55      �� 56   
   $��Right=�6   $��3��57      
����  �58      ]� 59   
   $��Bottom=�6   .+�5:      � $
��auto��6   $
��auto��6!    � ColumnDefinitions 5;      �� 5<      $��1* �6'   �� 5=      $��1* �6'   �� 5>      $��1* �6'   �� 5?      $��1* �6'    � RowDefinitions 5A      �� 5B      $��1* �6$   .+�5E      �� -   5         ��Name$ Accueil��5F      $��0��5E      #��[ 5G      $��Accueil��5H      $��0q�5I      $��35(�5J      $
��auto��5K      $	��120��5L      5M      �� 5N      -   5        $ 
Chargement��5O      $��1��5N      #��[ 5P      $��
Chargement��5Q      $��0q�5R      $��35(�5S      $
��auto��5T      $
��auto��5U      �� 5V      -   5        $ Supervision��5W      $��2��5V      #��[ 5X      $��Supervision��5Y      $��0q�5Z      $��35(�5[      $
��auto��5\      $
��auto��5]      �� 5^      -   5        $ Configuration��5_      $��3��5^      #��[ 5`      $��Configuration��5a      $��0q�5b      $��35(�5c      $
��auto��5d      $
��auto��5e      5f      5g      5h      � 5i   
   $	��Top=�6   $	��250��6$    5j      �� 5k      $��1* �6#   �� 5l      $
��2.5* �6#   �� 5m      $��1* �6#   .+�5o      �� -   5         ��Name$ AdministratorImage��5o   $   $��0��6   $'��!HomePage\Images\Administrator.png��6@   $y�Hidden=�6k   �� 5p      -   5        $ OperatorImage��5p   $   $��0��6   $"��HomePage\Images\Operator.png��6;   $y�Hidden=�6a   �� 5q      -   5        $ ManagerImage��5q   $   $��0��6   $��HomePage\Images\Boss.png��6:   $y�Hidden=�6\   5u      � 5v   
   .+�5w         UserControls.ConfigSheet  -	   5          Name$ ConfigSheet��5w       $y�Hidden=�5x          UserControls.HomePage  5y      -
   5          Name$ HomePage��5y      $y�Hidden=�5z      5{      5|      5}      