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
            MainVM.User.Id = DateTime.Now.ToString();
            //textBox1.Binding("Text", this.MainVM, "User.Name");
            MainVM.ShowMessageBox = new Notification<bool, string>(this.showMessageBox);
            MainVM.ChangePage = new Notification<string>(this.ChangePage);
        }
        private void ChangePage(string pageName)
        {
            this.panel1.Controls.Clear();
            Control control=null;
            switch (pageName)
            {
                case "Page1":
                    control = new Page1View() { Dock=DockStyle.Fill};
                    break;
                case "Page2":
                    control = new Page2View() { Dock = DockStyle.Fill };
                    break;
                default:
                    break;
            }
            this.panel1.Controls.Add(control);
        }
        private bool showMessageBox(string str)
        {
            DialogResult result = MessageBox.Show(str, "消息", MessageBoxButtons.OKCancel);
            return result == DialogResult.OK ? true : false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainVM.UpdateName((sender as Button).Name);
        }
    }
}
