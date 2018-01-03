using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EightBall
{
    public class EightBall
    {
        private List<string> _wisdom;

        public string GetRandom()
        {
            var rand = new Random();

            return GetWisdom(rand.Next(_wisdom.Count));
        }

        public EightBall()
        {
            _wisdom = new List<string>
            {

                //source: https://en.wikipedia.org/wiki/Magic_8-Ball

                "It is certain.",
                "It is decidedly so.",
                "Without a doubt.",
                "Yes definitely.",
                "You may rely on it.",
                "As I see it, yes.",
                "Most likely.",
                "Outlook good.",
                "Yes.",
                "Signs point to yes.",
                "Reply hazy try again.",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don't count on it.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Very doubtful.",
                "Laurier is wrong.",
                "NO YOU'RE FAKE NEWS.",
                "Maybe try Twitter instead."
            };
        }

        private string GetWisdom(int index)
        {
            return _wisdom[index];
        }

        public string GetJson()
        {
            var response = new SlackReponse();
            response.text = GetRandom();

            return JsonConvert.SerializeObject(response, Formatting.Indented);
        }
    }
}