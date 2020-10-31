using System;
using System.Collections.Generic;
using System.Text;
public struct ShareLandPlot
{
    public int inventoryNumber;
    public double share;
}

namespace HomWorkClasses25._10._2020_1
{
    class Human
    {
        public string Name
        {
            get; private set;
        }
        public string Surname
        {
            get; private set;
        }
        public string MiddleName
        {
            get; private set;
        }
        public int Age
        {
            get; private set;
        }
        public List<ShareLandPlot> SharesLandPlots
        {
            get; private set;
        }
        public Human(string name, string surname, string middleName, int age)
        {
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            Age = age;
        }
        public void 
    }
}
