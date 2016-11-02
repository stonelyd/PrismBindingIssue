using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrismBindingIssue.Models;
using Prism.Windows.Mvvm;
using System.Windows.Input;
using Prism.Windows.Navigation;
using Prism.Commands;



namespace PrismBindingIssue.ViewModels
{
    class PersonPageViewModel : ViewModelBase
    {

        private INavigationService _navigationService;
        private House _hos = new House();
        private Person _person = new Person();

        public Person Purson
        {
            get { return _person; }
            set { SetProperty(ref _person, value); }
        }

        private ICommand _navHouse;

        public ICommand NavHouse
        {
            get { return _navHouse; }
            set { _navHouse = value; }
        }

        private string _htype;

        public string Type
        {
            get { return _htype; }
            set { SetProperty(ref _htype, value); }
        }

        private string _hage;

        public string Age
        {
            get { return _hage; }
            set { SetProperty(ref _hage,value); }
        }




        public PersonPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavHouse = new DelegateCommand(NavigateToPerson);
        }

        private void NavigateToPerson()
        {
            if (_person.ValidateProperties()) { 
                _navigationService.Navigate("House", _person);
            }
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);

            _hos = (House)e.Parameter;

            if (_hos != null) { 
            this.Age = "Age passed from House Form:" + _hos.Age;
            this.Type = "Type passed from House Form:" + _hos.Type;
            }
        }


    }
}
