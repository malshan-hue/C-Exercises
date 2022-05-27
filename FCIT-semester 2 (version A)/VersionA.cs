using System;
class attendanceApplication {
  static void Main() {
    
    string check = "Y";
    
    while (check == "Y"){ //checking  wheather user need to perform more
      
      Console.WriteLine("Enter the subject code: ");  //prompt the user to input subject code
      string subjectCode = Console.ReadLine(); 
      
      Console.WriteLine("Enter the total number of sessions:  "); //prompt the user to input seesion count
      int sessionCount = Convert.ToInt32(Console.ReadLine()); 
      
      int i, totalAttendance = 0, totalAbsent = 0;  //declaring valriable to calculate total attendance and absent
      float attendancePercentage = 0;
      
      for (i=1; i<=sessionCount; i++){  //checking how many session one student attended  
          
          Console.WriteLine("Attendance for session No {0}: ", i);  //prompt the use to input attendance
          string Attendance = Console.ReadLine();
          
          if (Attendance == "Present"){   //if attendance is present total attendance will count
                totalAttendance += 1;
          }
          else if (Attendance == "Absent"){ //if attendance is present total absent will count
                totalAbsent += 1;   
          }
      }
      
      Console.WriteLine("\nTotal attendance for the session: {0}\n", totalAttendance);   //print total attendance
      Console.WriteLine("Total absent for the session: {0}\n", totalAbsent);   //print total absent
      
      attendancePercentage = (float)totalAttendance/sessionCount*100; //calculating attendance precentage
     
      Console.WriteLine("\nAttendance percentage: {0:F2}\n", attendancePercentage); //print attendance percentage
      
      if(attendancePercentage >= 80){
          Console.WriteLine("\nThe candidate is Eligible for sitting the exam.\n"); //print eligible if attendance percentage grater than 80
      } 
      else{
          Console.WriteLine("\nThe candidate is Not Eligible for sitting the exam.\n"); //print not eligible if attendance percentage less than 80
      }
      
      Console.WriteLine("\nDo you want to check more (Y/N): "); //prompt the user to input Y or N if they want to check more students attendance
      check = Console.ReadLine();
      
      Console.WriteLine("\n");
        
    }
    
  }
}