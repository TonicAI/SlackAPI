using System;
using System.Collections.Generic;
using System.Net;

namespace SlackAPI
{
    public abstract class Response
    {
        /// <summary>
        /// Should always be checked before trying to process a response.
        /// </summary>
        public bool ok;

        /// <summary>
        /// if ok is false, then this is the reason-code
        /// </summary>
        public string error;
        public string needed;
        public string provided;
        public string warning;
        public int statusCode;
        public Dictionary<string, string[]> responseHeaders;

        public void AssertOk()
        {
            if (!(ok))
                throw new InvalidOperationException($"An error occurred: {error}");
        }

        public ResponseMetaData response_metadata;
    }

    public class ResponseMetaData
    {
        public string next_cursor;
        public string[] messages;
    }
}
