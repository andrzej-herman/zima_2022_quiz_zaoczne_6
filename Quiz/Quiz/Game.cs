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
            var qC = Questions.Where(x => x.Category == CurrentCategory).ToList();
            var number = Random.Next(0, qC.Count);
            var question = qC[number];
            question.Answers = question.Answers.OrderBy(x => Random.Next()).ToList();

            int order = 1;
            foreach (var answer in question.Answers)
            {
                answer.Order = order;
                order++;
            }
            
            CurrentQuestion = question;
        }
    }
}
