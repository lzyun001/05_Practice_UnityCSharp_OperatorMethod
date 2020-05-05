using UnityEngine;
using UnityEngine.UI;
using System;

public class Monster_Method : MonoBehaviour
{
    public Monster monster1;
    public Monster monster2;

    [Header("文字：輸出結果")]
    public Text result;

    public void BatAttack()
    {
        monster2.hp = monster2.hp - monster1.att;
        result.text = monster2.name + " - 受到傷害：" + monster1.att + "\n" + monster2.name + " - 血量剩下：" + monster2.hp;
    }

    public void BatHeal()
    {
        monster1.hp = monster1.hp + monster1.heal;
        result.text = monster1.name + " - 收到治愈：" + monster1.heal + "\n" + monster1.name + " - 血量剩下：" + monster1.hp;
    }

    public void SlimeAtt()
    {
        monster1.hp = monster1.hp - monster2.att;
        result.text = monster1.name + " - 受到傷害：" + monster2.att + "\n" + monster1.name + " - 血量剩下：" + monster1.hp;
    }

    public void SlimeHeal()
    {
        monster2.hp = monster2.hp + monster2.heal;
        result.text = monster2.name + " - 收到治愈：" + monster2.heal + "\n" + monster2.name + " - 血量剩下：" + monster2.hp;
    }
}
