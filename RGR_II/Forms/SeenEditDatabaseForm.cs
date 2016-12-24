using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RGR_II.Classes.DatabaseInteraction;

namespace RGR_II.Forms
{
    public partial class SeenEditDatabaseForm : Form
    {
        SqlConnection Connection;
        public SeenEditDatabaseForm(SqlConnection _Connection)
        {
            Connection = _Connection;
            InitializeComponent();
        }

        private void SeenEditDatabaseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SELECTallRulesOnDataTable(Connection);
            
        }

        
    }
}
