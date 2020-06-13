namespace WCFIISExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ExampleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ExampleService.svc or ExampleService.svc.cs at the Solution Explorer and start debugging.
    public class ExampleService : IExampleService
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
