class Program
{

    public static void Main(String[] args)
    {      
        
        Console.WriteLine("Hej og velkommen");
        Console.WriteLine("Vælg en af de nederstående muligheder \n");

        //Menu options
        Console.WriteLine("Mulighed 1 \n" + "Mulighed 2 \n" + "Mulighed 3 \n" + "Mulighed 4 \n");
        //Console.WriteLine("Mulighed 2");
        //Console.WriteLine("Mulighed 3");
        //Console.WriteLine("Mulighed 4");

        Console.WriteLine("Hvad vil du vælge: ");

        int res = Convert.ToInt32(Console.ReadLine());

        switch (res)
	    {
            case 1:
               Console.WriteLine("Hej, Mulighed 1");
                break;
            case 2:
                Console.WriteLine("Hej, Mulighed 2");
                break;
            case 3:
                Console.WriteLine("Hej, Mulighed 3");
                break;
            case 4:
                Console.WriteLine("Hej, Mulighed 4");
                break;
		    default:
                Console.WriteLine("Fejl, du inputtede: " + res);
                break;
	    }
        Console.ReadLine();

    }

}
