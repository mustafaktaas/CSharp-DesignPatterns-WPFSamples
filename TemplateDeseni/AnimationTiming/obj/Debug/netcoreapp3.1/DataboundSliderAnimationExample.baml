   M S B A M L   `   `   `  ????  AnimationTiming5    /AnimationTiming.DataboundSliderAnimationExample   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        N? 
Background
  ????? ? Triggers 5      :? 5	       :? RoutedEvent$ Button.Click??6    :? 
SourceName$ myButton??6/   [?5
      ?? 5   
   .??5      ??  g? FillBehavior$ HoldEnd=?6   .??5      W? $ HoldEnd=?5       g? 	BeginTime 00:00:005       ?? 
TargetName$ MyAnimatedRectangle??5       ?? TargetProperty$ Width?5       g? Duration$ 00:00:03D?5      	 W? From	 05      	
 W? To
 5      ??  ?? ElementName$% AnimationDestinationValueSlider?? ?? Path$ Value?5      5      5      5      .??5      ?? $??20q?6   .+?5      ?? Select a destination value:6-   ?? 5       -   5        $%??AnimationDestinationValueSlider??5        ?? Orientation$ 
Horizontal=?5!      $
??Left=?5"       ? Minimum$ 25Q?5#       ? Maximum$	 500Q?6   $	??500??5$      ?? 5%      $??50??5'      
???  ??$
??Left=?5(      $??0,10,0,0q?6"   ??5&      ?? $% AnimationDestinationValueSlider??$ Value?5(   "   ?? 5*      $??0,30,0,0q?6   Animated Rectangle66   ?? 5+      -   5        $??MyAnimatedRectangle??5+   2   $??50??6   $??50??6   
???  ??$
??Left=?5,      $??0,10,0,0q?5-      ?? 5.      -   5        $??myButton??5.   A   $??Trigger animation??6   $	??150??6)   $??40??65   6A   5/      50      