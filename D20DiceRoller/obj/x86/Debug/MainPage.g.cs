﻿#pragma checksum "C:\Users\Steve\Desktop\d20DiceRoller\D20DiceRoller\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "022503640C1D40E34BFE15F4B448CEAA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace D20DiceRoller
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.navSplitViewPanel = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 38 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.iconsListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 49 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.iconsListBox).SelectionChanged += this.iconsListBox_SelectionChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.D20 = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5:
                {
                    this.DiceBag = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6:
                {
                    this.Complex = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 7:
                {
                    this.Character = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 8:
                {
                    this.Settings = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 9:
                {
                    this.mainFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

