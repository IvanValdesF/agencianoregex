using System;
using System.Windows.Forms;

namespace agencia
{
    public partial class Form1 : Form
    {
        //Instancias de cada tipo de vehiculo
        private Autobus miAutobus = new Autobus();

        private Tractor miTractor = new Tractor();

        public Form1()
        {
            InitializeComponent();

            //Crea los vehículos iniciales de ejemplo
            miAutobus.CrearVehiculos();

            miTractor.CrearVehiculos();

            //Carga los datos en el datagrid
            foreach (Autobus miAutobus in miAutobus.misVehiculos)
            {
                dtgVehiculo.Rows.Add(miAutobus.Alquilado, miAutobus.Placas, miAutobus.TipoVehiculo, miAutobus.CantidadKmInicial);
            }
            foreach (Tractor miTractor in miTractor.misVehiculos)
            {
                dtgVehiculo.Rows.Add(miTractor.Alquilado, miTractor.Placas, miTractor.TipoVehiculo, "-----");
            }
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            //Ejecuta el metodo RentarVehiculo correspondiente a cada tipo de vehiculo según la opción seleccionada, la lista toma
            //como posición el indice de la fila seleccionada en el datagrid
            if (dtgVehiculo.CurrentCell.RowIndex < miTractor.misVehiculos.Count)
            {
                miAutobus.misVehiculos[dtgVehiculo.CurrentCell.RowIndex].RentarVehiculo();
            }
            else
            {
                miTractor.misVehiculos[dtgVehiculo.CurrentCell.RowIndex - miTractor.misVehiculos.Count].RentarVehiculo();
            }

            //Actualiza los datos en el datagrid
            dtgVehiculo.Rows.Clear();
            foreach (Autobus miAutobus in miAutobus.misVehiculos)
            {
                dtgVehiculo.Rows.Add(miAutobus.Alquilado, miAutobus.Placas, miAutobus.TipoVehiculo, miAutobus.CantidadKmInicial);
            }
            foreach (Tractor miTractor in miTractor.misVehiculos)
            {
                dtgVehiculo.Rows.Add(miTractor.Alquilado, miTractor.Placas, miTractor.TipoVehiculo, "-----");
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string strPlacas = "";
            miAutobus.misVehiculos.ForEach((v) => strPlacas += v.Placas.ToString() + ",");
            miTractor.misVehiculos.ForEach((v) => strPlacas += v.Placas.ToString() + ",");
            //valida que no haya campos vacios en cada uno de los groupbox
            foreach (Control control in grpVehiculo.Controls)
            {
                if (control.Text.Trim() == "" || control.Text == "0.00")
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }
            }
            
            //Crea un objeto con sus datos correspondientes y los añade mediante el metodo de la clase
            if (cbxTipo.Text == "Autobus")
            {
                var autobus = new Autobus
                {
                    Placas = txtPlaca.Text,
                    Alquilado = false,
                    TipoVehiculo = "Autobus",
                    CantidadKmInicial = (double)nudKilometrajeInicial.Value
                };
                
                
                

                if (!strPlacas.Contains(txtPlaca.Text))
                    {
                        miAutobus.AñadirVehiculo(autobus);
                    }
                    else
                    {
                        MessageBox.Show("Vehiculo ya registrado");
                    }
                
                
                
            }
            if (cbxTipo.Text == "Tractor")
            {
                var tractor = new Tractor
                {
                    Placas = txtPlaca.Text,
                    Alquilado = false,
                    TipoVehiculo = "Tractor",
                };

                

                


                if (!strPlacas.Contains(txtPlaca.Text))
                {
                    miTractor.AñadirVehiculo(tractor);
                }
                else
                {
                    MessageBox.Show("Vehiculo ya registrado");
                }
            }

            //Actualiza los datos en el datagrid
            dtgVehiculo.Rows.Clear();
            foreach (Autobus miAutobus in miAutobus.misVehiculos)
            {
                dtgVehiculo.Rows.Add(miAutobus.Alquilado, miAutobus.Placas, miAutobus.TipoVehiculo, miAutobus.CantidadKmInicial);
            }
            foreach (Tractor miTractor in miTractor.misVehiculos)
            {
                dtgVehiculo.Rows.Add(miTractor.Alquilado, miTractor.Placas, miTractor.TipoVehiculo, "-----");
            }
        }

        //Boton qu mediante un foreach para cada lista busca la placa especificada en ambas lista y selecciona la fila
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int index = 0;
            string strPlacas = "";
            foreach (Autobus miAutobus in miAutobus.misVehiculos)
            {
                
                
                //Se usa el metodo Contains para buscar en la propiedad Placas de cada objeto
                if (miAutobus.Placas.ToLower().Contains(txtPlaca.Text.ToLower()))
                {
                    //Si encuentra la placa rellena los controles con los datos correspondientes
                    dtgVehiculo.Rows[index].Selected = true;
                    txtPlaca.Text = miAutobus.Placas;
                    nudKilometrajeInicial.Value = (decimal)miAutobus.CantidadKmInicial;
                    cbxTipo.Text = "Autobus";
                }
                index++;
                strPlacas += miAutobus.Placas.ToLower();
            }

            

