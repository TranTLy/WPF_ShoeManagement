   M S B A M L   `   `   `  ����X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  5      8    2_1612367_FinalManagmentProject.CustomerUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:_1612367_FinalManagmentProject     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������.��5      �� .+�5   
   �� $��KHÁCH HÀNG��6   $��30(�6%     �� Left$	  360��63   
 �� Top$ 20��6E   6W   � 5   
   $��Disabled=�6   $	��453��5      $ 85��6   $	��900��6-   $  4��69   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��CustomerDataGrid��5         SelectionMode$ Single=�6/      AutoGenerateColumns .  ���#EAECFF$��
5,-12,5,42q�5         CanUserResizeColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6H      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6U   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6)   �� 
 �� Path$
 order�6U     5      $ Tên khách hàng��6O   $	 180 6g   	 6)   �� $
 nameCustomer�6g     5      $ Bậc - Loại��6S   $ SizeToHeader 6g   	 6)   �� $
 nameTypeCustomer�6g     5      $ Điểm tích lũy��6H   $ SizeToHeader 6_   	 6)   �� $
 score�6_     5      $ 
Ngày sinh��6N   $	 190 6a   	 6)   �� $
 dateOBShort�6a     5      $ Số điện thoại��6N   $	 120 6e   	 6)   �� $
 phoneNumber�6e   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5   "   �� $��bntEditCustomer��6)   -   5        .��5   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$
 Edit=�6>   $��20��6J   $��20��6U   $��Center=�6a   5   #   5       5"        5$       5%      �� 5&      .R�5'   "   �� $��	btnDelete��6)   -   5        .��5(   &     $ Delete=�6>   $��20��6L   $��20��6W   $��Center=�6c   5)   #   5*      5,      5.      5/      �� 52   
   -   5        $��btnAdd��52      $	  846��64   $	 441��6F   ���	#FF34BB2D��6n   Z�  J� Effect 53      3	  -System.Windows.Media.Effects.DropShadowEffect	  54       	  ShadowDepth$ 5Q�6#    	  Color$ 	#FF8B8D8B��63   .��56        $	 Add=�6&   $��20��61   $��20��6<   $��Center=�6H   57      )
  #MaterialDesignThemes.Wpf.DialogHost
  5;   
   -   5        $��dialogCustomer��5;   $    
  CloseOnClickAway .  
  IsOpen .  $	��900��5<   3   $	��500��6?   $ 37��6L   $  10��6\    
  DialogContent 5=      A� 5>       A� Columns$ 2��6   $	��400��6+   $��173,0,182,4q�67   .+�5?      �� $��10q�6   $��Center=�6(   $
��Left=�6C   $��Tên khách hàng��6^   �� 5@      -   5        $��nameCustomerTxt��5@      $��Center=�65   $
��Left=�6P   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   $��30��6�   �� 5B      $��10q�6   $��Center=�6(   $
��Left=�6C   $��Số điện thoại��6^   �� 5C      -   5        $��phoneNumberTxt��5C      $��Center=�65   $
��Left=�6P   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   �� 5E      $��10q�6   $��Center=�6(   $
��Left=�6C   $��
Ngày sinh��6^   (  "System.Windows.Controls.DatePicker  5F      -   5        $��dateOB��5F   !      SelectedDateFormat$ Short=�6/      SelectedDate$ 1/1/1998X�6J   $	��100��6b   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Pick Date��6n    (  $MaterialDesignFloatingHintDatePicker#��[  6�   �� 5H      -	   5        $��btnSaveCustomer��5H      $y�	Collapsed=�64   $	��100��6i   $��30��6u   $��Center=�6�   $
��Lưu��6�   ���	#FFEAEA2B$��0,17,0,0q�6�   ��6�   Z�  5I      	  5J      $ 5Q�6/   $ 	#FF8B8D8B��6?   5L      �� 5M      -
   5        $��btnAddCustomer��5M      $	��100��6P   $��30��6\   $��Center=�6h   $��Thêm��6�   ���	#FF34BB2D$��0,17,0,0q�6�   ��6�   Z�  5N      	  5O      $ 5Q�6/   $ 	#FF8B8D8B��6?   5Q      �� 5R      -   5        $��btnCancelDialog��5R      $	��100��6W   $��30��6c   $��Center=�6o   $��Hủy��6�   
���  ��$��0,17,0,0q�6�   ��6�   Z�  5S      	  5T      $ 5Q�6/   $ 	#FF8B8D8B��6?   5V      5W      5Z      5\      5]      