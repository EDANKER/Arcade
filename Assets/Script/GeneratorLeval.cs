using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class GeneratorLeval : MonoBehaviour
{
    [SerializeField] private GameObject _backGraund;
    
    [SerializeField] private GameObject _red;
    [SerializeField] private GameObject _oranje;
    [SerializeField] private GameObject _blue;

    [SerializeField] private float minX = -3.5f;
    [SerializeField] private float maxX = 3.5f;
    [SerializeField] private float minY = -8f;
    [SerializeField] private float maxY = 8f;

    [SerializeField] private GameObject _canvasGame;

    public void CreateIamges(Transform parent)
    {
        var posBackground = new Vector2(parent.position.x, parent.position.y + 19.2f);
        var newBackGraound = Instantiate(_backGraund, posBackground, Quaternion.identity);

        var randomOranje = Random.Range(1, 4);
        var randomBlue = Random.Range(1, 6);
        var randomRed = Random.Range(1, 2);

        for (var i = 0; i < randomOranje; i++)
        {
            var posEnemyOranje = new Vector2(parent.position.x + Random.Range(minX, maxX), 
                parent.position.y + Random.Range(minY, maxY) + 19.2f);
           var canvasOranje = Instantiate(_oranje, posEnemyOranje, Quaternion.identity, newBackGraound.transform);
           canvasOranje.transform.SetParent(_canvasGame.transform, false);
            
        }

        for (var i = 0; i < randomBlue; i++)
        {
            var posEnemyBlue = new Vector2(parent.position.x + Random.Range(minX, maxY),
                parent.position.y + Random.Range(minY, maxY) + 19.2f);
           var canvasBlue = Instantiate(_blue, posEnemyBlue, Quaternion.identity, newBackGraound.transform);
           canvasBlue.transform.SetParent(_canvasGame.transform, false);
        }

        for (var i = 0; i < randomRed; i++)
        {
            var posEnemyRed = new Vector2(parent.position.x + Random.Range(minX, maxX),
                parent.position.y + Random.Range(minY, maxY) + 19.2F);
           var canvasRed = Instantiate(_red, posEnemyRed, quaternion.identity, newBackGraound.transform);
           canvasRed.transform.SetParent(_canvasGame.transform, false);
        }
    }
}