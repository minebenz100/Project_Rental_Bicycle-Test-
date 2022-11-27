using System;
public class MainMenu {
    private bool check;
    private static List<User> ListUser = Database.Get_UserList();//
    private static List<User_Borrow> user_BorrowList;
    static Login login = new Login();


    //Setค่าตัวตนผู้ใช้งาน ปัจจุบัน
    private string Username_Login = Database.Get_Username_Login();
    private int check_borrow = 0; //เช็คว่าผู้ใช้เคยยืมไปรึยัง ถ้ามากกว่า 0 แสดงว่าเคยยืมไปแล้ว
    //

    public void ShowMainMenuScreen() {
        Console.Clear();
        SetUserMain();
        ShowMenuScreenInformation();
    }
    private void PrintHeaderMenuScreen() {
        Console.WriteLine("=======================================");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("||     BICYCLE RENTAL SYSTEM 2022    ||");
        Console.WriteLine("||                                   ||");
        Console.WriteLine("=======================================");
        Console.WriteLine("---------------------------------------");
    }
    private void PrintListMenuScreen() {
        foreach(User user in ListUser) {
            if(Username_Login == user.Get_Username()){
        Console.WriteLine("=======================================");
        Console.WriteLine("|| Date : {0} | Time :{1} ||",DateTimes.GetDate(),DateTimes.GetTime());
        Console.WriteLine("=======================================");
        Console.WriteLine("Username : {0} | CitizenID : {1} | Phon_number : {2}",user.Get_Username(),user.Get_Citizen_ID(),user.Get_Phone_number());
        Console.WriteLine("------------------------------------");
        Console.WriteLine("||   1 - Bicycle Reservation        ||");
        Console.WriteLine("||   2 - List your Bicycle          || ");
        Console.WriteLine("||   0 - Logout                     ||");
        Console.WriteLine(" -----------------------------------");
        Console.WriteLine("");
        }}
    }

    private void ShowMenuScreenInformation() {
        Console.Clear();
        PrintHeaderMenuScreen();
        PrintListMenuScreen();
        RouteToMenu(InputSelectedMenuFromKeyboard());
    }

