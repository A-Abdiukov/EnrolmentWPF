﻿using BusinessLayer;
using System;
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
using System.Windows.Shapes;

namespace UI.Student
{
    /// <summary>
    /// Interaction logic for StudentEnrolment.xaml
    /// </summary>
    public partial class StudentEnrolment : Window
    {
        public StudentEnrolment()
        {
            InitializeComponent();
            Breadcrumbs brdcrumb_tracker = new Breadcrumbs(this.GetType().Name);
            dgBreadcrmbs.ItemsSource = brdcrumb_tracker.GetListOfPagesVisited();
        }

        //go back
        private void goBack_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            StudentProfile pageobj = new StudentProfile();
            pageobj.Show();
            Close();
        }
    }
}
