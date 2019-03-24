using System;
using System.Collections.Generic;

namespace Ex1
{
    public delegate double Calc(double var);
    public class FunctionsContainer
    {
        // dictionary contain all the missions by their names.
        private Dictionary<string, Calc> missions = new Dictionary<string, Calc>();
        public Calc this[string mission]
        {
            // get mission
            get
            {
                if (!missions.ContainsKey(mission))
                {
                    missions[mission] = val => val;
                }
                return missions[mission];
            }
            // add mission to the dictionary
            set { missions[mission] = value; }
        }

        public List<String> getAllMissions()
        {
            List<String> all_Missions = new List<string>();
            foreach (var mission in missions)
            {
                all_Missions.Add(mission.Key);
            }

            return all_Missions;
        }

    }
}
