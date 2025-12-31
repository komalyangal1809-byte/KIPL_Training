using MachineApi.Models;

namespace MachineApi.Data
{
    public class TextFileDataReader:IDatareader
    {
        public List<MachineAsset> ReadData()
        {
            try
            {
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "Data");

                var csvPath = Path.Combine(folder, "Matrix.csv");
                var jsonPath = Path.Combine(folder, "Matrix.json");

                if(File.Exists(csvPath))
                {
                    return new CsvFileReader().Read(csvPath);
                }
                if (File.Exists(jsonPath))
                {
                    return new JsonFileReader().Read(jsonPath);
                }
               
            }
            catch(FileNotFoundException ie)
            {   
                   Console.WriteLine("File Path Not Found "+ie.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurs "+ex.ToString());
            }
            return new List<MachineAsset>();

        }
    }
}
