﻿namespace TritexHalloween.Oxygen
{
    partial class FRM_OxygenIndicator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_OxygenIndicator));
            this.splc_Main = new System.Windows.Forms.SplitContainer();
            this.splc_Status = new System.Windows.Forms.SplitContainer();
            this.pb_Animation = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_SubjectName = new System.Windows.Forms.Label();
            this.lb_TemperatureLabel = new System.Windows.Forms.Label();
            this.lb_pressurelabel = new System.Windows.Forms.Label();
            this.lb_HeartRateLabel = new System.Windows.Forms.Label();
            this.lb_OxygenRemaning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splc_Main)).BeginInit();
            this.splc_Main.Panel1.SuspendLayout();
            this.splc_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splc_Status)).BeginInit();
            this.splc_Status.Panel1.SuspendLayout();
            this.splc_Status.Panel2.SuspendLayout();
            this.splc_Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Animation)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splc_Main
            // 
            this.splc_Main.BackColor = System.Drawing.Color.Transparent;
            this.splc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splc_Main.IsSplitterFixed = true;
            this.splc_Main.Location = new System.Drawing.Point(0, 0);
            this.splc_Main.Name = "splc_Main";
            this.splc_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splc_Main.Panel1
            // 
            this.splc_Main.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splc_Main.Panel1.Controls.Add(this.splc_Status);
            this.splc_Main.Size = new System.Drawing.Size(1530, 862);
            this.splc_Main.SplitterDistance = 584;
            this.splc_Main.SplitterWidth = 1;
            this.splc_Main.TabIndex = 0;
            // 
            // splc_Status
            // 
            this.splc_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splc_Status.Location = new System.Drawing.Point(0, 0);
            this.splc_Status.Name = "splc_Status";
            // 
            // splc_Status.Panel1
            // 
            this.splc_Status.Panel1.Controls.Add(this.pb_Animation);
            // 
            // splc_Status.Panel2
            // 
            this.splc_Status.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splc_Status.Size = new System.Drawing.Size(1530, 584);
            this.splc_Status.SplitterDistance = 923;
            this.splc_Status.SplitterWidth = 1;
            this.splc_Status.TabIndex = 0;
            // 
            // pb_Animation
            // 
            this.pb_Animation.BackColor = System.Drawing.Color.Black;
            this.pb_Animation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_Animation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Animation.Image = global::TritexHalloween.Oxygen.Properties.Resources.SpinningMan;
            this.pb_Animation.Location = new System.Drawing.Point(0, 0);
            this.pb_Animation.Name = "pb_Animation";
            this.pb_Animation.Size = new System.Drawing.Size(923, 584);
            this.pb_Animation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Animation.TabIndex = 0;
            this.pb_Animation.TabStop = false;
            this.pb_Animation.WaitOnLoad = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lb_SubjectName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_TemperatureLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_pressurelabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_HeartRateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_OxygenRemaning, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(606, 584);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lb_SubjectName
            // 
            this.lb_SubjectName.AutoSize = true;
            this.lb_SubjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_SubjectName.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SubjectName.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_SubjectName.Location = new System.Drawing.Point(3, 0);
            this.lb_SubjectName.Name = "lb_SubjectName";
            this.lb_SubjectName.Size = new System.Drawing.Size(297, 116);
            this.lb_SubjectName.TabIndex = 0;
            this.lb_SubjectName.Text = "Subject:";
            // 
            // lb_TemperatureLabel
            // 
            this.lb_TemperatureLabel.AutoSize = true;
            this.lb_TemperatureLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_TemperatureLabel.Font = new System.Drawing.Font("Consolas", 21F);
            this.lb_TemperatureLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_TemperatureLabel.Location = new System.Drawing.Point(3, 116);
            this.lb_TemperatureLabel.Name = "lb_TemperatureLabel";
            this.lb_TemperatureLabel.Size = new System.Drawing.Size(297, 116);
            this.lb_TemperatureLabel.TabIndex = 1;
            this.lb_TemperatureLabel.Text = "Temperature:";
            this.lb_TemperatureLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb_pressurelabel
            // 
            this.lb_pressurelabel.AutoSize = true;
            this.lb_pressurelabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_pressurelabel.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pressurelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_pressurelabel.Location = new System.Drawing.Point(3, 232);
            this.lb_pressurelabel.Name = "lb_pressurelabel";
            this.lb_pressurelabel.Size = new System.Drawing.Size(297, 116);
            this.lb_pressurelabel.TabIndex = 2;
            this.lb_pressurelabel.Text = "Suit Pressure:";
            // 
            // lb_HeartRateLabel
            // 
            this.lb_HeartRateLabel.AutoSize = true;
            this.lb_HeartRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_HeartRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_HeartRateLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_HeartRateLabel.Location = new System.Drawing.Point(3, 348);
            this.lb_HeartRateLabel.Name = "lb_HeartRateLabel";
            this.lb_HeartRateLabel.Size = new System.Drawing.Size(297, 116);
            this.lb_HeartRateLabel.TabIndex = 3;
            this.lb_HeartRateLabel.Text = "Heart Rate:";
            // 
            // lb_OxygenRemaning
            // 
            this.lb_OxygenRemaning.AutoSize = true;
            this.lb_OxygenRemaning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_OxygenRemaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OxygenRemaning.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_OxygenRemaning.Location = new System.Drawing.Point(3, 464);
            this.lb_OxygenRemaning.Name = "lb_OxygenRemaning";
            this.lb_OxygenRemaning.Size = new System.Drawing.Size(297, 120);
            this.lb_OxygenRemaning.TabIndex = 4;
            this.lb_OxygenRemaning.Text = "Oxygen Remaining:";
            this.lb_OxygenRemaning.Click += new System.EventHandler(this.lb_OxygenRemaning_Click);
            // 
            // FRM_OxygenIndicator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1530, 862);
            this.Controls.Add(this.splc_Main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_OxygenIndicator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oxgen Indicator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRM_OxygenIndicator_Load);
            this.splc_Main.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splc_Main)).EndInit();
            this.splc_Main.ResumeLayout(false);
            this.splc_Status.Panel1.ResumeLayout(false);
            this.splc_Status.Panel2.ResumeLayout(false);
            this.splc_Status.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splc_Status)).EndInit();
            this.splc_Status.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Animation)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splc_Main;
        private System.Windows.Forms.SplitContainer splc_Status;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_SubjectName;
        private System.Windows.Forms.Label lb_TemperatureLabel;
        private System.Windows.Forms.Label lb_pressurelabel;
        private System.Windows.Forms.Label lb_HeartRateLabel;
        private System.Windows.Forms.Label lb_OxygenRemaning;
        private System.Windows.Forms.PictureBox pb_Animation;
    }
}

