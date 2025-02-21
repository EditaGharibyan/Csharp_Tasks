
namespace Game_Character_System
{
    partial class Character {
        public string CharacterName;
        public string Level;
        public Character(string name,string level) {
            this.CharacterName = name;
            this.Level = level;
        
        }
    
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Character[] obj = {
                new Character("Tic-Tac-Toe","Second"),
                new Character("Sudoku","First"),
                new Character("Chess","Second"),
            };

            foreach (Character item in obj)
            {
                item.ShowDetails();
            }
        }
    }
}
