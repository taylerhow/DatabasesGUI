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

namespace DatabasesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Setup dataGridView
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            dataGridView3.ReadOnly = true;
            dataGridView4.ReadOnly = true;
            dataGridView5.ReadOnly = true;
            dataGridView6.ReadOnly = true;
            dataGridView7.ReadOnly = true;
            dataGridView8.ReadOnly = true;

            //Populate grid View
            HorseRacingDataSetTableAdapters.HorsesTableAdapter horsesAdapter = new HorseRacingDataSetTableAdapters.HorsesTableAdapter();
            HorseRacingDataSet.HorsesDataTable horsesData = horsesAdapter.GetData();
            dataGridView1.DataSource = horsesData;

            HorseRacingDataSetTableAdapters.JockeysTableAdapter jockeysAdapter = new HorseRacingDataSetTableAdapters.JockeysTableAdapter();
            HorseRacingDataSet.JockeysDataTable jockeysData = jockeysAdapter.GetData();
            dataGridView2.DataSource = jockeysData;

            HorseRacingDataSetTableAdapters.RacesTableAdapter racesAdapter = new HorseRacingDataSetTableAdapters.RacesTableAdapter();
            HorseRacingDataSet.RacesDataTable racesData = racesAdapter.GetData();
            dataGridView3.DataSource = racesData;

            HorseRacingDataSetTableAdapters.TracksTableAdapter tracksAdapter = new HorseRacingDataSetTableAdapters.TracksTableAdapter();
            HorseRacingDataSet.TracksDataTable tracksData = tracksAdapter.GetData();
            dataGridView4.DataSource = tracksData;

            HorseRacingDataSetTableAdapters.RidesTableAdapter ridesAdapter = new HorseRacingDataSetTableAdapters.RidesTableAdapter();
            HorseRacingDataSet.RidesDataTable ridesData = ridesAdapter.GetData();
            dataGridView5.DataSource = ridesData;

            HorseRacingDataSetTableAdapters.GamblersTableAdapter gamblersAdapter = new HorseRacingDataSetTableAdapters.GamblersTableAdapter();
            HorseRacingDataSet.GamblersDataTable gamblersData = gamblersAdapter.GetData();
            dataGridView6.DataSource = gamblersData;

            HorseRacingDataSetTableAdapters.BetsTableAdapter betsAdapter = new HorseRacingDataSetTableAdapters.BetsTableAdapter();
            HorseRacingDataSet.BetsDataTable betsData = betsAdapter.GetData();
            dataGridView7.DataSource = betsData;

            //Populate combobox options
            var dataSource = new List<Language>();
            dataSource.Add(new Language() { name = "Winning Horses", value = "WinningHorses" });
            dataSource.Add(new Language() { name = "All Horses", value = "AllHorses" });
            dataSource.Add(new Language() { name = "All Jockeys", value = "AllJockeys" });
            dataSource.Add(new Language() { name = "Winning Jockeys", value = "WinningJockeys" });
            dataSource.Add(new Language() { name = "Participants in race by race name", value = "ParticipantsByRaceName" });
            dataSource.Add(new Language() { name = "Bets by gambler name", value = "BetsByGamblerName" });
            dataSource.Add(new Language() { name = "Paricipants in race by RaceID", value = "ParticipantsByRaceID" });
            dataSource.Add(new Language() { name = "Bets by GamlberID", value = "BetsByGamblerID" });

            comboBox1.DataSource = dataSource;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "value";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            //Set default textBox options
            textBox1.Text = "No parameters required";
            textBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
            dataGridView2.Refresh();
            dataGridView3.Refresh();
            dataGridView4.Refresh();
            dataGridView5.Refresh();
            dataGridView6.Refresh();
            dataGridView7.Refresh();
            dataGridView8.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String comboBoxSelection = comboBox1.SelectedValue.ToString();
            String textFieldInput = textBox1.Text.ToString();
            string DBconnectionString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=HorseRacing;User ID=howtc;Password=sqlpasswordhowtc";


            switch (comboBoxSelection)
            {
                case "WinningHorses":
                    HorseRacingDataSetTableAdapters.WinningHorsesTableAdapter winningHorsesAdapter = new HorseRacingDataSetTableAdapters.WinningHorsesTableAdapter();
                    HorseRacingDataSet.WinningHorsesDataTable winningHorsesData = winningHorsesAdapter.GetData();
                    dataGridView8.DataSource = winningHorsesData;
                    break;
                case "AllHorses":
                    HorseRacingDataSetTableAdapters.AllHorsesTableAdapter allHorsesAdapter = new HorseRacingDataSetTableAdapters.AllHorsesTableAdapter();
                    HorseRacingDataSet.AllHorsesDataTable allHorsesData = allHorsesAdapter.GetData();
                    dataGridView8.DataSource = allHorsesData;
                    break;
                case "AllJockeys":
                    HorseRacingDataSetTableAdapters.AllJockeysTableAdapter allJockeysAdapter = new HorseRacingDataSetTableAdapters.AllJockeysTableAdapter();
                    HorseRacingDataSet.AllJockeysDataTable allJockeysData = allJockeysAdapter.GetData();
                    dataGridView8.DataSource = allJockeysData;
                    break;
                case "WinningJockeys":
                    HorseRacingDataSetTableAdapters.WinningJockeysTableAdapter winningJockeysAdapter = new HorseRacingDataSetTableAdapters.WinningJockeysTableAdapter();
                    HorseRacingDataSet.WinningJockeysDataTable winningJockeysData = winningJockeysAdapter.GetData();
                    dataGridView8.DataSource = winningJockeysData;
                    break;
                case "ParticipantsByRaceName":
                    using(SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string queryStatement = "EXEC dbo.ParticipantsByRaceName @RaceName = \""+textFieldInput+"\"";
                        using(SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                        {
                            DataTable participantsTable = new DataTable("Participants by Race Name");
                            SqlDataAdapter _dap = new SqlDataAdapter(_cmd);
        
                            _con.Open();
                            _dap.Fill(participantsTable);
                            _con.Close();

                            dataGridView8.DataSource = participantsTable;
                        }
                    }
                    break;
                case "BetsByGamblerName":
                    using(SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string queryStatement = "EXEC dbo.BetsByGamblerName @GamblerName = \""+textFieldInput+"\"";
                        using(SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                        {
                            DataTable betsTable = new DataTable("Bets by Gambler Name");
                            SqlDataAdapter _dap = new SqlDataAdapter(_cmd);
        
                            _con.Open();
                            _dap.Fill(betsTable);
                            _con.Close();

                            dataGridView8.DataSource = betsTable;
                        }
                    }
                    break;
                case "ParticipantsByRaceID":
                    using(SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string queryStatement = "EXEC dbo.ParticipantsByRaceID @RaceID = \""+textFieldInput+"\"";
                        using(SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                        {
                            DataTable participantsByIDTable = new DataTable("Participants by Race ID");
                            SqlDataAdapter _dap = new SqlDataAdapter(_cmd);
        
                            _con.Open();
                            _dap.Fill(participantsByIDTable);
                            _con.Close();

                            dataGridView8.DataSource = participantsByIDTable;
                        }
                    }
                    break;
                case "BetsByGamblerID":
                    using(SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string queryStatement = "EXEC dbo.BetsByGamblerID @GamblerID = \"" + textFieldInput + "\"";
                        using(SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                        {
                            DataTable betsFromGamlberIDTable = new DataTable("Bets by GamblerID");
                            SqlDataAdapter _dap = new SqlDataAdapter(_cmd);
        
                            _con.Open();
                            _dap.Fill(betsFromGamlberIDTable);
                            _con.Close();

                            dataGridView8.DataSource = betsFromGamlberIDTable;
                        }
                    }
                    break;
                default:
                    //dont do stuff
                    break;

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = comboBox1.SelectedValue.ToString();
            switch (value)
            {
                case "AllHorses":
                case "AllJockeys":
                case "WinningHorses":
                case "WinningJockeys":
                    textBox1.Text = "No parameters required";
                    textBox1.Enabled = false;
                    break;
                case "ParticipantsByRaceID":
                    textBox1.Text = "Enter a RaceID";
                    textBox1.Enabled = true;
                    break;
                case "ParticipantsByRaceName":
                    textBox1.Text = "Enter a RaceName";
                    textBox1.Enabled = true;
                    break;
                case "BetsByGamblerID":
                    textBox1.Text = "Enter a GamblerID";
                    textBox1.Enabled = true;
                    break;
                case "BetsByGamblerName":
                    textBox1.Text = "Enter a GamblerName";
                    textBox1.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
public class Language
{
    public string name { get; set; }
    public string value { get; set; }
}

//Access DB programatically
/*
            string connectionString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=HorseRacing;User ID=howtc;Password=sqlpasswordhowtc";

            using(SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatement = "SELECT TOP 5 * FROM dbo.Jockeys ORDER BY Jockey_ID";

                using(SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    DataTable jockeyTable = new DataTable("Top5Jockeys");

                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(jockeyTable);
                    _con.Close();

                    dataGridView8.DataSource = jockeyTable;
                }
            }
*/