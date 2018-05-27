using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Reflection;

namespace Security.Authorization
{
    public class AuthorizationHandler
    {
        public void Autorizar(Form form, IEnumerable<Patente> patentes)
        {

            foreach (ISecureControl control in form.Controls.OfType<ISecureControl>())
            {
                if (patentes.Contains(control.PatenteRequerida))
                {
                    ((Control)control).Hide();
                }
            }
        }
    }
}
