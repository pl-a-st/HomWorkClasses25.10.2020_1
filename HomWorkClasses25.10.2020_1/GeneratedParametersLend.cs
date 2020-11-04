using System;
using System.Collections.Generic;
using System.Text;


namespace HomWorkClasses25._10._2020_1
{
   public class GeneratedParametersLend
    {

        /// <summary>
        /// Генерирует семизначный номер
        /// </summary>
        /// <param name="Лист сгенерированных номеров"></param>
        //public static int GenerateInventoryNumber(List<int> availablePassportNumbers)
        //{
        //    const int MAX_INVENTORY_NUMBER = 10000000;
        //    const int MIN_INVENTORY_NUMBER = 1000000;
        //    int inventoryNumber;
        //    Random rnd = new Random();
        //    do
        //    {
        //        inventoryNumber = rnd.Next(MIN_INVENTORY_NUMBER, MAX_INVENTORY_NUMBER);
        //        if (!availablePassportNumbers.Contains(inventoryNumber))
        //        {
        //            availablePassportNumbers.Add(inventoryNumber);
        //            return inventoryNumber;
        //        }

        //    }
        //    while (availablePassportNumbers.Contains(inventoryNumber));
        //    return 0;
        //}
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
        public int InventoryNumber
        {
            get; private set;
        }
        public void GenerateResidentsCount()
        {
            const int MIN_RESIDENTS_COUNT = 1;
            const int MAX_RESIDENTS_COUNT = 5;
            Random rnd = new Random();
            ResidentsCount = rnd.Next(MIN_RESIDENTS_COUNT, MAX_RESIDENTS_COUNT+1);
        }
        public void GenerateLengthWight()
        {
            const int MIN_LENGTH_WIGHT = 100;
            const int MAX_LENGTH_WIGHT = 500;
            Random rnd = new Random();
            Length = rnd.Next(MIN_LENGTH_WIGHT, MAX_LENGTH_WIGHT + 1);
            Wight = rnd.Next(MIN_LENGTH_WIGHT, MAX_LENGTH_WIGHT + 1);
        }
      
        /// <summary>
        /// Генерирует семизначный номер
        /// </summary>
        /// <param name="Лист сгенерированных номеров"></param>
        public void GenerateInventoryNumber(List<LandPlot> availableLandPlots)
        {
            const int MAX_INVENTORY_NUMBER = 10000000;
            const int MIN_INVENTORY_NIMBER = 1000000;
            Random rnd = new Random();
            bool inventoryExists = false;
            do
            {
                InventoryNumber = rnd.Next(MIN_INVENTORY_NIMBER, MAX_INVENTORY_NUMBER);
                inventoryExists = false;
                foreach (LandPlot nextLandPlot in availableLandPlots)
                {
                    if (nextLandPlot.InventoryNumber == InventoryNumber)
                    {
                        inventoryExists = true;
                    }
                }
            }
            while (inventoryExists);
        }
        public void GenerateAllParametrsLend(List<LandPlot> availableLandPlots)
        {
            GenerateInventoryNumber(availableLandPlots);
            GenerateLengthWight();
            GenerateResidentsCount();

        }
        public void AddGeneratedLandPlotWithParametrs(List<LandPlot> availableLandPlots)
        {
            GenerateAllParametrsLend(availableLandPlots);
            LandPlot landPlot = new LandPlot(Length, Wight, ResidentsCount, InventoryNumber);
            availableLandPlots.Add(landPlot);
        }
    }
}
