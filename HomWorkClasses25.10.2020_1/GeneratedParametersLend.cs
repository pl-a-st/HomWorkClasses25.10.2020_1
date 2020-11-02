using System;
using System.Collections.Generic;
using System.Text;


namespace HomWorkClasses25._10._2020_1
{
   public static class GeneratedParametersLend
    {
       
        /// <summary>
        /// Генерирует семизначный номер
        /// </summary>
        /// <param name="Лист сгенерированных номеров"></param>
        public static int GenerateInventoryNumber(List<int> availablePassportNumbers)
        {
            const int MAX_INVENTORY_NUMBER = 10000000;
            const int MIN_INVENTORY_NIMBER = 1000000;
            Random rnd = new Random();
            do
            {
               return rnd.Next(MIN_INVENTORY_NIMBER, MAX_INVENTORY_NUMBER);
            }
            while (availablePassportNumbers.Contains(InventoryNumber));
            availablePassportNumbers.Add(InventoryNumber);
        }
    }
}
