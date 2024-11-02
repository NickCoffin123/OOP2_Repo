/* Nick Coffin - 100555045.
 * OOP - Assignment 3 Character Sheet.
 * October 31, 2024.
 * Constants class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet.Classes
{
    public class Constants
    {

        #region Alignment

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

        public enum General
        {
            ArmourClass = 10,
            Speed = 6
        }

        #endregion


    }
}
