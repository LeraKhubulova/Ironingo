using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ironingo
{
    public class TestManager
    {
        private readonly List<Word> words;//приватное поле words — список слов для теста
        private int currentIndex = -1;//чтобы при первом вызове увеличить на 1 и получить индекс 0 
        private int correctCount = 0;

        //конструктор класса,принимает список слов для тестиков
        public TestManager(IReadOnlyList<Word> sourceWords)
        {
            if (sourceWords == null || sourceWords.Count == 0)
                throw new ArgumentException("Список слов пуст.");

            // перемешиваем слова
            words = sourceWords.OrderBy(w => Guid.NewGuid()).ToList();
        }

        //публичные свойства возвращающие общее кол-во,кол-во правильных оветоы 
        public int TotalWords => words.Count;
        public int CorrectAnswers => correctCount;
        public int CurrentIndex => currentIndex + 1; // чтоб пользователь увидел индекс с 1 а не 0

        public Word GetNextWord()//получения след.слова из списка
        {
            currentIndex++;
            if (currentIndex >= words.Count)
                return null; 
            return words[currentIndex];
        }

        public void CheckAnswer(string userAnswer)//метод для проверки ответа пользователя
        {
            if (currentIndex < 0 || currentIndex >= words.Count)
                throw new InvalidOperationException("Нет текущего слова для проверки.");



            if (string.Equals(userAnswer?.Trim(), words[currentIndex].Translation, StringComparison.OrdinalIgnoreCase))
            {
                correctCount++;
            }
        }
    }
}
