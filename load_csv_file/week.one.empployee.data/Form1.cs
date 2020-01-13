using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week.one.empployee.data
{
    public partial class Form1 : Form
    {
        List<ManagerData> managers = new List<ManagerData>();
        List<DevelopersData> developers = new List<DevelopersData>();

        public Form1()
        {
            InitializeComponent();
        }
        //button to load three employee data files
        private void radioBtnLoad3_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string loadThree = openFileDialog1.FileName;


            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(loadThree);
            if (lines.Length > 0)
            {
                // first line to create header
                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(',');

                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                int loadTotalThree = 4;

                //for data
                for (int r = 1; r < loadTotalThree; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];

                    }

                    dt.Rows.Add(dr);
                }

            }

            if (dt.Rows.Count > 0)
            {
                dgvEmployeeData.DataSource = dt;
            }
        }

        //button to load five employee data files
        private void radioBtnLoad5_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string loadFive = openFileDialog1.FileName;


            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(loadFive);
            if (lines.Length > 0)
            {
                // first line to create header
                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(',');

                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                int loadTotalFive = 6;

                //for data
                for (int r = 1; r < loadTotalFive; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];

                    }

                    dt.Rows.Add(dr);
                }

            }

            if (dt.Rows.Count > 0)
            {
                dgvEmployeeData.DataSource = dt;
            }
        }

        //button to load all employee data files
        private void radioBtnLoadAll_CheckedChanged(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string loadAll = openFileDialog1.FileName;


            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(loadAll);
            if (lines.Length > 0)
            {
                // first line to create header
                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(',');

                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }


                //for data
                for (int r = 1; r < lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];

                    }

                    dt.Rows.Add(dr);
                }

            }

            if (dt.Rows.Count > 0)
            {
                dgvEmployeeData.DataSource = dt;
            }
        }
    }
}
