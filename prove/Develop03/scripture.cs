    class Scripture
    {
        public Reference Reference { get; private set; }
        private List<Word> Words;

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void HideRandomWords(int count)
        {
            var random = new Random();
            var indices = Enumerable.Range(0, Words.Count).OrderBy(x => random.Next()).Take(count);
            
            foreach (var index in indices)
            {
                Words[index].Hide();
            }
        }

        public override string ToString()
        {
            return $"{Reference.GetDisplayText()}\n\n" + string.Join(' ', Words);
        }

        public bool AllWordsHidden()
        {
            return Words.All(word => word.IsHidden);
        }
    }