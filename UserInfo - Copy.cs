using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationWithDisConnnected
{
    public class UserInfo
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public UserInfo()
        {

        }
        public UserInfo(string FirstName, string LastName, string EmailId, string Password, string ImageUrl)
        {
            this.FName = FirstName;
            this.LName = LastName;
            this.EmailId = EmailId;
            this.Password = Password;
            this.Image = ImageUrl;
        }
        public UserInfo(string Email)
        {
            this.EmailId = Email;
        }
    }
}