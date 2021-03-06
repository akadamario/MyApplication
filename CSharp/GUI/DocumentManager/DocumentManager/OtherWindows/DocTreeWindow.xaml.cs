﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;
using DocumentManager.DataSource;

namespace DocumentManager.OtherWindows
{
    /// <summary>
    /// DocTreeWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class DocTreeWindow : Window
    {
        public Document SelectedDocument { get; private set; }
        public ObservableCollection<Document> DisplayChapters { get; private set; }

        public DocTreeWindow()
        {
            InitializeComponent();

            //SelectedDocument = new Document();
            //DisplayChapters = new ObservableCollection<Document>();
            //DisplayChapters.Add(SelectedDocument);
            //DocTreeView.ItemsSource = DisplayChapters;
        }

        private void addChapter_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
