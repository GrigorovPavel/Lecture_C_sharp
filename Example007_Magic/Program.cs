Console.Clear();
// Console.SetCursorPosition ();
// Console.WriteLine ("+");

int xa = 40; 
int ya =1;
int xb = 1; 
int yb = 20;
int xc = 80; 
int yc = 20;

Console.SetCursorPosition (xa, ya);
Console.WriteLine ("+");

Console.SetCursorPosition (xb, yb);
Console.WriteLine ("+");

Console.SetCursorPosition (xc, yc);
Console.WriteLine ("+");

int x =xa, y=xb;
int count =0;

while (count < 3000){
    int random = new Random().Next(0,3); // [0;3) 0,1,2
    if(random == 0){
        x = (x + xa)/2;
        y = (y + ya)/2;
    }

    if(random == 1){
        x = (x + xb)/2;
        y = (y + yb)/2;
    }

    if(random == 2){
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition (x,y);
    Console.WriteLine ("+");
    count = count + 1;

}