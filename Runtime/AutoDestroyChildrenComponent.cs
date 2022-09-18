using UnityEngine;

namespace Kogane.Internal
{
    /// <summary>
    /// シーン開始時に子オブジェクトをすべて削除するコンポーネント
    /// </summary>
    [DefaultExecutionOrder( -1000 )]
    [DisallowMultipleComponent]
    internal sealed class AutoDestroyChildrenComponent : MonoBehaviour
    {
        //================================================================================
        // 関数
        //================================================================================
        /// <summary>
        /// 初期化される時に呼び出されます
        /// </summary>
        private void Awake()
        {
            foreach ( Transform child in transform )
            {
                Destroy( child.gameObject );
            }
        }
    }
}