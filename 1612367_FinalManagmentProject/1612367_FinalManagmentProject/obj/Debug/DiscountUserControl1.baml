   M S B A M L   `   `   `  ����X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  5      9    3_1612367_FinalManagmentProject.DiscountUserControl1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:_1612367_FinalManagmentProject     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������.��5
      �� .+�5   
   �� $��	ƯU ĐÃI��6   $��30(�6!     �� Left$	  400��6/   
 �� Top$ 15��6A   6S   � 5   
   $��Disabled=�6   $	��441��5      
�������$	��900��61   $ 75��6=   $  8��6M   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��DiscountDataGrid��5         SelectionMode$ Single=�6/      AutoGenerateColumns .  ���#EAECFF$��
5,-12,5,11q�5         CanUserResizeColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6H      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6U   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6)   �� 
 �� Path$
 order�6U     5      $ Tên ưu đãi��6O   $	 150 6c   	 6)   �� $
 nameDiscount�6c     5      $ Tình trạng��6I   $	 120 6]   	 6)   �� $
 status�6]     5      $ Ngày bắt đầu��6Q   $ SizeToHeader 6g   	 6)   �� $
 startShortDate�6g     5      $ Ngày kết thúc��6O   $ SizeToHeader 6f   	 6)   �� $
 endShortDate�6f     5      $ Phần trăm ưu đãi��6K   $ SizeToHeader 6e   	 6)   �� $
 discount�6e   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5   "   �� $��	btnDetail��6)   -   5        .��5   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Details=�6>   $��20��6M   $��20��6X   $��Center=�6d   5    #   5!      5#        5%       5&      �� 5'      .R�5(   "   �� $��bntEditCustomer��6)   -   5        .��5)   &     $
 Edit=�6>   $��20��6J   $��20��6U   $��Center=�6a   5*   #   5+      5-        50       51      �� 52      .R�53   "   �� $��	btnDelete��6)   -   5        .��54   &     $ Delete=�6>   $��20��6L   $��20��6W   $��Center=�6c   55   #   56      58      5:      5;      �� 5>   
   -   5        $��btnAdd��5>      $	  846��64   $	 441��6F   ���	#FF34BB2D��6n   Z�  J� Effect 5?      3	  -System.Windows.Media.Effects.DropShadowEffect	  5@       	  ShadowDepth$ 5Q�6#    	  Color$ 	#FF8B8D8B��63   .��5B        $	 Add=�6&   $��20��61   $��20��6<   $��Center=�6H   5C      )
  #MaterialDesignThemes.Wpf.DialogHost
  5G   
   -   5        $��dialogDiscount��5G   $    
  CloseOnClickAway .  
  IsOpen .  $	��900��5H   3   $	��500��6?   $ 37��6L   $  10��6\    
  DialogContent 5I      A� 5J       A� Columns$ 2��6   $	��400��6,   $��173,0,182,4q�68   .+�5K      �� $��10q�6   $��Center=�6(   $
��Left=�6C   $��Tên ưu đãi��6^   �� 5L      -   5        $��nameDiscountTxt��5L      $��Center=�65   $
��Left=�6P   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   $��30��6�   �� 5N      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Sản phẩm áp dụng��6^   �� 5O      -   5        $��comboBoxTypeProduct��5O      $��Center=�6;   $
��Left=�6V   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   �� 5Q      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Khách hàng áp dụng��6^   �� 5R      -	   5        $��comboBoxTypeCustomer��5R      $��Center=�6<   $
��Left=�6W   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   �� 5T      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Ngày bắt đầu��6^   (  "System.Windows.Controls.DatePicker  5U      -
   5        $��	startDate��5U   !      SelectedDateFormat$ Short=�62   $	��100��6M   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Pick Date��6Y    (  $MaterialDesignFloatingHintDatePicker#��[  6�   �� 5W      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Ngày kết thúc��6^     5X      -   5        $��endDate��5X   !   $ Short=�60   $	��100��6K   $ 	Pick Date��6W   #��[  6�   �� 5Z      $��10q�6   $��Center=�6(   $
��Left=�6C   $ ��Phần trăm ưu đãi (%)��6^   �� 5[      -   5        $��percentDiscountTxt��5[      $��Center=�68   $
��Left=�6S   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   $��30��6�   A� 5]      -   5        $��
statusGrid��5]   "   $y�Hidden=�64   $��2��6H   $ 2��6\   $��
0,0,-203,0q�6h   .+�5^      �� $��10q�6    $��Center=�6,   $
��Left=�6G   $��Tình trạng��6b   �� 5_      -   5        $��comboBoxStatusDiscount��5_   #   $��Center=�6A   $
��Left=�6\   ���#CCD0FF$��1q�6�   $��0,11,-10,11q�6�   $	��204��6�   $��30��6�   5`      �� 5a      6   �� 5b      -   5        $��btnSaveDiscount��5b      $y�	Collapsed=�64   $	��100��6i   $��30��6u   $��Center=�6�   $
��Lưu��6�   ���	#FFEAEA2B$��0,17,0,0q�6�   ��6�   Z�  5c      	  5d      $ 5Q�6/   $ 	#FF8B8D8B��6?   5f      �� 5g      -   5        $��btnAddDiscount��5g      $	��100��6P   $��30��6\   $��Center=�6h   $��Thêm��6�   ���	#FF34BB2D$��0,17,0,0q�6�   ��6�   Z�  5h      	  5i      $ 5Q�6/   $ 	#FF8B8D8B��6?   5k      �� 5l      -   5        $��btnCancelDialog��5l      $	��100��6W   $��30��6c   $��Center=�6o   $��Hủy��6�   
���  ��$��0,17,0,0q�6�   ��6�   Z�  5m      	  5n      $ 5Q�6/   $ 	#FF8B8D8B��6?   5p      5q      5t      5v      5w      