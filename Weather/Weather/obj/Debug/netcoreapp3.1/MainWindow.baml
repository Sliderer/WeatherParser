   M S B A M L   `   `   `  ����B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WeatherWeather  5   	       Weather.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Weather     5   	     � Title$  
MainWindow��5   	   $	��200��5	   	   $	��200��5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    � Topmost$
 True��5   	   
������  � AllowsTransparency$
 True��5   	    � 	Resources 5       �� 
TargetType��%+   '��       �� 5   
   " ��6   5      5      .��5      � .+�5   
   �� $
��auto��6   $
��auto��6   
����+��$��2q�6E    �� CornerRadius$ 
30,30,0,30��5      ��5      �� 5      ��5      � � 5       � Color$ #7FFFD4��6+   	 � Offset$		 0.0Q�6;   6J   � 5       $ #00FFFF��6+   $		 0.4Q�6;   6J   � 5!      $ #4682B4��6+   $	 1Q�6;   6H   5"      5$      5&      �� 5(   
   -   5        $
��Town��5*      $	��Top=�5(      $	��150��5)      $��
27,14,23,0q�5,      
����  � 5.      
 �� Color �� Triggers �� Binding �� RelativeSource �� AncestorType �� Value �� Property �� Value��%�  (��       5/   "   *SystemColors.WindowBrushKey+)(��       50   "   *$"SystemColors.HighlightTextBrushKey+)(�� @     51   "   * SystemColors.HighlightBrushKey+)'�� `     �� 5/      $
 Yellow��6Q   �� 50      $
 Yellow��6X   �� 51      $
 Yellow��6T   �� 52      " ��6    53      �� 54       6&   �� *
IsSelected+ ��  ComboBoxItem True6�   .a�55      ��  � ��
 �  ��6;   56      58      59      .@�5:      �� $��Вашингтон��6   6+   �� 5;      $��
Париж��6   6'   �� 5<      $��Москва��6   6(   5>      �� 5@   
   -   5         ��Name$ weatherText��5A       �� TextAlignment$ Center=�5B      $��Center=�5C      $��Center=�5D      5G      5H      5I      