   M S B A M L   `   `   `  ����X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  5      ,    &_1612367_FinalManagmentProject.Product   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:_1612367_FinalManagmentProject     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������.��5      �� .+�5   
   �� $��SẢN PHẨM��6   $��30(�6#     �� Left$	  395��61   
 �� Top$ 15��6C   6U   A� 5   
    A� Columns$ 3��6   $  95��6"   $ 68��63   $	��295��6C   .+�5      �� $��Tìm kiếm��6   �� 5      -   5        $��cbTypeProduct��5      6,   5      � 5   
   $��Disabled=�6   $	��390��5      $	 120��6   $	��890��6.   $  12��6:   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��ProductDataGrid��5         SelectionMode$ Single=�6.      AutoGenerateColumns .  ���#EAECFF$��5,0,5,30q�5         CanUserResizeColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6H   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 6U   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   ��  �� Path$ order�6U     5      $ 
Tên hàng��6N   $		 150 6`   
 6)   �� $ nameProduct�6`     5      $ Loại��6O   $		 120 6]   
 6)   �� $ nameCategory�6]     5      $ Giá nhập kho��6T   $		 120 6j   
 6)   �� $ stringPriceImport�6j     5      $ 	Giá bán��6R   $		 120 6c   
 6)   �� $ stringPriceSell�6c     5      $ Điểm tích lũy��6M   $	 SizeToHeader 6d   
 6)   �� $ 
bonusScore�6d     5      $ 
Đơn vị��6G   $	 SizeToHeader 6W   
 6)   �� $
 unit�6W   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5       �� 5!      .R�5"   "   �� $��btnEdt��6)   -   5        .��5#   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$
 Edit=�6>   $��20��6J   $��20��6U   $��Center=�6a   5$   #   5%      5'        5)       5*      �� 5+      .R�5,   "   �� $��	btnDelete��6)   -   5        .��5-   &     $ Delete=�6>   $��20��6L   $��20��6W   $��Center=�6c   5.   #   5/      51      53      54      �� 57   
   -   5        $��btnAdd��57      $	  846��64   $	 441��6F   ���	#FF34BB2D��6n   Z�  J� Effect 58      3	  -System.Windows.Media.Effects.DropShadowEffect	  59       	  ShadowDepth$ 5Q�6#    	  Color$ 	#FF8B8D8B��63   .��5;        $	 Add=�6&   $��20��61   $��20��6<   $��Center=�6H   5<      )
  #MaterialDesignThemes.Wpf.DialogHost
  5@   
   -   5        $��dialogAddProduct��5@   $    
  CloseOnClickAway .  
  IsOpen .  $	��900��5A   3   $	��451��6?   $ 65��6L    
  DialogContent 5B      A� 5C       A� Rows$ 9��6   $ 2��6'   $	��400��63   $��173,0,182,4q�6?   .+�5D      �� $��10q�6   $��Center=�6(   $
��Left=�6C   $��Tên sản phẩm��6^   �� 5E      -   5        $��nameProductTxt��5E      $��Center=�64   $
��Left=�6O   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   $��30��6�   �� 5G      -   5        $��categoryLable��5G      $��10q�61   $��Center=�6=   $
��Left=�6X   $��Loại��6s   �� 5H      -	   5        $��comboBoxCategory��5H      $��Center=�6X   $
��Left=�6s   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   ��67   �� *
nameType+6�   �� 5J      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Giá nhập hàng��6^   �� 5K      -
   5        $��priceImprotTxt��5K      $��Center=�64   $
��Left=�6O   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   �� 5M      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Giá xuất��6^   �� 5N      -   5        $��priceSellTxt��5N      $��Center=�62   $
��Left=�6M   ���#CCD0FF$��1q�6~   $��	0,10,0,10q�6�   $	��200��6�   �� 5P      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Điểm tích lũy��6^   �� 5Q      -   5        $��bonusScoreTxt��5Q      $��0��63   $��Center=�6<   $
��Left=�6W   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   �� 5S      $��10q�6   $��Center=�6(   $
��Left=�6C   $��
Đơn vị��6^   �� 5T      -   5        $��unitTxt��5T      $��Đôi��6-   $��Center=�68   $
��Left=�6S   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   �� 5V      -   5        $��lblSize��5V      $��10q�6+   $��Center=�67   $
��Left=�6R   $��2��6m   $
��Size��6�   �� 5W      $��10q�6   $��Center=�6(   $
��Left=�6C   A� 5Y      -   5        $��sizeCheckboxs��5Y   "   $��Center=�67   $��7��6T   $��2��6a   $ 1��6u   $��Center=�6   $��22��6�   $��37,13,-195,11q�6�   $	��360��6�   .+�5Z      �� -   5        $��checkboxSize36��5Z   $   $��36��6:    d� 	IsChecked$
 TrueY�6G   �� 5[      -   5        $��checkboxSize37��5[   $   $��37��6:   $
 TrueY�6G   �� 5\      -   5        $��checkboxSize38��5\   $   $��38��6:   $
 TrueY�6G   �� 5]      -   5        $��checkboxSize39��5]   $   $��39��6:   $
 TrueY�6G   �� 5^      -   5        $��checkboxSize40��5^   $   $��40��6:   $
 TrueY�6G   �� 5_      -   5        $��checkboxSize41��5_   $   $��41��6:   $
 TrueY�6G   �� 5`      -   5        $��checkboxSize42��5`   $   $��42��6:   $
 TrueY�6G   5a      �� 5b      $��10q�6   $��Center=�6(   $
��Left=�6C   �� 5d      -   5        $��btnSave��5d      $y�Visible=�6,   $	��100��6A   $��30��6M   $��Center=�6Y   $
��Lưu��6v   ��6�   Z�  5e      	  5f      $ 5Q�6/   $ 	#FF8B8D8B��6?   5h      �� 5i      -   5        $��bntAddProduct��5i      $	��100��62   $��30��6>   $��Center=�6J   $��Thêm��6g   ���	#FF34BB2D��6�   Z�  5j      	  5k      $ 5Q�6/   $ 	#FF8B8D8B��6?   5m      �� 5n      -   5        $��btnCancelAddProduct��5n      $	��100��68   $��30��6D   $��Center=�6P   $��Hủy��6m   
���  ����6�   Z�  5o      	  5p      $ 5Q�6/   $ 	#FF8B8D8B��6?   5r      5s      5v      5x      5y      