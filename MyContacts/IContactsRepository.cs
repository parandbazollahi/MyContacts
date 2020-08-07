using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MyContacts
{
    interface IContactsRepository
    {
        DataTable SelectAll();
        DataTable SelectRow(int contactID);
        bool Insert (String name, String lastName, String mobile, String address, String email);

        bool Update(int contactID, String name, String lastName, String mobile, String address, String email);

        bool Delete(int contactID);
    }
}
