﻿using LabPW1.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace LabPW1
{
    /// <summary>
    /// Логика взаимодействия для Zhanre.xaml
    /// </summary>
    public partial class Zhanre : Page
    {
        ZhanresTableAdapter zhanres = new ZhanresTableAdapter();
        public Zhanre()
        {
            InitializeComponent();
            dg_BD.ItemsSource = zhanres.GetData();
        }
    }
}
