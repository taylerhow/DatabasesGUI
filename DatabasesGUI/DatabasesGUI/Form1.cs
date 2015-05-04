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
            HorseRacingDataSetTableAdapters.HorsesTableAdapter hta = new HorseRacingDataSetTableAdapters.HorsesTableAdapter();
            HorseRacingDataSet.HorsesDataTable horseData = hta.GetData();
            dataGridView1.DataSource = horseData;

            HorseRacingDataSetTableAdapters.JockeysTableAdapter jta = new HorseRacingDataSetTableAdapters.JockeysTableAdapter();
            HorseRacingDataSet.JockeysDataTable jockeyData = jta.GetData();
            dataGridView2.DataSource = jockeyData;

            HorseRacingDataSetTableAdapters.RacesTableAdapter rta = new HorseRacingDataSetTableAdapters.RacesTableAdapter();
            HorseRacingDataSet.RacesDataTable raceData = rta.GetData();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
