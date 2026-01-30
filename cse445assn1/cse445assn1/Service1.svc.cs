using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace cse445assn1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        //not for this project, just exercise
        public double PiValue()
        {
            double pi = Math.PI;
            return pi;
        }

        //Converting Celsius to Fahrenheit
        public int c2f(int c)
        {
            //formula
            return c * 9 / 5 + 32;
        }

        //Converting Fahrenheit to Celsius
        public int f2c(int f)
        {
            //formula
            return (f - 32) * 5 / 9;
        }

        //Read the numbers in the text, then sort the output.
        public string sort(string s) {
            string text = "";
            int[]arr = new int[s.Length];
            //store them into an array
            for (int i = 0; i < s.Length; i++) {
                arr[i] = s[i] - '0';
            }

            //use selection sorting algorithm to sort 
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int iMin = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[iMin])
                    {
                        iMin = j;
                    }
                }

                if (iMin != i)
                {
                    // Swap arr[i] and arr[iMin]
                    int temp = arr[i];
                    arr[i] = arr[iMin];
                    arr[iMin] = temp;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                text += arr[i];
                if (i < arr.Length - 1) {
                       text += ",";
                }
                  
            }

            return text;
        }

    }

  
}
