using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week4_ClassRelationships.Example2;

namespace Week4_ClassRelationships
{
    //composition states that the account can exist only if a person exists and owns the account

    //aggregation states that bank can exist without the need of adding accounts, but once account is added,
                    //it is saved inside a collection in the bank instance

    //association states that the bank makes use of an instance of person, without saving it in any of the
                    //properties inside the bank
    internal class Program
    {
        static void Main(string[] args)
        {
            Example2.Person p = new Example2.Person();
            Account account = new Account(p);


            Bank b = new Bank();
            b.OpenAccount(account, p, Guid.NewGuid());
        }
    }
}
