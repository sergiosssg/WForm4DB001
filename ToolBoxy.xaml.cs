﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace WForm001
{
    /// <summary>
    /// Логика взаимодействия для ToolBoxy.xaml
    /// </summary>
    public partial class ToolBoxy : UserControl
    {
        public ToolBoxy()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            DbContext dbContext = MainWindow.DBContextProperty;

        }
    }
}
