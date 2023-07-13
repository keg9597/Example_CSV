using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_LOL : MonoBehaviour
{
    public string dataPath;
    public List<Dictionary<string, object>> data;
    public GameObject characterPrefab;

    public void LoadDataFromCSV()
    {
        //data = CSVReader.Read(dataPath);

        var data = CSVReader.Read(dataPath);

        int rnd = Random.Range(0, data.Count);
        GameObject character = Instantiate(characterPrefab);

        character.GetComponent<CharacterScript>().characterName = data[rnd]["Name"].ToString();
        character.GetComponent<CharacterScript>().hp = float.Parse(data[rnd]["HP"].ToString());
        character.GetComponent<CharacterScript>().mp = float.Parse(data[rnd]["MP"].ToString());
        character.GetComponent<CharacterScript>().ad = float.Parse(data[rnd]["AD"].ToString());
        character.GetComponent<CharacterScript>().asp = float.Parse(data[rnd]["ASP"].ToString());
        character.GetComponent<CharacterScript>().aDef = float.Parse(data[rnd]["ADEF"].ToString());
        character.GetComponent<CharacterScript>().mDef = float.Parse(data[rnd]["MDEF"].ToString());
        character.GetComponent<CharacterScript>().ms = float.Parse(data[rnd]["MS"].ToString());
        character.GetComponent<CharacterScript>().range = float.Parse(data[rnd]["RANGE"].ToString());
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            LoadDataFromCSV();
        }
    }
}
