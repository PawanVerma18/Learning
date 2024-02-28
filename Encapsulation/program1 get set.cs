namespace AccessSpecifiers1
{
    public class Properties
    {
        private string _name;
        private int _age;

        public string Name
        {
            set
            {
                this._name = value;
            }
            get
            {
                return this._name;
            }  
        }

        //public int Age
        //{
        //    set
        //    {
        //        this._age = value;
        //    }
        //    get
        //    {
        //        return this._age;
        //    }
        //}
       public static void Main(string[] args)
        {

            Properties s = new Properties();
            s.Name = "Pawan";
            //s.Age = 21;

            Console.WriteLine("Name is:"+s.Name);
            //Console.WriteLine("Age is:" + s.Age);

        }
    }
    
}
