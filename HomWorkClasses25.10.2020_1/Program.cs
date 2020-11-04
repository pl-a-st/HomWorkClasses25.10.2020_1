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
            //int humanCount = 5;
            //for (int i=0; i<humanCount; i++)
            //{
            //    CreateHumans(humans);
            //}
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
            foreach (LandPlot nextLandPlot in landPlots)
            {
                double[] shares = new double[nextLandPlot.ResidentsCount];
                double allShares = 1;
                Random rnd = new Random();
                for (int i = 0; i< nextLandPlot.ResidentsCount-1;i++)
                {
                    shares[i] =Math.Round((allShares *Math.Round(rnd.NextDouble(),3)),3);
                    allShares = allShares - shares[i];
                }
                shares[nextLandPlot.ResidentsCount-1] = allShares;
                for (int i = 0; i < nextLandPlot.ResidentsCount; i++)
                {
                   Human human= CreateAddHumanList(humans);
                   human.AddSharesLandPlots(nextLandPlot.InventoryNumber, shares[i]);
                }
            }
            Console.WriteLine("");
            foreach (Human nextHuman in humans)
            {
               
                Console.WriteLine("Участок {0}, доля {1}, владелец {2} {3} {4}",nextHuman.SharesLandPlots[0].inventoryNumber, nextHuman.SharesLandPlots[0].share,nextHuman.Surname,nextHuman.Name,nextHuman.MiddleName);
            }
        }
        static void AddHumanList(List<Human> humans)
        {
            GeneratedPerson generatedPerson = new GeneratedPerson();
            generatedPerson.AddGeneratedPersonWithParametrs(humans);
        }
        static Human CreateAddHumanList(List<Human> humans)
        {
            GeneratedPerson generatedPerson = new GeneratedPerson();
           Human  human= generatedPerson.RetunAddGeneratedPersonWithParametrs(humans);
            return human;
        }
        static void CreateLandPlots (List<LandPlot> landPlots)
        {
            GeneratedParametersLend generatedParametersLend = new GeneratedParametersLend();
            generatedParametersLend.AddGeneratedLandPlotWithParametrs(landPlots);
        }

    }
}
