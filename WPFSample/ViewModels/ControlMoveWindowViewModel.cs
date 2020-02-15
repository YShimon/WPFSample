using Prism.Mvvm;
using Reactive.Bindings;

namespace WPFSample.ViewModels
{
    /// <summary>
    /// ControlMoveWindowのViewModel
    /// </summary>
    public class ControlMoveWindowViewModel : BindableBase
    {
        /// <summary>
        /// アプリケーションタイトル(タイトルバー左に表示される文字列)
        /// </summary>
        public ReactiveProperty<string> Title => new ReactiveProperty<string> { Value = "Control Move Sample By Drag&Drop" };

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ControlMoveWindowViewModel() 
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
