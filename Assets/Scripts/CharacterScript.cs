using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    public string characterName;
    public float hp;
    public float mp;
    public float ad;
    public float asp;
    public float aDef;
    public float mDef;
    public float ms;
    public float range;

    private void Start()
    {
        gameObject.name = characterName;

        int rndX = Random.Range(-8, 9);
        int rndY = Random.Range(-6, 7);

        gameObject.transform.position = new Vector3(rndX, rndY, 0);
    }
}
