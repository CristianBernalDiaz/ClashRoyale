using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[System.Serializable]
public struct CRData
{
    public string Level;
    public string Gold;
    public string Esmerald;
    public string User;
    public string Clan;
}
public class MainMenu_Data : MonoBehaviour
{
    [Header("MAIN MENU CONFIG")]
    public CRData data;
    [Header("MAIN MENU UI")]

    public TMP_Text Level;
    public TMP_Text Gold;
    public TMP_Text Esmerald;
    public TMP_Text User;
    public TMP_Text Clan;
   

    void Start()
    {
        Level.text = data.Level.ToString();
        Gold.text = data.Gold.ToString();
        Esmerald.text = data.Esmerald.ToString();
        User.text = data.User;
        Clan.text = data.Clan;
    }
    void Update()
    {
        Level.text = data.Level.ToString();
        Gold.text = data.Gold.ToString();
        Esmerald.text = data.Esmerald.ToString();
        User.text = data.User;
        Clan.text = data.Clan;
    }
}
