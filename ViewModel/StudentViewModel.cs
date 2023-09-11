using CommunityToolkit.Mvvm.ComponentModel;
using StudentProjekt.Models;

namespace StudentProjekt.ViewModel
{
    public partial class StudentViewModel : ObservableObject
    {
        [ObservableProperty]
        private Student student;


        public StudentViewModel()
        {
            student = new Student();
        }
    }
}