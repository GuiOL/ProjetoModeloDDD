using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Register { get; set; }
        public bool Active { get; set; }
        public virtual IEnumerable<Product> Products  { get; set; }

        public bool SpecialClient(Client client)
        {
            return client.Active 
                && DateTime.Now.Year - client.Register.Year >= 5;
        }
    }
}
