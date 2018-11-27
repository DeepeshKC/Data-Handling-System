using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Data_Handling_System
{
    public partial class IndividualGraph : Form

    {
        public static Dictionary<string, List<string>> _hrData;

        public IndividualGraph()
        {
            InitializeComponent();
            this.CenterToScreen();
            plotGraph();
        }

        private void plotGraph()
        {

            GraphPane altitudePane = zedGraphControlAltitude.GraphPane;
            GraphPane heartRatePane = zedGraphControlHeart.GraphPane;
            GraphPane cadencePane = zedGraphControlCadence.GraphPane;
            GraphPane powerPane = zedGraphControlPower.GraphPane;
            GraphPane speedPane = zedGraphControlSpeed.GraphPane;


            // Set the Titles
            speedPane.Title = "Overview";
            speedPane.XAxis.Title = "Time in second";
            speedPane.YAxis.Title = "Speed";

            heartRatePane.Title = "Overview";
            heartRatePane.XAxis.Title = "Time in second";
            heartRatePane.YAxis.Title = "Heart Rate";

            cadencePane.Title = "Overview";
            cadencePane.XAxis.Title = "Time in second";
            cadencePane.YAxis.Title = "Cadence";

            powerPane.Title = "Overview";
            powerPane.XAxis.Title = "Time in second";
            powerPane.YAxis.Title = "Power";

            altitudePane.Title = "Overview";
            altitudePane.XAxis.Title = "Time in second";
            altitudePane.YAxis.Title = "Altitude";

            PointPairList cadencePairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();
            PointPairList heartPairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();
            PointPairList speedPairList = new PointPairList();



            for (int i = 0; i < _hrData["Cadence"].Count; i++)
            {
                cadencePairList.Add(i, Convert.ToInt16(_hrData["Cadence"][i]));
            }

            for (int i = 0; i < _hrData["Altitude"].Count; i++)
            {
                altitudePairList.Add(i, Convert.ToInt16(_hrData["Altitude"][i]));
            }

            for (int i = 0; i < _hrData["HeartRate"].Count; i++)
            {
                heartPairList.Add(i, Convert.ToInt16(_hrData["HeartRate"][i]));
            }

            for (int i = 0; i < _hrData["Watt"].Count; i++)
            {
                powerPairList.Add(i, Convert.ToInt16(_hrData["Watt"][i]));
            }

            for (int i = 0; i < _hrData["Speed"].Count; i++)
            {
                speedPairList.Add(i, Convert.ToInt16(_hrData["Speed"][i]));
            }

            LineItem cadence = cadencePane.AddCurve("Cadence",
                   cadencePairList, Color.Red, SymbolType.None);

            LineItem altitude = altitudePane.AddCurve("Altitude",
                  altitudePairList, Color.Blue, SymbolType.None);

            LineItem heart = heartRatePane.AddCurve("Heart",
                   heartPairList, Color.Black, SymbolType.None);

            LineItem power = powerPane.AddCurve("Power",
                  powerPairList, Color.Orange, SymbolType.None);

            LineItem speed = speedPane.AddCurve("Speed",
                  speedPairList, Color.Blue, SymbolType.None);

            zedGraphControlAltitude.AxisChange();
            zedGraphControlHeart.AxisChange();
            zedGraphControlPower.AxisChange();
            zedGraphControlCadence.AxisChange();
            zedGraphControlSpeed.AxisChange();
        }

        private void SetSize()
        {
            zedGraphControlAltitude.Location = new Point(0, 0);
            zedGraphControlAltitude.IsShowPointValues = true;
            zedGraphControlAltitude.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControlHeart.Location = new Point(0, 0);
            zedGraphControlHeart.IsShowPointValues = true;
            zedGraphControlHeart.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControlPower.Location = new Point(0, 0);
            zedGraphControlPower.IsShowPointValues = true;
            zedGraphControlPower.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControlCadence.Location = new Point(0, 0);
            zedGraphControlCadence.IsShowPointValues = true;
            zedGraphControlCadence.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControlSpeed.Location = new Point(0, 0);
            zedGraphControlSpeed.IsShowPointValues = true;
            zedGraphControlSpeed.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);
        }

        private void zedGraphControlAltitude_Load(object sender, EventArgs e)
        {

        }

        private void zedGraphControlSpeed_Load(object sender, EventArgs e)
        {

        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
