using System;
using System.Data;
using TMPro;
using UnityEngine;
public class SaveGame : MonoBehaviour
{
   [SerializeField] public int money;
   [SerializeField] private TextMeshProUGUI _mesh;

   private void Start()
   {
      _mesh = GetComponent<TextMeshProUGUI>();
   }

   private void Update()
   {
      money = PlayerPrefs.GetInt("money");
      _mesh.text = "" + money;
   }
}