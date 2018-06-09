using Prism.Navigation;
using Xamarin.Forms;

namespace GroupingListView.Views
{
    public partial class NavegacaoPage : NavigationPage, INavigationPageOptions, IDestructible
    {
        public NavegacaoPage()
        {
            InitializeComponent();
        }
        public bool ClearNavigationStackOnNavigation => true;
        public void Destroy()
        {
        }
    }
}
