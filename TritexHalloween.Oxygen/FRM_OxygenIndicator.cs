﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TritexHalloween.Oxygen
{
    using System.IO;
    using System.Net;
    using System.Reflection;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Threading;

    using TritexHalloween.Networking;
    using TritexHalloween.StoryObjects;

    public partial class FRM_OxygenIndicator : Form
    {
        private IPAddress ip;

        private Adventurer adventurer;

        private Random heartRateRandom;

        public FRM_OxygenIndicator(string ip)
        {
            this.ip = IPAddress.Parse(ip);
           
            InitializeComponent();
            this.Server.RunWorkerAsync();
            this.heartRateRandom = new Random();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            DoubleBuffered(this.lb_heartrate, true);
            DoubleBuffered(this.lb_oxygen, true);
            DoubleBuffered(this.tableLayoutPanel1, true);

        }

        private void FRM_OxygenIndicator_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Normal;
            //this.Location = new Point(0, 0);
            //this.TopMost = true;
            //Screen currentScreen = Screen.FromHandle(this.Handle);
            //this.Size = new System.Drawing.Size(currentScreen.Bounds.Width, currentScreen.Bounds.Height);
        }

        private void Server_DoWork(object sender, DoWorkEventArgs e)
        {
            var server = new Server(this.ip, this.UpdateAdventurer);
            server.Start();
        }

        private void UpdateAdventurer(Message message)
        {
            if (message.ObjectType == 0)
            {
                IFormatter formatter;
                using (var stream = new MemoryStream(message.Data))
                {
                    formatter = new BinaryFormatter();
                    var adventurer = (Adventurer)formatter.Deserialize(stream);
                    this.Invoke((MethodInvoker)delegate
                        {
                            this.SetAdventurer(adventurer);
                        });
                }
            }
        }

        private void SetAdventurer(Adventurer adventurer)
        {
            this.tmr_respiration.Stop();

            this.adventurer = adventurer;
            this.lb_SubjectValue.Text = adventurer.Name;
            this.lb_temperature.Text = adventurer.Temperature.ToString("N2") + "C";
            this.lb_suitpressure.Text = adventurer.SuitPressure + "-Bar";
            this.lb_oxygen.Text = adventurer.OxygenRemaining.ToString("N2") + "L";
            this.tmr_respiration.Start();
        }

        private void setOxygenHeartRate()
        {
            this.lb_oxygen.Parent.SuspendLayout();
            this.lb_heartrate.Parent.SuspendLayout();

            var currentHeartRate = 0;

            switch (this.adventurer.HeartRateMode)
            {
                default:
                case HeartRateMode.Error:
                    break;
                case HeartRateMode.BelowResting:
                    currentHeartRate = this.heartRateRandom.Next(50, 60);
                    break;
                case HeartRateMode.Resting: // 60
                    currentHeartRate = this.heartRateRandom.Next(60, 65);
                    break;
                case HeartRateMode.AboveResting:
                    currentHeartRate = this.heartRateRandom.Next(72, 85);
                    break;
                case HeartRateMode.Stressed:
                    currentHeartRate = this.heartRateRandom.Next(72, 100);
                    break;
                case HeartRateMode.ModerateExercise: // 
                    currentHeartRate = this.heartRateRandom.Next(100, 130);
                    break;
                case HeartRateMode.High: // 16
                    currentHeartRate = this.heartRateRandom.Next(140, 160);
                    break;
                case HeartRateMode.Extreme: // 20
                    currentHeartRate = this.heartRateRandom.Next(160, 200);
                    break;
            }

            this.adventurer.OxygenRemaining -= (currentHeartRate / 10m * (0.8m + (currentHeartRate / 1000m))) / 60m;
            this.lb_oxygen.Text = this.adventurer.OxygenRemaining.ToString("n2");
            this.lb_heartrate.Text = currentHeartRate.ToString();
            this.lb_oxygen.Parent.ResumeLayout();
            this.lb_heartrate.Parent.ResumeLayout();
        }

        private void tmr_respiration_Tick(object sender, EventArgs e)
        {
            this.setOxygenHeartRate();
        }

        public static void DoubleBuffered(Control formControl, bool setting)
        {
            Type conType = formControl.GetType();
            PropertyInfo pi = conType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(formControl, setting, null);
        }
    }
}
