   M S B A M L   `   `   `  ����X  T1612367_FinalManagmentProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:_1612367_FinalManagmentProject_1612367_FinalManagmentProject  5   	   .    (_1612367_FinalManagmentProject.WareHouse   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:_1612367_FinalManagmentProject     5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	WareHouse��5
   	   $	��530��6   $	��910��6(   
�������.��5      �� $��10,5,8,5q�6   .+�5   
   A�  A� Columns$ 2��6   $��173,10,182,40q�6#   .+�5      �� $��10q�6   $��Center=�6    $
��Left=�6;   $��Khách hàng: ��6V   �� 5      -   5         ��Name$ lblNameCustomer��5      $y�Visible=�6-   $��-152,10,0,10q�6B   $��Center=�6X   $
��Left=�6s   $��Tên Khách hàng��6�   $	��256��6�   5      � 5   
   $	��377��6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ DetailReceiptDataGridShow��5      "   VerticalScrollBarVisibility$
 Auto=�6;      SelectionMode$ Single=�6_      AutoGenerateColumns .  ���#EAECFF   CanUserResizeColumns .     
IsReadOnly . $��	5,9,15,50q�5   E   ��6Y   �� *listDetailReciept+	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 STT��6C      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *order+6P     5      $
 
Tên hàng��6I   $	 140 6[    6)   �� *nameProduct+6[     5      $
 SL��6F   $ 50 6R    6)   �� *
quantity+6R     5      $

 Size��6B   $ 55 6P    6)   �� *size+6P     5      $
 
Đơn giá��6K   $ SizeToHeader 6\    6)   �� *unitPriceSell+6\     5      $
 Tên Ưu đãi��6J   $	 140 6^    6)   �� *nameDiscount+6^     5      $
 	Ưu đãi��6L   $ SizeToHeader 6\    6)   �� *discountString+6\     5      $
 Thành tiền��6F      
Foreground �#FCC014$ SizeToHeader 6o    6)   �� *
sumMoney+6o     5       $
 Tổng Điểm��6F    �#FCC014$ SizeToHeader 6n    6)   �� *
sumScore+6n   5"      �� 5#      -   5        $ SumMoneyLableShow��5#      $��Tổng tiền: 0đ��6/   ���#FBC31F$��371,326,149,10q�6\   �� 5$      -   5        $ SumScoreLableShow��5$      $��Tổng điểm: 0��6/   ���#FBC31F$��220,326,438,10q�6[   �� 5%      -   5         ��Name$ bntClose��5%      $��98��6>   $
��Auto��6I   $��Center=�6W   $��Đóng��6t   ���#EA4335$��682,327,104,15q�6�   ��6�   Z�  J� Effect 5&      3  -System.Windows.Media.Effects.DropShadowEffect  5'         ShadowDepth$ 5Q�6'      Color$ 	#FF8B8D8B��67   5)      5*      5+      5,      