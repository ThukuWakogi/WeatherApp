﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPWeather.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPWeather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click_Async(object sender, RoutedEventArgs e)
        {
            var position = await LocationManager.GetPositionAsync();
            WeatherModel myWeather = await OpenWeatherMapProxy.GetWeatherAsync(position.Coordinate.Point.Position.Latitude, position.Coordinate.Point.Position.Longitude);
            ResultTextBlock.Text = $"{myWeather.Name} - {(int)myWeather.Main.Temp} - {myWeather.Weather[0].Description}";
            ResultImage.Source = new BitmapImage(new Uri(String.Format($"ms-appx:///Assets/Weather/{myWeather.Weather[0].Icon}.png")));
        }
    }
}
