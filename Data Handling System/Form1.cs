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
using System.Globalization;
using System.Text.RegularExpressions;

namespace Data_Handling_System
{
 
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> _hrData = new Dictionary<string, List<string>>();
        private Dictionary<string, string> _param = new Dictionary<string, string>();
        private Dictionary<string, object> hrData = new Dictionary<string, object>();
        private int count = 0;
        private string endTime;
      

        private List<int> smode = new List<int>();


        public Form1()
        {
            InitializeComponent();
            InitGrid();
            this.CenterToScreen();
            dataGridView1.MultiSelect = true;
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
                if (result == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    string text = File.ReadAllText(openFileDialog1.FileName);
                    //Dictionary<string, object> hrData = new TableFiller().FillTable(text, dataGridView1);
                    hrData = new TableFiller().FillTable(text, dataGridView1);
                    _hrData = hrData.ToDictionary(k => k.Key, k => k.Value as List<string>);


                    var metricsCalculation = new AdvanceMetricsCalculation();

                    //advance metrics calculation
                    double np = metricsCalculation.CalculateNormalizedPower(hrData);
                    label3.Text = "Normalized power = " + Summary.RoundUp(np, 2);

                    double ftp = metricsCalculation.CalculateFunctionalThresholdPower(hrData);
                    label4.Text = "Training Stress Score = " + Summary.RoundUp(ftp, 2);

                    double ifa = metricsCalculation.CalculateIntensityFactor(hrData);
                    label5.Text = "Intensity Factor = " + Summary.RoundUp(ifa, 2);

                    double pb = metricsCalculation.CalculatePowerBalance(hrData);
                    label6.Text = "Power balance = " + Summary.RoundUp(pb, 2);

                    var param = hrData["params"] as Dictionary<string, string>;

                    //header file
                    lblStartTime.Text = lblStartTime.Text + "= " + param["StartTime"];
                    lblInterval.Text = lblInterval.Text + "= " + param["Interval"];
                    lblMonitor.Text = lblMonitor.Text + "= " + param["Monitor"];
                    lblSMode.Text = lblSMode.Text + "= " + param["SMode"];
                    lblDate.Text = lblDate.Text + "= " + Summary.ConvertToDate(param["Date"]);
                    lblLength.Text = lblLength.Text + "= " + param["Length"];
                    lblWeight.Text = lblWeight.Text + "= " + param["Weight"];


                    var sMode = param["SMode"];
                    for (int i = 0; i < sMode.Length; i++)
                    {
                        smode.Add((int)Char.GetNumericValue(param["SMode"][i]));
                    }

                    if (smode[0] == 0)
                    {
                        dataGridView1.Columns[0].Visible = false;
                    }
                    else if (smode[1] == 0)
                    {
                        dataGridView1.Columns[1].Visible = false;
                    }
                    else if (smode[2] == 0)
                    {
                        dataGridView1.Columns[2].Visible = false;
                    }
                    else if (smode[3] == 0)
                    {
                        dataGridView1.Columns[3].Visible = false;
                    }
                    else if (smode[4] == 0)
                    {
                        dataGridView1.Columns[4].Visible = false;
                    }

                    //dataGridView2.Rows.Clear();
                   // dataGridView2.Rows.Add(new TableFiller().FillDataInSummaryTable(_hrData, _hrData["params"] as Dictionary<string, string>, _hrData["endTime"] as string));








                    //_param = new Dictionary<string, string>();
                    //_hrData = new Dictionary<string, List<string>>();
                    //string text = File.ReadAllText(openFileDialog1.FileName);
                    //var splittedString = c.SplitString(text);

                    //var splittedParamsData = c.SplitStringByEnter(splittedString[0]);

                    //foreach (var data in splittedParamsData)
                    //{
                    //  if (data != "\r")
                    //  {
                    //    string[] parts = data.Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                    //    _param.Add(parts[0], parts[1]);
                    //  }
                    //}


                    //lblStartTime.Text = "Start Time" + "= " + _param["StartTime"];
                    //lblInterval.Text = "Interval" + "= " + Regex.Replace(_param["Interval"], @"\t|\n|\r", "") + " sec";
                    //lblMonitor.Text = "Monitor" + "= " + _param["Monitor"];
                    //lblSMode.Text = "SMode" + "= " + _param["SMode"];
                    //lblDate.Text = "Date" + "= " + Summary.ConvertToDate(_param["Date"]);
                    //lblLength.Text = "Length" + "= " + _param["Length"];
                    //lblWeight.Text = "Weight" + "= " + Regex.Replace(_param["Weight"], @"\t|\n|\r", "") + " kg";

                    //var sMode = _param["SMode"];
                    //for (int i = 0; i < sMode.Length; i++)
                    //{
                    //  smode.Add((int)Char.GetNumericValue(_param["SMode"][i]));
                    //}

                    //List<string> cadence = new List<string>();
                    //List<string> altitude = new List<string>();
                    //List<string> heartRate = new List<string>();
                    //List<string> watt = new List<string>();
                    //List<string> speed = new List<string>();
                    //List<string> time = new List<string>();

                    ////adding data for datagrid
                    //var splittedHrData = c.SplitStringByEnter(splittedString[11]);
                    //DateTime dateTime = DateTime.Parse(_param["StartTime"]);

                    //int temp = 0;
                    //foreach (var data in splittedHrData)
                    //{
                    //  temp++;
                    //  var value = c.SplitStringBySpace(data);

                    //  if (value.Length >= 5)
                    //  {
                    //    cadence.Add(value[0]);
                    //    altitude.Add(value[1]);
                    //    heartRate.Add(value[2]);
                    //    watt.Add(value[3]);
                    //    speed.Add(value[4]);

                    //    if (temp > 2) dateTime = dateTime.AddSeconds(Convert.ToInt32(_param["Interval"]));
                    //    endTime = dateTime.TimeOfDay.ToString();

                    //    List<string> hrData = new List<string>();
                    //    hrData.Add(value[0]);
                    //    hrData.Add(value[1]);
                    //    hrData.Add(value[2]);
                    //    hrData.Add(value[3]);
                    //    hrData.Add(value[4]);
                    //    hrData.Add(dateTime.TimeOfDay.ToString());

                    //    dataGridView1.Rows.Add(hrData.ToArray());
                    //  }
                    //}

                    //_hrData.Add("cadence", cadence);
                    //_hrData.Add("altitude", altitude);
                    //_hrData.Add("heartRate", heartRate);
                    //_hrData.Add("watt", watt);
                    //_hrData.Add("speed", speed);

                    //if (smode[0] == 0)
                    //{
                    //  dataGridView1.Columns[0].Visible = false;
                    //}
                    //else if (smode[1] == 0)
                    //{
                    //  dataGridView1.Columns[1].Visible = false;
                    //}
                    //else if (smode[2] == 0)
                    //{
                    //  dataGridView1.Columns[2].Visible = false;
                    //}
                    //else if (smode[3] == 0)
                    //{
                    //  dataGridView1.Columns[3].Visible = false;
                    //}
                    //else if (smode[4] == 0)
                    //{
                    //  dataGridView1.Columns[4].Visible = false;
                    //}

                    //dataGridView2.Rows.Clear();
                    //dataGridView2.Rows.Add(new TableFiller().FillDataInSumaryTable(_hrData, _param, endTime));

                }
            }
        }

        private void loadData()
        {
            Cursor.Current = Cursors.WaitCursor;
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
            DateTime date1 = new DateTime(Convert.ToInt64(_param["Date"]));
          
             
            // label for the header data 
            lblStartTime.Text = "Start Time" + "= " + _param["StartTime"];
            lblInterval.Text = "Interval" + "= " + Regex.Replace(_param["Interval"], @"\t|\n|\r", "") + " sec";
            lblMonitor.Text = "Monitor" + "= " + _param["Monitor"];
            lblSMode.Text = "SMode" + "= " + _param["SMode"];
            lblDate.Text = "Date" + "= " + ConvertToDate(_param["Date"]);
            lblLength.Text = "Length" + "= " + _param["Length"];
            lblWeight.Text = "Weight" + "= " + Regex.Replace(_param["Weight"], @"\t|\n|\r", "") + " kg";

            var sMode = _param["SMode"];
            for (int i = 0; i < sMode.Length; i++)
            {
                smode.Add((int)Char.GetNumericValue(_param["SMode"][i]));
            }

            List<string> cadence = new List<string>();
            List<string> altitude = new List<string>();
            List<string> heartRate = new List<string>();
            List<string> watt = new List<string>();
            List<string> speed = new List<string>();
            List<string> time = new List<string>();

            //adding data for data0grid
            var splittedHrData = SplitStringByEnter(splittedString[11]);
            DateTime dateTime = DateTime.Parse(_param["StartTime"]);

            int tmp = 0;

            foreach (var data in splittedHrData)
            {
                tmp++;
                var value = SplitStringBySpace(data);

                if (value.Length >= 5)
                {
                    cadence.Add(value[0]);
                    altitude.Add(value[1]);
                    heartRate.Add(value[2]);
                    watt.Add(value[3]);
                    speed.Add(value[4]);

                    if (tmp > 2) dateTime = dateTime.AddSeconds(Convert.ToInt32(_param["Interval"]));
                    endTime = dateTime.TimeOfDay.ToString();

                    string[] hrData = new string[] { value[0], value[1], value[2], value[3], value[4], dateTime.TimeOfDay.ToString() };
                    dataGridView1.Rows.Add(hrData);

                   
                }
            }

            _hrData.Add("Cadence", cadence);
            _hrData.Add("Altitude", altitude);
            _hrData.Add("HeartRate", heartRate);
            _hrData.Add("Watt", watt);
            _hrData.Add("Speed", speed);

            if (smode[0] == 0)
            {
                dataGridView1.Columns[0].Visible = false;
            }
            else if (smode[1] == 0)
            {
                dataGridView1.Columns[1].Visible = false;
            }
            else if (smode[2] == 0)
            {
                dataGridView1.Columns[2].Visible = false;
            }
            else if (smode[3] == 0)
            {
                dataGridView1.Columns[3].Visible = false;
            }
            else if (smode[4] == 0)
            {
                dataGridView1.Columns[4].Visible = false;
            }

        }

        private void InitGrid()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Cadence";
            dataGridView1.Columns[1].Name = "Altitude";
            dataGridView1.Columns[2].Name = "Heart rate";
            dataGridView1.Columns[3].Name = "Power in watts";
            dataGridView1.Columns[4].Name = "Speed(Miles/hr)";
            dataGridView1.Columns[5].Name = "Time";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //date conversion
        private string ConvertToDate(string date)
        {
            string year = "";
            string month = "";
            string day = "";
            for (int i = 0; i < 4; i++)
            {
                year = year + date[i];
            };
            for (int i = 4; i < 6; i++)
            {
                month = month + date[i];
            };
            for (int i = 6; i < 8; i++)
            {
                day = day + date[i];
            };
            string convertedDate = year + "-" + month + "-" + day;
            return convertedDate;
        }

        //to view overall graph
        private void viewGraphToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_hrData.Count <= 1)
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
            try
            {
                SummaryView._hrData = _hrData;
                new SummaryView(hrData["params"] as Dictionary<string, string>, hrData["endTime"] as string).Show();
            } catch(Exception ex)
            {
                MessageBox.Show("Please select a file first");
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
                    dataGridView1.Columns[4].Name = "Speed(Miles/hr)";

                    data.Clear();

                    for (int i = 0; i < _hrData["Cadence"].Count; i++)
                    {
                        string temp = (Convert.ToDouble(_hrData["Speed"][i]) * 1.60934).ToString();
                        data.Add(temp);
                    }

                    //_hrData["speed"].Clear();
                    _hrData["Speed"] = data;

                    dataGridView1.Rows.Clear();
                    DateTime dateTime = DateTime.Parse(_param["StartTime"]);
                    for (int i = 0; i < _hrData["Cadence"].Count; i++)
                    {
                        if (i > 0) dateTime = dateTime.AddSeconds(Convert.ToInt32(_param["Interval"]));
                        string[] hrData = new string[] { _hrData["Cadence"][i], _hrData["Altitude"][i], _hrData["HeartRate"][i], _hrData["Watt"][i], _hrData["Speed"][i], dateTime.TimeOfDay.ToString() };
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

                    //_hrData["speed"].Clear();
                    _hrData["Speed"] = data;

                    dataGridView1.Rows.Clear();

                    DateTime dateTime = DateTime.Parse(_param["StartTime"]);
                    for (int i = 0; i < _hrData["Cadence"].Count; i++)
                    {
                        if (i > 0) dateTime = dateTime.AddSeconds(Convert.ToInt32(_param["Interval"]));
                        string[] hrData = new string[] { _hrData["Cadence"][i], _hrData["Altitude"][i], _hrData["HeartRate"][i], _hrData["Watt"][i], _hrData["Speed"][i], dateTime.TimeOfDay.ToString() };
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowUnshared(object sender, DataGridViewRowEventArgs e)
        {

        }

        private Dictionary<string, object> data = new Dictionary<string, object>();
        List<string> listCadence = new List<string>();
        List<string> listAltitude = new List<string>();
        List<string> listHeartRate = new List<string>();
        List<string> listPower = new List<string>();
        List<string> listSpeed = new List<string>();
        List<string> listTime = new List<string>();

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (e.StateChanged != DataGridViewElementStates.Selected) return;
                int index = Convert.ToInt32(e.Row.Index.ToString());

                string cadence = dataGridView1.Rows[index].Cells[0].Value.ToString();
                listCadence.Add(cadence);

                string altitude = dataGridView1.Rows[index].Cells[1].Value.ToString();
                listAltitude.Add(altitude);

                string heartRate = dataGridView1.Rows[index].Cells[2].Value.ToString();
                listHeartRate.Add(heartRate);

                string power = dataGridView1.Rows[index].Cells[3].Value.ToString();
                listPower.Add(power);

                string speed = dataGridView1.Rows[index].Cells[4].Value.ToString();
                listSpeed.Add(speed);

                string time = dataGridView1.Rows[index].Cells[5].Value.ToString();
                listTime.Add(time);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                data.Add("cadence", listCadence);
                data.Add("altitude", listAltitude);
                data.Add("heartRate", listHeartRate);
                data.Add("watt", listPower);
                data.Add("speed", listSpeed);
                data.Add("time", listTime);

                var endTime = data["time"] as List<string>;
                int count = endTime.Count();
                Dictionary<string, string> _param = new Dictionary<string, string>();
                _param.Add("StartTime", endTime[0]);

                //dataGridView2.Rows.Clear();
                //dataGridView2.Rows.Add(new TableFiller().FillDataInSummaryTable(data, endTime[count - 1], _param));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please click on reset button first");
            }

            //data.Add("cadence", listCadence);
            //data.Add("altitude", listAltitude);
            ///data.Add("heartRate", listHeartRate);
            //data.Add("watt", listPower);
            //data.Add("speed", listSpeed);
            ///data.Add("time", listTime);

            //var endTime = data["time"] as List<string>;
            //int count = endTime.Count();
            //Dictionary<string, string> _param = new Dictionary<string, string>();
            //_param.Add("StartTime", endTime[0]);


            //SummaryView._hrData = data.ToDictionary(k => k.Key, k => k.Value as List<string>);
            //new SummaryView(_param, hrData["endTime"] as string).Show();


            //new SummaryView(data as Dictionary<string, string>, hrData["endTime"] as string).Show();
            //new SummaryView(hrData["params"] as Dictionary<string, string>, hrData["endTime"] as string).Show();

            //dataGridView2.Rows.Clear();
            //dataGridView2.Rows.Add(new TableFiller().FillDataInSumaryTable(data, endTime[count - 1], _param));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            data.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var data = _hrData.ToDictionary(k => k.Key, k => k.Value as object);
            new IntervalDetectionForm(data).Show();
        }

        Dictionary<string, object> list = new Dictionary<string, object>();
        private void button7_Click(object sender, EventArgs e)
        {
            string val = textBox1.Text;
            int value;
            if (int.TryParse(val, out value))
            {
                int count = 0;
                try
                {
                    count = ((List<string>)data["speed"]).Count;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select a row first");
                }

                int portion = count / Convert.ToInt32(val);

                var cadenceData = data["cadence"] as List<string>;
                var altitudeData = data["altitude"] as List<string>;
                var heartRateData = data["heartRate"] as List<string>;
                var wattData = data["watt"] as List<string>;
                var speedData = data["speed"] as List<string>;

                var newCadenceData = new List<string>();
                var newAltitudeData = new List<string>();
                var newHeartRateData = new List<string>();
                var newWattData = new List<string>();
                var newSpeedData = new List<string>();

                int num = 0;
                int portionNumber = 0;

                for (int i = 0; i < count; i++)
                {
                    num++;
                    newCadenceData.Add(cadenceData[i]);
                    newAltitudeData.Add(altitudeData[i]);
                    newHeartRateData.Add(heartRateData[i]);
                    newWattData.Add(wattData[i]);
                    newSpeedData.Add(speedData[i]);

                    if (num == portion)
                    {
                        num = 0;
                        portionNumber++;

                        var listData = new Dictionary<string, List<string>>();
                        listData.Add("cadence", newCadenceData);
                        listData.Add("altitude", newAltitudeData);
                        listData.Add("heartRate", newHeartRateData);
                        listData.Add("watt", newWattData);
                        listData.Add("speed", newSpeedData);

                        list.Add("data" + portionNumber, listData);

                        newCadenceData = new List<string>();
                        newAltitudeData = new List<string>();
                        newHeartRateData = new List<string>();
                        newWattData = new List<string>();
                        newSpeedData = new List<string>();
                    }

                }

                comboBox1.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    comboBox1.Items.Add("Portion " + (i + 1));
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number between 0 - 9");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex + 1;

            var a = list["data" + selectedIndex] as Dictionary<string, List<string>>;
            var b = a.ToDictionary(k => k.Key, k => k.Value as object);


            var data = new TableFiller().FillDataInSummaryTable(b, "19:12:15", null);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new FileCompare().Show();

        }
    }
}



