using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop01.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }

        public User()
        {
        }
        public User(int id,string name,string password)
        {
            Id = id;
            Name = name ;
            Password = password;
        }
    }
}
