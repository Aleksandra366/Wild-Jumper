
using UnityEngine;

public class Room : MonoBehaviour
{

    [SerializeField] private GameObject[] enemies;
    private Vector3[] inititalPosition;

    private void Awake()
    {

        inititalPosition = new Vector3[enemies.Length];
        for(int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] != null)
                inititalPosition[i] = enemies[i].transform.position;
        }
    }

    public void ActivateRoom(bool _status)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            if (enemies[i] != null)
            {
                enemies[i].SetActive(_status);
                enemies[i].transform.position = inititalPosition[i];
            }
        }
    }
  

}
