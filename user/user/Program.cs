// See https://aka.ms/new-console-template for more information
using System;
namespace oop
{
    public class User
    {
        public String id;
        public String name;
        public String avatar;
        public String job;

        public User(String id, String name, String avatar, String job)
        {
            this.id = id;
            this.name = name;
            this.avatar = avatar;
            this.job = job;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            User u = new User(
                "id1",
                "Khanh Luu Le",
                "https://elearning.vlu.edu.vn/pluginfile.php/79246/user/icon/moove/f1?rev=4667371",
                "Teacher"
                );

            User u2 = new User(
                "id2",
                "Quyen Nguyen Kim Dang",
                "https://elearning.vlu.edu.vn/theme/image.php/moove/core/1712289815/u/f1",
                "Teacher"
                );

            Console.WriteLine(u.id);
            Console.WriteLine(u.name);
            Console.WriteLine(u.avatar);
            Console.WriteLine(u.job);
            Console.WriteLine(u2.id);
            Console.WriteLine(u2.name);
            Console.WriteLine(u2.avatar);
            Console.WriteLine(u2.job);
        }
                 
    }
}
