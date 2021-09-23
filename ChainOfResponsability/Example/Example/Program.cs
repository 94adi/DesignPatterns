using System;
using static System.Console;

namespace Example
{
    //pseudo http request/response pipeline
    public class UserRequest
    {
        public string Cookie { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string ContentType { get; set; }
        public string URL { get; set; }
        public bool IsStaticRequest { get; set; }
    }

    public class UserResponse
    {
        public string Content { get; set; }
        public bool IsReponseCached { get; set; }
        public string CacheControl { get; set; }
        public string Message { get; set; }
        public int ReponseCode { get; set; }

        public override string ToString()
        {
            return $"Content: {Content} \n IsResponseCached: {IsReponseCached} \n CacheControl: {CacheControl} \n Message: {Message} \n ResponseCode: {ReponseCode}";
        }
    }

    public class RequestPipeline
    {
        protected UserRequest userRequest;
        protected UserResponse userResponse;
        protected RequestPipeline next;

        public RequestPipeline(UserRequest userRequest, UserResponse userResponse)
        {
            this.userRequest = userRequest ?? throw new ArgumentNullException(paramName: nameof(userRequest));
            this.userResponse = userResponse ?? throw new ArgumentNullException(paramName: nameof(userResponse));
        }

        public void Add(RequestPipeline rp)
        {
            if (next != null)
            {
                next.Add(rp);
            }
            else
            {
                next = rp;
            }
        }

        public virtual void Handle() => next?.Handle();

        public UserResponse GetUserResponse() => userResponse;
    }

    public class StaticRquestHandler : RequestPipeline
    {
        public StaticRquestHandler(UserRequest userRequest, UserResponse userResponse) : base(userRequest, userResponse)
        {
        }

        public override void Handle()
        {
            WriteLine("Handling static reuqest handler...");
            if (this.userRequest.IsStaticRequest)
            {
                if (this.userRequest.ContentType.Equals("image/svg+xml"))
                {
                    userResponse.Content = "svg image content";
                    userResponse.IsReponseCached = true;
                    userResponse.CacheControl = "max-age=31536000, public";
                    userResponse.ReponseCode = 200;

                    //short circuit pipeline
                    return;
                }
                if (this.userRequest.ContentType.Equals("text/javascript"))
                {
                    userResponse.Content = "js file content";
                    userResponse.IsReponseCached = false;
                    userResponse.CacheControl = "max-age=0, public";
                    userResponse.ReponseCode = 200;

                    //short circuit pipeline
                    return;
                }
            }
            base.Handle();
        }
    }

    public class AuthenticateRquestHandler : RequestPipeline
    {
        public AuthenticateRquestHandler(UserRequest userRequest, UserResponse userResponse) : base(userRequest, userResponse)
        {
        }

        public override void Handle()
        {
            WriteLine("Handling authentication process...");
            if (this.userRequest.Cookie.Contains("SESS"))
            {
                string sessionId = this.userRequest.Cookie.Split(":")[1];
                if (!this.IsSessionActive(sessionId))
                {
                    this.userResponse.ReponseCode = 401;
                    this.userResponse.Message = "You need to authenticate to access this content";

                    //short circuit pipeline
                    return;
                }

            }
            base.Handle();
        }

        private bool IsSessionActive(string sessionId)
        {
            if (sessionId.Equals("12345"))
            {
                return true;
            }
            return false;
        }
    }

    public class AuthorizeRquestHandler : RequestPipeline
    {
        public AuthorizeRquestHandler(UserRequest userRequest, UserResponse userResponse) : base(userRequest, userResponse)
        {
        }

        public override void Handle()
        {
            WriteLine("Handling authorization...");
            if (this.userRequest.URL.Contains("/admin") && (!this.userRequest.Role.Equals("Admin")))
            {
                userResponse.ReponseCode = 401;
                userResponse.Message = "You do not have proper authorization to access this content";
                return;
            }
            else
            {
                userResponse.Content = "web content";
                userResponse.IsReponseCached = false;
                userResponse.CacheControl = "max-age=0, public";
                userResponse.ReponseCode = 200;
            }

            base.Handle();
        }

    }

    public class Demo
    {
        static void Main(string[] args)
        {
            UserRequest request1 = new UserRequest
            {
                Cookie = "",
                UserName = "annonymous",
                Role = null,
                ContentType = "image/svg+xml",
                URL = "/static/files/johnsmith.svg",
                IsStaticRequest = true
            };

            UserRequest request2 = new UserRequest
            {
                Cookie = "SESS:12345",
                UserName = "johnsmith",
                Role = "user",
                ContentType = "text/html",
                URL = "/products/index.html",
                IsStaticRequest = false
            };

            UserRequest request3 = new UserRequest
            {
                Cookie = "SESS:12345",
                UserName = "johnsmith",
                Role = "user",
                ContentType = "text/html",
                URL = "/admin/products/upsert/3",
                IsStaticRequest = false
            };

            UserResponse response = new UserResponse();

            WriteLine("****** Pipeline for request 1 ******");

            var pipeline = BuildPipeLine(request1, response);

            pipeline.Handle();

            WriteLine(response);

            WriteLine("****** END OF Pipeline for request 1 ******");

            WriteLine("****** Pipeline for request 2 ******");

            pipeline = BuildPipeLine(request2, response);

            pipeline.Handle();

            WriteLine(response);

            WriteLine("****** END OF Pipeline for request 2 ******");

            WriteLine("****** Pipeline for request 3 ******");

            pipeline = BuildPipeLine(request3, response);

            pipeline.Handle();

            WriteLine(response);

            WriteLine("****** Pipeline for request 3 ******");
        }

        static RequestPipeline BuildPipeLine(UserRequest userRequest, UserResponse userResponse)
        {
            RequestPipeline pipeline = new RequestPipeline(userRequest, userResponse);
            pipeline.Add(new StaticRquestHandler(userRequest, userResponse));
            pipeline.Add(new AuthenticateRquestHandler(userRequest, userResponse));
            pipeline.Add(new AuthorizeRquestHandler(userRequest, userResponse));

            return pipeline;
        }
    }
}
