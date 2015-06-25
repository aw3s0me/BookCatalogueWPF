﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using BookCatalogueWPF.Client.ViewModel;

namespace BookCatalogueWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private void OnStartUp(object sender, StartupEventArgs e)
        {
            AutoMapperConfiguration.Install();
        }
    }
}
