using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyContacts
{
    class ContactRepositery : IContactsRepository
    {
        private string conncectionString = "Data Source=.;Initial Catalog = contact_DB;Integrated Security =true";
        public bool Delete(int contactID)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string name, string lastName, string mobile, string address, string email)
        {
            SqlConnection connection = new SqlConnection(conncectionString);
            try
            {

                string query = "Insert Into dbo_MyContact (Name, LastName,Mobile,Email, Address)values(@Name,@lastName,@Mobile,@Address,@Email)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Mobile", mobile);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                command.ExecuteNonQuery();

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable SelectAll()
        {
            string query = "Select * From dbo_MyContact";
            SqlConnection connection = new SqlConnection(conncectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(int contactID)
        {
            throw new NotImplementedException();
        }

        public bool Update(int contactID, string name, string lastName, string mobile, string address, string email)
        {
            throw new NotImplementedException();
        }
    }
}
