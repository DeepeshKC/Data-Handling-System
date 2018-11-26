using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Data_Handling_System
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> _hrData = new Dictionary<string, List<string>>();
        private Dictionary<string, string> _param = new Dictionary<string, string>();
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
            InitGrid();
            //radioButton1.Checked = true;
        }


        private static string[] SplitString(string text)
        {
            var splitString = new string[] {"[Params]","[Note]","[IntTimes]", "[IntNotes]",
                "[ExtraData]", "[LapNames]", "[Summary-123]",
                "[Summary-TH]", "[HRZones]", "[SwapTimes]", "[Trip]", "[HRData]"};

            var splittedText = text.Split(splitString, StringSplitOptions.RemoveEmptyEntries);

            return splittedText;
        }

        private static string[] SplitStringByEnter(string text)
        {
            return text.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
        }

        private string[] SplitStringBySpace(string text)
        {
            var formattedText = string.Join(" ", text.Split().Where(x => x != ""));
            return formattedText.Split(' ');
        }

        //to open the file
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {


                loadData();

            }
        }

        private void loadData()
        {
            _param = new Dictionary<string, string>();
            _hrData = new Dictionary<string, List<string>>();
            string text = File.ReadAllText(openFileDialog1.FileName);
            var splittedString = SplitString(text);

            var splittedParamsData = SplitStringByEnter(splittedString[0]);

            foreach (var data in splittedParamsData)
            {
                if (data != "\r")
                {
                    string[] parts = data.Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                    _param.Add(parts[0], parts[1]);
                }
            }

            // label for the header data 
            lblStartTime.Text = "Start Time" + _param["StartTime"];
            lblInterval.Text = "Interval" + _param["Interval"];
            lblMonitor.Text = "Monitor" + _param["Monitor"];
            lblSMode.Text = "S mode" + _param["SMode"];
            lblDate.Text = "Date" + _param["Date"];
            lblLength.Text = "Length" + _param["Length"];
            lblWeight.Text = "Weight" + _param["Weight"];

            List<string> cadence = new List<string>();
            List<string> altitude = new List<string>();
            List<string> heartRate = new List<string>();
            List<string> watt = new List<string>();
            List<string> speed = new List<string>();

            //adding data for datagrid
            var splittedHrData = SplitStringByEnter(splittedString[11]);
            foreach (var data in splittedHrData)
            {
                var value = SplitStringBySpace(data);

                if (value.Length >= 5)
                {
                    cadence.Add(value[0]);
                    altitude.Add(value[1]);
                    heartRate.Add(value[2]);
                    watt.Add(value[3]);
                    speed.Add(value[4]);

                    string[] hrData = new string[] { value[0], value[1], value[2], value[3], value[4] };
                    dataGridView1.Rows.Add(hrData);
                }
            }

            _hrData.Add("Cadence", cadence);
            _hrData.Add("Altitude", altitude);
            _hrData.Add("HeartRate", heartRate);
            _hrData.Add("Watt", watt);
            _hrData.Add("Speed", speed);
        }

        private void InitGrid()
        {
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Cadence";
            dataGridView1.Columns[1].Name = "Altitude";
            dataGridView1.Columns[2].Name = "Heart rate";
            dataGridView1.Columns[3].Name = "Power in watts";
            dataGridView1.Columns[4].Name = "Speed(Mile/hr)";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //to view overall graph
        private void viewGraphToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_hrData.Count < 1)
            {
                MessageBox.Show("Please select a file first");
            }
            else
            {
                Graph._hrData = _hrData;
                new Graph().Show();
            }
        }

        //to view individual graphs
        private void viewIndividualGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_hrData.Count < 1)
            {
                MessageBox.Show("Please select a file first");
            }
            else
            {
                IndividualGraph._hrData = _hrData;
                new IndividualGraph().Show();
            }

        }

        //to view summary data
        private void viewSummaryDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_hrData.Count < 1)
            {
                MessageBox.Show("Please select a file first");
            }
            else
            {
                SummaryView._hrData = _hrData;
                new SummaryView().Show();
            }
        }

        //to change speed unit and return the value in table
        private void CalculateSpeed(string type)
        {
            if (_hrData.Count > 0)
            {
                List<string> data = new List<string>();
                if (type == "mile")
                {
                    dataGridView1.Columns[4].Name = "Speed(Mile/hr)";

                    data.Clear();
                    for (int i = 0; i < _hrData["Cadence"].Count; i++)
                    {
                        string temp = (Convert.ToDouble(_hrData["Speed"][i]) * 1.60934).ToString();
                        data.Add(temp);
                    }

                    _hrData["Speed"] = data;

                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < _hrData["Cadence"].Count; i++)
                    {
                        string[] hrData = new string[] { _hrData["Cadence"][i], _hrData["Altitude"][i], _hrData["HeartRate"][i], _hrData["Watt"][i], _hrData["Speed"][i] };
                        dataGridView1.Rows.Add(hrData);
                    }
                }
                else
                {
                    dataGridView1.Columns[4].Name = "Speed(km/hr)";

                    data.Clear();
                    for (int i = 0; i < _hrData["Cadence"].Count; i++)
                    {
                        string temp = (Convert.ToDouble(_hrData["Speed"][i]) / 1.60934).ToString();
                        data.Add(temp);
                    }

                    _hrData["Speed"] = data;

                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < _hrData["Cadence"].Count; i++)
                    {
                        string[] hrData = new string[] { _hrData["Cadence"][i], _hrData["Altitude"][i], _hrData["HeartRate"][i], _hrData["Watt"][i], _hrData["Speed"][i] };
                        dataGridView1.Rows.Add(hrData);
                    }
                }
            }
        }

        //button to select km/hr
        private void button1_Click(object sender, EventArgs e)
        {
            if (_hrData.Count < 1)
            {
                MessageBox.Show("Please select a file first");
            }
            else
            {
                CalculateSpeed("km");
            }
        }

        //button to select miles/hr
        private void button2_Click(object sender, EventArgs e)
        {
            if (_hrData.Count < 1)
            {
                MessageBox.Show("Please select a file first");
            }
            else
            {
                count++;
                if (count > 1) CalculateSpeed("mile");
            }
        }
    }
}