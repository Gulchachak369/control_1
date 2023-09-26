// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

string[] input = {"Иж", "Ока", "Волга", "Казанка", "Дон"}; 
string[] output = {}; 
 
for (int i = 0; i < input.Length; i++) { 
    string s = input[i]; 
    if (s.Length <= 3) { 
        output = output.Append(s).ToArray(); 
    } 
} 
 
Console.WriteLine("[{0}]", string.Join(", ", output));
