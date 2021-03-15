using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    //offset vars for the level position
    public float xOffset;
    public float yOffset;
    
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
    
    // Start is called before the first frame update
    void Start()
    {
        //currentPlayer = Get 
        LoadLevel(); // load first level
    }

    void LoadLevel()
    {
        //Destroy(level); //destroy the current level
        level = new GameObject("Level"); //create a new level gameObject
        
        string current_file_path = //build path to the level file
            Application.dataPath + "/Levels/" + fileName.Replace("Num", currentLevel + "");

        string text = File.ReadAllText(current_file_path);
        Debug.Log(text);
        currentPlayer = Instantiate<GameObject>(player);
        //startPos = new Vector3(-9.0f, 0.09f, 8.8f);
        currentPlayer.transform.position = new Vector3(-9.0f, 0.09f, 8.8f);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
