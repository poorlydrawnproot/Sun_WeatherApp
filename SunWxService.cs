using System;

public class SunWxService
{
    public SunWxService()
    {
        // DO NOT PLACE getSunTemp IN HERE OR IT WONT BE ACCESSIBLE IN OTHER PARTS OF THE SYSTEM...
        // Don't ask how i know
    }
    public int getSunTemp()
    {
        Random r = new Random(); // stackoverflow copypaste, because yes
        int tempKelvin = r.Next(5600, 5800); // "Yo PC pick a number between 5600 and 5800"
        return tempKelvin; // aight bet
    }
}
