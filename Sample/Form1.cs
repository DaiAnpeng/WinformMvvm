using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var v= this.IsHandleCreated;
            if (IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {

                }));
            }
            this.panel1.Controls.Add(new View.MainView());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (IsHandleCreated)
            {
                this.Invoke(new Action(() =>
                {

                }));
            }
        }
    }
}
