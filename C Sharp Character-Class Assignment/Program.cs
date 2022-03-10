Create a Character class

// TASK 1 \\ 
class Character {
    // Create a field 
    public string name;
    public string phrase1;
    public string phrase2;
    public int level = 0;
   
    // Define constructor method
    public Character(string _name, string _phrase1, string _phrase2, int _level)
    {
        name = _name;
        phrase1 = _phrase1;
        phrase2 = _phrase2;
        level = _level;
        
    }

    // Methods (Functions / Behaviour)
    public void Speak(int phraseNum)
    {

        int _phrase1 = phraseNum;
        int _phrase2 = phraseNum;

    }

    public void SetLevel(int newLevel)
    {
        int _level = +newLevel;
    }




    // TASK 2 \\ 

    static void Main(string[] args)
    {
        Character Po = new Character("Kung Fu Panda", "Skadoosh", "You have been blinded by pure awesomeness!", 0);
        Character Parker = new Character("Spiderman", "My Spider-Sense is tingling", "Your friendly neighbourhood spiderman.", 1);


        // TASK 3 \\
        Po.Speak(1);
        Parker.SetLevel(2);
        Parker.Speak(2);
    }
   
}
