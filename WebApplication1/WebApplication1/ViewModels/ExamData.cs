using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class ExamData
    {
        public string Name { get ; set; }
        public string Number { get; set; }
        public string NameMessage { get; set; }
        public string NumberMessage { get; set; }
    }
}