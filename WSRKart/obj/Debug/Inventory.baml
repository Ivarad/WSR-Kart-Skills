   M S B A M L   `   `   `  ����B  >WSRKart, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WSRKartWSRKart  5   	       WSRKart.Inventory   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WSRKart     5   	     � Title$  	Inventory��5   	   $	��450��6   $	��800��6(   .��5	      �  � RowDefinitions 5
   
   �� 5      $��70 �6   �� 5      $��40 �6   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��50 �6   �� 5      $��30 �6    � ColumnDefinitions 5   
   �� 5      $	��400 �6   �� 5      $	��400 �6   .+�5   
      WSRKart.Sample  $��7��6   $��2��6(   �� 5   
   $
��Left=�6   $��Center=�6,   $��
Назад��6G   $��0��6W   $��18(�6d   ���	#FFEBEBEB
���   �$��70��6�   $��30��6�   $��30,0,0,0q�6�   �� 5   
   $��Инвентарь��6   $��1��6%   $��2��62   $��Center=�6F   $��Center=�6c   $��18(�6~   $��Arial)�6�   �� 5   
   $+��%Количетсво пилотов: ��6   $��2��60   $��0��6=   $��2��6M   $��Center=�6a   $��Center=�6~   $��16(�6�   $��Arial)�6�   $
��Bold"�6�   �� 5   
   $��0��6   $��2��6   $��1��6*   $
��Left=�6:   $��Center=�6U   $��16(�6p   $��Arial)�6~   $��90,0,0,0q�6�   �� 5   
   $��Right=�6   $��Center=�6-   $��
Отчет��6H   $��1��6X   $��2��6e   $��1��6v   $��18(�6�   ���#b4b4b4
���   �$��85��6�   $��30��6�   $��0,0,65,0q�6�   &   System.Windows.Controls.DataGrid  5!   
   $��Center=�6   $��Center=�60   $��3��6K   $��2��6X   $	��700��6l   $	��200��6x   5"      �� 5$   
   $��Right=�6   $��Center=�6-   $��Поступление��6H   $��4��6^   $��1��6k   $��18(�6{   ���#b4b4b4
���   �$	��125��6�   $��30��6�   $��0,0,65,0q�6�   5&      5'      