
// See https://aka.ms/new-console-template for more information

using System;
namespace oop
{
    class Course
    {
        private void showId()
        {
            Console.WriteLine("id1");
        }
        private void showBanner()
        {
            Console.WriteLine("https://elearning.vlu.edu.vn/pluginfile.php/1/theme_moove/logo/1712289815/VLU_Logo_Final_VLU_logo%20ngang_Eng-300px.png");
        }
        private void showTag()
        {
            Console.WriteLine("HK2-2023-2024");
        }
        private void showName()
        {
            Console.WriteLine("Bao che va sinh hoc duoc 1 -232_71PHCE40253_01,02");
        }
        private void showUserlds()
        {
            Console.WriteLine("userId1", "userId2");
        }
        private void showId2()
        {
            Console.WriteLine("Id2");
        }
        private void showBanner2()
        {
            Console.WriteLine("https://elearning.vlu.edu.vn/pluginfile.php/1/theme_moove/logo/1712289815/VLU_Logo_Final_VLU_logo%20ngang_Eng-300px.png");
        }
        private void showTag2()
        {
            Console.WriteLine("HK2-2023-2024");
        }
        public void showUserIds2()
        {
            Console.WriteLine("userId1", "user");
        }
    }
}
namespace oop
{
    class User : Course
    {
        public void showId()
        {
            Console.WriteLine("userId1");
        }
        public void showName()
        {
            Console.WriteLine("Khanh Luu Le");
        }
        public void showAvatar()
        {
            Console.WriteLine("https://elearning.vlu.edu.vn/pluginfile.php/79246/user/icon/moove/f1?rev=4667371");
        }
        public void showJob()
        {
            Console.WriteLine("Teacher");
        }
        private void showId2()
        {
            Console.WriteLine("userId2");
        }
        private void showName2()
        {
            Console.WriteLine("Quyen Nguyen Kim Dang");
        }
        private void showAvatar2()
        {
            Console.WriteLine("https://elearning.vlu.edu.vn/theme/image.php/moove/core/1712289815/u/f1");
        }
        public void showJob2()
        {
            Console.WriteLine("Teacher");
        }
    }
}
namespace oop
{
    class Base : User
    {
        private void showCreatedAt()
        {
            Console.WriteLine("17/05/2024 17:00");
        }
        private void showCreatedBy()
        {
            Console.WriteLine("duy.@gmail.com");
        }
        public void showUpdatedAt()
        {
            Console.WriteLine("19/05/2024 20:00");
        }
        private void showUpdateBy()
        {
            Console.WriteLine("ThayA@gmail.com");
        }
    }
}
namespace oop
{
    class Program : Base
    {
        static void Main(string[] args)
        {
            Program pg = new Program();
            pg.showUserIds2();
            pg.showJob2();
            pg.showUpdatedAt();
            Console.ReadLine();

        }
    }
}