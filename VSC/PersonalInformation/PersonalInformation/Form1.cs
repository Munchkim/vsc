using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            String details = "First Name: " +txtFname.Text+
                             "\nMiddle Name: " +txtMname.Text+
                             "\nLast Name: " +txtLname.Text+
                             "\nBirth Date: " +dtBirthdate.Text;
            if (rbtnFemale.Checked)
                details = details + "\nGender: Female";
            else if (rbtnMale.Checked)
                details = details + "\nGender: Male";


            details = details + "\n\nCivil Status " +cboStat.SelectedItem+
                                "\nReligion: " +txtReligion.Text+
                                "\nNationality " +txtNationality.Text+
                                "\nOccupation " +txtOccupation.Text;
            details = details + "\n\nInterests: ";

            if (cbSinging.Checked)
                details = details + "\nSinging";
            if (cbDrawing.Checked)
                details = details + "\nDrawing";
            if (cbPlaying.Checked)
                details = details + "\nPlaying";
            if (cbReading.Checked)
                details = details + "\nReading";

            MessageBox.Show(details, "Personal Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
