using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ClassRelationships.Example2
{
    public class Bank
    {
        public string Address { get; set; }

        public string Name { get; set; }

        public string SwiftCode { get; set; }

        public string Country { get; set; }

        public List<Account> Accounts { get; set; }

        //8407D38B-8A7B-46A3-92DE-ABDA058E7B81
        public void OpenAccount(Account newAccount, Person p, Guid generatedId)
        {
            newAccount.IBAN = generatedId.ToString();
            newAccount.IdCard = p.Id;
            Accounts.Add(newAccount);
        
        }
    }
}
