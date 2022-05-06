using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace agencia
{
    //Clase abstracta
    abstract class Vehiculo
    {
        //Propiedades de la clase abstracta

        public bool Alquilado { get; set; }
        public double ImporteRenta { get; set; }
        public string Placas { get; set; }
        public string TipoVehiculo { get; set; }

        //Metodo abstracto que crea los vehiculos de ejemplo
        public abstract void CrearVehiculos();

        //Metodo que rentara el vehiculo
        public abstract void RentarVehiculo();

        //Metodo que devolvera el vehiculo a la agencia
        public abstract void DevolverVehiculo();
    }

    //Clase autobus
    class Autobus : Vehiculo
    {
        //Lista de autobuses
        public List<Autobus> misVehiculos = new List<Autobus>();

        //Propiedades

        public double PrecioKilometro { get; set; }
        public double CantidadKmFinal { get; set; }
        public double CantidadKmInicial { get; set; }

        //Metodo para añadir un autobus a la lista
        public void AñadirVehiculo(Autobus miVehiculo)
        {
            misVehiculos.Add(miVehiculo);
        }

        //Metodo que crea autobuses de ejemplo
        public override void CrearVehiculos()
        {
            string[] misPlacas = new string[] { "NUJE7LH4", "ZPVD3U37", "4ZF38MME", "YBST4FXZ", "PXQRQ9NR", "DUGWNEY5" };
            Random randomKm = new Random();
            for (int i = 0; i < 6; i++)
            {
                var autobus = new Autobus
                {
                    Placas = misPlacas[i],
                    Alquilado = false,
                    TipoVehiculo = "Autobus",
                    CantidadKmInicial = randomKm.Next(1000)
                };
                misVehiculos.ForEach((v) =>
                {
                    if (autobus.Placas == v.Placas)
                    {
                        MessageBox.Show("Vehiculo registrado");
                        return;
                    }
                });
                misVehiculos.Add(autobus);
            }
        }

        //metodo para rentar el vehiculo, cambia alquilado a true y muestra los datos
        public override void RentarVehiculo()
        {
            Alquilado = true;

            MessageBox.Show($"AUTOBUS\n" +
                            $"-------\n" +
                            $"Placas: {Placas}\n" +
                            $"Kilometros iniciales: {CantidadKmInicial}\n" +
                            $"Alquilado: {Alquilado}\n");
        }

        //Metodo para devolver el vehiculo, asigna Alquilado de vuelta a falso, hace los calculos para el importe
        //y muestra con un messagebox los datos
        public override void DevolverVehiculo()
        {
            Alquilado = false;

            ImporteRenta = (CantidadKmFinal - CantidadKmInicial) * PrecioKilometro;

            MessageBox.Show($"AUTOBUS\n" +
                            $"-------\n" +
                            $"Placas: {Placas}\n" +
                            $"Kilometros iniciales: {CantidadKmInicial}\n" +
                            $"Kilometros finales: {CantidadKmFinal}\n" +
                            $"Precio por kilómetro: {PrecioKilometro}\n" +
                            $"Alquilado: {Alquilado}\n" +
                            $"Importe a pagar: ({CantidadKmFinal} - {CantidadKmInicial}) x {PrecioKilometro} = {ImporteRenta}\n");

            //Actualiza la cantidad de kilometros recorridos
            CantidadKmInicial = CantidadKmFinal;
        }
    }

    //Clase tractor
    class Tractor : Vehiculo
    {
        //Lista de tractores
        public List<Tractor> misVehiculos = new List<Tractor>();

        //Propiedades

        public DateTime FechaDevolucion { get; set; }
        public DateTime FechaRenta { get; set; }
        public double PrecioDia { get; set; }

        //Metodo para añadir un tractor a la lista
        public void AñadirVehiculo(Tractor miVehiculo)
        {
            misVehiculos.Add(miVehiculo);
        }

        //Metodo que crea tractores de ejemplo
        public override void CrearVehiculos()
        {
            string[] misPlacas = new string[] { "BK62S6PU", "955NXTK2", "KL4KPDSY", "NQGDV7KR", "ZNF7MK2Q", "UU9H37NU" };
            for (int i = 0; i < 6; i++)
            {
                var tractor = new Tractor
                {
                    Placas = misPlacas[i],
                    Alquilado = false,
                    TipoVehiculo = "Tractor"
                };
                misVehiculos.Add(tractor);
            }
        }

        //Metodo para rentar el vehiculo, cambia alquilado a true y muestra los datos
        public override void RentarVehiculo()
        {
            Alquilado = true;

            FechaRenta = DateTime.Now;
            MessageBox.Show($"TRACTOR\n" +
                            $"-------\n" +
                            $"Placas: {Placas}\n" +
                            $"Fecha de renta: {FechaRenta.ToShortDateString()}\n" +
                            $"Alquilado: {Alquilado}");
        }

        //Metodo para devolver el vehiculo, asigna Alquilado de vuelta a falso, hace los calculos para el importe
        //y muestra con un messagebox los datos
        public override void DevolverVehiculo()
        {
            Alquilado = false;

            FechaDevolucion = DateTime.Now;

            double diasRentado = Math.Round((FechaDevolucion - FechaRenta).TotalDays + 1);
            ImporteRenta = PrecioDia * diasRentado;

            MessageBox.Show($"TRACTOR\n" +
                            $"-------\n" +
                            $"Placas: {Placas}\n" +
                            $"Alquilado: {Alquilado}\n" +
                            $"Fecha de renta: {FechaRenta.ToShortDateString()}\n" +
                            $"Fecha de devolución: {FechaDevolucion.ToShortDateString()}\n" +
                            $"Precio por día: {PrecioDia}\n" +
                            $"Días que fue alquilado: {diasRentado}\n" +
                            $"Importe a pagar: ${ImporteRenta}");
        }
    }
}