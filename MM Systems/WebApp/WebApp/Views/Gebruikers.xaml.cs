using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;
using System.ComponentModel;
using System.IO;
using Microsoft.CSharp;
using WebApp.DialogBoxes.FolderDialog;

namespace WebApp.Views
{
    public partial class Gebruikers : Page
    {
        FolderDialog fd = new FolderDialog();
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
        DataGrid multiexport = new DataGrid();
        public Gebruikers()
        {
            InitializeComponent();
            UpdateDataGrid();
        }

        void UpdateDataGrid()
        {
            gridd.ItemsSource = null;
            client.GetAllUsersAsync();
            client.GetAllUsersCompleted += client_GetAllUsersCompleted;
        }


        void client_GetAllUsersCompleted(object sender, ServiceReference.GetAllUsersCompletedEventArgs e)
        {
             gridd.ItemsSource = e.Result.ToList();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult msbResult = MessageBox.Show("De ingaven van deze gebruiker worden ook verwijderd! Weet u zeker dat u deze gebruiker wilt verwijderen?", "Verwijder", MessageBoxButton.OKCancel);
            if (msbResult == MessageBoxResult.OK)
            {
                client.DeleteUserAsync((Convert.ToInt32((((Image)sender).Tag).ToString())));
                client.DeleteUserCompleted += client_DeleteUserCompleted;
            }
        }

        void client_DeleteUserCompleted(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("gebruiker verwijderd");
            UpdateDataGrid();
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            Public_Informatie_Gebruiker.id = Convert.ToInt32((((HyperlinkButton)sender)).Tag);
        }

        private void btn_export_Click(object sender, RoutedEventArgs e)
        {
            Export export = new Export(gridd);
        }

        private void btn_exportall_Click(object sender, RoutedEventArgs e)
        {
            fd.Show();
            fd.Closed+=fd_Closed;
        }

        void fd_Closed(object sender, EventArgs e)
        {
            Tb_dir.Text = fd.SelectedFolderPath;
        }
    }
}
