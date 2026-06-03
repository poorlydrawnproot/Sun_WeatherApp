using System;

public class SunWxService
{
    public SunWxService()
    {

    }
    public int getSunTemp()
    {
        Random r = new Random(); // stackoverflow copypaste, because yes
        int tempKelvin = r.Next(5600, 5800);
        return tempKelvin;
    }
}
