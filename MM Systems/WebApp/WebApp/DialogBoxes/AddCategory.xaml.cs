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
    public partial class AddCategory : ChildWindow
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();           
            client.AddCategoryCompleted += client_AddCategoryCompleted;
            client.AddCategoryAsync(txtOmschr.Text);  
        }

        void client_AddCategoryCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Categorie is toegevoegd");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

