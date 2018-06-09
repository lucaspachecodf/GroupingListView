using Prism.Navigation;
using Xamarin.Forms;

namespace GroupingListView.Views
{
    public partial class MasterPage : MasterDetailPage, IMasterDetailPageOptions
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        public bool IsPresentedAfterNavigation => Device.Idiom != TargetIdiom.Phone;
    }
}