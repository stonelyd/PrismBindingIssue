using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;



namespace PrismBindingIssue.Models
{
    class House : BindableBase 
    {

        private string _age;
        private string _type;

        public string Age
        {
            get { return _age; }
            set { SetProperty(ref _age, value); }
        }

        public string Type
        {
            get { return _type; }
            set { SetProperty(ref _type, value); }
        }


    }
}
