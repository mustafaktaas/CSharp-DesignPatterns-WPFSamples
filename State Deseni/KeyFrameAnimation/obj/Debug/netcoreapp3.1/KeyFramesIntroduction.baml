   M S B A M L   `   `   `  ????  KeyFrameAnimation-    'KeyFrameAnimation.KeyFramesIntroduction   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      -   5          N? WindowTitle$  KeyFrame Animations??5      .??5	      ??  ?? Orientation$ Vertical=?6   $??Stretch=?6(   .+?5   
   ?? -   5         ??Name$ textYazi??5      $??20q?6&   $
??Wrap=?62   ??Key frame animations enable you to create complex animations by specifying multiple destination values and controlling the animation's interpolation method.5      ?? 5   
   
???   ?$??1q?6%   $??Center=?69   $??20q?6V   ._?5      ?? -   5        $	??600??5      $	??300??6!   
???????.+?5      ?? -   5        $??myImage??5   1   $	??600??6   $	??300??6$      MyDrawingImageResource#??[  5      ?? 5      -   5        $??myRectangle??5      
 ?? Top$	 100??5       ?? Left$ 10??5      $	??100??5      $	??100??5      
???   ?$??5??5      ??5       L? 5!       L? Drawing 5"      I? 5#   "   ??5%   *   ?  ? Brush ?#3333FF ? Geometry 5&   .   ?? 5'   2    ?? Rect$ 0,0,100,100?6D   5)   +   ? 5*   *    5+   .   ?? 5,   2   $ 0,0,100,100?6D    5.   .   !? 5/   2   -   5        myVisualBrush??	 j? ViewboxUnits$	 Absolute=?5/   U   
 ?? 	Transform
 50   6   ?? 51   :    ?? ScaleX$	 1.5Q?6I    ?? ScaleY$	 1.5Q?6V    ?? CenterX$	 0.5Q?6c    ?? CenterY$	 0.5Q?6q   53   3   55   +   57   #   59       ? Triggers 5<      :? 5=       :? RoutedEvent$ Rectangle.Loaded??6'   .[?5>      ?? .??5?   "   ??  g? RepeatBehavior$ Forever??6-   .??5@   &   U?  ?? 
TargetName$ myRectangle??5A       ?? TargetProperty$ (Canvas.Left)?5B      \?5E   .   ??  O? Value$	 500Q?6C    O? KeyTime$ 0:0:5??6O   ?? 5F   .    ?? 	KeySpline$ 0.25,0.5 0.75,1??6C   $	 200Q?6_   $ 0:0:10??6k   ?? 5G   .   $	 290Q?6C   $ 0:0:12??6O   ?? 5H   .   $	 300Q?6C   $ 0:0:13.5??6O   ?? 5I   .   $ 0.25,0.5 0.75,1??6C   $ 0Q?6_   $ 0:0:15??6i   5K   '   W? 5N   &   $ FirstLinearTextBlock??66   $ FontSize?6c    W? From 125O      	 W? To 166    g? Duration$ 0:0:0.2D?6%   W? 5P   &   $ FirstLinearTextBlock??66   $ FontSize?6c    165Q       126    g? 	BeginTime	 0:0:56%   $ 0:0:0.2D?67   W? 5T   &   $ FirstSplineTextBlock??66   $ FontSize?6c    125U       166   	 0:0:56%   $ 0:0:0.2D?67   W? 5V   &   $ FirstSplineTextBlock??66   $ FontSize?6c    165W       126   
 0:0:106%   $ 0:0:0.2D?68   W? 5Z   &   $ SecondLinearTextBlock??66   $ FontSize?6d    125[       166   
 0:0:106%   $ 0:0:0.2D?68   W? 5\   &   $ SecondLinearTextBlock??66   $ FontSize?6d    165]       126   
 0:0:126%   $ 0:0:0.2D?68   W? 5`   &   $ ThirdLinearTextBlock??66   $ FontSize?6c    125a       166   
 0:0:126%   $ 0:0:0.2D?68   W? 5b   &   $ ThirdLinearTextBlock??66   $ FontSize?6c    165c       126    0:0:13.56%   $ 0:0:0.2D?6:   W? 5f   &   $ SecondSplineTextBlock??66   $ FontSize?6d    125g       166    0:0:13.56%   $ 0:0:0.2D?6:   W? 5h   &   $ SecondSplineTextBlock??66   $ FontSize?6d    165i       126   
 0:0:156%   $ 0:0:0.2D?68   5j   #   5k      5l       J? BitmapEffect 5o      F? 5p       F? ShadowDepth$ 5Q?61   5r      5s      5t      ?? 5u   
   -   5        $??Button??5u      6"   ?? 5w   
   2  ,System.Windows.Markup.XmlAttributeProperties  XmlSpace preserve6   ??
                    <DoubleAnimationUsingKeyFrames
                    Storyboard.TargetName="myRectangle"
                    Storyboard.TargetProperty="(Canvas.Left)">
                      <DoubleAnimationUsingKeyFrames.KeyFrames>
                        ?? 5|      -   5        $??FirstLinearTextBlock??5|   $   64<LinearDoubleKeyFrame Value="500" KeyTime="0:0:5" />6|   
                        ?? 5}      -	   5        $??FirstSplineTextBlock??5}   $   SQ<SplineDoubleKeyFrame KeySpline="0.25,0.5 0.75,1" Value="200" KeyTime="0:0:10" />6?   
                        ?? 5~      -
   5        $??SecondLinearTextBlock??5~   $   75<LinearDoubleKeyFrame Value="290" KeyTime="0:0:12" />6~   
                        ?? 5      -   5        $??ThirdLinearTextBlock??5   $   97<LinearDoubleKeyFrame Value="300" KeyTime="0:0:13.5" />6   
                        ?? 5?      -   5        $??SecondSplineTextBlock??5?   $   QO<SplineDoubleKeyFrame KeySpline="0.25,0.5 0.75,1" Value="0" KeyTime="0:0:15" />6?   }
                      </DoubleAnimationUsingKeyFrames.KeyFrames>
                    </DoubleAnimationUsingKeyFrames>
      5?   	   5?      5?      