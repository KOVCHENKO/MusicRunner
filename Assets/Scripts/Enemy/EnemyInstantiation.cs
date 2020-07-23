using Level.MusicalStrings;
using UnityEngine;

namespace Enemy
{
    public class EnemyInstantiation : MonoBehaviour
    {
        public GameObject enemyNote;
        public int width = 4;
        public int height = 4;
        
        private void Start()
        {
            float firsrtPositionX = 0;            

            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new FirstString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new ThirdString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new SecondString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new ThirdString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new FirstString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new ThirdString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new SecondString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new ThirdString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new FirstString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new ThirdString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new SecondString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
            
            for (int x = 0; x < width; x++)
            {
                Instantiate(enemyNote, new Vector3(firsrtPositionX * 3f, new ThirdString().GetEnemyNoteYCoord(), 0), Quaternion.identity);
                firsrtPositionX += 1f;
            }
        }
    }
}