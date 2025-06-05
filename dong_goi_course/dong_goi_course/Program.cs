// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.InteropServices;
using System.Text;
namespace oop
{
    class Course
    {
        private String id;
        private String banner;
        private String tag;
        private String name;
        private List<String> UserId = new List<String>() { "userId1", "userId2" };
        public Course(String newId, String newBanner, String newTag, String newName, List<String> newUserId)
        {
            id = newId;
            banner = newBanner;
            tag = newTag;
            name = newName;
            UserId = newUserId;
        }
        public String getCourseInfo() { return id + "," + banner + "," + tag + "," + name; }

        public void setName(String courseName)
        {
            name = courseName;
        }
        public void setTag(String tagCourse)
        {
            tag = tagCourse;
        }
    }
    class User
    {
        private String id;
        private String name;
        private String avatar;
        private String job;
        public User(String newId, String newName, String newAvatar, String newJob)
        {
            id = newId;
            name = newName;
            avatar = newAvatar;
            job = newJob;
        }
        public String getUserName() { return name; }
        public String getUserInfo() { return id + "," + name + "," + avatar + "," + job; }

        public void setUserName(String newUserName)
        {
            name = newUserName;
        }
        public void setJob(String newJob)
        {
            job = newJob;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course("id1",
                "https://elearning.vlu.edu.vn/pluginfile.php/1/theme_moove/logo/1712289815/VLU_Logo_Final_VLU_logo%20ngang_Eng-300px.png",
                "HK2-2023-2024",
                "Anh văn chuyên ngành Dược - 232_DTA0520_01",
                new List<String>() { "userId1", "userId2" }
                );
            Course c2 = new Course("id2",
                "https://elearning.vlu.edu.vn/pluginfile.php/1/theme_moove/logo/1712289815/VLU_Logo_Final_VLU_logo%20ngang_Eng-300px.png",
                "HK2-2023-2024",
                "Bào chế và Sinh dược học 1 - 232_71PHCE40253_01, 02",
                new List<string>() { "userId1", "userId2" }
                );
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine(c.name);
            // Console.WriteLine(c2.name);
            Console.WriteLine(c.getCourseInfo());
            c.setName("Công nghệ thông tin");
            c.setTag("HK3-2023-2024");
            Console.WriteLine(c.getCourseInfo());
            User u = new User(
                "userId1",
                "Khanh Luu Le",
                "https://elearning.vlu.edu.vn/pluginfile.php/79246/user/icon/moove/f1?rev=4667371",
                "Teacher"
                );
            User u2 = new User("userId2",
                "Quyen Nguyen Kim Dang",
                "https://elearning.vlu.edu.vn/theme/image.php/moove/core/1712289815/u/f1",
                "Teacher"
                );
            //Console.WriteLine(u.id);
            // Console.WriteLine(u.name);
            // Console.WriteLine(u.avatar);
            // Console.WriteLine(u.job);
            // Console.WriteLine(u2.id);
            //  Console.WriteLine(u2.name);
            //  Console.WriteLine(u2.avatar);
            //  Console.WriteLine(u2.job);
            //Console.WriteLine(u.getUserName());
            //Console.WriteLine(u.getUserInfo());
            //u.setUserName("Phan Hoang Nguyen");
           // u.setJob("Student"); // Thay đoi thong tin
          
           // Console.WriteLine(u.getUserInfo());

        }
    }
}

