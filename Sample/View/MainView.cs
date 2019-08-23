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
    public partial class MainView : UserControl
    {
        public ViewModel.MainViewModel MainVM { set; get; } = new ViewModel.MainViewModel();
        public MainView()
        {
            InitializeComponent();
            textBox1.Binding("Text", this.MainVM, "User.Name");
            MainVM.ShowMessageBox = new Notification<bool, string>(this.showMessageBox);
        }
        private bool showMessageBox(string str)
        {
            DialogResult result = MessageBox.Show(str, "消息", MessageBoxButtons.OKCancel);
            return result == DialogResult.OK ? true : false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainVM.UpdateName();
        }
    }
}
