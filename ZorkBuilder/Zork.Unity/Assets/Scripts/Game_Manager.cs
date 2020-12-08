using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork;

public class Game_Manager : MonoBehaviour
{
    public string ZorkFilename = @"Assets\Resources\Zork.json";
    public UnityOutputService OutputService;

    void Awake()
    {
        //TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);

        //Game.Start(gameJsonAsset.text, Output);
    }

    // Start is called before the first frame update
    void Start()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>(ZorkGameFileAssetName);
        Game.Start(gameJsonAsset.text, OutputService);
    }

    // Update is called once per frame
    void Update()
    {

    }

    [SerializeField]
    private string ZorkGameFileAssetName = "Zork";

    //[SerializeField]
    //private UnityOutputService Output;
}
