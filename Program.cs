string[] CreateNewArray(ref string[] array) {
    int count = 0;
    string[] newArr = new string[count];
    foreach (string obj in array) {
        if (obj.Length <= 3) {
            count++;
            Array.Resize(ref newArr, count);
            newArr[count-1] = obj;
        }
    }
    return newArr;
}


string[] array = {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer", "Russia", "Denmark", "Kazan"};
string[] newArray =  CreateNewArray(ref array);

Console.WriteLine($"исходный массив: [\"{String.Join("\", \"", array)}\"]");
Console.WriteLine($"конечный массив: [\"{String.Join("\", \"", newArray)}\"]");
