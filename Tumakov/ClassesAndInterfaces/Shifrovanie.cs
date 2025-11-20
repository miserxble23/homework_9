using System;
using System.Text;
namespace Shifrovanie
{
    // Интерфейс для шифрования
    public interface ICipher
    {
        string Encode(string text);
        string Decode(string text);
    }
    // Класс ACipher - шифрование сдвигом на одну позицию
    public class ACipher : ICipher
    {
        public string Encode(string text)
        {
            return ShiftText(text, 1);
        }
        public string Decode(string text)
        {
            return ShiftText(text, -1);
        }
        private string ShiftText(string text, int shift)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                if (char.IsLetter(c)) // Проверяем, является ли символ БУКВОЙ
                {
                    char baseChar=char.IsUpper(c) ? 'А' : 'а'; // Определяем базовую букву
                    char shifted = (char)(((c-baseChar+shift+33)%33)+baseChar);
                    result.Append(shifted);
                }
                else
                {
                    // Если это НЕ буква - оставляем как есть
                    result.Append(c);
                }
            }
            return result.ToString(); // превращает в готовую строку
        }
    }
    public class BCipher : ICipher
    {
        public string Encode(string text)
        {
            return ReplaceText(text);
        }
        public string Decode(string text)
        {
            return ReplaceText(text);
        }
        private string ReplaceText(string text)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'А' : 'а';
                    int position = c - baseChar;
                    int mirrorPosition = 32 - position;
                    char mirror = (char)(mirrorPosition + baseChar);
                    result.Append(mirror);
                }
                else
                {
                    result.Append(c); 
                }
            }
            return result.ToString(); // превращает в готовую строку
        }
    }
}
