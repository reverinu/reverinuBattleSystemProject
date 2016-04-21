using UnityEngine;
using System.Collections;

/*
*    ここにはスキル情報が格納されている。ActionManagerで相手もしくは自身を対象とし、スキルが発動される。
*/
public class SkillInfo : MonoBehaviour {
    /*
    TODO: ステートをenumにしておく
    */

    [SerializeField][Header("与えるダメージ")]
    private int _damagedPoint;
    [SerializeField][Header("与えるステート")]
    private int _hasState;
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

