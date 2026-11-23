using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Abstractions;

namespace CleanArchitecture.Domain.Vehiculos
{
    public class Vehiculo : Entity
    {   
        public Vehiculo(
            Guid id,
            Modelo modelo,
            Vin vin,
            Moneda precio,
            Moneda mantenimiento,
            DateTime? fechaUltimoAlquiler,
            List<Accesorio> accesorios,
            Direccion? direccion
        ) : base(id)
        {
            Modelo = modelo;
            Vin = vin;
            Precio = precio;
            Mantenimiento = mantenimiento;
            FechaUltimoAlquiler = fechaUltimoAlquiler;
            Accesorios = accesorios;
            Direccion = direccion;
        }


        public Modelo? Modelo {get; private set;}
        public Vin? Vin {get; private set;}
        public Direccion? Direccion {get; private set;} //Objet Value
        //public decimal Precio {get; private set;}
        //public string? TipoMoneda {get; private set;}

        public Moneda Precio {get;  private set;}
        public Moneda Mantenimiento {get; private set;}
        public string? MantenimientoTipoMoneda {get; private set;}
        public DateTime? FechaUltimoAlquiler {get; private set;}
        public List<Accesorio> Accesorios {get; private set;}

        
    }
}