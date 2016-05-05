using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
*
* ステートを保持するスクリプト
*
*/
public class StateInfo : MonoBehaviour {
    
    [SerializeField][Header("ステート名")]
    private string _stateNameText;
    [SerializeField][Header("ステート説明文")]
    private string _stateInfoText;
    private enum TRIGGERTIMING
    {
        START,
        END,
        CONTINUE
    }
    [SerializeField][Header("発動タイミング")]
    private TRIGGERTIMING _triggerTiming;
    [SerializeField][Header("持続ターン数")]
    private int _persistTurn;
    [SerializeField][Header("受けるダメージ量(毒・火傷)")]
    private int _damege;// マイナスなら回復
    [SerializeField][Header("行動可能判定")]
    private bool _isAction;
    [SerializeField][Header("行動発動確率")]
    private int _actionProbability;
    [SerializeField][Header("無敵判定")]
    private bool _isInvincible;
    private enum ABILITY
    {
        ATK,
        DEF,
        MATK,
        MDEF,
        AGL,
        AVO,
        NONE// 能力変化しない
    }
    [SerializeField][Header("変化する能力")]
    private ABILITY _ability;
    [SerializeField][Header("変化のパーセンテージ")]
    private int _ChangePercentage;
}
