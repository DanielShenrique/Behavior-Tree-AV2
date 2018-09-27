using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    private string form;
    private string getDamage;
    private string setDamage;

    private int lifeAi;

    private bool seePlayer;
    private bool playerDead;
    private bool isFloor;
    private bool isAir;
    private bool aiThanFastPlayer;
    private bool Razor;
    private bool Footão;
    private bool FIreBolt;
    private bool LauchPlayer;

    private void Start()
    {
        getDamage = "levou dano";
        setDamage = "deu dano";
    }

    private void Update()
    {
        if(lifeAi == 3)
        {
            if (playerDead)
            {
                Debug.Log("Player is dead");
            }

            if (!playerDead && seePlayer)
            {
                if (!aiThanFastPlayer)
                {
                    RecebeuDanoDOPlayer();
                }
                else
                {
                    PerseguirPlayer();
                }
            }

            if (!playerDead && !seePlayer)
            {
                Debug.Log("voar e andar por ai");
            }
        }
        if(lifeAi == 2)
        {
            if (playerDead)
            {
                Debug.Log("Player is dead");
            }

            if (!playerDead && seePlayer)
            {
                if (!aiThanFastPlayer)
                {
                    RecebeuDanoDOPlayer();
                }
                else
                {
                    PerseguirPlayer();
                }
            }

            if (!playerDead && !seePlayer)
            {
                Debug.Log("voar e andar por ai");
            }
        }
        if(lifeAi == 1)
        {
            if (playerDead)
            {
                Debug.Log("Player is dead");
            }

            if (!playerDead && seePlayer)
            {
                if (!aiThanFastPlayer)
                {
                    RecebeuDanoDOPlayer();
                }
                else
                {
                    PerseguirPlayer();
                }
            }

            if (!playerDead && !seePlayer)
            {
                Debug.Log("voar e andar por ai");
            }
        }

    }

    void PerseguirPlayer()
    {
        int r = Random.Range(1, 5);

        if(r <= 5)
        {
            isAir = true;
            playerDead = true;
            if(lifeAi == 2)
            {
                Footão = true;
                Razor = true;
            }
            if(lifeAi == 1)
            {
                FIreBolt = true;
            }
        }
        else
        {
            isFloor = true;
            playerDead = true;
            LauchPlayer = true;
        }
    }

    void RecebeuDanoDOPlayer()
    {
        lifeAi -= 1;
    }
}
