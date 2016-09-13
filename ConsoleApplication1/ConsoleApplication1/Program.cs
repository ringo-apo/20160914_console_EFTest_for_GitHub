using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new DataContext())
            {
                string str;
                Console.WriteLine("コメントを入力してください。終了したい場合は何も入力せずにリターンキーを押してください。");
                str = Console.ReadLine();

                while (str != "")
                {
                    db.Comments.Add(new Comment { statement = str });
                    db.SaveChanges();

                    Console.WriteLine("コメントを入力してください。終了したい場合は何も入力せずにリターンキーを押してください。");
                    str = Console.ReadLine();
                }

                foreach(var i in db.Comments)
                {
                    Console.WriteLine("Id={0} Comment={1}", i.Id, i.statement);
                }

            }
            Console.ReadKey();
        }
    }
}
