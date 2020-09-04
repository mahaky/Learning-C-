using System;
using System.Collections.Generic;
namespace GradeBook{
    public class Book{
        public Book(String name){
            grades=new List<double>();
            this.name=name;
        }
        
        public void AddGrade(double grade){
    
        grades.Add(grade);
        }
        
        public Statistics ShowStatistics(){
            var result=new Statistics();
             result.Average=0.0;
             result.High=double.MinValue;
             result.Low=double.MaxValue;
            

            // high grade
          

            //foreach loop and adding the sum
            foreach(double num in grades){
               
               result.High=Math.Max(num,result.High);
                result.Low=Math.Min(num,result.Low);
                result.Average += num;
            }
            //calaculating average

            result.Average/=grades.Count;

            //formatting precision using N4 till 4 decimal precision
           return result;
        }
    private List<double> grades;
    private string name;
    }
}
