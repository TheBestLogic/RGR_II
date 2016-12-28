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
using static RGR_II.Classes.ExpertSystemLogic;
using static RGR_II.Classes.DatabaseInteraction;

namespace RGR_II.Forms
{
    public partial class RuleAddEditDeleteForm : Form
    {
        RULE Rule;
        byte AlgoritmStepIndex;
        SqlConnection Connection;

        public RuleAddEditDeleteForm(SqlConnection _Connection)
        {
            Connection = _Connection;
            InitializeComponent();
        }

        private byte GetByteNumber(bool Radio1 = false,bool Radio2 = false, bool Radio3 = false)
        {
            if (Radio1)
            {
                return 1;
            }
            if (Radio2)
            {
                return 2;
            }
            if (Radio3)
            {
                return 0;
            }
            return 0;
        }


        private void tabPage1_button_Back_Click(object sender, EventArgs e)
        {
            --AlgoritmStepIndex;
            tabPage1_MoveAlgoritm();
        }

        private void tabPage1_button_Next_Click(object sender, EventArgs e)
        {
            tabPage1_MoveAlgoritm();
        }

        private void tabPage1_button_Cancel_Click(object sender, EventArgs e)
        {
            RuleAddEditDeleteForm_Load(sender, e);
        }

        private void tabPage1_button_Accept_Click(object sender, EventArgs e)
        {
            tabPage1_button_Accept.Enabled = false;
            DoINSERTS(Connection, Rule);
            RuleAddEditDeleteForm_Load(sender, e);
        }

        private void tabPage1_MoveAlgoritm()
        {
            Rule.Name = tabPage1_textBox_Name.Text;
            switch (AlgoritmStepIndex)
            {
                case 0:
                    tabPage1_button_Back.Enabled = false;
                    break;
                case 1:
                    tabPage1_MoveText();
                    tabPage1_button_Cancel.Enabled = true;
                    tabPage1_button_Back.Enabled = false;
                    Rule.Node.AktivniiOtdih.FF = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 2:
                    tabPage1_MoveText();
                    tabPage1_button_Back.Enabled = true;
                    Rule.Node.AktivniiOtdih.FS = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 3:
                    tabPage1_MoveText();
                    Rule.Node.AktivniiOtdih.FT = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 4:
                    tabPage1_MoveText();
                    Rule.Node.OtdihVKompanii.FF = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 5:
                    tabPage1_MoveText();
                    Rule.Node.OtdihVKompanii.FS = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 6:
                    tabPage1_MoveText();
                    Rule.Node.Prirodu = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 7:
                    tabPage1_MoveText();
                    Rule.Node.OtdihNaPrirode = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 8:
                    tabPage1_MoveText();
                    Rule.Node.Arhitectura.FF = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 9:
                    tabPage1_MoveText();
                    Rule.Node.Arhitectura.FS = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 10:
                    tabPage1_MoveText();
                    Rule.Node.BolshieGoroda.FF = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 11:
                    tabPage1_MoveText();
                    Rule.Node.BolshieGoroda.FS = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 12:
                    tabPage1_MoveText();
                    Rule.Node.BolshieGoroda.FT = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 13:
                    tabPage1_MoveText();
                    Rule.Node.MalenkieGoroda.FF = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 14:
                    tabPage1_MoveText();
                    Rule.Node.MalenkieGoroda.FS = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 15:
                    tabPage1_MoveText();
                    Rule.Node.Dostoprimechatelnosti = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 16:
                    tabPage1_MoveText();
                    Rule.Node.VoennaaTematika.FF = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 17:
                    tabPage1_MoveText();
                    Rule.Node.VoennaaTematika.FS = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 18:
                    tabPage1_MoveText();
                    Rule.Node.Reki.FF = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 19:
                    tabPage1_MoveText();
                    Rule.Node.Reki.FS = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 20:
                    tabPage1_MoveText();
                    Rule.Node.Reki.FT = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 21:
                    tabPage1_MoveText();
                    Rule.Node.Gori.FF = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 22:
                    tabPage1_MoveText();
                    Rule.Node.Gori.FS = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 23:
                    tabPage1_MoveText();
                    Rule.Node.Gori.FT = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 24:
                    tabPage1_MoveText();
                    Rule.Node.SostoanieZdorovia.FF = (tabPage1_radioButtonLike.Checked) ? ((byte)1) : ((byte)0); 
                    Rule.Node.SostoanieZdorovia.FS = (tabPage1_radioButtonDLike.Checked) ? ((byte)1) : ((byte)0);
                    Rule.Node.SostoanieZdorovia.FT = (tabPage1_radioButtonDNM.Checked) ? ((byte)1) : ((byte)0);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 25:
                    tabPage1_MoveText();
                    Rule.Node.Temp_Hight.FF = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 26:
                    tabPage1_MoveText();
                    Rule.Node.Temp_Hight.FS = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 27:
                    tabPage1_MoveText();
                    Rule.Node.Temp_Low.FF = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 28:
                    tabPage1_button_Next.Enabled = true;
                    tabPage1_MoveText();
                    Rule.Node.Temp_Low.FS = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                case 29:
                    tabPage1_button_Next.Enabled = false;
                    tabPage1_button_Accept.Enabled = true;
                    tabPage1_MoveText();
                    Rule.Node.Temp_Srednaa = GetByteNumber(tabPage1_radioButtonLike.Checked, tabPage1_radioButtonDLike.Checked, tabPage1_radioButtonDNM.Checked);
                    ++AlgoritmStepIndex;
                    tabPage1_progressBar.PerformStep();
                    break;
                default:
                    ++AlgoritmStepIndex;
                    break;    
            }
        }

