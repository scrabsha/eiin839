using System.ServiceModel;
using System.ServiceModel.Web;

namespace MathsLibraryRest
{
    [ServiceContract]
    public interface IMathOperations
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Add?a={a}&b={b}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        int Add(int a, int b);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Sub?a={a}&b={b}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        int Sub(int a, int b);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Mul?a={a}&b={b}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        int Mul(int a, int b);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "Div?a={a}&b={b}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        float Div(int a, int b);
    }
}
