   M S B A M L   `   `   `  ????N? 5      \  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5        N? WindowTitle$)  #RectAnimationUsingKeyFrames Example??5      .??5      ??  ?? Orientation$ Vertical=?6   $??Center=?6&   .+?5      F? 
???   ?$??1??6   
?????????5      ?? 5	   
   -   5        myRectangleGeometry?? ?? Rect$ 0,200,100,100?5	   9    ? Triggers 5      :? 5   
    :? RoutedEvent$ Path.Loaded??6   .[?5      ?? .??5      ?? .??5      ?  ?? 
TargetName$ myRectangleGeometry??5       ?? TargetProperty$
 Rect?5       g? Duration$ 0:0:6D?5       g? FillBehavior$ HoldEnd=?6"   	 g? RepeatBehavior$	 Forever??69   ."?5      ?? 
  ? Value$
 600,50,200,50?6%     ? KeyTime$ 0:0:2??6;   e? 5      $
 600,50,200,10?6'   $ 0:0:2.5??6=   ?? 5#      $
 0,200,100,100?6%   $ 0:0:4.5??6;    ?? 	KeySpline$ 0.6,0.0 0.9,0.00??6M   5$      5%      5&      5'      5)      5+      5,      