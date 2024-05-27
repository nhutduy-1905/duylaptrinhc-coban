// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace oop
{
    public class Course
    {
        public String id;
        public String banner;
        public String tag;
        public String name;
        public List<String> userIds = new List<String>();

        public Course(String id, String banner, String tag, String name, List<String> userIds)
        {
            this.id = id;
            this.banner = banner;
            this.tag = tag;
            this.name = name;
            this.userIds = userIds;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Course c = new Course(
               "id",
               "https://elearning.vlu.edu.vn/pluginfile.php/1/theme_moove/logo/1712289815/VLU_Logo_Final_VLU_logo%20ngang_Eng-300px.png",
               "HK2-2023-2024",
               "Anh văn chuyên ngành Dược - 232_DTA0520_01",
               new List<String>() { "userId1", "userId2" }
              );

            Course c2 = new Course(
                "id2",
                "https://elearning.vlu.edu.vn/pluginfile.php/1/theme_moove/logo/1712289815/VLU_Logo_Final_VLU_logo%20ngang_Eng-300px.png",
                "HK2-2023-2024",
                "Bào chế và Sinh dược học 1 - 232_71PHCE40253_01, 02",
                new List<String>() { "userId1", "userId2" }
                );
            Console.WriteLine(c.name);
            Console.WriteLine(c2.name);

        }

    }
}





