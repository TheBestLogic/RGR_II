using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RGR_II.Classes.ExpertSystemLogic;

namespace RGR_II
{
    
    public partial class StartForm : Form
    {
        byte iteration_step;
        NODE Node;
        bool flag_1;
        bool flag_2;
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            iteration_step = 0;
            flag_1 = false;
            flag_2 = false;
            Node.Clear();
            label1.Text = "Для того чтобы начать процесс выбора\nнажмите кнопку \"Начать\"";
            label2.Text = "Выбор означает что вы отдаёте предпочтение и варианты с признаками.\n"+
                            "Выбор \"Не нравится\" означает что варианты будут с этим пунктом будут исключены."+
                            "\nОтсутствие выбора означает что вы не против наличия этого пункта";
            label3.Text = "";
            groupBox1.Text = "Пункты для выбора";
            checkBox1.Text = "";
            checkBox2.Text = "Нет";
            checkBox3.Text = "";
            checkBox4.Text = "Нет";
            checkBox5.Text = "";
            checkBox6.Text = "Нет";
            label3.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            checkBox5.Visible = false;
            checkBox6.Visible = false;
            button_Clear.Text = "Очистить";
            button_Clear.Visible = false;
            button_StartNextEnd.Text = "Начать";
        }

        private void button_StartNextEnd_Click(object sender, EventArgs e)
        {
            button_StartNextEnd.Enabled = false;
            switch (iteration_step)
            {
                case 0:
                    groupBox1.Visible = true;
                    button_Clear.Visible = true;
                    label1.Visible = false;
                    Thread.Sleep(300);
                    button_StartNextEnd.Text = "Дальше";
                    label3.Text = "Ваше отношение к активному отдыху:";
                    checkBox1.Text = "Любите активный отдых?";
                    checkBox3.Text = "Хотите сменить обстановку?";
                    checkBox5.Text = "Любите экстримальный отдых?";
                    label3.Visible = true;
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                    checkBox3.Visible = true;
                    checkBox4.Visible = true;
                    checkBox5.Visible = true;
                    checkBox6.Visible = true;
                    iteration_step = 1;
                    break;
                case 1:
                    //AktivniiOtdih
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "Ваше отношение к отдыху в компании:";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 2;
                    break;
                case 2:
                    //OtdihVKompanii
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 5;
                    break;
                case 3:
                    //Prirodu
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    if (!checkBox2.Checked)
                    {
                        flag_1 = true;
                        iteration_step = 6;
                        break;
                    }
                    iteration_step = 4;
                    break;
                case 4:
                    //OtdihNaPrirode
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 10;
                    break;
                case 5:
                    //Arhitectura
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 3;
                    break;
                case 6:
                    //BolshieGoroda
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 7;
                    break;
                case 7:
                    //MalenkieGoroda
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 9;
                    if (flag_1)
                    {
                        iteration_step = 4;
                        break;
                    }
                    break;
                case 8:
                    //Dostoprimechatelnosti
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    break;
                case 9:
                    //VoennaaTematika
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 12;
                    break;
                case 10:
                    //Reki
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    iteration_step = 11;
                    break;
                case 11:
                    //Gori
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 9;
                    break;
                case 12:
                    //SostoanieZdorovia
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 13;
                    break;
                case 13:
                    //Temp_Hight
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 15;
                    break;
                case 14:
                    //Temp_Low
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    break;
                case 15:
                    //Temp_Srednaa
                    SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    Thread.Sleep(300);
                    label3.Text = "";
                    checkBox1.Text = "";
                    checkBox3.Text = "";
                    checkBox5.Text = "";
                    iteration_step = 14;
                    break;
                case 16:

                    return;
                default:
                    button_StartNextEnd.Enabled = false;
                    Thread.Sleep(300);
                    StartForm_Load(sender, e);
                    button_StartNextEnd.Enabled = true;
                    return;
            }
            button_StartNextEnd.Enabled = true;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            StartForm_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Enabled = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = !checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox4.Enabled = !checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Enabled = !checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox6.Enabled = !checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Enabled = !checkBox6.Checked;
        }
        
    }
}
