﻿using System;

namespace ConsoleApp13
{
    public class Person
    {
       public DateTime Birthdate { get; set; }
       

       public int Age
       {
           get
           {
               var timeSpan = DateTime.Today - Birthdate;
               var years = timeSpan.Days / 365;
               return years;
           }
       }
            
        
    }
}