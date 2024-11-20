{
    Console.WriteLine("üçgenin 1.kenarını giriniz");
    int kenar1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("üçgenin 2.kenarını giriniz" );
    int kenar2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("üçgenin 3.kenarını giriniz");
    int kenar3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("hesaplanan cevre degeri");
    int cevre = (kenar1 + kenar2 + kenar3);
    Console.WriteLine(cevre);
    Console.WriteLine("karenin kenarını giriniz");
    int kenar4 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("hesaplanan cevre degeri");
    int cevre2 = 4 * (kenar4);
    Console.WriteLine(cevre2);
    Console.WriteLine("ucgenin cevresi=" + cevre);
    Console.WriteLine("karenin cevresi=" + cevre2);




}
