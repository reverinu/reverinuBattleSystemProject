using UnityEngine;
using System.Collections;

/*
*    ここにはスキル情報が格納されている。ActionManagerで相手もしくは自身を対象とし、スキルが発動される。
*/
public class SkillInfo : MonoBehaviour {
    
    [SerializeField][Header("スキル説明文")]// マイナスだと回復する
    private string _skillInfoText;
    [SerializeField][Header("与えるダメージ")]// マイナスだと回復する
    private int _damagedPoint;
    [SerializeField][Header("与えるステート")]
    private GameObject _hasState;
    private enum RANGE
    {
        MY,
        FRIEND,
        ALLFRIENDS,
        ENEMY,
        ALLENEMIES
    }
    [SerializeField][Header("範囲")]
    private RANGE _range;
    [SerializeField][Header("スキル命中率")]
    private int _hitRate;
    [SerializeField][Header("スキルステート発動率")]
    private int _stateTrigerRate;
}

