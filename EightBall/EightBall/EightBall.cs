using Newtonsoft.Json;
using System;

namespace EightBall
{
    public class EightBall
    {
        public string GetRandom()
        {
            //source: https://en.wikipedia.org/wiki/Magic_8-Ball

            var rand = new Random();
            var index = rand.Next(21);

            switch (index)
            {
                case 0:
                    return "It is certain";

                case 1:
                    return "It is decidedly so";

                case 2:
                    return "Without a doubt";

                case 3:
                    return "Yes definitely";

                case 4:
                    return "You may rely on it";

                case 5:
                    return "As I see it, yes";

                case 6:
                    return "Most likely";

                case 7:
                    return "Outlook good";

                case 8:
                    return "Yes";

                case 9:
                    return "Signs point to yes";

                case 10:
                    return "Reply hazy try again";

                case 11:
                    return "Ask again later";

                case 12:
                    return "Better not tell you now";

                case 13:
                    return "Cannot predict now";

                case 14:
                    return "Concentrate and ask again";

                case 15:
                    return "Don't count on it";

                case 16:
                    return "My reply is no";

                case 17:
                    return "My sources say no";

                case 18:
                    return "Outlook not so good";

                case 19:
                    return "Very doubtful";

                case 20:
                    return "Laurier is wrong";

                default:
                    return string.Format("Unknown value {0}", index);
            }
        }

        public string GetJson()
        {
            var response = new SlackReponse();
            response.text = GetRandom();

            return JsonConvert.SerializeObject(response, Formatting.Indented);
        }
    }
}