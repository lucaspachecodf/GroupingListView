using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GroupingListView.Models;
using GroupingListView.Views;
using Prism.Navigation;

namespace GroupingListView.ViewModels
{
	public class MasterPageViewModel : ViewModelBase
    {
        public MasterPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new DelegateCommand<Menu>(Navegar);

            CarregarMenus();
        }

        private void Navegar(Menu menu)
        {
            _navigationService.NavigateAsync(menu.Navegacao);
        }

        private void CarregarMenus()
        {
            //=========================================================
            //TODO: Adiona a coleções de itens para o Menu
            //=========================================================
            var primeiroGrupo = new MenuGroup
            {
                new Menu
                {
                    Logo = "ic_menu",
                    Descricao = "Página A",
                    Navegacao = $"{nameof(NavegacaoPage)}/{nameof(APage)}"
                },
                new Menu
                {
                    Logo = "ic_menu",
                    Descricao = "Página B",
                    Navegacao = $"{nameof(NavegacaoPage)}/{nameof(BPage)}"
                }

            };
            //TODO: Titulo do Primeiro Grupo
            primeiroGrupo.Titulo = "Primeiro Grupo";

            //=========================================================
            //TODO: Adiona a coleções de itens para o Menu
            //=========================================================
            var segundoGrupo = new MenuGroup
            {
                new Menu
                {
                    Logo = "ic_menu",
                    Descricao = "Página C",
                    Navegacao = $"{nameof(NavegacaoPage)}/{nameof(CPage)}"
                },
                new Menu
                {
                    Logo = "ic_menu",
                    Descricao = "Página D",
                    Navegacao = $"{nameof(NavegacaoPage)}/{nameof(DPage)}"
                }
            };
            //TODO: Titulo do Segundo Grupo
            segundoGrupo.Titulo = "Segundo Grupo";


            //==================================================
            //TODO: Adionada a Coleção dos menus
            //==================================================
            var listMenu = new ObservableCollection<MenuGroup>
            {
                primeiroGrupo,
                segundoGrupo
            };


            ListaMenu = listMenu;
        }


        //TODO: <!--É preciso habilitar como 'TRUE' no listview a propriedade IsGroupingEnabled, para poder ativar o agrupamento -->
        private ObservableCollection<MenuGroup> _menus;
        public ObservableCollection<MenuGroup> ListaMenu
        {
            get => _menus;
            set => _menus = value;
        }
        public DelegateCommand<Menu> NavigateCommand { get; set; }

	    private readonly INavigationService _navigationService;
    }
}
