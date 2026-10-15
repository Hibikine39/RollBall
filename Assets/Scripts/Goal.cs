using UnityEngine;
using TMPro;

public class GoalMessage : MonoBehaviour
{
    // ゴールのCollider
    [SerializeField] private Collider goalCollider;

    // メッセージ表示用のTextMeshPro
    [SerializeField] private TMP_Text messageText;

    void Start()
    {
        // 最初はメッセージを非表示にする
        messageText.gameObject.SetActive(false);

        // Is Triggerの状態を確認する
        Debug.Log("Is Trigger: " + goalCollider.isTrigger);

        if (goalCollider.isTrigger)
        {
            Debug.Log("Is TriggerはONです");
        }
        else
        {
            Debug.Log("Is TriggerはOFFです");
        }
    }

    // プレイヤーがゴールに入ったときに実行
    void OnTriggerEnter(Collider other)
    {
        // Is TriggerがONで、相手がPlayerの場合
        if (goalCollider.isTrigger && other.CompareTag("Player"))
        {
            // メッセージを設定する
            messageText.text = "ゴールしたよ！";

            // メッセージを表示する
            messageText.gameObject.SetActive(true);

            Debug.Log("ゴールしました！");
        }
    }
}