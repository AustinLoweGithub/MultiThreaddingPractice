using System.Threading;


        Thread mainThread = Thread.CurrentThread;

Thread threadOne = new Thread(() => CountDown("TimerOne"));
Thread threadTwo = new Thread(() => CountUp("TimerTwo"));

threadOne.Start();
threadTwo.Start();

        mainThread.Name = "Main Thread";

        //Console.WriteLine(mainThread.Name);


        Console.ReadKey();
    

    static void CountDown(String name)
    {

        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine("Timer #1 : " + i + " seconds");
            Thread.Sleep(1000);

        }
        Console.WriteLine("Timer #1 is complete.");
    }

    static void CountUp(String name)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Timer #2 : " + i + " seconds");
            Thread.Sleep(1000);

        }
        Console.WriteLine("Timer #2 is complete.");

    }

