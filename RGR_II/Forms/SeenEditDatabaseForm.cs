using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGR_II.Forms
{
    public partial class SeenEditDatabaseForm : Form
    {
        public SeenEditDatabaseForm()
        {
            InitializeComponent();
        }

        private void SeenEditDatabaseForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.Rule". При необходимости она может быть перемещена или удалена.
            this.ruleTableAdapter.Fill(this.dBDataSet.Rule);

        }
    }
}
