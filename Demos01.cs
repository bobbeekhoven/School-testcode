using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    public class Customer
    {
        public Customer(int ID, string Name, CustomerStatusEnum Status, string Email)
        {

            this.ID = ID;
            this.Name = Name;
            this.Status = Status;
            this.Email = Email;
        }

        public Customer(int ID, string Name)
        {

            this.ID = ID;
            this.Name = Name;
            this.Status = CustomerStatusEnum.Gold;
            this.Email = Name + "@cust.com";
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public Customer Status { get; set; }
        public string Email { get; set; }

        public string Details()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}", ID, Name, Status, Email);
        }
    }
}
