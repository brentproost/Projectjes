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
    public partial class AddWeersomstandigheid : ChildWindow
    {
        public AddWeersomstandigheid()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            ServiceReference.ServiceClient client = new ServiceReference.ServiceClient();
            client.AddWeersomstandighedenAsync(txtOmsch.Text);
            client.AddWeersomstandighedenCompleted += client_AddWeersomstandighedenCompleted;
        }

        void client_AddWeersomstandighedenCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Weersomstandigheid toegevoegd");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

