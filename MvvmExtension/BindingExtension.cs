using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvvmExtension
{
    public static class BindingExtension
    {
        public static void Binding(
            this Control control,
            string propertyName,
            object dataSource,
            string dataMember,
            bool formattingEnabled = false,
            string formatString = null,
            object nullValue = null,
            DataSourceUpdateMode dataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged)
        {
            if (control == null
                || propertyName == null
                || dataSource == null
                || dataMember == null)
                throw new NullReferenceException();
            else
            {
                Binding binding = new Binding(propertyName, dataSource, dataMember,
                    formattingEnabled: formattingEnabled,
                    formatString: formatString,
                    nullValue: nullValue,
                    dataSourceUpdateMode: dataSourceUpdateMode);
                control.DataBindings.Add(binding);
            }
        }
        public static void Binding(this Control control, Binding binding)
        {
            if (control == null || binding == null)
                throw new NullReferenceException();
            else
                control.DataBindings.Add(binding);
        }
    }
}
