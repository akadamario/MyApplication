﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ffmpegGUI.Commands;
using ffmpegGUI.MVVM.ViewModel;

namespace ffmpegGUI.MVVM.View
{
    /// <summary>
    /// SettingView.xaml の相互作用ロジック
    /// </summary>
    public partial class SettingView : UserControl
    {
        AppSettingViewModel _app => (this.Resources["appSetting"] as AppSettingViewModel);

        public SettingView()
        {
            InitializeComponent();

            _app.Load();
        }
    }
}
