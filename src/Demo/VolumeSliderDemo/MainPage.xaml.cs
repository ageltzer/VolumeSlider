﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VolumeSliderPlugin.DemoProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            regularSlider.ValueChanged += RegularSlider_ValueChanged;
            volumeSlider.VolumeChanged += (sender, e) => Console.WriteLine($"Native slider volumne at {e.NewValue}");
        }

        private void RegularSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            volumeSlider.Volume = regularSlider.Value / 100d;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}
