using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dataSource = new List<Language>();
            dataSource.Add(new Language() { name = "Winning Horses", value = "1" });
            dataSource.Add(new Language() { name = "All Horses", value = "2" });
            dataSource.Add(new Language() { name = "All Jockeys", value = "3" });
            dataSource.Add(new Language() { name = "Winning Jockeys", value = "4" });
            dataSource.Add(new Language() { name = "Participants in race by race name", value = "5" });
            dataSource.Add(new Language() { name = "Bets by gambler name", value = "6" });
            dataSource.Add(new Language() { name = "Paricipants in race by RaceID", value = "7" });
            dataSource.Add(new Language() { name = "Bets by GamlberID", value = "8" });

            comboBox1.DataSource = dataSource;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "value";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            var dataSource = new List<Language>();
            dataSource.Add(new Language() {name = "Winning Horses", value = "1"});
            dataSource.Add(new Language() {name = "All Horses", value = "2"});
            dataSource.Add(new Language() { name = "All Jockeys", value = "3" });
            dataSource.Add(new Language() { name = "Winning Jockeys", value = "4" });
            dataSource.Add(new Language() { name = "Participants in race by race name", value = "5" });
            dataSource.Add(new Language() { name = "Bets by gambler name", value = "6" });
            dataSource.Add(new Language() { name = "Paricipants in race by RaceID", value = "7" });
            dataSource.Add(new Language() { name = "Bets by GamlberID", value = "8" });

            comboBox1.DataSource = dataSource;
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "value";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
             
        }
    }
}
public class Language
{
    public string name { get; set; }
    public string value { get; set; }
}
