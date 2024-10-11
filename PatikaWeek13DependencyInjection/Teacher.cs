namespace PatikaWeek13DependencyInjection
{
    public class Teacher : ITeacher
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }

        public string GetInfo()
        {
            return $"Öğretmen Adı : {FirstName} {LastName}";
        }
    }

    
}
