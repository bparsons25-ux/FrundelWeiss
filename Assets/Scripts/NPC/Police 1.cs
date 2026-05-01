using UnityEngine;

public class Police1 : Interactable
{
    [SerializeField] MoneyManager moneyManager;
    [SerializeField] NPCsystem npcsystem;
    [SerializeField] NPCmovement i;

    public void policeBribed()
    {
        moneyManager.money -= 200;
        NPCsystem.hasSold = true;
    }

}
