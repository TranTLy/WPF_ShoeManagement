   M S B A M L   `   `   `  ���� X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  *    $_1612367_FinalManagmentProject.Sales   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     >local,clr-namespace:_1612367_FinalManagmentProject     V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$
  Test��$	��600��$
��1024�� � 
ResizeMode$ NoResize=� � WindowStyle$
 None=� � 	Resources    OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	CloseMenu��%�   &	        &	 q     �� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$ 70Q�  $ 0:0:0.5��$	 200Q��� .��U� $ (FrameworkElement.Width)�$ GridMenu��.\�  $ 0��$	 200Q�  $ 0:0:0.2��$ 70Q� � Triggers :� 	 :� RoutedEvent$	 ButtonBase.Click��
 :� 
SourceName$
 ExpandMenuButton��.[��� #��[  :� $	 ButtonBase.Click��$
 ClollapedMenuButton��.[��� #��[ .���� -   .+�� -    �Name$ GridContent��$	��940��$	��535�� �� Left$ 80��
 �� Top$ 50��� $
��1024��$	��600�� � RowDefinitions �� $��30 ��� $��* � � ColumnDefinitions �� $	��200 ��� $��* �.+�� -   $��GridMenu��$��1��$��70��$
��Left=����#355572 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 5Q�   Color$ 	#FF8B8D8B��.+��� .+�� $	��100�����#C3D0F4.+��� -   $��ExpandMenuButton��$	��100��$��Right=�$	��Top=���Z� ��Z� .��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$
 Menu=�$��30��$��30���� -   $��ClollapedMenuButton��$y�	Collapsed=�$	��100��$��Right=�$	��Top=���Z� ��Z� .��  $ 	ArrowLeft=�$��30��$��30��� $	��350��$
��Left=�.+�?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -     Name$ TrainsitionContentSlide��C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��� -   $ CursorSlide��$��0 10 0 0q����#DDF8FF$��5��$��50��$
��Left=�$	��Top=��� -   $��MenuList��$��Disabled=�$��Disabled=����#ffffff$��18(�.@��� $��70��.����  �� Orientation$ 
Horizontal=�.+�  $ WalletProduct=�$��20��$��20��$��Center=�$��	10 5 5 10q��� $��Sản phẩm��$��Center=�$��20 10q��� $��70��.���� $ 
Horizontal=�.+�  $
 Sale=�$��20��$��20��$��Center=�$��	10 5 5 10q��� $��	Ưu đãi��$��Center=�$��20 10q��� $��70��.���� $ 
Horizontal=�.+�  $ Users=�$��20��$��20��$��Center=�$��	10 5 5 10q��� $��Khách hàng��$��Center=�$��20 10q��� $��70��.���� $ 
Horizontal=�.+�  $ Receipt=�$��20��$��20��$��Center=�$��	10 5 5 10q��� $��
Hóa đơn��$��Center=�$��20 10q�� -	   $ Title��$��2�����#0FACF4      
BlurRadius$ 2Q�$ 2Q�$ 	#FFC1C3C1��.+��� $ 
Horizontal=�$��Right=�.+��� -
   $��
UserButton��$��25��$��25�� 0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 
���������Z� ��Z� .��  $ Account=��� -    ��Name$ shutdownButton��$��25��$��25��#��[ 
�������$
��10,0q���Z� ��Z� .��  $ Power=��� -   $��DropMenuUser��$y�	Collapsed=�$ Vertical=�
�������$��75��$��90��$	 885��$ 25��   $ 2Q�$ 3Q�$ 	#FF949497��.+��� $��Hồ Sơ��$��12(�$��Right=�
���   �$��2,0,0,0q���Z� ��Z� �� $��Đăng xuất��$��12(�$��Right=�
���   ���Z� ��Z� 