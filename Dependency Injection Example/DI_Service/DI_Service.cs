namespace Dependency_Injection_Example.DI_Service
{
    public class DI_Service:ITransientService,IScopedService,ISingletonService
    {
        Guid Id;

        public DI_Service()
        {
            Id = Guid.NewGuid();
        }

        public Guid GetId()
        {
            return Id;
        }
    }
}
