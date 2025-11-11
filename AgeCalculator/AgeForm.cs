namespace AgeCalculator
{
    public partial class AgeForm : Form
    {
        DateTime birthDate;
        DateTime currentDate = DateTime.Today.Date;

        public AgeForm()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker2.MaxDate = DateTime.Today;
            dateTimePicker3.MaxDate = DateTime.Today;
        }

        private void setBirthDateText()
        {
            labBdayD.Text = birthDate.Day.ToString();
            labBdayM.Text = birthDate.ToString("MMM");
            labBdayY.Text = birthDate.Year.ToString();
        }

        public void calculateAge(bool showMessage)
        {
            int years = currentDate.Year - birthDate.Year;
            int months = currentDate.Month - birthDate.Month;
            int days = currentDate.Day - birthDate.Day;

            if (months < 0)
            {
                years--;
                months += 12;
            }

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(currentDate.Year, (currentDate.Month == 1) ? 12 : currentDate.Month - 1);
            }

            labAgeY.Text = years.ToString();
            labAgeM.Text = months.ToString();
            labAgeD.Text = days.ToString();

            if (showMessage)
            {
                MessageBox.Show($"You are {years} years, {months} months, and {days} days old.");
            }
        }

        public void openDateTimePicker(DateTimePicker pickerComponent)
        {
            pickerComponent.Focus();
            SendKeys.Send("%{DOWN}");
        }

        #region Events

        private void panel1_Click(object sender, EventArgs e)
        {
            openDateTimePicker(dateTimePicker1);
        }

        private void bDay_Click(object sender, EventArgs e)
        {
            openDateTimePicker(dateTimePicker2);
        }

        private void bYear_Click(object sender, EventArgs e)
        {
            openDateTimePicker(dateTimePicker3);
        }

        private void bMonth_Click(object sender, EventArgs e)
        {
            openDateTimePicker(dateTimePicker1);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var picker = sender as DateTimePicker;
            birthDate = picker.Value;
            dateTimePicker1.Value = birthDate.Date;
            dateTimePicker2.Value = birthDate.Date;
            dateTimePicker3.Value = birthDate.Date;
            setBirthDateText();
            calculateAge(false);
        }

        private void btnCalcAge_Click(object sender, EventArgs e)
        {
            calculateAge(true);
        }

        #endregion
    }
}
