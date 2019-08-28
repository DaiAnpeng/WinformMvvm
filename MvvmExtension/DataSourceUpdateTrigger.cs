using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExtension
{
    public enum DataSourceUpdateTrigger
    {
        //
        // 摘要:
        //     当验证控件属性后，更新数据源
        OnValidation = 0,
        //
        // 摘要:
        //     每当控件属性的值更改时，将更新数据源。
        OnPropertyChanged = 1,
        //
        // 摘要:
        //     永远不会更新数据源并且不分析、 验证或重新格式化文本框控件中输入的值。
        Never = 2,
        //
        // 摘要:
        //     每当控件丢失焦点时，将更新数据源。
        OnLostFocus = 3
    }
}
