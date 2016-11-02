using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Windows.Validation;
using System.ComponentModel.DataAnnotations;


namespace PrismBindingIssue.Models
{
    class Person : ValidatableBindableBase
    {
        private string _name;
        private string _age;

        [Required( ErrorMessage = "Value Required")]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        public string Age
        {
            get { return _age; }
            set { SetProperty(ref _age,  value); }
        }

    }
}
