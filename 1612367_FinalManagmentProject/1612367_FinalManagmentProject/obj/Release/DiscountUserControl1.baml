   M S B A M L   `   `   `  ���� X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  9    3_1612367_FinalManagmentProject.DiscountUserControl1   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     >local,clr-namespace:_1612367_FinalManagmentProject     V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  
�������.���� .+��� $��	ƯU ĐÃI��$��30(�  �� Left$	  400��
 �� Top$ 15��� $��Disabled=�$	��441��
�������$	��900��$ 75��$  8��.+�&   System.Windows.Controls.DataGrid  -   $��DiscountDataGrid��   SelectionMode$ Single=�   AutoGenerateColumns .  ���#EAECFF$��
5,-12,5,11q�   CanUserResizeColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��   Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� 
 �� Path$
 order�  $ Tên ưu đãi��$	 150 	 �� $
 nameDiscount�  $ Tình trạng��$	 120 	 �� $
 status�  $ Ngày bắt đầu��$ SizeToHeader 	 �� $
 startShortDate�  $ Ngày kết thúc��$ SizeToHeader 	 �� $
 endShortDate�  $ Phần trăm ưu đãi��$ SizeToHeader 	 �� $
 discount�4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� $��	btnDetail��-   .��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Details=�$��20��$��20��$��Center=�   �� .R��� $��bntEditCustomer��-   .��  $
 Edit=�$��20��$��20��$��Center=�   �� .R��� $��	btnDelete��-   .��  $ Delete=�$��20��$��20��$��Center=��� -   $��btnAdd��$	  846��$	 441�����	#FF34BB2D��Z�  J� Effect 3	  -System.Windows.Media.Effects.DropShadowEffect	   	  ShadowDepth$ 5Q� 	  Color$ 	#FF8B8D8B��.��  $	 Add=�$��20��$��20��$��Center=�)
  #MaterialDesignThemes.Wpf.DialogHost
  -   $��dialogDiscount�� 
  CloseOnClickAway .  
  IsOpen .  $	��900��$	��500��$ 37��$  10�� 
  DialogContent A�  A� Columns$ 2��$	��400��$��173,0,182,4q�.+��� $��10q�$��Center=�$
��Left=�$��Tên ưu đãi���� -   $��nameDiscountTxt��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200��$��30���� $��10q�$��Center=�$
��Left=�$��Sản phẩm áp dụng���� -   $��comboBoxTypeProduct��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200���� $��10q�$��Center=�$
��Left=�$��Khách hàng áp dụng���� -	   $��comboBoxTypeCustomer��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200���� $��10q�$��Center=�$
��Left=�$��Ngày bắt đầu��(  "System.Windows.Controls.DatePicker  -
   $��	startDate��   SelectedDateFormat$ Short=�$	��100��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Pick Date�� (  $MaterialDesignFloatingHintDatePicker#��[  �� $��10q�$��Center=�$
��Left=�$��Ngày kết thúc��  -   $��endDate��$ Short=�$	��100��$ 	Pick Date��#��[  �� $��10q�$��Center=�$
��Left=�$ ��Phần trăm ưu đãi (%)���� -   $��percentDiscountTxt��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200��$��30��A� -   $��
statusGrid��$y�Hidden=�$��2��$ 2��$��
0,0,-203,0q�.+��� $��10q�$��Center=�$
��Left=�$��Tình trạng���� -   $��comboBoxStatusDiscount��$��Center=�$
��Left=����#CCD0FF$��1q�$��0,11,-10,11q�$	��204��$��30���� �� -   $��btnSaveDiscount��$y�	Collapsed=�$	��100��$��30��$��Center=�$
��Lưu�����	#FFEAEA2B$��0,17,0,0q���Z�  	  $ 5Q�$ 	#FF8B8D8B���� -   $��btnAddDiscount��$	��100��$��30��$��Center=�$��Thêm�����	#FF34BB2D$��0,17,0,0q���Z�  	  $ 5Q�$ 	#FF8B8D8B���� -   $��btnCancelDialog��$	��100��$��30��$��Center=�$��Hủy��
���  ��$��0,17,0,0q���Z�  	  $ 5Q�$ 	#FF8B8D8B��