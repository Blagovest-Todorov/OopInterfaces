using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.InterfaceOop
{

    // Console.WriteLine("Hello World!");
    // an interface provide a contract along with the class, to waht they both will 
    // provide to the Application
    // an Interface declares the properties and methods it is up to the class to define 
    // what exactly the methods will do .


    public interface Guru99Interface   //declare the public interface;
    {
         public void SetTutotial(int pID, string pName);
         public string GetTutorial();   //into interface the Methods and the properties are just basic declared , 
                                //but not developed , they have not block body; 
    }

    public class Guru99Tutorial : Guru99Interface    //publ;ic class extends, inherites the Interface
    {
        protected int TutorialID;
        protected string TutorialName;

        //public void SetTutorial(int pID, string pName)
        //{
        //    TutorialID = pID;
        //    TutorialName = pName;
        //}

        //public string GetTutorial()
        //{
        //    return TutorialName;
        //}

        //static void Main(string[] args)
        //{
        //    Guru99Tutorial pTutor = new Guro99Tutorial();
        //    pTutor.SetTutorial(1, ".Net by Guru99");
        //    Console.WriteLine(pTutor.GetTutorial());
        //    Console.ReadKey();

        //}

        //public void SetTutotial(int pID, string pName)
        //{
        //    throw new NotImplementedException();
        //}
        public string GetTutorial()
        {
            return TutorialName;
        }

        public void SetTutotial(int pID, string pName)
        {
            TutorialID = pID;
            TutorialName = pName;

        }
    } // the interface is a contract what the class should comlpy with;
      // the interface declares what are the operations that the class should perform.
      // must automatically rightlic on the class extends : interface and to click the interface implement
}

