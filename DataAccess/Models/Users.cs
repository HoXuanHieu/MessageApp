using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Users
    {
        public int user_id;
        public string? user_name;
        public string? first_name;
        public string? last_name;
        public string? password;
        public string? email;
        public bool is_delete;
        public DateTime last_modified;

        public List<Friends> friends { get; set; }
        public List<Friends> friends_user { get; set; }


    }
}
