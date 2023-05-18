using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ReclutamientoNovaJrMTG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ReclutamientoNovaJrMTG
{
    /// <summary>
    /// Interaction logic for Sucursal.xaml
    /// </summary>
    public partial class Sucursal : Window
    {
        private MTGDBContext _context = new MTGDBContext();
        public Sucursal()
        {
            
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // this is for demo purposes only, to make it easier
            // to get up and running
            _context.Database.EnsureCreated();

            // load the entities into EF Core
            _context.Sucursales.Load();

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombreSucursal.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string sucursalmatris = txtSucursalMatriz.Text;
            string creadopor = txtCreadoPor.Text;

            using (var conn = new SqlConnection("Server=localhost;Database=MTGDB;Trusted_Connection=True;TrustServerCertificate=True;"))
            {
                var cmd = new SqlCommand("insert into Sucursales values (@SucursalID, @NombreComercial, @Telefono, @Email, @SucursalMatriz, @CreadoPor, @FechaAlta, @FechaModificacion)", conn);
                cmd.Parameters.AddWithValue("@SucursalID", "DEV");
                cmd.Parameters.AddWithValue("@NombreComercial", nombre);
                cmd.Parameters.AddWithValue("@Telefono", telefono);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@SucursalMatriz", sucursalmatris);
                cmd.Parameters.AddWithValue("@CreadoPor", creadopor);
                cmd.Parameters.AddWithValue("@FechaAlta", DateTime.Now);
                cmd.Parameters.AddWithValue("@FechaModificacion", DateTime.Now);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            

            //Sucursales sucursales = new Sucursales();
            //sucursales.SucursalId = "1DEV";
            //sucursales.NombreComercial = nombre;
            //sucursales.Telefono = telefono;
            //sucursales.Email = email;
            //sucursales.SucursalMatriz = sucursalmatris;
            //sucursales.CreadoPor = creadopor;
            //sucursales.FechaAlta = DateTime.Now;
            //sucursales.FechaModificacion = DateTime.Now;
            //_context.SaveChanges();

        }
    }
}
