   M S B A M L   `   `   `  ����?  ;View, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ViewView  5   	       View.MainWindow   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5   	   c _DevExpress.Xpf.Ribbon.v19.1, Version=19.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxr4http://schemas.devexpress.com/winfx/2008/xaml/ribbon   5   	   ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5   	   localclr-namespace:View  5   	     � WindowStartupLocation$  CenterScreen=�6*    � Title$5 /Quản lý học sinh Trường THPT An Dương��5	   	   $	��580��67   $	��920��6D   $	��720��6P   $
��1020��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   )  #DevExpress.Xpf.Ribbon.RibbonControl  $��0��6      RibbonStyle$ 
Office2010=�6)      ToolbarItems 5      +  %DevExpress.Xpf.Bars.BarButtonItemLink  5      )  #DevExpress.Xpf.Bars.BarItemLinkBase   BarItemName$ newItem��6(      Items. 5      5  /DevExpress.Xpf.Ribbon.RibbonDefaultPageCategory  2  ,DevExpress.Xpf.Ribbon.RibbonPageCategoryBase   Pages. 5      &   DevExpress.Xpf.Ribbon.RibbonPage     Caption)  #DevExpress.Xpf.Core.ObjectConverter$ Hệ thống 6!   	   Groups.	 5      +  %DevExpress.Xpf.Ribbon.RibbonPageGroup  
   Caption$
 Tài khoản��6*      Items. 5      '	  !DevExpress.Xpf.Bars.BarButtonItem	  !
  DevExpress.Xpf.Bars.BarItem 
  Content$ Đăng nhập 6,    
  RibbonStyle$ Large=�6@    
  Glyph 6T   *  $DevExpress.Xpf.Core.DXImageExtension  *'%Images/Comments/EditComment_32x32.png+	  5      $ Đổi mật khẩu 6,   $ Large=�6C    6W     *'%Images/Comments/EditComment_32x32.png+	  5      $ Đăng xuất 6,   $ Large=�6@   5        5      $
  ��6*   . 5      	  $" Phân quyền người dùng 6,   $ Large=�6L   5        5      $
 Dữ liệu��6*   . 5       	  $ Sao lưu 6,   $ Large=�6>   	  5!      $ Phục hồi 6,   $ Large=�6?   5"      5#        5$      $ 
Danh mục 6!   .	 5%        $
 Khối lớp��6*   . 5&      	  $ Khối 6,   $ Large=�6;   	  5'      $ Lớp 6,   $ Large=�6:   5(        5)      $
 Giáo viên��6*   . 5*      	  $ Giáo viên 6,   $ Large=�6@   	  5+      $ Chuyên môn 6,   $ Large=�6A   5,        5-      $
 
Môn học��6*   . 5.      	  $ 	Ban học 6,   $ Large=�6>   	  5/      $ 
Môn học 6,   $ Large=�6>   50        51      $
 Học tập��6*   . 52      	  $ Xếp loại 6,   $ Large=�6?   	  53      $ Điểm 6,   $ Large=�6;   	  54      $ Loại hạnh kiểm 6,   $ Large=�6E   55        56      $
 Khác��6*   . 57      	  $ 
Dân tộc 6,   $ Large=�6>   	  58      $ Trình độ học vấn 6,   $ Large=�6G   	  59      $ Tình trạng hồ sơ 6,   $ Large=�6G   	  5:      $ Loại phiếu thu 6,   $ Large=�6E   	  5;      $! Loại phiếu điểm danh 6,   $ Large=�6K   5<      5=        5>      $ Hồ sơ học sinh 6!   .	 5?        $
  ��6*   . 5@      	  $&  Cập nhật hồ sơ học sinh 6,   $ Large=�6N   	  5A      $) #Cập nhật trạng thái hồ sơ 6,   $ Large=�6P   	  5B      $ Phân lớp học sinh 6,   $ Large=�6H   5C      5D        5E      $ Giảng dạy 6!   .	 5F        $
  ��6*   . 5G      	  $% Phân công chủ nhiệm lớp 6,   $ Large=�6N   	  5H      $ Phân công giảng dạy 6,   $ Large=�6J   5I      5J        5K      $ Học tập 6!   .	 5L        $
  ��6*   . 5M      	  $ Cập nhật điểm 6,   $ Large=�6D   	  5N      $ Cập nhật điểm danh 6,   $ Large=�6I   	  5O      $! Cập nhật khen thưởng 6,   $ Large=�6K   	  5P      $ Cập nhật kỷ luật 6,   $ Large=�6G   	  5Q      $  Cập nhật hạnh kiểm 6,   $ Large=�6I   	  5R      $ Tổng kết 6,   $ Large=�6?   5S      5T        5U      $ Quản lý thu chi 6!   .	 5V        $
  ��6*   . 5W      	  $ Quản lý thu 6,   $ Large=�6B   	  5X      $ Quản lý chi 6,   $ Large=�6B   5Y      5Z        5[      $ Báo cáo thống kê 6!   5]      5^      5_      2  ,DevExpress.Xpf.Ribbon.RibbonStatusBarControl  5`   
   $��2��6%      
RightItems 5a      	  5b      -   5         	 Name$ 	printItem��5b   $   $ Print 67    6G        Image1  +DevExpress.Xpf.Core.Native.DXImageConverter$ Print_16x16.png 5d      � 5e   
   $��1��6   .+�5f         
View.UCThu     
View.UCThu   Loaded$ UCPhanCongChuNhiem_Loaded��6   6?   5g      5h      5i      