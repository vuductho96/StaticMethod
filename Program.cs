// See https://aka.ms/new-console-template for more information

using System;
namespace Student
{
    public class Student
    {
        
        public string studentId;
        public int PhoneNumber;
        public int MonHoc;      
        public double TienMonHoc;
        public Student(string studentId, int phoneNumber,int monHoc,int tienMonHoc)
        {
            this.studentId = studentId;
            PhoneNumber = phoneNumber;
            MonHoc = monHoc;
            TienMonHoc = tienMonHoc;

        }
        public static int ThongtinStudent( int Monhoc,int TienMonhoc) 
        {
            int Total;
            return Total = Monhoc * TienMonhoc;
            
        }
        public  void Display()
        {
            Console.WriteLine("Thong tin hoc sinh la: " + studentId + " - " + PhoneNumber);
        }
   

    }
    public class Program
    {

        public static void Main(string[] args)
        {
            Student student = new Student("hgHG1", 0354256, 3, 150000);
           double total= Student.ThongtinStudent(25,100000);
          
            student.Display();
              Console.WriteLine("Tien hoc sinh phai nop la "+total);

        }



    }
}

