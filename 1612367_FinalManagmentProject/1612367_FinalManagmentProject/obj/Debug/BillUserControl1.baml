   M S B A M L   `   `   `  ����X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  5      5    /_1612367_FinalManagmentProject.BillUserControl1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:_1612367_FinalManagmentProject     5      V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      
�������.��5
      �� .+�5   
   �� $��
HÓA ĐƠN��6   $��30(�6"     �� Left$	  400��60   
 �� Top$ 15��6B   6T   � 5   
   $��Disabled=�6   $	��436��5      $��Center=�6   
�������$	��900��6N   $ 80��6Z   $  8��6j   .+�5      &   System.Windows.Controls.DataGrid  -   5        $��ReceiptDataGrid��5         SelectionMode$ Single=�6.      AutoGenerateColumns .  ���#EAECFF$��	17,5,5,11q�5         CanUserResizeColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 STT��6H      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6U   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6)   �� 
 �� Path$
 order�6U     5      $ 
Hóa đơn��6N   $	 150 6_   	 6)   �� $
 nameReceipt�6_     5      $ Khách hàng��6O   $	 200 6c   	 6)   �� $
 nameCustomer�6c     5      $ Ngày xuất��6L   $	 150 6_   	 6)   �� $
 	shortDate�6_     5      $ Tổng tiền��6Q   $	 100 6d   	 6)   �� $
 stringSumMoney�6d     5      $ Tổng điểm��6K   $ SizeToHeader 6^   	 6)   �� $
 sumScore�6^   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5   "   �� $��	bntDetail��6)   -   5        .��5   &   '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Details=�6>   $��20��6M   $��20��6X   $��Center=�6d   5   #   5       5"      51      52      �� 55   
   -   5        $��btnAdd��55      $	  855��64   $	 441��6F   ���	#FF34BB2D��6n   Z�  J� Effect 56      3	  -System.Windows.Media.Effects.DropShadowEffect	  57       	  ShadowDepth$ 5Q�6#    	  Color$ 	#FF8B8D8B��63   .��59        $	 Add=�6&   $��20��61   $��20��6<   $��Center=�6H   5:      )
  #MaterialDesignThemes.Wpf.DialogHost
  5=   
   -   5        $��dialogReceiptDetailShow��5=   $    
  CloseOnClickAway .  
  IsOpen .  $	��930��5>   3   $	��550��6?   $ 20��6L   $  5��6\    
  DialogContent 5?      �� 5@      $��10,5,8,5q�6   .+�5B      A�  A� Columns$ 2��6#   $��173,10,182,40q�6/   .+�5C      �� $��10q�6    $��Center=�6,   $
��Left=�6G   $��Khách hàng: ��6b   �� 5E      -   5         ��Name$ lblNameCustomer��5E       $y�Visible=�69   $��-152,10,0,10q�6N   $��Center=�6d   $
��Left=�6   $��Tên Khách hàng��6�   $	��256��6�   5F      � 5H      $	��377��6   .+�5I        -   5          Name$ DetailReceiptDataGridShow��5I   #   "   VerticalScrollBarVisibility$
 Auto=�6G   $ Single=�6k    .  ���#EAECFF .   . $��	5,9,15,50q�5J   E   ��6Y   �� *listDetailReciept+ 5K        5L   "   $	 STT��6O   $ SizeToHeader 6\   	 65   �� *order+6\     5M   "   $ 
Tên hàng��6U   $	 140 6g   	 65   �� *nameProduct+6g     5N   "   $ SL��6R   $ 50 6^   	 65   �� *
quantity+6^     5O   "   $
 Size��6N   $ 55 6\   	 65   �� *size+6\     5P   "   $ 
Đơn giá��6W   $ SizeToHeader 6h   	 65   �� *unitPriceSell+6h     5Q   "   $ Tên Ưu đãi��6V   $	 140 6j   	 65   �� *nameDiscount+6j     5R   "   $ 	Ưu đãi��6X   $ SizeToHeader 6h   	 65   �� *discountString+6h     5T   "   $ Thành tiền��6X      
Foreground �#FCC014$ SizeToHeader 6�   	 65   �� *stringSumMoney+6�     5U   "   $ Tổng Điểm��6R    �#FCC014$ SizeToHeader 6z   	 65   �� *
sumScore+6z   5W      �� 5X      -   5        $ SumMoneyLableShow��5X       $��Tổng tiền: 0đ��6;   ���#FBC31F$��371,326,149,10q�6h   �� 5Y      -   5        $ SumScoreLableShow��5Y       $��Tổng điểm: 0��6;   ���#FBC31F$��220,326,438,10q�6g   �� 5Z      -	   5         ��Name$ bntClose��5Z   !   $��98��6J   $
��Auto��6U   $��Center=�6c   $��Đóng��6�   ���#EA4335$��682,327,104,15q�6�   ��6�   Z�  5[      	  5\   "   $ 5Q�63   $ 	#FF8B8D8B��6C   5^      5_      5`      5c      
  5f   
   -
   5        $��dialogReceipt��5f   $    .  .  $	��930��5g   4   $	��550��6@   $ 20��6M   $  5��6]    5h      �� 5i      $	��850��6   $��
