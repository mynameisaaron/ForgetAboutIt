using ForgetAboutIt.ViewModels;
using System;
using System.Text.RegularExpressions;

namespace ForgetAboutIt.Models
{
    public class ToDo
    {
        
        public ToDo()
        {
           
        }
        

        
       

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        


        public ToDo(string description)
        {
            




            var dueDatePattern = new Regex(@"((?i)Jan|January|Feb|February|March|Mar|April|Apr|May|June|Jun|July|Jul|August|Aug|September|Sep|Sept|October|Oct|November|Nov|December|Dec)\s(\d{1,2})");
            var hasDueDate = dueDatePattern.IsMatch(description);
            if (hasDueDate)
            {
                var dueDate = dueDatePattern.Match(description);
                var day = Convert.ToInt32(dueDate.Groups[2].Value);
                var month = PrivateConvert.Months[PrivateConvert.FirstCharToUpper(dueDate.Groups[1].Value)];
            
                var _dueDate = new DateTime(DateTime.Today.Year, month, day);
                if (_dueDate <= DateTime.Today)
                   _dueDate = _dueDate.AddYears(1);

                Description = description;
                DueDate = _dueDate;
            }
            else
            {

                Description = description;
            }



            
        }
        
        
        public static ToDo  ParseTodo(ToDoViewModel viewModel)
        {
           
            return new ToDo(viewModel.Input);



            
        }

        

       
    }
}