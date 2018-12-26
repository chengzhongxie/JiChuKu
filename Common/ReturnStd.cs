using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class ReturnStd
    {
        public class ReturnJson
        {
            public string Status { get; set; }
            public string Message { get; set; }
            public object Data { get; set; }
        }
        public static ReturnJson ComJson(string responseMessage, string responseCode, object rtnData = null)
        {
            ReturnJson returnJson = new ReturnJson()
            {
                Status = responseCode,
                Message = responseMessage,
                Data = rtnData ?? string.Empty
            };
            return returnJson;
        }

        public static ReturnJson Success(object rtnData = null)
        {
            ReturnJson returnJson = new ReturnJson()
            {
                Status = "200",
                Message = string.Empty,
                Data = rtnData ?? string.Empty
            };
            return returnJson;
        }
        public static ReturnJson Success(string message)
        {
            ReturnJson returnJson = new ReturnJson()
            {
                Status = "200",
                Message = message,
                Data = string.Empty
            };
            return returnJson;
        }
        public static ReturnJson Error(string responseMessage, string responseCode = "400", object rtnData = null)
        {
            ReturnJson returnJson = new ReturnJson()
            {
                Status = responseCode,
                Message = responseMessage ?? string.Empty,
                Data = rtnData ?? string.Empty
            };
            return returnJson;
        }

        public static ReturnJson NotAuthorize(string responseMessage, string responseCode = "90", object rtnData = null)
        {
            ReturnJson returnJson = new ReturnJson()
            {
                Status = responseCode,
                Message = responseMessage ?? string.Empty,
                Data = rtnData ?? string.Empty
            };
            return returnJson;
        }
    }
}
