using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualDataBase db = new VirtualDataBase();
            var serchResultAge=db.GetPersonByAgeWithoutLinq(90,100);
            var serchResultName=db.GetPersonByFirstLetterWithoutLinq('V');


            var serchResultAgeWithLinq = db.GetPersonByAgeWithLinq(90, 100);
            var serchResultNameWithLinq = db.GetPersonByFirstLetterWithLinq('V');

            var searchGenderMale = db.Persons.Where(x => x.Gender == GenderEnum.Male);

            IEnumerable<Person> badQuery = db.Persons.Where(x => x.Name.StartsWith("V"));
            badQuery = badQuery.Take<Person>(1);

            IQueryable<Person> goodQuery = db.Persons.AsQueryable().Where(x => x.Name.EndsWith("N"));
            goodQuery = goodQuery.Take<Person>(1);
        }
    }
}
