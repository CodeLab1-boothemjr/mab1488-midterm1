using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    //offset vars for the level position
    public float xOffset = -10;
    public float yOffset = 10;
    
    //Prefabs for the gameObjects we want to add to our scene
    public GameObject player;
    public GameObject wall;
    public GameObject enemy;
    public GameObject start;
    public GameObject finish;
    
    //var for the current player
    public GameObject currentPlayer;
    
    //var for player start position
    private Vector3 startPos;
    
    //name of the level file
    public string fileName;
    
    //current level var
    public int currentLevel = 0;
    
    //empty game object that holds the level
    public GameObject level;
    
    //property wrapping currentLevel
    //when the level changes, we load that level
    public int CurrentLevel
    {
        get { return currentLevel;}
        set
        {
            currentLevel = value;
            LoadLevel();
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        LoadLevel(); // load first level
    }

    void LoadLevel()
    {
        Destroy(level); //destroy the current level
        level = new GameObject("Level"); //create a new level gameObject
        
        string current_file_path = //build path to the level file
            Application.dataPath + "/Levels/" + fileName.Replace("Num", currentLevel + "");

        //pull the contents of the file into a string array
        //each line in the file becomes an item in the array
        string[] fileLines = File.ReadAllLines(current_file_path);
        
        //loop through each line
        for (int y = 0; y < fileLines.Length; y++)
        {
            //get the current line
            string lineText = fileLines[y];

            //split the line into a char array
            char[] characters = lineText.ToCharArray();

            //loop through each char
            for (int x = 0; x < characters.Length; x++)
            {
                //grab the current char
                char c = characters[x];

                //var for newObj
                GameObject newObj;
                //GameObject newObj2;

                switch (c) //switch statement for the char
                {
                    case 's': //if char is a 's'
                        //make a start gameObject
                        newObj = Instantiate<GameObject>(start);
                        startPos = new Vector3(x + xOffset, 0, -y + yOffset);
                        break;
                    case 'f': //if char is an 'f'
                        //make a start gameObject
                        newObj = Instantiate<GameObject>(finish);
                        break;
                    case 'w': //if char is a 'w'
                        //make a wall
                        newObj = Instantiate<GameObject>(wall);
                        break;
                    case 'e': //if char is an 'e'
                        //make a wall
                        newObj = Instantiate<GameObject>(enemy);
                        break;
                    default: //if the char is anything else
                        newObj = null; //make newObj null
                        break;
                }

                // if there's an object to be placed, place it
                if (newObj != null)
                {
                    newObj.transform.position =
                        new Vector3(x + xOffset, 0, -y + yOffset);
                    newObj.transform.parent = level.transform;
                }
            }
        }
        
        //add the player last
        if (currentPlayer == null)
        {
            currentPlayer = Instantiate(player);
            currentPlayer.transform.position = startPos;
        }
        else
        {
            currentPlayer.transform.position = startPos;
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
