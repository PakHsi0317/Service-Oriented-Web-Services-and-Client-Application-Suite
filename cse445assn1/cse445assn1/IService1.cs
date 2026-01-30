using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Services.Description;

namespace cse445assn1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //not for this project, just exercise
        [OperationContract]
        double PiValue();

        // TODO: Add your service operations here
        // convert Celsius temperature to Fahrenheit temperature interface
        [OperationContract]
        int c2f(int c);

        // convert Fahrenheit temperature to Celsius temperature interface
        [OperationContract]
        int f2c(int f);

        // sort a string of numbers, separated by commas interface
        [OperationContract]
        string sort(string s);

    }

  
}
