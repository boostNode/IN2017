using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarshallsRevenueGUI
{
    public partial class frmMarshallsRevenue : Form
    {
        // define class global variables
        int intMuralsInterior = 0;
        int intMuralsExterior = 0;
        double dblCostInterior = 500.00;
        double dblCostExterior = 750.00;

        // initialize
        public frmMarshallsRevenue()
        {
            InitializeComponent();
            updateDisplay();
        }

        // capture input on number of interior murals
        private void txtNumbInteriorMurals_TextChanged(object sender, EventArgs e)
        {
            if( txtNumbInteriorMurals.Text != "" )
            {
                // parse input to Int32, handle non-numeric input
                if(! Int32.TryParse(txtNumbInteriorMurals.Text, out intMuralsInterior))
                {
                    txtNumbInteriorMurals.Text = "";
                    intMuralsInterior = 0;
                }
            }
            else
            {
                intMuralsInterior = 0;
            }
            updateDisplay();
        }

        // capture input on number of exterior murals
        private void txtNumbExteriorMurals_TextChanged(object sender, EventArgs e)
        {
            if ( txtNumbExteriorMurals.Text != "")
            {
                // parse input to Int32, handle non-numeric input
                if (!Int32.TryParse(txtNumbExteriorMurals.Text, out intMuralsExterior))
                {
                    txtNumbExteriorMurals.Text = "";
                    intMuralsExterior = 0;
                }
            }
            else
            {
                intMuralsExterior = 0;
            }
            updateDisplay();
        }

        // update form display
        private void updateDisplay()
        {
            // update mural cost labels
            lblCostInterior.Text = "x " + dblCostInterior.ToString("C2") + " each";
            lblCostExterior.Text = "x " + dblCostExterior.ToString("C2") + " each";
            // update mural revenue subtotal
            txtRevenueInterior.Text = ((double)intMuralsInterior * dblCostInterior).ToString("C2");
            txtRevenueExterior.Text = ((double)intMuralsExterior * dblCostExterior).ToString("C2");
            // update total revenue
            txtRevenueTotal.Text = ((double)intMuralsInterior * dblCostInterior + (double)intMuralsExterior * dblCostExterior).ToString("C2"); ;
            // update scheduling remarks
            if( intMuralsInterior > intMuralsExterior )
            {
                lblSchedulingRemarks.Text = "More Interior Murals Scheduled than Exterior Murals";
            }
            else if( intMuralsInterior < intMuralsExterior)
            {
                lblSchedulingRemarks.Text = "More Exterior Murals Scheduled than Interior Murals";
            }
            else // same number scheduled
            {
                if( intMuralsInterior == 0 ) // no murals secheduled
                {
                    lblSchedulingRemarks.Text = "No Murals Scheduled";
                }
                else
                {
                    lblSchedulingRemarks.Text = "Same Number of Interior and Exterior Murals Scheduled";
                }
            }
        }

    }
}
