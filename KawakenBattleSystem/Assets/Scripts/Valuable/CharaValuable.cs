using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharaValuable : MonoBehaviour {

    [SerializeField][Header("キャラリスト")]
    private GameObject[] charaList;

    static readonly string charaTag = "CharaTag";

	// Use this for initialization
	void Start () {
        GetCharaList();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void GetCharaList()
    {
        charaList = GameObject.FindGameObjectsWithTag(charaTag);
    }


}
