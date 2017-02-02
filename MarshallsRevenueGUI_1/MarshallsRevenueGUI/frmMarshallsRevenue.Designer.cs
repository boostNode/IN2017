namespace MarshallsRevenueGUI
{
    partial class frmMarshallsRevenue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumbInteriorMurals = new System.Windows.Forms.Label();
            this.lblNumbExteriorMurals = new System.Windows.Forms.Label();
            this.txtNumbInteriorMurals = new System.Windows.Forms.TextBox();
            this.txtNumbExteriorMurals = new System.Windows.Forms.TextBox();
            this.lblCostInterior = new System.Windows.Forms.Label();
            this.lblCostExterior = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblRevenueTotal = new System.Windows.Forms.Label();
            this.lblSchedulingRemarks = new System.Windows.Forms.Label();
            this.txtRevenueInterior = new System.Windows.Forms.TextBox();
            this.txtRevenueExterior = new System.Windows.Forms.TextBox();
            this.txtRevenueTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNumbInteriorMurals
            // 
            this.lblNumbInteriorMurals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbInteriorMurals.Location = new System.Drawing.Point(36, 36);
            this.lblNumbInteriorMurals.Name = "lblNumbInteriorMurals";
            this.lblNumbInteriorMurals.Size = new System.Drawing.Size(160, 15);
            this.lblNumbInteriorMurals.TabIndex = 0;
            this.lblNumbInteriorMurals.Text = "Number of Interior Murals:";
            this.lblNumbInteriorMurals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumbExteriorMurals
            // 
            this.lblNumbExteriorMurals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbExteriorMurals.Location = new System.Drawing.Point(36, 62);
            this.lblNumbExteriorMurals.Name = "lblNumbExteriorMurals";
            this.lblNumbExteriorMurals.Size = new System.Drawing.Size(160, 15);
            this.lblNumbExteriorMurals.TabIndex = 1;
            this.lblNumbExteriorMurals.Text = "Number of Exterior Murals:";
            this.lblNumbExteriorMurals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumbInteriorMurals
            // 
            this.txtNumbInteriorMurals.Location = new System.Drawing.Point(202, 33);
            this.txtNumbInteriorMurals.Name = "txtNumbInteriorMurals";
            this.txtNumbInteriorMurals.Size = new System.Drawing.Size(40, 20);
            this.txtNumbInteriorMurals.TabIndex = 2;
            this.txtNumbInteriorMurals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumbInteriorMurals.TextChanged += new System.EventHandler(this.txtNumbInteriorMurals_TextChanged);
            // 
            // txtNumbExteriorMurals
            // 
            this.txtNumbExteriorMurals.Location = new System.Drawing.Point(202, 59);
            this.txtNumbExteriorMurals.Name = "txtNumbExteriorMurals";
            this.txtNumbExteriorMurals.Size = new System.Drawing.Size(40, 20);
            this.txtNumbExteriorMurals.TabIndex = 3;
            this.txtNumbExteriorMurals.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumbExteriorMurals.TextChanged += new System.EventHandler(this.txtNumbExteriorMurals_TextChanged);
            // 
            // lblCostInterior
            // 
            this.lblCostInterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostInterior.Location = new System.Drawing.Point(248, 36);
            this.lblCostInterior.Name = "lblCostInterior";
            this.lblCostInterior.Size = new System.Drawing.Size(110, 15);
            this.lblCostInterior.TabIndex = 4;
            this.lblCostInterior.Text = "costInterior";
            this.lblCostInterior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCostExterior
            // 
            this.lblCostExterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostExterior.Location = new System.Drawing.Point(248, 62);
            this.lblCostExterior.Name = "lblCostExterior";
            this.lblCostExterior.Size = new System.Drawing.Size(110, 15);
            this.lblCostExterior.TabIndex = 5;
            this.lblCostExterior.Text = "costExterior";
            this.lblCostExterior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(420, 18);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Enter the number of murals scheduled to be painted in the next month:";
            // 
            // lblRevenueTotal
            // 
            this.lblRevenueTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueTotal.Location = new System.Drawing.Point(211, 86);
            this.lblRevenueTotal.Name = "lblRevenueTotal";
            this.lblRevenueTotal.Size = new System.Drawing.Size(150, 15);
            this.lblRevenueTotal.TabIndex = 7;
            this.lblRevenueTotal.Text = "Total Expected Revenue:";
            this.lblRevenueTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSchedulingRemarks
            // 
            this.lblSchedulingRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedulingRemarks.Location = new System.Drawing.Point(36, 112);
            this.lblSchedulingRemarks.Name = "lblSchedulingRemarks";
            this.lblSchedulingRemarks.Size = new System.Drawing.Size(390, 15);
            this.lblSchedulingRemarks.TabIndex = 8;
            this.lblSchedulingRemarks.Text = "schedulingRemarks";
            this.lblSchedulingRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRevenueInterior
            // 
            this.txtRevenueInterior.Enabled = false;
            this.txtRevenueInterior.Location = new System.Drawing.Point(367, 33);
            this.txtRevenueInterior.Name = "txtRevenueInterior";
            this.txtRevenueInterior.Size = new System.Drawing.Size(80, 20);
            this.txtRevenueInterior.TabIndex = 9;
            this.txtRevenueInterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRevenueExterior
            // 
            this.txtRevenueExterior.Enabled = false;
            this.txtRevenueExterior.Location = new System.Drawing.Point(367, 59);
            this.txtRevenueExterior.Name = "txtRevenueExterior";
            this.txtRevenueExterior.Size = new System.Drawing.Size(80, 20);
            this.txtRevenueExterior.TabIndex = 10;
            this.txtRevenueExterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRevenueTotal
            // 
            this.txtRevenueTotal.Enabled = false;
            this.txtRevenueTotal.Location = new System.Drawing.Point(367, 85);
            this.txtRevenueTotal.Name = "txtRevenueTotal";
            this.txtRevenueTotal.Size = new System.Drawing.Size(80, 20);
            this.txtRevenueTotal.TabIndex = 11;
            this.txtRevenueTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmMarshallsRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 140);
            this.Controls.Add(this.txtRevenueTotal);
            this.Controls.Add(this.txtRevenueExterior);
            this.Controls.Add(this.txtRevenueInterior);
            this.Controls.Add(this.lblSchedulingRemarks);
            this.Controls.Add(this.lblRevenueTotal);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblCostExterior);
            this.Controls.Add(this.lblCostInterior);
            this.Controls.Add(this.txtNumbExteriorMurals);
            this.Controls.Add(this.txtNumbInteriorMurals);
            this.Controls.Add(this.lblNumbExteriorMurals);
            this.Controls.Add(this.lblNumbInteriorMurals);
            this.Name = "frmMarshallsRevenue";
            this.Text = "Marshall\'s Revenue GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumbInteriorMurals;
        private System.Windows.Forms.Label lblNumbExteriorMurals;
        private System.Windows.Forms.TextBox txtNumbInteriorMurals;
        private System.Windows.Forms.TextBox txtNumbExteriorMurals;
        private System.Windows.Forms.Label lblCostInterior;
        private System.Windows.Forms.Label lblCostExterior;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblRevenueTotal;
        private System.Windows.Forms.Label lblSchedulingRemarks;
        private System.Windows.Forms.TextBox txtRevenueInterior;
        private System.Windows.Forms.TextBox txtRevenueExterior;
        private System.Windows.Forms.TextBox txtRevenueTotal;
    }
}

