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
            this. CenterToScreen();
             plotGraph();
        }

        private void plotGraph()
        {

            GraphPane speedPane = zedGraphControlSpeed.GraphPane;
            GraphPane heartRatePane = zedGraphControlHeart.GraphPane;
            GraphPane cadencePane = zedGraphControlPower.GraphPane;
            GraphPane powerPane = zedGraphControlCadence.GraphPane;


            // Set the Titles
            speedPane.Title = "Overview";
            speedPane.XAxis.Title = "Time in second";
            speedPane.YAxis.Title = "Data";

            heartRatePane.Title = "Overview";
            heartRatePane.XAxis.Title = "Time in second";
            heartRatePane.YAxis.Title = "Data";

            cadencePane.Title = "Overview";
            cadencePane.XAxis.Title = "Time in second";
            cadencePane.YAxis.Title = "Data";

            powerPane.Title = "Overview";
            powerPane.XAxis.Title = "Time in second";
            powerPane.YAxis.Title = "Data";

            PointPairList cadencePairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();
            PointPairList heartPairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();


            for (int i = 0; i < _hrData["cadence"].Count; i++)
            {
                cadencePairList.Add(i, Convert.ToInt16(_hrData["cadence"][i]));
            }

            for (int i = 0; i < _hrData["altitude"].Count; i++)
            {
                altitudePairList.Add(i, Convert.ToInt16(_hrData["altitude"][i]));
            }

            for (int i = 0; i < _hrData["heartRate"].Count; i++)
            {
                heartPairList.Add(i, Convert.ToInt16(_hrData["heartRate"][i]));
            }

            for (int i = 0; i < _hrData["watt"].Count; i++)
            {
                powerPairList.Add(i, Convert.ToInt16(_hrData["watt"][i]));
            }

            LineItem cadence = cadencePane.AddCurve("Cadence",
                   cadencePairList, Color.Red, SymbolType.None);
            //cadence.Symbol.Fill = new Fill(new Color[] { Color.Blue, Color.Green, Color.Red });

            LineItem altitude = speedPane.AddCurve("Altitude",
                  altitudePairList, Color.Blue, SymbolType.None);

            LineItem heart = heartRatePane.AddCurve("Heart",
                   heartPairList, Color.Black, SymbolType.None);

            LineItem power = powerPane.AddCurve("Power",
                  powerPairList, Color.Orange, SymbolType.None);

            zedGraphControlSpeed.AxisChange();
            zedGraphControlHeart.AxisChange();
            zedGraphControlPower.AxisChange();
            zedGraphControlCadence.AxisChange();
        }

        private void SetSize()
        {
            zedGraphControlSpeed.Location = new Point(0, 0);
            zedGraphControlSpeed.IsShowPointValues = true;
            zedGraphControlSpeed.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControlHeart.Location = new Point(0, 0);
            zedGraphControlHeart.IsShowPointValues = true;
            zedGraphControlHeart.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControlPower.Location = new Point(0, 0);
            zedGraphControlPower.IsShowPointValues = true;
            zedGraphControlPower.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

            zedGraphControlCadence.Location = new Point(0, 0);
            zedGraphControlCadence.IsShowPointValues = true;
            zedGraphControlCadence.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);
        }

    }
}
