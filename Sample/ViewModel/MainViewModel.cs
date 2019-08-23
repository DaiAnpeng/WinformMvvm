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
        public void UpdateName()
        {
            var result = ShowMessageBox("ceshi");
            if (!result) return;
            new Thread(() => {
                User.Name = DateTime.Now.ToString("mmss");
            }).Start();
        }
    }
}
