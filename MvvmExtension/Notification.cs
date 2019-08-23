using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmExtension
{
    public delegate T Notification<T, E>(E e);
    public delegate void Notification<E>(E e);
    public delegate void Notification();
}
