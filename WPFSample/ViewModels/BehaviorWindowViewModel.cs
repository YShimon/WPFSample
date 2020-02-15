using Prism.Mvvm;
using Reactive.Bindings;

namespace WPFSample.ViewModels
{
    /// <summary>
    /// BehaviorWindowのViewModel
    /// </summary>
    public class BehaviorWindowViewModel : BindableBase
    {
        /// <summary>
        /// タイトル(タイトルバー左に表示される文字列)
        /// </summary>
        public ReactiveProperty<string> Title => new ReactiveProperty<string> { Value = "Behaviour Sample" };

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public BehaviorWindowViewModel() 
        {
            InitializeCommand();
        }

        /// <summary>
        /// コマンドの初期化
        /// </summary>
        private void InitializeCommand()
        {
        }
    }
}
