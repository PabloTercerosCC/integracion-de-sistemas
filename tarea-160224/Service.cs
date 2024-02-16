using System.Collections.Generic;
namespace DependencyInjection
{
    public interface IService
    {
        List<Model> SelectAll();
    }
    
    public class Service : IService
    {
        public List<Model> SelectAll()
        {
            List<Model> ListModels = new List<Model>
            {
                new Model() { Id = 1, Name = "Pablo", LastName = "Terceros" },
                new Model() { Id = 2, Name = "Jorge", LastName = "Camacho" },
                new Model() { Id = 3, Name = "Marc", LastName = "Antony" }
            };
            return ListModels;
        }
    }
}