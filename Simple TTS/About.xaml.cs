﻿#region

using System.Windows;

#endregion

namespace Simple_TTS
{
    /// <summary>
    ///     Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {
        public About()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}