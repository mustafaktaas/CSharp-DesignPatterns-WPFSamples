   M S B A M L   `   `   `  ????  KeyFrameAnimation;    5keyframes_markup.DoubleAnimationUsingKeyFramesExample   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N? WindowTitle$+  %DoubleAnimationUsingKeyFrames Example??5      .??5
      ??  ?? Orientation$ Vertical=?6   $??Center=?6&   .+?5      ?? -   5        $??myAnimatedButton??5      $	??200q?6%   $	??120??62    J? RenderTransformOrigin$ 0.5,0.5&?6>   .??6^   
Click Mez?5      ?? 5   
    ?? Angle$ 0Q?6    ? Triggers 5      :? 5   
    :? RoutedEvent$ Button.Click??6   .[?5      ?? .??5      ?? .??5      U?  ?? 
TargetName$ myAnimatedButton??5       ?? TargetProperty$6 0(Button.RenderTransform).(RotateTransform.Angle)?5       g? Duration$ 0:0:10D?5      	 g? FillBehavior$
	 Stop=?6#   \?5      ?? 
 O? Value$	
 300Q?6)    O? KeyTime$ 0:0:3??65   n? 5       $	
 225Q?6+   $ 0:0:3.5??67   n? 5!      $	
 180Q?6+   $ 0:0:4??67   n? 5"      $
 90Q?6+   $ 0:0:4.5??66   ?? 5#      $

 -180Q?6)   $ 0:0:10??66    ?? 	KeySpline$ 0.25,0.5 0.75,1??6G   5&      5'      5(      5)      5+      5,      5-      