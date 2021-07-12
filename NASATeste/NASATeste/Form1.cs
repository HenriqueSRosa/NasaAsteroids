using NASATeste.Model;
using NASATeste.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NASATeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            GetAsteroids ga = new GetAsteroids();

            string dateFromMonth = "";
            string dateToMonth = "";
            string dateFromDay = "";
            string dateToDay = "";

            if(dateFrom.Value > dateTo.Value)
            {
                MessageBox.Show("A data de início deve ser menor ou igual que a de fim", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dateFrom.Value.Month < 10)
            {
                dateFromMonth = "0" + dateFrom.Value.Month.ToString();
            }
            else
            {
                dateFromMonth = dateFrom.Value.Month.ToString();
            }

            if (dateTo.Value.Month < 10)
            {
                dateToMonth = "0" + dateFrom.Value.Month.ToString();
            }
            else
            {
                dateToMonth = dateFrom.Value.Month.ToString();
            }

            if (dateFrom.Value.Day < 10)
            {
                dateFromDay = "0" + dateFrom.Value.Day.ToString();
            }
            else
            {
                dateFromDay = dateFrom.Value.Day.ToString();
            }

            if (dateTo.Value.Day < 10)
            {
                dateToDay = "0" + dateTo.Value.Day.ToString();
            }
            else
            {
                dateToDay = dateTo.Value.Day.ToString();
            }

            string startDate = dateFrom.Value.Year.ToString() + "-" + dateFromMonth + "-" + dateFromDay;
            string endDate = dateTo.Value.Year.ToString() + "-" + dateToMonth + "-" + dateToDay;

            if (cboMetrics.Text == "Metros")
            {
                dataGridAsteroids.Columns[2].Visible = true;
                dataGridAsteroids.Columns[3].Visible = true;
                dataGridAsteroids.Columns[4].Visible = false;
                dataGridAsteroids.Columns[5].Visible = false;
                dataGridAsteroids.Columns[6].Visible = false;
                dataGridAsteroids.Columns[7].Visible = false;
            }
            else if (cboMetrics.Text == "Milhas")
            {
                dataGridAsteroids.Columns[2].Visible = false;
                dataGridAsteroids.Columns[3].Visible = false;
                dataGridAsteroids.Columns[4].Visible = true;
                dataGridAsteroids.Columns[5].Visible = true;
                dataGridAsteroids.Columns[6].Visible = false;
                dataGridAsteroids.Columns[7].Visible = false;
            }
            else if (cboMetrics.Text == "Quilômetros")
            {
                dataGridAsteroids.Columns[2].Visible = false;
                dataGridAsteroids.Columns[3].Visible = false;
                dataGridAsteroids.Columns[4].Visible = false;
                dataGridAsteroids.Columns[5].Visible = false;
                dataGridAsteroids.Columns[6].Visible = true;
                dataGridAsteroids.Columns[7].Visible = true;
            }


            NEO asteroids = ga.getAsteroids(startDate, endDate);

            string isHazardous = "";
            if(asteroids != null)
            {
                foreach (var dates in asteroids.near_earth_objects.Values)
                {
                    foreach (var asteroid in dates)
                    {
                        if (asteroid.is_potentially_hazardous_asteroid)
                        {
                            isHazardous = "Sim";
                        }
                        else
                        {
                            isHazardous = "Não";
                        }
                        dataGridAsteroids.Rows.Add(asteroid.name, isHazardous, asteroid.estimated_diameter.meters.estimated_diameter_min, asteroid.estimated_diameter.meters.estimated_diameter_max,
                        asteroid.estimated_diameter.miles.estimated_diameter_min, asteroid.estimated_diameter.miles.estimated_diameter_max, asteroid.estimated_diameter.kilometers.estimated_diameter_min,
                        asteroid.estimated_diameter.kilometers.estimated_diameter_max, asteroid.close_approach_data[0].relative_velocity.kilometers_per_hour,
                        asteroid.close_approach_data[0].close_approach_date);
                    }

                }

                if (cboHazardous.Text.ToString() != "Todos")
                {
                    foreach (DataGridViewRow row in dataGridAsteroids.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (row.Cells[1].Value.ToString() == cboHazardous.Text.ToString())
                            {
                                row.Visible = true;
                            }
                            else
                            {
                                row.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            cboMetrics.SelectedItem = "Metros";
            dateFrom.Value = Convert.ToDateTime("2021/07/03");
            dateTo.Value = Convert.ToDateTime("2021/07/10");
            cboHazardous.SelectedItem = "Todos";

            btnFilter.PerformClick();
        }

        #region NãoUsado
        private void tableObjects_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTo_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
