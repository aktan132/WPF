   M S B A M L   `   `   `  ����>  :tan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:tan.views	tan.views  5   	       tan.views.Thisismail   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:tan.views     5   	     � Title$  
Thisismail��5   	   $	��650��6   $
��1000��6*    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�6.   
������  � AllowsTransparency .  � 
ResizeMode$ NoResize=�5   	    � WindowState$ Normal=�6   .��5      ��  �� CornerRadius$ 8��6      PrimaryBackgroundColor#���   6   ._�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      .+�5      �� $ 8 0 0 8��6     SecundaryBackgroundColor#���  6,   ._�5      � -   5         �Name$ gridMenu��5      $��60��6)   	 � RowDefinitions	 5      �� 5      $��60 �6(   �� 5      $��80 �6(   �� 5      $
��Auto �6(   �� 5      .+�5      �� $��1��6!   
 �� Orientation$
 
Horizontal=�6.   $	��Top=�6G   .+�5      F�   logo#���  6   $��16 0 0 0q�6=    �� Stretch$
 Fill=�6O     PrimaryBlueColor#���  6^   $��25��6�   $��25��6�   $
��Left=�6�   �� 5       $	��Tan��6    #���  6.   $
��Bold"�6^   $��20(�6p   $��Center=�6~   $
��Left=�6�   $
��Left=�6�   $��14 0 0 0q�6�   5!      d� 5$      -   5         d�Name$ btnMenu��5$   #   $��Right=�65   $��0q�6Q   
������ $��Center=�6~     MenuIconStyle#��[ 6�   $��0 0 15 0q�6�    � Triggers 5%      :� 5&       :� RoutedEvent$ ToggleButton.Unchecked��6+   .[�5'   "   �� .��5(   &   �� -   5         ��Name$ HideStackPanel��5(   1   .��5)   *   W�  �� 
TargetName$ gridMenu��6:    �� TargetProperty$ Width�6[    g� 	BeginTime$ 0:0:0X�6}    W� From$	 200X�6�   	 W� To$ 60X�6�    g� Duration$ 0:0:0.3D�6�   5*   +   5+   '   5,   #   5-      :� 5.      $ ToggleButton.Checked��6+   .[�5/   "   �� .��50   &   �� -   5        $ ShowStackPanel��50   1   .��51   *   W� $ gridMenu��6:   $ Width�6[   $ 0:0:0X�6}   $ 60X�6�   $	 200X�6�   $ 0:0:0.3D�6�   52   +   53   '   54   #   55      57      �� 59      $��3��6!   .+�5:      	� -   5         	�Name$ rdHome��5:   &    d� 	IsChecked$
 TrueY�66   $��Теория��6G     MenuRadioButtonStyle#���  6X     home
 � Tag# �  6�   6�   	� 5;      -   5        $ rdSounds��5;   &   $��Задания��68   #���  6J     
headphones# �  6y   $��0 5 0 5q�6�   6�   	� 5<      -   5        $ rdNotes��5<   &   $��Тест��67   #���  6F    	 notes# �  6u   6�   	� 5=      -   5        $ 	rdPayment��5=   &   $��Настройки��69   #���  6M    	 payment# � 	 6|   $��0 5 0 5q�6�   6�   5?      �� 5A      $��3��6!   $��Bottom=�6.   $
 
Horizontal=�6I   $	��200��6b   $��0 0 0 20q�6n   .+�5B      A� $��40��6"   $��40��6-   $��10 0 0 0q�69   ��5C      �� 5D   "    �� ImageSource$- '/images/image-xSuLeoPAE-transformed.png��6.   5F      �� 5G      $
 Vertical=�6%   $��8 0 0 0q�6<   .+�5H      �� -	   5        $	��log��5H   $    
 TextPrimaryColor#��� 
 6/   $��14(�6_   $��SemiBold"�6m   $��Center=�6�   $
��Left=�6�   �� 5I      -
   5        $	��pas��5I   $     PrimaryGrayColor#���  60   $��11(�6`   $��Regular"�6n   $��Center=�6�   $
��Left=�6�   $��	0 -10 0 0q�6�   5J      5K      5L      5M      � 5Q      $��1��6   	 5R      �� 5S      $��60 �6$   �� 5T      .+�5X      �� $��0��6   $��4��6*   $��Right=�6:   $	��Top=�6V   $��0,5,10,0q�6n   $��30��6�   $
 
Horizontal=�6�   $��RightToLeft=�6�   .+�5Y      �� -   5         ��Name$ btnClose��5Y        IconButtonsStyle#��[ 6/    	 close#���  6Y   $ IsCloseButton��6�   �� 5[      -   5        $ btnMinimize��5[      #���  62     minimize#���  6]   6�   5\      �� 5]      $��5,235,-5,203q�6   $��1��63   $
 Vertical=�6@   .+�5^      ��   
TitleText1#��[ 6   
��� � �$��45(�6S   $��1��6c   $	��455��6p   .��6|   " Добро пожаловать!6�   �� 5_      -   5        $
��losa��5_   �   $��Center=�6   #��[ 67   $��45(�6\   $��Center=�6j   
��� � �6�   5a      �� 5b      $��1��6   $��10q�6'   ._�5d       � -   5          �Name$ PagesNavigation��5d        � NavigationUIVisibility$ Hidden=�65   5f      5h      5i      5l      5m      5n      