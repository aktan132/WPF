   M S B A M L   `   `   `  ����>  :tan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:tan.Pages	tan.Pages  5          tan.Pages.test   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:tan.Pages     5        N� Title$
  test��5	      .��5
      � 
������� � ColumnDefinitions 5   
   �� 5      $
��1000 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��myCanvas��5      
�������$��2��67   $��	0,0,199,0q�6H   .+�5      �� -   5         ��Name$ 	scoreText��5      $��1��6'   $��18(�64   $�� ��6B    �� Left$ 1��6M   
 �� Top$	 509��6]   $��Center=�6n   $��40��6�   $	��Top=�6�   $	��151��6�   �� 5      -   5        $ questionOrder��5      $��18(�6+   $	 349��69   $��  ��6K   $��288,2,-288,-2q�6X   �� 5      -   5         ��Name$ txtQuestion��5       �� TextAlignment$ Center=�6-    �� Padding$ 3q�6D   $��20(�6P   $	��572��6^   $
��Wrap=�6j   $	 168��6~   $	 192��6�   �� 5      $ 97��6   $	 303��6*   .+�5      �� -   5        $
��ans1��5   q   $��2��6      ButtonStyle2#���   6(   $��18(�6O   $	��250��6}   $��50��6�   $��15q�6�   $��Answer 1��6�   
	 � Tag$	 1��6�   $ 79��6�   $	 270��6�   �� 5      -   5        $
��ans2��5   b   #���   6   $��18(�6@   $	��250��6n   $��50��6z   $��Answer 2��6�   $	 2��6�   $	 380��6�   $	 269��6�   5      �� 5      $	 494��6   $	 299��6+   .+�5      �� -   5        $
��ans3��5   c   #���   6   $��18(�6A   $	��250��6o   $��15q�6{   $��50��6�   $��Answer 3��6�   $	 3��6�   $ 80��6�   $	 340��6�   �� 5       -   5        $
��ans4��5    c   #���   6   $��18(�6A   $	��250��6o   $��50��6{   $��Answer 4��6�   $	 4��6�   $	 379��6�   $	 338��6�   5!      �� 5"      -	   5        $��tbTime��5"      $��15(�6'   
 �� Right$
 1��66   $	 535��6G   $
��Left=�6X   $��40��6s   $	��135��6   $ 26��6�   $��Center=�6�   5#       � 5$   
   -
   5          �Name$ 
MainFrame1��5$        � NavigationUIVisibility$ Hidden=�5%      5'      5)      