// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Windows;

namespace FontDialog
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnFontButtonClick(object sender, RoutedEventArgs e)
        {
            ShowFontDialog();
        }

        private void ShowFontDialog()
        {
            var fontChooser = new FontChooser {Owner = this};

            fontChooser.SetPropertiesFromObject(textBox);
            fontChooser.PreviewSampleText = textBox.SelectedText;

            var showDialog = fontChooser.ShowDialog();
            if (showDialog != null && showDialog.Value)
            {
                fontChooser.ApplyPropertiesToObject(textBox);
            }
        }

        private void textBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var secimFactory = new SecimFactory();  

            ISecim secilenFontTipi = secimFactory.SecimYap(Secilen.MyFont);
            secilenFontTipi.Degistir(textBox);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var secimFactory = new SecimFactory();

            ISecim secilenFontBoyutu = secimFactory.SecimYap(Secilen.MyFontSize);
            secilenFontBoyutu.Degistir(textBox);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var secimFactory = new SecimFactory();

            ISecim secilenRenk = secimFactory.SecimYap(Secilen.Renk);
            secilenRenk.Degistir(textBox);
        }
    }
}