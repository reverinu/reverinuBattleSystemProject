using UnityEngine;
using System.Collections;
/*
*ラウンドを管理するスクリプト
*/


public class RoundManager : MonoBehaviour {

    [SerializeField][Header("ラウンド")]
    private int round;

    void Start()
    {
        round = 0;
    }

    public void RoundCount()
    {
        round++;
    }
}
