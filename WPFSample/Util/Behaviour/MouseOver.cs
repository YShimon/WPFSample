using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interactivity;

namespace WPFSample.Util.Behaviour
{
    /// <summary>
    /// Buttonに対して適用可能なBehavior
    /// </summary>
    public class MouseOver : Behavior<Button>
    {
        /// <summary>
        /// メッセージ
        /// </summary>
        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        /// <summary>
        /// メッセージ(依存プロパティ)
        /// </summary>
        public static readonly DependencyProperty MessageProperty =
            DependencyProperty.Register(
                "Message",
                typeof(string),
                typeof(MouseOver),
                new UIPropertyMetadata(null));

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MouseOver()
        {
        }

        /// <summary>
        /// 要素にアタッチされたときの処理。大体イベントハンドラの登録処理をここでやる
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseEnter += Enter;
            AssociatedObject.MouseLeave += Leave;
        }

        /// <summary>
        /// 要素にデタッチされたときの処理。大体イベントハンドラの登録解除をここでやる
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.MouseEnter -= Enter;
            AssociatedObject.MouseLeave -= Leave;
        }

        /// <summary>
        /// マウスがコントロール領域に入ってきたときの処理(マウスカーソルを禁止マークにする)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enter(object sender, MouseEventArgs e)
            => Mouse.OverrideCursor = Cursors.No;

        /// <summary>
        /// マウスがコントロール領域を外れた時の処理(マウスカーソルを戻す)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Leave(object sender, MouseEventArgs e)
            => Mouse.OverrideCursor = null;
    }
}
