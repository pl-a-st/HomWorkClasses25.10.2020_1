﻿using System;
using System.Collections.Generic;
using System.Text;
public struct ShareLandPlot
{
    public int inventoryNumber;
    public double share;
    public double areaShareLandPlot;
}

namespace HomWorkClasses25._10._2020_1
{
   public class Human
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
        public int PassportNumber
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
        public Human(string name, string surname, string middleName,int passportNumber, int age)
        {
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            Age = age;
            PassportNumber = passportNumber;
        }
        /// <summary>
        /// Добавление владения долей
        /// </summary>
        /// <param name="inventoryNumber"></param>
        /// <param name="share"></param>
        public void AddSharesLandPlots (int inventoryNumber, double share, double areaShareLandPlot)
        {
            List<ShareLandPlot> sharesLandPlots = new List<ShareLandPlot>();
            if (SharesLandPlots!=null)
            {
                sharesLandPlots = SharesLandPlots;
            }
            ShareLandPlot shareLandPlot = new ShareLandPlot();
            shareLandPlot.inventoryNumber = inventoryNumber;
            shareLandPlot.share = share;
            shareLandPlot.areaShareLandPlot = areaShareLandPlot;
            sharesLandPlots.Add(shareLandPlot);
            SharesLandPlots = sharesLandPlots;
            
        }
    }
}