    private AuthenMenu InputSelectedMenuFromKeyboard() {
        Console.Write("Select Menu: ");
        bool Check_Select;
        Check_Select = int.TryParse(Console.ReadLine(),out int input);
        if(!Check_Select){
            ShowMenuScreenInformation();
        }
        return (AuthenMenu)input;        
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
        else{
            ShowMenuScreenInformation();
        }
        }
        else {
            //Console.WriteLine("ไม่สามารถยืม 2 คันได้");
            if (menu == AuthenMenu.Reservation) {
                Console.Clear();
                ShowMenuScreenInformation();
        }
            else if (menu == AuthenMenu.List) {
                Console.Clear();
                UserList();
        }  
            else if (menu == AuthenMenu.Logout) {
                Console.Clear();
                Logout();
        }
        else{
            ShowMenuScreenInformation();
        }
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
    private void Show_location_Status(string[] Status_Bike,char location){//โชว์การจอง
        Console.WriteLine("________________________________________________");
        Console.WriteLine("|                                               |");
        Console.WriteLine("|                VEHICLES LIST                  |");
        Console.WriteLine("|_______________________________________________|");
        Console.WriteLine("         ___________________________");
        Console.WriteLine("         | ID  | Status | Location |");
        Console.WriteLine("         |-------------------------|");
        Console.WriteLine("         |  {0}  | {1}  |     {2}    |",1,Status_Bike[0],location);
        Console.WriteLine("         |  {0}  | {1}  |     {2}    |",2,Status_Bike[1],location);
        Console.WriteLine("         |  {0}  | {1}  |     {2}    |",3,Status_Bike[2],location);
        Console.WriteLine("         |  {0}  | {1}  |     {2}    |",4,Status_Bike[3],location);
        Console.WriteLine("         |  {0}  | {1}  |     {2}    |",5,Status_Bike[4],location);
        Console.WriteLine("         |  {0}  | {1}  |     {2}    |",6,Status_Bike[5],location);
        Console.WriteLine("         |  {0}  | {1}  |     {2}    |",7,Status_Bike[6],location);
        Console.WriteLine("         |  {0}  | {1}  |     {2}    |",8,Status_Bike[7],location);
        Console.WriteLine("         |  {0}  | {1}  |     {2}    |",9,Status_Bike[8],location);
        Console.WriteLine("         |  {0} | {1}  |     {2}    |",10,Status_Bike[9],location);
        Console.WriteLine("         |  {0} | {1}  |     {2}    |",11,Status_Bike[10],location);
        Console.WriteLine("         |  {0} | {1}  |     {2}    |",12,Status_Bike[11],location);
        Console.WriteLine("         |  {0} | {1}  |     {2}    |",13,Status_Bike[12],location);
        Console.WriteLine("         |  {0} | {1}  |     {2}    |",14,Status_Bike[13],location);
        Console.WriteLine("         |  {0} | {1}  |     {2}    |",15,Status_Bike[14],location);
        Console.WriteLine("         |  {0} | {1}  |     {2}    |",16,Status_Bike[15],location);
        Console.WriteLine("         |_________________________|");
        Console.WriteLine("");

        Console.WriteLine("Input ID to Reservation [ 1-16 ]or Input [0] Back to Main Menu ");
        Console.Write("Select Menu: ");
            bool check_Input;
            check_Input = int.TryParse(Console.ReadLine(),out int input);//คืออันดับที่ยืม
            if(!check_Input){
                Reservation();
            }
            
            if(input >= 1 && input <= 16){
                input--;
                if(Status_Bike[input] == "Ready"){
                    Console.WriteLine("----Successfully Reservated----");

                    Database.Set_Status_Bike(input,"Active",location);
                    foreach(User user in ListUser) {
                        if(Username_Login == user.Get_Username()){
                            double time = DateTimes.GetTimetoDouble();// อย่าลืมใส่ จักรยานที่ยืมไป แล้วก็ค่าการเข้าโปรแกรม //โลเคชั่น // เพิ่มค่าอันดับตัวตนของผู้ใช้
                            check_borrow++;
                            User_Borrow user_borrow = new User_Borrow(user.Get_Name(),user.Get_Sur_name(),user.Get_Phone_number(),user.Get_Student_ID(),user.Get_Citizen_ID(),user.Get_Mail(),user.Get_Username(),user.Get_Password(),time,input,check_borrow,location);
                            Database.AddNewUser_Borrow(user_borrow);
                            break;}
                    }
                }
                else if(Status_Bike[input] == "Active"){
                    Reservation();
                }
                InputBackToMenuOrLogout();
            }
            else{
                Reservation();
            }
        Console.WriteLine("");
    }
    private void InputBackToMenuOrLogout(){
        Console.WriteLine("Input [1] Back to Main Menu or Input [0] to Logout");
        Console.Write("Select Menu: ");
                string input2 = Console.ReadLine();
                if(input2 == "0"){
                    Logout();
                }
                else if(input2 == "1"){
                    ShowMainMenuScreen();
                }
                else{
                    InputBackToMenuOrLogout();
                }
    }
    private void Reservation() { //ฟังชั่นจอง แยกโลเคชัั่นทำให้มันเยอะ
        Console.Clear();
        Console.WriteLine("Input Location : {A,B,C,D}");
        bool check_input;
        check_input = char.TryParse(Console.ReadLine(),out char input_location);
        if(!check_input){
            Reservation();
        }
        if(input_location == 'A' || input_location == 'B'|| input_location == 'C' || input_location == 'D'){
            Show_location_Status(Database.Get_Status_Bike(input_location),input_location);
        }
        else{
            Reservation();
        }
    }

    private string Select_Location_Status(char location,int i){//เลือก สเตตัสของโลเคชั่นต่างๆ และอินเด็กให้ถูกต้อง
        string[] Status_Bike = Database.Get_Status_Bike(location);
        return Status_Bike[i];
    }
    private void UserList() { //ฟังชั่นคืน
        Console.Clear();
        user_BorrowList = Database.Get_User_BorrowList();
        foreach(User_Borrow user_borrow in user_BorrowList) {
            double time_now = DateTimes.GetTimetoDouble();
            double sumprice = Sumprice(user_borrow.Get_Time_borrow());
            if(Username_Login == user_borrow.Get_Username()){
                Console.WriteLine("");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("|                                               |");
                Console.WriteLine("|               My Bicycle List                 |");
                Console.WriteLine("|_______________________________________________|");
                Console.WriteLine("________________________________________________");
                Console.WriteLine("|||||||||||||||| Time : {0} ||||||||||||||||||",time_now);
                Console.WriteLine("________________________________________________");
                Console.WriteLine(" | ID | Location |   Time    | Status | Charge |");
                Console.WriteLine(" |-----------------------------------------------");
                Console.WriteLine(" | {0} |   {1}     |   {2}    | {3} | {4} Bath |",user_borrow.Get_Index_borrow()+1,user_borrow.Get_Location_borrow(),user_borrow.Get_Time_borrow(),Select_Location_Status(user_borrow.Get_Location_borrow(),user_borrow.Get_Index_borrow()),sumprice);
                Console.WriteLine(" |______________________________________________|");
                Console.WriteLine("");

        Console.WriteLine("Input [1] to Pay Service Charge or Input [0] Back to Main Menu ");
        Console.Write("Select Menu: ");
        string input = Console.ReadLine();
            
            if(input == "1"){
            Console.Write("Input money to pay :");
            bool check_Input;
            check_Input = double.TryParse(Console.ReadLine(),out double inputmoney);//คืออันดับที่ยืม
            if(!check_Input){
                UserList();
            }
            //double inputmoney = double.Parse(Console.ReadLine());
                if(inputmoney == sumprice){
                    Database.Set_Status_Bike(user_borrow.Get_Index_borrow() ,"Ready",user_borrow.Get_Location_borrow());
                    Database.RemoveUser(user_borrow);
                    check_borrow--;
                    Console.WriteLine("");
                    Console.WriteLine("----Successfully Return----");
                    Console.WriteLine("");
                    //เรียกใช้ใส่รูปมาตรงนี้ 
                    //user_borrow.Get_Name(),user_borrow.Get_Sur_name(),user_borrow.Get_Student_ID(),user_borrow.Get_Location_borrow(),user_borrow.Get_Index_borrow(),user_borrow.Get_Time_borrow(),time_now(),sumprice;
                }
                else{
                    Console.WriteLine("----Incorrect Money Input----");
                }
                InputBackToMenuOrLogout();

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
    private double Sumprice(double time_borrow){//ฟังชั่นคำนวณเงินที่ต้องจ่าย
        double time_Return =  DateTimes.GetTimetoDouble();
        double SumPrice = Math.Ceiling(time_Return - time_borrow) * 15 ;
        return  SumPrice;
    }
        private void SetUserMain(){ // มันคือการ Setค่าว่าเคยยืมไปรึยังจะได้แสดงเมนูได้ถูกต้อง
        user_BorrowList = Database.Get_User_BorrowList();
        foreach(User_Borrow user_borrow in user_BorrowList) {
            if(Username_Login == user_borrow.Get_Username()){
                this.check_borrow = user_borrow.Get_Check_borrow();
            }
        }
    }
}