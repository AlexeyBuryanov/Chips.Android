using System;
using Android.Content;
using Android.Runtime;
using Android.Util;

namespace Com.Hootsuite.Nachos
{
    [Register("Com.Hootsuite.Nachos.NachosTextView")]
    public class NachosTextView : NachoTextView
    {
        public NachosTextView(Context context) 
            : base(context)
        {
        }

        public NachosTextView(Context context, IAttributeSet attrs) 
            : base(context, attrs)
        {
        }

        public NachosTextView(Context context, IAttributeSet attrs, int defStyleAttr) 
            : base(context, attrs, defStyleAttr)
        {
        }

        protected NachosTextView(IntPtr javaReference, JniHandleOwnership transfer) 
            : base(javaReference, transfer)
        {
        }
    }
}

