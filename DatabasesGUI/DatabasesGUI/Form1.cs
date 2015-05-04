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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //HorseRacingDataSetTableAdapters.HorsesTableAdapter hta = new HorseRacingDataSetTableAdapters.HorsesTableAdapter();

            //HorseRacingDataSet.HorsesDataTable data = hta.GetData();

            //dataGridView1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HorseRacingDataSetTableAdapters.WinningHorsesTableAdapter winningHorsesAdapter = new HorseRacingDataSetTableAdapters.WinningHorsesTableAdapter();
            HorseRacingDataSet.WinningHorsesDataTable winningHorsesData = winningHorsesAdapter.GetData();
            dataGridView8.DataSource = winningHorsesData;

            String x = comboBox1.SelectedValue.ToString();
            switch (x)
            {
                case "WinningHorses":
                    //do stuff
                    break;
                case "BetsFromGamblerName":
                    //do stuff
                    break;
                default:    
                    //dont do stuff
                    break;

            }

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
            dataSource.Add(new Language() { name = "Participants in race by race name", value = "Participants" });
            dataSource.Add(new Language() { name = "Bets by gambler name", value = "BetsFromGamblerName" });
            dataSource.Add(new Language() { name = "Paricipants in race by RaceID", value = "" });
            dataSource.Add(new Language() { name = "Bets by GamlberID", value = "" });

            comboBox1.DataSource = dataSource;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "value";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=titan.csse.rose-hulman.edu;Initial Catalog=HorseRacing;User ID=howtc;Password=sqlpasswordhowtc";

            using(SqlConnection _con = new SqlConnection(connectionString))
            {
                string queryStatement = "SELECT TOP 5 * FROM dbo.Jockeys ORDER BY Jockey_ID";

                using(SqlCommand _cmd = new SqlCommand(queryStatement, _con))
                {
                    DataTable customerTable = new DataTable("Top5Customers");

                    SqlDataAdapter _dap = new SqlDataAdapter(_cmd);

                    _con.Open();
                    _dap.Fill(customerTable);
                    _con.Close();

                    dataGridView1.DataSource = customerTable;
                }
            }
        }
    }
}
public class Language
{
    public string name { get; set; }
    public string value { get; set; }
}
