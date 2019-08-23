using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvvmExtension
{
    public abstract class BindingBase : INotifyPropertyChanged
    {
        protected void SetValue<T>(ref T target, T value,
            [CallerMemberName] string propertyName = null)
        {
            if ((target == null && value != null) || (target != null && !target.Equals(value)))
            {
                target = value;
                if (Application.OpenForms.Count == 0) return;
                Application.OpenForms[0]?.Invoke(new Action(() =>
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                }));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
