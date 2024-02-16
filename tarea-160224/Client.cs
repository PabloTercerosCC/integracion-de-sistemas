using System.Collections.Generic;
namespace DependencyInjection
{
    public class Client
    {
        public IService Service;
        
        public Client(IService service)
        {
            Service = service;
        }

        public List<Model> GetAll()
        {
            return Service.SelectAll();
        }
    }
}