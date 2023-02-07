int CalculateLenght(string[] startArr) //Calculate lenght of start array
{
    int lenght = 0;

    for (var i = 0; i < startArr.Length; i++)
    {
        if(startArr[i].Length <= 3)
        {
            lenght++;
        }
    }

    return lenght;
}

string[] CreateArray(string[] startArr, int lenght) //Create new array
{
    string[] resultArr = new string[lenght];
    int count = 0;

    for (var i = 0; i < startArr.Length; i++)
    {
        if(startArr[i].Length <= 3)
        {
            resultArr[count] = startArr[i];
            count++;
            if(count >= lenght)
            {
                break;
            }
        }
    }

    return resultArr;
}

string ArrayToStr(string[] strArray) //Create string from array
{
    string result = "[ ";

    for (int i = 0; i < strArray.Length; i++)
    {
        result += "\""+ strArray[i] + "\" ";
    }

    result += "]";
    return result;
}

string[] startArray = new string[4] {"123", "qwerty", ":-)", "wasd"};

Console.WriteLine($"Result: {ArrayToStr(CreateArray(startArray, CalculateLenght(startArray)))}");