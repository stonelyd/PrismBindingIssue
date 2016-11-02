using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Windows.Mvvm;
using PrismBindingIssue.Models;
using System.Windows.Input;
using Prism.Windows.Navigation;
using Prism.Commands;


namespace PrismBindingIssue.ViewModels
{
    class HousePageViewModel : ViewModelBase
    {

        private INavigationService _navigationService;
        private House _h = new House();
        private  Person _per = new Person();

        public House Howse
        {
            get { return _h; }
            set { SetProperty(ref _h, value); }
        }

        private ICommand _navperson;

        public ICommand NavPerson
        {
            get { return _navperson; }
            set { _navperson = value; }
        }

        private string _dName;

        public string Name
        {
            get { return _dName; }
            set { SetProperty(ref _dName, value); }
        }

        private string _dage;

        public string Age
        {
            get { return _dage; }
            set { SetProperty(ref _dage, value); }
        }



        public  HousePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavPerson = new DelegateCommand(NavigateToPerson);
        }

        private void NavigateToPerson()
        {
            _navigationService.Navigate("Person", _h);
        }

        public override void OnNavigatedTo(NavigatedToEventArgs e, Dictionary<string, object> viewModelState)
        {
            base.OnNavigatedTo(e, viewModelState);

            _per =  (Person)e.Parameter;

            this.Age = "Age passed from Person Form:" + _per.Age;
            this.Name = "Name passed from Person Form:" + _per.Name;

        }

    }
}
