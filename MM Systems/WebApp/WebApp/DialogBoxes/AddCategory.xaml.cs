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
using WebApp.ServiceReference;

namespace WebApp.DialogBoxes
{
    public partial class AddCategory : ChildWindow
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            ServiceReference.ServiceClient client2 = new ServiceClient();
            client2.AddCategoryAsync(txtOmsch.Text);
            client2.AddCategoryCompleted += client_AddCategoryCompleted;
            client2.CloseAsync();
            /*ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();

            client.AddCategoryAsync(txtOmsch.Text);
            client.AddCategoryCompleted += client_AddCategoryCompleted;
            client.CloseAsync();*/
        }

        void client_AddCategoryCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Categorie toegevoegd");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

