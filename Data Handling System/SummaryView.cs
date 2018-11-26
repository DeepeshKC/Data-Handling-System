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

        //        public SummaryView()
        //        {
        //            InitializeComponent();
        //            this.CenterToScreen();

        //            viewSummary();
        //        }

        //        ////method to fetch the calculations from summary class and fill the text area
        //        //public void viewSummary(String unit)
        //        //{
        //        //    Summary s = new Summary(heart, speed, speed_mile, cadence, altitude, power, timee);
        //        //    lbltotaldistance.Text = "Total Distance Covered: " + s.FindTotalDistanceKm;
        //        //    string totalDistanceKm = s.TotalDistance();
        //        //    string totalMile = s.TotalDistanceMile();
        //        //    string avgSpeed = s.AverageSpeed();
        //        //    string maxSpeed = s.MaxSpeed();
        //        //    string avgSpeedMile = s.AverageSpeedMile();
        //        //    string maxSpeedMile = s.MaxSpeedMile();
        //        //    string avgHeartRate = s.AverageHeartRate();
        //        //    string minHeartRate = s.MinHeartRate();
        //        //    string maxHeartRate = s.MaxHeartRate();
        //        //    string avgPower = s.AveragePower();
        //        //    string avgAlt = s.AverageAltitude();
        //        //    string maxPower = s.maxPower();

        //        //    if (unit.Equals("km/hr"))
        //        //    {
        //        //        List<string> summary = new List<string>();
        //        //        summary.Add(totalDistanceKm);
        //        //        summary.Add(avgSpeed);
        //        //        summary.Add(maxSpeed);
        //        //        summary.Add(avgHeartRate);
        //        //        summary.Add(maxHeartRate);
        //        //        summary.Add(minHeartRate);
        //        //        summary.Add(avgPower);
        //        //        summary.Add(avgAlt);
        //        //        summary.Add(maxPower);
        //        //        summary.Add(avgAlt);

        //        //        foreach (string val in summary)
        //        //        {

        //        //            txtSummary.Text = txtSummary.Text + val + Environment.NewLine;

        //        //            summary2.Text = summary2.Text + val + Environment.NewLine;


        //        //        }
        //        //        foreach (string val in summary)
        //        //        {


        //        //            summary2.Text = summary2.Text + val + Environment.NewLine;

        //        //        }


        //        //    }
        //        //    else if (unit.Equals("miles/hr"))
        //        //    {
        //        //        List<string> summary = new List<string>();
        //        //        summary.Add(totalMile);
        //        //        summary.Add(avgSpeedMile);
        //        //        summary.Add(maxSpeedMile);
        //        //        summary.Add(avgHeartRate);
        //        //        summary.Add(maxHeartRate);
        //        //        summary.Add(minHeartRate);
        //        //        summary.Add(avgPower);
        //        //        summary.Add(maxPower);
        //        //        summary.Add(avgAlt);

        //        //        foreach (string val in summary)
        //        //        {

        //        //            txtSummary.Text = txtSummary.Text + val + Environment.NewLine;

        //        //            summary2.Text = summary2.Text + val + Environment.NewLine;


        //        //        }
        //        //        foreach (string val in summary)
        //        //        {



        //        //            summary2.Text = summary2.Text + val + Environment.NewLine;



        //        //        }
        //        //    }
        //        //}

        //        private void viewSummary()
        //        {
        //            //data from summary class
        //            string totalDistanceCovered = Summary.FindSum(_hrData["Cadence"]).ToString();


        //            string averageSpeed = Summary.FindAverage(_hrData["Cadence"]).ToString();
        //            string maxSpeed = Summary.FindMax(_hrData["Cadence"]).ToString();
        //            string minSpeed = Summary.FindMin(_hrData["Cadence"]).ToString();

        //            string averageHeartRate = Summary.FindAverageHeartRate(_hrData["HeartRate"]).ToString();
        //            string maximumHeartRate = Summary.FindMaxHeartRate(_hrData["HeartRate"]).ToString();
        //            string minHeartRate = Summary.FindMinHeartRate(_hrData["HeartRate"]).ToString();

        //            string averagePower = Summary.FindAverage(_hrData["Watt"]).ToString();
        //            string maxPower = Summary.FindMax(_hrData["Watt"]).ToString();

        //            string averageAltitude = Summary.FindAverage(_hrData["Altitude"]).ToString();
        //            string maximumAltitude = Summary.FindAverage(_hrData["Altitude"]).ToString();

        //            //labels for summarized data
        //            lbltotaldistance.Text = "Total Distance Covered: " + totalDistanceCovered;
        //            lblavgspeed.Text = "Average Speed: " + averageSpeed;
        //            lblmaxspeed.Text = "Maximum Speed: " + maxSpeed;
        //            lblminspeed.Text = "Minimum Speed: " + minSpeed;
        //            lblavgheart.Text = "Average Heart Rate: " + averageHeartRate;
        //            lblmaxheart.Text = "Maximim Heart Rate: " + maximumHeartRate;
        //            lblminheart.Text = "Minimum Heart Rate: " + minHeartRate;
        //            lblavgpower.Text = " Average Power: " + averagePower;
        //            lblmaxpower.Text = "Maximum Power: " + maxPower;
        //            lblavgalt.Text = "Average Altitude: " + averageAltitude;
        //            lblmaxalt.Text = "Maximum Altitude: " + maximumAltitude;
        //        }

        private void SummaryView_Load(object sender, EventArgs e)
        {

        }
    }
}
//    }
//}
