using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Usuarios_SOAPService.Dominio;

namespace Usuarios_SOAPService.Persistencia
{
    public class PrioridadRESTDAO
    {
        public Prioridad Crear(Prioridad prioridadACrear)
        {
            Prioridad estadoCreado = null;
            string sql = "INSERT INTO t_prioridad VALUES (@Id, @prioridad)";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    string id = prioridadACrear.Id.ToString();
                    com.Parameters.Add(new SqlParameter("@Id", id));
                    com.Parameters.Add(new SqlParameter("@prioridad", prioridadACrear.PrioridadTicket));
                    com.ExecuteNonQuery();
                }
            }
            estadoCreado = Obtener(prioridadACrear.Id.ToString());
            return estadoCreado;

        }
        public Prioridad Obtener(string codigo)
        {
            Prioridad prioridadEncontrado = null;
            string sql = "SELECT * FROM t_prioridad WHERE id=@Id";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@Id", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            prioridadEncontrado = new Prioridad()
                            {
                                Id = (int)resultado["Id"],
                                PrioridadTicket = (string)resultado["PrioridadTicket"]
                            };
                        }
                    }
                }
            }
            return prioridadEncontrado;
        }
        public Prioridad Modificar(Prioridad prioridadAModificar)
        {
            Prioridad prioridadModificado = null;
            string sql = "UPDATE t_prioridad VALUES SET id=@Id, estado=@estado WHERE id=@Id";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    string id = prioridadAModificar.Id.ToString();
                    com.Parameters.Add(new SqlParameter("@Id", id));
                    com.Parameters.Add(new SqlParameter("@prioridad", prioridadAModificar.PrioridadTicket));
                    com.ExecuteNonQuery();
                }
            }
            prioridadModificado = Obtener(prioridadAModificar.Id.ToString());
            return prioridadModificado;
        }
        public void Eliminar(string codigo)
        {
            string sql = "DELETE FROM t_prioridad WHERE id=@Id";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@Id", codigo));
                    com.ExecuteNonQuery();
                }
            }
        }
        public List<Prioridad> ListarTodos()
        {
            List<Prioridad> prioridades = new List<Prioridad>();
            string sql = "SELECT * FROM t_prioridad";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            Prioridad campo = new Prioridad()
                            {
                                Id = (int)resultado["Id"],
                                PrioridadTicket = (string)resultado["PrioridadTicket"]
                            };

                            prioridades.Add(campo);
                        }
                    }
                }
            }
            return prioridades;
        }
    }
}