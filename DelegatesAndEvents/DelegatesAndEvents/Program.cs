using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate int BizRulesDelegate(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {

            var custs = new List<Customer>
            {
                new Customer { City = "Phoenix", FirstName = "John", LastName = "Doe", ID = 1},
                new Customer { City = "Phoenix", FirstName = "Jane", LastName = "Doe", ID = 500},
                new Customer { City = "Seattle", FirstName = "Suki", LastName = "Pizzoro", ID = 3},
                new Customer { City = "New York City", FirstName = "Michelle", LastName = "Smith", ID = 4},
            };

            var phxCusts = custs.Where(c => c.City == "Phoenix" && c.ID < 500)
                .OrderBy(c => c.FirstName);
            foreach (var cust in phxCusts)
            {
                Console.WriteLine(cust.FirstName);
            }

            var data = new ProcessData();
            BizRulesDelegate addDel = (x, y) => x + y;
            BizRulesDelegate multiplyDel = (x, y) => x * y;
            data.Process(2, 3, addDel);
            data.Process(2, 3, multiplyDel);

            Func<int, int, int> funcAddDel = (x, y) => x + y;
            Func<int, int, int> funcMultiplyDel = (x, y) => x * y;
            data.ProcessFunc(3, 2, funcAddDel);
            data.ProcessFunc(3, 2, funcMultiplyDel);

            Action<int, int> myAction = (x, y) => Console.WriteLine(x + y);
            Action<int, int> myMultiplyAction = (x, y) => Console.WriteLine(x * y);
            data.ProcessAction(2, 3, myAction);
            data.ProcessAction(2, 3, myMultiplyAction);


            var worker = new Worker();

            worker.WorkPerformed += (s, e) =>
            {
                Console.WriteLine("Hours Worked: " + e.Hours + " " + e.WorkType);
                //Console.WriteLine("Something else.");
            };
            worker.WorkCompleted += (s,e) => Console.WriteLine("Worker is done"); 

            worker.DoWork(8,WorkType.GenerateReports);       
            Console.Read();
        }

        //private static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Worker is done");
        //}

        //private static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine("Hours Worked: " + e.Hours + " " + e.WorkType);
        //}

        //static void DoWork(WorkPerformedHandler del)
        //{
        //    del(5, WorkType.GoToMeetings);
        //}

        //static int WorkPerformed1(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed1 called " + hours.ToString());
        //    return hours + 1;
        //}

        //static int WorkPerformed2(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed2 called " + hours.ToString());
        //    return hours + 2;
        //}

        //static int WorkPerformed3(int hours, WorkType workType)
        //{
        //    Console.WriteLine("WorkPerformed3 called " + hours.ToString());
        //    return hours + 3;
        //}
    }

    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}
