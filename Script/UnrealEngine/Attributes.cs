using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnrealEngine
{

    public class UCLASS : Attribute
    {
        string _text;
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

    }
    public class UPROPERTY : Attribute
    {
        string _text;
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

    }
    public class UFUNCTION : Attribute
    {
        string _text;
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

    }
    public class USTRUCT : Attribute
    {
        string _text;
        public string text
        {
            get { return _text; }
            set { _text = value; }
        }

    }
}
