using System.Text;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = txtInput.Text;

            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show("Поле не може бути пустим!");
                return;
            }
            string originalText = text;

            int letters = 0;
            int digits = 0;
            int spaces = 0;
            int punctuation = 0;
            int upper = 0;
            int lower = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (char.IsLetter(c))
                    letters++;

                if (char.IsDigit(c))
                    digits++;

                if (char.IsWhiteSpace(c))
                    spaces++;

                if (char.IsPunctuation(c))
                    punctuation++;

                if (char.IsUpper(c))
                    upper++;

                if (char.IsLower(c))
                    lower++;
            }

            string[] words = text.Split(
                (char[]?)null,
                StringSplitOptions.RemoveEmptyEntries);

            StringBuilder result = new StringBuilder();

            result.Append($"Початковий текст: {originalText}\r\n");
            result.Append($"Довжина тексту: {text.Length}\r\n");
            result.Append($"Кількість літер: {letters}\r\n");
            result.Append($"Кількість цифр: {digits}\r\n");
            result.Append($"Кількість пробільних символів: {spaces} \r\n");
            result.Append($"Кількість розділових знаків: {punctuation}\r\n");
            result.Append($"Кількість великих літер: {upper}\r\n");
            result.Append($"Кількість малих літер: {lower} \r\n");
            result.Append($"Кількість слів: {words.Length} \r\n");

            for (int i = 0; i < words.Length; i++)
            {
                result.AppendLine(
                    $"Слово {i + 1}: {words[i]}, довжина: {words[i].Length}");
            }

            if (words.Length == 0)
            {
                result.AppendLine("Слів у тексті не знайдено.");
            }
            else
            {
                string longestWord = words[0];
                int longestWordNumber = 1;

                for (int i = 1; i < words.Length; i++)
                {
                    if (words[i].Length > longestWord.Length)
                    {
                        longestWord = words[i];
                        longestWordNumber = i + 1;
                    }
                }

                result.Append("\r\n");
                result.Append("Результат перетворення:\r\n");
                result.Append($"Перетворений текст: {longestWord}\r\n");
                result.Append($"Найдовше слово: {longestWord}\r\n");
                result.Append($"Довжина слова: {longestWord.Length}\r\n");
                result.Append($"Порядковий номер слова: {longestWordNumber}\r\n");
            }

            txtOutput.Text = result.ToString();
        }

        private void btnProcessClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
            txtOutput.Clear();
            txtInput.Focus();
        }
    }
}
