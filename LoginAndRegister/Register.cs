using System.Threading.Tasks.Dataflow;
using System.Reflection.Metadata;
using System.Threading;
using System;

enum UserType{
    Student = 1,
    Visitor
}

public class Register{

    public void ShowRegisterScreen() {
        Console.Clear();
        PrintHeaderRegisterScreen();
        InputNewUserFromKeyboard();
    }

    private User user ;
    Login menu = new Login();
    
    public void InputNewUserFromKeyboard() {

        UserType userType = InputUserTypeFromKeyboard();

        if (userType == UserType.Student){ 
            string FristName = InputFristNameFromKeyboard();
            string LastName = InputLastNameFromKeyboard();
            string PhoneNumber = InputPhoneNumberFromKeyboard();
            string Citizen_ID = InputCitizen_IDFromKeyboard();
            string Student_ID = InputStudentIDFromKeyboard();
            string Email = InputEmailFromKeyboard();
            string UserName = InputUserNameFromKeyboard();
            string Password = InputPasswordFromKeyboard();
            user = new User(FristName,LastName,PhoneNumber,Student_ID,Citizen_ID,Email,UserName,Password);
            Database.AddNewUser(user);
        }

        else if (userType == UserType.Visitor){
            string FristName = InputFristNameFromKeyboard();
            string LastName = InputLastNameFromKeyboard();
            string PhoneNumber = InputPhoneNumberFromKeyboard();
            string Citizen_ID = InputCitizen_IDFromKeyboard();
            string Email = InputEmailFromKeyboard();
            string UserName = InputUserNameFromKeyboard();
            string Password = InputPasswordFromKeyboard();
            user = new User(FristName,LastName,PhoneNumber,Citizen_ID,Email,UserName,Password);
            Database.AddNewUser(user);
        }
        menu.Menu();
    }

    private UserType InputUserTypeFromKeyboard() {
        Console.WriteLine("Input User Type 1 = Student:");
        Console.WriteLine("Input User Type 2 = Visitor: ");

        int typeNumber = int.Parse(Console.ReadLine());

        UserType userType = (UserType)(typeNumber);

        return userType;
    }




    private string InputFristNameFromKeyboard() {
        Console.Write("Input FristName: ");

        return Console.ReadLine();
    }

    private string InputLastNameFromKeyboard() {
        Console.Write("Input LastName: ");

        return Console.ReadLine();
    }
    private string InputPhoneNumberFromKeyboard() {
        Console.Write("Phone Number: ");

        return Console.ReadLine();
    }
    private string InputStudentIDFromKeyboard() {
        Console.Write("Student ID: ");

        return Console.ReadLine();
    }
    private string InputCitizen_IDFromKeyboard() {
        Console.Write("Citizen_ID: ");

        return Console.ReadLine();
    }

    private string InputEmailFromKeyboard() {
        Console.Write("Email : ");

        return Console.ReadLine();
    }
    private string InputUserNameFromKeyboard() {
        Console.Write("UserName : ");

        return Console.ReadLine();
    }
    private string InputPasswordFromKeyboard() {
        Console.Write("Password : ");

        return Console.ReadLine();
    }


    private void PrintHeaderRegisterScreen() {
        Console.WriteLine("Register for the event");
        Console.WriteLine("-------------------");
    }




}