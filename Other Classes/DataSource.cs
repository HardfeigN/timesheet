namespace time_sheet.Other_Classes
{
    public class DataSource
    {
        private static string _dataSourceStringFilePath = "DataSourceString.txt"; // файл для хранения строки подключения ( чтобы при сдаче тестового не нужно было лезть для проверки работы)
        public static string DataSourceString = "Server=localhost;Database=timesheet;User=timesheet_admin;Password=Zhbr123;";// дефолтная строка подключения

        public static string ReadDataSourceStringFromFile()
        {
            if (File.Exists(_dataSourceStringFilePath))
            {
                string text;
                using (StreamReader reader = new StreamReader(_dataSourceStringFilePath))
                {
                    text = reader.ReadToEnd();
                }
                return text;
            }
            else return DataSourceString;
        }        

        public static void WriteDataSourceStringToFile(string DataSourceString)
        {
            using (StreamWriter writer = new StreamWriter(_dataSourceStringFilePath, false))
            {
                writer.WriteLine(DataSourceString);
            }
        }
    }
}
