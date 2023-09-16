
using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true,message)
        {
            Console.WriteLine();
        }
        public SuccessResult():base(true)
        {
            
        }
    }
}
