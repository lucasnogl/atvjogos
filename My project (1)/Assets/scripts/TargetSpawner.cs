using UnityEngine;
using System.Collections.Generic;

public class TargetSpawner : MonoBehaviour
{
    [System.Serializable]
    public class SpawnPoint
    {
        public Transform position;            // Posição do spawn (objeto vazio)
        public GameObject targetPrefab;       // Qual target vai nascer
        public int quantity = 1;              // Quantos targets
        public Vector3 scale = Vector3.one;   // Tamanho
        public Vector3 rotation = Vector3.zero; // Rotação

        // Movimento
        public bool moveHorizontal = false;
        public bool moveVertical = false;
        public float moveSpeed = 3f;
        public float moveRange = 5f;
    }
}