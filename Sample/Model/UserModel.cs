using MvvmExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Model
{
    public class UserModel : BindingBase
    {
        private string id;
        private string name;
        public string Id { get => id; set => SetValue(ref id, value); }
        public string Name { get => name; set => SetValue(ref name, value); }
    }
}
