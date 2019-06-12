class Program{

main()
{
	Device temperature = new Device();
	Device humidity = new Device();
	Device nitrogen = new Device();
	Device carbonOxide = new Device();
	Worksheet measurements = new Worksheet();

	int t, h, n, co;
	int tmin=20;
	int hmin=70;
	int nmin;
	int comin;
	
	int
	
	while()
	{
		delay(5min);
	
		
		t=temperature.GetValue(PORT1);
		if (t<tmin)
		{	
			temperature.SetPowerOn(PORT2);
		}
		else 
		{
			temperature.SetPowerOff(PORT2)
		}
	
		h=humidity.GetValue(PORT3);
		if (h<hmin)
		{
			humidity.SetPowerOn(PORT4);
		}
		else 
		{
			humidity.SetPowerOff(PORT4);
		}
		
		n=nitrogen.GetValue(PORT5);
		co=carbonOxide.GetValue(PORT6);
		if (n<nmin)
		{
			nitrogen.SetPowerOn(PORT7);
		}
		else 
		{
			nitrogen.SetPowerOff(PORT7);
		}
		if(co<comin)
		{	
			carbonOxide.SetPowerOn(PORT8);
		}
		else
		{
			carbonOxide.SetPowerOff(PORT8);
		}
		
		
		time = GetTimeStamp();
		Worksheet.SaveString(time);
		Worksheet.SaveValue('B',t);
		Worksheet.SaveValue('C',h);
		Worksheet.SaveValue('D',n);
		Worksheet.SaveValue('E', co);
		
	}
}
}