using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BTAI;

public class AI_Commands : MonoBehaviour {

    Root tree = BT.Root();

    bool isVisible = false;

    private void Start()
    {
        tree.OpenBranch(

            BT.Sequence().OpenBranch(

                BT.If(() => IsVisible()).OpenBranch(
                    
                    
                    )

                )

            );
    }

    private void Update()
    {
        tree.Tick();
    }

    ///
    // Fazer funções para a comparação dos "if"sda AI
    ///

    bool IsVisible() { return isVisible; }

}
