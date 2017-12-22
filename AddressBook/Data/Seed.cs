using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Data
{
    public class Seed
    {
        public static void DBSeed (ApplicationDbContext context)
        {
            var Apa = new Person { FirstName = "Apan", LastName = "Apansson" };
            context.Add(Apa);
            var Peter = new Person { FirstName = "Peter", LastName = "Apansson" };
            context.Add(Peter);
            var Luktis = new Person { FirstName = "Luktis", LastName = "Apansson" };
            context.Add(Luktis);

            var Adress1 = new AddressModel { Name = "Gatan 1" };
            context.Add(Adress1);
            var Adress2 = new AddressModel { Name = "Gatan 2" };
            context.Add(Adress2);
            var Adress3 = new AddressModel { Name = "Gatan 3" };
            context.Add(Adress3);
        }
    }
}
