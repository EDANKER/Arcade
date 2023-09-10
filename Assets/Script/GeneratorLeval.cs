using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GeneratorLeval : MonoBehaviour
{
    [SerializeField] private GameObject _red;
    [SerializeField] private GameObject _oranje;
    [SerializeField] private GameObject _blue;

    [SerializeField] private float minX = -3.5f;
    [SerializeField] private float maxX = 3.5f;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    [SerializeField] private GameObject _base;

    [SerializeField] private GameObject _canvasGame;

    public void CreateIamges(Transform parent)
    {
        var random = Random.Range(-1000f, -2000f);

        minY = random;
        maxY = random;

        var randomOranje = Random.Range(1, 2);
        var randomBlue = Random.Range(1, 2);
        var randomRed = Random.Range(1, 1);

        for (var i = 0; i < randomOranje; i++)
        {
            var posEnemyOranje = new Vector2(parent.position.x + Random.Range(minX, maxX),
                parent.position.y + Random.Range(minY, maxX) + 19.2f);
            var canvasOranje = Instantiate(_oranje, posEnemyOranje, Quaternion.identity, _base.transform);
            canvasOranje.transform.SetParent(_canvasGame.transform, false);
        }

        for (var i = 0; i < randomBlue; i++)
        {
            var posEnemyBlue = new Vector2(parent.position.x + Random.Range(minX, maxX),
                parent.position.y + Random.Range(minY, maxX) + 19.2f);
            var canvasBlue = Instantiate(_blue, posEnemyBlue, Quaternion.identity, _base.transform);
            canvasBlue.transform.SetParent(_canvasGame.transform, false);
        }

        for (var i = 0; i < randomRed; i++)
        {
            var posEnemyRed = new Vector2(parent.position.x + Random.Range(minX, maxX),
                parent.position.y + Random.Range(minY, maxX) + 19.2F);
            var canvasRed = Instantiate(_red, posEnemyRed, quaternion.identity, _base.transform);
            canvasRed.transform.SetParent(_canvasGame.transform, false);
        }
    }
}