5, 5, 5, 5q�6)   .+�5j      A� $ 2��6#   $��173,10,182,40q�6/   .+�5k      �� $��10q�6    $��Center=�6,   $
��Left=�6G   $��Khách hàng��6b   �� 5l      -   5        $��comboBoxCustomer��5l   #   $��Center=�6<   $
��Left=�6W   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   �� 5m      -   5        $��nameCustomerLable��5m       $y�	Collapsed=�69   $��10q�6P   $��Center=�6\   $
��Left=�6w   $��Tên Khách hàng��6�   5n      A� 5p      $ 3��6#   $��
15,0,0, 15q�60   .+�5q      �� $��10q�6    $��Center=�6,   $
��Left=�6G   $��Tên sản phẩm��6b   �� 5r      $��10q�6    $��Center=�6,   $
��Left=�6G   $
��Size��6b   �� 5s      $��10q�6    $��Center=�6,   $
��Left=�6G   $��Số lượng��6b   �� 5u      -   5        $��comboBoxNameProduct��5u   #   $��Center=�6>   $��Center=�6Y   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   �� 5v      -   5        $��comboBoxSize��5v   #   $��Center=�68   $��Center=�6S   ���#CCD0FF$��1q�6�   $
��0,13q�6�   $	��122��6�   �� 5w      -   5        $��quantityTxt��5w   "   $��Center=�65   $��Center=�6P   ���#CCD0FF$��1q�6�   $��	0,10,0,10q�6�   $	��200��6�   $��30��6�   5y      �� 5z      -   5        $ btnAddDetail��5z      $	��100��6N   $��30��6Z   $��Center=�6f   $��Thêm��6�   ���	#FF34BB2D$��
650,0,50,0q�6�   ��6�   Z�  5{      	  5|      $ 5Q�6/   $ 	#FF8B8D8B��6?   5~      � 5�      $	��229��6   .+�5�        -   5        $��DetailReceiptDataGrid��5�   #   $
 Auto=�6A   $ Single=�6e    .  ���#EAECFF .   . $��	5,9,15,80q�5�   E   ��6Y   �� *listDetailReciept+ 5�        5�   "   $	 STT��6T   $ SizeToHeader 6a   	 65   �� $
 order�6a     5�   "   $ 
Tên hàng��6Z   $	 140 6l   	 65   �� $
 nameProduct�6l     5�   "   $ SL��6W   $ 50 6c   	 65   �� $
 quantity�6c     5�   "   $
 Size��6S   $ 55 6a   	 65   �� $

 size�6a     5�   "   $ 
Đơn giá��6^   $	 100 6o   	 65   �� $
 stringUnitPrice�6o     5�   "   $ Tên Ưu đãi��6[   $	 140 6o   	 65   �� $
 nameDiscount�6o     5�   "   $ 	Ưu đãi��6]   $ SizeToHeader 6m   	 65   �� $
 discountString�6m     5�   "   $ Thành tiền��6]    �#FCC014$ SizeToHeader 6�   	 65   �� $
 stringSumMoney�6�     5�   "   $ Tổng Điểm��6W    �#FCC014$ SizeToHeader 6   	 65   �� $
 sumScore�6     5�   "    5�   &   �� 5�   *   .R�5�   .   �� $��bntCancelBuyProduct��65   -   5        $��-��5�   l   
���  ����6x   Z� 5�   /   5�   +   5�   #   5�      �� 5�      -   5        $��SumMoneyLable��5�       $��Tổng tiền: 0đ��65   ���#FBC31F$��373,155,150,44q�6b   �� 5�      -   5        $��SumScoreLable��5�       $��Tổng điểm: 0��65   ���#FBC31F$��242,155,423,44q�6a   �� 5�      -   5        $ bntCanel��5�   !   $	��110��6K   $
��Auto��6W   $��Center=�6e   $��Hủy��6�   ���#EA4335$��640,184,50,15q�6�   ��6�   Z�  5�      	  5�   "   $ 5Q�63   $ 	#FF8B8D8B��6C   5�      �� 5�      -   5        $ btnPay��5�   !   $	��110��6G   $
��Auto��6S   $��Center=�6a   $��Thanh toán��6~   $��505,184,185,15q�6�   ��6�   Z�  5�      	  5�   "   $ 5Q�63   $ 	#FF8B8D8B��6C   5�      5�      5�      5�      5�      5�      