using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace gestionair_depenses
{
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }

        private void tbxMontant_TextChanged(object sender, EventArgs e)
        {
            //chaine de connection
            string connectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\nathan\\Desktop\\Buraux\\Cours\\Programation\\PROJET-GESTIONNAIR\\gestionair-depense\\gestionair-depenses\\gestionair-depenses\\Database1.mdf;Integrated Security=True";
            
            string query = "INSERT INTO depense (id, montant, nom, idCategorie)" +
                            "VALUES (1, value2, value3, ...);";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                
            }
        }
    }
}