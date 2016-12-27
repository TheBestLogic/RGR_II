using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;
using static RGR_II.Classes.ExpertSystemLogic;
using System.IO;
using System.Reflection;
using System.Data;


namespace RGR_II.Classes
{
    class DatabaseInteraction
    {

        public static SqlConnection CreateConn(SqlConnection Connection)
        {
            Connection = new SqlConnection(GetConnectionString());
            try
            {
                Connection.Open();
            }
            catch (SqlException se)
            {
                MessageBox.Show("Connection exeption: " + se.Number.ToString() + "\n" + se.Message);
                if (se.Number == 4060)
                {
                    ExeptionCreateDatabase(Connection);
                    Connection = new SqlConnection(GetConnectionString());
                }
                else
                {
                    Connection.Close();
                    return null;
                }
            }
            Connection.Close();
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            return Connection;
        }

        public static int LostConn(SqlConnection Connection)
        {
            Connection.Close();
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            Connection.Dispose();
            return 0;
        }

        private static void ExeptionCreateDatabase(SqlConnection Connection)
        {
            MessageBox.Show("Database creation begin");
            Connection.Close();
            Connection = new SqlConnection(GetConnectionString());
            SqlCommand cmdCreateDatabase = new SqlCommand(GetCreateDatabaseString(), Connection);
            try
            {
                Connection.Open();
                cmdCreateDatabase.ExecuteNonQuery();
            }
            catch (SqlException se)
            {
                MessageBox.Show("CreateDatabase exeption: " + se.Number.ToString() + "\n" + se.Message);
                Connection.Close();
                return;
            }
            Connection.Close();
            Thread.Sleep(5000);
            MessageBox.Show("Database creation end");
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        private static string GetConnectionString()
        {
            return "Data Source=(LocalDB)\\MSSQLLocalDB;"
                    + "AttachDbFilename=" + Properties.Settings.Default.DBDir + ";"
                    + " Integrated Security=True";
        }

        private static string GetCreateDatabaseString()
        {
            return "CREATE DATABASE [" + Properties.Settings.Default.DBN + "] " +
                   "ON (FILENAME = " + Properties.Settings.Default.DBDir + ") " +
                   "LOG ON (FILENAME = " + Properties.Settings.Default.DBLog + ") " +
                   "FOR ATTACH GO";
        }

        public static string GetCreateTableString()
        {
            return Properties.Resources.Criate_Tables; 
        }

        public static void CreateTable(SqlConnection Connection)
        {
            SqlCommand cmdCreateTable = new SqlCommand(GetCreateTableString(), Connection);
            try
            {
                Connection.Open();
                cmdCreateTable.ExecuteNonQuery();
                Connection.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("CreateTable exeption: " + se.Number.ToString() + "\n" + se.Message);
                Connection.Close();
                return;
            }
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public static int NeedNewTables(SqlConnection Connection)
        {
            SqlCommand command = new SqlCommand(Properties.Resources.SelectTOPaLL, Connection);
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                   DefaultRules(Connection);
                   Connection.Close();
                   //CreateTable(Connection);
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("NeedNewTables - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);

                Connection.Close();
                CreateTable(Connection);
            }
            Connection.Close();
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            return 0;
        }

        public static string CreateSELECTString(RULE Rule)
        {
            byte check = 0;
            NODE Node = new NODE();
            Node.Copy(Rule.Node);
            string Str = Properties.Resources.SelectAllString + '\n';
            while (true)
            {
                if (Node.SostoanieZdorovia.FF != 0)
                {
                    Str += $" WHRERE (SZ.FF={Node.SostoanieZdorovia.FF} OR SZ.FS={Node.SostoanieZdorovia.FF} OR  SZ.FT={Node.SostoanieZdorovia.FF}) AND ( ";
                    ++check;
                    break;
                }
                if (Node.SostoanieZdorovia.FS != 0)
                {
                    Str += $" WHRERE (SZ.FS={Node.SostoanieZdorovia.FF} OR  SZ.FT={Node.SostoanieZdorovia.FF}) AND ( ";
                    ++check;
                    break;
                }
                if (Node.SostoanieZdorovia.FT != 0)
                {
                    Str += " WHRERE SZ.FT=" + Node.SostoanieZdorovia.FT + " AND ( ";
                    ++check;
                }
                break;
            }
            if (Node.AktivniiOtdih.FF != 0)
            {
                Str += " OR AO.FF=" + Node.AktivniiOtdih.FF;
                ++check;
            }
            if (Node.AktivniiOtdih.FS != 0)
            {
                Str += " OR AO.FS=" + Node.AktivniiOtdih.FS;
                ++check;
            }
            if (Node.AktivniiOtdih.FT != 0)
            {
                Str += " OR AO.FT=" + Node.AktivniiOtdih.FT;
                ++check;
            }
            if (Node.OtdihVKompanii.FF != 0)
            {
                Str += " OR OvK.FF=" + Node.OtdihVKompanii.FF;
                ++check;
            }
            if (Node.OtdihVKompanii.FS != 0)
            {
                Str += " OR OvK.FS=" + Node.OtdihVKompanii.FS;
                ++check;
            }
            if (Node.Prirodu != 0)
            {
                Str += " OR R.Priroda=" + Node.Prirodu;
                ++check;
            }
            if (Node.OtdihNaPrirode != 0)
            {
                Str += " OR R.OtdihNaPrirode=" + Node.OtdihNaPrirode;
                ++check;
            }
            if (Node.Arhitectura.FF != 0)
            {
                Str += " OR A.FF=" + Node.Arhitectura.FF;
                ++check;
            }
            if (Node.Arhitectura.FS != 0)
            {
                Str += " OR A.FS=" + Node.Arhitectura.FS;
                ++check;
            }
            if (Node.BolshieGoroda.FF != 0)
            {
                Str += " OR BG.FF=" + Node.BolshieGoroda.FF;
                ++check;
            }
            if (Node.BolshieGoroda.FS != 0)
            {
                Str += " OR BG.FS=" + Node.BolshieGoroda.FS;
                ++check;
            }
            if (Node.BolshieGoroda.FT != 0)
            {
                Str += " OR BG.FT=" + Node.BolshieGoroda.FT;
                ++check;
            }
            if (Node.MalenkieGoroda.FF != 0)
            {
                Str += " OR MG.FF=" + Node.MalenkieGoroda.FF;
                ++check;
            }
            if (Node.MalenkieGoroda.FS != 0)
            {
                Str += " OR MG.FS=" + Node.MalenkieGoroda.FS;
                ++check;
            }
            if (Node.Dostoprimechatelnosti != 0)
            {
                Str += " OR R.Dostoprimech=" + Node.Dostoprimechatelnosti;
                ++check;
            }
            if (Node.VoennaaTematika.FF != 0)
            {
                Str += " OR VT.FF=" + Node.VoennaaTematika.FF;
                ++check;
            }
            if (Node.VoennaaTematika.FS != 0)
            {
                Str += " OR VT.FS=" + Node.VoennaaTematika.FS;
                ++check;
            }
            if (Node.Reki.FF != 0)
            {
                Str += " OR Re.FF=" + Node.Reki.FF;
                ++check;
            }
            if (Node.Reki.FS != 0)
            {
                Str += " OR Re.FS=" + Node.Reki.FS;
                ++check;
            }
            if (Node.Reki.FT != 0)
            {
                Str += " OR Re.FT=" + Node.Reki.FT;
                ++check;
            }
            if (Node.Gori.FF != 0)
            {
                Str += " OR G.FF=" + Node.Gori.FF;
                ++check;
            }
            if (Node.Gori.FS != 0)
            {
                Str += " OR G.FS=" + Node.Gori.FS;
                ++check;
            }
            if (Node.Gori.FT != 0)
            {
                Str += " OR G.FT=" + Node.Gori.FT;
                ++check;
            }

            if (Node.Temp_Hight.FF != 0)
            {
                Str += " OR TH.FF=" + Node.Temp_Hight.FF;
                ++check;
            }
            if (Node.Temp_Hight.FS != 0)
            {
                Str += " OR TH.FS=" + Node.Temp_Hight.FS;
                ++check;
            }
            if (Node.Temp_Low.FF != 0)
            {
                Str += " OR TL.FF=" + Node.Temp_Low.FF;
                ++check;
            }
            if (Node.Temp_Low.FS != 0)
            {
                Str += " OR TL.FS=" + Node.Temp_Low.FS;
                ++check;
            }
            if (Node.Temp_Srednaa != 0)
            {
                Str += " OR R.TempSred=" + Node.Temp_Srednaa;
                ++check;
            }
            if (check == 0)
            {
                Str = Properties.Resources.SelectAllString;
            }
            else
            {
                Str += " );";
            }

            return Str;
        }

        private static string[] CreateUPDATEString(SqlConnection Connection, RULE Rule, int flag = 0, int ID = 1, string Name =null)
        {
            if(Rule.ID ==0 || Rule.Name == null)
            {
                Rule.SetIdName(GetNamesIDs(Connection, flag, ID, Name));
            }
            string[] Strin = new string[12];
            if (Rule.Name == null || Rule.Name.Length<2)
            {
                Strin[0] = $"UPDATE AktivniiOtdih SET FF={Rule.Node.AktivniiOtdih.FF}, " +
                    $"FS={Rule.Node.AktivniiOtdih.FS}, FT={Rule.Node.AktivniiOtdih.FT} " +
                    $"WHERE ID ={Rule.ID};";
                Strin[1] = $"UPDATE Arhitectura SET FF={Rule.Node.Arhitectura.FF}, " +
                    $"FS={ Rule.Node.Arhitectura.FS} WHERE ID ={Rule.ID};";
                Strin[2] = $"UPDATE BolshieGoroda SET FF={Rule.Node.BolshieGoroda.FF}, " +
                    $"FS={Rule.Node.BolshieGoroda.FS}, FT={Rule.Node.BolshieGoroda.FT} " +
                    $"WHERE ID ={Rule.ID};";
                Strin[3] = $"UPDATE Gori SET FF={Rule.Node.Gori.FF}, " +
                    $"FS={Rule.Node.Gori.FS}, FT={Rule.Node.Gori.FT} " +
                    $"WHERE ID ={Rule.ID};";
                Strin[4] = $"UPDATE MalenkieGoroda SET FF={Rule.Node.MalenkieGoroda.FF}, " +
                    $"FS={ Rule.Node.MalenkieGoroda.FS} WHERE ID ={Rule.ID};";
                Strin[5] = $"UPDATE OtdihVKompanii SET FF={Rule.Node.OtdihVKompanii.FF}, " +
                    $"FS={ Rule.Node.OtdihVKompanii.FS} WHERE ID ={Rule.ID};";
                Strin[6] = $"UPDATE Reki SET FF={Rule.Node.Reki.FF}, " +
                    $"FS={Rule.Node.Reki.FS}, FT={Rule.Node.Reki.FT} " +
                    $"WHERE ID ={Rule.ID};";
                Strin[7] = $"UPDATE Rules SET Priroda={ Rule.Node.Prirodu}, " +
                    $"OtdihNaPrirode={ Rule.Node.OtdihNaPrirode}, "+
                    $"Dostoprimech={ Rule.Node.Dostoprimechatelnosti}, TempSred={Rule.Node.Temp_Srednaa} " +
                    "WHERE Id =" + Rule.ID + ';';
                Strin[8] = $"UPDATE SostoanieZdorovia SET FF={Rule.Node.SostoanieZdorovia.FF}, " +
                    $"FS={Rule.Node.SostoanieZdorovia.FS}, FT={Rule.Node.SostoanieZdorovia.FT} " +
                    $"WHERE ID ={Rule.ID};";
                Strin[9] = $"UPDATE Temp_Hight SET FF={Rule.Node.Temp_Hight.FF}, " +
                    $"FS={ Rule.Node.Temp_Hight.FS} WHERE ID ={Rule.ID};";
                Strin[10] = $"UPDATE Temp_Low SET FF={Rule.Node.Temp_Low.FF}, " +
                    $"FS={ Rule.Node.Temp_Low.FS} WHERE ID ={Rule.ID};";
                Strin[11] = $"UPDATE VoennaaTematika SET FF={Rule.Node.VoennaaTematika.FF}, " +
                    $"FS={ Rule.Node.VoennaaTematika.FS} WHERE ID ={Rule.ID};";
            }
            else
            {
                Strin[0] = $"UPDATE AktivniiOtdih SET FF={Rule.Node.AktivniiOtdih.FF}, " +
                    $"FS={Rule.Node.AktivniiOtdih.FS}, FT={Rule.Node.AktivniiOtdih.FT} " +
                    $"WHERE ID ={Rule.ID};";
                Strin[1] = $"UPDATE Arhitectura SET FF={Rule.Node.Arhitectura.FF}, " +
                    $"FS={ Rule.Node.Arhitectura.FS} WHERE ID ={Rule.ID};";
                Strin[2] = $"UPDATE BolshieGoroda SET FF={Rule.Node.BolshieGoroda.FF}, " +
                    $"FS={Rule.Node.BolshieGoroda.FS}, FT={Rule.Node.BolshieGoroda.FT} " +
                    $"WHERE ID ={Rule.ID};";
                Strin[3] = $"UPDATE Gori SET FF={Rule.Node.Gori.FF}, " +
                    $"FS={Rule.Node.Gori.FS}, FT={Rule.Node.Gori.FT} " +
                    $"WHERE ID ={Rule.ID};";
                Strin[4] = $"UPDATE MalenkieGoroda SET FF={Rule.Node.MalenkieGoroda.FF}, " +
                    $"FS={ Rule.Node.MalenkieGoroda.FS} WHERE ID ={Rule.ID};";
                Strin[5] = $"UPDATE OtdihVKompanii SET FF={Rule.Node.OtdihVKompanii.FF}, " +
                    $"FS={ Rule.Node.OtdihVKompanii.FS} WHERE ID ={Rule.ID};";
                Strin[6] = $"UPDATE Reki SET FF={Rule.Node.Reki.FF}, " +
                    $"FS={Rule.Node.Reki.FS}, FT={Rule.Node.Reki.FT} " +
                    $"WHERE ID ={Rule.ID};";
                Strin[7] = $"UPDATE Rules SET Priroda={Rule.Node.Prirodu}, Name='{Rule.Name}'," +
                    $"OtdihNaPrirode={Rule.Node.OtdihNaPrirode}, " +
                    $"Dostoprimech={Rule.Node.Dostoprimechatelnosti}, TempSred={Rule.Node.Temp_Srednaa} " +
                    $"WHERE Id ={Rule.ID};";
                Strin[8] = $"UPDATE SostoanieZdorovia SET FF={Rule.Node.SostoanieZdorovia.FF}, " +
                    $"FS={Rule.Node.SostoanieZdorovia.FS}, FT={Rule.Node.SostoanieZdorovia.FT} " +
                    $"WHERE ID ={Rule.ID};";
                Strin[9] = $"UPDATE Temp_Hight SET FF={Rule.Node.Temp_Hight.FF}, " +
                    $"FS={ Rule.Node.Temp_Hight.FS} WHERE ID ={Rule.ID};";
                Strin[10] = $"UPDATE Temp_Low SET FF={Rule.Node.Temp_Low.FF}, " +
                    $"FS={ Rule.Node.Temp_Low.FS} WHERE ID ={Rule.ID};";
                Strin[11] = $"UPDATE VoennaaTematika SET FF={Rule.Node.VoennaaTematika.FF}, " +
                    $"FS={ Rule.Node.VoennaaTematika.FS} WHERE ID ={Rule.ID};";
            }
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            return Strin;
        }

        private static string findNeedSELECT(int flag = 0, int ID = 1, string Name = null)
        {
            string SelectString = Properties.Resources.SelectNameAndID;
            switch (flag)
            {
                case 0:
                    SelectString += $" WHERE ID={ID}";
                    break;
                case 1:
                    SelectString += $" WHERE Name='{Name}'";
                    break;
                case 2:
                    SelectString += $" WHERE Name='{Name}' AND ID={ID}";
                    break;
                case 3:
                    SelectString += $" WHERE Name='{Name}' OR ID={ID}";
                    break;
                default:
                    break;
            }
            return SelectString;
        }

        public static void DELETEdataFromTable(SqlConnection Connection, int flag = 0, int ID = 1, string Name = null)
        {
            string[] sqlExpression = new string[12];
            SqlCommand command;
            int _ID = ID;
            string _Name = Name;
            if (flag != 4)
            {
                sqlExpression[0] = findNeedSELECT(flag, ID, Name);
                command = new SqlCommand(sqlExpression[0], Connection);
                try
                {
                    Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            _ID = reader.GetInt32(0);
                            _Name = reader.GetString(1);
                        }
                    }
                    Connection.Close();
                }
                catch (SqlException se)
                {
                    MessageBox.Show("DELETEdataFromTable - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);
                    Connection.Close();
                }
            }
            sqlExpression[0] = $"DELETE Rules FROM Rules WHERE Rules.ID = {_ID} OR Rules.Name='{_Name}'";
            sqlExpression[1] = $"DELETE AktivniiOtdih FROM AktivniiOtdih WHERE AktivniiOtdih.ID = {_ID}";
            sqlExpression[2] = $"DELETE Arhitectura FROM Arhitectura WHERE Arhitectura.ID = {_ID}";
            sqlExpression[3] = $"DELETE BolshieGoroda FROM BolshieGoroda WHERE BolshieGoroda.ID = {_ID}";
            sqlExpression[4] = $"DELETE Gori FROM Gori WHERE Gori.ID = {_ID}";
            sqlExpression[5] = $"DELETE MalenkieGoroda FROM MalenkieGoroda WHERE MalenkieGoroda.ID = {_ID}";
            sqlExpression[6] = $"DELETE OtdihVKompanii FROM OtdihVKompanii WHERE OtdihVKompanii.ID = {_ID}";
            sqlExpression[7] = $"DELETE Reki FROM Reki WHERE Reki.ID = {_ID}";
            sqlExpression[8] = $"DELETE SostoanieZdorovia FROM SostoanieZdorovia WHERE SostoanieZdorovia.ID = {_ID}";
            sqlExpression[9] = $"DELETE Temp_Hight FROM Temp_Hight WHERE Temp_Hight.ID = {_ID}";
            sqlExpression[10] = $"DELETE Temp_Low FROM Temp_Low WHERE Temp_Low.ID = {_ID}";
            sqlExpression[11] = $"DELETE VoennaaTematika FROM VoennaaTematika WHERE VoennaaTematika.ID = {_ID}";
            try
            {
                Connection.Open();
                SqlDataReader reader;
                for( int i = 0; i < 12; ++i)
                {
                    command = new SqlCommand(sqlExpression[i], Connection);
                    reader = command.ExecuteReader();
                }
                Connection.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("DELETEdataFromTable - " + "DELETE exeption: " + se.Number.ToString() + "\n" + se.Message);
                Connection.Close();
            }
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public static RULE GetNamesIDs(SqlConnection Connection,int flag = 0, int ID = 1, string Name = null)
        {
            string sqlExpression = findNeedSELECT(flag, ID, Name);
            RULE R = new RULE();
            SqlCommand command = new SqlCommand(sqlExpression, Connection);
            try
            {
                Connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                   while (reader.Read())
                   {
                       R.ID = reader.GetInt32(0);
                       R.Name = reader.GetString(1);
                   }
                }
                Connection.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show("GetNamesIDs - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);
                Connection.Close();
            }
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            return R;
        }

        public static void DoINSERTS(SqlConnection Connection, RULE Rule = default(RULE))
        {
            string Ex = null;
            string[] sqlExpression = new string[13];
            int ID = 0;
            sqlExpression[0] = "INSERT INTO Rules(Priroda, OtdihNaPrirode,Dostoprimech,TempSred,Name) " +
                $"values({Rule.Node.Prirodu}, {Rule.Node.OtdihNaPrirode}, {Rule.Node.Dostoprimechatelnosti}, {Rule.Node.Temp_Srednaa},'{Rule.Name}')";
            sqlExpression[1] = $"SELECT TOP 1 ID FROM Rules WHERE Name='{Rule.Name}' ORDER BY ID DESC";
            try
            {
                Connection.Open();
                Ex += "Open";
                SqlCommand command = new SqlCommand(sqlExpression[0], Connection);
                Ex += "\n\t" + sqlExpression[0] + "try... ";
                SqlDataReader reader = command.ExecuteReader();
                Ex += "Done.";
                command = new SqlCommand(sqlExpression[1], Connection);
                Ex += "\n\t" + sqlExpression[1] + "try... ";
                reader.Close();
                reader = command.ExecuteReader();
                Ex += "Done.";
                if (reader.HasRows)
                {
                    Ex += "\n\t\t\t\tHasRows.";
                    while (reader.Read())
                    {
                        ID = reader.GetInt32(0);
                        Ex += $"\n\t\t\t\tHasID: {ID}";
                    }
                }
                reader.Close();
                Connection.Close();
                sqlExpression[2] = "INSERT INTO AktivniiOtdih(ID, FF, FS, FT) " +
                $"values({ID}, {Rule.Node.AktivniiOtdih.FF}, {Rule.Node.AktivniiOtdih.FS}, {Rule.Node.AktivniiOtdih.FT})";
                sqlExpression[3] = "INSERT INTO Arhitectura(ID, FF, FS)  " +
                    $"values({ID}, {Rule.Node.Arhitectura.FF}, {Rule.Node.Arhitectura.FS})";
                sqlExpression[4] = "INSERT INTO BolshieGoroda(ID, FF, FS, FT) " +
                    $"values({ID}, {Rule.Node.BolshieGoroda.FF}, {Rule.Node.BolshieGoroda.FS}, {Rule.Node.BolshieGoroda.FT})";
                sqlExpression[5] = "INSERT INTO Gori(ID, FF, FS, FT) " +
                    $"values({ID}, {Rule.Node.Gori.FF}, {Rule.Node.Gori.FS}, {Rule.Node.Gori.FT})";
                sqlExpression[6] = "INSERT INTO MalenkieGoroda(ID, FF, FS) " +
                    $"values({ID}, {Rule.Node.MalenkieGoroda.FF}, {Rule.Node.MalenkieGoroda.FS})";
                sqlExpression[7] = "INSERT INTO OtdihVKompanii(ID, FF, FS) " +
                    $"values({ID}, {Rule.Node.OtdihVKompanii.FF}, {Rule.Node.OtdihVKompanii.FS})";
                sqlExpression[8] = "INSERT INTO Reki(ID, FF, FS, FT) " +
                    $"values({ID}, {Rule.Node.Reki.FF}, {Rule.Node.Reki.FS}, {Rule.Node.Reki.FT})";
                sqlExpression[9] = "INSERT INTO SostoanieZdorovia(ID, FF, FS, FT) " +
                    $"values({ID}, {Rule.Node.SostoanieZdorovia.FF},{Rule.Node.SostoanieZdorovia.FS}, {Rule.Node.SostoanieZdorovia.FT})";
                sqlExpression[10] = "INSERT INTO Temp_Hight(ID, FF, FS) " +
                    $"values({ID}, {Rule.Node.Temp_Hight.FF}, {Rule.Node.Temp_Hight.FS})";
                sqlExpression[11] = "INSERT INTO Temp_Low(ID, FF, FS) " +
                    $"values({ID}, {Rule.Node.Temp_Low.FF}, {Rule.Node.Temp_Low.FS})";
                sqlExpression[12] = "INSERT INTO VoennaaTematika(ID, FF, FS) " +
                    $"values({ID}, {Rule.Node.VoennaaTematika.FF},{Rule.Node.VoennaaTematika.FS})";
                for(int i = 2; i < 13; ++i)
                {
                    command = new SqlCommand(sqlExpression[i], Connection);
                    Ex += "\n\t" + sqlExpression[i] + "try... ";
                    Connection.Open();
                    reader = command.ExecuteReader();
                    reader.Close();
                    Connection.Close();
                    Ex += "Done.";
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("NeedNewTables - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);

                Connection.Close();
                CreateTable(Connection);
            }
            Connection.Close();
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
        }

        public static List<RULE> SELECTallRules(SqlConnection Connection, bool flag = false, RULE Rule = default(RULE), List<RULE> ListNode = null)
        {
            string sqlExpression = null;
            SqlCommand command;
            RULE NodeList = new RULE();
            List<RULE> List = new List<RULE>();
            if (flag)
            {
                sqlExpression = CreateSELECTString(Rule);
            }
            else
            {
                sqlExpression = Properties.Resources.SelectAllString;
                //sqlExpression = Properties.Resources.SelectAllAlternative;
            }
            try
            {
                Connection.Open();
                command = new SqlCommand(sqlExpression, Connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        NodeList.ID = reader.GetInt32(0);
                        NodeList.Name = reader.GetString(1);
                        NodeList.Node.AktivniiOtdih.FF = reader.GetByte(2);
                        NodeList.Node.AktivniiOtdih.FS = reader.GetByte(3);
                        NodeList.Node.AktivniiOtdih.FT = reader.GetByte(4);
                        NodeList.Node.OtdihVKompanii.FF = reader.GetByte(5);
                        NodeList.Node.OtdihVKompanii.FS = reader.GetByte(6);
                        NodeList.Node.Prirodu = reader.GetByte(7);
                        NodeList.Node.OtdihNaPrirode = reader.GetByte(8);
                        NodeList.Node.Arhitectura.FF = reader.GetByte(9);
                        NodeList.Node.Arhitectura.FS = reader.GetByte(10);
                        NodeList.Node.BolshieGoroda.FF = reader.GetByte(11);
                        NodeList.Node.BolshieGoroda.FS = reader.GetByte(12);
                        NodeList.Node.BolshieGoroda.FT = reader.GetByte(13);
                        NodeList.Node.MalenkieGoroda.FF = reader.GetByte(14);
                        NodeList.Node.MalenkieGoroda.FS = reader.GetByte(15);
                        NodeList.Node.Dostoprimechatelnosti = reader.GetByte(16);
                        NodeList.Node.VoennaaTematika.FF = reader.GetByte(17);
                        NodeList.Node.VoennaaTematika.FS = reader.GetByte(18);
                        NodeList.Node.Reki.FF = reader.GetByte(19);
                        NodeList.Node.Reki.FS = reader.GetByte(20);
                        NodeList.Node.Reki.FT = reader.GetByte(21);
                        NodeList.Node.Gori.FF = reader.GetByte(22);
                        NodeList.Node.Gori.FS = reader.GetByte(23);
                        NodeList.Node.Gori.FT = reader.GetByte(24);
                        NodeList.Node.SostoanieZdorovia.FF = reader.GetByte(25);
                        NodeList.Node.SostoanieZdorovia.FS = reader.GetByte(26);
                        NodeList.Node.SostoanieZdorovia.FT = reader.GetByte(27);
                        NodeList.Node.Temp_Hight.FF = reader.GetByte(28);
                        NodeList.Node.Temp_Hight.FS = reader.GetByte(29);
                        NodeList.Node.Temp_Low.FF = reader.GetByte(30);
                        NodeList.Node.Temp_Low.FS = reader.GetByte(31);
                        NodeList.Node.Temp_Srednaa = reader.GetByte(32);
                        List.Add(NodeList);
                    }
                }

            }
            catch (SqlException se)
            {
                MessageBox.Show("SELECTallRules - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);

                Connection.Close();
                CreateTable(Connection);
            }
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            if(ListNode != null)
            {
                ListNode = List;
            }
            return List;
        }

        public static DataTable SELECTallRulesOnDataTable(SqlConnection Connection)
        {
            DataTable dt = new DataTable();
            SqlCommand command;
            try
            {
                Connection.Open();
                command = new SqlCommand(Properties.Resources.SelectAllString, Connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

            }
            catch (SqlException se)
            {
                MessageBox.Show("SELECTallRulesOnDataTable - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);

                Connection.Close();
                CreateTable(Connection);
            }
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            return dt;
        }

        public static List<RULE> UPDATEallRules(SqlConnection Connection, bool flag = false, RULE Rule = default(RULE), List<RULE> ListNode = default(List<RULE>))
        {
            string[] sqlExpression = new string[12];
            SqlCommand command;
            try
            {
                Connection.Open();
                SqlDataReader reader;
                if (flag)
                {
                    sqlExpression = CreateUPDATEString(Connection, Rule, 3);
                }
                else
                {
                    for(int i=0; i< ListNode.Count; ++i)
                    {
                        sqlExpression = CreateUPDATEString(Connection, ListNode[i], 3);

                    }
                }
                for(int i = 0; i < sqlExpression.Length; ++i)
                {
                    command = new SqlCommand(sqlExpression[i], Connection);
                    reader = command.ExecuteReader();
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show("NeedNewTables - " + "SELECT exeption: " + se.Number.ToString() + "\n" + se.Message);

                Connection.Close();
                CreateTable(Connection);
            }
            if (Connection.State != ConnectionState.Closed)
            {
                Connection.Close();
            }
            return ListNode;
        }
    }
}

