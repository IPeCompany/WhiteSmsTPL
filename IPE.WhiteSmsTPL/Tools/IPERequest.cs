using RestSharp;

namespace IPE.WhiteSmsTPL
{
    public class IPERequest : RestRequest
    {
        public IPERequest(Method method)
        {
            AddHeader("Content-Type", "application/json");
            Method = method;
        }

        public IPERequest(Method method, string token)
            : this(method)
        {
            AddHeader("x-sms-ir-secure-token", token);
        }

        public IPERequest(Method method, string token, string requestBody)
            : this(method,token)
        {
            var param = new Parameter { ContentType = "Body", Type = ParameterType.RequestBody, Value = requestBody, Name = "undefined" };
            AddParameter(param);
        }

        public IPERequest(Method method, Parameter param)
            : this(method)
        {
            AddParameter(param);
        }
    }
}
