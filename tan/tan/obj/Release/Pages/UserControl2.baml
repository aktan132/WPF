   M S B A M L   `   `   `  ����   tan    tan.Pages.UserControl2   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  $	��812��.��� 
�������  � ColumnDefinitions  �� $��10 ��� $	��150 ��� $��10 ��� $��* ��� $��10 � � RowDefinitions �� $��10 ��� $��* ��� $��10 �.+�� $��1��$��1��.+��� .+���  �� Orientation$ 
Horizontal=�.+��� $
��Id: ��$
��Left=��� -    ��Name$ idText��$
��Left=�$��Center=�����  �� Path$ Id��� $��Логи��$
��auto��$
��Left=��� -    ��Name$ firstNameText��$��Stretch=� �� TextAlignment$
 Left=��� $��Пароль��$
��Left=��� -   $ lastNameText��$��Stretch=�$
 Left=� �� TextWrapping$ NoWrap=��� $��Имя��$
��Left=��� -   $ NameText��$��Stretch=�$
 Left=�$ NoWrap=��� -    ��Name$ addPersonBtn��$��0 10 0 0q�$��Добавить��$��30��$	��100���� -   $ refreshListBtn��$��0 10 0 0q�$��Обновить��$��30��$	��100���� -   $ editBtn��$��0 10 0 0q�$��Изменить��$��30��$	��100��{�.  �� -   $ 	deleteBtn��$��0 10 0 0q�$��Удалить��$��30��$	��100���� -	   $ findBtn��$��0 10 0 0q�$��
Поиск��$��30��$	��100��� $��3��$��1��.+��� -
   	 ��Name$	 listPeopleListBox��$
��auto��$
��auto��
 �� SelectionMode$
 Extended=�$��0,40,0,0q����� *Users+����  �� 
TargetType" �� �� BasedOn# [B��.���  �� Property �@��
IsSelected �� Value �� *
IsSelected+ �� Mode$ TwoWay=�-   ���� .R��� $ 
Horizontal=�.+��� $��0 0 10 0q����� $ Id��� $��0 0 10 0q����� $ login��� $��0 0 10 0q����� $ password��� $��0 0 10 0q����� $
 name��� $ 
Horizontal=�$��4,23,-26,748q�.+��� $��ID��$��0 0 10 0q��� $��
Логин��$��0 0 10 0q��� $��Пароль��$��0 0 10 0q��� $��Имя��$��0 0 10 0q