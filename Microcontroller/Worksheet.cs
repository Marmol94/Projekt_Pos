class Worksheet
{
	void Create(){
	
	var excelApp = new Application();
	var worksheet = excelApp.Workbook.Worksheets.Add("ImportFromDataTable");
	excelApp.Save("Measurement.xlsx");

	
	}
	void SaveValue(char column, int value,string timeStamp){

		
	excelApp.SelectColumn(column);
	measurement=value;
	excelApp.MovetoFirstEmptyRow();
	excelApp.Add(measurement);
	
	}	
	void SaveString(string stamp )
	{
		excelApp.SelectColumn('A');
		excelApp.AddDate(stamp);
	
	}