using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Seminar7
{
    public class CarteRepository
    {
        private string _connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Carti.mdf;Integrated Security=True";
        public List<Carte> GetAll()
        {
            var results = new List<Carte>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT Id, Titlu, Autor, AnAparitie, Gen FROM Carti", connection))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var carte = new Carte();
                        carte.Id = reader.GetGuid(reader.GetOrdinal("Id"));
                        carte.Titlu = reader.GetString(reader.GetOrdinal("Titlu"));
                        carte.Autor = reader.GetString(reader.GetOrdinal("Autor"));
                        carte.AnAparitie = reader.GetInt32(reader.GetOrdinal("AnAparitie"));
                        carte.Gen = (GenCarte)Enum.Parse(typeof(GenCarte), reader.GetString(reader.GetOrdinal("Gen")));

                        results.Add(carte);
                    }
                }
                connection.Close();
            }

            return results;
        }

        public Carte GetById(Guid id)
        {
            var carte = new Carte();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT Id, Titlu, Autor, AnAparitie, Gen FROM Carti WHERE Id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", id.ToString());

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        carte.Id = reader.GetGuid(reader.GetOrdinal("Id"));
                        carte.Titlu = reader.GetString(reader.GetOrdinal("Titlu"));
                        carte.Autor = reader.GetString(reader.GetOrdinal("Autor"));
                        carte.AnAparitie = reader.GetInt32(reader.GetOrdinal("AnAparitie"));
                        carte.Gen = (GenCarte)Enum.Parse(typeof(GenCarte), reader.GetString(reader.GetOrdinal("Gen")));
                    }
                }
                connection.Close();
            }

            return carte;
        }

        public void Add(Carte carte)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO Carti (Id, Titlu, Autor, AnAparitie, Gen) VALUES (@id, @titlu, @autor, @anAparitie, @gen)", connection))
                {
                    command.Parameters.AddWithValue("id", carte.Id.ToString());
                    command.Parameters.AddWithValue("titlu", carte.Titlu);
                    command.Parameters.AddWithValue("autor", carte.Autor);
                    command.Parameters.AddWithValue("anAparitie", carte.AnAparitie);
                    command.Parameters.AddWithValue("gen", carte.Gen.ToString());

                    command.ExecuteNonQuery();                    
                }
                connection.Close();
            }
        }

        public void Update(Carte carte)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("UPDATE Carti SET Titlu = @titlu, Autor = @autor, AnAparitie = @anAparitie, Gen = @gen WHERE Id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", carte.Id.ToString());
                    command.Parameters.AddWithValue("titlu", carte.Titlu);
                    command.Parameters.AddWithValue("autor", carte.Autor);
                    command.Parameters.AddWithValue("anAparitie", carte.AnAparitie);
                    command.Parameters.AddWithValue("gen", carte.Gen.ToString());

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public void Delete(Guid id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("DELETE FROM Carti WHERE Id = @id", connection))
                {
                    command.Parameters.AddWithValue("id", id.ToString());

                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}
