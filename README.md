# mab1488-midterm1

## todo list

* add enemy AI
* add death
* add level limit
* add music
* add win screen
* add trail
* update maps
* receive additional maps

## bugs

* players and enemies will catch on walls

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