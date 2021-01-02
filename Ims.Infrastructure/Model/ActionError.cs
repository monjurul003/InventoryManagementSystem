using System;
using Ims.Infrastructure.Enum;

namespace Ims.Infrastructure.Model
{
    public class ActionError
    {
        public ActionErrorCode Code { get; set; }
        public string Message { get; set; }
        public dynamic Payload { get; set; }

        public void ReThrowIfFailedWithException()
        {
            if (Code == ActionErrorCode.Exception)
            {
                throw new Exception(Message);
            }
        }
    }
}