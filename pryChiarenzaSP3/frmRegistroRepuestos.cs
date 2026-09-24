using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryChiarenzaSP3
{
    public partial class frmRepuestos : Form
    {

        // DECLARACION DE VARIABLES GLOBALES

        // Array de 1 dimension - vector - sin elementos
        string[] vecRegistros;

        // Array de 2 dimensiones - matriz - sin elementos
        string[,] matRegistros;

        // Array de 1 dimension - vector - sin elementos
        string[] vecRepuestos = new string[3];

        // Array de 2 dimensiones - matriz
        string[,] matRepuestos = new string[2, 2];

        int indiceRegistros = 0;

        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void frmRepuestos_Load(object sender, EventArgs e)
        {
            cmbMarca.Items.Add("P");
            cmbMarca.Items.Add("F");
            cmbMarca.Items.Add("R");
        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string varMarca = cmbMarca.Text;
            string varOrigen;

            // Estoy registrando como texto a Marca. lo cargado se guardara en la cmb

            if (rdbNacional.Checked == true)
            {
                varOrigen = "Nacional";

            }

            else
            {

                varOrigen = "Importado";

            }



            lsbDatos.Items.Add(varMarca + "  " + varOrigen);

            // Grabar en el VECTOR - Array de 1 dimension

            vecRepuestos[indiceRegistros] =  varMarca + " " + varOrigen;
            indiceRegistros++;

            if (indiceRegistros == vecRepuestos.Length)
            {
                btnRegistrar.Enabled = false;
                MessageBox.Show("Se ha completado el registro de repuestos");
            }


            // Añadir los elementos del vector a la lista

            // Bucle repetitivo p/ recorrer el vector y añadir sus elementos a la lista
            for (int indice = 0; indice < vecRepuestos.Length; indice++)
            {
                lsbDatos.Items.Add(vecRepuestos[indice]);
            }

        }

    }
}

