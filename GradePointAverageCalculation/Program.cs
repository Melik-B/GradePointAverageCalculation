//grade point average calculation

//ALGORITHM

//1.1 Start.
//1.2 User is asked for name.
//1.3 User is asked for last name.
//1.4 1st visa note is requested from the user.
//1.5 2nd visa note is requested from the user.
//1.6 Final grade is requested from the user.
//1.7 The user's average is calculated.
//1.8 The screen prints whether the user passed the course or not.


//not ortalaması hesaplama

//ALGORİTMA

//1.1 Başla.
//1.2 Kullanıcıya adı sorulur.
//1.3 Kullanıcıya soyadı sorulur.
//1.4 Kullanıcıdan 1.vize notu istenir.
//1.5 Kullanıcıdan 2.vize notu istenir.
//1.6 Kullanıcıdan final notu istenir.
//1.7 Kullanıcının ortalaması hesaplanır.
//1.8 Ekrana kullanıcının dersi geçip geçemediği yazdırılır.



string name;
string surname;
double visa1;
double visa2;
double finish;
double average;
const double visaMultiplier = 0.2;
const double finishMultiplier = 0.6;


Console.Write("Name: ");
name = Console.ReadLine();

Console.Write("Surname: ");
surname = Console.ReadLine();

Console.Write("1. Visa: ");
visa1 = Convert.ToDouble(Console.ReadLine());

Console.Write("2. Visa: ");
visa2 = Double.Parse(Console.ReadLine());

Console.Write("Finish: ");
finish = Convert.ToDouble(Console.ReadLine());

average = (visa1 + visa2) * visaMultiplier + finish * finishMultiplier;

Console.WriteLine("Dear " + name + " " + surname + ", your average: " + average);

if (average >= 60)
    Console.WriteLine("congratulations " + name + " " + surname + " you have successfully completed the course.");
else
    Console.WriteLine("Dear " + name + " " + surname + " you did not complete the lesson.");


Console.ReadLine();