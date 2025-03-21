using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class VirtualDataBase
    {
        public List<Person> Persons = new List<Person>();
        public VirtualDataBase()
        {
            Random rand = new Random();
            for (int i = 1; i <= 10000; i++)
            {
                Person person = new Person()
                {
                    Id = i,
                    Name = FakeData.NameData.GetFirstName(),
                    Surname = FakeData.NameData.GetSurname(),
                    Age = rand.Next(1, 100),
                    DOB = FakeData.DateTimeData.GetDatetime(new DateTime(1950,01,01),new DateTime(2004,01,01)),
                    Gender=(rand.Next(1,100)%2==0)? GenderEnum.Male : GenderEnum.Femail,
                    Country=FakeData.PlaceData.GetCountry(),
                    City=FakeData.PlaceData.GetCity(),
                    Adress=FakeData.PlaceData.GetAddress(),
                    Email=FakeData.NetworkData.GetEmail(),
                    Phone=FakeData.PhoneNumberData.GetPhoneNumber(),
                    PostCode=FakeData.PlaceData.GetPostCode()
                };
                Persons.Add(person);
            }
        }

        public List<Person> GetPersonByFirstLetterWithoutLinq(char letter)
        {
            var uoutput = new List<Person>();
            for (int i = 0; i < Persons.Count; i++)
            {
                if (char.ToLower(Persons[i].Name[0])==char.ToLower(letter))
                {
                     uoutput.Add(Persons[i]);
                }
            }

            return uoutput;
        }

        public List<Person> GetPersonByAgeWithoutLinq(int minAge, int maxAge)
        {
            var uoutput = new List<Person>();
            for (int i = 0; i < Persons.Count; i++)
            {
                if (Persons[i].Age>=minAge && Persons[i].Age<=maxAge)
                {
                    uoutput.Add(Persons[i]);
                }
            }

            return uoutput;
        }

        #region WithLinQ
        public List<Person> GetPersonByFirstLetterWithLinq(char letter)
        {
            var output = Persons.Where(x => x.Name.StartsWith(letter.ToString())).ToList();
            return output;
        }

        public List<Person> GetPersonByAgeWithLinq(int minAge, int maxAge)
        {
            var output = Persons.Where(x => x.Age >= minAge && x.Age <= maxAge).ToList();
            return output;
        }
        #endregion
    }
}
