namespace AirplaneTicketsApp
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
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.tbtLast = new System.Windows.Forms.TextBox();
            this.tbDeparture = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblDepature = new System.Windows.Forms.Label();
            this.dateTimePickerLV = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRT = new System.Windows.Forms.DateTimePicker();
            this.lblLeaving = new System.Windows.Forms.Label();
            this.lblReturning = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbTrip = new System.Windows.Forms.GroupBox();
            this.radioButtonOneWay = new System.Windows.Forms.RadioButton();
            this.radioButtonRoundTp = new System.Windows.Forms.RadioButton();
            this.cbDestination = new System.Windows.Forms.ComboBox();
            this.cbPassenger = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(12, 43);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(173, 20);
            this.tbFirst.TabIndex = 0;
            // 
            // tbtLast
            // 
            this.tbtLast.Location = new System.Drawing.Point(12, 97);
            this.tbtLast.Name = "tbtLast";
            this.tbtLast.Size = new System.Drawing.Size(173, 20);
            this.tbtLast.TabIndex = 1;
            // 
            // tbDeparture
            // 
            this.tbDeparture.Location = new System.Drawing.Point(12, 155);
            this.tbDeparture.Name = "tbDeparture";
            this.tbDeparture.Size = new System.Drawing.Size(173, 20);
            this.tbDeparture.TabIndex = 2;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(12, 27);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(57, 13);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.Text = "First Name";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(12, 81);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(58, 13);
            this.lblLast.TabIndex = 4;
            this.lblLast.Text = "Last Name";
            // 
            // lblDepature
            // 
            this.lblDepature.AutoSize = true;
            this.lblDepature.Location = new System.Drawing.Point(12, 139);
            this.lblDepature.Name = "lblDepature";
            this.lblDepature.Size = new System.Drawing.Size(74, 13);
            this.lblDepature.TabIndex = 5;
            this.lblDepature.Text = "Departure City";
            // 
            // dateTimePickerLV
            // 
            this.dateTimePickerLV.Location = new System.Drawing.Point(12, 214);
            this.dateTimePickerLV.Name = "dateTimePickerLV";
            this.dateTimePickerLV.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLV.TabIndex = 6;
            // 
            // dateTimePickerRT
            // 
            this.dateTimePickerRT.Location = new System.Drawing.Point(12, 266);
            this.dateTimePickerRT.Name = "dateTimePickerRT";
            this.dateTimePickerRT.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerRT.TabIndex = 7;
            // 
            // lblLeaving
            // 
            this.lblLeaving.AutoSize = true;
            this.lblLeaving.Location = new System.Drawing.Point(12, 198);
            this.lblLeaving.Name = "lblLeaving";
            this.lblLeaving.Size = new System.Drawing.Size(77, 13);
            this.lblLeaving.TabIndex = 8;
            this.lblLeaving.Text = "Depature Date";
            // 
            // lblReturning
            // 
            this.lblReturning.AutoSize = true;
            this.lblReturning.Location = new System.Drawing.Point(17, 250);
            this.lblReturning.Name = "lblReturning";
            this.lblReturning.Size = new System.Drawing.Size(53, 13);
            this.lblReturning.TabIndex = 9;
            this.lblReturning.Text = "Returning";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(512, 292);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 41);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Book";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbTrip
            // 
            this.gbTrip.Controls.Add(this.radioButtonRoundTp);
            this.gbTrip.Controls.Add(this.radioButtonOneWay);
            this.gbTrip.Location = new System.Drawing.Point(257, 17);
            this.gbTrip.Name = "gbTrip";
            this.gbTrip.Size = new System.Drawing.Size(200, 100);
            this.gbTrip.TabIndex = 11;
            this.gbTrip.TabStop = false;
            this.gbTrip.Text = "Trip";
            // 
            // radioButtonOneWay
            // 
            this.radioButtonOneWay.AutoSize = true;
            this.radioButtonOneWay.Location = new System.Drawing.Point(17, 32);
            this.radioButtonOneWay.Name = "radioButtonOneWay";
            this.radioButtonOneWay.Size = new System.Drawing.Size(70, 17);
            this.radioButtonOneWay.TabIndex = 0;
            this.radioButtonOneWay.TabStop = true;
            this.radioButtonOneWay.Text = "One-Way";
            this.radioButtonOneWay.UseVisualStyleBackColor = true;
            this.radioButtonOneWay.CheckedChanged += new System.EventHandler(this.radioButtonOneWay_CheckedChanged);
            // 
            // radioButtonRoundTp
            // 
            this.radioButtonRoundTp.AutoSize = true;
            this.radioButtonRoundTp.Location = new System.Drawing.Point(17, 57);
            this.radioButtonRoundTp.Name = "radioButtonRoundTp";
            this.radioButtonRoundTp.Size = new System.Drawing.Size(78, 17);
            this.radioButtonRoundTp.TabIndex = 1;
            this.radioButtonRoundTp.TabStop = true;
            this.radioButtonRoundTp.Text = "Round-Trip";
            this.radioButtonRoundTp.UseVisualStyleBackColor = true;
            this.radioButtonRoundTp.CheckedChanged += new System.EventHandler(this.radioButtonRoundTp_CheckedChanged);
            // 
            // cbDestination
            // 
            this.cbDestination.FormattingEnabled = true;
            this.cbDestination.Location = new System.Drawing.Point(256, 155);
            this.cbDestination.Name = "cbDestination";
            this.cbDestination.Size = new System.Drawing.Size(163, 21);
            this.cbDestination.TabIndex = 12;
            // 
            // cbPassenger
            // 
            this.cbPassenger.FormattingEnabled = true;
            this.cbPassenger.Location = new System.Drawing.Point(257, 213);
            this.cbPassenger.Name = "cbPassenger";
            this.cbPassenger.Size = new System.Drawing.Size(162, 21);
            this.cbPassenger.TabIndex = 13;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(257, 269);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(162, 21);
            this.cbClass.TabIndex = 14;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(254, 139);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 15;
            this.lblDestination.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Passenger";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Class";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.cbPassenger);
            this.Controls.Add(this.cbDestination);
            this.Controls.Add(this.gbTrip);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblReturning);
            this.Controls.Add(this.lblLeaving);
            this.Controls.Add(this.dateTimePickerRT);
            this.Controls.Add(this.dateTimePickerLV);
            this.Controls.Add(this.lblDepature);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.tbDeparture);
            this.Controls.Add(this.tbtLast);
            this.Controls.Add(this.tbFirst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTrip.ResumeLayout(false);
            this.gbTrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirst;
        private System.Windows.Forms.TextBox tbtLast;
        private System.Windows.Forms.TextBox tbDeparture;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblDepature;
        private System.Windows.Forms.DateTimePicker dateTimePickerLV;
        private System.Windows.Forms.DateTimePicker dateTimePickerRT;
        private System.Windows.Forms.Label lblLeaving;
        private System.Windows.Forms.Label lblReturning;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbTrip;
        private System.Windows.Forms.RadioButton radioButtonRoundTp;
        private System.Windows.Forms.RadioButton radioButtonOneWay;
        private System.Windows.Forms.ComboBox cbDestination;
        private System.Windows.Forms.ComboBox cbPassenger;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

