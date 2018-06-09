using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace GroupingListView.ViewModels
{
	public class CPageViewModel : ViewModelBase
    {
        public CPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Página C";
        }
    }
}
