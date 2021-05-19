class cricket
{

Struct Team {
var totalGamesWon=0;
var totalGamesLost=0;
var numberofDrawMatches=0;
}

var group1= [Team1, Team2, Team3, Team4];
var group2=[Team5, Team6, Team7, Team8];
var group3=[Team9, Team10, Team11, Team12];
var group4=[Team13, Team14, Team15, Team16];

Public enum MatchResult {
won=0,
lost=1,
draw=2
}

string array[];
array ar=new array[15];
array = ar.append(group1);
array=ar.append(group2);
array=ar.append(group3);
array=ar.append(group4);


Random random= new Random();
int i= random.Next(0,array.Lenght);
Console.Write(array[i]);

var userTeam=array[i];

int j;
do
{
j=random.Next(0,array.Lenght);
}
while(i!=j);  // picked user team is not same as opponent team
var oppTeam=array[j];
Console.write(array[j]);

int m=random.Next(0,2);
var resultType;
if m == 0 {
resultType  = won
} else if m == 1 {
resultType  = lost
} else {
resultType  = draw
}

Console.Write(+resultType);



this.addMatchResult( userTeam, resultType);

if resultType == 0 { // oppnent logic
this.addMatchResult( oppTeam, 1); // won
} else if resultType == 1 {
this.addMatchResult( oppTeam, 0); // lost
} else {
this.addMatchResult( oppTeam, 2); // draw
}



Public void addMatchResult( Team , MatchResult)
{
if MatchResult == 0 {
Team. totalGamesWon += 1;
} else if MatchResult == 1 {
Team. totalGamesLost -=  1;
} else {
Team. numberofDrawMatches += 1;
}
}







}
