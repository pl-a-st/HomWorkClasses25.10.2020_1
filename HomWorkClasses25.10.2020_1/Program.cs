using System;
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
            Console.WriteLine("");
            List<Human> humans = new List<Human>();
            int humanCount = 5;
            for (int i=0; i<humanCount; i++)
            {
                CreateHumans(humans);
            }
            List<LandPlot> landPlots = new List<LandPlot>();
            int landPlotsCount = 5;
            for (int i = 0; i < landPlotsCount; i++)
            {
                CreateLandPlots(landPlots);
            }
            LandPlot mostSquareLandPlot = landPlots[0];
            int differenceeLngthHeight = Math.Abs(landPlots[0].Length - landPlots[0].Wight);
            foreach (LandPlot nextLandPlot in landPlots)
            {
                if (Math.Abs(nextLandPlot.Length - nextLandPlot.Wight)<differenceeLngthHeight)
                {
                    mostSquareLandPlot = nextLandPlot;
                    differenceeLngthHeight = Math.Abs(nextLandPlot.Length - nextLandPlot.Wight);
                }
            }
            Console.WriteLine("Самый квадрантый участок: {0}", mostSquareLandPlot.InventoryNumber);
            foreach (LandPlot nextLandPlot in landPlots)
            {
                Console.WriteLine("Участок {0} длина: {1}, ширина: {2}, количество жителей: {3}," +
                    " квадратных метров на человека: {4}", nextLandPlot.InventoryNumber, nextLandPlot.Length, nextLandPlot.Wight,
                    nextLandPlot.ResidentsCount, nextLandPlot.CalculateAreaPerPerson());
            }
        }
        static void CreateHumans(List<Human> humans)
        {
            GeneratedPerson generatedPerson = new GeneratedPerson();
            generatedPerson.AddGeneratedPersonWithParametrs(humans);
        }
        static void CreateLandPlots (List<LandPlot> landPlots)
        {
            GeneratedParametersLend generatedParametersLend = new GeneratedParametersLend();
            generatedParametersLend.AddGeneratedLandPlotWithParametrs(landPlots);
        }

    }
}
