using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CharaInfo : MonoBehaviour {

    [SerializeField][Header("キャラレベル")]
    int charaLv;
    [SerializeField][Header("キャラネーム")]
    private string _charaName;
    [SerializeField][Header("キャラ画像")]
    private Image _charaImage;
    public enum CHARAJOB
    {
        KNIGHT,
        KING,
        ENEMY
    }
    [Header("キャラ職業")]
    public CHARAJOB charaJob;
    [Header("攻撃力")]
    public int atk;
    [Header("防御力")]
    public int def;
    [Header("魔法攻撃力")]
    public int matk;
    [Header("魔法防御力")]
    public int mdef;
    [Header("素早さ")]
    public int agl;
    [Header("回避率")]
    public int avo;
    [Header("体力")]
    public int hp;
    [Header("魔力")]
    public int mp;
    
    public enum SKILL
    {
        FIRE,
        MEGAFIRE
    }
    [Header("所持スキルリスト")]
    public List<SKILL> _skillList = new List<SKILL>();

    public enum ITEM
    {
        PORTION,
        MEGAPORTION
    }
    [Header("所持アイテムリスト")]
    public List<ITEM> _itemList = new List<ITEM>();


}
