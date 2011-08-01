//AutoGenerated

namespace org.w3c.dom.indexeddb
{

    public interface IDBKeyRange
    {
        // IDBKeyRange
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short SINGLE = 0;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short LEFT_OPEN = 1;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short RIGHT_OPEN = 2;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short LEFT_BOUND = 4;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short RIGHT_BOUND = 8;
        object left {get;}
        object right {get;}
        short flags {get;}
        IDBKeyRange only(object value);
        IDBKeyRange leftBound(object bound);
        IDBKeyRange leftBound(object bound, bool open);
        IDBKeyRange rightBound(object bound);
        IDBKeyRange rightBound(object bound, bool open);
        IDBKeyRange bound(object left, object right);
        IDBKeyRange bound(object left, object right, bool openLeft);
        IDBKeyRange bound(object left, object right, bool openLeft, bool openRight);
    }

}