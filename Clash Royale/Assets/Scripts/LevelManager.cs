using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using TMPro;



public class LevelManager : MonoBehaviour
{
    public List<CR_Character> characters;
    public CR_Character CharData;
    public GameObject dummy;
    public void LoadCharacters(string _fileName)
    {
        string path = Application.dataPath + "/Resources/" + _fileName + ".json";
        string data = File.ReadAllText(path);
        var resource = JSON.Parse(path);

        for (int i = 0; i < resource.Count; i++)
        {
            CR_Character character = new CR_Character();
            character.name = resource[i]["name"].Value;
            character.name = resource[i]["rarity"].Value;
            character.name = resource[i]["id"].Value;
            characters.Add(character);
        }
    }
    void Start()
    {
        characters = new List<CR_Character>();
        LoadCharacters("characters");
        dummy.transform.GetChild(0).GetComponent<TMP_Text>().text = characters[0].name;
        //CharData = FileSystem.instance.LoadFromJSON<CR_Character>("knight");
        //characters.Add(CharData);
    }

    
    void Update()
    {
        
    }
}
