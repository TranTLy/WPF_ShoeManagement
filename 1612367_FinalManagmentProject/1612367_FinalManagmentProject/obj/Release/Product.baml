   M S B A M L   `   `   `  ���� X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  ,    &_1612367_FinalManagmentProject.Product   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     >local,clr-namespace:_1612367_FinalManagmentProject     V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  
�������.���� .+��� $��SẢN PHẨM��$��30(�  �� Left$	  395��
 �� Top$ 15��A�  A� Columns$ 3��$  95��$ 68��$	��295��.+��� $��Tìm kiếm���� -   $��cbTypeProduct��� $��Disabled=�$	��390��$	 120��$	��890��$  12��.+�&   System.Windows.Controls.DataGrid  -   $��ProductDataGrid��   SelectionMode$ Single=�   AutoGenerateColumns .  ���#EAECFF$��5,0,5,30q�   CanUserResizeColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 SizeToHeader 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 ��  �� Path$ order�  $ 
Tên hàng��$		 150 
 �� $ nameProduct�  $ Loại��$		 120 
 �� $ nameCategory�  $ Giá nhập kho��$		 120 
 �� $ stringPriceImport�  $ 	Giá bán��$		 120 
 �� $ stringPriceSell�  $ Điểm tích lũy��$	 SizeToHeader 
 �� $ 
bonusScore�  $ 
Đơn vị��$	 SizeToHeader 
 �� $
 unit�4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� $��btnEdt��-   .��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$
 Edit=�$��20��$��20��$��Center=�   �� .R��� $��	btnDelete��-   .��  $ Delete=�$��20��$��20��$��Center=��� -   $��btnAdd��$	  846��$	 441�����	#FF34BB2D��Z�  J� Effect 3	  -System.Windows.Media.Effects.DropShadowEffect	   	  ShadowDepth$ 5Q� 	  Color$ 	#FF8B8D8B��.��  $	 Add=�$��20��$��20��$��Center=�)
  #MaterialDesignThemes.Wpf.DialogHost
  -   $��dialogAddProduct�� 
  CloseOnClickAway .  
  IsOpen .  $	��900��$	��451��$ 65�� 
  DialogContent A�  A� Rows$ 9��$ 2��$	��400��$��173,0,182,4q�.+��� $��10q�$��Center=�$
��Left=�$��Tên sản phẩm���� -   $��nameProductTxt��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200��$��30���� -   $��categoryLable��$��10q�$��Center=�$
��Left=�$��Loại���� -	   $��comboBoxCategory��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200������ *
nameType+�� $��10q�$��Center=�$
��Left=�$��Giá nhập hàng���� -
   $��priceImprotTxt��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200���� $��10q�$��Center=�$
��Left=�$��Giá xuất���� -   $��priceSellTxt��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200���� $��10q�$��Center=�$
��Left=�$��Điểm tích lũy���� -   $��bonusScoreTxt��$��0��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200���� $��10q�$��Center=�$
��Left=�$��
Đơn vị���� -   $��unitTxt��$��Đôi��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200���� -   $��lblSize��$��10q�$��Center=�$
��Left=�$��2��$
��Size���� $��10q�$��Center=�$
��Left=�A� -   $��sizeCheckboxs��$��Center=�$��7��$��2��$ 1��$��Center=�$��22��$��37,13,-195,11q�$	��360��.+��� -   $��checkboxSize36��$��36�� d� 	IsChecked$
 TrueY��� -   $��checkboxSize37��$��37��$
 TrueY��� -   $��checkboxSize38��$��38��$
 TrueY��� -   $��checkboxSize39��$��39��$
 TrueY��� -   $��checkboxSize40��$��40��$
 TrueY��� -   $��checkboxSize41��$��41��$
 TrueY��� -   $��checkboxSize42��$��42��$
 TrueY��� $��10q�$��Center=�$
��Left=��� -   $��btnSave��$y�Visible=�$	��100��$��30��$��Center=�$
��Lưu����Z�  	  $ 5Q�$ 	#FF8B8D8B���� -   $��bntAddProduct��$	��100��$��30��$��Center=�$��Thêm�����	#FF34BB2D��Z�  	  $ 5Q�$ 	#FF8B8D8B���� -   $��btnCancelAddProduct��$	��100��$��30��$��Center=�$��Hủy��
���  ����Z�  	  $ 5Q�$ 	#FF8B8D8B��