namespace Data_Handling_System
{
    partial class IndividualGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.zedGraphControlSpeed = new ZedGraph.ZedGraphControl();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zedGraphControlPower = new ZedGraph.ZedGraphControl();
            this.zedGraphControlCadence = new ZedGraph.ZedGraphControl();
            this.zedGraphControlHeart = new ZedGraph.ZedGraphControl();
            this.zedGraphControlAltitude = new ZedGraph.ZedGraphControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.zedGraphControlSpeed);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.zedGraphControlPower);
            this.panel1.Controls.Add(this.zedGraphControlCadence);
            this.panel1.Controls.Add(this.zedGraphControlHeart);
            this.panel1.Controls.Add(this.zedGraphControlAltitude);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 784);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 1379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Graph of Speed";
            // 
            // zedGraphControlSpeed
            // 
            this.zedGraphControlSpeed.IsShowPointValues = false;
            this.zedGraphControlSpeed.Location = new System.Drawing.Point(16, 1406);
            this.zedGraphControlSpeed.Name = "zedGraphControlSpeed";
            this.zedGraphControlSpeed.PointValueFormat = "G";
            this.zedGraphControlSpeed.Size = new System.Drawing.Size(937, 379);
            this.zedGraphControlSpeed.TabIndex = 11;
            this.zedGraphControlSpeed.Load += new System.EventHandler(this.zedGraphControlSpeed_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 1040);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Graph of Power";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 706);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Graph of Cadence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Graph of Altitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Graph of Heart Rate";
            // 
            // zedGraphControlPower
            // 
            this.zedGraphControlPower.IsShowPointValues = false;
            this.zedGraphControlPower.Location = new System.Drawing.Point(3, 746);
            this.zedGraphControlPower.Name = "zedGraphControlPower";
            this.zedGraphControlPower.PointValueFormat = "G";
            this.zedGraphControlPower.Size = new System.Drawing.Size(950, 256);
            this.zedGraphControlPower.TabIndex = 6;
            // 
            // zedGraphControlCadence
            // 
            this.zedGraphControlCadence.IsShowPointValues = false;
            this.zedGraphControlCadence.Location = new System.Drawing.Point(-21, 1067);
            this.zedGraphControlCadence.Name = "zedGraphControlCadence";
            this.zedGraphControlCadence.PointValueFormat = "G";
            this.zedGraphControlCadence.Size = new System.Drawing.Size(974, 299);
            this.zedGraphControlCadence.TabIndex = 5;
            // 
            // zedGraphControlHeart
            // 
            this.zedGraphControlHeart.IsShowPointValues = false;
            this.zedGraphControlHeart.Location = new System.Drawing.Point(27, 405);
            this.zedGraphControlHeart.Name = "zedGraphControlHeart";
            this.zedGraphControlHeart.PointValueFormat = "G";
            this.zedGraphControlHeart.Size = new System.Drawing.Size(950, 275);
            this.zedGraphControlHeart.TabIndex = 4;
            // 
            // zedGraphControlAltitude
            // 
            this.zedGraphControlAltitude.IsShowPointValues = false;
            this.zedGraphControlAltitude.Location = new System.Drawing.Point(27, 66);
            this.zedGraphControlAltitude.Name = "zedGraphControlAltitude";
            this.zedGraphControlAltitude.PointValueFormat = "G";
            this.zedGraphControlAltitude.Size = new System.Drawing.Size(935, 273);
            this.zedGraphControlAltitude.TabIndex = 3;
            this.zedGraphControlAltitude.Load += new System.EventHandler(this.zedGraphControlAltitude_Load);
            // 
            // IndividualGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 749);
            this.Controls.Add(this.panel1);
            this.Name = "IndividualGraph";
            this.Text = "IndividualGraph";
            this.Load += new System.EventHandler(this.IndividualGraph_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zedGraphControlPower;
        private ZedGraph.ZedGraphControl zedGraphControlCadence;
        private ZedGraph.ZedGraphControl zedGraphControlHeart;
        private ZedGraph.ZedGraphControl zedGraphControlAltitude;
        private System.Windows.Forms.Label label5;
        private ZedGraph.ZedGraphControl zedGraphControlSpeed;
    }
}