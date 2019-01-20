using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CharacterStateControl;

public class CharacterBehaviour : MonoBehaviour
{
    private Character _character;

    // Start is called before the first frame update
    void Start()
    {
        _character = new Character();
        _character.characterObject = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        _character.Update();
    }
}
