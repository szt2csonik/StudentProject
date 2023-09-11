using CommunityToolkit.Mvvm.ComponentModel;
using StudentProjekt.Models;
using System.Collections.Generic;

namespace StudentProjekt.ViewModel
{
    public partial class StudentViewModel : ObservableObject
    {
        private List<string> _educationLevel = new EducationLevels().AllEducationLevel;
        [ObservableProperty]
        private Student student;

        [ObservableProperty]
        private string selectedEducationLevel;

        [ObservableProperty]
        private List<string> educationLevels;


        public StudentViewModel()
        {
            student = new Student();
            SelectedEducationLevel = string.Empty;
            EducationLevels = _educationLevel;
        }
    }
}