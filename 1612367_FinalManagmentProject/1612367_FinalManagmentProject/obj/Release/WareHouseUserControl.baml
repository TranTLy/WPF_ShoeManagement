   M S B A M L   `   `   `  ���� X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  9    3_1612367_FinalManagmentProject.WareHouseUserControl   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     >local,clr-namespace:_1612367_FinalManagmentProject     V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  
�������.���� .+��� $��	KHO HÀNG��$��30(�  �� Left$	  400��
 �� Top$ 15���� -   $��SumProductLable��$��	Tổng: 0�����#E98C0A$��16(�$��40��$	��130��$	  765��$ 5��� $��Disabled=�$	��472��$ 55��$	��940��$  0��.+�&   System.Windows.Controls.DataGrid  -   $��ProductDataGrid��   SelectionMode$ Single=�   AutoGenerateColumns .  ���#EAECFF$��0,0,0,25q�   CanUserResizeColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��   Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� 
 �� Path$
 order�  $ 
Tên hàng��$	 150 	 �� $
 nameProduct�  $ Loại��$	 120 	 �� $
 nameTypeProduct�  $ Size 36��$ SizeToHeader 	 �� $
 arrSizeQuantity[0]�  $ Size 37��$ SizeToHeader 	 �� $
 arrSizeQuantity[1]�  $ Size 38��$ SizeToHeader 	 �� $
 arrSizeQuantity[2]�  $ Size 39��$ SizeToHeader 	 �� $
 arrSizeQuantity[3]�  $ Size 40��$ SizeToHeader 	 �� $
 arrSizeQuantity[4]�  $ Size 41��$ SizeToHeader 	 �� $
 arrSizeQuantity[5]�  $ Size 42��$ SizeToHeader 	 �� $
 arrSizeQuantity[6]�     
Foreground �#E98C0A$ Tổng��$ SizeToHeader 	 �� $
 sumQuantity�4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� $��
bntAddItem��-   .��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$	 Add=�$��10��$��10��$��Center=�)	  #MaterialDesignThemes.Wpf.DialogHost	  -   $��dialogAddProduct�� 	  CloseOnClickAway .  	  IsOpen .  $	��900��$	��461��$ 55�� 	  DialogContent A�  A� Columns$ 2��$	��200��$��173,0,182,4q�.+��� $��10q�$��Center=�$
��Left=�$��Size 36���� -   $��size36QuantityTxt��$��0��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,12,0,13q�$��49��$��30���� $��10q�$��Center=�$
��Left=�$��Size 37���� -   $��size37QuantityTxt��$��0��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,12,0,13q�$��49��$��30���� $��10q�$��Center=�$
��Left=�$��Size 38���� -   $��size38QuantityTxt��$��0��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,12,0,13q�$��49��$��30���� $��10q�$��Center=�$
��Left=�$��Size 39���� -   $��size39QuantityTxt��$��0��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,12,0,13q�$��49��$��30���� $��10q�$��Center=�$
��Left=�$��Size 40���� -	   $��size40QuantityTxt��$��0��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,12,0,13q�$��49��$��30���� $��10q�$��Center=�$
��Left=�$��Size 41���� -
   $��size41QuantityTxt��$��0��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,12,0,13q�$��49��$��30���� $��10q�$��Center=�$
��Left=�$��Size 42���� -   $��size42QuantityTxt��$��0��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,12,0,13q�$��49��$��30���� -   $��bntAddProduct��$	��100��$��30��$��Center=�$��Thêm�����	#FF34BB2D��Z�  J� Effect 3
  -System.Windows.Media.Effects.DropShadowEffect
   
  ShadowDepth$ 5Q� 
  Color$ 	#FF8B8D8B���� -   $��btnCancelAddProduct��$	��100��$��30��$��Center=�$��Hủy��
���  ����Z�  
  $ 5Q�$ 	#FF8B8D8B��