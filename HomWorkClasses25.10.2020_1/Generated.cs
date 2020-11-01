using System;
using System.Collections.Generic;
using System.Text;

enum Gender
{
    men=1,
    women
}
namespace HomWorkClasses25._10._2020_1
{
    class Generated
    {
        public string Name
        {
            get;private set;
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
        public int InventoryNumber
        {
            get; private set;
        }
        public Gender Gender
        {
            get; private set;
        }
        public int PassportNumber
        {
            get; private set;
        }
        public void GenerateGender()
        {
            Random rnd = new Random();
            Gender gender;
            gender=(Gender)rnd.Next(1, 3);
            Gender = gender;
        }
        public void GenerateName()
        {
            if(Gender==0)
            {
                GenerateGender();
            }
            if(Gender==Gender.men)
            {
                Random rnd = new Random();
                string[] names = { "Сергей", "Петр", "Борис", "Владислав", "Галя" };
                Name = names[rnd.Next(0, names.Length)];
            }
            if (Gender == Gender.women)
            {
                Random rnd = new Random();
                string[] names = { "Ирина", "Марина", "Полина", "Екатерина", "Марихуана" };
                Name = names[rnd.Next(0, names.Length)];
            }

        }
        public void GenerateSurname()
        {
            if (Gender == 0)
            {
                GenerateGender();
            }
            if (Gender == Gender.men)
            {
                Random rnd = new Random();
                string[] surnames = { "Иванов", "Петров", "Борисов", "Верин", "Хренова" };
                Surname = surnames[rnd.Next(0, surnames.Length)];
            }
            if (Gender == Gender.women)
            {
                Random rnd = new Random();
                string[] surnames = { "Иванова", "Петрова", "Борисова", "Верина", "Мозгопилина" };
                Surname = surnames[rnd.Next(0, surnames.Length)];
            }
        }
        public void GenerateMiddleName()
        {
            if (Gender == 0)
            {
                GenerateGender();
            }
            if (Gender == Gender.men)
            {
                Random rnd = new Random();
                string[] middleNames = { "Иванович", "Петрович", "Сергеевич", "Юльевич", "Марленович" };
                MiddleName = middleNames[rnd.Next(0, middleNames.Length)];
            }
            if (Gender == Gender.women)
            {
                Random rnd = new Random();
                string[] middleNames = { "Андреевна", "Анатольевна", "Сергеевна", "Борисовна", "Ганибаловна" };
                MiddleName = middleNames[rnd.Next(0, middleNames.Length)];
            }
        }
    }
}
