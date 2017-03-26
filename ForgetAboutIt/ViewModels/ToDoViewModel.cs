using ForgetAboutIt.Models;
using System.Collections.Generic;

namespace ForgetAboutIt.ViewModels
{
    public class ToDoViewModel
    {
        public string Input { get; set; }
        public IEnumerable<ToDo> ToDoList { get; set; }
    }
}