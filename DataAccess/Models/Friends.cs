using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Friends
    {
        //primary key
        public int friend_id;

        //foreign key
        public Users? user;
        public int user_id;
        //foreign key
        public Users? friend_user;
        public int friend_user_id;

        
        public bool is_delete;
        public DateTime last_modified;

        public List<Messages> messages { get; set; }
        

    }
}
