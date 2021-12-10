namespace UserModule
{
    public class User {
        public string name = "";
        public int age = 0;
    
        public User(string name, int age) {
            this.name = name;
            this.age = age;
        }

        public void Greet() {
            Console.WriteLine("Hi. My name is " + name + " and my age is " + age);
        }
    }
}
