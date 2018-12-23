using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using dasData;

namespace DasDataCtrl_CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            das _myDas = new das();
            //CHANGE FROM YOUR ACCOUNT
            string _Akey = "a09075165g-2f343fe-485a-8276-02574c41c94";
            string _dKey = "bf082e44-7945-48b5-8016-8b94365ce8d2";

            //SEND DATA DELIMITED BY |  DEPENDING ON THE CONFIGURED ELEMENTS 
            Console.Write(_myDas.sendDas("34|453|4322", _dKey, _Akey));
            //RECEIVE DATA - JSON / XML
            // latest 100 values :: "json", 0, 100    
            // based on interval dfrom / dto :: "json", 23.12.2013, 14.01.2014   
            Console.Write(_myDas.getDas(_dKey, "json", "0", "100"));
            //   Console.Write(_myDas.getDas(_dKey, "jsond", "23.12.2013", "14.01.2014"));
            //  Console.Write(_myDas.getDas(_dKey, "xml", 0, 100));
            // Console.Write(_myDas.getDas(_dKey, "xmld", "23.12.2013", "14.01.2014"));
            Console.ReadLine();
        }
    }
}
