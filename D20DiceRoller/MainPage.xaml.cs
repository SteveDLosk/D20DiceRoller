﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace D20DiceRoller
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            mainFrame.Navigate(typeof(StartPage));
        }

        private void iconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (D20.IsSelected)
                mainFrame.Navigate(typeof(d20));
            else if (DiceBag.IsSelected)
                mainFrame.Navigate(typeof(diceBag));
            else if (Complex.IsSelected)
                mainFrame.Navigate(typeof(Complex));
            else if (Character.IsSelected)
                mainFrame.Navigate(typeof(Character));
            else if (Settings.IsSelected)
                mainFrame.Navigate(typeof(Settings));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            navSplitViewPanel.IsPaneOpen = !navSplitViewPanel.IsPaneOpen;
        }
    }
}
