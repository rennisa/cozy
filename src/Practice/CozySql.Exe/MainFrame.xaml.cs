﻿using MahApps.Metro.Controls;
using System;
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

namespace CozySql.Exe
{
    /// <summary>
    /// Interaction logic for MainFrame.xaml
    /// </summary>
    public partial class MainFrame : MetroWindow
    {
        public class UIControlInfo
        {
            public string Title { get; set; }
            public UserControl Content { get; set; }
        }

        public MainFrame()
        {
            InitializeComponent();

            this.DataContext = this;
            _MainTabItems.Add(new UIControlInfo { Title = "Welcome!", Content = new UserControls.WelcomePage() });
            _MainTabItems.Add(new UIControlInfo { Title = "SqlView1", Content = new UserControls.SqlView() });
            _MainTabItems.Add(new UIControlInfo { Title = "SqlView2", Content = new UserControls.SqlView() });
            _MainTabItems.Add(new UIControlInfo { Title = "SqlView3", Content = new UserControls.SqlView() });
        }

        private ObservableCollection<UIControlInfo> _MainTabItems = new ObservableCollection<UIControlInfo>();
        public IEnumerable<UIControlInfo> MainTabItems
        {
            get
            {
                return _MainTabItems;
            }
        }
    }
}