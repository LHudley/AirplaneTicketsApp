using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirplaneTicketsApp
{
    public partial class Form1 : Form
    {
        //1.creating an object that represents the data model
        private readonly AirlineDBsEntities1 airlineDBEntities; //entity container name
        public Form1()
        {
            InitializeComponent();
            airlineDBEntities = new AirlineDBsEntities1(); //2.initialize db entity
        }

        string trip;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //text boxes
                var firstName = tbFirst.Text;
                var lastName = tbtLast.Text;
                var departFrom = tbDeparture.Text;

                //date time pickers
                var leaving = dateTimePickerLV.Value;
                var returning = dateTimePickerRT.Value;

                //combo boxes
                var destination = cbDestination.Text;
                var classType = cbClass.Text;
                var passengerType = cbPassenger.Text;

                //validate form
                bool isValid = true;

                var errorMessage = "";



                //null combobox selection
                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(departFrom) || string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(classType) || string.IsNullOrEmpty(passengerType))
                {
                    isValid = false;
                    errorMessage += "Enter missing info\n";
                }

                if (leaving > returning)
                {
                    isValid = false;
                    errorMessage += "Illegal date selection\n";
                }

                if (radioButtonOneWay.Checked)
                {
                    trip = "One-Way";
                }
                else if (radioButtonRoundTp.Checked)
                {
                    trip = "Round-Trip";
                }
                else
                {
                    isValid = false;
                    errorMessage += "choose a trip type\n";
                }


                if (isValid)
                {
                    //saving data to airline record table
                    var airlineTicket = new AirlineRecord();
                    airlineTicket.firstName = firstName;
                    airlineTicket.lastName = lastName;
                    airlineTicket.departureFrom = departFrom;
                    airlineTicket.departuredt = leaving;
                    airlineTicket.returndt = returning;
                    airlineTicket.passengerId = (int)cbPassenger.SelectedValue;
                    airlineTicket.tripType = trip;

                    //saving date passenger table
                    var passTb = new PassengerTbl();
                    passTb.passengerType = passengerType;
                    passTb.destinationId = (int)cbDestination.SelectedValue;

                    //saving data to class table
                    var destTb = new DestinationTbl();
                    destTb.destinationCityName = destination;
                    destTb.classId = (int)cbClass.SelectedValue;

                    //saving data to class table
                    var clTb = new Classtbl();
                    clTb.classType = classType;

                    //placing all info into db record table
                    airlineDBEntities.AirlineRecords.Add(airlineTicket);
                    airlineDBEntities.SaveChanges();

                    MessageBox.Show($"Thank you {firstName} {lastName} for booking with us. Here are the details of your trip: \n" +
                       $"Youa are taking a {trip} trip\n" +
                       $"Leaving from {departFrom}\n" +
                       $"Going to {destination}\n" +
                       $"You are leaving on {leaving}\n" +
                       $"Returning on {returning}\n" +
                       $"You are a {passengerType} passenger, flying {classType} class");

                }
                else
                {
                    MessageBox.Show(errorMessage);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void radioButtonOneWay_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerRT.Visible = !radioButtonOneWay.Checked;
            lblReturning.Visible = false;

        }

        private void radioButtonRoundTp_CheckedChanged(object sender, EventArgs e)
        {
            lblReturning.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //3.I want to query the db when form loads and populate combo boxes
            var ps = airlineDBEntities.PassengerTbls.ToList(); //query db
            cbPassenger.DisplayMember = "PassengerType"; //want combobox look for display member of passengertype
            cbPassenger.ValueMember = "Id"; //set value member to id
            cbPassenger.DataSource = ps; //display on combobox

            var cl = airlineDBEntities.Classtbls.ToList();
            cbClass.DisplayMember = "ClassType";
            cbClass.ValueMember = "Id";
            cbClass.DataSource = cl;

            var dt = airlineDBEntities.DestinationTbls.ToList();
            cbDestination.DisplayMember = "DestinationCityName";
            cbDestination.ValueMember = "Id";
            cbDestination.DataSource = dt;


        }
    }
}
