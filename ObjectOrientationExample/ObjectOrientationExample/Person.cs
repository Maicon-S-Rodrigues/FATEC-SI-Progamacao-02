namespace ObjectOrientationExample
{
    public class Person
    {
        public Person(
            string name,
            char sex,
            int age
        )
        {
            Name = name;
            Sex = sex;
            Age = age;
        }

        public Person()
        {
            Name = "Sem nome";
            Sex = ' ';
            Age = 0;
        }

        public string Name;
        public char Sex;
        public int Age;

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetSex(char sex)
        {
            Sex = sex;
        }

        public char GetSex()
        {
            return Sex;
        }

        public override string ToString()
        {
            return $"\nDados da pessoa: " +
                   $"\nNome: {Name}" +
                   $"\nIdade: {Age}" +
                   $"\nSexo: {Sex}" + "\n";
        }
    }
}