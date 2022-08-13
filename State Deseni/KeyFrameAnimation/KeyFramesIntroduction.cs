// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Windows;
using System.Windows.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Collections;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing.Design;
using System.Drawing;

namespace KeyFrameAnimation
{
    public partial class KeyFramesIntroduction : Page
    {
        public void PageLoaded(object sender, RoutedEventArgs args)
        {
            myVisualBrush.Visual = myImage;
        }

        private void ExampleCanvasLayoutUpdated(object sender, EventArgs args)
        {
            myVisualBrush.Viewbox =
                new Rect(
                    Canvas.GetLeft(myRectangle),
                    Canvas.GetTop(myRectangle),
                    myRectangle.ActualWidth,
                    myRectangle.ActualHeight
                    );
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();

            /*student.centuryGothic1(textYazi);
            student.franklinGothic1(textYazi);
            student.elephantGothic1(textYazi);
            student.harlowSolid1(textYazi);*/

            /* student.setState(new Elephant(student));
             student.centuryGothic1(textYazi);
             student.franklinGothic1(textYazi);
             student.elephantGothic1(textYazi);
             student.harlowSolid1(textYazi);*/

            student.setState(new Elephant(student));
            student.elephantGothic1(textYazi);

        }
    }
}