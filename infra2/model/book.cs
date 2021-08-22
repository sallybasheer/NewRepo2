using System;
using System.Collections.Generic;
using System.Text;

namespace infra2.model
{
    public class book
    {
       public book(){}
        public int id { get; set; }
        public string titel { get; set; }
       public bool IsExisting { get; set; }
        

        public book(int id, string titel,bool IsExisting)
        {
            this.id = id;
            this.titel = titel;
            this.IsExisting = IsExisting;
            
        }
       
    }
}
