namespace DateHandling;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnCalculateDays_Click(object sender, EventArgs e)
    {
        // TODO: Add code to calculate the days until due date
        DateTime currentDate = DateTime.Today;
        string currentDateString = currentDate.ToShortDateString();
        DateTime futureDate = DateTime.Parse(txtFutureDate.Text);
        string futureDateString = futureDate.ToShortDateString();
        TimeSpan dueDate = futureDate.Subtract(currentDate);
        string dueDateString = dueDate.TotalDays.ToString();
        MessageBox.Show("Current Date: " + currentDateString + "\n" + "Future Date: " + futureDateString + "\n" + "Due Date: " + dueDateString, "Due Days Calculation");

    }

    private void btnCalculateAge_Click(object sender, EventArgs e)
    {
        // TODO: Add code to calculate the age
        DateTime currentDate = DateTime.Today;
        string currentDateString = currentDate.ToShortDateString();
        DateTime birthDate = DateTime.Parse(txtBirthDate.Text);
        string birthDateString = birthDate.ToShortDateString();
        TimeSpan age = birthDate.Subtract(currentDate);
        double ageDays = age.TotalDays;
        int ageInt = ((int)ageDays);
        int ageCalc = ageInt / -365;
        
        MessageBox.Show("Current Date: " + currentDateString + "\n" + "Birth Date: " + birthDateString + "\n" + "Age: " + ageCalc, "Due Days Calculation");

    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
