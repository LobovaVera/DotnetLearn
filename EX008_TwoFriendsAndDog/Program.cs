int distance = 10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
bool friend = false;
int time = 0;
int i =0;


while ( distance > 10 )
{
if (friend == false) { 
    time = distance/(secondFriendSpeed+dogSpeed);
    friend = true;
    distance = distance - (firstFriendSpeed +secondFriendSpeed)*time;
    i++;
}
if (friend== true){
    time = distance/(firstFriendSpeed+dogSpeed);
    friend = false;
    distance = distance - (firstFriendSpeed +secondFriendSpeed)*time;
    i++;
}

}
Console.WriteLine(("Собака пробежит ")+ (i) +("раз"));
