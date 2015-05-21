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
        List<TextBox> insertActiveTextBoxes = new List<TextBox>();
        List<TextBox> updateActiveTextBoxes = new List<TextBox>();
        List<TextBox> updateActiveConditionTextBoxes = new List<TextBox>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            setupViewDataTab();
            setupInsertDataTab();
            setupUpdateDataTab();
        }

        //View Data tab
        private void refreshDataButton_Click(object sender, EventArgs e)
        {
            refreshDataTables();
        }

        private void runStoredProcedureButton_Click(object sender, EventArgs e)
        {
            String comboBoxSelection = storedProcedureComboBox.SelectedValue.ToString();
            String textFieldInput = storedProcedureParameterTextBox.Text.ToString();
            string DBconnectionString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=HorseRacing;User ID=howtc;Password=sqlpasswordhowtc";


            switch (comboBoxSelection)
            {
                case "UncompletedRaces":
                    HorseRacingDataSetTableAdapters.UncompletedRacesTableAdapter uncompletedRacesTableAdapter = new HorseRacingDataSetTableAdapters.UncompletedRacesTableAdapter();
                    HorseRacingDataSet.UncompletedRacesDataTable uncompletedRacesData = uncompletedRacesTableAdapter.GetData();
                    storedProcedureResultsTableView.DataSource = uncompletedRacesData;
                    break;
                case "CompletedRaces":
                    HorseRacingDataSetTableAdapters.CompletedRacesTableAdapter completedRacesTableAdapter = new HorseRacingDataSetTableAdapters.CompletedRacesTableAdapter();
                    HorseRacingDataSet.CompletedRacesDataTable completedRacesData = completedRacesTableAdapter.GetData();
                    storedProcedureResultsTableView.DataSource = completedRacesData;
                    break;
                case "JockeysWithoutBets":
                    HorseRacingDataSetTableAdapters.JockeysWithoutBetsTableAdapter jockeysWithoutBetsAdaptor = new HorseRacingDataSetTableAdapters.JockeysWithoutBetsTableAdapter();
                    HorseRacingDataSet.JockeysWithoutBetsDataTable jockeysWithoutBetsData = jockeysWithoutBetsAdaptor.GetData();
                    storedProcedureResultsTableView.DataSource = jockeysWithoutBetsData;
                    break;
                case "JockeysWithBets":
                    HorseRacingDataSetTableAdapters.JockeysWithBetsTableAdapter jockeysWithBetsAdaptor = new HorseRacingDataSetTableAdapters.JockeysWithBetsTableAdapter();
                    HorseRacingDataSet.JockeysWithBetsDataTable jockeysWithBetsData = jockeysWithBetsAdaptor.GetData();
                    storedProcedureResultsTableView.DataSource = jockeysWithBetsData;
                    break;
                case "HorsesWithoutBets":
                    HorseRacingDataSetTableAdapters.HorsesWithoutBetsTableAdapter horsesWithoutBetsAdaptor = new HorseRacingDataSetTableAdapters.HorsesWithoutBetsTableAdapter();
                    HorseRacingDataSet.HorsesWithoutBetsDataTable horsesWithoutBetsData = horsesWithoutBetsAdaptor.GetData();
                    storedProcedureResultsTableView.DataSource = horsesWithoutBetsData;
                    break;
                case "HorsesWithBets":
                    HorseRacingDataSetTableAdapters.HorsesWithBetsTableAdapter horsesWithBetsAdaptor = new HorseRacingDataSetTableAdapters.HorsesWithBetsTableAdapter();
                    HorseRacingDataSet.HorsesWithBetsDataTable HorsesWithBetsData = horsesWithBetsAdaptor.GetData();
                    storedProcedureResultsTableView.DataSource = HorsesWithBetsData;
                    break;
                case "Top10Payouts":
                    HorseRacingDataSetTableAdapters.Top10PayoutsTableAdapter top10PayoutsAdaptor = new HorseRacingDataSetTableAdapters.Top10PayoutsTableAdapter();
                    HorseRacingDataSet.Top10PayoutsDataTable Top10PayoutsData = top10PayoutsAdaptor.GetData();
                    storedProcedureResultsTableView.DataSource = Top10PayoutsData;
                    break;
                case "Top10BetAmounts":
                    HorseRacingDataSetTableAdapters.Top10BetAmountsTableAdapter top10BetsAdaptor = new HorseRacingDataSetTableAdapters.Top10BetAmountsTableAdapter();
                    HorseRacingDataSet.Top10BetAmountsDataTable Top10BetsData = top10BetsAdaptor.GetData();
                    storedProcedureResultsTableView.DataSource = Top10BetsData;
                    break;
                case "Top10Jockeys":
                    HorseRacingDataSetTableAdapters.Top10JockeysTableAdapter top10JockeysAdapter = new HorseRacingDataSetTableAdapters.Top10JockeysTableAdapter();
                    HorseRacingDataSet.Top10JockeysDataTable Top10JockeysData = top10JockeysAdapter.GetData();
                    storedProcedureResultsTableView.DataSource = Top10JockeysData;
                    break;
                case "Top10Horses":
                    HorseRacingDataSetTableAdapters.Top10HorsesTableAdapter top10HorsesAdapter = new HorseRacingDataSetTableAdapters.Top10HorsesTableAdapter();
                    HorseRacingDataSet.Top10HorsesDataTable Top10HorsesData = top10HorsesAdapter.GetData();
                    storedProcedureResultsTableView.DataSource = Top10HorsesData;
                    break;
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
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string queryStatement = "EXEC dbo.ParticipantsByRaceName @RaceName = @name";
                        using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                        {
                            _cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = RemoveSpecialCharacters(textFieldInput);

                            DataTable participantsTable = new DataTable("Participants by Race Name");
                            SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                            try
                            {
                                _con.Open();
                                _dap.Fill(participantsTable);
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }

                            storedProcedureResultsTableView.DataSource = participantsTable;
                        }
                    }
                    break;
                case "TracksInState":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string queryStatement = "EXEC dbo.TracksInState @State = @state";
                        using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                        {
                            _cmd.Parameters.Add("@state", SqlDbType.VarChar, 2).Value = RemoveSpecialCharacters(textFieldInput);

                            DataTable tracksInStateTable = new DataTable("Tracks In State");
                            SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                            try
                            {
                                _con.Open();
                                _dap.Fill(tracksInStateTable);
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }

                            storedProcedureResultsTableView.DataSource = tracksInStateTable;
                        }
                    }
                    break;
                case "BetsByGamblerName":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string queryStatement = "EXEC dbo.BetsByGamblerName @GamblerName = @name";
                        using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                        {
                            _cmd.Parameters.Add("@name", SqlDbType.VarChar, 25).Value = RemoveSpecialCharacters(textFieldInput);

                            DataTable betsTable = new DataTable("Bets by Gambler Name");
                            SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                            try
                            {
                                _con.Open();
                                _dap.Fill(betsTable);
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }

                            storedProcedureResultsTableView.DataSource = betsTable;
                        }
                    }
                    break;
                case "ParticipantsByRaceID":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string queryStatement = "EXEC dbo.ParticipantsByRaceID @RaceID = @ID";
                        using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                        {
                            _cmd.Parameters.Add("@ID", SqlDbType.Int).Value = RemoveSpecialCharacters(textFieldInput);

                            DataTable participantsByIDTable = new DataTable("Participants by Race ID");
                            SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                            try
                            {
                                _con.Open();
                                _dap.Fill(participantsByIDTable);
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }

                            storedProcedureResultsTableView.DataSource = participantsByIDTable;
                        }
                    }
                    break;
                case "BetsByGamblerID":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string queryStatement = "EXEC dbo.BetsByGamblerID @GamblerID = @ID";
                        using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                        {
                            _cmd.Parameters.Add("@ID", SqlDbType.Int).Value = RemoveSpecialCharacters(textFieldInput);

                            DataTable betsFromGamlberIDTable = new DataTable("Bets by GamblerID");
                            SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                            try
                            {
                                _con.Open();
                                _dap.Fill(betsFromGamlberIDTable);
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }

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
                case "TracksInState":
                    storedProcedureParameterTextBox.Text = "Enter a state";
                    storedProcedureParameterTextBox.Enabled = true;
                    break;
                case "UncompletedRaces":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "CompletedRaces":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "JockeysWithoutBets":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "JockeysWithBets":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "HorsesWithoutBets":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "HorsesWithBets":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "AllHorses":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "AllJockeys":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "WinningHorses":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
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
                case "Top10Jockeys":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "Top10Horses":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "Top10BetAmouts":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                case "Top10Payouts":
                    storedProcedureParameterTextBox.Text = "No Parameters Required";
                    storedProcedureParameterTextBox.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        //Insert Data tab
        private void insertTableSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Label> attributeLabels = new List<Label>();
            attributeLabels.Add(insertAttribute1Label);
            attributeLabels.Add(insertAttribute2Label);
            attributeLabels.Add(insertAttribute3Label);
            attributeLabels.Add(insertAttribute4Label);
            attributeLabels.Add(insertAttribute5Label);
            attributeLabels.Add(insertAttribute6Label);
            attributeLabels.Add(insertAttribute7Label);
            attributeLabels.Add(insertAttribute8Label);

            List<TextBox> attributeTextBoxes = new List<TextBox>();
            attributeTextBoxes.Add(insertAttribute1TextBox);
            attributeTextBoxes.Add(insertAttribute2TextBox);
            attributeTextBoxes.Add(insertAttribute3TextBox);
            attributeTextBoxes.Add(insertAttribute4TextBox);
            attributeTextBoxes.Add(insertAttribute5TextBox);
            attributeTextBoxes.Add(insertAttribute6TextBox);
            attributeTextBoxes.Add(insertAttribute7TextBox);
            attributeTextBoxes.Add(insertAttribute8TextBox);

            for (int i = 0; i < attributeTextBoxes.Count; i++)
            {
                attributeTextBoxes[i].Text = "";
            }

            String selectedTable = insertTableSelectionComboBox.SelectedValue.ToString();
            insertActiveTextBoxes.Clear();

            switch (selectedTable)
            {
                case "Horses":
                    HorseRacingDataSetTableAdapters.HorsesTableAdapter horsesAdapter = new HorseRacingDataSetTableAdapters.HorsesTableAdapter();
                    HorseRacingDataSet.HorsesDataTable horsesData = horsesAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < horsesData.Columns.Count)
                        {
                            attributeLabels[i].Text = horsesData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            insertActiveTextBoxes.Add(attributeTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Jockeys":
                    HorseRacingDataSetTableAdapters.JockeysTableAdapter jockeysAdapter = new HorseRacingDataSetTableAdapters.JockeysTableAdapter();
                    HorseRacingDataSet.JockeysDataTable jockeysData = jockeysAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < jockeysData.Columns.Count)
                        {
                            attributeLabels[i].Text = jockeysData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            insertActiveTextBoxes.Add(attributeTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Races":
                    HorseRacingDataSetTableAdapters.RacesTableAdapter racesAdapter = new HorseRacingDataSetTableAdapters.RacesTableAdapter();
                    HorseRacingDataSet.RacesDataTable racesData = racesAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < racesData.Columns.Count)
                        {
                            attributeLabels[i].Text = racesData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            insertActiveTextBoxes.Add(attributeTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Tracks":
                    HorseRacingDataSetTableAdapters.TracksTableAdapter tracksAdapter = new HorseRacingDataSetTableAdapters.TracksTableAdapter();
                    HorseRacingDataSet.TracksDataTable tracksData = tracksAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < tracksData.Columns.Count)
                        {
                            attributeLabels[i].Text = tracksData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            insertActiveTextBoxes.Add(attributeTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Rides":
                    HorseRacingDataSetTableAdapters.RidesTableAdapter ridesAdapter = new HorseRacingDataSetTableAdapters.RidesTableAdapter();
                    HorseRacingDataSet.RidesDataTable ridesData = ridesAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < ridesData.Columns.Count)
                        {
                            attributeLabels[i].Text = ridesData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            insertActiveTextBoxes.Add(attributeTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Gamblers":
                    HorseRacingDataSetTableAdapters.GamblersTableAdapter gamblersAdapter = new HorseRacingDataSetTableAdapters.GamblersTableAdapter();
                    HorseRacingDataSet.GamblersDataTable gamblersData = gamblersAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < gamblersData.Columns.Count)
                        {
                            attributeLabels[i].Text = gamblersData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            insertActiveTextBoxes.Add(attributeTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Bets":
                    HorseRacingDataSetTableAdapters.BetsTableAdapter betsAdapter = new HorseRacingDataSetTableAdapters.BetsTableAdapter();
                    HorseRacingDataSet.BetsDataTable betsData = betsAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < betsData.Columns.Count)
                        {
                            attributeLabels[i].Text = betsData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            insertActiveTextBoxes.Add(attributeTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                default:
                    //do nothing
                    break;
            }


        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            String tableToInsertInto = insertTableSelectionComboBox.SelectedValue.ToString();
            string username = insertUsernameTextBox.Text;
            string password = insertPasswordTextBox.Text;
            string DBconnectionString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=HorseRacing;User ID=" + RemoveSpecialCharacters(username) + ";Password=" + RemoveSpecialCharacters(password);
            insertErrorLabel.Text = "";
            updateErrorLabel.Text = "";

            //Sync insert/update username & password text boxes for convenience
            updateUsernameTextBox.Text = username;
            updatePasswordTextBox.Text = password;

            switch (tableToInsertInto)
            {
                case "Horses":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string insertHorse = "INSERT INTO Horses (Name,Weight,Height,Date_Of_Birth,NumWins) VALUES (@name,@weight,@height,@DOB,@numWins)";

                        using (SqlCommand _cmd = new SqlCommand(insertHorse))
                        {
                            _cmd.Connection = _con;

                            _cmd.Parameters.Add("@name", SqlDbType.VarChar, 35).Value = RemoveSpecialCharacters(insertActiveTextBoxes[0].Text);
                            _cmd.Parameters.Add("@weight", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[1].Text);
                            _cmd.Parameters.Add("@height", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[2].Text);
                            _cmd.Parameters.Add("@DOB", SqlDbType.Date).Value = RemoveSpecialCharacters(insertActiveTextBoxes[3].Text);
                            _cmd.Parameters.Add("@numWins", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[4].Text);

                            try
                            {
                                _con.Open();
                                _cmd.ExecuteNonQuery();
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }
                        }
                    }
                    break;
                case "Jockeys":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string insertJockey = "INSERT INTO Jockeys (Jockey_ID,Name,Weight,Height,NumWins) VALUES (@ID,@name,@weight,@height,@numWins)";

                        using (SqlCommand _cmd = new SqlCommand(insertJockey))
                        {
                            _cmd.Connection = _con;

                            _cmd.Parameters.Add("@ID", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[0].Text);
                            _cmd.Parameters.Add("@name", SqlDbType.VarChar, 35).Value = RemoveSpecialCharacters(insertActiveTextBoxes[1].Text);
                            _cmd.Parameters.Add("@weight", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[2].Text);
                            _cmd.Parameters.Add("@height", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[3].Text);
                            _cmd.Parameters.Add("@numWins", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[4].Text);

                            try
                            {
                                _con.Open();
                                _cmd.ExecuteNonQuery();
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }
                        }
                    }
                    break;
                case "Races":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string insertRace = "INSERT INTO Races (Race_ID,Length,Date,Name,Win,Place,Show,Track_Name) VALUES (@ID,@length,@date,@name,@win,@place,@show,@trackName)";

                        using (SqlCommand _cmd = new SqlCommand(insertRace))
                        {
                            _cmd.Connection = _con;

                            _cmd.Parameters.Add("@ID", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[0].Text);
                            _cmd.Parameters.Add("@length", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[1].Text);
                            _cmd.Parameters.Add("@date", SqlDbType.Date).Value = RemoveSpecialCharacters(insertActiveTextBoxes[2].Text);
                            _cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = RemoveSpecialCharacters(insertActiveTextBoxes[3].Text);
                            _cmd.Parameters.Add("@win", SqlDbType.VarChar, 35).Value = RemoveSpecialCharacters(insertActiveTextBoxes[4].Text);
                            _cmd.Parameters.Add("@place", SqlDbType.VarChar, 35).Value = RemoveSpecialCharacters(insertActiveTextBoxes[5].Text);
                            _cmd.Parameters.Add("@show", SqlDbType.VarChar, 35).Value = RemoveSpecialCharacters(insertActiveTextBoxes[6].Text);
                            _cmd.Parameters.Add("@trackName", SqlDbType.VarChar, 20).Value = RemoveSpecialCharacters(insertActiveTextBoxes[7].Text);

                            try
                            {
                                _con.Open();
                                _cmd.ExecuteNonQuery();
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }
                        }
                    }
                    break;
                case "Rides":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string insertRide = "INSERT INTO Rides (Jockey_ID,Horse_Name,Race_ID) VALUES (@jockeyID,@horseName,@raceID)";

                        using (SqlCommand _cmd = new SqlCommand(insertRide))
                        {
                            _cmd.Connection = _con;

                            _cmd.Parameters.Add("@jockeyID", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[0].Text);
                            _cmd.Parameters.Add("@horseName", SqlDbType.VarChar, 35).Value = RemoveSpecialCharacters(insertActiveTextBoxes[1].Text);
                            _cmd.Parameters.Add("@raceID", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[2].Text);

                            try
                            {
                                _con.Open();
                                _cmd.ExecuteNonQuery();
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }
                        }
                    }
                    break;
                case "Tracks":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string insertTrack = "INSERT INTO Tracks (Name,City,State) VALUES (@name,@city,@state)";

                        using (SqlCommand _cmd = new SqlCommand(insertTrack))
                        {
                            _cmd.Connection = _con;

                            _cmd.Parameters.Add("@name", SqlDbType.VarChar, 20).Value = RemoveSpecialCharacters(insertActiveTextBoxes[0].Text);
                            _cmd.Parameters.Add("@city", SqlDbType.VarChar, 20).Value = RemoveSpecialCharacters(insertActiveTextBoxes[1].Text);
                            _cmd.Parameters.Add("@state", SqlDbType.VarChar, 2).Value = RemoveSpecialCharacters(insertActiveTextBoxes[2].Text);

                            try
                            {
                                _con.Open();
                                _cmd.ExecuteNonQuery();
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }
                        }
                    }
                    break;
                case "Gamblers":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string insertGambler = "INSERT INTO Gamblers (Gambler_ID,Name,Address,Phone,Email) VALUES (@ID,@name,@address,@phone,@email)";

                        using (SqlCommand _cmd = new SqlCommand(insertGambler))
                        {
                            _cmd.Connection = _con;

                            _cmd.Parameters.Add("@ID", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[0].Text);
                            _cmd.Parameters.Add("@name", SqlDbType.VarChar, 25).Value = RemoveSpecialCharacters(insertActiveTextBoxes[1].Text);
                            _cmd.Parameters.Add("@address", SqlDbType.VarChar, 60).Value = RemoveSpecialCharacters(insertActiveTextBoxes[2].Text);
                            _cmd.Parameters.Add("@phone", SqlDbType.Char, 12).Value = RemoveSpecialCharacters(insertActiveTextBoxes[3].Text);
                            _cmd.Parameters.Add("@email", SqlDbType.VarChar, 35).Value = RemoveSpecialCharacters(insertActiveTextBoxes[4].Text);

                            try
                            {
                                _con.Open();
                                _cmd.ExecuteNonQuery();
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }
                        }
                    }
                    break;
                case "Bets":
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string insertBet = "INSERT INTO Bets (Bet_ID,Amount,Condition,Horse_Name,Race_ID,Gambler_ID,Payout) VALUES (@ID,@amount,@condition,@horseName,@raceID,@gamblerID,@payout)";

                        using (SqlCommand _cmd = new SqlCommand(insertBet))
                        {
                            _cmd.Connection = _con;

                            _cmd.Parameters.Add("@ID", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[0].Text);
                            _cmd.Parameters.Add("@amount", SqlDbType.Money).Value = RemoveSpecialCharacters(insertActiveTextBoxes[1].Text);
                            _cmd.Parameters.Add("@condition", SqlDbType.VarChar, 50).Value = RemoveSpecialCharacters(insertActiveTextBoxes[2].Text);
                            _cmd.Parameters.Add("@horseName", SqlDbType.VarChar, 35).Value = RemoveSpecialCharacters(insertActiveTextBoxes[3].Text);
                            _cmd.Parameters.Add("@raceID", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[4].Text);
                            _cmd.Parameters.Add("@gamblerID", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[5].Text);
                            _cmd.Parameters.Add("@payout", SqlDbType.Int).Value = RemoveSpecialCharacters(insertActiveTextBoxes[6].Text);

                            try
                            {
                                _con.Open();
                                _cmd.ExecuteNonQuery();
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }
                        }
                    }
                    break;
                default:
                    using (SqlConnection _con = new SqlConnection(DBconnectionString))
                    {
                        string queryStatement = "INSERT INTO " + tableToInsertInto + "\nVALUES(";
                        for (int i = 0; i < insertActiveTextBoxes.Count; i++)
                        {
                            queryStatement += "'" + RemoveSpecialCharacters(insertActiveTextBoxes[i].Text) + "'";
                            if (i != insertActiveTextBoxes.Count - 1)
                            {
                                queryStatement += ", ";
                            }
                        }
                        queryStatement += ");";
                        using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                        {
                            try
                            {
                                _con.Open();
                                _cmd.ExecuteNonQuery();
                                _con.Close();
                            }
                            catch (SqlException exception)
                            {
                                handleSQLException(exception);
                            }
                        }
                    }
                    break;
            }
            refreshDataTables();
        }

        //Update Data tab
        private void updateTableSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Label> attributeLabels = new List<Label>();
            attributeLabels.Add(updateAttribute1Label);
            attributeLabels.Add(updateAttribute2Label);
            attributeLabels.Add(updateAttribute3Label);
            attributeLabels.Add(updateAttribute4Label);
            attributeLabels.Add(updateAttribute5Label);
            attributeLabels.Add(updateAttribute6Label);
            attributeLabels.Add(updateAttribute7Label);
            attributeLabels.Add(updateAttribute8Label);

            List<TextBox> attributeTextBoxes = new List<TextBox>();
            attributeTextBoxes.Add(updateAttribute1TextBox);
            attributeTextBoxes.Add(updateAttribute2TextBox);
            attributeTextBoxes.Add(updateAttribute3TextBox);
            attributeTextBoxes.Add(updateAttribute4TextBox);
            attributeTextBoxes.Add(updateAttribute5TextBox);
            attributeTextBoxes.Add(updateAttribute6TextBox);
            attributeTextBoxes.Add(updateAttribute7TextBox);
            attributeTextBoxes.Add(updateAttribute8TextBox);

            List<Label> attributeConditionLabels = new List<Label>();
            attributeConditionLabels.Add(updateAttribute1ConditionLabel);
            attributeConditionLabels.Add(updateAttribute2ConditionLabel);
            attributeConditionLabels.Add(updateAttribute3ConditionLabel);
            attributeConditionLabels.Add(updateAttribute4ConditionLabel);
            attributeConditionLabels.Add(updateAttribute5ConditionLabel);
            attributeConditionLabels.Add(updateAttribute6ConditionLabel);
            attributeConditionLabels.Add(updateAttribute7ConditionLabel);
            attributeConditionLabels.Add(updateAttribute8ConditionLabel);

            List<TextBox> attributeConditionTextBoxes = new List<TextBox>();
            attributeConditionTextBoxes.Add(updateAttribute1ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute2ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute3ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute4ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute5ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute6ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute7ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute8ConditionTextBox);

            for (int i = 0; i < attributeConditionTextBoxes.Count; i++) attributeConditionTextBoxes[i].Text = "";
            for (int i = 0; i < attributeTextBoxes.Count; i++) attributeTextBoxes[i].Text = "";

            String selectedTable = updateTableSelectionComboBox.SelectedValue.ToString();
            updateActiveTextBoxes.Clear();
            updateActiveConditionTextBoxes.Clear();

            switch (selectedTable)
            {
                case "Horses":
                    HorseRacingDataSetTableAdapters.HorsesTableAdapter horsesAdapter = new HorseRacingDataSetTableAdapters.HorsesTableAdapter();
                    HorseRacingDataSet.HorsesDataTable horsesData = horsesAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < horsesData.Columns.Count)
                        {
                            attributeLabels[i].Text = horsesData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            updateActiveTextBoxes.Add(attributeTextBoxes[i]);

                            attributeConditionLabels[i].Text = horsesData.Columns[i].ColumnName;
                            attributeConditionLabels[i].Visible = true;
                            attributeConditionTextBoxes[i].Visible = true;
                            updateActiveConditionTextBoxes.Add(attributeConditionTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                            attributeConditionLabels[i].Visible = false;
                            attributeConditionTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Jockeys":
                    HorseRacingDataSetTableAdapters.JockeysTableAdapter jockeysAdapter = new HorseRacingDataSetTableAdapters.JockeysTableAdapter();
                    HorseRacingDataSet.JockeysDataTable jockeysData = jockeysAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < jockeysData.Columns.Count)
                        {
                            attributeLabels[i].Text = jockeysData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            updateActiveTextBoxes.Add(attributeTextBoxes[i]);

                            attributeConditionLabels[i].Text = jockeysData.Columns[i].ColumnName;
                            attributeConditionLabels[i].Visible = true;
                            attributeConditionTextBoxes[i].Visible = true;
                            updateActiveConditionTextBoxes.Add(attributeConditionTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                            attributeConditionLabels[i].Visible = false;
                            attributeConditionTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Races":
                    HorseRacingDataSetTableAdapters.RacesTableAdapter racesAdapter = new HorseRacingDataSetTableAdapters.RacesTableAdapter();
                    HorseRacingDataSet.RacesDataTable racesData = racesAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < racesData.Columns.Count)
                        {
                            attributeLabels[i].Text = racesData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            updateActiveTextBoxes.Add(attributeTextBoxes[i]);

                            attributeConditionLabels[i].Text = racesData.Columns[i].ColumnName;
                            attributeConditionLabels[i].Visible = true;
                            attributeConditionTextBoxes[i].Visible = true;
                            updateActiveConditionTextBoxes.Add(attributeConditionTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                            attributeConditionLabels[i].Visible = false;
                            attributeConditionTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Tracks":
                    HorseRacingDataSetTableAdapters.TracksTableAdapter tracksAdapter = new HorseRacingDataSetTableAdapters.TracksTableAdapter();
                    HorseRacingDataSet.TracksDataTable tracksData = tracksAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < tracksData.Columns.Count)
                        {
                            attributeLabels[i].Text = tracksData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            updateActiveTextBoxes.Add(attributeTextBoxes[i]);

                            attributeConditionLabels[i].Text = tracksData.Columns[i].ColumnName;
                            attributeConditionLabels[i].Visible = true;
                            attributeConditionTextBoxes[i].Visible = true;
                            updateActiveConditionTextBoxes.Add(attributeConditionTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                            attributeConditionLabels[i].Visible = false;
                            attributeConditionTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Rides":
                    HorseRacingDataSetTableAdapters.RidesTableAdapter ridesAdapter = new HorseRacingDataSetTableAdapters.RidesTableAdapter();
                    HorseRacingDataSet.RidesDataTable ridesData = ridesAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < ridesData.Columns.Count)
                        {
                            attributeLabels[i].Text = ridesData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            updateActiveTextBoxes.Add(attributeTextBoxes[i]);

                            attributeConditionLabels[i].Text = ridesData.Columns[i].ColumnName;
                            attributeConditionLabels[i].Visible = true;
                            attributeConditionTextBoxes[i].Visible = true;
                            updateActiveConditionTextBoxes.Add(attributeConditionTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                            attributeConditionLabels[i].Visible = false;
                            attributeConditionTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Gamblers":
                    HorseRacingDataSetTableAdapters.GamblersTableAdapter gamblersAdapter = new HorseRacingDataSetTableAdapters.GamblersTableAdapter();
                    HorseRacingDataSet.GamblersDataTable gamblersData = gamblersAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < gamblersData.Columns.Count)
                        {
                            attributeLabels[i].Text = gamblersData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            updateActiveTextBoxes.Add(attributeTextBoxes[i]);

                            attributeConditionLabels[i].Text = gamblersData.Columns[i].ColumnName;
                            attributeConditionLabels[i].Visible = true;
                            attributeConditionTextBoxes[i].Visible = true;
                            updateActiveConditionTextBoxes.Add(attributeConditionTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                            attributeConditionLabels[i].Visible = false;
                            attributeConditionTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                case "Bets":
                    HorseRacingDataSetTableAdapters.BetsTableAdapter betsAdapter = new HorseRacingDataSetTableAdapters.BetsTableAdapter();
                    HorseRacingDataSet.BetsDataTable betsData = betsAdapter.GetData();

                    for (int i = 0; i < attributeLabels.Count; i++)
                    {
                        if (i < betsData.Columns.Count)
                        {
                            attributeLabels[i].Text = betsData.Columns[i].ColumnName;
                            attributeLabels[i].Visible = true;
                            attributeTextBoxes[i].Visible = true;
                            updateActiveTextBoxes.Add(attributeTextBoxes[i]);

                            attributeConditionLabels[i].Text = betsData.Columns[i].ColumnName;
                            attributeConditionLabels[i].Visible = true;
                            attributeConditionTextBoxes[i].Visible = true;
                            updateActiveConditionTextBoxes.Add(attributeConditionTextBoxes[i]);
                        }
                        else
                        {
                            attributeLabels[i].Visible = false;
                            attributeTextBoxes[i].Visible = false;
                            attributeConditionLabels[i].Visible = false;
                            attributeConditionTextBoxes[i].Visible = false;
                        }
                    }
                    break;
                default:
                    //do nothing
                    break;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            HorseRacingDataSetTableAdapters.BetsTableAdapter betsAdapter = new HorseRacingDataSetTableAdapters.BetsTableAdapter();
            HorseRacingDataSet.BetsDataTable betsData = betsAdapter.GetData();

            HorseRacingDataSetTableAdapters.GamblersTableAdapter gamblersAdapter = new HorseRacingDataSetTableAdapters.GamblersTableAdapter();
            HorseRacingDataSet.GamblersDataTable gamblersData = gamblersAdapter.GetData();

            HorseRacingDataSetTableAdapters.RidesTableAdapter ridesAdapter = new HorseRacingDataSetTableAdapters.RidesTableAdapter();
            HorseRacingDataSet.RidesDataTable ridesData = ridesAdapter.GetData();

            HorseRacingDataSetTableAdapters.TracksTableAdapter tracksAdapter = new HorseRacingDataSetTableAdapters.TracksTableAdapter();
            HorseRacingDataSet.TracksDataTable tracksData = tracksAdapter.GetData();

            HorseRacingDataSetTableAdapters.RacesTableAdapter racesAdapter = new HorseRacingDataSetTableAdapters.RacesTableAdapter();
            HorseRacingDataSet.RacesDataTable racesData = racesAdapter.GetData();

            HorseRacingDataSetTableAdapters.JockeysTableAdapter jockeysAdapter = new HorseRacingDataSetTableAdapters.JockeysTableAdapter();
            HorseRacingDataSet.JockeysDataTable jockeysData = jockeysAdapter.GetData();

            HorseRacingDataSetTableAdapters.HorsesTableAdapter horsesAdapter = new HorseRacingDataSetTableAdapters.HorsesTableAdapter();
            HorseRacingDataSet.HorsesDataTable horsesData = horsesAdapter.GetData();

            List<TextBox> attributeConditionTextBoxes = new List<TextBox>();
            attributeConditionTextBoxes.Add(updateAttribute1ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute2ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute3ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute4ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute5ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute6ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute7ConditionTextBox);
            attributeConditionTextBoxes.Add(updateAttribute8ConditionTextBox);

            string username = updateUsernameTextBox.Text;
            string password = updatePasswordTextBox.Text;
            string DBconnectionString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=HorseRacing;User ID=" + username + ";Password=" + password;
            String tableToInsertInto = updateTableSelectionComboBox.SelectedValue.ToString();
            insertErrorLabel.Text = "";
            updateErrorLabel.Text = "";

            //Sync insert/update username & password text boxes for convenience
            insertUsernameTextBox.Text = username;
            insertPasswordTextBox.Text = password;

            using (SqlConnection _con = new SqlConnection(DBconnectionString))
            {
                string queryStatement = "UPDATE " + tableToInsertInto + "\nSET";
                switch (tableToInsertInto)
                {
                    case "Bets":
                        for (int i = 0; i < updateActiveTextBoxes.Count; i++)
                        {
                            if (updateActiveTextBoxes[i].Text != "")
                            {
                                queryStatement += " " + betsData.Columns[i].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveTextBoxes[i].Text) + "',";
                            }
                        }
                        if (queryStatement.EndsWith(",")) queryStatement = queryStatement.Substring(0, queryStatement.Length - 1);
                        queryStatement += "\nWHERE";
                        for (int j = 0; j < updateActiveConditionTextBoxes.Count; j++)
                        {
                            if (updateActiveConditionTextBoxes[j].Text != "")
                            {
                                queryStatement += " " + betsData.Columns[j].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveConditionTextBoxes[j].Text) + "' AND";
                            }
                        }
                        break;
                    case "Gamblers":
                        for (int i = 0; i < updateActiveTextBoxes.Count; i++)
                        {
                            if (updateActiveTextBoxes[i].Text != "")
                            {
                                queryStatement += " " + gamblersData.Columns[i].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveTextBoxes[i].Text) + "',";
                            }
                        }
                        if (queryStatement.EndsWith(",")) queryStatement = queryStatement.Substring(0, queryStatement.Length - 1);
                        queryStatement += "\nWHERE";
                        for (int j = 0; j < updateActiveConditionTextBoxes.Count; j++)
                        {
                            if (updateActiveConditionTextBoxes[j].Text != "")
                            {
                                queryStatement += " " + gamblersData.Columns[j].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveConditionTextBoxes[j].Text) + "' AND";
                            }
                        }
                        break;
                    case "Rides":
                        for (int i = 0; i < updateActiveTextBoxes.Count; i++)
                        {
                            if (updateActiveTextBoxes[i].Text != "")
                            {
                                queryStatement += " " + ridesData.Columns[i].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveTextBoxes[i].Text) + "',";
                            }
                        }
                        if (queryStatement.EndsWith(",")) queryStatement = queryStatement.Substring(0, queryStatement.Length - 1);
                        queryStatement += "\nWHERE";
                        for (int j = 0; j < updateActiveConditionTextBoxes.Count; j++)
                        {
                            if (updateActiveConditionTextBoxes[j].Text != "")
                            {
                                queryStatement += " " + ridesData.Columns[j].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveConditionTextBoxes[j].Text) + "' AND";
                            }
                        }
                        break;
                    case "Tracks":
                        for (int i = 0; i < updateActiveTextBoxes.Count; i++)
                        {
                            if (updateActiveTextBoxes[i].Text != "")
                            {
                                queryStatement += " " + tracksData.Columns[i].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveTextBoxes[i].Text) + "',";
                            }
                        }
                        if (queryStatement.EndsWith(",")) queryStatement = queryStatement.Substring(0, queryStatement.Length - 1);
                        queryStatement += "\nWHERE";
                        for (int j = 0; j < updateActiveConditionTextBoxes.Count; j++)
                        {
                            if (updateActiveConditionTextBoxes[j].Text != "")
                            {
                                queryStatement += " " + tracksData.Columns[j].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveConditionTextBoxes[j].Text) + "' AND";
                            }
                        }
                        break;
                    case "Races":
                        for (int i = 0; i < updateActiveTextBoxes.Count; i++)
                        {
                            if (updateActiveTextBoxes[i].Text != "")
                            {
                                queryStatement += " " + racesData.Columns[i].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveTextBoxes[i].Text) + "',";
                            }
                        }
                        if (queryStatement.EndsWith(",")) queryStatement = queryStatement.Substring(0, queryStatement.Length - 1);
                        queryStatement += "\nWHERE";
                        for (int j = 0; j < updateActiveConditionTextBoxes.Count; j++)
                        {
                            if (updateActiveConditionTextBoxes[j].Text != "")
                            {
                                queryStatement += " " + racesData.Columns[j].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveConditionTextBoxes[j].Text) + "' AND";
                            }
                        }
                        break;
                    case "Jockeys":
                        for (int i = 0; i < updateActiveTextBoxes.Count; i++)
                        {
                            if (updateActiveTextBoxes[i].Text != "")
                            {
                                queryStatement += " " + jockeysData.Columns[i].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveTextBoxes[i].Text) + "',";
                            }
                        }
                        if (queryStatement.EndsWith(",")) queryStatement = queryStatement.Substring(0, queryStatement.Length - 1);
                        queryStatement += "\nWHERE";
                        for (int j = 0; j < updateActiveConditionTextBoxes.Count; j++)
                        {
                            if (updateActiveConditionTextBoxes[j].Text != "")
                            {
                                queryStatement += " " + jockeysData.Columns[j].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveConditionTextBoxes[j].Text) + "' AND";
                            }
                        }
                        break;
                    case "Horses":
                        for (int i = 0; i < updateActiveTextBoxes.Count; i++)
                        {
                            if (updateActiveTextBoxes[i].Text != "")
                            {
                                queryStatement += " " + horsesData.Columns[i].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveTextBoxes[i].Text) + "',";
                            }
                        }
                        if (queryStatement.EndsWith(",")) queryStatement = queryStatement.Substring(0, queryStatement.Length - 1);
                        queryStatement += "\nWHERE";
                        for (int j = 0; j < updateActiveConditionTextBoxes.Count; j++)
                        {
                            if (updateActiveConditionTextBoxes[j].Text != "")
                            {
                                queryStatement += " " + horsesData.Columns[j].ColumnName + "=" + "'" + RemoveSpecialCharacters(updateActiveConditionTextBoxes[j].Text) + "' AND";
                            }
                        }
                        break;
                    default:
                        break;
                }
                if (queryStatement.EndsWith("AND")) queryStatement = queryStatement.Substring(0, queryStatement.Length - 4);
                queryStatement += ";";
                using (SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    try
                    {
                        _con.Open();
                        _cmd.ExecuteNonQuery();
                        _con.Close();
                    }
                    catch (SqlException exception)
                    {
                        handleSQLException(exception);
                    }
                }
                refreshDataTables();
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
            dataSource.Add(new Language() { name = "Top 10 Jockeys", value = "Top10Jockeys" });
            dataSource.Add(new Language() { name = "Top 10 Horses", value = "Top10Horses" });
            dataSource.Add(new Language() { name = "Top 10 Bet Amounts", value = "Top10BetAmouts " });
            dataSource.Add(new Language() { name = "Top 10 Payouts", value = "Top10Payouts" });
            dataSource.Add(new Language() { name = "Horses with Bets Placed on Them", value = "HorsesWithBets" });
            dataSource.Add(new Language() { name = "Horses without Bets Place on Them", value = "HorsesWithoutBets" });
            dataSource.Add(new Language() { name = "Jockeys with Bets Placed on Them", value = "JockeysWithBets" });
            dataSource.Add(new Language() { name = "Jockeys without Bets Placed on Them", value = "JockeysWithoutBets" });
            dataSource.Add(new Language() { name = "Completed Races", value = "CompletedRaces" });
            dataSource.Add(new Language() { name = "Uncompleted Races", value = "UncompletedRaces" });
            dataSource.Add(new Language() { name = "Tracks in a Given State", value = "TracksInState" });



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

            insertActiveTextBoxes.Add(insertAttribute1TextBox);
            insertActiveTextBoxes.Add(insertAttribute2TextBox);
            insertActiveTextBoxes.Add(insertAttribute3TextBox);
            insertActiveTextBoxes.Add(insertAttribute4TextBox);
            insertActiveTextBoxes.Add(insertAttribute5TextBox);

            insertAttribute6Label.Visible = false;
            insertAttribute7Label.Visible = false;
            insertAttribute8Label.Visible = false;

            insertAttribute6TextBox.Visible = false;
            insertAttribute7TextBox.Visible = false;
            insertAttribute8TextBox.Visible = false;

            insertErrorLabel.Text = "";
            insertErrorLabel.MaximumSize = new Size(500, 300);
            insertErrorLabel.ForeColor = System.Drawing.Color.Red;
        }

        public void setupUpdateDataTab()
        {
            var dataSource = new List<Language>();
            dataSource.Add(new Language() { name = "Horses", value = "Horses" });
            dataSource.Add(new Language() { name = "Jockeys", value = "Jockeys" });
            dataSource.Add(new Language() { name = "Races", value = "Races" });
            dataSource.Add(new Language() { name = "Rides", value = "Rides" });
            dataSource.Add(new Language() { name = "Tracks", value = "Tracks" });
            dataSource.Add(new Language() { name = "Gamblers", value = "Gamblers" });
            dataSource.Add(new Language() { name = "Bets", value = "Bets" });

            updateTableSelectionComboBox.DataSource = dataSource;
            updateTableSelectionComboBox.DisplayMember = "name";
            updateTableSelectionComboBox.ValueMember = "value";
            updateTableSelectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            HorseRacingDataSetTableAdapters.HorsesTableAdapter updateHorsesAdapter = new HorseRacingDataSetTableAdapters.HorsesTableAdapter();
            HorseRacingDataSet.HorsesDataTable horsesData = updateHorsesAdapter.GetData();

            updateAttribute1Label.Text = horsesData.Columns[0].ColumnName;
            updateAttribute2Label.Text = horsesData.Columns[1].ColumnName;
            updateAttribute3Label.Text = horsesData.Columns[2].ColumnName;
            updateAttribute4Label.Text = horsesData.Columns[3].ColumnName;
            updateAttribute5Label.Text = horsesData.Columns[4].ColumnName;

            updateAttribute1ConditionLabel.Text = horsesData.Columns[0].ColumnName;
            updateAttribute2ConditionLabel.Text = horsesData.Columns[1].ColumnName;
            updateAttribute3ConditionLabel.Text = horsesData.Columns[2].ColumnName;
            updateAttribute4ConditionLabel.Text = horsesData.Columns[3].ColumnName;
            updateAttribute5ConditionLabel.Text = horsesData.Columns[4].ColumnName;

            this.updateActiveTextBoxes.Add(updateAttribute1TextBox);
            this.updateActiveTextBoxes.Add(updateAttribute2TextBox);
            this.updateActiveTextBoxes.Add(updateAttribute3TextBox);
            this.updateActiveTextBoxes.Add(updateAttribute4TextBox);
            this.updateActiveTextBoxes.Add(updateAttribute5TextBox);

            this.updateActiveConditionTextBoxes.Add(updateAttribute1ConditionTextBox);
            this.updateActiveConditionTextBoxes.Add(updateAttribute2ConditionTextBox);
            this.updateActiveConditionTextBoxes.Add(updateAttribute3ConditionTextBox);
            this.updateActiveConditionTextBoxes.Add(updateAttribute4ConditionTextBox);
            this.updateActiveConditionTextBoxes.Add(updateAttribute5ConditionTextBox);

            updateAttribute6Label.Visible = false;
            updateAttribute7Label.Visible = false;
            updateAttribute8Label.Visible = false;

            updateAttribute6TextBox.Visible = false;
            updateAttribute7TextBox.Visible = false;
            updateAttribute8TextBox.Visible = false;

            updateAttribute6ConditionLabel.Visible = false;
            updateAttribute7ConditionLabel.Visible = false;
            updateAttribute8ConditionLabel.Visible = false;

            updateAttribute6ConditionTextBox.Visible = false;
            updateAttribute7ConditionTextBox.Visible = false;
            updateAttribute8ConditionTextBox.Visible = false;

            updateErrorLabel.Text = "";
            updateErrorLabel.MaximumSize = new Size(500, 300);
            updateErrorLabel.ForeColor = System.Drawing.Color.Red;
        }

        public static object RemoveSpecialCharacters(string str)
        {
            if (str == "")
            {
                return DBNull.Value;
            }
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_' || c == ' ' || c == '/' || c == '@' || c == '-')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static string ParseErrorMessage(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if (c == '^')
                {
                    return sb.ToString();
                }
                sb.Append(c);

            }
            return sb.ToString();
        }

        private void handleSQLException(SqlException exception)
        {
            switch (exception.Number)
            {
                case 18456:
                    insertErrorLabel.Text = "Invalid username/password combination!";
                    updateErrorLabel.Text = "Invalid username/password combination!";
                    break;
                case 2627:
                    insertErrorLabel.Text = "Cannot insert duplicate element into table!";
                    updateErrorLabel.Text = "Cannot insert duplicate element into table!";
                    break;
                case 547:
                    insertErrorLabel.Text = "Invalid input! Violating Foreign Key constraints!";
                    updateErrorLabel.Text = "Invalid input! Violating Foreign Key constraints!";
                    break;
                case 102:
                    insertErrorLabel.Text = "Incorrect Syntax!";
                    updateErrorLabel.Text = "Incorrect Syntax!";
                    break;
                case 50000:
                    insertErrorLabel.Text = ParseErrorMessage(exception.Message);
                    updateErrorLabel.Text = ParseErrorMessage(exception.Message);
                    break;
                default:
                    insertErrorLabel.Text = "Exception Number: " + exception.Number;
                    updateErrorLabel.Text = "Exception Number: " + exception.Number;
                    break;
            }
        }

        private void refreshDataTables()
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


    }
    public class Language
    {
        public string name { get; set; }
        public string value { get; set; }
    }
}