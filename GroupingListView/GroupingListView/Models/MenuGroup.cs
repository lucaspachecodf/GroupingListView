using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace GroupingListView.Models
{
    public class MenuGroup : ObservableCollection<Menu>
    {
        public string Titulo { get; set; }
        public ObservableCollection<Menu> Lista => this;
    }
}
