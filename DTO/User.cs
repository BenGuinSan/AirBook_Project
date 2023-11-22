using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        protected string User_ID { get; set; }
        public string getUser_ID() { return User_ID; }
        public void setUser_ID(string user_ID) {  User_ID = user_ID; }

        protected string Role_ID { get; set; }
        public string getRole_ID() { return Role_ID; }
        public void setRole_ID(string role_ID) { Role_ID = role_ID; }

        protected string Username { get; set; }
        public string getUsername() {  return Username; }
        public void setUsername(string username) { Username = username; }

        protected string Pwd { get; set; }
        public string getPwd() { return Pwd; }
        public void setPwd(string pwd) { Pwd = pwd; }

        protected string Real_name { get; set; }
        public string getReal_name() {  return Real_name; }
        public void setReal_name(string real_name) {  Real_name = real_name; }

        protected DateTime DoB { get; set; }
        public DateTime getDoB() { return DoB; }
        public void setDoB(DateTime doB) {  DoB = doB; }

        protected string Gender { get; set; }
        public string getGender() { return Gender; }
        public void setGender(string gender) {  Gender = gender; }

        protected string Nation { get; set; }
        public string getNation() { return Nation; }
        public void setNation(string nation) {  Nation = nation; }

        protected string User_address { get; set; }
        public string getUser_address() { return User_address; }
        public void setUser_address(string user_address) {  User_address = user_address; }

        protected string Phone_number { get; set; }
        public string getPhone_number() {  return Phone_number; }
        public void setPhone_number(string phone_number) {  Phone_number = phone_number; }

        protected string CCCD { get; set; }
        public string getCCCD() {  return CCCD; }
        public void setCCCD(string CCCD) { this.CCCD = CCCD; }

        protected string Email { get; set; }
        public string getEmail() { return Email; }
        public void setEmail(string email) { Email = email; }

        protected DateTime Date_create { get; set; }
        public DateTime getDate_create() { return Date_create; }
        public void setDate_create(DateTime dateTime) { Date_create = dateTime; }

        protected int IsDelete { get; set; }
        public int getIsDelete() {  return IsDelete; }
        public void setIsDelete() {  this.IsDelete = IsDelete; }

        public User() { }
        public User(string user_ID, string role_ID, string username, string pwd, string real_name, DateTime doB, string gender, string nation, string user_address, string phone_number, string CCCD, string email, DateTime date_create, int isDelete)
        {
            User_ID = user_ID;
            Role_ID = role_ID;
            Username = username;
            Pwd = pwd;
            Real_name = real_name;
            DoB = doB;
            Gender = gender;
            Nation = nation;
            User_address = user_address;
            Phone_number = phone_number;
            this.CCCD = CCCD;
            Email = email;
            Date_create = date_create;
            IsDelete = isDelete;
        }
        public User(string email, string pwd)
        { 
            this.Email = email;
            this.Pwd = pwd;
        }
    }
}
