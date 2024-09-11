namespace BakaTeacher
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> hiraganaToRomaji = new Dictionary<string, string>
        {
            {"ん", "N"},{"わ", "Wa"},{"ら", "Ra"},{"や", "Ya"},{"ま", "Ma"},{"は", "Ha"},{"な", "Na"},{"た", "Ta"},{"さ", "Sa"},{"か", "Ka"},{"あ", "A"},
            {"り", "Ri"},{"み", "Mi"},{"ひ", "Hi"},{"に", "Ni"},{"ち", "Chi"},{"し", "Shi"},{"き", "Ki"},{"い", "I"},
            {"る", "Ru"},{"ゆ", "Yu"},{"む", "Mu"},{"ふ", "Fu"},{"ぬ", "Nu"},{"つ", "Tsu"},{"す", "Su"},{"く", "Ku"},{"う", "U"},
            {"れ", "Re"},{"め", "Me"},{"へ", "He"},{"ね", "Ne"},{"て", "Te"},{"せ", "Se"},{"け", "Ke"},{"え", "E"},
            {"を", "Wo"},{"ろ", "Ro"},{"よ", "Yo"},{"も", "Mo"},{"ほ", "Ho"},{"の", "No"},{"と", "To"},{"そ", "So"},{"こ", "Ko"},{"お", "O"}
        };

        Dictionary<string, string> katakanaToHiragana = new Dictionary<string, string>
        {
            {"ン", "ん"},{"ワ", "わ"},{"ラ", "ら"},{"ヤ", "や"},{"マ", "ま"},{"ハ", "は"},{"七", "な"},{"タ", "た"},{"サ", "さ"},{"カ", "か"},{"ア", "あ"},
            {"リ", "り"},{"ミ", "み"},{"ヒ", "ひ"},{"ニ", "に"},{"チ", "ち"},{"シ", "し"},{"キ", "き"},{"イ", "い"},
            {"ル", "る"},{"ユ", "ゆ"},{"ム", "む"},{"フ", "ふ"},{"ヌ", "ぬ"},{"ツ", "つ"},{"ス", "す"},{"ク", "く"},{"ウ", "う"},
            {"レ", "れ"},{"メ", "め"},{"ネ", "ね"},{"テ", "て"},{"セ", "せ"},{"ケ", "け"},{"エ", "え"},
            {"ロ", "ろ"},{"ヨ", "よ"},{"モ", "も"},{"ホ", "ほ"},{"ノ", "の"},{"ト", "と"},{"ソ", "そ"},{"コ", "こ"},{"オ", "お"}
        };
        static bool questionType = true;
        static int correctGuesses = 0;
        static int incorrectGuesses = 0;
        public Form1()
        {
            InitializeComponent();
            NewQuestion(questionType);
        }

        private void NewQuestion(bool selection)
        {
            Random random = new Random();
            if (selection)
            {
                var randomKana = hiraganaToRomaji.ElementAt(random.Next(hiraganaToRomaji.Count));
                lblCharacter.Text = randomKana.Key;
                PopualteFields(selection, randomKana);
            }
            else
            {
                var randomKana = katakanaToHiragana.ElementAt(random.Next(katakanaToHiragana.Count));
                lblCharacter.Text = randomKana.Key;
                PopualteFields(selection, randomKana);
            }
        }

        private void PopualteFields(bool selection, KeyValuePair<string, string> correctAnswer)
        {
            Random random = new Random();
            var incorrectAnswers = GetIncorrectAnswers(selection, correctAnswer.Value, 3, random);

            var allAnswers = incorrectAnswers.ToList();
            allAnswers.Insert(random.Next(allAnswers.Count + 1), correctAnswer.Value);

            Button[] buttons = { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };

            for(int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = allAnswers[i];
            }
        }

        private HashSet<string> GetIncorrectAnswers(bool selection, string correctAnswer, int count, Random random)
        {
            var incorrectAnswers = new HashSet<string>();
            var values = selection ? hiraganaToRomaji.Values : katakanaToHiragana.Values;
            while(incorrectAnswers.Count < count)
            {
                var randomChoice = values.ElementAt(random.Next(values.Count()));
                if(randomChoice != correctAnswer)
                {
                    incorrectAnswers.Add(randomChoice);
                }
            }

            return incorrectAnswers;
        }

        private void btnSwitchKatakana_Click(object sender, EventArgs e)
        {
            questionType = false;
            NewQuestion(questionType);
        }

        private void btnSwitchHiragana_Click(object sender, EventArgs e)
        {
            questionType = true;
            NewQuestion(questionType);
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            CheckAnswer(1, questionType);
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            CheckAnswer(2, questionType);
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            CheckAnswer(3, questionType);
        }

        private void btnAnswer4_Click(object sender, EventArgs e)
        {
            CheckAnswer(4, questionType);
        }

        private void CheckAnswer(int choice, bool questionType)
        {
            string correctAnswer = questionType
                ? hiraganaToRomaji[lblCharacter.Text]
                : katakanaToHiragana[lblCharacter.Text];

            Button[] answerButtons = { btnAnswer1, btnAnswer2, btnAnswer3, btnAnswer4 };

            if (answerButtons[choice - 1].Text == correctAnswer)
                correctGuesses++;
            else
                incorrectGuesses++;

            lblCorrect.Text = correctGuesses.ToString();
            lblWrong.Text = incorrectGuesses.ToString();

            NewQuestion(questionType);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}