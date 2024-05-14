namespace StudentInfoApplication
{
    public class StudentInfo
    {
        private string firstName, lastName, studID;

        public string encapFirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }

        }

        public string encapLastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }

        }

        public string encapStudentID
        {
            get
            {
                return this.studID;
            }
            set
            {
                this.studID = value;
            }

        }


    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfo stud = new StudentInfo();
            stud.encapStudentID = txtStudentID.Text;
            stud.encapFirstName = txtFirstName.Text;
            stud.encapLastName = txtLastName.Text;

            lbStudentID.Items.Add(txtStudentID.Text);
            lbFirstName.Items.Add(txtFirstName.Text);
            lbLastName.Items.Add(txtLastName.Text);

            txtStudentID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
        }
    }
}