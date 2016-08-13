using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(ViewRenderer.MyView), typeof(ViewRenderer.UWP.MyViewRenderer))]
namespace ViewRenderer.UWP
{
    public class MyViewRenderer : ViewRenderer<ViewRenderer.MyView, Windows.UI.Xaml.Controls.TextBlock>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ViewRenderer.MyView> e)
        {
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    var nativeControl = new Windows.UI.Xaml.Controls.TextBlock();
                    nativeControl.Text = e.NewElement.Text;

                    //デバッグだと文字が見えづらかったため追加
                    nativeControl.FontSize = 50;

                    SetNativeControl(nativeControl);
                }
            }
            base.OnElementChanged(e);
        }
    }
}
