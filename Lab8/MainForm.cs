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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Will cause the application to close.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Will display the vending machine form.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!CheckIfFormCreated(typeof(VendingForm)))
            {
                VendingForm vendingForm = new VendingForm();
                vendingForm.MdiParent = this;
                vendingForm.WindowState = FormWindowState.Maximized;
                vendingForm.Show();
            }
        }

        /// <summary>
        /// Determines whether the window has been created and just needs to be 
        /// activated.
        /// </summary>
        /// <param name="formType">Type of the form being checked</param>
        /// <returns>boolean indicating whether the window was previously created 
        /// and could be activated</returns>
        private bool CheckIfFormCreated(Type formType)
        {
            bool formCreated = false;

            // Check all open forms to see if this form has already been instantiated
            foreach (Form form in Application.OpenForms)
            {
                // If the type matches, then activate the form instance
                if (form.GetType() == formType)
                {
                    formCreated = true;
                    form.Activate();
                    break;
                }
            }

            return formCreated;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!CheckIfFormCreated(typeof(CourseForm)))
            {
                CourseForm courseForm = new CourseForm();
                courseForm.MdiParent = this;
                courseForm.WindowState = FormWindowState.Maximized;
                courseForm.Show();
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (!CheckIfFormCreated(typeof(WordForm)))
            {
                WordForm wordForm = new WordForm();
                wordForm.MdiParent = this;
                wordForm.WindowState = FormWindowState.Maximized;
                wordForm.Show();
            }
        }
    }
}

