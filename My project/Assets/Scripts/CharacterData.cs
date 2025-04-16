using NUnit.Framework;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.Rendering;
[System.Serializable]
public class CharacterData
{
    public Character basechar { get; private set; }
    public int level { get; private set; }

    public string name;
    public int currentHP;
    public int currentSpeed;
    
    //public list of moves will be added in once moves is created/////////

    public CharacterData(Character basecharacter, int levelnum)
    {
        basechar = basecharacter;
        name = basecharacter.name;
        level = levelnum;
        currentHP = basechar.hp + (level * 2);
        currentSpeed = basechar.speed + (level); 
    }

}

