using MachineApi.Models;

namespace MachineApi.Data
{
    public class TextFileDataReader:IDatareader
    {
        private readonly string _filePath;

        public TextFileDataReader(string filepath)
        {
            _filePath = filepath;
        }
        public List<MachineAsset> ReadData()
        {
            var data = new List<MachineAsset>();
            try
            {
                var lines = File.ReadAllLines(_filePath);
                
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    data.Add(new MachineAsset
                    {
                        MachineName = parts[0].Trim(),
                        AssetName = parts[1].Trim(),
                        Series = parts[2].Trim()
                    });
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
            return data;
        }
    }
}
