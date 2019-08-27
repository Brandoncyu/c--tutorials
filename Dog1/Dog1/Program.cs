using System;

namespace Dog1
{
    public class Trainer
    {
        //event handler
        void Operate()
        {
            var dog = new Poodle();
            dog.HasSpoken += Dog_HasSpoken;
        }

        private void Dog_HasSpoken(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }

    public class Dog
    {
        //properties hold values
        //short-term. Better for holding bugs.
        public string Name { get; set; }

        private string _name;
        //long-term
        public string Name
        {
            get { return _name;  }
            private set {
                //look at value
                _name = value;
            }
        }

        

        public event EventHandler HasSpoken;

        //default is "bark" for what
        //"void" does not return anything
        public void Speak(string what = "bark")
        {
            //TODO
            if (HasSpoken != null)
                HasSpoken(this, EventArgs.Empty);
        }

        //can't have defaults that precede the ones that are required.
        public void Speak(int times, bool sit = true, string what = "bark" )
        {
            //TODO 
        }

        
        //only by this class
        private void Foo() { }

        // only this and derived classes
        protected void Bar() { }

        //only in this assembly
        internal void Daw() { }

        
    }

    //Poodle inherits Dog.
    class Poodle: Dog
    {
        //after typing "this", you get "Bar" but not "Foo!"
        void x() {
            this.Speak(2);
        }
    }
}
