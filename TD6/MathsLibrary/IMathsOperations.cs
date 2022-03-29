using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathsLibrary
{
    [ServiceContract]
    public interface IMathsOperations
    {
        [OperationContract]
        int Add(int a, int b);

        [OperationContract]
        int Sub(int a, int b);

        [OperationContract]
        int Mul(int a, int b);

        [OperationContract]
        float Div(int a, int b);
    }
}