        private void tabPage1_MoveText()
        {
            switch (AlgoritmStepIndex)
            {
                case 0:
                    tabPage1_groupBox.Text = "Предпочитает активный отдых?";
                    tabPage1_radioButtonLike.Text = "Хорошее";
                    tabPage1_radioButtonDLike.Text = "Среднее";
                    tabPage1_radioButtonDNM.Text = "Плохое";
                    break;
                case 1:
                    tabPage1_groupBox.Text = "Любит смену обстановки?";
                    break;
                case 2:
                    tabPage1_groupBox.Text = "Любит экстримальный отдых?";
                    break;
                case 3:
                    tabPage1_groupBox.Text = "Любит большую компаниию?";
                    break;
                case 4:
                    tabPage1_groupBox.Text = "Любит маленькую компанию?";
                    break;
                case 5:
                    tabPage1_groupBox.Text = "Любит природу?";
                    break;
                case 6:
                    tabPage1_groupBox.Text = "Любит отдых на природе?";
                    break;
                case 7:
                    tabPage1_groupBox.Text = "Любит исторические строения?";
                    break;
                case 8:
                    tabPage1_groupBox.Text = "Любит современные строения?";
                    break;
                case 9:
                    tabPage1_groupBox.Text = "Любит промышленные города?";
                    break;
                case 10:
                    tabPage1_groupBox.Text = "Любит столицы?";
                    break;
                case 11:
                    tabPage1_groupBox.Text = "Любит обласные центры?";
                    break;
                case 12:
                    tabPage1_groupBox.Text = "Любит провинциальные города?";
                    break;
                case 13:
                    tabPage1_groupBox.Text = "Любит села?";
                    break;
                case 14:
                    tabPage1_groupBox.Text = "Любит достопримечательности?";
                    break;
                case 15:
                    tabPage1_groupBox.Text = "Любит музеи военной техники?";
                    break;
                case 16:
                    tabPage1_groupBox.Text = "Любит парки славы?";
                    break;
                case 17:
                    tabPage1_groupBox.Text = "Любит моря?";
                    break;
                case 18:
                    tabPage1_groupBox.Text = "Любит реки?";
                    break;
                case 19:
                    tabPage1_groupBox.Text = "Любит озера?";
                    break;
                case 20:
                    tabPage1_groupBox.Text = "Любит высокие горы?";
                    break;
                case 21:
                    tabPage1_groupBox.Text = "Любит холмы?";
                    break;
                case 22:
                    tabPage1_groupBox.Text = "Любит горы с возможностью подьёма?";
                    break;
                case 23:
                    tabPage1_groupBox.Text = "Укажите состояние здоровья:";
                    tabPage1_radioButtonLike.Text = "Хорошее";
                    tabPage1_radioButtonDLike.Text = "Среднее";
                    tabPage1_radioButtonDNM.Text = "Плохое";
                    break;
                case 24:
                    tabPage1_groupBox.Text = "Отношение к температуре +30 по цельсию и выше:";
                    tabPage1_radioButtonLike.Text = "Нравится";
                    tabPage1_radioButtonDLike.Text = "Не нравится";
                    tabPage1_radioButtonDNM.Text = "Не имеет значения";
                    break;
                case 25:
                    tabPage1_groupBox.Text = "Отношение к температуре от +25 до +30 по цельсию:";
                    break;
                case 26:
                    tabPage1_groupBox.Text = "Отношение к температуре от -10 до +15 по цельсию:";
                    break;
                case 27:
                    tabPage1_groupBox.Text = "Отношение к температуре от -30 до -10 по цельсию:";
                    break;
                case 28:
                    tabPage1_groupBox.Text = "Отношение к температуре от +15 до +25 по цельсию:";
                    break;
                case 29:
                    tabPage1_groupBox.Text = "Для добавления правила нажмите \"Accept\"";
                    break;
                default:
                    break;
            }
        }

        private void RuleAddEditDeleteForm_Load(object sender, EventArgs e)
        {
            Rule = new RULE();
            Rule.Clear();
            AlgoritmStepIndex = 0;
            tabPage1_groupBox.Text = "Предпочитает активный отдых?";
            tabPage1_textBox_Name.Text = null;
            tabPage1_label1.Text = "Название места отдыха:";
            tabPage1_progressBar.Step = 31;
            tabPage1_radioButtonLike.Text = "Нравится";
            tabPage1_radioButtonDLike.Text = "Не нравится";
            tabPage1_radioButtonDNM.Text = "Не имеет значения";
            tabPage1_MoveText();
            tabPage1_button_Back.Enabled = false;
            tabPage1_button_Accept.Enabled = false;
            tabPage1_button_Cancel.Enabled = false;
        }
    }
}
