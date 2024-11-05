/* Nick Coffin - 100555045.
 * OOP - Assignment 3 Character Sheet.
 * October 31, 2024.
 * Constants class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;


namespace CharacterSheet.Classes
{
    /// <summary>
    /// Main method.
    /// </summary>
    public class Constants
    {

        #region Alignment

        /// <summary>
        /// Enum for alignment.
        /// </summary>
        public enum Alignment
        {
            LawfulGood,
            NeutralGood,
            ChaoticGood,
            LawfulNeutral,
            TrueNeutral,
            ChaoticNeutral,
            LawfulEvil,
            NeutralEvil,
            ChaoticEvil
        }

        #endregion

        #region Attribute

        /// <summary>
        /// Enum for attributes.
        /// </summary>
        public enum Attribute
        {
            Strength,
            Dexerity,
            Constitution,
            Intelligence,
            Wisdom,
            Charisma
        }

        #endregion

        #region General

        /// <summary>
        /// Enum for general.
        /// </summary>
        public enum General
        {
            ArmourClass = 10,
            Speed = 6
        }

        #endregion

    }
}
