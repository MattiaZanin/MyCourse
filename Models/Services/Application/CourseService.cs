using System;
using System.Collections.Generic;
using MyCourse.Models.ValueObjects;
using MyCourse.Models.ViewModels;

namespace MyCourse.Models.Services.Application
{

    public class CourseService
    {
        public System.Collections.Generic.List<CourseViewModel> GetServices()
        {
           var list = new List<CourseViewModel>();
           var course = new CourseViewModel();
           course.Title = "Corso 1";
           course.Author = "Mattia Zanin";
           course.Id = 1;
           course.FullPrice = new Money(Enums.Currency.EUR, 10);
           course.CurrentPrice = new Money(Enums.Currency.EUR, 8);
           course.Rating = 4.5;
           list.Add(course);
           return list;
        }
    }



}