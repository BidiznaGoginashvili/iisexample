using System.ServiceModel;

namespace WCFIISExample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IExampleService" in both code and config file together.
    [ServiceContract]
    public interface IExampleService
    {
        [OperationContract]
        int Sum(int a,int b);
    }
}
