﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmpTrack.Views.News
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewsPage : TabbedPage
    {
        public NewsPage()
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