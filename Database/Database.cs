using System.Collections.Generic;
using System;

public class Database{
    //List ที่เก็บข้อมูลผู้ใช้ต่างๆ
    private static List<User> userList = new List<User>(); 
    private static List<User_Borrow> user_BorrowList = new List<User_Borrow>();
    private static List<User_Return> user_ReturnList = new List<User_Return>();

        public static void AddNewUser(User user) {
        userList.Add(user);
    }
        public static void AddNewUser_Borrow(User_Borrow user_Borrow) {
        user_BorrowList.Add(user_Borrow);
    }
        public static void AddNewUser_Return(User_Return user_Return) {
        user_ReturnList.Add(user_Return);
    }
        public static void RemoveUser(User_Borrow user_borrow){
            user_BorrowList.Remove(user_borrow);
        }

        public static List<User> Get_UserList(){
        return userList;
    }
        public static List<User_Borrow> Get_User_BorrowList(){
        return user_BorrowList;
    }
        public static List<User_Return> Get_User_ReturnList(){
        return user_ReturnList;
    }
    //

    //ไว้เช็คข้อมูลต่างๆของยูสเซอร์ภายในลิส
        public  void ShowData(List<User> userListx ){
        Console.Clear();
        Console.WriteLine("List User");
        Console.WriteLine("************");
        foreach(User user in userList) {
            Console.WriteLine("Name : {0}",user.Get_Name());
            Console.WriteLine("Surname : {0}",user.Get_Sur_name());
            Console.WriteLine("Phone_Number : {0}",user.Get_Phone_number());
            Console.WriteLine("Mail : {0}",user.Get_Mail());
            Console.WriteLine("Student_ID : {0}",user.Get_Student_ID());
            Console.WriteLine("Citizen_ID : {0}",user.Get_Citizen_ID());
            Console.WriteLine("Username : {0}",user.Get_Username());
            Console.WriteLine("Password : {0}",user.Get_Password());
            Console.WriteLine("************");
        }
        }

        public static  void ShowData( ){
        Console.Clear();
        Console.WriteLine("List User Borrow");
        Console.WriteLine("************");
        foreach(User_Borrow user in user_BorrowList) {
            Console.WriteLine("Name : {0}",user.Get_Name());
            Console.WriteLine("Surname : {0}",user.Get_Sur_name());
            Console.WriteLine("Phone_Number : {0}",user.Get_Phone_number());
            Console.WriteLine("Mail : {0}",user.Get_Mail());
            Console.WriteLine("Student_ID : {0}",user.Get_Student_ID());
            Console.WriteLine("Citizen_ID : {0}",user.Get_Citizen_ID());
            Console.WriteLine("Username : {0}",user.Get_Username());
            Console.WriteLine("Password : {0}",user.Get_Password());
            Console.WriteLine("Time Borrow : {0}",user.Get_Time_borrow());
            Console.WriteLine("************");
        }
        }
        public  void ShowData(List<User_Return> user_returnList ){
        Console.Clear();
        Console.WriteLine("List User Return");
        Console.WriteLine("************");
        foreach(User_Return user in user_ReturnList) {
            Console.WriteLine("Name : {0}",user.Get_Name());
            Console.WriteLine("Surname : {0}",user.Get_Sur_name());
            Console.WriteLine("Phone_Number : {0}",user.Get_Phone_number());
            Console.WriteLine("Mail : {0}",user.Get_Mail());
            Console.WriteLine("Student_ID : {0}",user.Get_Student_ID());
            Console.WriteLine("Citizen_ID : {0}",user.Get_Citizen_ID());
            Console.WriteLine("Username : {0}",user.Get_Username());
            Console.WriteLine("Password : {0}",user.Get_Password());
            Console.WriteLine("Time Return : {0}",user.Get_Time_return());
            Console.WriteLine("************");
        }
        }
    //

    //เก็บค่าตัวตนของผู้ใช้ว่าเป็นใคร
    private static string Username_Login = ("Null");
    public static void AddUsernameLogin (string username){
        Username_Login = username;
        }
    public  static string Get_Username_Login(){
        return Username_Login;
    }
    //

    // สเตตัสของจักรยาน
    private static string[] Status_BikeA = new string [16] {"Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready"};
    private static string[] Status_BikeB = new string [16] {"Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready"};
    private static string[] Status_BikeC = new string [16] {"Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready"};
    private static string[] Status_BikeD = new string [16] {"Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready","Ready"};
    
    public static string[] Set_Status_Bike(int i ,string Status,char location){
        if(location == 'A'){
            Status_BikeA[i] = Status; 
            return Status_BikeA;
        }
        else if (location == 'B'){
            Status_BikeB[i] = Status; 
            return Status_BikeB;
        }
        else if (location == 'C'){
            Status_BikeC[i] = Status; 
            return Status_BikeC;
        }
        else if (location == 'D'){
            Status_BikeD[i] = Status; 
            return Status_BikeD; 
        }
        return null;
    }
    public static string[] Get_Status_Bike(char location){
        if(location == 'A'){
            return Status_BikeA;
        }
        else if (location == 'B'){
            return Status_BikeB;
        }
        else if (location == 'C'){
            return Status_BikeC;
        }
        else if (location == 'D'){
            return Status_BikeD; 
        }
        return null;
        
    }

    //เช็ค ล็อคอิน
    public static bool check_Login(string Username, string Password){
            foreach(User user in userList) {
                if(Username == user.Get_Username() && Password == user.Get_Password()){
                    return true;
                }
            }
            return false;
    }
    //

}