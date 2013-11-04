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

namespace WebApp.DialogBoxes
{
    public partial class AddActivity : ChildWindow
    {
        List<string> cbitems = new List<string>();
        List<int> cbtag = new List<int>();
        public AddActivity()
        {
            InitializeComponent();
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
            client.GetAllCategoriesAsync();
            client.GetAllCategoriesCompleted += client_GetAllCategoriesCompleted;
        }

        void client_GetAllCategoriesCompleted(object sender, ServiceReference.GetAllCategoriesCompletedEventArgs e)
        {
           

            for (int i = 0; i < e.Result.Count; i++)
            {
                cbitems.Add(e.Result[i].Omschrijving);
                cbtag.Add(e.Result[i].Id);
            }

            cb_Categorie.ItemsSource = cbitems;
        }


        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            int selected_id = cbtag[cb_Categorie.SelectedIndex];
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
            client.AddActivityCompleted += client_AddActivityCompleted;
            client.AddActivityAsync(txtOmschr.Text, selected_id);
        }

        void client_AddActivityCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("De activiteit is toegevoegd");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