            foreach (Tractor miTractor in miTractor.misVehiculos)
            {
                if (miTractor.Placas.ToLower().Contains(txtPlaca.Text.ToLower()))
                {
                    dtgVehiculo.Rows[index].Selected = true;
                    txtPlaca.Text = miTractor.Placas;
                    cbxTipo.Text = "Tractor";
                }
                index++;
                strPlacas += miTractor.Placas.ToLower();
            }
            if (!strPlacas.Contains(txtPlaca.Text.ToLower()))
            {
                MessageBox.Show("Vehiculo no encontrado");
            }
        }

        //Boton que ejecutara los metodos para devolver el vehiculo a la agencia
        private void btnDevolver_Click(object sender, EventArgs e)
        {
            //Para que se pueda seleccionar el vehiculo desde el datagrid se usó como indice de la lista
            //el indice de la fila seleccionada
            if (dtgVehiculo.CurrentCell.RowIndex < miTractor.misVehiculos.Count)
            {
                //Valida que no se intente devolver un vehiculo que no ha sido alquilado
                if (!miAutobus.misVehiculos[dtgVehiculo.CurrentCell.RowIndex].Alquilado)
                {
                    MessageBox.Show("Este vehículo no ha sido alquilado");
                    return;
                }
                //Se asignan los datos necearios para devolver el vehiculo
                miAutobus.misVehiculos[dtgVehiculo.CurrentCell.RowIndex].PrecioKilometro = (double)nudPrecioKilometro.Value;
                miAutobus.misVehiculos[dtgVehiculo.CurrentCell.RowIndex].CantidadKmFinal = (double)nudKilometrajeFinal.Value;

                //Valida que los kilometros finales no sean menor a los kilometros iniciales
                if (miAutobus.misVehiculos[dtgVehiculo.CurrentCell.RowIndex].CantidadKmFinal < miAutobus.misVehiculos[dtgVehiculo.CurrentCell.RowIndex].CantidadKmInicial)
                {
                    MessageBox.Show("Verifique los kilometros finales");
                    nudKilometrajeFinal.Focus();
                    return;
                }
                //Se llama al metodo para devolver el vehiculo a la agencia
                miAutobus.misVehiculos[dtgVehiculo.CurrentCell.RowIndex].DevolverVehiculo();
            }
            else
            {
                //Valida que no se intente devolver un vehiculo que no ha sido alquilado
                if (!miTractor.misVehiculos[dtgVehiculo.CurrentCell.RowIndex - miTractor.misVehiculos.Count].Alquilado)
                {
                    MessageBox.Show("Este vehículo no ha sido alquilado");
                    return;
                }
                //Se asignan los datos necearios para devolver el vehiculo
                miTractor.misVehiculos[dtgVehiculo.CurrentCell.RowIndex - miTractor.misVehiculos.Count].PrecioDia = (double)nudPrecioDia.Value;
                //Se llama al metodo para devolver el vehiculo a la agencia
                miTractor.misVehiculos[dtgVehiculo.CurrentCell.RowIndex - miTractor.misVehiculos.Count].DevolverVehiculo();
            }

            //Actualiza los datos en los datagrid
            dtgVehiculo.Rows.Clear();
            foreach (Autobus miAutobus in miAutobus.misVehiculos)
            {
                dtgVehiculo.Rows.Add(miAutobus.Alquilado, miAutobus.Placas, miAutobus.TipoVehiculo, miAutobus.CantidadKmInicial);
            }
            foreach (Tractor miTractor in miTractor.misVehiculos)
            {
                dtgVehiculo.Rows.Add(miTractor.Alquilado, miTractor.Placas, miTractor.TipoVehiculo, "-----");
            }
        }

        //Oculta o muestra los controles segun el tipo de vehiculo seleccionado
        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.Text == "Autobus")
            {
                gbxTractor.Enabled = false;
                gbxAutobus.Enabled = true;
            }
            if (cbxTipo.Text == "Tractor")
            {
                gbxTractor.Enabled = true;
                gbxAutobus.Enabled = false;
            }
        }

        //Carga los datos en los controles segun la fila seleccionada
        private void dtgVehiculo_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgVehiculo.CurrentCell.RowIndex < miTractor.misVehiculos.Count)
            {
                txtPlaca.Text = miAutobus.misVehiculos[dtgVehiculo.CurrentCell.RowIndex].Placas;
                cbxTipo.Text = miAutobus.misVehiculos[dtgVehiculo.CurrentCell.RowIndex].TipoVehiculo;
                nudKilometrajeInicial.Value = (decimal)miAutobus.misVehiculos[dtgVehiculo.CurrentCell.RowIndex].CantidadKmInicial;
            }
            else
            {
                txtPlaca.Text = miTractor.misVehiculos[dtgVehiculo.CurrentCell.RowIndex - miTractor.misVehiculos.Count].Placas;
                cbxTipo.Text = miTractor.misVehiculos[dtgVehiculo.CurrentCell.RowIndex - miTractor.misVehiculos.Count].TipoVehiculo;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }
    }
}