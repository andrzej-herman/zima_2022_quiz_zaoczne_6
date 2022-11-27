using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Game
    {
        public Game()
        {
            CreateQuestions();
            CurrentCategory = 100;
            Random = new Random();
        }

        public List<Question> Questions { get; set; }
        public int CurrentCategory { get; set; }
        public Question CurrentQuestion { get; set; }
        public Random Random { get; set; }

        public void CreateQuestions()
        {
            var path = Directory.GetCurrentDirectory() + "\\questions.json";
            var text = File.ReadAllText(path);
            Questions = JsonConvert.DeserializeObject<List<Question>>(text);
        }

        public void GetQuestion()
        {
            var qC = new List<Question>();
            foreach (var q in Questions)
            {
                if (q.Category == CurrentCategory)
                {
                    qC.Add(q);
                }          
            }

            var number = Random.Next(0, qC.Count);
            CurrentQuestion = qC[number];
        }
    }
}
