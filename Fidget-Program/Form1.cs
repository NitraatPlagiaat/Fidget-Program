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
        /// <algo>
        /// enable the off button
        /// disable the on button
        /// </algo>
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
        /// <algo>
        /// disable the off button
        /// enable the on button
        /// </algo>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_off_Click(object sender, EventArgs e)
        {
            btn_off.Enabled = false;
            btn_on.Enabled = true;
        }

        /// <summary>
        /// Clear the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_fidget.Clear();
        }

        /// <summary>
        /// open a random song of Rammstein
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_rammstein_Click(object sender, EventArgs e)
        {
            Music.getRandomSong(Music.rammstein);
        }

        /// <summary>
        /// open a random song from Slipknot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_slipknot_Click(object sender, EventArgs e)
        {
            Music.getRandomSong(Music.slipknot);
        }

        /// <summary>
        /// open a random song from Behemoth
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_behemoth_Click(object sender, EventArgs e)
        {
            Music.getRandomSong(Music.behemoth);
        }

        /// <summary>
        /// open a random song from Muse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_muse_Click(object sender, EventArgs e)
        {
            Music.getRandomSong(Music.muse);
        }

        /// <summary>
        /// open horror ambient sound/music
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_horrorAmbience_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=HmkBpCBLnCg");
        }
    }
}
