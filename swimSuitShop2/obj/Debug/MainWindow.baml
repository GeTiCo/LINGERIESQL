   M S B A M L   `   `   `  ����H  DswimSuitShop2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:swimSuitShop2swimSuitShop2  5   	       swimSuitShop2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:swimSuitShop2     5   	     � WindowStyle$
  None=�5   	    � AllowsTransparency . $	��0.3q�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 
MainWindow��5   	   $	��550��5   	   $	��450��5   	    � 
ResizeMode$ 	CanResize=�5   	    J� Clip 5      �� 5   
    �� Rect$ 0,0,450,550�6    �� RadiusX$ 10Q�6/    �� RadiusY$ 10Q�6<   .��5      � 	 � RowDefinitions	 5   
   �� 5      $	��100 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   �� 
 �� CornerRadius$
 	0,0,10,10��6   ���	#FF007AFF$��0��6A   ._�5      � $��0��6      
headerGrid#��[  6     � ColumnDefinitions 5      �� 5      $	��100 �6'   �� 5      $��* �6'   �� 5       $	��100 �6'   .+�5$      �� $��0��6   $��12q�5%      $��/res/LogoSwim1.png��5&      �� 5(      $��1��6   $��LINGERIE��5)        ETBStyle#��[ 5*      $��Center=�5+      $��40(�5,      
�������$��72��5.      �� 50      -   5        $��2��50        Exit#��[ 6)   6G   51       J� Effect 52      3  -System.Windows.Media.Effects.DropShadowEffect  53         
BlurRadius$ 20Q�6#      Color$
 blue��63      Opacity$	 0.3Q�6@   55      � 57   
   $��1��6     mainback#��[ 6   	 58      �� 59      $��65 �6    �� 5:      $��* �6    �� 5;      $��* �6    �� 5<      $��* �6    �� 5=      $��65 �6    .+�5A      �� -   5        $��1��5A      $��40, 5q�5B      $��Каталог��5C        btnStyle#��[ 5E      �� 5G      -   5        $��2��5G      $��40, 5q�5H      $!��Оформить заказ��5I      #��[ 5K      �� 5M      -   5        $��3��5M      $��40, 5q�5N      $ ��Редактировать��5O      #��[ 5Q      5R      �� 5T   
   $
 	10,10,5,0��6   ���	#FF007AFF$��2��6A   ._�5U      � $��2��6     	foterGrid#��[ 6     5V      �� 5W      $��* �6'   �� 5X      $��* �6'   .+�5\      �� $��0��6   $��
©LINGERIE��5]      $��20(�5^      #��[ 5_      $��10,0,0,0q�5`      
�������$��35��5b      5c      �� 5e      $��1��6   $��Center=�5f      $��Right=�5g      $��0,0,10,0q�5h        Message#��[ 5i      5j      5k      5l      5m      