using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../Imagem/uslogin.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close()
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            MEU_BD bancoDeDados = new MEU_BD();
            MySqlDataAdapter adaptador = new MySqlDataAdapter();
        DataTable tabela = new DataTable();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `usuarios` WHERE 1 `username` = @usn AND `password` = @psw", bancoDeDados.getConexao);
        }
    }
}
