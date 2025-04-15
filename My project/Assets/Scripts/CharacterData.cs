using NUnit.Framework;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.Rendering;
[System.Serializable]
public class CharacterData
{
    public Character basechar { get; private set; }
    public int level { get; private set; }

    public int currentHP { get; private set; }
    
    //public list of moves will be added in once moves is created/////////

    public CharacterData(Character basecharacter, int levelnum)
    {
        basechar = basecharacter;
        level = levelnum;
        currentHP = GetMaxHP();
    }

   public int GetMaxHP()
    {
        return basechar.hp + (level * 2);
    }
}

