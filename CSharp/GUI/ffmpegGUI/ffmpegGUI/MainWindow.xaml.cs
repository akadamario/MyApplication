﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ffmpegGUI.MVVM.View;
using ffmpegGUI.MVVM.ViewModel;

namespace ffmpegGUI
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            var app = new AppSettingViewModel
            {
                StartTrimTime = 2,
                EndTrimTime = 4.5,
                CompressRate = 32,
                IsScaling = true,
                VerticalScale = 240,
                HorizontalScale = -1
            };
            app.Save();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var setting = new SettingView();
            var test = new Popup
            {
                StaysOpen = true,
                Child = setting
            };

            test.IsOpen = true;
        }
    }
}
