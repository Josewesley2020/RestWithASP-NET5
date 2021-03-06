using System.Collections.Generic;
using RestWithASPNET.Model;

namespace RestWithASPNET.Services
{
    public interface IPersonServices
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
