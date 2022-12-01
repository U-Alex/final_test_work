//
string[] InputArray() {
    string[] array = {"hello", "2", "world", ":-)", "1234", "1567", "-2", "computer", "Russia", "Denmark", "Kazan"};
    Console.WriteLine($"будет использоваться исходный массив: [\"{String.Join("\", \"", array)}\"]");
    Console.WriteLine("если желаете ввести свой массив, вводите элементы разделяя их знаками ','  либо нажмите <Enter>: ");
    string? userInput = Console.ReadLine();
    if (userInput.Length != 0) {
        string[] userArray = userInput.Split(",");
        Console.WriteLine($"будет использоваться массив: [\"{String.Join("\", \"", userArray)}\"]");
        return userArray;
    }
    return array;
}

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

string[] array = InputArray();
string[] newArray =  CreateNewArray(ref array);

Console.WriteLine($"конечный массив: [\"{String.Join("\", \"", newArray)}\"]");
