   M S B A M L   `   `   `  ���� >  :tan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:tan.Pages	tan.Pages      tan.Pages.mp3   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  #localclr-namespace:tan.Pages    N� Title$	  mp3��.��� .+���  �� CornerRadius$ 15��$��0q�����  �� 
StartPoint$ 0.1,0&� �� EndPoint$ 0.5,1&�.���  � Color$ Green�� � Offset$	 0.7Q�� $ White��$	 0.4Q�._�� ��Z� .+�#  MaterialDesignThemes.Wpf.Card  
��� ���$��10q�   UniformCornerRadius$ 20Q���Z� .���� .+�� $��70��.+��� -    ��Name$ btnFile��   CActionButtons#��[  $
��Left=�$
��20 0q� � ToolTip$ 	Open File��.���� $��-5q�.+�'  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Folder=�$��20��$��20���� -   $ btnClose��#��[  $��Right=�$
��20 0q�$ Close��.���� $��-5q�.+�  $	 Close=�$��20��$��20���� -   
 ��Name$
 Musicimg��$��10q�$	��200��$��Uniform=��� -    ��Name$ lblSongname��$��10q�$��16(�$��	Song Name��
������� �� TextAlignment$ Center=�$��SemiBold"��� $��10q�$��11(�$��
Definition��
�������$ Center=�$��
ExtraLight"�� $��0 20 0 0q�.+��� -   $ lblCurrenttime��$��11(�$
��0:00��$
��20 0q�
�������$��
ExtraLight"�$ Center=�$
��Left=��� -   $ lblMusiclength��$��11(�$
��0:00��$
��20 0q�
�������$��
ExtraLight"�$ Center=�$��Right=��� -    ��Name$ TimerSlider�� � Value$ 0Q� � Minimum$ 1Q� � Maximum$ 50Q�$��15q�
���q�<�� $��Center=�$
��0 40q�.+��� -   $ 
btnPRewind��#��[  $��Right=�$
��10 0q�$
 Back��.���� $��-5q�.+�  $	 
FastRewind=�$��20��$��20���� -	   $ btnPlay��#��[  $��Right=�$
��10 0q�$
 Play��.��  $
	 Play=�$��20��$��20���� -
   $ btnStop��#��[  $
��10 0q�$ Pause��$y�	Collapsed=�.��  $	 Pause=�$��20��$��20���� -   $ btnPNext��#��[  $��Right=�$
��10 0q�$ 	Play Next��.���� $��-5q�.+�  $	 FastForward=�$��20��$��20��