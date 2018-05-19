using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface.Forms
{
    public partial class CuartosForm : Form
    {
        private static CuartosForm form;
        public static CuartosForm Instance()
        {
            if(form == null)
            {
                form = new CuartosForm();
            }
            return form;
        }
        protected CuartosForm()
        {
            InitializeComponent();
        }
    }
}
