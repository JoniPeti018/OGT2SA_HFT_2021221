﻿using Microsoft.Toolkit.Mvvm.Input;
using OGT2SA_HFT_2021221.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace OGT2SA_HFT_2021221.WPFClient
{
    public class MainWindowViewModel
    {
        public ICommand AnimeCommand { get; set; }
        public ICommand CharacterCommand { get; set; }
        public ICommand StudioCommand { get; set; }

        public static bool IsInDesignMode
        {
            get
            {
                var prop = DesignerProperties.IsInDesignModeProperty;
                return (bool)DependencyPropertyDescriptor.FromProperty(prop, typeof(FrameworkElement)).Metadata.DefaultValue;
            }
        }

        public MainWindowViewModel()
        {
            if (!IsInDesignMode)
            {
                AnimeCommand = new RelayCommand(() =>
                {
                    new AnimeWindow().ShowDialog();
                });
                CharacterCommand = new RelayCommand(() =>
                {
                    new CharacterWindow().ShowDialog();
                });
                StudioCommand = new RelayCommand(() =>
                {
                    new StudioWindow().ShowDialog();
                });
            }
        }
    }
}
