﻿// Helpers...
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace TwainDirectScanner
{
    public partial class ConfirmScan : Form
    {
        /// <summary>
        /// Init us...
        /// </summary>
        public ConfirmScan(float a_fScale)
        {
            // Init stuff...
            InitializeComponent();

            // Scaling...
            if ((a_fScale > 0) && (a_fScale != 1))
            {
                if (a_fScale > 4)
                {
                    a_fScale = 4;
                }
                this.Font = new Font(this.Font.FontFamily, this.Font.Size * a_fScale, this.Font.Style);
            }

            // Try to make a noise...
            SystemSounds.Beep.Play();
        }

        /// <summary>
        /// Sure, let's do it...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_buttonYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        /// <summary>
        /// Nope...nope...not gonna do it...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_buttonNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
    }
}
