using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Reservations.Shared.Generic
{
    public class ApiResult<T>
    {
        public bool Success { get; set; }
        public MessageStruct[] Messages { get; set; }
        public T Payload { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
        }
    }

}
