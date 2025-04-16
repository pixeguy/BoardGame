using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public BattleCharacter playerunit;
    public BattleCharacter enemyunit;

    public CharacterParty characterparty;

    //temporary
    private CharacterData partyally;
    public Character allycharacter;
    //temporary
    
    public Character enemyparty;

    private CharacterData playercharacter;
    private CharacterData enemycharacter;

    public int turnCounter = 0;
    [SerializeField]
    private List<CharacterData> turnOrder = new List<CharacterData>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetUp();
        Debug.Log(playercharacter.currentHP);
        StartCoroutine(Battle());


    }

    void SetUp()
    {
        //temporary
        partyally = new CharacterData(allycharacter, 5);
        characterparty.party.Add(partyally);
        //temporary

        playercharacter = characterparty.GetCharacter(0);
        enemycharacter = new CharacterData(enemyparty, 1);

        playerunit.setup(playercharacter);
        enemyunit.setup(enemycharacter);

        //setting turns
        turnOrder.Add(playercharacter);
        turnOrder.Add(enemycharacter);

        turnOrder.Sort((a, b) => b.currentSpeed.CompareTo(a.currentSpeed));
    }

    private IEnumerator Battle()
    {
        while (turnCounter >= 0 && turnCounter < turnOrder.Count)
        {
            CharacterData currentCharacter = turnOrder[turnCounter];

            if (currentCharacter != null)
            {
                Debug.Log($"{currentCharacter.name}'s turn!");

                // Wait until user presses 'W' to make an attack
                while (true)
                {
                    if (Input.GetKeyDown(KeyCode.W))
                    {
                        Debug.Log($"{currentCharacter.name} attacked!");
                        break;
                    }
                    yield return null;  // Wait for the next frame
                }
            }
            turnCounter++;
            if (turnCounter >= turnOrder.Count)
            {
                turnCounter = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
