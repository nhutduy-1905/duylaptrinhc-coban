// See https://aka.ms/new-console-template for more information

using System.Text;
namespace oop
{
    class Base
    {
        public String createdAt;
        public String createdBy;
        public String updatedAt;
        public String updatedBy;           
    }

    class User : Base
    {
        private String id;
        private String name;
        private String avatar;
        private String job;
        public User(String newId, String newName, String newAvatar, String newJob, String newCreatedAt, String newCreatedBy, String newUpdatedAt, String newUpdatedBy)
        {
            id = newId;
            name = newName;
            avatar = newAvatar;
            job = newJob;
            createdAt = newCreatedAt;
            createdBy = newCreatedBy;
            updatedAt = newUpdatedAt;
            updatedBy = newUpdatedBy;

        }
        public String getUserName() { return name; }
        public String getUserInfo() { return id + "," + name + "," + avatar + "," + job + "," + createdAt +"," + createdBy + "," + updatedAt +"," + updatedBy; }

        public void setUserName(String newUserName)
        {
            name = newUserName;
        }
        public void setJob(String newJob)
        {
            job = newJob;
        }
        class Program
        {
            static void Main(string[] args)
            {

                User u = new User(
                    "userId1",
                    "Khanh Luu Le",
                    "https://elearning.vlu.edu.vn/pluginfile.php/79246/user/icon/moove/f1?rev=4667371",
                    "Teacher",
                    "10/05/2024 12:00",
                    "oai@gmail.com",
                    "12/05/2024 19:40",
                    "thayA@gmail.com"
                    );
                Console.WriteLine(u.getUserInfo());
                //User u2 = new User("userId2",
                //  "Quyen Nguyen Kim Dang",
                //  "https://elearning.vlu.edu.vn/theme/image.php/moove/core/1712289815/u/f1",
                // "Teacher"
                // );
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

                User u2 = new User("Id2",
                    "minh",
                    "http",
                    "Teacher2",
                    "20/05/2024 12:00",
                    "minh@gmail.com",
                    "21/05/2024 7:00",
                    "thayb@gmail.com");
                Console.WriteLine(u2.getUserInfo());
                u2.setUserName("minh2");
                Console.WriteLine(u2.name);

            }

        }
    }
}

