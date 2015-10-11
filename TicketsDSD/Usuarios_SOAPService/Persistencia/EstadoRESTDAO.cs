using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Usuarios_SOAPService.Dominio;

namespace Usuarios_SOAPService.Persistencia
{
    public class EstadoRESTDAO
    {
        public Estado Crear(Estado estadoACrear)
        {
            Estado estadoCreado = null;
            string sql = "INSERT INTO t_estado VALUES (@Id, @estado)";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    string id = estadoACrear.Id.ToString();
                    com.Parameters.Add(new SqlParameter("@Id", id));
                    com.Parameters.Add(new SqlParameter("@estado", estadoACrear.EstadoTicket));
                    com.ExecuteNonQuery();
                }
            }
            estadoCreado = Obtener(estadoACrear.Id.ToString());
            return estadoCreado;

        }
        public Estado Obtener(string codigo)
        {
            Estado estadoEncontrado = null;
            string sql = "SELECT * FROM t_estado WHERE id=@Id";
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
                            estadoEncontrado = new Estado()
                            {
                                Id = (int)resultado["Id"],
                                EstadoTicket = (string)resultado["EstadoTicket"]
                            };
                        }
                    }
                }
            }
            return estadoEncontrado;
        }
        public Estado Modificar(Estado estadoAModificar)
        {
            Estado estadoModificado = null;
            string sql = "UPDATE t_estado VALUES SET id=@Id, estado=@estado WHERE id=@Id";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    string id1 = estadoAModificar.Id.ToString();
                    com.Parameters.Add(new SqlParameter("@Id", id1));
                    com.Parameters.Add(new SqlParameter("@estado", estadoAModificar.EstadoTicket));
                    com.ExecuteNonQuery();
                }
            }
            estadoModificado = Obtener(estadoAModificar.Id.ToString());
            return estadoModificado;
        }
        public void Eliminar(string codigo)
        {
            string sql = "DELETE FROM t_estado WHERE id=@Id";
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
        public List<Estado> ListarTodos()
        {

            List<Estado> estados = new List<Estado>();
            string sql = "SELECT * FROM t_estado";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            Estado campo = new Estado()
                            {
                                Id = (int)resultado["Id"],
                                EstadoTicket = (string)resultado["EstadoTicket"]
                            };

                            estados.Add(campo);
                        }
                    }
                }
            }
            return estados;
        }
    }
}