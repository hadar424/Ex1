using System;

namespace Ex1
{
    public class SingleMission : IMission
    {
        private string name;
        private Calc mission;
        // An Event of when a mission is activated
        public event EventHandler<double> OnCalculate;  
        
        public SingleMission(Calc type, string myName)
        {
            name = myName;
            mission = type;
        }
        
        public String Name
        {
            get => this.name;
        }
        public String Type
        {
            get => "Single";
        }
        
        public double Calculate(double value)
        {
            double num = mission(value);
            if (OnCalculate != null)
            {
                OnCalculate.Invoke(this,num); 
            }
            return num;
        }
    }
}
