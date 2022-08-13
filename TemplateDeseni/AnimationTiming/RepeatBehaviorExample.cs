// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows.Controls;

namespace AnimationTiming
{
    public partial class RepeatBehaviorExample : Page
    {
        private void TemplateButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            KöseYazýsý köseYazýsý = new KöseYazýsý();
            köseYazýsý.Uygula(templateTextBox);
        }

        private void TemplateButton1_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            DenemeYazýsý denemeYazýsý = new DenemeYazýsý();
            denemeYazýsý.Uygula(templateTextBox);
        }

        private void TemplateButton2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            SiirYazýsý siirYazýsý = new SiirYazýsý();
            siirYazýsý.Uygula(templateTextBox);
        }
    }
}