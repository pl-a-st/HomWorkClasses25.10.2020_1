using System;
using System.Collections.Generic;
using System.Text;

namespace HomWorkClasses25._10._2020_1
{
    class LandPlot
    {
        public int Length
        {
            get; private set;
        }
        public int Wight
        {
            get; private set;
        }
        public int ResidentsCount
        {
            get; private set;
        }
        public int Square
        {
            get; private set;
        }
        public int InventoryNumber
        {
            get; private set;
        }
        public LandPlot(int length, int wight, int residentsCount, int inventoryNumber)
        {
            Length = length;
            Wight = wight;
            ResidentsCount = residentsCount;
            InventoryNumber = inventoryNumber;
        }
        public void CalculateSquare()
           {
            Square = Length * Wight;
            }
    }
}
