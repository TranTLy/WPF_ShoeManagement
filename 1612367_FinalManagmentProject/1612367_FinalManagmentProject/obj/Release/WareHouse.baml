   M S B A M L   `   `   `  ���� X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  .    (_1612367_FinalManagmentProject.WareHouse   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     >local,clr-namespace:_1612367_FinalManagmentProject     V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  	WareHouse��$	��530��$	��910��
�������.���� $��10,5,8,5q�.+�A�  A� Columns$ 2��$��173,10,182,40q�.+��� $��10q�$��Center=�$
��Left=�$��Khách hàng: ���� -    ��Name$ lblNameCustomer��$y�Visible=�$��-152,10,0,10q�$��Center=�$
��Left=�$��Tên Khách hàng��$	��256��� $	��377��.+�&   System.Windows.Controls.DataGrid  -     Name$ DetailReceiptDataGridShow��"   VerticalScrollBarVisibility$
 Auto=�   SelectionMode$ Single=�   AutoGenerateColumns .  ���#EAECFF   CanUserResizeColumns .     
IsReadOnly . $��	5,9,15,50q����� *listDetailReciept+	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$	
 STT��   Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *order+  $
 
Tên hàng��$	 140  �� *nameProduct+  $
 SL��$ 50  �� *
quantity+  $

 Size��$ 55  �� *size+  $
 
Đơn giá��$ SizeToHeader  �� *unitPriceSell+  $
 Tên Ưu đãi��$	 140  �� *nameDiscount+  $
 	Ưu đãi��$ SizeToHeader  �� *discountString+  $
 Thành tiền��   
Foreground �#FCC014$ SizeToHeader  �� *
sumMoney+  $
 Tổng Điểm�� �#FCC014$ SizeToHeader  �� *
sumScore+�� -   $ SumMoneyLableShow��$��Tổng tiền: 0đ�����#FBC31F$��371,326,149,10q��� -   $ SumScoreLableShow��$��Tổng điểm: 0�����#FBC31F$��220,326,438,10q��� -    ��Name$ bntClose��$��98��$
��Auto��$��Center=�$��Đóng�����#EA4335$��682,327,104,15q���Z�  J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 5Q�   Color$ 	#FF8B8D8B��