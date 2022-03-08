// Create a Character class
class Character {
    // Create a field 
    public string name;
    public string phrase1;
    public string phrase2;
    public int level = 0;
   
    // Define constructor method
    public Character()
    {
        this.name = "Mustang";
        this.phrase1 = "My name is Roy Mustang.";
        this.phrase2 = "Fire is my alchemy!";
        
    }

    // Methods (Functions / Behaviour)
     public static void speak(phraseNum)
    {
        
        Console.WriteLine("Which catchphrase should the character say?");
        phraseNum = Convert.ToInt32(Console.ReadLine));
    }

    static void Main(string[] args)
    {
        Character Roy = new Character();
        Console.WriteLine(Roy.name);
        Console.WriteLine(Roy.phrase1);
        Console.WriteLine(Roy.phrase2);
    }
}
