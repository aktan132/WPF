   M S B A M L   `   `   `  ����>  :tan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:tan.Pages	tan.Pages  5          tan.Pages.mp3   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      #localclr-namespace:tan.Pages  5        N� Title$	  mp3��5
      .��5      � .+�5      ��  �� CornerRadius$ 15��6   $��0q�6$   ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.5,1&�65   .��5      �  � Color$ Green��6    � Offset$	 0.7Q�6-   � 5      $ White��6   $	 0.4Q�6-   5      ._�5   
   � ��6   Z� .+�5      #  MaterialDesignThemes.Wpf.Card  
��� ���$��10q�5         UniformCornerRadius$ 20Q�5      ��5      Z� .��5      �� .+�5      � $��70��6   .+�5      �� -   5         ��Name$ btnFile��5   �      CActionButtons#��[  6!   $
��Left=�6I   $
��20 0q�6d    � ToolTip$ 	Open File��6r   .��5       �� $��-5q�6)   .+�5!   "   '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Folder=�6:   $��20��6H   $��20��6S   5"      5#      �� 5$      -   5        $ btnClose��5$   �   #��[  6!   $��Right=�6I   $
��20 0q�6e   $ Close��6s   .��5%      �� $��-5q�6)   .+�5&   "     $	 Close=�6:   $��20��6G   $��20��6R   5'      5(      5)      �� 5*      -   5        
 ��Name$
 Musicimg��5*   5   $��10q�6   $	��200��6(   $��Uniform=�6G   �� 5+      -   5         ��Name$ lblSongname��5+   �   $��10q�6!   $��16(�6-   $��	Song Name��6;   
������� �� TextAlignment$ Center=�6_   $��SemiBold"�6v   6�   �� 5,      $��10q�6    $��11(�6,   $��
Definition��6:   
�������$ Center=�6_   $��
ExtraLight"�6v   � 5-      $��0 20 0 0q�6   .+�5.      �� -   5        $ lblCurrenttime��5.   �   $��11(�6$   $
��0:00��62   $
��20 0q�6>   
�������$��
ExtraLight"�6_   $ Center=�6w   $
��Left=�6�   6�   �� 5/      -   5        $ lblMusiclength��5/   �   $��11(�6$   $
��0:00��62   $
��20 0q�6>   
�������$��
ExtraLight"�6_   $ Center=�6w   $��Right=�6�   6�   �� 50      -   5         ��Name$ TimerSlider��57   !    � Value$ 0Q�52   !    � Minimum$ 1Q�53   !    � Maximum$ 50Q�54   !   $��15q�55   !   
���q�<�57   6   � 58      $��Center=�6$   $
��0 40q�6A   .+�5:      �� -   5        $ 
btnPRewind��5:   �   #��[  6%   $��Right=�6M   $
��10 0q�6i   $
 Back��6w   .��5;   "   �� $��-5q�6-   .+�5<   &     $	 
FastRewind=�6>   $��20��6P   $��20��6[   5=   #   5>      �� 5@      -	   5        $ btnPlay��5@   �   #��[  6%   $��Right=�6M   $
��10 0q�6   $
 Play��6�   .��5A   "     $
	 Play=�6:   $��20��6F   $��20��6Q   5B      �� 5C      -
   5        $ btnStop��5C   �   #��[  6%   $
��10 0q�6c   $ Pause��6q   $y�	Collapsed=�6�   .��5D   "     $	 Pause=�6:   $��20��6G   $��20��6R   5E      �� 5P      -   5        $ btnPNext��5P   �   #��[  6<   $��Right=�6d   $
��10 0q�6�   $ 	Play Next��6�   .��5Q   "   �� $��-5q�6-   .+�5R   &     $	 FastForward=�6>   $��20��6Q   $��20��6\   5S   #   5T      5V      5W      5X      5Y      5Z      5[      5\      5]      