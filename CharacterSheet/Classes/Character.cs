/* Nick Coffin - 100555045.
* OOP - Assignment 3 Character Sheet.
* October 31, 2024.
* Character class.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Classes
{
    /// <summary>
    /// Main method.
    /// </summary>
    public class Character
    {

        #region Class Scope Variables

        public static List<Character> characters = new List<Character>();

        #endregion

        #region Properties

        public string Name { get; set; }
        public Class CharacterClass { get; private set; }
        public Race CharacterRace { get; private set; }
        public Constants.Alignment CharacterAlignment { get; set; }
        public string Gender { get; set; }
        public int Level { get; private set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int ArmourClass { get; set; }
        public int Initiative => Dexterity;
        public int HitPoints { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Character() { }

        /// <summary>
        /// Paramatized constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="characterClass"></param>
        /// <param name="characterRace"></param>
        /// <param name="characterAlignment"></param>
        /// <param name="gender"></param>
        /// <param name="level"></param>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="constitution"></param>
        /// <param name="intelligence"></param>
        /// <param name="wisdom"></param>
        /// <param name="charisma"></param>
        /// <param name="armourClass"></param>
        /// <param name="hitPoints"></param>
        public Character(string name, Class characterClass, Race characterRace, Constants.Alignment characterAlignment, string gender,
            int level, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma, int armourClass, int hitPoints)
        {
            Name = name;
            CharacterClass = characterClass;
            CharacterRace = characterRace;
            CharacterAlignment = characterAlignment;
            Gender = gender;
            Level = level;
            ArmourClass = armourClass;
            HitPoints = 10;

            Strength = strength + CharacterRace.Strength;
            Dexterity = dexterity + CharacterRace.Dexterity;
            Constitution = constitution + CharacterRace.Constitution;
            Intelligence = intelligence + CharacterRace.Intelligence;
            Wisdom = wisdom + CharacterRace.Wisdom;
            Charisma = charisma + CharacterRace.Charisma;
        }

        #endregion

        #region Custom Methods
        #endregion

        #region Static Methods

        /// <summary>
        /// A method to create a default character.
        /// </summary>
        public static void DefaultCharacter()
        {
            // Retrieve the "Druid" class and "Human" race from the static lists
            Class druidClass = Class.GetClasses().First(c => c.Name == "Druid");
            Race humanRace = Race.GetRaces().First(r => r.Name == "Human");

            // Create the character using the retrieved class and race instances
            Character nick = new Character("Nick", druidClass, humanRace, Constants.Alignment.TrueNeutral, "Male", 1,
                8, 8, 8, 8, 8, 8, 10, 10);
            characters.Add(nick);
        }

        /// <summary>
        /// A method to return the characters.
        /// </summary>
        /// <returns></returns>
        public static List<Character> GetCharacters() { return characters; }


        #endregion

    }
}