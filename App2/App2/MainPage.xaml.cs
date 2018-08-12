using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App2.Services;
using App2.ViewModels;
using Xamarin.Forms;

namespace App2
{
	public partial class MainPage : ContentPage
	{   
		public MainPage()
		{

			InitializeComponent();
            PageService pageService = new PageService(this);
		    BindingContext = new MainPageViewModel(pageService);
		}

	}
}
