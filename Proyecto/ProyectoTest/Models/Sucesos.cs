﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTest.Models
{
    public class Sucesos
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Medios oMarca { get; set; }
        public Categoria oCategoria { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public string RutaImagen { get; set; }
        public bool Activo { get; set; }
        public string base64 { get; set; }
        public string extension { get; set; }
    }
}