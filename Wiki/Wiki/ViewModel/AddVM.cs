using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wiki.Messages;
using Wiki.Services.Interfaces;
using Wiki.Model;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows;
using Wiki.Context;

namespace Wiki.ViewModel
{
    internal class AddVM : ViewModelBase
    {
        //private readonly IMessenger _messenger;
        private readonly ICheckService _checkService;

        private Country _country = new();
        public Country Country
        {
            get => _country;

            set
            {
                if (_country != value)
                {
                    Set(ref _country, value);
                }
            }
        }

        public AddVM(/*IMessenger messenger,*/ ICheckService checkService)
        {
            //_messenger = messenger;
            _checkService = checkService;

            //_messenger.Register<DataMessage>(this, messenger =>
            //{
            //    Data.Countries = messenger.Data as ObservableCollection<Country>;
            //});
        }

        public RelayCommand AddCommand
        {
            get => new(() =>
            {
                if (_checkService.CkeckCountryExist(Country.Name))
                {
                    if (Country.Name != null && 
                    Country.Year != null && 
                    Country.TypeOfBoard != null && 
                    Country.Map != null && 
                    Country.Population != null && 
                    Country.Area != null && 
                    Country.GDP != null && 
                    Country.Ruler != null && 
                    Country.Anthem != null)
                    {
                        WikiDbContext context = new();
                        List<Country> Countries = new List<Country>()
                        {
                            new Country() { Name = Country.Name, 
                                Year = Country.Year, 
                                TypeOfBoard = Country.TypeOfBoard, 
                                Map = Country.Map, 
                                Population = Country.Population, 
                                Area = Country.Area, 
                                GDP = Country.GDP, 
                                Ruler = Country.Ruler, 
                                Anthem = Country.Anthem }
                        };

                        context.Country.AddRange(Countries);
                        context.SaveChanges();

                        //Data.Countries.Add(Country);
                        MessageBox.Show($"{Country.Name} added", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }

                    else
                    {
                        MessageBox.Show("Enter the country info!", "Information", MessageBoxButton.OK, MessageBoxImage.Hand);
                    }
                }
            });
        }
    }
}
