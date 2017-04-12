namespace EightBall
{
    public class SlackReponse
    {
        public string response_type
        {
            get
            {
                return "in_channel";
            }
        }

        public string text
        {
            get; set;
        }
    }
}
