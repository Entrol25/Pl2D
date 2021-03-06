//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization;//

namespace Save_Load
{
    public class QuaternionSerializationSurrogte : ISerializationSurrogate
    {
        public void GetObjectData(object obj, SerializationInfo info, 
            StreamingContext context)
        {// вытащить из obj сериал. дата
            var q = (Quaternion)obj;
            info.AddValue("x", q.x);
            info.AddValue("y", q.y);
            info.AddValue("z", q.z);
            info.AddValue("w", q.w);
        }
        public object SetObjectData(object obj, SerializationInfo info, 
            StreamingContext context, ISurrogateSelector selector)
        {// из info в obj вытащить дата
            var q = (Quaternion)obj;
            q.x = (float)info.GetValue("x", typeof(float));
            q.y = (float)info.GetValue("y", typeof(float));
            q.z = (float)info.GetValue("z", typeof(float));
            q.w = (float)info.GetValue("w", typeof(float));
            obj = q;
            return obj;
        }
    }
}
