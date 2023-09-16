using System;
using System.Collections.Generic;
using System.Text;

namespace BasicBackendProject.Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool isSucces,string message):this(isSucces)
        {
            Message = message;
        }

        public Result(bool isSucces)
        {
            IsSuccess=isSucces;
        }

        public bool IsSuccess { get; }

        #region Not
        // getter readonlydir. Ve constructorda Set edilebilir.
        // biz constructor dışında set etmeyeceğiz. O yüzden bu yapıyı kurduk getter dedik. setter koymadık.
        // ki adam tamamen construcor yapısıyla kullansın. 
        // biz setter de koyabilirdik. Ama programcı burda kafasına göre kodlayabilirdi. biz onu sınırladık.
        #endregion

        public string Message { get; }
    }
}
