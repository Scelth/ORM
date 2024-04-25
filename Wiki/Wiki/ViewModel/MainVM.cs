using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiki.Messages;
using Wiki.Services.Interfaces;
using GalaSoft.MvvmLight.Command;

namespace Wiki.ViewModel
{
    internal class MainVM : ViewModelBase
    {
        private ViewModelBase selectedPage;
        private readonly IMessenger _messenger;
        private readonly INavigateService _navigateService;

        public ViewModelBase CurrentViewModel
        {
            get => selectedPage;
            set
            {
                Set(ref selectedPage, value);
            }
        }

        public void ReceiveMessage(NavigationMessage message)
        {
            CurrentViewModel = App.Container.GetInstance(message.VMType) as ViewModelBase;
        }

        public MainVM(IMessenger messenger, INavigateService navigateService)
        {
            _messenger = messenger;
            _navigateService = navigateService;
            _messenger.Register<NavigationMessage>(this, ReceiveMessage);
        }

        public RelayCommand AddCommand
        {
            get => new(() =>
            {
                _navigateService.NavigateTo<AddVM>();
            });
        }

        public RelayCommand ListCommand
        {
            get => new(() =>
            {
                _navigateService.NavigateTo<ListVM>();
            });
        }
    }
}
