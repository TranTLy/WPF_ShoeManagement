   M S B A M L   `   `   `  ����X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  5   	   )    #_1612367_FinalManagmentProject.Test   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:_1612367_FinalManagmentProject     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$
  Test��5	   	   $	��600��6   $
��1024��6#    � 
ResizeMode$ NoResize=�60    � WindowStyle$
 None=�6F    � 	Resources 5         OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�  &	        &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $ 70Q�63     5      $ 0:0:0.5��6'   $	 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 200Q�63     5      $ 0:0:0.2��6'   $ 70Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 ButtonBase.Click��6   
 :� 
SourceName$
 ExpandMenuButton��66   .[�5      �� #��[  6   5      :� 5    
   $	 ButtonBase.Click��6   $
 ClollapedMenuButton��66   .[�5!      �� #��[ 6   5"      .��5&      �� -   5        .+�5(   
   � -   5         �Name$ GridContent��5(      $	��940��6$   $	��535��60    �� Left$ 80��6=   
 �� Top$ 50��6N   .+�5)      �� $��Chào mừng bạn��6   $��50(�6,   $��Center=�6:   $��Center=�6W   5*      � 5+   
   $
��1024��6   $	��600��6    � RowDefinitions 5,      �� 5-      $��30 �6    �� 5.      $��* �6     � ColumnDefinitions 50      �� 51      $	��200 �6#   �� 52      $��* �6#   .+�57      � -   5        $��GridMenu��57      $��1��6#   $��70��60   $
��Left=�6;   ���#355572 J� Effect 58      3  -System.Windows.Media.Effects.DropShadowEffect  59         ShadowDepth$ 5Q�6'      Color$ 	#FF8B8D8B��67   .+�5<      �� .+�5=      � $	��100��6   ���#C3D0F4.+�5>      �� -   5        $��ExpandMenuButton��5>   !   $	��100��69   $��Right=�6s   $	��Top=�6�   ��6F   Z� ��6\   Z� .��5?      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$
 Menu=�66   $��30��6B   $��30��6N   5@      �� 5B      -   5        $��ClollapedMenuButton��5B   !   $y�	Collapsed=�6<   $	��100��6S   $��Right=�6�   $	��Top=�6�   ��6`   Z� ��6v   Z� .��5C        $ 	ArrowLeft=�66   $��30��6G   $��30��6S   5D      5E      � 5F      $	��435��6   $
��Left=�6(   .+�5G      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionContentSlide��5G   >   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6_   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5H      � -   5        $ CursorSlide��5H   #   $��0 10 0 0q�68   ���#DDF8FF$��5��6_   $��50��6i   $
��Left=�6u   $	��Top=�6�   5I      �� 5K      -   5        $��MenuList��5K   #   $��Disabled=�63   $��Disabled=�6g   ���#ffffff$��18(�6�   $��	0,0,0,-75q�6�   .@�5L      �� $��70��6+   .��5M   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5N   &     $ WalletProduct=�6>   $��20��6S   $��20��6^   $��Center=�6j   $��	10 5 5 10q�6�   �� 5O   &   $��Sản phẩm��60   $��Center=�6@   $��20 10q�6[   5P   #   5Q      �� 5S      $��70��6+   .��5T   "   �� $ 
Horizontal=�6-   .+�5U   &     $ 
Responsive=�6>   $��20��6P   $��20��6[   $��Center=�6g   $��	10 5 5 10q�6�   �� 5V   &   $	��Kho��60   $��Center=�6;   $��20 10q�6V   5W   #   5X      �� 5Z      $��70��6+   .��5[   "   �� $ 
Horizontal=�6-   .+�5\   &     $
 Sale=�6>   $��20��6J   $��20��6U   $��Center=�6a   $��	10 5 5 10q�6|   �� 5]   &   $��	Ưu đãi��60   $��Center=�6>   $��20 10q�6Y   5^   #   5_      �� 5a      $��70��6+   .��5b   "   �� $ 
Horizontal=�6-   .+�5c   &     $ 
FileReport=�6>   $��20��6P   $��20��6[   $��Center=�6g   $��	10 5 5 10q�6�   �� 5d   &   $��Thống kê��60   $��Center=�6@   $��20 10q�6[   5e   #   5f      �� 5h      $��70��6+   .��5i   "   �� $ 
Horizontal=�6-   .+�5j   &     $ Users=�6>   $��20��6K   $��20��6V   $��Center=�6b   $��	10 5 5 10q�6}   �� 5k   &   $��Khách hàng��60   $��Center=�6B   $��20 10q�6]   5l   #   5m      �� 5o      $��70��6+   .��5p   "   �� $ 
Horizontal=�6-   .+�5q   &     $ Money=�6>   $��20��6K   $��20��6V   $��Center=�6b   $��	10 5 5 10q�6}   �� 5r   &   $��
Hóa đơn��60   $��Center=�6?   $��20 10q�6Z   5s   #   5t      5u      5v      5w      5x      � 5{      -	   5        $ Title��5{      $��2��6"   ���#0FACF4 5|        5}         
BlurRadius$ 2Q�6'   $ 2Q�66   $ 	#FFC1C3C1��6F   .+�5      �� $ 
Horizontal=�6   $��Right=�66   .+�5�      �� -
   5        $��
UserButton��5�      $��25��6/   $��25��6:    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 5�      
���������5�      Z� ��6/   Z� .��5�        $ Account=�62   6C   5�      �� 5�      -   5         ��Name$ shutdownButton��5�      $��25��65   $��25��6@   #��[ 5�      
�������$
��10,0q�5�      ��5�      Z� ��6/   Z� .��5�        $ Power=�62   6A   5�      5�      5�      5�      �� 5�   
   -   5        $��DropMenuUser��5�      $y�	Collapsed=�6)   $ Vertical=�6@   
�������$��75��6n   $��90��6z   $	 885��6�   $ 25��6�    5�        5�      $ 2Q�6#   $ 3Q�62   $ 	#FF949497��6B   .+�5�      �� $��Hồ Sơ��6   $��12(�6%   $��Right=�63   
���   �$��2,0,0,0q�6�   ��6O   Z� ��6e   Z� 6�   �� 5�      $��Đăng xuất��6   $��12(�6)   $��Right=�67   
���   ���6S   Z� ��6i   Z� 6�   5�      5�      5�      