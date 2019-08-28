using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MvvmExtension;

namespace Sample.View
{
    public partial class Page2View : UserControl
    {
        public object ViewModel { set; get; } = new ViewModel.Page2ViewModel();
        public Page2View()
        {
            InitializeComponent();
            label1.TwoWayBinding("Text", ViewModel, "PageName");
        }
    }
}
