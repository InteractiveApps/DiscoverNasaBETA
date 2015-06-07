using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DiscoverNasaBETA.Caching_Test
{
    public class VM : INotifyPropertyChanged
    {

        public List<item> items
        {
            get { return items; }
            set
            {
                items=value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("PersonName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event 
        protected void OnPropertyChanged( string name )
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler!=null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }

    public class item
    {
        public int index { get; set; }
        public int count { get; set; }
    }

}
