using MvvmExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.ViewModel
{
    public class Page1ViewModel:BindingBase
    {
        private string pageName;

        public string PageName { get => pageName; set => SetValue(ref pageName, value); }
        public Page1ViewModel()
        {
            PageName = "页面1";
        }
    }
}
