using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App2.Interfaces;
using Xamarin.Forms;


namespace App2.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        private string entry_X;
        private string entry_Y;
        private string entry_Z;

        public ICommand Button_OnExecute { get; private set; }

        private readonly IPageService _pageService;
        public MainPageViewModel(IPageService pageService)
        {
            _pageService = pageService;
            Button_OnExecute = new Command(async () => { await Alert(); });
        }

        public string Entry_X
        {
            get => entry_X;
            set
            {
                if (entry_X != value) entry_X = value;
                else return;

                base.OnPropertyChanged();
                base.OnPropertyChanged(nameof(Label_Output));
            }
        }

        public string Entry_Y
        {
            get => entry_Y;
            set
            {
                if (entry_Y != value) entry_Y = value;
                else return;

                base.OnPropertyChanged();
                base.OnPropertyChanged(nameof(Label_Output));
            }
        }

        public string Entry_Z
        {
            get => entry_Z;
            set
            {
                if (entry_Z != value) entry_Z = value;
                else return;

                base.OnPropertyChanged();
                base.OnPropertyChanged(nameof(Label_Output));
            }
        }

        private string label_Output;
        public string Label_Output
        {
            get { return Calculate(); }
            set
            {
                if (label_Output != value) label_Output = value;
                else return;

                base.OnPropertyChanged();
            }
        }
       
        private string Calculate()
        {
            try
            {
                if (Entry_X != null && Entry_Y != null && Entry_Z != null)
                {
                    var diag1 = Math.Sqrt(Math.Pow(int.Parse(Entry_X), 2) + Math.Pow(int.Parse(Entry_Y), 2));
                    var result = Math.Sqrt(Math.Pow(diag1, 2) + Math.Pow(int.Parse(Entry_Z), 2));
                    return result.ToString();
                }
                else return "Something went wrong";
            }
            catch (Exception e1)
            {
                _pageService.DisplayAlert("Exception", e1.ToString(), "ok");       
                throw;
            }
        }

        private async Task Alert()
        {
            await _pageService.DisplayAlert("Test", "this is a display alert from the View Model", "ok");
            
        }

    }
}
