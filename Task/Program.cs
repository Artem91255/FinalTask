string[] Result(string[] Array)
{
    string[] Array2 = new string[Array.Length];
    int countOfArray2 = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
             Array2[i] = Array[i];
             countOfArray2++;
        }
        else Array2[i] = "null";
    }
     string[] Array3 = new string[countOfArray2];
     int countOfArray3=0;
    for(int i = 0; i<Array2.Length; i++)
    {
        
        if(Array2[i] != "null")    
        {
        Array3[countOfArray3] = Array2[i];
        countOfArray3++;
        }
    }
    return Array3;
    
}



string[] StartArray = { "hello", "2", "world", ":-)" };
string[] FinalArray = Result(StartArray);
Console.WriteLine("[{0}]", string.Join(",", FinalArray));
