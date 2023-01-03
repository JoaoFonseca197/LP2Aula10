using System;
namespace Indexers
{
    public struct MyVector
    {
        
        public float X { get; set; }
        public float Y { get; set; }
        public MyVector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float this [float index]
        {
            get
            {
                if(index==0){return  X;}
                if(index == 1){return Y;}
                else { throw new IndexOutOfRangeException();}
            }
        }

        public float this [string index]
        {
            get
            {
                index.ToLower();
                if(index=="x" || index=="a" || index=="0"){return  X;}
                if(index=="y"||index=="b"||index=="1"){return Y;}
                else { throw new IndexOutOfRangeException();}
            }
        }
    }
}