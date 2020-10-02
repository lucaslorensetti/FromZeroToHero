using FromZeroToHero.Application.Interfaces;
using System;
using System.Windows.Forms;

namespace FromZeroToHero.UI.Forms
{
    public partial class Form1 : Form
    {
        private readonly IPersonService _personService;

        public Form1(IPersonService personService)
        {
            InitializeComponent();
            _personService = personService;
        }

        private void BtnGetAll_Click(object sender, EventArgs e)
        {
            dgv.DataSource = _personService.GetAll();
        }
    }
}
