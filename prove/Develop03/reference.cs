    class Reference
    {
        public string Book { get; private set; }
        public int Chapter { get; private set; }
        public int StartVerse { get; private set; }
        public int EndVerse { get; private set; }

        public Reference(string book, int chapter, int startVerse, int endVerse = -1)
        {
            Book = book;
            Chapter = chapter;
            StartVerse = endVerse == -1 ? startVerse : endVerse;
            EndVerse = endVerse;
        }

        public string GetDisplayText()
        {
            return EndVerse == -1
                ? $"{Book} {Chapter}:{StartVerse}"
                : $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        }
    }

