/* Nick Coffin - 100555045.
 * OOP - Assignment 3 Character Sheet.
 * October 31, 2024.
 * Race class.
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
    public class Race
    {

        #region Class Scope Variables

        private static List<Race> races = new List<Race>();

        #endregion

        #region Properties

        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Constitution { get; private set; }
        public int Intelligence { get; private set; }
        public int Wisdom { get; private set; }
        public int Charisma { get; private set; }


        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Race() { }

        /// <summary>
        /// Paramaterized constructor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="strength"></param>
        /// <param name="dexterity"></param>
        /// <param name="constitution"></param>
        /// <param name="intelligence"></param>
        /// <param name="wisdom"></param>
        /// <param name="charisma"></param>
        public Race(string name, string description, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Name = name;
            Description = description;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        #endregion

        #region Custom Methods
        #endregion

        #region Static Methods
        /// <summary>
        /// A method to populate the races.
        /// Descriptions pulled from D&D site and Fandom.com.
        /// </summary>
        public static void InitializeDefaultRaces()
        {
            Race dwarf = new Race("Dwarf", "Raised from the earth in the elder days by a deity of the forge", 2,0,2,0,0,0);
            races.Add(dwarf);
            Race highelf = new Race("High Elf", "Graceful beings originated from the realm of Farie", 0, 2, 0, 1, 0, 0); 
            races.Add(highelf);
            Race woodelf = new Race("Wood Elf", "Graceful beings from forests and wooded areas", 0, 2, 0, 0, 1, 0);
            races.Add(woodelf);
            Race halfling = new Race("Halfling", "Posess a brave and adventurous spirit that leads them on journeys of discovery", 0, 2, 0, 0, 0, 1);
            races.Add(halfling);
            Race human = new Race("Human", "Found throughout the multiverse, humans are varied as they are numerous", 1, 1, 1, 1, 1, 1);
            races.Add(human);
            Race dragonborn = new Race("Dragonborne", "Ancestors of dragonborn hatched from the eggs of chromatic and metallic dragons", 2, 0, 0, 0, 0, 1);
            races.Add(dragonborn);
            Race gnome = new Race("Gnome", "Magical folk created by gods of invention, illusions, and life underground", 0, 1, 0, 2, 0, 0);
            races.Add(gnome);
            Race halfelf = new Race("Half-Elf", "The combination of what some say are the best qualities of their elf and human parents", 0, 1, 0, 1, 0, 2);
            races.Add(halfelf);
            Race halforc = new Race("Half-Orc", "Equipped with the gifts from orcs and humans to help them wander great plains, vast caverns, and churning seas", 2, 0, 1, 0, 0, 0);
            races.Add(halforc);
            Race tiefling = new Race("Tiefling", "Born in the Lower Planes or have fiendish ancestors who originated there", 0, 0, 0, 1, 0, 2);
            races.Add(tiefling);
            Race githyanki = new Race("Githyanki", "Physical prowess with psionic might, instilled in them by mind flayers and cultivated over eons in the Astral Plane", 1,2,0,0,0,0);
            races.Add(githyanki);
        }

        /// <summary>
        /// Method to return the races.
        /// </summary>
        /// <returns></returns>
        public static List<Race> GetRaces() { return races; }

        #endregion


    }
}
