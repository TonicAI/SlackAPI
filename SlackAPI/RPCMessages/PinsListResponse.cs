namespace SlackAPI.RPCMessages
{
    [RequestPath("pins.list")]
    public class PinsListResponse: Response
    {
        public Message message;
        public File file;
        public string file_comment;
    }
}