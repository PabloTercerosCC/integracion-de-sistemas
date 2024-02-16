using System;
using System.Collections.Generic;
namespace DependencyInjection
{
    class Injector
    {
        static void Main(string[] args)
        {
            Client client = new Client(new Service());
            List<Model> listEmployee = client.GetAll();
            foreach (Model emp in listEmployee)
            {
                Console.WriteLine($"ID = {emp.Id}, Name = {emp.Name}, LastName = {emp.LastName}");
            }
            Console.ReadKey();
        }
    }
}