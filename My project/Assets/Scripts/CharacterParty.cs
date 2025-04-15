using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CharacterParty : MonoBehaviour
{
    [SerializeField]
    public List<CharacterData> party = new List<CharacterData>();

    [SerializeField]
    Character character;

    public void addCharacter(CharacterData newchar)
    {
        party.Add(newchar);
    }

    public void deleteCharacter(CharacterData delchar)
    {
        party.Remove(delchar);
    }

    public CharacterData GetCharacter(int index)
    {
        if (index < party.Count)
        {
            return party[index];
        }
        else { return null; }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
