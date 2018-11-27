using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Handling_System
{
    public partial class SummaryView : Form
    {

        public static Dictionary<string, List<string>> _hrData;
        private Dictionary<string, string> _param = new Dictionary<string, string>();
        private String _endTime;

        string totalDistanceCovered = "";

        public SummaryView(Dictionary<string, string> _param, string endTime)
        {
            InitializeComponent();
            this.CenterToScreen();
            this._param = _param;
            _endTime = endTime;


            viewSummary();
        }

        private void viewSummary()
        {
            //data from summary class

            double startDate = TimeSpan.Parse(_param["StartTime"]).TotalSeconds;
            double endDate = TimeSpan.Parse(_endTime).TotalSeconds;
            double totalTime = endDate - startDate;


            string averageSpeed = Summary.FinDAverageSpeed(_hrData["Speed"]).ToString();
            string maxSpeed = Summary.FindMaxSpeed(_hrData["Cadence"]).ToString();


            totalDistanceCovered = (Convert.ToDouble(averageSpeed) * totalTime).ToString();

            string averageHeartRate = Summary.FindAverageHeartRate(_hrData["HeartRate"]).ToString();
            string maximumHeartRate = Summary.FindMaxHeartRate(_hrData["HeartRate"]).ToString();
            string minHeartRate = Summary.FindMinHeartRate(_hrData["HeartRate"]).ToString();

            string averagePower = Summary.FindAveragePower(_hrData["Watt"]).ToString();
            string maxPower = Summary.FindMaxPower(_hrData["Watt"]).ToString();

            string averageAltitude = Summary.FindAverageAltitude(_hrData["Altitude"]).ToString();


            //labels for summarized data
            lbltotaldistance.Text = "Total Distance Covered: " + totalDistanceCovered;
            lblavgspeed.Text = "Average Speed: " + averageSpeed;
            lblmaxspeed.Text = "Maximum Speed: " + maxSpeed;
            lblavgheart.Text = "Average Heart Rate: " + averageHeartRate;
            lblmaxheart.Text = "Maximum Heart Rate: " + maximumHeartRate;
            lblminheart.Text = "Minimum Heart Rate: " + minHeartRate;
            lblavgpower.Text = "Average Power: " + averagePower;
            lblmaxpower.Text = "Maximum Power: " + maxPower;
            lblavgalt.Text = "Average Altitude: " + averageAltitude;

        }

        private void SummaryView_Load(object sender, EventArgs e)
        {

        }
    }
}
