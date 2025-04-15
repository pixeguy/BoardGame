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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Battle();
    }

    void Battle()
    {

        //temporary
        partyally = new CharacterData(allycharacter, 5);
        characterparty.party.Add(partyally);
        //temporary

        playercharacter = characterparty.GetCharacter(0);
        enemycharacter = new CharacterData(enemyparty, 1);

        playerunit.setup(playercharacter);
        enemyunit.setup(enemycharacter);
    }

    // Update is called once per frame
    void Update()
    { 

    }
}
