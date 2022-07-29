using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fidget_Program
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Enable and disable buttons
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_on_Click(object sender, EventArgs e)
        {
            btn_off.Enabled = true;
            btn_on.Enabled = false;
        }
        /// <summary>
        /// Enable and disable buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_off_Click(object sender, EventArgs e)
        {
            btn_off.Enabled = false;
            btn_on.Enabled = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_fidget.Clear();
        }

        private void btn_rammstein_Click(object sender, EventArgs e)
        {

        }
    }
}
