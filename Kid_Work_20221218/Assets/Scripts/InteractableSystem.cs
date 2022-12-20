using UnityEngine;

namespace Justin
{
    /// <summary>
    /// 互動系統
    /// </summary>
    public class InteractableSystem : MonoBehaviour
    {
        [SerializeField, Header("對話資料")]
        private DialogueData dataDialogue;

        private string nameTarget = "PlayerCapsule";

        private void OnTriggerEnter(Collider other)
        {
            print(other.name);
        }
        //碰撞結束
        private void OnTriggerStay(Collider other)
        {
            
        }
        //持續碰撞
        private void OnTriggerExit(Collider other)
        {
            
        }
    }
}


