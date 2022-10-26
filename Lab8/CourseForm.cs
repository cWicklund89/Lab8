using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class CourseForm : Form
    {

        // A dictionary containing course numbers and room numbers.
        Dictionary<string, string> courseRoom = new Dictionary<string, string>()
    {
        { "CS101", "3004" }, { "CS102", "4501" },
        { "CS103", "6755" }, { "NT110", "1244" },
        { "CM241", "1411" }
    };

        // A dictionary containing course numbers and instructors.
        Dictionary<string, string> courseInstructor = new Dictionary<string, string>()
    {
        { "CS101", "Haynes" },{ "CS102", "Alvarado" },
        { "CS103", "Rich" },{ "NT110", "Burke" },
        { "CM241", "Lee" }
    };

        // A map containing course numbers and meeting times.
        Dictionary<string, string> courseTimes = new Dictionary<string, string>()
    {
        { "CS101", "8:00 A.M." },{ "CS102", "9:00 A.M." },
        { "CS103", "10:00 A.M." },{ "NT110", "11:00 A.M." },
        { "CM241", "1:00 P.M." }
    };

        public CourseForm()
        {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            // Populate the course number list box.
            foreach (var element in courseRoom)
            {
                courseListBox.Items.Add(element.Key);
            }

        }

        /// <summary>
        /// Retrieve the course number, instructor and meeting time for the selected course
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getCourseButton_Click(object sender, EventArgs e)
        {
            if (courseListBox.SelectedIndex > -1)
            {
                // Get the course number.
                string courseNumber = courseListBox.SelectedItem.ToString();

                // Display the room number.
                if (courseRoom.ContainsKey(courseNumber))
                {
                    roomNumberLabel.Text = courseRoom[courseNumber];
                }

                // Display the instructor.
                if (courseInstructor.ContainsKey(courseNumber))
                {
                    instructorLabel.Text = courseInstructor[courseNumber];
                }

                // Display the meeting time.
                if (courseTimes.ContainsKey(courseNumber))
                {
                    meetingTimeLabel.Text = courseTimes[courseNumber];
                }
            }
        }
    }
}