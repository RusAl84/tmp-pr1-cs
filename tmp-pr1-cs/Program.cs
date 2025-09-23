using System.Diagnostics;

long nop = 0;  // number of operations

for(int n = 1; n <= 64; n++) {
    var sw = new Stopwatch();
    sw.Start();
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
    sw.Stop();
    //Console.WriteLine("{0}; {1} ", n, sw.Elapsed.TotalMilliseconds * 1000000);
    Console.WriteLine("{1} ", n, sw.Elapsed.TotalMilliseconds * 1000000);
    //Console.WriteLine("{0}; {1} ", n, nop); 
    //Console.WriteLine("{0} ", nop);
}



// Write result https://stackoverflow.com/questions/2329079/how-do-you-convert-stopwatch-ticks-to-nanoseconds-milliseconds-and-seconds
//Console.WriteLine("Time elapsed (s): {0}", stopwatch.Elapsed.TotalSeconds);
//Console.WriteLine("Time elapsed (ms): {0}", stopwatch.Elapsed.TotalMilliseconds);
//Console.WriteLine("Time elapsed (ns): {0}", stopwatch.Elapsed.TotalMilliseconds * 1000000);

