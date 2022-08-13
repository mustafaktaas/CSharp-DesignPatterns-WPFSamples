// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows.Controls;

namespace AnimationTiming
{
    public partial class RepeatBehaviorExample : Page
    {
        private void TemplateButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            K�seYaz�s� k�seYaz�s� = new K�seYaz�s�();
            k�seYaz�s�.Uygula(templateTextBox);
        }

        private void TemplateButton1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DenemeYaz�s� denemeYaz�s� = new DenemeYaz�s�();
            denemeYaz�s�.Uygula(templateTextBox);
        }

        private void TemplateButton2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SiirYaz�s� siirYaz�s� = new SiirYaz�s�();
            siirYaz�s�.Uygula(templateTextBox);
        }
    }
}