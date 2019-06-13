#define MAX 5

class Device
{
	bool power;
	int measurement;
	int intValue;
	byte byteValue;
	
	
	int GetValue(SerialPort PORT)
	{
	get serialData to byteValue from PORT;
	convert byteValue to intValue;
	return intValue;
	}
	
	void SetPowerOn(SerialPort PORT)
	{
		set power to true;
		send power to PORT;
	}
	
	void SetPowerOff(SerialPort PORT)
	{
		set power to false;
		send power to PORT;
	}
	
	
			
			

	

}
