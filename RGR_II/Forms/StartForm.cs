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
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            iteration_step = 0;
            flag_1 = false;
            Node.Clear();
            label1.Text = "Для того чтобы начать процесс выбора\nнажмите кнопку \"Начать\"";
            label2.Text = "Выбор означает что вы отдаёте предпочтение и варианты с признаками.\n" +
                            "Выбор \"Не нравится\" означает что варианты будут с этим пунктом будут исключены." +
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
            button_Clear.Enabled = false;
            button_StartNextEnd.Text = "Начать";
            button_StartNextEnd.Enabled = true;
        }

        private void button_StartNextEnd_Click(object sender, EventArgs e)
        {
            button_StartNextEnd.Enabled = false;
            switch (iteration_step)
            {
                case 0:
                    label1.Visible = false;
                    groupBox1.Visible = true;
                    button_Clear.Enabled = true;
                    button_StartNextEnd.Text = "Дальше";
                    SetActiveComponentAndString("Ваше отношение к активному отдыху:", "Любите активный отдых?", "Хотите сменить обстановку?", "Любите экстримальный отдых?");
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
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);
                    SetActiveComponentAndString("Ваше отношение к отдыху в компании:", "Любите отдых в большой компании?", "Любите отдых в маленькой компании?");
                    iteration_step = 2;
                    break;
                case 2:
                    //OtdihVKompanii
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    SetActiveComponentAndString("Ваше отношение к аршитектуре:","Любите исторические строения?","Любите современные строения?");
                    iteration_step = 5;
                    break;
                case 3:
                    //Prirodu
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked);
                    if (checkBox2.Checked)
                    {
                        flag_1 = true;
                        iteration_step = 6;
                        SetActiveComponentAndString("Ваше отношение к большим городам:", "Любите промышленные города?", "Любите посещать столицы?","Вы хотели бы посетить областной центр?");
                    }
                    else
                    {
                        iteration_step = 4;
                        SetActiveComponentAndString("Ваше отношения к отдыху на природе:", "Любите отдыхать на природе?");
                    }
                    break;
                case 4:
                    //OtdihNaPrirode
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked);
                    SetActiveComponentAndString("Ваше отношение к рекам, озерам и океанам:","Вы любите моря?","Вы любите реки?","Вы любите озера?");
                    iteration_step = 10;
                    break;
                case 5:
                    //Arhitectura
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    SetActiveComponentAndString("Ваше отношение к природе:","Вы любите природу?");
                    iteration_step = 3;
                    break;
                case 6:
                    //BolshieGoroda
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);
                    SetActiveComponentAndString("Ваше отношение к маленьким городам:","Вы любите провинциальные города?","Вы любите села?");
                    iteration_step = 8;
                    break;
                case 7:
                    //MalenkieGoroda
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    if (!flag_1)
                    {
                        iteration_step = 4;
                        SetActiveComponentAndString("Ваше отношения к отдыху на природе:", "Любите отдыхать на природе?");
                    }
                    else
                    {
                        iteration_step = 9;
                        SetActiveComponentAndString("Ваше отношение к военным памятникам культуры:","Вы любите парки военной техники?","Хотели бы вы посетить музеи славы?");
                    }
                    break;
                case 8:
                    //Dostoprimechatelnosti
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked);
                    SetActiveComponentAndString("Ваше отношение к достопримечательностям:","Вы любите достопримечательности?");
                    iteration_step = 7;
                    break;
                case 9:
                    //VoennaaTematika
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    SetActiveComponentAndString("Какое у вас состояние здоровья?","Хорошее","Среднее","Тяжелое");
                    iteration_step = 12;
                    break;
                case 10:
                    //Reki
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);
                    SetActiveComponentAndString("Ваше отношение к горам:","Вы любите высокие горы?","Вы любите холмы?","Вас интерисуют горы с возможностью подьёма?");
                    iteration_step = 11;
                    break;
                case 11:
                    //Gori
                    if (checkBox1.Checked || checkBox3.Checked || checkBox5.Checked)
                    {
                        Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);
                        SetActiveComponentAndString("Ваше отношение к военным памятникам культуры:", "Вы любите парки военной техники?", "Хотели бы вы посетить музеи славы?");
                        iteration_step = 9;
                    }
                    break;
                case 12:
                    //SostoanieZdorovia
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked, checkBox5.Checked, checkBox6.Checked);
                    SetActiveComponentAndString("Как вы относитесь к высокой температуре:","Вам нравится температура больше 30 градусов?", "Вам нравится температура от 25 до 30 градусов?");
                    iteration_step = 13;
                    break;
                case 13:
                    //Temp_Hight
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    SetActiveComponentAndString("Как вы относитесь к средней температуре:", "Вам нравится температура от 15 до 25 градусов?");
                    iteration_step = 15;
                    break;
                case 14:
                    //Temp_Low
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked, checkBox3.Checked, checkBox4.Checked);
                    button_StartNextEnd.Enabled = false;
                    GetResultForRules();
                    ////end
                    break;
                case 15:
                    //Temp_Srednaa
                    Node = SetNodeParam(Node, iteration_step, checkBox1.Checked, checkBox2.Checked);
                    SetActiveComponentAndString("Как вы относитесь к низкой температуре:", "Вам нравится температура -10 до 15 градусов?", "Вам нравится температура от -30 до -10 градусов?");
                    iteration_step = 14;
                    break;
                default:
                    button_StartNextEnd.Enabled = false;
                    Thread.Sleep(300);
                    StartForm_Load(sender, e);
                    button_StartNextEnd.Enabled = true;
                    return;
            }
            button_StartNextEnd.Enabled = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            StartForm_Load(sender, e);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(iteration_step == 12)
            {
                checkBox3.Checked = false;
                checkBox5.Checked = false;
                return;
            }
            checkBox2.Enabled = !checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = !checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (iteration_step == 12)
            {
                checkBox1.Checked = false;
                checkBox5.Checked = false;
                return;
            }
            checkBox4.Enabled = !checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            
            checkBox3.Enabled = !checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (iteration_step == 12)
            {
                checkBox3.Checked = false;
                checkBox1.Checked = false;
                return;
            }
            checkBox6.Enabled = !checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox5.Enabled = !checkBox6.Checked;
        }

        private void SetActiveComponentAndString(string Label3String, params string[] values)
        {
            label3.Text = "...";
            int Length = values.Length;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox1.Text = "...";
            checkBox3.Text = "...";
            checkBox5.Text = "...";
            checkBox2.Text = "...";
            checkBox4.Text = "...";
            checkBox6.Text = "...";
            Thread.Sleep(300);
            if(Label3String == "Какое у вас состояние здоровья?")
            {
                label3.Text = Label3String;
                checkBox1.Text = values[0];
                checkBox3.Text = values[1];
                checkBox5.Text = values[2];
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox5.Enabled = true;
                return;
            }
            if(Length == 1)
            {
                checkBox1.Text = values[0];
                checkBox2.Text = "Нет";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
            }
            if (Length == 2)
            {
                checkBox1.Text = values[0];
                checkBox3.Text = values[1];
                checkBox2.Text = "Нет";
                checkBox4.Text = "Нет";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
            }
            if (Length == 3)
            {
                checkBox1.Text = values[0];
                checkBox3.Text = values[1];
                checkBox5.Text = values[2];
                checkBox2.Text = "Нет";
                checkBox4.Text = "Нет";
                checkBox6.Text = "Нет";
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
            }
            label3.Text = Label3String;
        }

        private void GetResultForRules()
        {
            bool[] Arr = new bool[17];
            label1.Text = GetResultString(DetectRule(Arr, Node));
            groupBox1.Visible = false;
            label1.Visible = true;
        }



        
    }
}
