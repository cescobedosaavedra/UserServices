using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Usuarios_SOAPService.Dominio;

namespace Usuarios_SOAPService.Persistencia
{
    public class EmpleadoRESTDAO
    {
        public Empleado Crear(Empleado usuarioACrear)
        {
            Empleado usuarioCreado = null;
            string sql = "INSERT INTO t_empleado VALUES (@cod, @nom, @apell, @correo, @cargo, @telf, @area, @password, @estado, @tipo, @loginErrorCount)";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    string codigo = usuarioACrear.CodEmpleado.ToString();
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    com.Parameters.Add(new SqlParameter("@nom", usuarioACrear.NombreEmpleado));
                    com.Parameters.Add(new SqlParameter("@apell", usuarioACrear.ApellidoEmpleado));
                    com.Parameters.Add(new SqlParameter("@correo", usuarioACrear.CorreoEmpleado));
                    com.Parameters.Add(new SqlParameter("@cargo", usuarioACrear.CargoEmpleado));
                    com.Parameters.Add(new SqlParameter("@telf", usuarioACrear.TelefonoEmpleado));
                    com.Parameters.Add(new SqlParameter("@area", usuarioACrear.AreaEmpleado));
                    com.Parameters.Add(new SqlParameter("@password", usuarioACrear.Password));
                    com.Parameters.Add(new SqlParameter("@estado", usuarioACrear.Estado));
                    com.Parameters.Add(new SqlParameter("@tipo", usuarioACrear.Tipo));
                    com.Parameters.Add(new SqlParameter("@loginErrorCount", usuarioACrear.LoginErrorCount));
                    com.ExecuteNonQuery();
                }
            }
            usuarioCreado = Obtener(usuarioACrear.CodEmpleado.ToString());
            return usuarioCreado;

       }
        public Empleado Obtener(string codigo)
        {
            Empleado usuarioEncontrado = null;
            string sql = "SELECT * FROM t_empleado WHERE CodEmpleado=@cod";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            usuarioEncontrado = new Empleado()
                            {
                                CodEmpleado = (int)resultado["CodEmpleado"],
                                NombreEmpleado = (string)resultado["NombreEmpleado"],
                                ApellidoEmpleado = (string)resultado["ApellidoEmpleado"],
                                CorreoEmpleado = (string)resultado["CorreoEmpleado"],
                                CargoEmpleado = (string)resultado["CargoEmpleado"],
                                TelefonoEmpleado = (string)resultado["TelefonoEmpleado"],
                                AreaEmpleado = (string)resultado["AreaEmpleado"],
                                Password = (string)resultado["Password"],
                                Estado = (string)resultado["Estado"],
                                Tipo = (string)resultado["Tipo"],
                                LoginErrorCount = (int)resultado["loginErrorCount"]
                                
                            };
                        }
                    }
                }
            }
            return usuarioEncontrado;
        }

        public Empleado ObtenerNombre(string nombre)
        {
            Empleado usuarioEncontrado = null;
            string sql = "SELECT * FROM t_empleado WHERE NombreEmpleado=@nom";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@nom", nombre));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            usuarioEncontrado = new Empleado()
                            {
                                CodEmpleado = (int)resultado["CodEmpleado"],
                                NombreEmpleado = (string)resultado["NombreEmpleado"],
                                ApellidoEmpleado = (string)resultado["ApellidoEmpleado"],
                                CorreoEmpleado = (string)resultado["CorreoEmpleado"],
                                CargoEmpleado = (string)resultado["CargoEmpleado"],
                                TelefonoEmpleado = (string)resultado["TelefonoEmpleado"],
                                AreaEmpleado = (string)resultado["AreaEmpleado"],
                                Password = (string)resultado["Password"],
                                Estado = (string)resultado["Estado"],
                                Tipo = (string)resultado["Tipo"],
                                LoginErrorCount = (int)resultado["loginErrorCount"]
                            };
                        }
                    }
                }
            }
            return usuarioEncontrado;
        }
        public Empleado Modificar(Empleado usuarioAModificar)
        {
            //, ApellidoEmpleado=@apell, CorreoEmpleado=@correo, CargoEmpleado=@cargo, TelefonoEmpleado=@telf, AreaEmpleado=@area, Password=@password, Estado=@estado, Tipo=@tipo, LoginErrorCount=@loginErrorCount  
            Empleado usuarioModificado = null;
            string sql = "UPDATE t_empleado SET CodEmpleado=@cod, NombreEmpleado=@NombreEmpleado, ApellidoEmpleado=@apell, CorreoEmpleado=@correo, CargoEmpleado=@cargo, TelefonoEmpleado=@telf, AreaEmpleado=@area, Password=@password, Estado=@estado, Tipo=@tipo, LoginErrorCount=@loginErrorCount  WHERE CodEmpleado=@cod";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", usuarioAModificar.CodEmpleado.ToString()));
                    com.Parameters.Add(new SqlParameter("@NombreEmpleado", usuarioAModificar.NombreEmpleado));
                    com.Parameters.Add(new SqlParameter("@apell", usuarioAModificar.ApellidoEmpleado));
                    com.Parameters.Add(new SqlParameter("@correo", usuarioAModificar.CorreoEmpleado));
                    com.Parameters.Add(new SqlParameter("@cargo", usuarioAModificar.CargoEmpleado));
                    com.Parameters.Add(new SqlParameter("@telf", usuarioAModificar.TelefonoEmpleado));
                    com.Parameters.Add(new SqlParameter("@area", usuarioAModificar.AreaEmpleado));
                    com.Parameters.Add(new SqlParameter("@password", usuarioAModificar.Password));
                    com.Parameters.Add(new SqlParameter("@estado", usuarioAModificar.Estado));
                    com.Parameters.Add(new SqlParameter("@tipo", usuarioAModificar.Tipo));
                    com.Parameters.Add(new SqlParameter("@loginErrorCount", usuarioAModificar.LoginErrorCount.ToString()));
                    com.ExecuteNonQuery();
                }
            }
            usuarioModificado = Obtener(usuarioAModificar.CodEmpleado.ToString());
            return usuarioModificado;
        }

        public Empleado ModificarLoginError(Empleado usuarioAModificar)
        {
            //, ApellidoEmpleado=@apell, CorreoEmpleado=@correo, CargoEmpleado=@cargo, TelefonoEmpleado=@telf, AreaEmpleado=@area, Password=@password, Estado=@estado, Tipo=@tipo, LoginErrorCount=@loginErrorCount  
            Empleado usuarioModificado = null;
            string sql = "UPDATE t_empleado SET CodEmpleado=@cod, LoginErrorCount=@loginErrorCount  WHERE CodEmpleado=@cod";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //string estado = usuarioAModificar.Estado;
                    string loginError = usuarioAModificar.LoginErrorCount.ToString();
                    string codigo = usuarioAModificar.CodEmpleado.ToString();
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    //com.Parameters.Add(new SqlParameter("@estado", estado));
                    com.Parameters.Add(new SqlParameter("@loginErrorCount", loginError));
                    com.ExecuteNonQuery();
                }
            }
            usuarioModificado = Obtener(usuarioAModificar.CodEmpleado.ToString());
            return usuarioModificado;
        }
        public Empleado ModificarEstado(Empleado usuarioAModificar)
        {
            //, ApellidoEmpleado=@apell, CorreoEmpleado=@correo, CargoEmpleado=@cargo, TelefonoEmpleado=@telf, AreaEmpleado=@area, Password=@password, Estado=@estado, Tipo=@tipo, LoginErrorCount=@loginErrorCount  
            Empleado usuarioModificado = null;
            string sql = "UPDATE t_empleado SET CodEmpleado=@cod, Estado=@Estado WHERE CodEmpleado=@cod";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //string estado = usuarioAModificar.Estado;
                    string loginError = usuarioAModificar.LoginErrorCount.ToString();
                    string codigo = usuarioAModificar.CodEmpleado.ToString();
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    //com.Parameters.Add(new SqlParameter("@estado", estado));
                    com.Parameters.Add(new SqlParameter("@Estado", usuarioAModificar.Estado));
                    com.ExecuteNonQuery();
                }
            }
            usuarioModificado = Obtener(usuarioAModificar.CodEmpleado.ToString());
            return usuarioModificado;
        }
        public void Eliminar(string codigo)
        {
            string sql = "DELETE FROM t_empleado WHERE CodEmpleado=@cod";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codigo));
                    com.ExecuteNonQuery();
                }
            }
        }
        public List<Empleado> ListarTodos()
        {
            List<Empleado> usuarios = new List<Empleado>();
            string sql = "SELECT * FROM t_empleado";
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.HasRows)
                        {
                            while (resultado.Read())
                            {
                                Empleado campo = new Empleado()
                                {
                                    CodEmpleado = (int)resultado["CodEmpleado"],
                                    NombreEmpleado = (string)resultado["NombreEmpleado"],
                                    ApellidoEmpleado = (string)resultado["ApellidoEmpleado"],
                                    CorreoEmpleado = (string)resultado["CorreoEmpleado"],
                                    CargoEmpleado = (string)resultado["CargoEmpleado"],
                                    TelefonoEmpleado = (string)resultado["TelefonoEmpleado"],
                                    AreaEmpleado = (string)resultado["AreaEmpleado"],
                                    Password = (string)resultado["Password"],
                                    Estado= (string)resultado["Estado"],
                                    Tipo = (string)resultado["Tipo"],
                                    LoginErrorCount = (int)resultado["loginErrorCount"]
                                };

                                usuarios.Add(campo);
                            }
                        }
                    }
                }
            }
            return usuarios;
        }
    }
}