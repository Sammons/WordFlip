﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WordFlip.Common;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace WordFlip
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class ResultPage : WordFlip.Common.LayoutAwarePage
    {
        public ResultPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="navigationParameter">The parameter value passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested.
        /// </param>
        /// <param name="pageState">A dictionary of state preserved by this page during an earlier
        /// session.  This will be null the first time a page is visited.</param>
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            var words = ((List<string>)navigationParameter).ToArray();
            Array.Resize(ref words,5);
            const string none = "";
            if (words[0] != null) LeftText1.Text = RightText1.Text = "1 "+words[0];
            else LeftText1.Text = RightText1.Text = none;
            if (words[1] != null) LeftText2.Text = RightText2.Text = "2 "+words[1];
            else LeftText2.Text = RightText2.Text = none;
            if (words[2] != null) LeftText3.Text = RightText3.Text = "3 "+words[2];
            else LeftText3.Text = RightText3.Text = none;
            if (words[3] != null) LeftText4.Text = RightText4.Text = "4 "+words[3];
            else LeftText4.Text = RightText4.Text = none;
            if (words[4] != null) LeftText5.Text = RightText5.Text = "5 "+words[4];
            else LeftText5.Text = RightText5.Text = none;
            if (words[0] == null)
            {
                LeftText1.Text =
                    RightText1.Text =
                    LeftText2.Text =
                    RightText2.Text =
                    LeftText3.Text =
                    RightText3.Text =
                    LeftText4.Text = 
                    RightText4.Text = 
                    LeftText5.Text = 
                    RightText5.Text = "Nothing found";
            }

        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="pageState">An empty dictionary to be populated with serializable state.</param>
        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }
    }
}
