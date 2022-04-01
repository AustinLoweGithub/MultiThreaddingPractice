using System.Threading;


        Thread mainThread = Thread.CurrentThread;

Thread threadOne = new Thread(() => CountDown("Timer One"));
Thread threadTwo = new Thread(() => CountUp("Timer Two"));

threadOne.Start();
threadTwo.Start();

        mainThread.Name = "Main Thread";

        //Console.WriteLine(mainThread.Name);


        Console.ReadKey();
    

    static void CountDown(String name)
    {

        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"{name} : " + i + " seconds");
            Thread.Sleep(1000);

        }
        Console.WriteLine($"{name} is complete.");
    }

    static void CountUp(String name)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{name} : " + i + " seconds");
            Thread.Sleep(1000);

        }
        Console.WriteLine($"{name} is complete.");

    }

