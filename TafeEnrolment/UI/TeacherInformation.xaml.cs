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
using UI.Teacher;

namespace UI
{
    /// <summary>
    /// Interaction logic for TeacherInformation.xaml
    /// </summary>
    public partial class TeacherInformation : Window
    {
        private Breadcrumbs brdcrumb_tracker;
        public TeacherInformation()
        {
            InitializeComponent();
            brdcrumb_tracker = new Breadcrumbs(this.GetType().Name);

            dgBreadcrmbs.ItemsSource = brdcrumb_tracker.GetListOfPagesVisited();

        }


        //back button
        private void goBack_navigation_btn_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.Navigate("MainWindow");
            Hide();
        }


        //logic
        private void SearchTextbox_MouseClick(object sender, MouseButtonEventArgs e)
        {
            if (SearchTextbox.Text == "Enter keywords by which criteria to search")
            {
                SearchTextbox.Text = "";
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            //logic to update the datagrid for a specific teacher
            SearchDataGrid(SearchTextbox.Text);

            //below is placeholder code for testing
            PageNavigation.Navigate("TeacherProfile");
            Hide();
        }

        private void BtnSelect_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.Navigate("TeacherProfile");
            Hide();
        }


        private void SearchDataGrid(string searchInput)
        {
            searchInput = searchInput == "Enter keywords by which criteria to search" ? "" : searchInput;

            if (checkbox_SearchPartTime.IsChecked == true)
            {
                if (checkbox_SearchTeacherNotBasedLocation.IsChecked == true)
                {
                    MessageBox.Show("Show part time teachers who are not teaching at their base location " + searchInput);
                }
                else
                {
                    MessageBox.Show("Show part time teachers " + searchInput);
                }
            }
            else if (checkbox_SearchFullTime.IsChecked == true)
            {
                if (checkbox_SearchTeacherNotBasedLocation.IsChecked == true)
                {
                    MessageBox.Show("Show full time teachers who are not teaching at their base location " + searchInput);
                }
                else
                {
                    MessageBox.Show("Show full time teachers " + searchInput);
                }
            }
            else if (checkbox_SearchTeacherNotBasedLocation.IsChecked == true)
            {
                MessageBox.Show("Show all teachers who are not teaching at their base location " + searchInput);
            }
            else
            {
                MessageBox.Show("Search everyone " + searchInput);
            }
        }

        private void checkbox_SearchPartTime_Checked(object sender, RoutedEventArgs e)
        {
            checkbox_SearchFullTime.IsChecked = false;
        }

        private void checkbox_SearchFullTime_Checked(object sender, RoutedEventArgs e)
        {
            checkbox_SearchPartTime.IsChecked = false;
        }

        private void Btn_CourseHistory_Click(object sender, RoutedEventArgs e)
        {
            PageNavigation.Navigate("TeacherCourseHistory");
            Hide();
        }

        private void dgTeacherProfiles_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Upon right clicking, there should be datagrid settings displayed to user");
        }

        private void dgBreadcrmbs_NavigateToSelectedPage(object sender, DataGridPreparingCellForEditEventArgs e)
        {
            string selected_page = dgBreadcrmbs.SelectedItem.ToString();

            //if the current page is NOT the page the user has clicked on
            if (selected_page != this.GetType().Name)
            {
                PageNavigation.Navigate(selected_page);
                Hide();
            }
            dgBreadcrmbs.CancelEdit();
        }

    }
}
