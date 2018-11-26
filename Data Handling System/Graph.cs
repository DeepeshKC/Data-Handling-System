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
    public partial class Graph : Form
    {
        public static Dictionary<string, List<string>> _hrData;

        public Graph()
        {
            InitializeComponent();
        }

        private void Graph_Load(object sender, EventArgs e)
        {
            plotGraph();
            SetSize();
        }

        private void plotGraph()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the Titles
            myPane.Title = "Overview";
            myPane.XAxis.Title = "Time in second";
            myPane.YAxis.Title = "Data";


            PointPairList cadencePairList = new PointPairList();
            PointPairList altitudePairList = new PointPairList();
            PointPairList heartPairList = new PointPairList();
            PointPairList powerPairList = new PointPairList();

          
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
                powerPairList.Add(i, Convert.ToInt16(_hrData["Speed"][i]));
            }
            LineItem cadence = myPane.AddCurve("Cadence",
                   cadencePairList, Color.Red, SymbolType.None);

            LineItem altitude = myPane.AddCurve("Altitude",
                  altitudePairList, Color.Blue, SymbolType.None);

            LineItem heart = myPane.AddCurve("Heart",
                   heartPairList, Color.Black, SymbolType.None);

            LineItem power = myPane.AddCurve("Power",
                  powerPairList, Color.Orange, SymbolType.None);

            LineItem speed = myPane.AddCurve("Speed",
                 powerPairList, Color.Orange, SymbolType.None);

            zedGraphControl1.AxisChange();
        }

        private void SetSize()
        {
            zedGraphControl1.Location = new Point(0, 0);
            zedGraphControl1.IsShowPointValues = true;
            zedGraphControl1.Size = new Size(this.ClientRectangle.Width - 20, this.ClientRectangle.Height - 50);

        }
    }
}
