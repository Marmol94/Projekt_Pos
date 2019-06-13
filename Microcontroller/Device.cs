#define MAX 5
//* \file	

/*!

* \brief Definicja klasy Device
*
* Plik zawiera definicję klasy Device odpowiedzialnej
* za zbieranie informacji z czujników oraz
* za modyfikację wartości temperatury, wilgotności i 
* zawartości atmosfery.
 */
public class Device
{
	bool power;
	int measurement;
	int intValue;
	byte byteValue;
	
	/*!
	* 
	* \brief GetValue pobiera wartości z mikrokontrolera 
	*
	* Metoda pobiera dane szeregowe z określonego portu,
	* następnie zamienia dane szeregowe na wartości bitowe,
	* na końcu zwraca wartość bajtową przeskształconą na integer
	 */
	public int GetValue(SerialPort PORT)
	{
	get serialData to byteValue from PORT;
	convert byteValue to intValue;
	return intValue;
	}
	
	/*!
	* 
	* \brief SetPowerOn włącza urządzenie na określonym porcie
	*
	* Metoda używana do uruchamiania systemów odpowiedzialnych
	* za zmiany parametrów mikroklimatu w szklarni
	 */
	public void SetPowerOn(SerialPort PORT)
	{
		set power to true;
		send power to PORT;
	}
	/*!
	* \brief SetPowerOff wyłącza urządzenie na określonym porcie 
	*
	* Metoda używana do wyłączania systemów odpowiedzialnych
	* za zmiany parametrów mikroklimatu w szklarni. Kontrola zasilania
	* została zrealizowana w dwóch metodach w celach bezpieczeństwa
	 */
	
	public void SetPowerOff(SerialPort PORT)
	{
		set power to false;
		send power to PORT;
	}
	
	
			
			

	

}
