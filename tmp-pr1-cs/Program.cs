long nop = 0;  // number of operations
for(int n = 2; n <= 16; n++) { 
    nop++;
    int s = 0; nop++;
    nop+=4;
    for (int i = n; i < 2*n*n; i++)
    {
        nop += 5;
        nop += 5;
        for (int j = 2*n; j < n * n+1; j++)
        {
            nop += 5; 
            //Console.WriteLine("Александр не съел {0} ЁЖИКОВ", i);
            //Console.WriteLine("ЁЖИК не съел {0} Сашу", j);
            int k = 13; nop++;
            nop+=2;
            while (k +3 <42) {
                nop += 2;
                k += 7; nop += 2;
                s++; nop += 2;
            }
        }
    }
    nop++;
    //Console.WriteLine("s = {0} nop = {1} ", s, nop); 
    Console.WriteLine("{0}, {1} ", n, nop); 
}

