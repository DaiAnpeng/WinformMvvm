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
        public DateTime currentTime;
        public DateTime CurrentTime { get => currentTime; set => SetValue(ref currentTime, value); }
        public Page1ViewModel()
        {
            PageName = "页面1";
            Task.Run(() =>
            {
                while (true)
                {
                    CurrentTime = DateTime.Now;
                    System.Threading.Thread.Sleep(100);
                }
            });
        }
    }
}
