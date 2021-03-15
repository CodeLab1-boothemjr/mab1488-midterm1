# mab1488-midterm1

## shoutouts

* Matt for lots of code / comments to reference.
* Kelly for helping to make some of the levels.

## todo list

* add death
* add level limit
* add music
* add win screen
* add trail
* update maps
* receive additional maps

## bugs

* players and enemies will catch on walls
* enemy AI currently uses MoveTowards instead of 

## questions

* Which of these from PlayerControl.cs have to be public / private and why?

    //var for the current player
    public GameObject currentPlayer;
    
    //var for player start position
    public Vector3 startPos;
    
    //name of the level file
    public string fileName;
    
    //current level var
    public int currentLevel = 0;
    
    //empty game object that holds the level
    public GameObject level;