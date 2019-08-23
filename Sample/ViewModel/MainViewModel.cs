using MvvmExtension;
using Sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sample.ViewModel
{
    public class MainViewModel : BindingBase
    {
        public UserModel User { set; get; } = new UserModel();
        public Notification<bool, string> ShowMessageBox { set; get; }
        public Notification<string> ChangePage { set; get; }
        public string CurrentPage { set; get; }
        public void UpdateName(string pageName)
        {
            var result = ShowMessageBox("是否切换页面");
            if (!result) return;
            ChangePage(pageName);
        }
    }
}
