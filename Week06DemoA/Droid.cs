﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week06DemoA
{
    internal class Droid
    {
        #region Class Scope Variables

        public const int MIN_DESIGNATION_LENGTH = 3;
        public const int MAX_DESIGNATION_LENGTH = 8;
        public const int MIN_OWNER_LENGTH = 5;

        public static List<Droid> droids = new List<Droid>();

        #endregion

        #region Properties

        private string _designation;

        public string Designation
        {
            get
            {
                return _designation;
            }
            set
            {
                if (value.Length >= MIN_DESIGNATION_LENGTH && value.Length <= MAX_DESIGNATION_LENGTH)
                {
                    _designation = value;
                }
            }
        }
        public string Owner { get; set; }
        public bool IsInService { get; set; }
        public Color PrimaryColor { get; set; }
        public Color SecondaryColor { get; set; }

        #endregion

        #region Constructors

        public Droid() { }

        public Droid(string designation, string owner, bool isInService, Color primaryColor, Color secondaryColor)
        {
            Designation = designation;
            Owner = owner;
            IsInService = isInService;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }



        #endregion

        #region Custom Methods

        public void SellDroid(string owner, bool isInService)
        {
            // this. isn't necessary. It is based on naming conventions and if the property was capitalized.
            this.Owner = owner;
            IsInService = isInService;
        }

        #endregion

        #region Static Methods

        /// <summary>
        /// Temporary, just for testing.
        /// </summary>
        public static void PopulateSampleDroids()
        {
            Droid droid = new Droid("R2D2", "Obi-Won Kenobi", true, Color.Silver, Color.Navy);
            droids.Add(droid);

            droid = new Droid("C3PO", "Aankin Skywalker", true, Color.Gold, Color.Gold);
            droids.Add(droid);

            droid = new Droid("BB-8", "Poe Damerin", true, Color.White, Color.Orange);
            droids.Add(droid);

            droid = new Droid("R4D2", "Obi-Won Kenobi", true, Color.Silver, Color.Red);
            droids.Add(droid);
        }

        public static Droid FindDroid(String droidDesignation)
        {
            
            foreach(Droid droid in droids)
            {
                if (droid.Designation == droidDesignation) return droid; 
            }
            
            return null;
        }

        #endregion
    }
}
