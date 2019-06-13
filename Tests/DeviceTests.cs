//Testy jednostkowe sprawdzające poprawność działania metod klasy Device
class DeviceTests{
    Device testDevice= new Device();
    SerialPort testPort=new SerialPort();
public void WrongValue(int value)
{
    result = testDevice.GetValue(testPort);
    
    Assert.False(result, $"{value} is not a valid value");
}
public void CorrectValu(int value)
{
    result = testDevice.GetValue(testPort);

    Assert.True(result, $"{value} is a correct value");
}
}