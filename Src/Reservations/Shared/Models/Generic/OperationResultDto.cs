using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations.Shared.Generic
{
    public class OperationResultDto<T>
    {
        public bool Success { get; set; }
        public MessageStruct[] Messages { get; set; }
        public T Payload { get; set; }
        public string Token { get; set; }
    }
}
