/* 
 * Nathan Pache
 * IDA-P1A
 * Gestionnair de dépenses
 */

namespace gestionair_depenses
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        /* pour les boutton de la page d'accuil */
        private void btnStats_Click(object sender, EventArgs e)
        {
            //ouvre frmstats
            frmStats frmstats = new frmStats();
            frmstats.Show();
        }


        private void btnsettings_Click(object sender, EventArgs e)
        {
            // Ouvre frmsettings
            frmsettings frmsettings = new frmsettings();
            frmsettings.Show();
        }

        /* pour les boutton du menu */
        private void statistiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvre frmstats
            frmStats frmstats = new frmStats();
            frmstats.Show();
        }

        private void parametresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvre frmsettings
            frmsettings frmsettings = new frmsettings();
            frmsettings.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ouvre fradd
            frmAdd frmadd = new frmAdd();
            frmadd.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Ouvre fradd
            frmAdd frmadd = new frmAdd();
            frmadd.Show();
        }
    }
}