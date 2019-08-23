using MvvmExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.ViewModel
{
    public class Page2ViewModel:BindingBase
    {
        private string pageName;
        public string PageName { get => pageName; set => SetValue(ref pageName, value); }
        public Page2ViewModel()
        {
            PageName = "页面2";
        }
    }
}
