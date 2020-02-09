namespace TypesAndTypeMembers
{
    /*
     * TYPES ARE:
     * 1. Classes
     * 2. Structs
     * 3. Enums
     * 4. Interfaces
     * 5. Delegates
     * TYPES can have only 2 access modifiers: internal & public
     * 
     * TYPE MEMBERS ARE:
     * 1. Fields
     * 2. Properties
     * 3. Constructors
     * 4. Methods
     * 5. etc
     * They usually reside in a TYPE & can have all access modifiers, such as:
     * - private
     * - protected
     * - internal
     * - protected internal
     * - public
     */
    class Program
    {
        static void Main()
        {
        }
    }

    /* MyClass is a TYPE */
    class MyClass
    {
        /* All below are TYPE MEMBERS */
        #region Fields
        private int _id;
        #endregion
        #region Constructors
        public MyClass()
        {

        }
        #endregion
        #region Properties
        public int ID { get { return this._id; } set { this._id = value; } }
        #endregion
        #region Methods
        void Print()
        {

        }
        #endregion
    }

}
