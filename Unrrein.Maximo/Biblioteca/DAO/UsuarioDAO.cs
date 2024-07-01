using Biblioteca.clases;
using Biblioteca.sql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca.DAO
{
    public class UsuarioDAO
    {
        private SqlConnection sqlConnection;

        public UsuarioDAO()
        {
            SqlManager singletonInstance = SqlManager.GetInstance();
            this.sqlConnection = singletonInstance.GetConnection();
        }

        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> listaAux = new List<Usuario>();

            try
            {
                string command = "SELECT * FROM Usuarios";
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string nombre = reader.GetString(1);
                        string apellido = reader.GetString(2);
                        int dni = reader.GetInt32(3);
                        string genero = reader.GetString(4);
                        string tipoUsuario = reader.GetString(5);
                        string nombreUsuario = reader.GetString(8);
                        string contraseñaUsuario = reader.GetString(9);
                        string mail = reader.GetString(11);

                        Usuario usuario;
                        if (tipoUsuario == "Doctor")
                        {
                            string especialidad = reader.GetString(6);
                            string rangoHorario = reader.GetString(10);
                            Doctor doctorAux = new Doctor(nombre, apellido, dni, char.Parse(genero), Enum.Parse<RangoHorario>(rangoHorario), Enum.Parse<Especialidades>(especialidad));
                            List<Paciente> listaPacientes = this.CompletarListaPacientes(id, sqlConnection);
                            doctorAux.ListaPacientes = listaPacientes;
                            Usuario usuarioAux = new Usuario(doctorAux, nombreUsuario, contraseñaUsuario, mail);
                            usuario = usuarioAux;
                        }
                        else if(tipoUsuario == "Paciente")
                        {
                            string enfermedad = reader.IsDBNull(7) ? null : reader.GetString(7);
                            Paciente pacienteAux = new Paciente(nombre, apellido, dni, char.Parse(genero));
                            Turno turno = this.TurnoPaciente(id, sqlConnection);
                            pacienteAux.Turno = turno;
                            Usuario usuarioAux = new Usuario(pacienteAux, nombreUsuario, contraseñaUsuario, mail);
                            usuario = usuarioAux;
                        }
                        else
                        {
                            usuario = new Usuario(nombreUsuario, contraseñaUsuario, mail);
                        }

                        listaAux.Add(usuario);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en ListarUsuarios: {ex.Message}");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
            return listaAux;
        }

        private List<Paciente> CompletarListaPacientes(int idDoctor, SqlConnection connection)
        {
            List<Paciente> listaPacientesAux = new List<Paciente>();

            string command = @"
                    SELECT u.ID, u.Nombre, u.Apellido, u.DNI, u.Genero, u.Enfermedad 
                    FROM Turnos t
                    INNER JOIN Usuarios u ON t.PacienteID = u.ID
                    WHERE t.DoctorID = @idDoctor AND u.TipoUsuario = 'Paciente'";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@idDoctor", idDoctor);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int idPaciente = reader.GetInt32(0);
                            string nombre = reader.GetString(1);
                            string apellido = reader.GetString(2);
                            int dni = reader.GetInt32(3);
                            string genero = reader.GetString(4);
                            string enfermedad = reader.IsDBNull(5) ? null : reader.GetString(5);

                            Paciente pacienteAux = new Paciente(nombre, apellido, dni, char.Parse(genero), enfermedad);
                            pacienteAux.Turno = this.TurnoPaciente(idPaciente, connection); // Asignar el turno al paciente
                            listaPacientesAux.Add(pacienteAux);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al completar lista de pacientes: {ex.Message}");
            }

            return listaPacientesAux;
        }

        private Turno TurnoPaciente(int idPaciente, SqlConnection connection)
        {
            Turno turno = null;

            string command = @"
                            SELECT t.TurnoID, t.Fecha, t.Hora
                            FROM Turnos t
                            WHERE t.PacienteID = @idPaciente";

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand(command, connection))
                {
                    sqlCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime dia = reader.GetDateTime(1);
                            TimeSpan hora = reader.GetTimeSpan(2);

                            turno = new Turno(dia, $"{hora}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en TurnoPaciente: {ex.Message}");
            }

            return turno;
        }

        public bool GuardarPaciente(Usuario usuario)
        {
            string command = @"
                            INSERT INTO 
                            Usuarios(Nombre, Apellido, DNI, Genero, TipoUsuario, NombreUsuario, ContraseñaUsuario, Email) 
                            VALUES
                            (@Nombre, @Apellido, @DNI, @Genero, @TipoUsuario, @NombreUsuario, @ContraseñaUsuario, @Email)";

            try
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Nombre", usuario.Paciente.Nombre);
                    sqlCommand.Parameters.AddWithValue("@Apellido", usuario.Paciente.Apellido);
                    sqlCommand.Parameters.AddWithValue("@DNI", usuario.Paciente.DNI);
                    sqlCommand.Parameters.AddWithValue("@Genero", usuario.Paciente.Genero);
                    sqlCommand.Parameters.AddWithValue("@TipoUsuario", "Paciente");
                    sqlCommand.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    sqlCommand.Parameters.AddWithValue("@ContraseñaUsuario", usuario.ContraseñaUsuario);
                    sqlCommand.Parameters.AddWithValue("@Email", usuario.Mail);
                    sqlCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error guardando el usuario: {ex.Message}");
                return false;
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public bool CambiarContraseña(Usuario usuario, string nuevaContraseña)
        {
            string command = @"
                    UPDATE Usuarios 
                    SET ContraseñaUsuario = @nuevaContraseña 
                    WHERE DNI = @dni";

            try
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@nuevaContraseña", nuevaContraseña);
                    sqlCommand.Parameters.AddWithValue("@dni", usuario.Paciente.DNI);
                    sqlCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cambiar la contraseña: {ex.Message}");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return false;
        }

        public bool AsignarTurno(int idDoctor, int idPaciente, DateTime fechaTurno, string horaTurno)
        {
            string command = @"
                    INSERT INTO Turnos (DoctorID, PacienteID, Fecha, Hora) 
                    VALUES (@idDoctor, @idPaciente, @fechaTurno, @horaTurno)";

            try
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@idDoctor", idDoctor);
                    sqlCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
                    sqlCommand.Parameters.AddWithValue("@fechaTurno", fechaTurno.Date);
                    sqlCommand.Parameters.AddWithValue("@horaTurno", TimeSpan.Parse(horaTurno));
                    sqlCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al asignar el turno: {ex.Message}");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return false;
        }

        public int ObtenerIdUsuarioPorDNI(int dni)
        {
            string command = "SELECT ID FROM Usuarios WHERE DNI = @dni";
            int userId = 0;

            try
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@dni", dni);
                    using (SqlDataReader reader = sqlCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userId = reader.GetInt32(0);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener el ID del usuario: {ex.Message}");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return userId;
        }

        public bool CancelarTurno(int idPaciente)
        {
            string command = "DELETE FROM Turnos WHERE PacienteID = @idPaciente";

            try
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@idPaciente", idPaciente);
                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    return rowsAffected > 0; // Si se afectaron filas, se eliminó el turno correctamente
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al cancelar el turno: {ex.Message}");
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }

            return false;
        }



        public bool EliminarUsuarios(List<Usuario> usuarios)
        {
            try
            {
                sqlConnection.Open();
                SqlTransaction transaction = sqlConnection.BeginTransaction(); // Inicia la transacción

                try
                {
                    foreach (var usuario in usuarios)
                    {
                        int usuarioId;

                        // Cierra la conexión antes de llamar a ObtenerIdUsuarioPorDNI
                        if (sqlConnection.State == System.Data.ConnectionState.Open)
                        {
                            sqlConnection.Close();
                        }

                        // Obtener el ID del usuario
                        if (usuario.Doctor is not null)
                        {
                            usuarioId = ObtenerIdUsuarioPorDNI(usuario.Doctor.DNI);
                        }
                        else
                        {
                            usuarioId = ObtenerIdUsuarioPorDNI(usuario.Paciente.DNI);
                        }
                        

                        // Reabre la conexión y comienza la transacción nuevamente
                        sqlConnection.Open();
                        transaction = sqlConnection.BeginTransaction();

                        // Eliminar turnos asociados
                        string queryTurnos = "DELETE FROM Turnos WHERE DoctorID = @ID OR PacienteID = @ID";
                        using (SqlCommand commandTurnos = new SqlCommand(queryTurnos, sqlConnection, transaction))
                        {
                            commandTurnos.Parameters.AddWithValue("@ID", usuarioId);
                            commandTurnos.ExecuteNonQuery();
                        }

                        // Eliminar usuario
                        string queryUsuario = "DELETE FROM Usuarios WHERE ID = @ID";
                        using (SqlCommand commandUsuario = new SqlCommand(queryUsuario, sqlConnection, transaction))
                        {
                            commandUsuario.Parameters.AddWithValue("@ID", usuarioId);
                            commandUsuario.ExecuteNonQuery();
                        }

                        transaction.Commit(); // Confirma la transacción
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Revierte la transacción en caso de error
                    Console.WriteLine("Error al eliminar usuarios: " + ex.Message);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
                return false;
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public bool CrearDoctor(Usuario usuario)
        {
            string command = @"
                            INSERT INTO 
                            Usuarios(Nombre, Apellido, DNI, Genero, TipoUsuario, NombreUsuario, ContraseñaUsuario, Email, RangoHorario, Especialidad) 
                            VALUES
                            (@Nombre, @Apellido, @DNI, @Genero, @TipoUsuario, @NombreUsuario, @ContraseñaUsuario, @Email, @RangoHorario, @Especialidad)";

            try
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(command, sqlConnection))
                {
                    sqlCommand.Parameters.AddWithValue("@Nombre", usuario.Doctor.Nombre);
                    sqlCommand.Parameters.AddWithValue("@Apellido", usuario.Doctor.Apellido);
                    sqlCommand.Parameters.AddWithValue("@DNI", usuario.Doctor.DNI);
                    sqlCommand.Parameters.AddWithValue("@Genero", usuario.Doctor.Genero);
                    sqlCommand.Parameters.AddWithValue("@TipoUsuario", "Doctor");
                    sqlCommand.Parameters.AddWithValue("@NombreUsuario", usuario.NombreUsuario);
                    sqlCommand.Parameters.AddWithValue("@ContraseñaUsuario", usuario.ContraseñaUsuario);
                    sqlCommand.Parameters.AddWithValue("@Email", usuario.Mail);
                    sqlCommand.Parameters.AddWithValue("@RangoHorario", usuario.Doctor.HorariosAtencion);
                    sqlCommand.Parameters.AddWithValue("@Especialidad", usuario.Doctor.Especialidad);
                    sqlCommand.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error guardando el usuario: {ex.Message}");
                return false;
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }




    }
}
