   M S B A M L   `   `   `  ????G  CImageScaling, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ImageScalingImageScaling  5   	       ImageScaling.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ImageScaling     5   	     ? Title$"  ImageScaling-Per Monitor DPI??5   	    ? SizeToContent$ WidthAndHeight=?6.   .??5	      ? $??40q?6    ? RowDefinitions 5
   
   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   ?? 5      $??* ?6   ?? 5      $
??Auto ?6   .+?5   
   ?? -   5         ??Name$ 	textLabel??5      $$??images\MSFT_logo.scale-100.png??6'   $??4??6M   $??20(?6Z   $??10q?6h   ?? 5   
   $??0??6   $??18(?6!   ZXUsing <Image Source="..." Initialize="PickRightScaledImage" Width="524" Height="193" />:6?   ?? 5   
   -   5        $$??images\MSFT_logo.scale-100.png??5      $??1??68   $	??524??5   3   $	??193??6?   ?? 5   
   $??2??6   $??18(?6!   -+Using <local:DpiAwareImage Source="..." />:6b       ImageScaling.DpiAwareImage  5   
   $$??images\MSFT_logo.scale-100.png??6   $??3??6F   5      5      