   M S B A M L   `   `   `  ���� X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  5    /_1612367_FinalManagmentProject.BillUserControl1   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     >local,clr-namespace:_1612367_FinalManagmentProject     V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  
�������.���� .+��� $��
HÓA ĐƠN��$��30(�  �� Left$	  400��
 �� Top$ 15��� $��Disabled=�$	��436��$��Center=�
�������$	��900��$ 80��$  8��.+�&   System.Windows.Controls.DataGrid  -   $��ReceiptDataGrid��   SelectionMode$ Single=�   AutoGenerateColumns .  ���#EAECFF$��	17,5,5,11q�   CanUserResizeColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��   Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� 
 �� Path$
 order�  $ 
Hóa đơn��$	 150 	 �� $
 nameReceipt�  $ Khách hàng��$	 200 	 �� $
 nameCustomer�  $ Ngày xuất��$	 150 	 �� $
 	shortDate�  $ Tổng tiền��$	 100 	 �� $
 stringSumMoney�  $ Tổng điểm��$ SizeToHeader 	 �� $
 sumScore�4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� $��	bntDetail��-   .��'  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Details=�$��20��$��20��$��Center=��� -   $��btnAdd��$	  855��$	 441�����	#FF34BB2D��Z�  J� Effect 3	  -System.Windows.Media.Effects.DropShadowEffect	   	  ShadowDepth$ 5Q� 	  Color$ 	#FF8B8D8B��.��  $	 Add=�$��20��$��20��$��Center=�)
  #MaterialDesignThemes.Wpf.DialogHost
  -   $��dialogReceiptDetailShow�� 
  CloseOnClickAway .  
  IsOpen .  $	��930��$	��550��$ 20��$  5�� 
  DialogContent �� $��10,5,8,5q�.+�A�  A� Columns$ 2��$��173,10,182,40q�.+��� $��10q�$��Center=�$
��Left=�$��Khách hàng: ���� -    ��Name$ lblNameCustomer��$y�Visible=�$��-152,10,0,10q�$��Center=�$
��Left=�$��Tên Khách hàng��$	��256��� $	��377��.+�  -     Name$ DetailReceiptDataGridShow��"   VerticalScrollBarVisibility$
 Auto=�$ Single=� .  ���#EAECFF .   . $��	5,9,15,50q����� *listDetailReciept+   $	 STT��$ SizeToHeader 	 �� *order+  $ 
Tên hàng��$	 140 	 �� *nameProduct+  $ SL��$ 50 	 �� *
quantity+  $
 Size��$ 55 	 �� *size+  $ 
Đơn giá��$ SizeToHeader 	 �� *unitPriceSell+  $ Tên Ưu đãi��$	 140 	 �� *nameDiscount+  $ 	Ưu đãi��$ SizeToHeader 	 �� *discountString+  $ Thành tiền��   
Foreground �#FCC014$ SizeToHeader 	 �� *stringSumMoney+  $ Tổng Điểm�� �#FCC014$ SizeToHeader 	 �� *
sumScore+�� -   $ SumMoneyLableShow��$��Tổng tiền: 0đ�����#FBC31F$��371,326,149,10q��� -   $ SumScoreLableShow��$��Tổng điểm: 0�����#FBC31F$��220,326,438,10q��� -	    ��Name$ bntClose��$��98��$
��Auto��$��Center=�$��Đóng�����#EA4335$��682,327,104,15q���Z�  	  $ 5Q�$ 	#FF8B8D8B��
  -
   $��dialogReceipt�� .  .  $	��930��$	��550��$ 20��$  5�� �� $	��850��$��
5, 5, 5, 5q�.+�A� $ 2��$��173,10,182,40q�.+��� $��10q�$��Center=�$
��Left=�$��Khách hàng���� -   $��comboBoxCustomer��$��Center=�$
��Left=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200���� -   $��nameCustomerLable��$y�	Collapsed=�$��10q�$��Center=�$
��Left=�$��Tên Khách hàng��A� $ 3��$��
15,0,0, 15q�.+��� $��10q�$��Center=�$
��Left=�$��Tên sản phẩm���� $��10q�$��Center=�$
��Left=�$
��Size���� $��10q�$��Center=�$
��Left=�$��Số lượng���� -   $��comboBoxNameProduct��$��Center=�$��Center=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200���� -   $��comboBoxSize��$��Center=�$��Center=����#CCD0FF$��1q�$
��0,13q�$	��122���� -   $��quantityTxt��$��Center=�$��Center=����#CCD0FF$��1q�$��	0,10,0,10q�$	��200��$��30���� -   $ btnAddDetail��$	��100��$��30��$��Center=�$��Thêm�����	#FF34BB2D$��
650,0,50,0q���Z�  	  $ 5Q�$ 	#FF8B8D8B��� $	��229��.+�  -   $��DetailReceiptDataGrid��$
 Auto=�$ Single=� .  ���#EAECFF .   . $��	5,9,15,80q����� *listDetailReciept+   $	 STT��$ SizeToHeader 	 �� $
 order�  $ 
Tên hàng��$	 140 	 �� $
 nameProduct�  $ SL��$ 50 	 �� $
 quantity�  $
 Size��$ 55 	 �� $

 size�  $ 
Đơn giá��$	 100 	 �� $
 stringUnitPrice�  $ Tên Ưu đãi��$	 140 	 �� $
 nameDiscount�  $ 	Ưu đãi��$ SizeToHeader 	 �� $
 discountString�  $ Thành tiền�� �#FCC014$ SizeToHeader 	 �� $
 stringSumMoney�  $ Tổng Điểm�� �#FCC014$ SizeToHeader 	 �� $
 sumScore�   �� .R��� $��bntCancelBuyProduct��-   $��-��
���  ����Z� �� -   $��SumMoneyLable��$��Tổng tiền: 0đ�����#FBC31F$��373,155,150,44q��� -   $��SumScoreLable��$��Tổng điểm: 0�����#FBC31F$��242,155,423,44q��� -   $ bntCanel��$	��110��$
��Auto��$��Center=�$��Hủy�����#EA4335$��640,184,50,15q���Z�  	  $ 5Q�$ 	#FF8B8D8B���� -   $ btnPay��$	��110��$
��Auto��$��Center=�$��Thanh toán��$��505,184,185,15q���Z�  	  $ 5Q�$ 	#FF8B8D8B��