﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeePointPlayerView : ContentPage
    {
        public SeePointPlayerView()
        {
            InitializeComponent();
            contentPage.BackgroundColor = (Color)new ColorTypeConverter().ConvertFromInvariantString(Constants.PRIMARY_COLOR);
        }
    }
}