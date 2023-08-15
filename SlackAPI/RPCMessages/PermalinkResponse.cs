namespace SlackAPI.RPCMessages
{
    [RequestPath("chat.getPermalink")]
    public class PermalinkResponse: Response
    {
        public string channel;
        public string permalink;
    }
}