using System;
using System.Collections.Generic;
using System.Text;


namespace HomWorkClasses25._10._2020_1
{
    class GeneratedParametersLend
    {
        
        public int InventoryNumber
        {
            get; private set;
        }
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
        /// <summary>
        /// Генерирует семизначный номер
        /// </summary>
        /// <param name="Лист сгенерированных номеров"></param>
        public void GenerateInventoryNumber(List<int> availablePassportNumbers)
        {
            const int MAX_INVENTORY_NUMBER = 10000000;
            const int MIN_INVENTORY_NIMBER = 1000000;
            Random rnd = new Random();
            do
            {
                InventoryNumber = rnd.Next(MIN_INVENTORY_NIMBER, MAX_INVENTORY_NUMBER);
            }
            while (availablePassportNumbers.Contains(InventoryNumber));
            availablePassportNumbers.Add(InventoryNumber);
        }
        public void GenerateLengthOrWight()
        {
            const int MAX_LENGTH_OR_WIGHT = 500;
            const int MIN_LENGTH_OR_WIGHT = 100;
            Random rnd = new Random();
            
                InventoryNumber = rnd.Next(MIN_LENGTH_OR_WIGHT, MAX_LENGTH_OR_WIGHT);
            
        }
    }
}
