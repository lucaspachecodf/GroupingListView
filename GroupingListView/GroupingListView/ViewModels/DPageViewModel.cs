using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupingListView.ViewModels
{
	public class DPageViewModel : ViewModelBase
    {
        public DPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Página D";
        }
    }
}
