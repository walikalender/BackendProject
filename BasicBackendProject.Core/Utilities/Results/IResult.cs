using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.Core.Utilities.Results
{
    // temel voidler için başlangıç
    // voidleri bu IResult yapısı ile süsleyeceğiz
    public interface IResult
    {
        bool IsSuccess { get; }
        string Message { get; }
    }
} 
