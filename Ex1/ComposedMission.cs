using System;
using System.Collections.Generic;

namespace Ex1
{
    public class ComposedMission : IMission
    {
        private string name;
        private List<Calc> missions = new List<Calc>();
        // An Event of when a mission is activated
        public event EventHandler<double> OnCalculate;  
        public ComposedMission(string myName)
        {
            name = myName;
        }
        
        public String Name
        {
            get => this.name;
        }
        public String Type
        {
            get => "Composed";
        }
        public ComposedMission Add(Calc mission)
        {
            missions.Add(mission);
            return this;
        }
        public double Calculate(double value)
        {
            double num = value;
            foreach (var mission in missions)
            {
                num = mission(num);
            }

            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this,num); 
            }
            return num;
        }
    }
}
