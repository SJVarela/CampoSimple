using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security.Authorization
{
    public interface ISecureControl : IComponent
    {
        Patente PatenteRequerida { get; set; }
    }
}
