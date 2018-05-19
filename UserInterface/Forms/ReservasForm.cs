using BusinessLogic.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UserInterface.Forms
{
    public partial class ReservasForm : Form
    {
        List<User> list = new List<User>();
        List<User> list2 = new List<User>()
        {
            new User(){ Id = 0, LastName = "Juan", Name = "Pepe"},
            new User(){ Id = 1, LastName = "Juan", Name = "Pedro"},
            new User(){ Id = 2, LastName = "Juan", Name = "Pepe"},
            new User(){ Id = 3, LastName = "Jose", Name = "Gomez"}
        };

        protected ReservasForm()
        {
            InitializeComponent();
        }
        private static ReservasForm form;
        public static ReservasForm Instance()
        {
            if (form == null)
            {
                form = new ReservasForm();
            }
            return form;
        }

        private void ReservasForm_Load(object sender, System.EventArgs e)
        {
            list.AddRange(list2);
        }


    }
}
