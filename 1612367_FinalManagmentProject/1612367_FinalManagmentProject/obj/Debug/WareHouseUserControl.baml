   M S B A M L   `   `   `  ����X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  5      9    3_1612367_FinalManagmentProject.WareHouseUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:_1612367_FinalManagmentProject     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������.��5
      �� .+�5   
   �� $��	KHO HÀNG��6   $��30(�6#     �� Left$	  400��61   
 �� Top$ 15��6C   6U   �� 5   
   -   5        $��SumProductLable��5      $��	Tổng: 0��6'   ���#E98C0A$��16(�6O   $��40��6]   $	��130��6i   $	  765��6u   $ 5��6�   6�   � 5   
   $��Disabled=�6   $	��472��5      $ 55��6   $	��940��6-   $  0��69   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��ProductDataGrid��5         SelectionMode$ Single=�6.      AutoGenerateColumns .  ���#EAECFF$��0,0,0,25q�5         CanUserResizeColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6H      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6U   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6)   �� 
 �� Path$
 order�6U     5      $ 
Tên hàng��6N   $	 150 6`   	 6)   �� $
 nameProduct�6`     5      $ Loại��6R   $	 120 6`   	 6)   �� $
 nameTypeProduct�6`     5      $ Size 36��6U   $ SizeToHeader 6f   	 6)   �� $
 arrSizeQuantity[0]�6f     5      $ Size 37��6U   $ SizeToHeader 6f   	 6)   �� $
 arrSizeQuantity[1]�6f     5      $ Size 38��6U   $ SizeToHeader 6f   	 6)   �� $
 arrSizeQuantity[2]�6f     5      $ Size 39��6U   $ SizeToHeader 6f   	 6)   �� $
 arrSizeQuantity[3]�6f     5      $ Size 40��6U   $ SizeToHeader 6f   	 6)   �� $
 arrSizeQuantity[4]�6f     5      $ Size 41��6U   $ SizeToHeader 6f   	 6)   �� $
 arrSizeQuantity[5]�6f     5      $ Size 42��6U   $ SizeToHeader 6f   	 6)   �� $
 arrSizeQuantity[6]�6f     5         
Foreground �#E98C0A$ Tổng��6c   $ SizeToHeader 6q   	 6)   �� $
 sumQuantity�6q   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5       .R�5!   "   �� $��
bntAddItem��6)   -   5        .��5"   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$	 Add=�6>   $��10��6I   $��10��6T   $��Center=�6`   5#   #   5$      5&      5(      5)      )	  #MaterialDesignThemes.Wpf.DialogHost	  5,   
   -   5        $��dialogAddProduct��5,   $    	  CloseOnClickAway .  	  IsOpen .  $	��900��5-   3   $	��461��6?   $ 55��6L    	  DialogContent 5.      A� 5/       A� Columns$ 2��6   $	��200��6*   $��173,0,182,4q�66   .+�50      �� $��10q�6   $��Center=�6(   $
��Left=�6C   $��Size 36��6^   �� 51      -   5        $��size36QuantityTxt��51      $��0��67   $��Center=�6@   $
��Left=�6[   ���#CCD0FF$��1q�6�   $��	0,12,0,13q�6�   $��49��6�   $��30��6�   �� 52      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Size 37��6^   �� 53      -   5        $��size37QuantityTxt��53      $��0��67   $��Center=�6@   $
��Left=�6[   ���#CCD0FF$��1q�6�   $��	0,12,0,13q�6�   $��49��6�   $��30��6�   �� 54      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Size 38��6^   �� 55      -   5        $��size38QuantityTxt��55      $��0��67   $��Center=�6@   $
��Left=�6[   ���#CCD0FF$��1q�6�   $��	0,12,0,13q�6�   $��49��6�   $��30��6�   �� 56      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Size 39��6^   �� 57      -   5        $��size39QuantityTxt��57      $��0��67   $��Center=�6@   $
��Left=�6[   ���#CCD0FF$��1q�6�   $��	0,12,0,13q�6�   $��49��6�   $��30��6�   �� 58      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Size 40��6^   �� 59      -	   5        $��size40QuantityTxt��59      $��0��67   $��Center=�6@   $
��Left=�6[   ���#CCD0FF$��1q�6�   $��	0,12,0,13q�6�   $��49��6�   $��30��6�   �� 5:      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Size 41��6^   �� 5;      -
   5        $��size41QuantityTxt��5;      $��0��67   $��Center=�6@   $
��Left=�6[   ���#CCD0FF$��1q�6�   $��	0,12,0,13q�6�   $��49��6�   $��30��6�   �� 5<      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Size 42��6^   �� 5=      -   5        $��size42QuantityTxt��5=      $��0��67   $��Center=�6@   $
��Left=�6[   ���#CCD0FF$��1q�6�   $��	0,12,0,13q�6�   $��49��6�   $��30��6�   �� 5?      -   5        $��bntAddProduct��5?      $	��100��62   $��30��6>   $��Center=�6J   $��Thêm��6g   ���	#FF34BB2D��6�   Z�  J� Effect 5@      3
  -System.Windows.Media.Effects.DropShadowEffect
  5A       
  ShadowDepth$ 5Q�6/    
  Color$ 	#FF8B8D8B��6?   5C      �� 5D      -   5        $��btnCancelAddProduct��5D      $	��100��68   $��30��6D   $��Center=�6P   $��Hủy��6m   
���  ����6�   Z�  5E      
  5F      $ 5Q�6/   $ 	#FF8B8D8B��6?   5H      5I      5L      5M      5N      