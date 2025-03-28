using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStats", menuName = "Scriptable Objects/CharacterStats")]
public class CharacterStats : ScriptableObject
{
    public string characterName;
    public int strength;
    public int stamina;
    public int intelligence;
    public int charisma;
    public int willPower;
    public int dexterity;

    public void GenerateRandomStats()
    {
        characterName = "Character_" + Random.Range(1, 1000);
        strength = Random.Range(1, 100);
        stamina = Random.Range(1, 100);
        intelligence = Random.Range(1, 100);
        charisma = Random.Range(1, 100);
        willPower = Random.Range(1, 100);
        dexterity = Random.Range(1, 100);
    }
}
