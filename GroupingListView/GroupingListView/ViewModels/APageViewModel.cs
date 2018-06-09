using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupingListView.ViewModels
{
	public class APageViewModel : ViewModelBase
    {
        public APageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Página A";
        }
    }
}
