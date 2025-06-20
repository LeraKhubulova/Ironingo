using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ironingo
{
    public class DictionaryManager  //управляет списком слов и их сохранением/загрузкой
    {
        private List<Word> words = new List<Word>();
        private readonly string filePath;//приватное поле хранящее путь к файлу где сохраняется и откуда загружается словарь

        public DictionaryManager(string filePath)
        {
            this.filePath = filePath;//конструктор класса принимает путь к файлу и сохраняет его в поле 
        }

        // получить список слов только для чтения
        public IReadOnlyList<Word> Words => words.AsReadOnly();//не позволяет изменять список снаружи

        // добавить слово, возвращает фолз если слово уже есть
        public bool AddWord(Word word)
        {
            if (words.Any(w => w.Ossetian.Equals(word.Ossetian, StringComparison.OrdinalIgnoreCase)))
                return false;

            words.Add(word);
            return true;
        }

        // удалить слово
        public void RemoveWord(Word word)
        {
            words.Remove(word);
        }

        // загрузить слова из файла
        public void Load()
        {
            words.Clear();
            if (!File.Exists(filePath))
                return;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(new string[] { " - " }, StringSplitOptions.None);
                if (parts.Length == 2)
                {
                    //tсли строка корректна  создаёт новый объект Word и добавляет его в список
                    words.Add(new Word { Ossetian = parts[0], Translation = parts[1] });
                }
            }
        }

        // cохранить слова в файл
        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var word in words)
                {
                    writer.WriteLine($"{word.Ossetian} - {word.Translation}");
                }
            }
        }
    }
}
