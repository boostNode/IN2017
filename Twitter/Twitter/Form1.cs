/*
 *  Author: Troy Davis
 *  Project: Twitter (Chapter 4, Programming Exercise 2)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 1, 2017 
 *  Revision: Original
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Twitter
{
    public partial class frmTwitter : Form
    {
        // class global variables
        int intMessageLength;
        int intMaxMessageLength = 140;
        String strMessage, strFeedback;

        public frmTwitter()
        {
            InitializeComponent();
            // form initialization
            lblFeedback.Text = "";
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {
            // message being edited, clear previous feedback
            lblFeedback.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // get length of submitted message
            strMessage = txtMessage.Text;
            intMessageLength = strMessage.Length;
            // validate message length
            if( intMessageLength <= intMaxMessageLength )
            {
                strFeedback = "Message sent!";
                txtMessage.Text = "";
            }
            else
            {
                strFeedback = "Message is " + intMessageLength.ToString() + " characters long (limit is " + intMaxMessageLength.ToString() + ")!";
            }
            lblFeedback.Text = strFeedback;
        }
    }
}
