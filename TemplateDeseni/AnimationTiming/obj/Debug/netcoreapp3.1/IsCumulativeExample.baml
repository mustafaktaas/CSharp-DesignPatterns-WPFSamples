   M S B A M L   `   `   `  ????  AnimationTiming)    #AnimationTiming.IsCumulativeExample   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N? WindowTitle$  IsCumulative Example??5      .??5      ?? $??20q?6      MyGridBrushResource#??[  6   .+?5
      ?? ._?5      ?? $??20q?6   ??This example shows how to use the IsCumulative property to make an animation build upon each iteration. The rectangles below are animated by DoubleAnimations with identical durations, target values, AutoReverse, and RepeatBehavior but one has the IsCumulative property set to True while the other does not.5   	   5      ?? 5      2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve6"   $??10,0,0,0q?6   
 <DoubleAnimation ... ?? 5      $
??Bold"?6%   IsCumulative="True"6L   \Z
   Duration="0:0:1" From="100" By="100" RepeatBehavior="4x" AutoReverse="True" />
       5   
   ?? 5      -   5        $??withIsCumulative??5      $	??100??5      $??20??6   $??12,0,0,5q?6   ???	#AA3333FF$
??Left=?6B   F? 5      
???   ?$??2??6   ???? ?     ? ??    	5      F? 5      
???   ?$??2??6   ???? ??    ? ?? z 	5      F? 5      
???   ?$??2??6   ???? ????v?? ݢ??v?	5       F? 5!      
???   ?$??2??6   ???? ݢ??v?? ݢ    	5"      F? 5#      
???   ?$??2??6   ???? ݢ??v?? ????v?	5$      F? 5%      
???   ?$??2??6   ???? ????v?? ??    	5&      F? 5'      
???   ?$??2??6   ???? ????v?? ????v?	5(      F? 5)      
???   ?$??2??6   ???? ????v?? ??    	5*      F? 5+      
???   ?$??2??6   ???? ????v?? ????v?	5,      F? 5-      
???   ?$??2??6   ???? ????v?? ??    	5.      ?? 52       preserve6"   $??10,0,0,0q?6   
 <DoubleAnimation ... ?? 53      $
??Bold"?6%   IsCumulative="False"6M   \Z
   Duration="0:0:1" From="100" By="100" RepeatBehavior="4x" AutoReverse="True" />
       55   
   ?? 57      -   5        $??withoutIsCumulative??57      $	??100??58      $??20??6   $??12,0,0,5q?6   ???	#AA3333FF$
??Left=?6B   F? 5:      
???   ?$??2??6   ???? ?     ? ??    	5;      F? 5<      
???   ?$??2??6   ???? ??    ? ?? z 	5=      F? 5>      
???   ?$??2??6   ???? ????v?? ݢ??v?	5?      F? 5@      
???   ?$??2??6   ???? ݢ??v?? ݢ    	5A      F? 5B      
???   ?$??2??6   ???? ݢ??v?? ????v?	5C      F? 5D      
???   ?$??2??6   ???? ????v?? ??    	5E      F? 5F      
???   ?$??2??6   ???? ????v?? ????v?	5G      F? 5H      
???   ?$??2??6   ???? ????v?? ??    	5I      F? 5J      
???   ?$??2??6   ???? ????v?? ????v?	5K      F? 5L      
???   ?$??2??6   ???? ????v?? ??    	5M      ?? 5P      $??0,30,0,0q?6   $
??Left=?6   .??6:   Restart Animations ? Triggers 5R      :? 5S   
    :? RoutedEvent$ Button.Click??6   .[?5T      ?? .??5U      ?? .??5X      W?  ?? 
TargetName$ withIsCumulative??5Y       ?? TargetProperty$ (Rectangle.Width)?5Z       g? Duration$ 0:0:1D?5[       W? From 1006"   	 W? By 1006-   	 W? IsCumulative$
	 True??66   
 g? RepeatBehavior$
 4x??6J    g? AutoReverse$
 True??6^   W? 5^      $ withoutIsCumulative??5_      $ (Rectangle.Width)?5`      $ 0:0:1D?5a       1006"    1006-   $	 False??66   $
 4x??6K   $
 True??6_   5b      5d      5e      5g      5h      5i      