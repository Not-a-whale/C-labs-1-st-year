using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3.Entities
{
    class Flight
    {
        public string Name
        {
            get; set;
        }

        public int Id { get; set; }

        public DateTime Departure { get; set; }

        public DateTime Arival { get; set; }

    }
}
