//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Natnael Tsige">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
// Natnael Tsige

namespace Spreadsheet_Natnael_Tsige
{
    using BadImplementation;

    /// <summary>
    /// Auto generated calss. The main enatry to the slotion.
    /// </summary>
    internal static class Demo
    {
        private static void Main(string[] args)
        {
           /*
            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird());
            letBirdsFly(birds);

            List<Bird> birds2 = new List<Bird>();
            birds2.Add(new Swan());
            letBirdsFly(birds2);*/
            

            List<Bird> birds3 = new List<Bird>();
            birds3.Add(new Penguin());
            letBirdsFly(birds3);
        }

        public static void letBirdsFly(List<Bird> birds)
        {
            foreach (Bird element in birds)
            {
                if (!(element.GetType() == typeof(Penguin))) {
                    element.fly();
                }
            }
        }
    }
}