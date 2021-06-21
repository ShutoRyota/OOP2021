using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);


            
        }


        //ファイルからStudentクラスの作成： 
        private static IEnumerable<Student> ReadScore(string filePath) {
            var scores = new List<Student>();
            var lines = File.ReadAllLines(filePath);
            foreach(var s in lines) {
                var items = s.Split(',');
                var student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                scores.Add(student);
            }
            return scores;
        }

        //科目ごとの点数： 
        public IDictionary<string, int> GetPerStudentScore() {

            var dict = new Dictionary<string, int>();
            foreach(var s in _score) {
                if (dict.ContainsKey(s.Subject)) {
                    dict[s.Subject] += s.Score;
                } else {
                    dict[s.Subject] = s.Score;
                }
            }
            return dict;
        }
    }
}
