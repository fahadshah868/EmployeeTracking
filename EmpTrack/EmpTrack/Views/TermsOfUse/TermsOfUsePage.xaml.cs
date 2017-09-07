using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpTrack.Views.TermsOfUse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TermsOfUsePage : TabbedPage
    {
        public TermsOfUsePage()
        {
            InitializeComponent();
            Title = CurrentPage.Title;
            this.CurrentPageChanged += CurrentPageHasChanged;
        }
        private void CurrentPageHasChanged(object sender, EventArgs e)
        {
            this.Title = this.CurrentPage.Title;
        }
    }
}