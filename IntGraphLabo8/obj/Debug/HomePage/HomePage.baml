   M S B A M L   `   `   `  ����H  DIntGraphLabo8, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:UserControlsUserControls  5          UserControls.HomePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:UserControls     5        � 	Resources  5	         
fontFamily  BlueDegradedButton �� 
TargetType �� Property �� Value �� 
StartPoint �� EndPoint � Color � Offset  ActivatedButton��%4  &	        &	      &	 �    *�5
   
   
Tahoma)�60   �� 5   
   " ��6+   .�5      ��  � �� 5      �� 5      $	 0,0&�6*   $	 0,1&�6;   .��5      � $ 	#FFADDCE6��6'   $ 0Q�69   � 5      $ 	#FF00AEFF��6'   $	 0.5Q�69   � 5      $ 	LightBlue��6'   $ 1Q�69   5      5      �� 5       � ��$	 8,4q�6(   �� 5       � ��$ 4q�6'   5      �� 5   
   " ��6(   .�5      ��  � ��
 ��ح�5      �� 5       � ��$	 8,4q�6(   �� 5       � ��$ 4q�6'   5       55      .��57      �� .+�58   
   �� $	��Top=�6   $��10q�6(   ��59      �� 5:      $��Profil��6   #��[  6*   .��5<      �  � ColumnDefinitions 5=      �� 5>      $��* �6'   �� 5?      $��* �6'   �� 5@      $��* �6'   .+�5B      �� -   5        $��ButtonOperator��5B      $��0��6/   #��[ 6?   $��50��6k   .��5C      �� 	 �� Orientation$	 
Horizontal=�6!   .+�5D      �� $��Images/Operator.png��6    �� 5E      $��
Opérateur��6$   $��Center=�65   #��[  6P   5F      5G      �� 5I      -   5        $��ButtonManager��5I      $��1��6.   #��[ 6>   $��50��6j   .��5J      �� $	 
Horizontal=�6!   .+�5K      �� $��Images/Boss.png��6    �� 5L      $��Chef d'atelier��6$   $��Center=�6:   #��[  6U   5M      5N      �� 5P      -   5        $��ButtonAdministrator��5P      $��2��64   #��[ 6D   $��50��6p   .��5Q      �� $	 
Horizontal=�6!   .+�5R      �� $��Images/Administrator.png��6    �� 5S      $��Administrateur��6$   $��Center=�6:   #��[  6U   5T      5U      5V      5W      �� 5Y   
   $��10q�6   ��5Z      �� 5[      $��	Connexion��6   #��[  6-   .��5]      ]� $��5q�6   .+�5^      � $��Right=�6   
 � RowDefinitions
 5_      �� 5`      $
��Auto �6(   �� 5a      $
��Auto �6(    5c      �� 5d      $��* �6+   �� 5e      $��* �6+   .+�5g      �� -   5        $��ButtonConnection��5g      $��0��65   $��	Connexion��6E   $��5q�6Y   6d   �� 5h      -   5        $��ButtonDeconnection��5h      $��1��67   $��Déconnexion��6G   $��5q�6]   6h   5i      �� 5j      -   5        $��TextBlockConnectionResult��5j      $��Bottom=�6=   $��5,0,0,0q�6U   
���  ��6f   G� 5k      -   5        $��PasswordBoxProfile��5k       G� PasswordChar$ *��68   $��5q�6I   5l      5m      �� 5o   
   -   5        $��GroupBoxModifyPassword��5o      $��10q�61   $y�Hidden=�6=   ��5p      �� 5q      $��Modifier mot de passe��6   #��[  69   .��5s      ]� $��5q�6   .+�5t      �� -	   5        $��ButtonValidate��5t      $��Right=�6/   $��Valider��6F   $��5q�6X   6c   G� 5u      -
   5        $��PasswordBoxModify��5u      $ *��67   $��5q�6H   5v      5w      5x      5y      