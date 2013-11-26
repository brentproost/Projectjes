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
        List<string> bestandsnaam = new List<string>();
        List<int> gebruikersids = new List<int>();

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
            client.GetAllUsersAsync();
            client.GetAllUsersCompleted+=client_GetAllUsersCompletedids;
        }

        void client_GetAllUsersCompletedids(object sender, ServiceReference.GetAllUsersCompletedEventArgs e)
        {
            foreach (var item in e.Result)
            {
                gebruikersids.Add(item.Id);
                bestandsnaam.Add(item.Naam.Replace(" ", "") + "_" + item.Voornaam.Replace(" ", "") + "_" + DateTime.Now.Date.ToString("MMMM-dd-yyyy")+".csv");
            }
            client.GetIngave_GebruikerAsync();
            client.GetIngave_GebruikerCompleted += client_GetIngave_GebruikerCompleted;
        }

        void client_GetIngave_GebruikerCompleted(object sender, ServiceReference.GetIngave_GebruikerCompletedEventArgs e)
        {
            int count = 0;
            foreach (var item in gebruikersids)
            {
                var list = from i in e.Result where i.User_ID == item select i;
                inv_datagrid.ItemsSource = list.ToList();
                Export ex = new Export(inv_datagrid, fd.SelectedFolderPath, bestandsnaam[count]);
                count ++;
            }
        }

        private void btn_export_allin_one_file_Click(object sender, RoutedEventArgs e)
        {
            client.GetIngave_GebruikerAsync();
            client.GetIngave_GebruikerCompleted += client_GetIngave_GebruikerCompletedonefile;
        }

        void client_GetIngave_GebruikerCompletedonefile(object sender, ServiceReference.GetIngave_GebruikerCompletedEventArgs e)
        { 
            inv_datagrid.ItemsSource = e.Result.ToList();
            Export exportallonefile = new Export(inv_datagrid);
        }
    }
}
