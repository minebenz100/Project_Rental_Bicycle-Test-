
using System;
public class User{
    private string name;
    private string sur_name;
    private string phone_number;
    private string mail;
    private string student_ID;
    private string citizen_ID ;
    private string username ;
    private string password ;


    public User (string name,string sur_name,string phone_number,string student_ID,string citizen_ID,string mail,string username,string password){
        this.name = name;
        this.sur_name = sur_name;
        this.phone_number = phone_number;
        this.mail = mail;
        this.student_ID = student_ID;
        this.citizen_ID = citizen_ID;
        this.username = username;
        this.password = password;
    }
        public User (string name,string sur_name,string phone_number,string citizen_ID,string mail,string username,string password){
        this.name = name;
        this.sur_name = sur_name;
        this.phone_number = phone_number;
        this.mail = mail;
        this.student_ID = student_ID;
        this.citizen_ID = citizen_ID;
        this.username = username;
        this.password = password;
    }
    public string Get_Name (){
        return this.name;
    }
    public string Get_Sur_name (){
        return this.sur_name;
    }
    public string Get_Phone_number (){
        return this.phone_number;
    }
    public string Get_Mail (){
        return this.mail;
    }
    public string Get_Student_ID (){
        return this.student_ID;
    }
    public string Get_Citizen_ID (){
        return this.citizen_ID;
    }
    public string Get_Username (){
        return this.username;
    }
    public string Get_Password (){
        return this.password;
    }

}