using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Shared.Generic
{
    public struct MessageStruct
    {
        public string MessageCode { get; set; }
        public string Message { get; set; }

        public MessageStruct(string _messageCode, string _message)
        {
            MessageCode = _messageCode;
            Message = _message;
        }
    }
}
