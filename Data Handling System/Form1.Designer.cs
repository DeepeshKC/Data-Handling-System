namespace Data_Handling_System
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblSMode = new System.Windows.Forms.Label();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltotaldistance = new System.Windows.Forms.Label();
            this.lblavgspeed = new System.Windows.Forms.Label();
            this.lblmaxspeed = new System.Windows.Forms.Label();
            this.lblminspeed = new System.Windows.Forms.Label();
            this.lblavgheart = new System.Windows.Forms.Label();
            this.lblmaxheart = new System.Windows.Forms.Label();
            this.lblminheart = new System.Windows.Forms.Label();
            this.lblavgpower = new System.Windows.Forms.Label();
            this.lblmaxpower = new System.Windows.Forms.Label();
            this.lblavgalt = new System.Windows.Forms.Label();
            this.lblmaxalt = new System.Windows.Forms.Label();
            this.viewGraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.viewGraphToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(26, 265);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(74, 24);
            this.lblWeight.TabIndex = 13;
            this.lblWeight.Text = "Weight:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(27, 194);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 24);
            this.lblDate.TabIndex = 12;
            this.lblDate.Text = "Date:";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(27, 227);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(73, 24);
            this.lblLength.TabIndex = 10;
            this.lblLength.Text = "Length:";
            // 
            // lblSMode
            // 
            this.lblSMode.AutoSize = true;
            this.lblSMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMode.Location = new System.Drawing.Point(27, 121);
            this.lblSMode.Name = "lblSMode";
            this.lblSMode.Size = new System.Drawing.Size(84, 24);
            this.lblSMode.TabIndex = 11;
            this.lblSMode.Text = "SMODE:";
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitor.Location = new System.Drawing.Point(27, 86);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(78, 24);
            this.lblMonitor.TabIndex = 9;
            this.lblMonitor.Text = "Monitor:";
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.Location = new System.Drawing.Point(27, 158);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(74, 24);
            this.lblInterval.TabIndex = 8;
            this.lblInterval.Text = "Interval:";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(27, 52);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(99, 24);
            this.lblStartTime.TabIndex = 7;
            this.lblStartTime.Text = "Start Time:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(435, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 410);
            this.dataGridView1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Your Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Your Summarized Data:";
            // 
            // lbltotaldistance
            // 
            this.lbltotaldistance.AutoSize = true;
            this.lbltotaldistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotaldistance.Location = new System.Drawing.Point(26, 338);
            this.lbltotaldistance.Name = "lbltotaldistance";
            this.lbltotaldistance.Size = new System.Drawing.Size(243, 25);
            this.lbltotaldistance.TabIndex = 18;
            this.lbltotaldistance.Text = "Total Distance Covered:";
            // 
            // lblavgspeed
            // 
            this.lblavgspeed.AutoSize = true;
            this.lblavgspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavgspeed.Location = new System.Drawing.Point(26, 375);
            this.lblavgspeed.Name = "lblavgspeed";
            this.lblavgspeed.Size = new System.Drawing.Size(166, 25);
            this.lblavgspeed.TabIndex = 19;
            this.lblavgspeed.Text = "Average Speed:";
            // 
            // lblmaxspeed
            // 
            this.lblmaxspeed.AutoSize = true;
            this.lblmaxspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxspeed.Location = new System.Drawing.Point(26, 413);
            this.lblmaxspeed.Name = "lblmaxspeed";
            this.lblmaxspeed.Size = new System.Drawing.Size(178, 25);
            this.lblmaxspeed.TabIndex = 20;
            this.lblmaxspeed.Text = "Maximum Speed:";
            // 
            // lblminspeed
            // 
            this.lblminspeed.AutoSize = true;
            this.lblminspeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminspeed.Location = new System.Drawing.Point(26, 455);
            this.lblminspeed.Name = "lblminspeed";
            this.lblminspeed.Size = new System.Drawing.Size(172, 25);
            this.lblminspeed.TabIndex = 21;
            this.lblminspeed.Text = "Minimum Speed:";
            // 
            // lblavgheart
            // 
            this.lblavgheart.AutoSize = true;
            this.lblavgheart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavgheart.Location = new System.Drawing.Point(26, 491);
            this.lblavgheart.Name = "lblavgheart";
            this.lblavgheart.Size = new System.Drawing.Size(207, 25);
            this.lblavgheart.TabIndex = 22;
            this.lblavgheart.Text = "Average Heart Rate:";
            // 
            // lblmaxheart
            // 
            this.lblmaxheart.AutoSize = true;
            this.lblmaxheart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxheart.Location = new System.Drawing.Point(26, 530);
            this.lblmaxheart.Name = "lblmaxheart";
            this.lblmaxheart.Size = new System.Drawing.Size(219, 25);
            this.lblmaxheart.TabIndex = 23;
            this.lblmaxheart.Text = "Maximum Heart Rate:";
            // 
            // lblminheart
            // 
            this.lblminheart.AutoSize = true;
            this.lblminheart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblminheart.Location = new System.Drawing.Point(26, 567);
            this.lblminheart.Name = "lblminheart";
            this.lblminheart.Size = new System.Drawing.Size(213, 25);
            this.lblminheart.TabIndex = 24;
            this.lblminheart.Text = "Minimum Heart Rate:";
            // 
            // lblavgpower
            // 
            this.lblavgpower.AutoSize = true;
            this.lblavgpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavgpower.Location = new System.Drawing.Point(26, 603);
            this.lblavgpower.Name = "lblavgpower";
            this.lblavgpower.Size = new System.Drawing.Size(164, 25);
            this.lblavgpower.TabIndex = 25;
            this.lblavgpower.Text = "Average Power:";
            // 
            // lblmaxpower
            // 
            this.lblmaxpower.AutoSize = true;
            this.lblmaxpower.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxpower.Location = new System.Drawing.Point(26, 637);
            this.lblmaxpower.Name = "lblmaxpower";
            this.lblmaxpower.Size = new System.Drawing.Size(176, 25);
            this.lblmaxpower.TabIndex = 26;
            this.lblmaxpower.Text = "Maximum Power:";
            // 
            // lblavgalt
            // 
            this.lblavgalt.AutoSize = true;
            this.lblavgalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavgalt.Location = new System.Drawing.Point(26, 676);
            this.lblavgalt.Name = "lblavgalt";
            this.lblavgalt.Size = new System.Drawing.Size(176, 25);
            this.lblavgalt.TabIndex = 27;
            this.lblavgalt.Text = "Average Altitude:";
            // 
            // lblmaxalt
            // 
            this.lblmaxalt.AutoSize = true;
            this.lblmaxalt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaxalt.Location = new System.Drawing.Point(26, 715);
            this.lblmaxalt.Name = "lblmaxalt";
            this.lblmaxalt.Size = new System.Drawing.Size(188, 25);
            this.lblmaxalt.TabIndex = 28;
            this.lblmaxalt.Text = "Maximum Altitude:";
            // 
            // viewGraphToolStripMenuItem
            // 
            this.viewGraphToolStripMenuItem.Name = "viewGraphToolStripMenuItem";
            this.viewGraphToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewGraphToolStripMenuItem.Text = "View Graph";
            this.viewGraphToolStripMenuItem.Click += new System.EventHandler(this.viewGraphToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 749);
            this.Controls.Add(this.lblmaxalt);
            this.Controls.Add(this.lblavgalt);
            this.Controls.Add(this.lblmaxpower);
            this.Controls.Add(this.lblavgpower);
            this.Controls.Add(this.lblminheart);
            this.Controls.Add(this.lblmaxheart);
            this.Controls.Add(this.lblavgheart);
            this.Controls.Add(this.lblminspeed);
            this.Controls.Add(this.lblmaxspeed);
            this.Controls.Add(this.lblavgspeed);
            this.Controls.Add(this.lbltotaldistance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblSMode);
            this.Controls.Add(this.lblMonitor);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblSMode;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltotaldistance;
        private System.Windows.Forms.Label lblavgspeed;
        private System.Windows.Forms.Label lblmaxspeed;
        private System.Windows.Forms.Label lblminspeed;
        private System.Windows.Forms.Label lblavgheart;
        private System.Windows.Forms.Label lblmaxheart;
        private System.Windows.Forms.Label lblminheart;
        private System.Windows.Forms.Label lblavgpower;
        private System.Windows.Forms.Label lblmaxpower;
        private System.Windows.Forms.Label lblavgalt;
        private System.Windows.Forms.Label lblmaxalt;
        private System.Windows.Forms.ToolStripMenuItem viewGraphToolStripMenuItem;
    }
}

