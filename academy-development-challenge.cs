using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}

    public string TryArrayMatching(string[] strArr) {
        string result = ""
        
        try {
            result = ArrayMatching(strArr);
        }
        catch (ArgumentException ex) {
            result = ex.Message;
        }
        catch (Exception ex) {
            throw;
        }

        return result;
    }

    public string ArrayMatching(string[] strArr) {
        if (strArr == null) throw new ArgumentException("strArr must not be null.");
        if (strArr.Length < 2 || strArr.Length > 2) throw new ArgumentException("strArr must have two elements.");
        if (strArr[0] == null || strArr[1] == null) throw new ArgumentException("Strings must not be null.")

        int[] intArr1 = CreateIntArray(strArr[0]);
        int[] intArr2 = CreateIntArray(strArr[1]);


        string result = "";
        return result;
    }

    public int[] CreateIntArray(string str) {
        
    }

    public bool CheckFormat(string str) {
        bool containsFirstBracket = str.Contains('[')
    }
}