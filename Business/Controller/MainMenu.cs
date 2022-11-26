using System;
public class MainMenu {
    private bool check;
    private static List<User> ListUser = Database.Get_UserList();//
    private static List<User_Borrow> user_BorrowList;
    static Login login = new Login();

    //ดึงสเตตัสของจักรยานออกมา
    //ยังไม่ได้แก้ข้างในฟังชั่นต่างๆนะ ยังใช้แบบโลเคชั่นเดียวอยู่
    private static string[] Status_Bike = Database.Get_Status_BikeA();
    private static string[] Status_BikeB = Database.Get_Status_BikeB();
    private static string[] Status_BikeC = Database.Get_Status_BikeC();
    private static string[] Status_BikeD = Database.Get_Status_BikeD();
    //

    //Setค่าตัวตนผู้ใช้งาน ปัจจุบัน
    private string Username_Login = Database.Get_Username_Login();
    private int check_borrow = 0; //เช็คว่าผู้ใช้เคยยืมไปรึยัง ถ้ามากกว่า 0 แสดงว่าเคยยืมไปแล้ว
    //

    public void ShowMainMenuScreen() {
        Console.Clear();
        ShowMenuScreenInformation();
    }
    private void PrintHeaderMenuScreen() {
        Console.WriteLine("=======================================");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||     BICYCLE RENTAL SYSTEM 2022    ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("=======================================");
        Console.WriteLine("--------------------------");
    }
    private void PrintListMenuScreen() {
        foreach(User user in ListUser) {
            if(Username_Login == user.Get_Username()){
        Console.WriteLine("Username : {0} | CitizenID : {0} | PhoneNumber : {0}",user.Get_Username(),user.Get_Citizen_ID(),user.Get_Phone_number());
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("||   1 - Bicycle Reservation        ||");
        Console.WriteLine("||   2 - List your Bicycle          || ");
        Console.WriteLine("||   0 - Logout                     ||");
        Console.WriteLine(" -----------------------------------");
        Console.WriteLine("");
        }}
    }

    private void ShowMenuScreenInformation() {
        PrintHeaderMenuScreen();
        PrintListMenuScreen();
        SetUserMain();
        RouteToMenu(InputSelectedMenuFromKeyboard());
    }


    private AuthenMenu InputSelectedMenuFromKeyboard() {
        Console.Write("Select Menu: ");

        return (AuthenMenu)(int.Parse)(Console.ReadLine());        
    }

    private void RouteToMenu(AuthenMenu menu) {

        if(check_borrow == 0){
            if (menu == AuthenMenu.Reservation) {
                Console.Clear();
                Reservation();
        }
            else if (menu == AuthenMenu.List) {
                Console.Clear();
                UserList();
        }  
            else if (menu == AuthenMenu.Logout) {
                Console.Clear();
                Logout();
        } 
        }
        else {
            Console.WriteLine("ไม่สามารถยืม 2 คันได้");
            if (menu == AuthenMenu.Reservation) {
                Console.Clear();
        }
            else if (menu == AuthenMenu.List) {
                Console.Clear();
                UserList();
        }  
            else if (menu == AuthenMenu.Logout) {
                Console.Clear();
                Logout();
        }
                //ShowMainMenuScreen();
        }
    }
     private void Logout() {
        Console.WriteLine("");
        Console.WriteLine("=======================================");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||         Logout Success>>>>        ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("=======================================");
        Console.WriteLine("--------------------------");
        //Environment.Exit(0);
        login.Menu();
    }
    public string check1(){
        return "menu";
    }
    private void Reservation() { //ฟังชั่นจอง

        Console.WriteLine("________________________________________________");
        Console.WriteLine("|                                               |");
        Console.WriteLine("|                VEHICLES LIST                  |");
        Console.WriteLine("|_______________________________________________|");
        Console.WriteLine(" ____________________");
        Console.WriteLine(" | ID | Status   |");
        Console.WriteLine(" |---------------|");
        Console.WriteLine(" | {0}  | {1}   |",1,Status_Bike[0]);
        Console.WriteLine(" | {0}  | {1}   |",2,Status_Bike[1]);
        Console.WriteLine(" | {0}  | {1}   |",3,Status_Bike[2]);
        Console.WriteLine(" | {0}  | {1}   |",4,Status_Bike[3]);
        Console.WriteLine(" | {0}  | {1}   |",5,Status_Bike[4]);
        Console.WriteLine(" | {0}  | {1}   |",6,Status_Bike[5]);
        Console.WriteLine(" | {0}  | {1}   |",7,Status_Bike[6]);
        Console.WriteLine(" | {0}  | {1}   |",8,Status_Bike[7]);
        Console.WriteLine(" | {0}  | {1}   |",9,Status_Bike[8]);
        Console.WriteLine(" | {0}  | {1}   |",10,Status_Bike[9]);
        Console.WriteLine(" | {0}  | {1}   |",11,Status_Bike[10]);
        Console.WriteLine(" | {0}  | {1}   |",12,Status_Bike[11]);
        Console.WriteLine(" | {0}  | {1}   |",13,Status_Bike[12]);
        Console.WriteLine(" | {0}  | {1}   |",14,Status_Bike[13]);
        Console.WriteLine(" | {0}  | {1}   |",15,Status_Bike[14]);
        Console.WriteLine(" | {0}  | {1}   |",16,Status_Bike[15]);
        Console.WriteLine(" |_______________|");
        Console.WriteLine("");
        Console.WriteLine("Input ID to Reservation or Input [0] Back to Main Menu ");
        Console.WriteLine("Select Menu: ");

        int input = int.Parse(Console.ReadLine());//คืออันดับที่ยืม
            
            if(input >= 1 && input <= 16){
                input--;
                if(Status_Bike[input] == "Ready"){
                    Console.WriteLine("Reservated!!!");

                    Database.Set_Status_BikeA(input,"Active");
                    foreach(User user in ListUser) {
                        if(Username_Login == user.Get_Username()){
                            double time = 0;// อย่าลืมใส่ จักรยานที่ยืมไป แล้วก็ค่าการเข้าโปรแกรม //โลเคชั่น // เพิ่มค่าอันดับตัวตนของผู้ใช้
                            check_borrow++;
                            User_Borrow user_borrow = new User_Borrow(user.Get_Name(),user.Get_Sur_name(),user.Get_Phone_number(),user.Get_Student_ID(),user.Get_Citizen_ID(),user.Get_Mail(),user.Get_Username(),user.Get_Password(),time,input,check_borrow);
                            Database.AddNewUser_Borrow(user_borrow);
                            break;}
                    }
                }
                else if(Status_Bike[input] == "Active"){
                    Reservation();
                }
                Console.WriteLine("Input [1] Back to Main Menu or Input [0] to Logout");
                string input2 = Console.ReadLine();
                if(input2 == "0"){
                    Logout();
                }
                else if(input2 == "1"){
                    ShowMainMenuScreen();
                }
            }
            else if(input == 0){
                ShowMainMenuScreen();
            }
        Console.WriteLine("");
    }

