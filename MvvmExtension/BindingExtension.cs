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
        public static void TwoWayBinding(
           this Control control,
           string propertyName,
           object dataSource,
           string dataMember,
           bool formattingEnabled = false,
           string formatString = null,
           object nullValue = null,
           DataSourceUpdateTrigger trigger = DataSourceUpdateTrigger.OnValidation)
        {
            if (control == null
                || propertyName == null
                || dataSource == null
                || dataMember == null)
                throw new NullReferenceException();
            else
            {
                Binding binding = new Binding(propertyName, dataSource, dataMember);
                binding.FormattingEnabled = formattingEnabled;
                binding.FormatString = formatString;
                binding.NullValue = nullValue;
                if (trigger.Equals(DataSourceUpdateTrigger.OnLostFocus))
                {
                    binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    control.LostFocus += Control_LostFocus;
                }
                else
                    binding.DataSourceUpdateMode = (DataSourceUpdateMode)trigger;
                control.DataBindings.Add(binding);
            }
        }

        private static void Control_LostFocus(object sender, EventArgs e)
        {
            foreach (Binding v in (sender as Control).DataBindings)
            {
                v.WriteValue();
            }
        }

        public static void OneWayToSourceBinding(
            this Control control,
            string propertyName,
            object dataSource,
            string dataMember,
            bool formattingEnabled = false,
            string formatString = null,
            object nullValue = null,
            DataSourceUpdateTrigger trigger = DataSourceUpdateTrigger.OnValidation)
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
                    dataSourceUpdateMode: DataSourceUpdateMode.OnValidation);
                binding.FormattingEnabled = formattingEnabled;
                binding.FormatString = formatString;
                binding.NullValue = nullValue;
                if (trigger.Equals(DataSourceUpdateTrigger.OnLostFocus))
                {
                    binding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
                    control.LostFocus += Control_LostFocus;
                }
                else
                    binding.DataSourceUpdateMode = (DataSourceUpdateMode)trigger;
                binding.ControlUpdateMode = ControlUpdateMode.Never;
                control.DataBindings.Add(binding);
            }
        }
        public static void OneWayBinding(
            this Control control,
            string propertyName,
            object dataSource,
            string dataMember,
            bool formattingEnabled = false,
            string formatString = null,
            object nullValue = null)
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
                    dataSourceUpdateMode: DataSourceUpdateMode.Never);
                binding.ControlUpdateMode = ControlUpdateMode.OnPropertyChanged;
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
