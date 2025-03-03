using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskİnheriWeryImportant
{
    public class Base
    {
        public static int counter = 1;
        private int _id;
        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                
            }
        }

        public DateTime CreatedDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime? EditDate { get; set; }
        public int? EditUser{ get; set; }
        public bool isDeleted { get; set;}
        public DateTime? DeletedDate { get; set; }
        public int? DeleteUser { get; set; }

        public Base()
        {
            _id = counter;
            counter++;
        }
    }
}
