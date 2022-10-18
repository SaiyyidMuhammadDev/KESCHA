
System.Console.WriteLine($"Hello\nWhat is you name?:");
string name = System.Console.ReadLine();
System.Console.WriteLine($"Helle {name}. My name is Kescha. WELCOME");
System.Console.Write("How old are you?:");
string age = System.Console.ReadLine();
int ageInt = Convert.ToInt32(age);
if(ageInt>3){
    System.Console.WriteLine("You older then Kescha");
}
else if(ageInt<3){
    System.Console.WriteLine("You are younger then Kescha");
}
else {
    System.Console.WriteLine("Your age eaual to Kescha age");
}
