using System;

namespace ConceptsExample
{
    class CustomExceptionExample : Exception
    {
        public CustomExceptionExample() { }

        public CustomExceptionExample(string name) : base(String.Format("invalid student name : {0}",name))
        {

        }

    }
}
