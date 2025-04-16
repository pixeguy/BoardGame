using UnityEngine;
using UnityEngine.UIElements;

public class BattleCharacter : MonoBehaviour
{

    public CharacterData CharacterData {  get; private set; }
    public void setup(CharacterData characterData)
    {
        CharacterData = characterData;

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
