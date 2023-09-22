

int totalPlayer = 0;
int totalDealer = 15;
string message = "";

 //black jack game,  request cards from the user until they say no or they bust (go over 21)
 
if (totalPlayer > totalDealer)
{
    message = "You win! dealer loose.... Congratulations!!!";
}
else if (totalPlayer < totalDealer)
{
    message = "You loose! dealer win.... Sorry!!!";
}
else
{
    message = "It's a tie! dealer win.... Sorry!!!";
}

Console.Write(message);

