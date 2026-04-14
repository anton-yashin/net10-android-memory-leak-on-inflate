using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace AndroidApp2
{
    internal sealed class CustomView : View
    {
        public CustomView(Context? context) : base(context)
        {
            ReferenceCounter.InvokeGC();
            ReferenceCounter.AddReferenceAndPrint(this);
        }

        public CustomView(nint javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
            ReferenceCounter.InvokeGC();
            ReferenceCounter.AddReferenceAndPrint(this);
        }

        public CustomView(Context? context, IAttributeSet? attrs) : base(context, attrs)
        {
            ReferenceCounter.InvokeGC();
            ReferenceCounter.AddReferenceAndPrint(this);
        }

        public CustomView(Context? context, IAttributeSet? attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            ReferenceCounter.InvokeGC();
            ReferenceCounter.AddReferenceAndPrint(this);
        }

        public CustomView(Context? context, IAttributeSet? attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
            ReferenceCounter.InvokeGC();
            ReferenceCounter.AddReferenceAndPrint(this);
        }
    }
}
