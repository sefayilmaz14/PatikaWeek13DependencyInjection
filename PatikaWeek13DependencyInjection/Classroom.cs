using Microsoft.AspNetCore.SignalR;

namespace PatikaWeek13DependencyInjection
{
    public class Classroom
    {
        private readonly Teacher _teacher;

        public Classroom(Teacher teacher)
        {
            _teacher = teacher;
        }

        public void GetTeacherInfo()
        {
        _teacher.GetInfo();
        }

    }
}
