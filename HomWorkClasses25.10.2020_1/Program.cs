﻿using System;
using System.Collections.Generic;

namespace HomWorkClasses25._10._2020_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 В поселении имеются несколько участков. Каждый участок имеет некоторое количество жителей, " +
                "длину и ширину. Найти самый \"квадратный\" из участков, учитывая, что все они имеют прямоугольную форму, " +
                "оценить, сколько получается квадратных метров на жителя, на каждом из участков. Кол-во жителей, длину, " +
                "ширину. 1* Жители на участках имеют фамилию, имя, возраст, долю от участка. Оценить метраж каждого " +
                "участника, относительно его долевого процента (процент генерировать), при том, что 100% участка должно" +
                " быть распределено. Выводить доли после генерации и рассчетов.");
            int inventoryNumber = 100;
            double share = 0.5;
            //Human human = new Human("Сергей", "Верин", "Сергеевич", 35);
            // human.AddingSharesLandPlots(inventoryNumber, share);
            //human.AddingSharesLandPlots(inventoryNumber, share);
            GeneratedPerson generated = new GeneratedPerson();
            generated.GenerateName();
            List<int> availablePassportNumbers = new List<int>();
            generated.GeneratePassportNumber(availablePassportNumbers);
            generated.GeneratePassportNumber(availablePassportNumbers);

            string name = generated.Name;
        }

    }
}
