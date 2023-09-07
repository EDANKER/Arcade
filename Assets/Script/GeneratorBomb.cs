using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorBomb : MonoBehaviour
{
    [SerializeField] private float minX = -3.5f;
    [SerializeField] private float maxX = 3.5f;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    [SerializeField] private GameObject _base;
    [SerializeField] private GameObject bomb;
    [SerializeField] private GameObject _canvasGame;

    public void CreateBomb(Transform parent)
    {
        var randomMin = Random.Range(500f, -500f);
        randomMin = minY;
        randomMin = maxY;
        
        var posEnemyOranje = new Vector2(parent.position.x + Random.Range(minX, maxX),
            parent.position.y + Random.Range(minY, maxY) + 19.2f);
        var canvasOranje = Instantiate(bomb, posEnemyOranje, Quaternion.identity, _base.transform);
        canvasOranje.transform.SetParent(_canvasGame.transform, false);
    }
}