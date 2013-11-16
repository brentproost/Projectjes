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
using System.IO;

namespace WebApp.Views
{
    public partial class Resultaten : Page
    {
        ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
        public Resultaten()
        {
            InitializeComponent();
            txtid.Text = Public_Informatie_Gebruiker.id.ToString();
            UpdateUserInfo();
        }

        void client_GetUserCompleted(object sender, ServiceReference.GetUserCompletedEventArgs e)
        {
            Public_Informatie_Gebruiker.Voornaam = e.Result[0].Voornaam.Replace(" ", string.Empty);
            Public_Informatie_Gebruiker.Naam = e.Result[0].Naam.Replace(" ", string.Empty);

            if (Public_Informatie_Gebruiker.Voornaam != null && Public_Informatie_Gebruiker.Naam != null)
            {
                txt_Naam_Voornaam.Text = "Informatie over: " + Public_Informatie_Gebruiker.Voornaam.ToString() + " " + Public_Informatie_Gebruiker.Naam.ToString();
            }
        }

        void client_GetIngave_GebruikerCompleted(object sender, ServiceReference.GetIngave_GebruikerCompletedEventArgs e)
        {
            dg_Ingaven.ItemsSource = null;
            dg_Ingaven.ItemsSource = e.Result.ToList();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        void UpdateUserInfo()
        {
            client.GetIngave_GebruikerAsync(Convert.ToInt16(txtid.Text));
            client.GetIngave_GebruikerCompleted += client_GetIngave_GebruikerCompleted;
            client.GetUserAsync(Convert.ToInt16(txtid.Text));
            client.GetUserCompleted += client_GetUserCompleted;
        }

        private void btn_ChangeUser_Click(object sender, RoutedEventArgs e)
        {
            UpdateUserInfo();
        }

        private void btn_export_Click(object sender, RoutedEventArgs e)
        {
            string data = ExportDataGrid(dg_Ingaven);
            SaveFileDialog sfd = new SaveFileDialog()
            {
                DefaultExt = "csv",
                Filter = "CSV Files (*.csv)|*.csv|All files (*.*)|*.*",
                FilterIndex = 1
            };
            if (sfd.ShowDialog() == true)
            {
                using (Stream stream = sfd.OpenFile())
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.Write(data);
                        writer.Close();
                    }
                    stream.Close();
                }
            }
        }

        public String ExportDataGrid(DataGrid grid)
        {
            string colPath;
            System.Reflection.PropertyInfo propInfo;
            System.Windows.Data.Binding binding;
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
            System.Collections.IList source = (grid.ItemsSource as System.Collections.IList);
            if (source == null)
                return "";

            for (int i = 0; i < grid.Columns.Count; i++)
            {
                strBuilder.Append(grid.Columns[i].Header.ToString());
                strBuilder.Append(";");
            }

            strBuilder.Append("\r\n");

            foreach (Object data in source)
            {
                foreach (DataGridColumn col in grid.Columns)
                {
                    if (col is DataGridBoundColumn)
                    {
                        binding = (col as DataGridBoundColumn).Binding;
                        colPath = binding.Path.Path;
                        propInfo = data.GetType().GetProperty(colPath);
                        if (propInfo != null)
                        {
                            strBuilder.Append(propInfo.GetValue(data, null).ToString());
                            strBuilder.Append(";");
                        }
                    }
                }
                strBuilder.Append("\r\n");
            }
            return strBuilder.ToString().Replace(" ", string.Empty);
        }
    }
}


