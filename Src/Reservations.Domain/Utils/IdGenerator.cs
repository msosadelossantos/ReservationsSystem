using System;


namespace Reservations.Data.Utils
{
    public static class IdGenerator
    {

        public static string Generate()
        {
            return Guid.NewGuid().ToString().Trim() + DateTime.Now.ToString().Trim()
                .Replace(":","").Replace(" ","").Replace("/", "");
        }
        

    }
}
