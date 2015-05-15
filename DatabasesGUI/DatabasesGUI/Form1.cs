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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            setupViewDataTab();
            setupInsertDataTab();
        }

        private void refreshDataButton_Click(object sender, EventArgs e)
        {
            HorseRacingDataSetTableAdapters.HorsesTableAdapter horsesAdapter = new HorseRacingDataSetTableAdapters.HorsesTableAdapter();
            HorseRacingDataSet.HorsesDataTable horsesData = horsesAdapter.GetData();
            horsesTableView.DataSource = horsesData;

            HorseRacingDataSetTableAdapters.JockeysTableAdapter jockeysAdapter = new HorseRacingDataSetTableAdapters.JockeysTableAdapter();
            HorseRacingDataSet.JockeysDataTable jockeysData = jockeysAdapter.GetData();
            jockeysTableView.DataSource = jockeysData;

            HorseRacingDataSetTableAdapters.RacesTableAdapter racesAdapter = new HorseRacingDataSetTableAdapters.RacesTableAdapter();
            HorseRacingDataSet.RacesDataTable racesData = racesAdapter.GetData();
            racesTableView.DataSource = racesData;

            HorseRacingDataSetTableAdapters.TracksTableAdapter tracksAdapter = new HorseRacingDataSetTableAdapters.TracksTableAdapter();
            HorseRacingDataSet.TracksDataTable tracksData = tracksAdapter.GetData();
            tracksTableView.DataSource = tracksData;

            HorseRacingDataSetTableAdapters.RidesTableAdapter ridesAdapter = new HorseRacingDataSetTableAdapters.RidesTableAdapter();
            HorseRacingDataSet.RidesDataTable ridesData = ridesAdapter.GetData();
            ridesTableView.DataSource = ridesData;

            HorseRacingDataSetTableAdapters.GamblersTableAdapter gamblersAdapter = new HorseRacingDataSetTableAdapters.GamblersTableAdapter();
            HorseRacingDataSet.GamblersDataTable gamblersData = gamblersAdapter.GetData();
            gamblersTableView.DataSource = gamblersData;

            HorseRacingDataSetTableAdapters.BetsTableAdapter betsAdapter = new HorseRacingDataSetTableAdapters.BetsTableAdapter();
            HorseRacingDataSet.BetsDataTable betsData = betsAdapter.GetData();
            betsTableView.DataSource = betsData;
        }

        private void runStoredProcedureButton_Click(object sender, EventArgs e)
        {
            String comboBoxSelection = storedProcedureComboBox.SelectedValue.ToString();
            String textFieldInput = storedProcedureParameterTextBox.Text.ToString();
            string DBconnectionString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=HorseRacing;User ID=howtc;Password=sqlpasswordhowtc";


            switch (comboBoxSelection)
            {
                case "WinningHorses":
                    HorseRacingDataSetTableAdapters.WinningHorsesTableAdapter winningHorsesAdapter = new HorseRacingDataSetTableAdapters.WinningHorsesTableAdapter();
                    HorseRacingDataSet.WinningHorsesDataTable winningHorsesData = winningHorsesAdapter.GetData();
                    storedProcedureResultsTableView.DataSource = winningHorsesData;
                    break;
                case "AllHorses":
                    HorseRacingDataSetTableAdapters.AllHorsesTableAdapter allHorsesAdapter = new HorseRacingDataSetTableAdapters.AllHorsesTableAdapter();
                    HorseRacingDataSet.AllHorsesDataTable allHorsesData = allHorsesAdapter.GetData();
                    storedProcedureResultsTableView.DataSource = allHorsesData;
                    break;
                case "AllJockeys":
                    HorseRacingDataSetTableAdapters.AllJockeysTableAdapter allJockeysAdapter = new HorseRacingDataSetTableAdapters.AllJockeysTableAdapter();
                    HorseRacingDataSet.AllJockeysDataTable allJockeysData = allJockeysAdapter.GetData();
                    storedProcedureResultsTableView.DataSource = allJockeysData;
                    break;
                case "WinningJockeys":
                    HorseRacingDataSetTableAdapters.WinningJockeysTableAdapter winningJockeysAdapter = new HorseRacingDataSetTableAdapters.WinningJockeysTableAdapter();
                    HorseRacingDataSet.WinningJockeysDataTable winningJockeysData = winningJockeysAdapter.GetData();
                    storedProcedureResultsTableView.DataSource = winningJockeysData;
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

                            storedProcedureResultsTableView.DataSource = participantsTable;
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

                            storedProcedureResultsTableView.DataSource = betsTable;
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

                            storedProcedureResultsTableView.DataSource = participantsByIDTable;
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

                            storedProcedureResultsTableView.DataSource = betsFromGamlberIDTable;
                        }
                    }
                    break;
                default:
                    //dont do stuff
                    break;

            }

        }

        private void storedProcedureComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String value = storedProcedureComboBox.SelectedValue.ToString();
            switch (value)
            {
                case "AllHorses":
                case "AllJockeys":
                case "WinningHorses":
                case "WinningJockeys":
                    storedProcedureParameterTextBox.Text = "No parameters required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "ParticipantsByRaceID":
                    storedProcedureParameterTextBox.Text = "Enter a RaceID";
                    storedProcedureParameterTextBox.Enabled = true;
                    break;
                case "ParticipantsByRaceName":
                    storedProcedureParameterTextBox.Text = "Enter a RaceName";
                    storedProcedureParameterTextBox.Enabled = true;
                    break;
                case "BetsByGamblerID":
                    storedProcedureParameterTextBox.Text = "Enter a GamblerID";
                    storedProcedureParameterTextBox.Enabled = true;
                    break;
                case "BetsByGamblerName":
                    storedProcedureParameterTextBox.Text = "Enter a GamblerName";
                    storedProcedureParameterTextBox.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        //Helper methods

        private void setupViewDataTab()
        {
            //Setup dataGridView
            horsesTableView.ReadOnly = true;
            jockeysTableView.ReadOnly = true;
            racesTableView.ReadOnly = true;
            tracksTableView.ReadOnly = true;
            ridesTableView.ReadOnly = true;
            gamblersTableView.ReadOnly = true;
            betsTableView.ReadOnly = true;
            storedProcedureResultsTableView.ReadOnly = true;

            //Populate grid View
            HorseRacingDataSetTableAdapters.HorsesTableAdapter horsesAdapter = new HorseRacingDataSetTableAdapters.HorsesTableAdapter();
            HorseRacingDataSet.HorsesDataTable horsesData = horsesAdapter.GetData();
            horsesTableView.DataSource = horsesData;

            HorseRacingDataSetTableAdapters.JockeysTableAdapter jockeysAdapter = new HorseRacingDataSetTableAdapters.JockeysTableAdapter();
            HorseRacingDataSet.JockeysDataTable jockeysData = jockeysAdapter.GetData();
            jockeysTableView.DataSource = jockeysData;

            HorseRacingDataSetTableAdapters.RacesTableAdapter racesAdapter = new HorseRacingDataSetTableAdapters.RacesTableAdapter();
            HorseRacingDataSet.RacesDataTable racesData = racesAdapter.GetData();
            racesTableView.DataSource = racesData;

            HorseRacingDataSetTableAdapters.TracksTableAdapter tracksAdapter = new HorseRacingDataSetTableAdapters.TracksTableAdapter();
            HorseRacingDataSet.TracksDataTable tracksData = tracksAdapter.GetData();
            tracksTableView.DataSource = tracksData;

            HorseRacingDataSetTableAdapters.RidesTableAdapter ridesAdapter = new HorseRacingDataSetTableAdapters.RidesTableAdapter();
            HorseRacingDataSet.RidesDataTable ridesData = ridesAdapter.GetData();
            ridesTableView.DataSource = ridesData;

            HorseRacingDataSetTableAdapters.GamblersTableAdapter gamblersAdapter = new HorseRacingDataSetTableAdapters.GamblersTableAdapter();
            HorseRacingDataSet.GamblersDataTable gamblersData = gamblersAdapter.GetData();
            gamblersTableView.DataSource = gamblersData;

            HorseRacingDataSetTableAdapters.BetsTableAdapter betsAdapter = new HorseRacingDataSetTableAdapters.BetsTableAdapter();
            HorseRacingDataSet.BetsDataTable betsData = betsAdapter.GetData();
            betsTableView.DataSource = betsData;

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

            storedProcedureComboBox.DataSource = dataSource;
            storedProcedureComboBox.DisplayMember = "name";
            storedProcedureComboBox.ValueMember = "value";
            storedProcedureComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //Set default textBox options
            storedProcedureParameterTextBox.Text = "No parameters required";
            storedProcedureParameterTextBox.Enabled = false;
        }

        private void setupInsertDataTab()
        {
            var dataSource = new List<Language>();
            dataSource.Add(new Language() { name = "Horses", value = "Horses" });
            dataSource.Add(new Language() { name = "Jockeys", value = "Jockeys" });
            dataSource.Add(new Language() { name = "Races", value = "Races" });
            dataSource.Add(new Language() { name = "Rides", value = "Rides" });
            dataSource.Add(new Language() { name = "Tracks", value = "Tracks" });
            dataSource.Add(new Language() { name = "Gamblers", value = "Gamblers" });
            dataSource.Add(new Language() { name = "Bets", value = "Bets" });

            insertTableSelectionComboBox.DataSource = dataSource;
            insertTableSelectionComboBox.DisplayMember = "name";
            insertTableSelectionComboBox.ValueMember = "value";
            insertTableSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            HorseRacingDataSetTableAdapters.HorsesTableAdapter horsesAdapter = new HorseRacingDataSetTableAdapters.HorsesTableAdapter();
            HorseRacingDataSet.HorsesDataTable horsesData = horsesAdapter.GetData();

            insertAttribute1Label.Text = horsesData.Columns[0].ColumnName;
            insertAttribute2Label.Text = horsesData.Columns[1].ColumnName;
            insertAttribute3Label.Text = horsesData.Columns[2].ColumnName;
            insertAttribute4Label.Text = horsesData.Columns[3].ColumnName;
            insertAttribute5Label.Text = horsesData.Columns[4].ColumnName;

            insertAttribute6Label.Visible = false;
            insertAttribute7Label.Visible = false;
            insertAttribute8Label.Visible = false;

            insertAttribute6TextBox.Visible = false;
            insertAttribute7TextBox.Visible = false;
            insertAttribute8TextBox.Visible = false;
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