   M S B A M L   `   `   `  ????  AnimationTiming1    +AnimationTiming.HandoffVersusComposeExample   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        ? 	Resources  5         
FadeToHalf	 W? To g? Duration ?? TargetProperty  
FadeToFull  Compose ?? 
TargetType ?? Property ?? Value ?? Triggers :? RoutedEvent	 ?? HandoffBehavior  Handoff??%Y  &	        &	 ?     &	 5    7   7  &	 ?    7   7  ?? 5      .??5      W?  0.56   $ 0:0:1.0D?6   $ Fill.Opacity?5      W? 5	       456   $ 0:0:1.0D?6   $ Height?5
      5      ?? 5      .??5      W? $ 0:0:1.0D?6   $ Fill.Opacity?5      W? 5      $ 0:0:1.0D?6   $ Height?5      5      ?? 5      " ??6   .?5      ??  ? ??
 ?  ??6   ?? 5       ? ??$ 90??6   ?? 5       ? ??$ 90??6    5      :? 5      $ Mouse.MouseEnter??6   [?5      ?? 5      8??  $	 Compose=?6A   5      :? 5      $ Mouse.MouseLeave??6   [?5      ?? 5      8?? $	 Compose=?6A   5       5"      ?? 5#      " ??6   .?5$      ??  ? ??
 ??  ?6   ?? 5%       ? ??$ 90??6   ?? 5&       ? ??$ 90??6    5'      :? 5(      $ Mouse.MouseEnter??6   [?5)      ?? 5*      8??  $	 SnapshotAndReplace=?6A   5,      :? 5-      $ Mouse.MouseLeave??6   [?5.      ?? 5/      8?? $	 SnapshotAndReplace=?6A   51      53      54      .??55      ?? 
???????.+?56      ?? 

 ?? Top$
 50??6    ?? Left$	 100??6   
???  ??	Compose6J   ?? 57      $
 50??6   $	 200??6   
????  ?SnapshotAndReplace6V   ?? 58      #??[ 6   $	
 100??6/   $	 100??6@   ?? 59      #??[ 6   $	
 100??6/   $	 200??6@   ?? 5:      #??[ 6   $	
 200??6/   $	 100??6@   ?? 5;      #??[ 6   $	
 200??6/   $	 200??6@   5<      5=      