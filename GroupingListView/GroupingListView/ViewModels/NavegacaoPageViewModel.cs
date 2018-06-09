using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupingListView.ViewModels
{
	public class NavegacaoPageViewModel : ViewModelBase
    {
        public NavegacaoPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
