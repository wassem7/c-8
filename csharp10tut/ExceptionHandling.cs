class ExceptionHandlilng
{
    static void Main()
    {
        StreamReader streamReader = null;
        try
        {
            streamReader = new StreamReader(@"C:\SamplesFiles\Data.txt");

            System.Console.WriteLine(streamReader.ReadToEnd());
        }
        catch (FileNotFoundException e)
        {
            System.Console.WriteLine("Please check if the {0} exists", e.FileName);
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
        finally
        {
            if (streamReader != null)
            {
                streamReader.Close();
            }

            System.Console.WriteLine("Stream Closed wai");
        }
    }
}
