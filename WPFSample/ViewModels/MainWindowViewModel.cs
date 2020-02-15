using System;
using Prism.Mvvm;
using Reactive.Bindings;
using WPFSample.Views;

namespace WPFSample.ViewModels
{
    /// <summary>
    /// MainWindow ViewModel
    /// </summary>
    public class MainWindowViewModel : BindableBase
    {
        /// <summary>
        /// アプリケーションタイトル(タイトルバー左に表示される文字列)
        /// </summary>
        public ReactiveProperty<string> Title => new ReactiveProperty<string> { Value = "Sample App" };

        /// <summary>
        /// Behavior動作のサンプル画面を表示
        /// </summary>
        public ReactiveCommand ShowBehavior { get; private set; } = new ReactiveCommand();

        /// <summary>
        /// コントロールをドラッグして移動するサンプル画面を表示
        /// </summary>
        public ReactiveCommand ShowControlMove { get; private set; } = new ReactiveCommand();

        /// <summary>
        /// Avalondock(ドッキング)画面のサンプル画面を表示
        /// </summary>
        public ReactiveCommand ShowAvalondock { get; private set; } = new ReactiveCommand();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindowViewModel() 
        {
            InitializeCommand();
        }

        /// <summary>
        /// コマンドの初期化
        /// </summary>
        private void InitializeCommand()
        {
            ShowBehavior.Subscribe(_ => ShowBehaviorWindow());
            ShowControlMove.Subscribe(_ => ShowControlMoveWindow());
            ShowAvalondock.Subscribe(_ => ShowAvalondockWindow());
        }

        /// <summary>
        /// Behavior動作のサンプル画面を表示するコマンド
        /// </summary>
        private void ShowBehaviorWindow()
            => (new BehaviorWindow()).ShowDialog();

        /// <summary>
        /// コントロールをドラッグして移動するサンプル画面を表示するコマンド
        /// </summary>
        private void ShowControlMoveWindow()
            => (new ControlMoveWindow()).ShowDialog();

        /// <summary>
        /// Avalondock(ドッキング)画面のサンプル画面を表示するコマンド
        /// </summary>
        private void ShowAvalondockWindow()
            => (new AvalondockWindow()).ShowDialog();
    }
}
