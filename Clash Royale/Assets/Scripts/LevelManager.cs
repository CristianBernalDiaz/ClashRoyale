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

    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    public GameObject Card5;
    public GameObject Card6;
    public GameObject Card7;
    public GameObject Card8;
    public GameObject Card9;
    public GameObject Card10;
    public GameObject Card11;
    public GameObject Card12;
    public GameObject Card13;
    public GameObject Card14;
    public GameObject Card15;
    public GameObject Card16;
    public GameObject Card17;
    public GameObject Card18;
    public GameObject Card19;
    public GameObject Card20;
    public GameObject Card21;
    public GameObject Card22;
    public GameObject Card23;
    public GameObject Card24;
    public GameObject Card25;
    public GameObject Card26;
    public GameObject Card27;
    public GameObject Card28;
    public GameObject Card29;
    public GameObject Card30;
    public GameObject Card31;
    public GameObject Card32;
    public GameObject Card33;
    public GameObject Card34;
    public GameObject Card35;
    public GameObject Card36;
    public GameObject Card37;
    public GameObject Card38;
    public GameObject Card39;
    public GameObject Card40;
    public GameObject Card41;
    public GameObject Card42;
    public GameObject Card43;
    public GameObject Card44;
    public GameObject Card45;
    public GameObject Card46;
    public GameObject Card47;
    public GameObject Card48;
    public GameObject Card49;
    public GameObject Card50;
    public GameObject Card51;
    public GameObject Card52;
    public GameObject Card53;
    public GameObject Card54;
    public GameObject Card55;
    public GameObject Card56;
    public GameObject Card57;
    public GameObject Card58;
    public GameObject Card59;
    public GameObject Card60;
    public GameObject Card61;
    public GameObject Card62;
    public GameObject Card63;
    public GameObject Card64;
    public GameObject Card65;
    public GameObject Card66;
    public GameObject Card67;
    public GameObject Card68;
    public GameObject Card69;
    public GameObject Card70;

    public void LoadCharacters(string _fileName)
    {
        string path = Application.dataPath + "/Resources/" + _fileName + ".json";
        string data = File.ReadAllText(path);
        var resource = JSON.Parse(data);

        for (int i = 0; i < resource.Count; i++)
        {
            CR_Character character = new CR_Character();
            character.name = resource[i]["name"].Value;
            character.rarity = resource[i]["rarity"].Value;
            character.id = int.Parse(resource[i]["id"].Value);
            characters.Add(character);
        }
    }
    void Start()
    {
        characters = new List<CR_Character>();
        LoadCharacters("characters");

        Card1.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[0].name;
        Card1.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[0].id.ToString();

        Card2.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[1].name;
        Card2.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[1].id.ToString();

        Card3.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[2].name;
        Card3.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[2].id.ToString();

        Card4.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[3].name;
        Card4.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[3].id.ToString();

        Card5.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[4].name;
        Card5.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[4].id.ToString();

        Card6.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[5].name;
        Card6.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[5].id.ToString();

        Card7.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[6].name;
        Card7.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[6].id.ToString();

        Card8.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[7].name;
        Card8.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[7].id.ToString();

        Card9.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[8].name;
        Card9.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[8].id.ToString();

        Card10.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[9].name;
        Card10.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[9].id.ToString();

        Card11.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[10].name;
        Card11.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[10].id.ToString();

        Card12.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[11].name;
        Card12.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[11].id.ToString();

        Card13.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[12].name;
        Card13.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[12].id.ToString();

        Card14.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[13].name;
        Card14.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[13].id.ToString();

        Card15.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[14].name;
        Card15.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[14].id.ToString();

        Card16.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[15].name;
        Card16.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[15].id.ToString();

        Card17.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[16].name;
        Card17.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[16].id.ToString();

        Card18.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[17].name;
        Card18.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[17].id.ToString();

        Card19.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[18].name;
        Card19.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[18].id.ToString();

        Card20.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[19].name;
        Card20.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[19].id.ToString();

        Card21.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[20].name;
        Card21.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[20].id.ToString();

        Card22.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[21].name;
        Card22.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[21].id.ToString();

        Card23.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[22].name;
        Card23.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[22].id.ToString();

        Card24.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[23].name;
        Card24.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[23].id.ToString();

        Card25.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[24].name;
        Card25.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[24].id.ToString();

        Card26.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[25].name;
        Card26.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[25].id.ToString();

        Card27.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[26].name;
        Card27.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[26].id.ToString();

        Card28.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[27].name;
        Card28.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[27].id.ToString();

        Card29.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[28].name;
        Card29.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[28].id.ToString();

        Card30.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[29].name;
        Card30.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[29].id.ToString();

        Card31.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[30].name;
        Card31.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[30].id.ToString();

        Card32.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[31].name;
        Card32.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[31].id.ToString();

        Card33.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[32].name;
        Card33.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[32].id.ToString();

        Card34.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[33].name;
        Card34.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[33].id.ToString();

        Card35.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[34].name;
        Card35.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[34].id.ToString();

        Card36.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[35].name;
        Card36.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[35].id.ToString();

        Card37.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[36].name;
        Card37.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[36].id.ToString();

        Card38.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[37].name;
        Card38.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[37].id.ToString();

        Card39.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[38].name;
        Card39.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[38].id.ToString();

        Card40.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[39].name;
        Card40.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[39].id.ToString();

        Card41.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[40].name;
        Card41.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[40].id.ToString();

        Card42.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[41].name;
        Card42.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[41].id.ToString();

        Card43.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[42].name;
        Card43.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[42].id.ToString();

        Card44.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[43].name;
        Card44.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[43].id.ToString();

        Card45.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[44].name;
        Card45.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[44].id.ToString();

        Card46.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[45].name;
        Card46.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[45].id.ToString();

        Card47.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[46].name;
        Card47.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[46].id.ToString();

        Card48.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[47].name;
        Card48.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[47].id.ToString();

        Card49.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[48].name;
        Card49.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[48].id.ToString();

        Card50.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[49].name;
        Card50.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[49].id.ToString();

        Card51.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[50].name;
        Card51.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[50].id.ToString();

        Card52.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[51].name;
        Card52.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[51].id.ToString();

        Card53.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[52].name;
        Card53.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[52].id.ToString();

        Card54.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[53].name;
        Card54.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[53].id.ToString();

        Card55.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[54].name;
        Card55.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[54].id.ToString();

        Card56.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[55].name;
        Card56.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[55].id.ToString();

        Card57.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[56].name;
        Card57.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[56].id.ToString();

        Card58.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[57].name;
        Card58.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[57].id.ToString();

        Card59.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[58].name;
        Card59.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[58].id.ToString();

        Card60.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[59].name;
        Card60.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[59].id.ToString();

        Card61.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[60].name;
        Card61.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[60].id.ToString();

        Card62.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[61].name;
        Card62.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[61].id.ToString();

        Card63.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[62].name;
        Card63.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[62].id.ToString();

        Card64.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[63].name;
        Card64.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[63].id.ToString();

        Card65.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[64].name;
        Card65.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[64].id.ToString();

        Card66.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[65].name;
        Card66.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[65].id.ToString();

        Card67.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[66].name;
        Card67.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[66].id.ToString();

        Card68.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[67].name;
        Card68.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[67].id.ToString();

        Card69.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[68].name;
        Card69.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[68].id.ToString();

        Card70.transform.GetChild(0).GetChild(0).GetComponent<TMP_Text>().text = characters[69].name;
        Card70.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<TMP_Text>().text = characters[69].id.ToString();

        //CharData = FileSystem.instance.LoadFromJSON<CR_Character>("knight");
        //characters.Add(CharData);
    }

    
    void Update()
    {
        
    }
}
