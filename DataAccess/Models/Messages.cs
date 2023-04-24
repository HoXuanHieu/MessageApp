using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Messages
    {
        public int message_id;
        //foreign key
        public Friends? friend;
        
        public int friend_id;
        public int user_id;


        public string? message;
        public DateTime date_send;
        public DateTime last_modified;
        public bool is_delete;
    }
}
