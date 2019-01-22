using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Microsoft.Extensions.Logging;
using Thundra.Agent.Lambda.Config;
using Thundra.Agent.Lambda.Core;
using Thundra.Agent.Log.AspNetCore;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace ThundraLoggingTemplate
{
    public class Function : LambdaRequestHandler<string, string>
    {
        /// <summary>
        /// Handler class needs to extend `LambdaRequestHandler< Request, Response >`
        /// Please write all code within the DoHandleRequest method
        /// </summary>
        /// <param name="request"></param>
        /// <param name="context"></param>
        /// <returns>/Greeting Message/</returns>
        public override Album DoHandleRequest(string request, ILambdaContext context)
        {
            var loggerFactory = new LoggerFactory().AddThundraProvider();
            var logger = loggerFactory.CreateLogger<Function>();

            Console.WriteLine("Successfully sent console log.");

            return "Hello Thundra";
        }
    }
}
