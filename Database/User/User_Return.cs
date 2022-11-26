using System;
public class User_Return : User{
    private double time_return  ;
    public User_Return(string name,string sur_name,string phone_number,string student_ID,string citizen_ID,string mail,string username,string password,double time_return)
    :base(name,sur_name,phone_number,student_ID,citizen_ID,mail,username,password){
        this.time_return = time_return;
    }
        public User_Return(string name,string sur_name,string phone_number,string citizen_ID,string mail,string username,string password,double time_return)
    :base(name,sur_name,phone_number,citizen_ID,mail,username,password){
        this.time_return = time_return;
    }
    public double Get_Time_return(){
       return this.time_return;
    }
}