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
    class GeneratedPerson
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
        public void GenerateAge()
        {
            const int MAX_AGE = 110;
            const int MIN_AGE = 18;
            Random rnd = new Random();
            Age=rnd.Next(MIN_AGE, MAX_AGE);
        }
        /// <summary>
        /// Генерирует семизначный номер
        /// </summary>
        /// <param name="Лист сгенерированных номеров"></param>
        public void GeneratePassportNumber(List<Human> availableHumans)
        {
            const int MAX_PASSPORT_NUMBER = 10000000;
            const int MIN_PASSPORT_NIMBER = 1000000;
            Random rnd = new Random();
            bool passportExists = false;
            do
            {
                PassportNumber = rnd.Next(MIN_PASSPORT_NIMBER, MAX_PASSPORT_NUMBER);
                passportExists = false;
                foreach (Human nextHuman in availableHumans)
                {
                    if (nextHuman.PassportNumber== PassportNumber)
                    {
                        passportExists = true;
                    }
                }
            }
            while (passportExists);
        }
        public void GenerateAllParametrsPerson(List<Human> availableHumans)
        {
            GenerateGender();
            GenerateName();
            GenerateSurname();
            GenerateMiddleName();
            GeneratePassportNumber(availableHumans);
            GenerateAge();
        }
        public void AddGeneratedPersonWithParametrs(List<Human> availableHumans)
        {
            GenerateAllParametrsPerson(availableHumans);
            Human human = new Human(Name,Surname,MiddleName,PassportNumber,Age);
            availableHumans.Add(human);
        }
    }
}