    private void UserList() { //ฟังชั่นคืน
        double sumprice = Sumprice(); // คำนวณเงินที่ต้องจ่าย
        sumprice = 9999;
        user_BorrowList = Database.Get_User_BorrowList();
        foreach(User_Borrow user_borrow in user_BorrowList) {
            if(Username_Login == user_borrow.Get_Username()){
                Console.WriteLine("");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|               My Bicycle List                 |");
                Console.WriteLine("|_______________________________________________|");
                Console.WriteLine("________________________________________________");
                Console.WriteLine(" | ID |    Date    | Status | Charge |");
                Console.WriteLine(" |-----------------------------------------------");
                Console.WriteLine(" | {0}  |     {1}    |    {2}   | {3} Bath|",user_borrow.Get_Index_borrow()+1,user_borrow.Get_Time_borrow(),Status_Bike[user_borrow.Get_Index_borrow()],sumprice);
                Console.WriteLine(" |______________________________________________|");
                Console.WriteLine("");

        Console.WriteLine("Input [1] to Pay Service Charge or Input [0] Back to Main Menu ");
        Console.WriteLine("Select Menu: ");
        string input = Console.ReadLine();
            
            if(input == "1"){
            Console.WriteLine("input money to pay :");
            double inputmoney = double.Parse(Console.ReadLine());
                if(inputmoney == sumprice){
                    Database.Set_Status_BikeA(user_borrow.Get_Index_borrow() ,"Ready" );
                    Database.RemoveUser(user_borrow);
                    //check_borrow--;
                    Console.WriteLine("Compls");
                }
                Console.WriteLine("Input [1] Back to Main Menu or Input [0] to Logout");
                string input2 = Console.ReadLine();
                
                if(input2 == "0"){
                    Logout();
                }
                else if(input2 == "1"){
                    ShowMainMenuScreen();
                }

            }
            else if(input == "0"){
                ShowMainMenuScreen();
            }
            else{
                UserList();
            }
        }
        }
        ShowMainMenuScreen();
    }   
    private double Sumprice(){//ฟังชั่นคำนวณเงินที่ต้องจ่าย
        return  0 ;
        //ไว้คำนวณแล้วมันรีเทินเป็น เงินออกมาก
    }
    private void SetUserMain(){ //ยังไม่ได้เช็คว่าทำงานได้มั้ย มันคือการ Setค่าว่าเคยยืมไปรึยังจะได้แสดงเมนูได้ถูกต้อง วิธีเช็คคือ ให้ผู้ใช้คนแรก ยืมแล้วออกระบบ แล้วผู้ใช้คนที่สองล็อคอินเข้ามาดูว่า ยืมได้มั้ย
        user_BorrowList = Database.Get_User_BorrowList();
        foreach(User_Borrow user_borrow in user_BorrowList) {
            if(Username_Login == user_borrow.Get_Username()){
                this.check_borrow = user_borrow.Get_Check_borrow();
            }
        }
    }
}