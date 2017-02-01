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
        int intMonth;
        int intMuralsInterior = 0;
        int intMuralsExterior = 0;

        double dblCostInterior = 500.00;
        double dblCostInteriorDiscounted = 450.00;
        double dblCostExterior = 750.00;
        double dblCostExteriorDiscounted = 699.00;
        double dblRevenue = 0.00;

        String strFeedback = "";

        bool boolInputErrorMonth = false;
        bool boolInputErrorInterior = false;
        bool boolInputErrorExterior = false;
        bool boolBypassUpdate = false;

        // initialize
        public frmMarshallsRevenue()
        {
            InitializeComponent();
            updateDisplay();
        }

        private void frmMarshallsRevenue_Load(object sender, EventArgs e)
        {

        }

        // capture input on number of month being computed
        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            boolInputErrorMonth = false;
            if ( txtMonth.Text != "" )
            {
                // parse input to Int32, handle non-numeric input
                if ( ! Int32.TryParse(txtMonth.Text, out intMonth) )
                {
                    txtMonth.Text = "";
                    intMonth = 0;
                }
                // TO DO!!! handle out-of-range input
                if ( intMonth < 1 || intMonth > 12 )
                {
                    boolInputErrorMonth = true;
                }

            }
            else
            {
                boolInputErrorMonth = true;
                intMonth = 0;
            }
            updateDisplay();
        }

        // capture input on number of interior murals
        private void txtNumbInteriorMurals_TextChanged(object sender, EventArgs e)
        {
            boolInputErrorInterior = false;
            if ( txtNumbInteriorMurals.Text != "" )
            {
                // parse input to Int32, handle non-numeric input
                if ( ! Int32.TryParse(txtNumbInteriorMurals.Text, out intMuralsInterior) )
                {
                    txtNumbInteriorMurals.Text = "";
                    intMuralsInterior = 0;
                }
                // TO DO!!! handle out-of-range input
                if ( intMuralsInterior < 0 || intMuralsInterior > 30 )
                {
                    boolInputErrorInterior = true;
                }
            }
            else
            {
                boolInputErrorInterior = true;
                intMuralsInterior = 0;
            }
            updateDisplay();
        }

        // capture input on number of exterior murals
        private void txtNumbExteriorMurals_TextChanged(object sender, EventArgs e)
        {
            if ( ! boolBypassUpdate ) {
                boolInputErrorExterior = false;
                if ( txtNumbExteriorMurals.Text != "" )
                {
                    // parse input to Int32, handle non-numeric input
                    if (!Int32.TryParse(txtNumbExteriorMurals.Text, out intMuralsExterior))
                    {
                        txtNumbExteriorMurals.Text = "";
                        intMuralsExterior = 0;
                    }
                    // TO DO!!! handle out-of-range input
                    if ( intMuralsExterior < 0 || intMuralsExterior > 30)
                    {
                        boolInputErrorExterior = true;
                    }
                }
                else
                {
                    boolInputErrorExterior = true;
                    intMuralsExterior = 0;
                }
                updateDisplay();
            }
        }

        // update form display
        private void updateDisplay()
        {
            // initialize
            strFeedback = "";
            dblRevenue = 0.00;
            // clear revenue displays
            lblCostInterior.Text = "";
            txtRevenueInterior.Text = "";
            lblCostExterior.Text = "";
            txtRevenueExterior.Text = "";
            txtRevenueTotal.Text = "";
            // provided valid input, compute revenue and provide feedback
            if ( boolInputErrorMonth != true && boolInputErrorInterior != true && boolInputErrorExterior != true )
            {
                // account for winter months
                //      exterior murals cannot be painted December (12) through February (2)
                if ( intMonth <= 2 || intMonth == 12 )
                {
                    if ( intMuralsExterior > 0 )
                    {
                        strFeedback += "Unable to complete exterior murals due to winter weather. ";
                        boolBypassUpdate = true;
                        txtNumbExteriorMurals.Text = "0";
                        intMuralsExterior = 0;
                    }
                    boolBypassUpdate = false;
                }

                // account for exterior mural discount
                //      Marshall prefers painting exterior murals during April (4), May (5), September (9) and October (10) (apply discount)
                if ( intMonth == 4 || intMonth == 5 || intMonth == 9 || intMonth == 10 )
                {
                    lblCostExterior.Text = "x " + dblCostExteriorDiscounted.ToString("C2") + " each";
                    txtRevenueExterior.Text = ((double)intMuralsExterior * dblCostExteriorDiscounted).ToString("C2");
                    dblRevenue += (double)intMuralsExterior * dblCostExteriorDiscounted;
                    strFeedback += "Discount applied to exterior murals. ";
                }
                else
                {
                    lblCostExterior.Text = "x " + dblCostExterior.ToString("C2") + " each";
                    txtRevenueExterior.Text = ((double)intMuralsExterior * dblCostExterior).ToString("C2");
                    dblRevenue += (double)intMuralsExterior * dblCostExterior;
                }

                // account for interior mural discount
                //      Marshall prefers painting interior murals during July (7) and August (8) (apply discount)
                if ( intMonth == 7 || intMonth == 8 )
                {
                    lblCostInterior.Text = "x " + dblCostInteriorDiscounted.ToString("C2") + " each";
                    txtRevenueInterior.Text = ((double)intMuralsInterior * dblCostInteriorDiscounted).ToString("C2");
                    dblRevenue += (double)intMuralsInterior * dblCostInteriorDiscounted;
                    strFeedback += "Discount applied to interior murals. ";
                }
                else
                {
                    lblCostInterior.Text = "x " + dblCostInterior.ToString("C2") + " each";
                    txtRevenueInterior.Text = ((double)intMuralsInterior * dblCostInterior).ToString("C2");
                    dblRevenue += (double)intMuralsInterior * dblCostInterior;
                }

                // update total revenue
                txtRevenueTotal.Text = dblRevenue.ToString("C2");

                // compare interior versus exterior scheduled, update feedback
                if( intMuralsInterior > intMuralsExterior )
                {
                    strFeedback += "More Interior Murals Projected than Exterior Murals. ";
                }
                else if( intMuralsInterior < intMuralsExterior )
                {
                    strFeedback += "More Exterior Murals Projected than Interior Murals. ";
                }
                else // same number scheduled
                {
                    if ( intMuralsInterior == 0 ) // no murals secheduled
                    {
                        strFeedback = "No Murals Projected. ";
                    }
                    else
                    {
                        strFeedback += "Same Number of Interior and Exterior Murals Projected. ";
                    }
                }
            }
            else
            {
                if ( boolInputErrorMonth == true )
                {
                    strFeedback += "You must enter a month between 1 and 12! ";
                }
                if ( boolInputErrorInterior == true )
                {
                    strFeedback += "You must enter between 0 and 30 Interior Murals! ";
                }
                if ( boolInputErrorExterior == true )
                {
                    strFeedback += "You must enter between 0 and 30 Exterior Murals! ";
                }
            }
            lblSchedulingRemarks.Text = strFeedback;
        }
    }
}
