using System;
public class User_Borrow :User{
    private double time_borrow ;
    private int index_borrow;
    private char location_borrow;
    private int check_borrow;

    public User_Borrow(string name,string sur_name,string phone_number,string student_ID,string citizen_ID,string mail,string username,string password,double time_borrow,int index_borrow,int check_borrow)//,char location_borrow
    :base(name,sur_name,phone_number,student_ID,citizen_ID,mail,username,password){
        this.time_borrow = time_borrow;
        this.index_borrow = index_borrow;
        this.check_borrow = check_borrow;
        //this.Location_borrow = location_borrow;
    }
        public User_Borrow(string name,string sur_name,string phone_number,string citizen_ID,string mail,string username,string password,double time_borrow)
    :base(name,sur_name,phone_number,citizen_ID,mail,username,password){
        this.time_borrow = time_borrow;
        this.index_borrow = index_borrow;
    }

    public double Get_Time_borrow(){
       return this.time_borrow;
    }
    public int Get_Index_borrow(){
        return this.index_borrow;
    }
    public int Get_Check_borrow(){
        return this.check_borrow;
    }

}