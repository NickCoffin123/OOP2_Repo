/* Nick Coffin - 100555045.
 * OOP - Assignment 3 Character Sheet.
 * October 31, 2024.
 * Class class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Classes
{
    internal class Class
    {

        #region Class Scope Variables
        
        private static List<Class> classes = new List<Class>();

        #endregion

        #region Properties

        public string Name {  get; private set; }
        public string Description { get; private set; }
        public int BaseHitPoints {  get; private set; }

        #endregion

        #region Constructors

        public Class() { }

        public Class(string name, string description, int baseHitPoints)
        {
            Name = name;
            Description = description;
            BaseHitPoints = baseHitPoints;
        }

        #endregion

        #region Custom Methods
        #endregion

        #region Static Methods

        /// <summary>
        /// A method to populate the classes
        /// Descriptions pulled from D&D site
        /// </summary>
        public static void InitializeDefaultClasses()
        {
            Class barbarian = new Class("Barbarian", "A fierce warrior of primal rage", 12);
            classes.Add(barbarian);
            Class bard = new Class("Bard", "An inspiring preformer of music, dance, and magic", 8);
            classes.Add(bard);
            Class cleric = new Class("Cleric", "A miraculous priest of divine power", 8);
            classes.Add(cleric);
            Class druid = new Class("Druid", "A nature priest of primal power", 8);
            classes.Add(druid);
            Class fighter = new Class("Fighter", "A master of all arms and armor", 10);
            classes.Add(fighter);
            Class monk = new Class("Monk", "A martial artist of supernatural focus", 8);
            classes.Add(monk);
            Class paladin = new Class("Paladin", "A devout warrior of sacred oaths", 10);
            classes.Add(paladin);
            Class ranger = new Class("Ranger", "A wandering warrior imbued with primal magic", 10);
            classes.Add(ranger);
            Class rogue = new Class("Rogue", "A dexterous expert in stealth and subterfuge", 8);
            classes.Add(rogue);
            Class sorcerer = new Class("Sorcerer", "A dazzling mage filled with innate magic", 6);
            classes.Add (sorcerer);
            Class warlock = new Class("Warlock", "An occultist empowered by otherworldly pacts", 8);
            classes.Add(warlock);
            Class wizard = new Class("Wizard", "A scholary magic user of arcane power", 6);
            classes.Add(wizard);
        }

        public static List<Class> GetClasses() { return classes; }

        #endregion

    }
}
