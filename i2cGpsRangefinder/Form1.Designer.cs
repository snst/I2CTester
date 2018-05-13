namespace i2cGpsRangefinder
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
            this.btnRangefinder = new System.Windows.Forms.Button();
            this.btnGps = new System.Windows.Forms.Button();
            this.txtRangerfinderRegs = new System.Windows.Forms.TextBox();
            this.txtRangefinderDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGpsStatus = new System.Windows.Forms.TextBox();
            this.txtGpsLat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGpsLon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGpsSpeed = new System.Windows.Forms.TextBox();
            this.txtGpsCourse = new System.Windows.Forms.TextBox();
            this.txtGpsAltitude = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGpsStatus = new System.Windows.Forms.Button();
            this.btnGpsLat = new System.Windows.Forms.Button();
            this.btnGpsSpeed = new System.Windows.Forms.Button();
            this.btnGpsCourse = new System.Windows.Forms.Button();
            this.btnGpsLon = new System.Windows.Forms.Button();
            this.btnGpsAltitude = new System.Windows.Forms.Button();
            this.txtPackets = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGpsPackets = new System.Windows.Forms.Button();
            this.txtGpsSats = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGps2d = new System.Windows.Forms.CheckBox();
            this.cbGps3d = new System.Windows.Forms.CheckBox();
            this.btnGpsPing = new System.Windows.Forms.Button();
            this.txtGpsPing = new System.Windows.Forms.TextBox();
            this.comboComPorts = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRangefinder
            // 
            this.btnRangefinder.Location = new System.Drawing.Point(12, 26);
            this.btnRangefinder.Name = "btnRangefinder";
            this.btnRangefinder.Size = new System.Drawing.Size(75, 24);
            this.btnRangefinder.TabIndex = 0;
            this.btnRangefinder.Text = "Rangefinder";
            this.btnRangefinder.UseVisualStyleBackColor = true;
            this.btnRangefinder.Click += new System.EventHandler(this.btnRangefinder_Click);
            // 
            // btnGps
            // 
            this.btnGps.Location = new System.Drawing.Point(11, 73);
            this.btnGps.Name = "btnGps";
            this.btnGps.Size = new System.Drawing.Size(76, 24);
            this.btnGps.TabIndex = 1;
            this.btnGps.Text = "GPS";
            this.btnGps.UseVisualStyleBackColor = true;
            this.btnGps.Click += new System.EventHandler(this.btnGps_Click);
            // 
            // txtRangerfinderRegs
            // 
            this.txtRangerfinderRegs.Location = new System.Drawing.Point(100, 29);
            this.txtRangerfinderRegs.Name = "txtRangerfinderRegs";
            this.txtRangerfinderRegs.Size = new System.Drawing.Size(100, 20);
            this.txtRangerfinderRegs.TabIndex = 2;
            // 
            // txtRangefinderDistance
            // 
            this.txtRangefinderDistance.Location = new System.Drawing.Point(206, 29);
            this.txtRangefinderDistance.Name = "txtRangefinderDistance";
            this.txtRangefinderDistance.Size = new System.Drawing.Size(66, 20);
            this.txtRangefinderDistance.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            // 
            // txtGpsStatus
            // 
            this.txtGpsStatus.Location = new System.Drawing.Point(117, 75);
            this.txtGpsStatus.Name = "txtGpsStatus";
            this.txtGpsStatus.Size = new System.Drawing.Size(34, 20);
            this.txtGpsStatus.TabIndex = 5;
            // 
            // txtGpsLat
            // 
            this.txtGpsLat.Location = new System.Drawing.Point(117, 114);
            this.txtGpsLat.Name = "txtGpsLat";
            this.txtGpsLat.Size = new System.Drawing.Size(100, 20);
            this.txtGpsLat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lat";
            // 
            // txtGpsLon
            // 
            this.txtGpsLon.Location = new System.Drawing.Point(256, 114);
            this.txtGpsLon.Name = "txtGpsLon";
            this.txtGpsLon.Size = new System.Drawing.Size(100, 20);
            this.txtGpsLon.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Speed";
            // 
            // txtGpsSpeed
            // 
            this.txtGpsSpeed.Location = new System.Drawing.Point(117, 153);
            this.txtGpsSpeed.Name = "txtGpsSpeed";
            this.txtGpsSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtGpsSpeed.TabIndex = 5;
            // 
            // txtGpsCourse
            // 
            this.txtGpsCourse.Location = new System.Drawing.Point(256, 153);
            this.txtGpsCourse.Name = "txtGpsCourse";
            this.txtGpsCourse.Size = new System.Drawing.Size(100, 20);
            this.txtGpsCourse.TabIndex = 5;
            // 
            // txtGpsAltitude
            // 
            this.txtGpsAltitude.Location = new System.Drawing.Point(256, 76);
            this.txtGpsAltitude.Name = "txtGpsAltitude";
            this.txtGpsAltitude.Size = new System.Drawing.Size(100, 20);
            this.txtGpsAltitude.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Altitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Course";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Distance";
            // 
            // btnGpsStatus
            // 
            this.btnGpsStatus.Location = new System.Drawing.Point(93, 73);
            this.btnGpsStatus.Name = "btnGpsStatus";
            this.btnGpsStatus.Size = new System.Drawing.Size(20, 23);
            this.btnGpsStatus.TabIndex = 6;
            this.btnGpsStatus.Text = "?";
            this.btnGpsStatus.UseVisualStyleBackColor = true;
            this.btnGpsStatus.Click += new System.EventHandler(this.btnGpsStatus_Click);
            // 
            // btnGpsLat
            // 
            this.btnGpsLat.Location = new System.Drawing.Point(93, 111);
            this.btnGpsLat.Name = "btnGpsLat";
            this.btnGpsLat.Size = new System.Drawing.Size(20, 23);
            this.btnGpsLat.TabIndex = 6;
            this.btnGpsLat.Text = "?";
            this.btnGpsLat.UseVisualStyleBackColor = true;
            this.btnGpsLat.Click += new System.EventHandler(this.btnGpsLat_Click);
            // 
            // btnGpsSpeed
            // 
            this.btnGpsSpeed.Location = new System.Drawing.Point(93, 151);
            this.btnGpsSpeed.Name = "btnGpsSpeed";
            this.btnGpsSpeed.Size = new System.Drawing.Size(20, 23);
            this.btnGpsSpeed.TabIndex = 6;
            this.btnGpsSpeed.Text = "?";
            this.btnGpsSpeed.UseVisualStyleBackColor = true;
            this.btnGpsSpeed.Click += new System.EventHandler(this.btnGpsSpeed_Click);
            // 
            // btnGpsCourse
            // 
            this.btnGpsCourse.Location = new System.Drawing.Point(235, 151);
            this.btnGpsCourse.Name = "btnGpsCourse";
            this.btnGpsCourse.Size = new System.Drawing.Size(20, 23);
            this.btnGpsCourse.TabIndex = 6;
            this.btnGpsCourse.Text = "?";
            this.btnGpsCourse.UseVisualStyleBackColor = true;
            this.btnGpsCourse.Click += new System.EventHandler(this.btnGpsCourse_Click);
            // 
            // btnGpsLon
            // 
            this.btnGpsLon.Location = new System.Drawing.Point(235, 112);
            this.btnGpsLon.Name = "btnGpsLon";
            this.btnGpsLon.Size = new System.Drawing.Size(20, 23);
            this.btnGpsLon.TabIndex = 6;
            this.btnGpsLon.Text = "?";
            this.btnGpsLon.UseVisualStyleBackColor = true;
            this.btnGpsLon.Click += new System.EventHandler(this.btnGpsLon_Click);
            // 
            // btnGpsAltitude
            // 
            this.btnGpsAltitude.Location = new System.Drawing.Point(235, 74);
            this.btnGpsAltitude.Name = "btnGpsAltitude";
            this.btnGpsAltitude.Size = new System.Drawing.Size(20, 23);
            this.btnGpsAltitude.TabIndex = 6;
            this.btnGpsAltitude.Text = "?";
            this.btnGpsAltitude.UseVisualStyleBackColor = true;
            this.btnGpsAltitude.Click += new System.EventHandler(this.btnGpsAltitude_Click);
            // 
            // txtPackets
            // 
            this.txtPackets.Location = new System.Drawing.Point(117, 190);
            this.txtPackets.Name = "txtPackets";
            this.txtPackets.Size = new System.Drawing.Size(100, 20);
            this.txtPackets.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(113, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Packets";
            // 
            // btnGpsPackets
            // 
            this.btnGpsPackets.Location = new System.Drawing.Point(93, 188);
            this.btnGpsPackets.Name = "btnGpsPackets";
            this.btnGpsPackets.Size = new System.Drawing.Size(20, 23);
            this.btnGpsPackets.TabIndex = 6;
            this.btnGpsPackets.Text = "?";
            this.btnGpsPackets.UseVisualStyleBackColor = true;
            this.btnGpsPackets.Click += new System.EventHandler(this.btnGpsPackets_Click);
            // 
            // txtGpsSats
            // 
            this.txtGpsSats.Location = new System.Drawing.Point(157, 75);
            this.txtGpsSats.Name = "txtGpsSats";
            this.txtGpsSats.Size = new System.Drawing.Size(26, 20);
            this.txtGpsSats.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sats";
            // 
            // cbGps2d
            // 
            this.cbGps2d.AutoSize = true;
            this.cbGps2d.Location = new System.Drawing.Point(188, 71);
            this.cbGps2d.Name = "cbGps2d";
            this.cbGps2d.Size = new System.Drawing.Size(38, 17);
            this.cbGps2d.TabIndex = 7;
            this.cbGps2d.Text = "2d";
            this.cbGps2d.UseVisualStyleBackColor = true;
            // 
            // cbGps3d
            // 
            this.cbGps3d.AutoSize = true;
            this.cbGps3d.Location = new System.Drawing.Point(188, 86);
            this.cbGps3d.Name = "cbGps3d";
            this.cbGps3d.Size = new System.Drawing.Size(38, 17);
            this.cbGps3d.TabIndex = 8;
            this.cbGps3d.Text = "3d";
            this.cbGps3d.UseVisualStyleBackColor = true;
            // 
            // btnGpsPing
            // 
            this.btnGpsPing.Location = new System.Drawing.Point(11, 189);
            this.btnGpsPing.Name = "btnGpsPing";
            this.btnGpsPing.Size = new System.Drawing.Size(20, 23);
            this.btnGpsPing.TabIndex = 6;
            this.btnGpsPing.Text = "?";
            this.btnGpsPing.UseVisualStyleBackColor = true;
            this.btnGpsPing.Click += new System.EventHandler(this.btnGpsPing_Click);
            // 
            // txtGpsPing
            // 
            this.txtGpsPing.Location = new System.Drawing.Point(36, 191);
            this.txtGpsPing.Name = "txtGpsPing";
            this.txtGpsPing.Size = new System.Drawing.Size(51, 20);
            this.txtGpsPing.TabIndex = 5;
            // 
            // comboComPorts
            // 
            this.comboComPorts.FormattingEnabled = true;
            this.comboComPorts.Location = new System.Drawing.Point(11, 151);
            this.comboComPorts.Name = "comboComPorts";
            this.comboComPorts.Size = new System.Drawing.Size(73, 21);
            this.comboComPorts.TabIndex = 9;
            this.comboComPorts.SelectedIndexChanged += new System.EventHandler(this.comboComPorts_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Port";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(97, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Response";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Ping";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 222);
            this.Controls.Add(this.comboComPorts);
            this.Controls.Add(this.cbGps3d);
            this.Controls.Add(this.cbGps2d);
            this.Controls.Add(this.btnGpsAltitude);
            this.Controls.Add(this.btnGpsLon);
            this.Controls.Add(this.btnGpsPing);
            this.Controls.Add(this.btnGpsCourse);
            this.Controls.Add(this.btnGpsPackets);
            this.Controls.Add(this.btnGpsSpeed);
            this.Controls.Add(this.btnGpsLat);
            this.Controls.Add(this.btnGpsStatus);
            this.Controls.Add(this.txtGpsLon);
            this.Controls.Add(this.txtGpsPing);
            this.Controls.Add(this.txtGpsCourse);
            this.Controls.Add(this.txtGpsAltitude);
            this.Controls.Add(this.txtPackets);
            this.Controls.Add(this.txtGpsSpeed);
            this.Controls.Add(this.txtGpsLat);
            this.Controls.Add(this.txtGpsSats);
            this.Controls.Add(this.txtGpsStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRangefinderDistance);
            this.Controls.Add(this.txtRangerfinderRegs);
            this.Controls.Add(this.btnGps);
            this.Controls.Add(this.btnRangefinder);
            this.Name = "Form1";
            this.Text = "i2c Rangefinder Sonar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRangefinder;
        private System.Windows.Forms.Button btnGps;
        private System.Windows.Forms.TextBox txtRangerfinderRegs;
        private System.Windows.Forms.TextBox txtRangefinderDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGpsStatus;
        private System.Windows.Forms.TextBox txtGpsLat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGpsLon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGpsSpeed;
        private System.Windows.Forms.TextBox txtGpsCourse;
        private System.Windows.Forms.TextBox txtGpsAltitude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGpsStatus;
        private System.Windows.Forms.Button btnGpsLat;
        private System.Windows.Forms.Button btnGpsSpeed;
        private System.Windows.Forms.Button btnGpsCourse;
        private System.Windows.Forms.Button btnGpsLon;
        private System.Windows.Forms.Button btnGpsAltitude;
        private System.Windows.Forms.TextBox txtPackets;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGpsPackets;
        private System.Windows.Forms.TextBox txtGpsSats;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbGps2d;
        private System.Windows.Forms.CheckBox cbGps3d;
        private System.Windows.Forms.Button btnGpsPing;
        private System.Windows.Forms.TextBox txtGpsPing;
        private System.Windows.Forms.ComboBox comboComPorts;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

