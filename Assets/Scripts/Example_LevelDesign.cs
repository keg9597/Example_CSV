using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example_LevelDesign : MonoBehaviour
{
    public string dataPath;
    public List<Dictionary<string, object>> data;

    void Start()
    {
        LoadDataFromCSV();
    }

    public void LoadDataFromCSV()
    {

        data = CSVReader.Read(dataPath);
        for (int i = 0; i < data.Count; i++)
        {
                     
        }
    }
}
