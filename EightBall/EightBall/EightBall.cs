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
            _wisdom = new List<string>();

            //source: https://en.wikipedia.org/wiki/Magic_8-Ball

            _wisdom.Add("It is certain.");
            _wisdom.Add("It is decidedly so.");
            _wisdom.Add("Without a doubt.");
            _wisdom.Add("Yes definitely.");
            _wisdom.Add("You may rely on it.");
            _wisdom.Add("As I see it, yes.");
            _wisdom.Add("Most likely.");
            _wisdom.Add("Outlook good.");
            _wisdom.Add("Yes.");
            _wisdom.Add("Signs point to yes.");
            _wisdom.Add("Reply hazy try again.");
            _wisdom.Add("Ask again later.");
            _wisdom.Add("Better not tell you now.");
            _wisdom.Add("Cannot predict now.");
            _wisdom.Add("Concentrate and ask again.");
            _wisdom.Add("Don't count on it.");
            _wisdom.Add("My reply is no.");
            _wisdom.Add("My sources say no.");
            _wisdom.Add("Outlook not so good.");
            _wisdom.Add("Very doubtful.");
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