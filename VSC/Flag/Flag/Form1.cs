using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flag
{
    public partial class Flags : Form
    {
        public Flags()
        {
            InitializeComponent();
        }

        private void chkTitle_CheckedChanged(object sender, EventArgs e)
        {
            if(chkTitle.Checked)
                lblTitle.Visible = true;
            else 
                lblTitle.Visible = false;
        }

        private void rbtnFrance_CheckedChanged(object sender, EventArgs e)
        {
            picFrance.Visible = true;
            picAustralia.Visible = false;
            picThailand.Visible = false;
            picCanada.Visible = false;

            if (chkCountry.Checked)
            {
                    lblAustralia.Visible = false;
                    lblFrance.Visible = true;
                    lblThailand.Visible = false;
                    lblCanada.Visible = false;
            }
            else
            {
                    lblFrance.Visible = false;
            }

        }

        private void rbtnAustralia_CheckedChanged(object sender, EventArgs e)
        {
            picAustralia.Visible = true;
            picFrance.Visible = false;
            picThailand.Visible = false;
            picCanada.Visible = false;
            


            if (chkCountry.Checked)
            {
                    lblAustralia.Visible = true;
                    lblFrance.Visible = false;
                    lblThailand.Visible = false;
                    lblCanada.Visible = false;
            }
            else
            {
                    lblAustralia.Visible = false;
            }
        }

        private void rbtnThailand_CheckedChanged(object sender, EventArgs e)
        {
            picThailand.Visible = true;
            picFrance.Visible = false;
            picAustralia.Visible = false;
            picCanada.Visible = false;

            if (chkCountry.Checked)
            {
                    lblAustralia.Visible = false;
                    lblFrance.Visible = false;
                    lblThailand.Visible = true;
                    lblCanada.Visible = false;
            }
            else
            {
                    lblThailand.Visible = false;
            }
        }

        private void rbtnCanada_CheckedChanged(object sender, EventArgs e)
        {
            picCanada.Visible = true;
            picFrance.Visible = false;
            picAustralia.Visible = false;
            picThailand.Visible = false;


            if (chkCountry.Checked)
            {
                    lblAustralia.Visible = false;
                    lblFrance.Visible = false;
                    lblThailand.Visible = false;
                    lblCanada.Visible = true;
            }
            else
            {
                lblCanada.Visible = false;
            }
        }

        private void chkProgrammer_CheckedChanged(object sender, EventArgs e)
        {
            if(chkProgrammer.Checked)
                lblProgrammer.Visible = true;
            else 
                lblProgrammer.Visible = false;
        }

        private void Flags_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(chkTitle, "Click this button to show Title.");
            toolTip1.SetToolTip(chkCountry, "Click this button to show Country Name.");
            toolTip1.SetToolTip(chkProgrammer, "Click this button to show Programmer.");
            toolTip1.SetToolTip(groupBox2, "Click any button to show Flag.");
            toolTip1.SetToolTip(lblTitle, "Title goes here.");
            toolTip1.SetToolTip(groupBox4, "Country Name goes here.");
        }
    }
}
