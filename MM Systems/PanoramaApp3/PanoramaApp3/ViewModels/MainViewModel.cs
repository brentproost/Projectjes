using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;


namespace PanoramaApp3
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
            this.Date = new ObservableCollection<DateViewModel>();
        }

        /// <summary>
        /// A collection for ItemViewModel objects.
        /// </summary>
       public ObservableCollection<ItemViewModel> Items { get; private set; }
        public ObservableCollection<DateViewModel> Date { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates and adds a few ItemViewModel objects into the Items collection.
        /// </summary>
        public void LoadData()
        {
            // Sample data; replace with real data
            /*this.Items.Add(new ItemViewModel() { LineOne="Nieuwe invoer", LineTwo="Nieuwe data ingeven van een activiteit" });
            this.Items.Add(new ItemViewModel() { LineOne="Grafieken", LineTwo="Grafieken van vorige data bekijken" });
            this.Items.Add(new ItemViewModel() { LineOne="Instellingen", LineTwo="Log je uit of verander andere instellingen" });
            this.Date.Add(new DateViewModel()  { LineOne="Datum", LineTwo="Geef de datum in van de activiteit" });
            this.Date.Add(new DateViewModel() { LineOne="Uur", LineTwo="Geef het uur in waarop u de activiteit heeft gedaan" });*/
            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}