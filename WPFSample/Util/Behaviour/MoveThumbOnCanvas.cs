using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interactivity;

namespace WPFSample.Util.Behaviour
{
    public class MoveThumbOnCanvas : Behavior<Thumb>
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MoveThumbOnCanvas() { }

        /// <summary>
        /// 要素にアタッチされたときの処理。大体イベントハンドラの登録処理をここでやる
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.DragDelta += DragDelta;
        }

        /// <summary>
        /// 要素にデタッチされたときの処理。大体イベントハンドラの登録解除をここでやる
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.DragDelta -= DragDelta;
        }

        private void DragDelta(object sender, DragDeltaEventArgs e)
        {
            Canvas.SetLeft(AssociatedObject, Canvas.GetLeft(AssociatedObject) + e.HorizontalChange);
            Canvas.SetTop(AssociatedObject, Canvas.GetTop(AssociatedObject) + e.VerticalChange);
        }
    }
}
